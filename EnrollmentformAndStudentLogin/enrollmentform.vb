Imports MySql.Data.MySqlClient

Public Class enrollmentform

    Public Shared sqlConnection As MySqlConnection
    Public Shared sqlCmd As MySqlCommand
    Public Shared sqlReader As MySqlDataReader
    Public Shared sqlData As DataTable
    Private bitmap As Bitmap

    Dim Query As String

    Dim gender As String
    Dim FourPs As String
    Dim Returning As String
    Dim WithLRN As String
    Dim foreignID As String

    Private Sub rbtnMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub rbtnFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFemale.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub rbtnYes_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnYes.CheckedChanged
        FourPs = "Yes"
    End Sub

    Private Sub rbtnNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnNo.CheckedChanged
        FourPs = "No"
    End Sub

    Private Sub rbtnRETURNINGYES_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRETURNINGYES.CheckedChanged
        Returning = "Yes"
    End Sub

    Private Sub rbtnRETURNINGNO_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRETURNINGNO.CheckedChanged
        Returning = "No"
    End Sub

    Private Sub rbtnLRNYES_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLRNYES.CheckedChanged
        WithLRN = "Yes"
    End Sub

    Private Sub rbtnLRNNO_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLRNNO.CheckedChanged
        WithLRN = "No"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=1234;database=enrollmentdb"

        Try
            sqlConnection.Open()
            Query = "Insert into enrollmentdb.student(STUDENT_FNAME,STUDENT_LNAME,STUDENT_MNAME,STUDENT_GENDER,STUDENT_BIRTHDATE,
                     STUDENT_PLACE_OF_BIRTH,GRADELEVEL_TOENROLL, RETURNING,WITH_LRN, FATHER_FNAME,FATHER_LNAME,FATHER_MNAME,FATHER_CONTACTNUM,MOTHER_FNAME,MOTHER_LNAME,MOTHER_MNAME,
                     MOTHER_CONTACTNUM,GUARDIAN_FNAME,GUARDIAN_LNAME,GUARDIAN_MNAME,GUARDIAN_CONTACTNUM,CURRENTHOUSESTREETNUM,CURRENTSTREETNAME,
                     CURRENTBARANGAY,CURRENTMUNICIPALITY,CURRENTPROVINCE,CURRENTCOUNTRY,CURRENTZIPCODE,
                     PERMANENTHOUSESTREETNUM, PERMANENTSTREETNAME,PERMANENTBARANGAY,PERMANENTMUNICIPALITY,PERMANENTPROVINCE,
                     PERMANENTCOUNTRY,PERMANENTZIPCODE,4PS_BENEFECIARY,4PS_HOUSEHOLDIDNUM,
                     LASTGRADELEVELCOMPLETED,LASTSCHOOLATTENDED,LASTSCHOOLYEARCOMPLETED,LASTSCHOOLID) values ( '" _
                     & txtFirstname.Text & "', '" & txtLastname.Text & "', '" & txtMiddlename.Text & "', '" & gender & "', '" _
                     & dateBirthdate.Text & "', '" & txtBirthplace.Text & "', '" & cbxGradelevel.Text & "', '" & Returning & "', '" _
                     & WithLRN & "', '" & txtFather_Fname.Text & "', '" & txtFather_Lname.Text & "', '" & txtFather_Mname.Text & "', '" _
                     & txtFather_ContactNum.Text & "', '" & txtMother_Fname.Text & "', '" & txtMother_Lname.Text & "', '" & txtMother_Mname.Text _
                     & "', '" & txtMother_ContactNum.Text & "', '" & txtGuardian_Fname.Text & "', '" & txtGuardian_Lname.Text & "', '" _
                     & txtGuardian_Mname.Text & "', '" & txtGuardian_ContactNum.Text & "', '" & txtCurrent_HouseNum.Text & "', '" _
                     & txtCurrent_StreetName.Text & "', '" & txtCurrent_Barangay.Text & "', '" & txtCurrent_MunicipalityorCity.Text & "', '" _
                     & txtCurrent_Province.Text & "', '" & txtCurrent_Country.Text & "', '" & txtCurrent_ZipCode.Text & "', '" _
                     & txtPerm_HouseNum.Text & "', '" & txtPerm_StreetName.Text & "', '" & txtPerm_Barangay.Text & "', '" _
                     & txtPerm_MunicipalityorCity.Text & "', '" & txtPerm_Province.Text & "', '" & txtPerm_Country.Text & "', '" _
                     & txtPerm_ZipCode.Text & "', '" & FourPs & "', '" & txt4Ps.Text & "', '" & txtLastGradeLevelComp.Text & "', '" _
                     & txtLastSchoolAttended.Text & "', '" & lastSchoolYearComp.Text & "', '" & txtLastSchoolID.Text & "')"

            sqlCmd = New MySqlCommand(Query, sqlConnection)
            sqlReader = sqlCmd.ExecuteReader

            MessageBox.Show("Form submitted!")

            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        previewform.txtFirstname.Text = txtFirstname.Text
        previewform.txtLastname.Text = txtLastname.Text
        previewform.txtMiddlename.Text = txtMiddlename.Text
        previewform.txtSex.Text = gender
        previewform.txtIs4Ps.Text = FourPs
        previewform.txtIsWithLRN.Text = WithLRN
        previewform.txtisBalikAral.Text = Returning
        previewform.txtGradelevel.Text = cbxGradelevel.Text
        previewform.txtBirthdate.Text = dateBirthdate.Value
        previewform.txtBirthplace.Text = txtBirthplace.Text
        previewform.txt4Ps.Text = txt4Ps.Text
        previewform.txtstudentLRN.Text = txtstudentLRN.Text

        previewform.txtCurrent_HouseNum.Text = txtCurrent_HouseNum.Text
        previewform.txtCurrent_StreetName.Text = txtCurrent_StreetName.Text
        previewform.txtCurrent_Barangay.Text = txtCurrent_Barangay.Text
        previewform.txtCurrent_MunicipalityorCity.Text = txtCurrent_MunicipalityorCity.Text
        previewform.txtCurrent_Province.Text = txtCurrent_Province.Text
        previewform.txtCurrent_Country.Text = txtCurrent_Country.Text
        previewform.txtCurrent_ZipCode.Text = txtCurrent_ZipCode.Text
        previewform.txtPerm_HouseNum.Text = txtPerm_HouseNum.Text
        previewform.txtPerm_StreetName.Text = txtPerm_StreetName.Text
        previewform.txtPerm_Barangay.Text = txtPerm_Barangay.Text
        previewform.txtPerm_MunicipalityorCity.Text = txtPerm_MunicipalityorCity.Text
        previewform.txtPerm_Province.Text = txtPerm_Province.Text
        previewform.txtPerm_Country.Text = txtPerm_Country.Text
        previewform.txtPerm_ZipCode.Text = txtPerm_ZipCode.Text

        previewform.txtFather_Fname.Text = txtFather_Fname.Text
        previewform.txtFather_Lname.Text = txtFather_Lname.Text
        previewform.txtFather_Mname.Text = txtFather_Mname.Text
        previewform.txtFather_ContactNum.Text = txtFather_ContactNum.Text
        previewform.txtMother_Fname.Text = txtMother_Fname.Text
        previewform.txtMother_Lname.Text = txtMother_Lname.Text
        previewform.txtMother_Mname.Text = txtMother_Mname.Text
        previewform.txtMother_ContactNum.Text = txtMother_ContactNum.Text
        previewform.txtGuardian_Fname.Text = txtGuardian_Fname.Text
        previewform.txtGuardian_Lname.Text = txtGuardian_Lname.Text
        previewform.txtGuardian_Mname.Text = txtGuardian_Mname.Text
        previewform.txtGuardian_ContactNum.Text = txtGuardian_ContactNum.Text

        previewform.txtLastGradeLevelComp.Text = txtLastGradeLevelComp.Text
        previewform.txtLastSchoolAttended.Text = txtLastSchoolAttended.Text
        previewform.txtLastSchoolYearComp.Text = txtLastSchoolYearComp.Text
        previewform.txtLastSchoolID.Text = txtLastSchoolID.Text

        Me.Hide()
        previewform.Show()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Try
            For Each txt In Panel1.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            For Each txt In Panel10.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            For Each txt In Panel12.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            For Each txt In Panel11.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            For Each txt In Panel14.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class