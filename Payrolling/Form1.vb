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
End Class
