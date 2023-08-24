Imports MySql.Data.MySqlClient
Public Class classlist

    Public Shared MysqlConn As MySqlConnection
    Public Shared MysqlCmd As MySqlCommand
    Public Shared Reader As MySqlDataReader
    Public Shared Mysqldata As DataTable
    Public Shared Mysqladapter As MySqlDataAdapter

    Dim Query As String
    Dim Ans1 As Boolean
    Dim Ans2 As Boolean

    Private Sub updateTable()

        Ans1 = True
        Ans2 = False

        Mysqldata = New DataTable
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1234;database=enrollmentdb"

        MysqlConn.Open()
        Query = "SELECT student_lrn, student_fname, student_lname, student_mname, gradelevel, section, teacher_lname FROM student NARURAL JOIN academic_year NATURAL JOIN enrollment JOIN homeroom ON enrollment.homeroom_id = homeroom.homeroom_id JOIN section ON section.section_id = homeroom.section_id JOIN teacher ON homeroom.teacher_id = teacher.teacher_id NATURAL JOIN grade_level WHERE ay_status = 1 and student_status=0 and enrollmentform_status=1"
        MysqlCmd = New MySqlCommand(Query, MysqlConn)
        Reader = MysqlCmd.ExecuteReader

        Mysqldata.Load(Reader)
        Reader.Close()
        MysqlConn.Close()
        DataGridView1.DataSource = Mysqldata

    End Sub

    Private Sub classlist_Load(sender As Object, e As EventArgs)

        updateTable()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        updateTable()
    End Sub
End Class