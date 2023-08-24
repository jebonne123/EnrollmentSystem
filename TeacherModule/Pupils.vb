Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Pupils

    Public Shared MysqlConn As MySqlConnection
    Public Shared MysqlCmd As MySqlCommand
    Public Shared Reader As MySqlDataReader
    Public Shared Mysqldata As DataTable
    Public Shared Mysqladapter As MySqlDataAdapter

    Dim Query As String
    Dim Query2 As String

    Private Sub updateTable()

        Mysqldata = New DataTable
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1234;database=enrollmentdb"

        MysqlConn.Open()
        Query = "SELECT STUDENT_LRN, STUDENT_FNAME, STUDENT_LNAME, STUDENT_MNAME, STUDENT_GENDER, STUDENT_BIRTHDATE, STUDENT_PLACE_OF_BIRTH from student where ENROLLMENTFORM_STATUS=TRUE and STUDENT_STATUS=FALSE"
        MysqlCmd = New MySqlCommand(Query, MysqlConn)
        Reader = MysqlCmd.ExecuteReader

        Mysqldata.Load(Reader)
        Reader.Close()
        MysqlConn.Close()
        DataGridView1.DataSource = Mysqldata

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        updateTable()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress

        Try
            If Asc(e.KeyChar) - 13 Then
                Dim dv As DataView
                dv = Mysqldata.DefaultView
                dv.RowFilter = String.Format("firstName like '%{0}%'", txtSearch.Text)
                DataGridView1.DataSource = dv.ToTable()
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class