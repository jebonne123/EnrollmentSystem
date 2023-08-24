Imports MySql.Data.MySqlClient
Imports System.Data.SqlTypes
Imports System.Diagnostics.Eventing

Public Class Dashboard

    Public Shared MysqlConn As MySqlConnection
    Public Shared MysqlCmd As MySqlCommand
    Public Shared Reader As MySqlDataReader
    Public Shared Mysqldata As DataTable
    Public Shared Mysqladapter As MySqlDataAdapter

    Dim Count As Integer
    Dim Count2 As Integer
    Dim Count3 As Integer
    Dim Query2 As String

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Dispose()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1234;database=enrollmentdb"

        If MysqlConn.State = ConnectionState.Closed Then
            MysqlConn.Open()
        End If
        Query2 = "SELECT COUNT(*) from teacher"
        MysqlCmd = New MySqlCommand(Query2, MysqlConn)
        Reader = MysqlCmd.ExecuteReader
        Reader.Read()
        Count = Reader("COUNT(*)")
        MysqlConn.Close()
        lblTotalTeacher.Text = Count

        If MysqlConn.State = ConnectionState.Closed Then
            MysqlConn.Open()
        End If
        Query2 = "SELECT COUNT(STUDENT_CODE) from student where ENROLLMENTFORM_STATUS=TRUE"
        MysqlCmd = New MySqlCommand(Query2, MysqlConn)
        Reader = MysqlCmd.ExecuteReader
        Reader.Read()
        Count2 = Reader("COUNT(STUDENT_CODE)")
        MysqlConn.Close()
        lblTotalStudentValue.Text = Count2

        If MysqlConn.State = ConnectionState.Closed Then
            MysqlConn.Open()
        End If
        Query2 = "SELECT COUNT(STUDENT_CODE) from student where ENROLLMENTFORM_STATUS=FALSE and STUDENT_STATUS=TRUE"
        MysqlCmd = New MySqlCommand(Query2, MysqlConn)
        Reader = MysqlCmd.ExecuteReader
        Reader.Read()
        Count3 = Reader("COUNT(STUDENT_CODE)")
        MysqlConn.Close()
        lblTotalPending.Text = Count3
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1234;database=enrollmentdb"

        If MysqlConn.State = ConnectionState.Closed Then
            MysqlConn.Open()
        End If
        Query2 = "SELECT COUNT(*) from teacher"
        MysqlCmd = New MySqlCommand(Query2, MysqlConn)
        Reader = MysqlCmd.ExecuteReader
        Reader.Read()
        Count = Reader("COUNT(*)")
        MysqlConn.Close()
        lblTotalTeacher.Text = Count

        If MysqlConn.State = ConnectionState.Closed Then
            MysqlConn.Open()
        End If
        Query2 = "SELECT COUNT(STUDENT_CODE) from student where ENROLLMENTFORM_STATUS=TRUE"
        MysqlCmd = New MySqlCommand(Query2, MysqlConn)
        Reader = MysqlCmd.ExecuteReader
        Reader.Read()
        Count2 = Reader("COUNT(STUDENT_CODE)")
        MysqlConn.Close()
        lblTotalStudentValue.Text = Count2

        If MysqlConn.State = ConnectionState.Closed Then
            MysqlConn.Open()
        End If
        Query2 = "SELECT COUNT(STUDENT_CODE) from student where ENROLLMENTFORM_STATUS=FALSE and STUDENT_STATUS=TRUE"
        MysqlCmd = New MySqlCommand(Query2, MysqlConn)
        Reader = MysqlCmd.ExecuteReader
        Reader.Read()
        Count3 = Reader("COUNT(STUDENT_CODE)")
        MysqlConn.Close()
        lblTotalPending.Text = Count3

    End Sub

End Class