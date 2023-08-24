Imports System.Data.SqlTypes
Imports System.Xml
Imports MySql.Data.MySqlClient

Public Class enrollmentform

    Public Shared MysqlConn As MySqlConnection
    Public Shared MysqlCmd As MySqlCommand
    Public Shared Reader As MySqlDataReader
    Public Shared Query As String
    Public Shared Mysqldata As DataTable

    Dim Query2 As String
    Dim Query3 As String
    Dim aycode As Integer
    Dim Sectioncode As Integer
    Dim gradelevelCode As Integer

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Dispose()
    End Sub

    Private Sub updateTable()

        Mysqldata = New DataTable
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1234;database=elementaryenrollmentandmanagementsystem"

        MysqlConn.Open()
        Query = "SELECT Fname as Firstname, Lname as Lastname, Mname as Middlename, Gender, Birthdate as Birthday, Birthplace, Gradelevel, enrollForm_ID from elementaryenrollmentandmanagementsystem.enrollment_form where enrollForm_Status=FALSE"
        MysqlCmd = New MySqlCommand(Query, MysqlConn)
        Reader = MysqlCmd.ExecuteReader

        Mysqldata.Load(Reader)
        Reader.Close()
        MysqlConn.Close()
        DataGridView1.DataSource = Mysqldata

    End Sub

    Private Sub enrollmentform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        updateTable()

    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1234;database=elementaryenrollmentandmanagementsystem"

        Try
            MysqlConn.Open()
            Query = "Insert into elementaryenrollmentandmanagementsystem.student(Student_LRN, student_Fname,  student_Lname, student_Mname, student_Gender, student_Birthdate, student_PlaceOfBirth) values ('" & txtStudentID.Text & "','" & txtFirstname.Text & "','" & txtLastname.Text & "','" & txtMiddlename.Text & "','" & txtGender.Text & "','" & txtBirthdate.Text & "', '" & txtPlaceOfBirth.Text & "')"
            MysqlCmd = New MySqlCommand(Query, MysqlConn)
            Reader = MysqlCmd.ExecuteReader

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        If MysqlConn.State = ConnectionState.Closed Then
            MysqlConn.Open()
        End If
        Query2 = "select SY_Code from school_year where SY_Status=TRUE"
        MysqlCmd = New MySqlCommand(Query2, MysqlConn)
        Reader = MysqlCmd.ExecuteReader
        Reader.Read()
        aycode = Reader("SY_Code")
        MysqlConn.Close()

        If MysqlConn.State = ConnectionState.Closed Then
            MysqlConn.Open()
        End If
        Query3 = "select gradelevel_Code from grade_level where level= '" & txtGradelevel.Text & "'"
        MysqlCmd = New MySqlCommand(Query3, MysqlConn)
        Reader = MysqlCmd.ExecuteReader
        Reader.Read()
        gradelevelCode = Reader("gradelevel_Code")
        MysqlConn.Close()

        If cbxSection.Text = "Loyal" Then
            Sectioncode = 1
        ElseIf cbxSection.Text = "Respectful" Then
            Sectioncode = 2
        End If

        Try
            MysqlConn.Open()
            Query = "Insert into elementaryenrollmentandmanagementsystem.enrollment(Student_LRN, enrollForm_ID, gradelevel_Code, SY_Code, section_ID, enrollmentDate) values ('" & txtStudentID.Text & "', '" & txtEnrollForm_ID.Text & "', '" & gradelevelCode & "', '" & aycode & "', '" & Sectioncode & "','" & dateEnrollment.Value & "')"
            MysqlCmd = New MySqlCommand(Query, MysqlConn)
            Reader = MysqlCmd.ExecuteReader

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            MysqlConn.Open()
            Query = "update enrollment_form set enrollForm_Status=TRUE where EnrollForm_ID = '" & txtEnrollForm_ID.Text & "'"
            MysqlCmd = New MySqlCommand(Query, MysqlConn)
            Reader = MysqlCmd.ExecuteReader

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            For Each txt In Panel2.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        updateTable()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1234;database=myconnector"

        Try
            MysqlConn.Open()
            Query = "Delete from myconnector.myconnector where studentID='" & txtStudentID.Text & "'"
            MysqlCmd = New MySqlCommand(Query, MysqlConn)
            Reader = MysqlCmd.ExecuteReader

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            MysqlConn.Dispose()
        End Try


        updateTable()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Try
            For Each txt In Panel2.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            txtFirstname.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            txtLastname.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            txtMiddlename.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            txtGender.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            txtBirthdate.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            txtPlaceOfBirth.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
            txtGradelevel.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString
            txtEnrollForm_ID.Text = DataGridView1.SelectedRows(0).Cells(7).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class