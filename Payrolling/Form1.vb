Imports MaterialSkin
Imports System.Data.OleDb

Public Class frmPayroll
    Inherits MaterialSkin.Controls.MaterialForm
    Private connectionString = My.Settings.ConnectionString

    Private Sub frmPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeID()
    End Sub

    Private Sub LoadEmployeeID()
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT TOP 1 * FROM Employees WHERE [Active] = True ORDER BY EmployeeID"
                Dim command As New OleDbCommand(query, connection)

                Using reader As OleDbDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        IDLabelText.Text = reader("EmployeeID").ToString()
                        lblFirstName.Text = reader("FirstName").ToString()
                        lblSecondName.Text = reader("LastName").ToString()
                        lblDepartment.Text = reader("Department").ToString()
                        lblPosition.Text = reader("Position").ToString()
                        lblRate.Text = Convert.ToDecimal(reader("HourlyRate")).ToString("C")
                    Else
                        MessageBox.Show("No records in Emplyees table.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
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

        Dim difference As TimeSpan = (endDate - startDate)
        Dim totalDays As Integer = CInt(difference.TotalDays)

        If totalDays < 0 Then
            MessageBox.Show($"Unless your employee is a time traveller, I don't see how they could have achieved working  {totalDays} days. Check your math!")
        Else
            lblDaysWorked.Text = totalDays.ToString()
        End If
    End Sub
End Class
