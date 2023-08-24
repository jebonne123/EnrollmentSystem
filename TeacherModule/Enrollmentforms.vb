Imports MySql.Data.MySqlClient
Public Class Enrollmentforms

    Public Shared MysqlConn As MySqlConnection
    Public Shared MysqlCmd As MySqlCommand
    Public Shared Reader As MySqlDataReader
    Public Shared Mysqldata As DataTable
    Public Shared Mysqladapter As MySqlDataAdapter

    Dim Query As String
    Dim Query2 As String

    Dim currdate As String
    Dim Teacher_ID As Integer
    Dim Section_idOLD As Integer
    Dim Section_idNEW As Integer
    Dim Homeroom_IDOLD As Integer
    Dim Homeroom_IDNEW As Integer
    Dim aycode As Integer



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Dispose()
    End Sub

    Private Sub updateTable1()

        Mysqldata = New DataTable
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1234;database=enrollmentdb"

        MysqlConn.Open()
        Query = "SELECT STUDENT_FNAME as 'First name', STUDENT_LNAME as 'Last name', STUDENT_MNAME as 'Middle name', STUDENT_GENDER as Gender, STUDENT_BIRTHDATE as Birthday,STUDENT_PLACE_OF_BIRTH as 'Place of birth', GRADELEVEL_TOENROLL as 'Grade level to enroll', STUDENT_CODE as Scode from enrollmentdb.student where ENROLLMENTFORM_STATUS=FALSE and STUDENT_STATUS=TRUE"
        MysqlCmd = New MySqlCommand(Query, MysqlConn)
        Reader = MysqlCmd.ExecuteReader

        Mysqldata.Load(Reader)
        Reader.Close()
        MysqlConn.Close()
        DataGridView2.DataSource = Mysqldata

    End Sub

    Private Sub updateTable2()

        Mysqldata = New DataTable
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1234;database=enrollmentdb"

        MysqlConn.Open()
        Query = "SELECT STUDENT_FNAME as 'First name', STUDENT_LNAME as 'Last name', STUDENT_MNAME as 'Middle name', STUDENT_GENDER as Gender, STUDENT_BIRTHDATE as Birthday,STUDENT_PLACE_OF_BIRTH as 'Place of birth', GRADELEVEL_TOENROLL as 'Grade level to enroll', STUDENT_CODE as Scode from enrollmentdb.student where ENROLLMENTFORM_STATUS=FALSE and STUDENT_STATUS=FALSE"
        MysqlCmd = New MySqlCommand(Query, MysqlConn)
        Reader = MysqlCmd.ExecuteReader

        Mysqldata.Load(Reader)
        Reader.Close()
        MysqlConn.Close()
        DataGridView1.DataSource = Mysqldata

    End Sub

    Private Sub Enrollmentforms_Load(sender As Object, e As EventArgs)
        updateTable1()
        updateTable2()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefreshNew.Click
        updateTable1()
    End Sub

    Private Sub btnRefreshOld_Click(sender As Object, e As EventArgs) Handles btnRefreshOld.Click
        updateTable2()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Mysqldata = New DataTable
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1234;database=enrollmentdb"

        MysqlConn.Open()
        Query = "SELECT STUDENT_FNAME as 'First name', STUDENT_LNAME as 'Last name', STUDENT_MNAME as 'Middle name', STUDENT_GENDER as Gender, STUDENT_BIRTHDATE as Birthday,STUDENT_PLACE_OF_BIRTH as 'Place of birth', GRADELEVEL_TOENROLL as 'Grade level to enroll', STUDENT_CODE as Scode from enrollmentdb.student where (ENROLLMENTFORM_STATUS=FALSE and STUDENT_STATUS=FALSE) and (STUDENT_FNAME='" & txtOldStudentFname.Text & "' or STUDENT_LNAME='" & txtOldStudentLname.Text & "' or STUDENT_MNAME='" & txtOldStudentMname.Text & "')"
        MysqlCmd = New MySqlCommand(Query, MysqlConn)
        Reader = MysqlCmd.ExecuteReader

        Mysqldata.Load(Reader)
        Reader.Close()
        MysqlConn.Close()
        DataGridView1.DataSource = Mysqldata

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Mysqldata = New DataTable
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1234;database=enrollmentdb"

        MysqlConn.Open()
        Query = "SELECT STUDENT_FNAME as 'First name', STUDENT_LNAME as 'Last name', STUDENT_MNAME as 'Middle name', STUDENT_GENDER as Gender, STUDENT_BIRTHDATE as Birthday,STUDENT_PLACE_OF_BIRTH as 'Place of birth', GRADELEVEL_TOENROLL as 'Grade level to enroll', STUDENT_CODE as Scode from enrollmentdb.student where (ENROLLMENTFORM_STATUS=FALSE and STUDENT_STATUS=TRUE) and STUDENT_FNAME like '" & txtsearch.Text & "%'"
        MysqlCmd = New MySqlCommand(Query, MysqlConn)
        Reader = MysqlCmd.ExecuteReader

        Mysqldata.Load(Reader)
        Reader.Close()
        MysqlConn.Close()
        DataGridView2.DataSource = Mysqldata

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        Try
            txtNewStudentFirstName.Text = DataGridView2.SelectedRows(0).Cells(0).Value.ToString
            txtNewStudentLastName.Text = DataGridView2.SelectedRows(0).Cells(1).Value.ToString
            txtNewStudentMiddleName.Text = DataGridView2.SelectedRows(0).Cells(2).Value.ToString
            txtNewStudentGender.Text = DataGridView2.SelectedRows(0).Cells(3).Value.ToString
            txtNewStudentBirthdate.Text = DataGridView2.SelectedRows(0).Cells(4).Value.ToString
            txtNewStudentPlaceOfBirth.Text = DataGridView2.SelectedRows(0).Cells(5).Value.ToString
            txtNewStudentGradeLevelToEnroll.Text = DataGridView2.SelectedRows(0).Cells(6).Value.ToString
            txtNewSCode.Text = DataGridView2.SelectedRows(0).Cells(7).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        txtOldStudentFname.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        txtOldStudentLname.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
        txtOldStudentMname.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
        txtOldSCode.Text = DataGridView1.SelectedRows(0).Cells(7).Value.ToString

    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1234;database=enrollmentdb"

        If MysqlConn.State = ConnectionState.Closed Then
            MysqlConn.Open()
        End If
        Query2 = "select TEACHER_ID from enrollmentdb.teacher where TEACHER_PASSWORD='" & txtTeacherPassword.Text & "'"
        MysqlCmd = New MySqlCommand(Query2, MysqlConn)
        Reader = MysqlCmd.ExecuteReader
        Reader.Read()
        Teacher_ID = Reader("TEACHER_ID")
        MysqlConn.Close()
        txtshowtID.Text = Teacher_ID

        If String.IsNullOrEmpty(cbxSectionOldStudent.Text) = False And String.IsNullOrEmpty(cbxGradeLevelOldStudent.Text) = False Then
            If MysqlConn.State = ConnectionState.Closed Then
                MysqlConn.Open()
            End If
            Query2 = "select SECTION_ID from enrollmentdb.section where GRADELEVEL_CODE='" & cbxGradeLevelOldStudent.Text & "' and SECTION='" & cbxSectionOldStudent.Text & "'"
            MysqlCmd = New MySqlCommand(Query2, MysqlConn)
            Reader = MysqlCmd.ExecuteReader
            Reader.Read()
            Section_idOLD = Reader("SECTION_ID")
            MysqlConn.Close()
            txtShowSectOLDID.Text = Section_idOLD

            If MysqlConn.State = ConnectionState.Closed Then
                MysqlConn.Open()
            End If
            Query2 = "select HOMEROOM_ID from enrollmentdb.homeroom where SECTION_ID='" & txtShowSectOLDID.Text & "'"
            MysqlCmd = New MySqlCommand(Query2, MysqlConn)
            Reader = MysqlCmd.ExecuteReader
            Reader.Read()
            Homeroom_IDOLD = Reader("HOMEROOM_ID")
            MysqlConn.Close()
            txtHomeroomIDShow.Text = Homeroom_IDOLD
        End If

        If String.IsNullOrEmpty(cbxNewStudentSection.Text) = False And String.IsNullOrEmpty(txtNewStudentGradeLevelToEnroll.Text) = False Then
            If MysqlConn.State = ConnectionState.Closed Then
                MysqlConn.Open()
            End If
            Query2 = "select SECTION_ID from enrollmentdb.section where GRADELEVEL_CODE='" & txtNewStudentGradeLevelToEnroll.Text & "' and SECTION='" & cbxNewStudentSection.Text & "'"
            MysqlCmd = New MySqlCommand(Query2, MysqlConn)
            Reader = MysqlCmd.ExecuteReader
            Reader.Read()
            Section_idNEW = Reader("SECTION_ID")
            MysqlConn.Close()
            txtSectionNEWID.Text = Section_idNEW

            If MysqlConn.State = ConnectionState.Closed Then
                MysqlConn.Open()
            End If
            Query2 = "select HOMEROOM_ID from enrollmentdb.homeroom where SECTION_ID='" & txtSectionNEWID.Text & "'"
            MysqlCmd = New MySqlCommand(Query2, MysqlConn)
            Reader = MysqlCmd.ExecuteReader
            Reader.Read()
            Homeroom_IDNEW = Reader("HOMEROOM_ID")
            MysqlConn.Close()
            txtHomeroomIDShow.Text = Homeroom_IDNEW
        End If

        If MysqlConn.State = ConnectionState.Closed Then
            MysqlConn.Open()
        End If
        Query2 = "select AY_CODE from enrollmentdb.academic_year where AY_STATUS=TRUE"
        MysqlCmd = New MySqlCommand(Query2, MysqlConn)
        Reader = MysqlCmd.ExecuteReader
        Reader.Read()
        aycode = Reader("AY_CODE")
        MysqlConn.Close()
        txtshowAycode.Text = aycode

        txtShowDate.Text = dateCurrDate.Text.ToString

        If String.IsNullOrEmpty(txtNewSCode.Text) = False And String.IsNullOrEmpty(cbxNewStudentSection.Text) = False And String.IsNullOrEmpty(txtNewStudentGradeLevelToEnroll.Text) = False Then
            Try
                MysqlConn.Open()
                Query = "update enrollmentdb.student set ENROLLMENTFORM_STATUS=TRUE, STUDENT_STATUS=FALSE where STUDENT_CODE='" & txtNewSCode.Text & "'"
                MysqlCmd = New MySqlCommand(Query, MysqlConn)
                Reader = MysqlCmd.ExecuteReader
                MysqlConn.Close()

                confirmenrollmentNew.txtConfirmstudentNewCode.Text = txtNewSCode.Text
                confirmenrollmentNew.txtshowtID.Text = txtshowtID.Text
                confirmenrollmentNew.txtSectionNEWID.Text = txtSectionNEWID.Text
                confirmenrollmentNew.txtHomeroomIDShow.Text = txtHomeroomIDShow.Text
                confirmenrollmentNew.txtshowAycode.Text = txtshowAycode.Text
                confirmenrollmentNew.txtShowDate.Text = txtShowDate.Text

                MessageBox.Show("NEW")
                confirmenrollmentNew.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        If String.IsNullOrEmpty(txtOldSCode.Text) = False And String.IsNullOrEmpty(cbxSectionOldStudent.Text) = False And String.IsNullOrEmpty(cbxGradeLevelOldStudent.Text) = False Then
            Try
                MysqlConn.Open()
                Query = "update enrollmentdb.student set ENROLLMENTFORM_STATUS=TRUE, STUDENT_STATUS=FALSE where STUDENT_CODE='" & txtOldSCode.Text & "'"
                MysqlCmd = New MySqlCommand(Query, MysqlConn)
                Reader = MysqlCmd.ExecuteReader
                MysqlConn.Close()

                confirmenrollmentOLD.txtOldStudentSCode.Text = txtOldSCode.Text
                confirmenrollmentOLD.txtshowtID.Text = txtshowtID.Text
                confirmenrollmentOLD.txtShowSectOLDID.Text = txtShowSectOLDID.Text
                confirmenrollmentOLD.txtHomeroomIDShow.Text = txtHomeroomIDShow.Text
                confirmenrollmentOLD.txtshowAycode.Text = txtshowAycode.Text
                confirmenrollmentOLD.txtShowDate.Text = txtShowDate.Text

                MessageBox.Show("OLD")
                confirmenrollmentOLD.Show()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        Try
            For Each txt In Panel2.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            For Each txt In Panel2.Controls
                If TypeOf txt Is ComboBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            For Each txt In Panel7.Controls
                If TypeOf txt Is ComboBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        Try
            For Each txt In Panel7.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            For Each txt In Panel8.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        updateTable1()
        updateTable2()

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

        Try
            For Each txt In Panel2.Controls
                If TypeOf txt Is ComboBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            For Each txt In Panel7.Controls
                If TypeOf txt Is ComboBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            For Each txt In Panel7.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtshowtID_TextChanged(sender As Object, e As EventArgs) Handles txtshowtID.TextChanged

    End Sub
End Class