Imports MySql.Data.MySqlClient

Public Class Form2

    Dim MysqlConn As MySqlConnection
    Dim MysqlCmd As MySqlCommand
    Dim Query As String
    Dim Reader As MySqlDataReader
    Dim count As Integer

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1234;database=elementaryenrollmentandmanagementsystem"

        Try
            MysqlConn.Open()
            Query = "select * from elementaryenrollmentandmanagementsystem.student_login where student_Username='" & txtUsername.Text & "' and student_Password='" & txtPassword.Text & "'"
            MysqlCmd = New MySqlCommand(Query, MysqlConn)
            Reader = MysqlCmd.ExecuteReader
            count = 0

            While Reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Username and Password are correct")
                enrollmentform.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are a duplicate")
            Else
                MessageBox.Show("Username and Password are incorrect")
            End If

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
End Class