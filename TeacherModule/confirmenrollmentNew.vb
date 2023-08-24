Imports MySql.Data.MySqlClient

Public Class confirmenrollmentNew

    Public Shared MysqlConn As MySqlConnection
    Public Shared MysqlCmd As MySqlCommand
    Public Shared Reader As MySqlDataReader
    Public Shared Mysqldata As DataTable
    Public Shared Mysqladapter As MySqlDataAdapter

    Dim Query2 As String

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1234;database=enrollmentdb"

        Try
            MysqlConn.Open()
            Query2 = "INSERT INTO enrollmentdb.enrollment(STUDENT_CODE, TEACHER_ID, HOMEROOM_ID, AY_CODE, ENROLL_DATE) values ('" & txtConfirmstudentNewCode.Text & "', '" & txtshowtID.Text & "', '" & txtHomeroomIDShow.Text & "', '" & txtshowAycode.Text & "', '" & txtShowDate.Text & "')"
            MysqlCmd = New MySqlCommand(Query2, MysqlConn)
            Reader = MysqlCmd.ExecuteReader
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Me.Hide()
    End Sub

End Class