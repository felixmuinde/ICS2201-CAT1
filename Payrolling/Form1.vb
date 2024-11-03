Imports MaterialSkin
Imports System.Data.OleDb

Public Class frmPayroll
    Private connectionString = My.Settings.ConnectionString

    ' With these we can store employee data temporarily while reading from the DB and navigate through records sequentially
    Private currentRecordIndex As Integer = 0
    Private employeeDataTable As DataTable


    Private Sub frmPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeRecords()
    End Sub

    Private Sub LoadEmployeeRecords()
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT Employees.*, Accounts.AccountNumber, Accounts.BankName " &
                                  "FROM Employees " &
                                  "INNER JOIN Accounts ON Employees.EmployeeID = Accounts.EmployeeID " &
                                  "WHERE Employees.Active = True " &
                                  "ORDER BY Employees.EmployeeID"
                Dim adapter As New OleDbDataAdapter(query, connection)
                employeeDataTable = New DataTable()
                adapter.Fill(employeeDataTable)

                If employeeDataTable.Rows.Count > 0 Then
                    currentRecordIndex = 0
                    PopulateEmployeeDetails(currentRecordIndex)
                Else
                    MessageBox.Show("No active records found.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub PopulateEmployeeDetails(index As Integer)
        If employeeDataTable IsNot Nothing AndAlso employeeDataTable.Rows.Count > index AndAlso index >= 0 Then
            Dim row As DataRow = employeeDataTable.Rows(index)
            IDLabelText.Text = row("EmployeeID").ToString()
            lblFirstName.Text = row("FirstName").ToString()
            lblSecondName.Text = row("LastName").ToString()
            lblDepartment.Text = row("Department").ToString()
            lblPosition.Text = row("Position").ToString()
            lblRate.Text = Convert.ToDecimal(row("HourlyRate")).ToString()
            lblAccNo.Text = row("AccountNumber").ToString()
            lblBank.Text = row("BankName").ToString()
        End If
    End Sub


    Private Sub ClearDates()
        dtpStart.CustomFormat = ""
        dtpEnd.CustomFormat = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearchBox.Text = ""
        ClearDates()
    End Sub

    Private Sub btnCalcPay_Click(sender As Object, e As EventArgs) Handles btnCalcPay.Click
        Dim startDate As Date = dtpStart.Value
        Dim endDate As Date = dtpEnd.Value

        Dim rate As Decimal = CInt(lblRate.Text)

        Dim difference As TimeSpan = (endDate - startDate)
        Dim totalDays As Integer = CInt(difference.TotalDays) + 1

        If totalDays < 0 Then
            MessageBox.Show($"Unless your employee is a time traveller, I don't see how they could have achieved working  {totalDays} days. Check your math!")
        Else
            lblDaysWorked.Text = totalDays.ToString()
        End If
    End Sub

    Private Sub btnPreviousRecord_Click(sender As Object, e As EventArgs) Handles btnPreviousRecord.Click
        If currentRecordIndex > 0 Then
            currentRecordIndex -= 1
            PopulateEmployeeDetails(currentRecordIndex)
        Else
            MessageBox.Show("There are no more employees before this one.")
        End If
    End Sub

    Private Sub btnNextRecord_Click(sender As Object, e As EventArgs) Handles btnNextRecord.Click
        If currentRecordIndex < employeeDataTable.Rows.Count - 1 Then
            currentRecordIndex += 1
            PopulateEmployeeDetails(currentRecordIndex)
        Else
            MessageBox.Show("Congratulations! You reached the end of the records.")
        End If
    End Sub
End Class
