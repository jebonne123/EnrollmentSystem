Imports MySql.Data.MySqlClient
Imports System.Data.SqlTypes
Imports System.Xml

Public Class updateform


    Public Shared sqlConnection As MySqlConnection
    Public Shared sqlCmd As MySqlCommand
    Public Shared sqlReader As MySqlDataReader
    Public Shared sqlData As DataTable
    Private bitmap As Bitmap

    Dim Query As String
    Dim Query2 As String
    Dim Query3 As String
    Dim Query4 As String
    Dim Query5 As String

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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnUpdateForm_Click(sender As Object, e As EventArgs) Handles btnUpdateForm.Click
        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=1234;database=enrollmentdb"

        Try
            sqlConnection.Open()
            Query = "Update enrollmentdb.student set STUDENT_FNAME='" & txtFirstname.Text & "',STUDENT_LNAME= '" & txtLastname.Text & "',STUDENT_MNAME='" & txtMiddlename.Text & "',STUDENT_GENDER='" & gender & "',STUDENT_BIRTHDATE='" & dateBirthdate.Text & "',
                     STUDENT_PLACE_OF_BIRTH='" & txtBirthplace.Text & "',GRADELEVEL_TOENROLL='" & cbxGradelevel.Text & "', RETURNING='"& Returning &"',WITH_LRN='"& WithLRN & "', FATHER_FNAME='"& txtFather_Fname.Text &"',FATHER_LNAME='"& txtFather_Lname.Text &"',FATHER_MNAME='"& txtFather_Mname.Text &"',FATHER_CONTACTNUM='"& txtFather_ContactNum.Text &"',MOTHER_FNAME='"& txtMother_Fname.Text &"',MOTHER_LNAME='" & txtMother_Lname.Text &"',MOTHER_MNAME='" txtMother_Mname.Text "',
                     MOTHER_CONTACTNUM='""',GUARDIAN_FNAME='""',GUARDIAN_LNAME='""',GUARDIAN_MNAME='""',GUARDIAN_CONTACTNUM='""',CURRENTHOUSESTREETNUM='""',CURRENTSTREETNAME='""',
                     CURRENTBARANGAY='""',CURRENTMUNICIPALITY='""',CURRENTPROVINCE='""',CURRENTCOUNTRY='""',CURRENTZIPCODE='""',
                     PERMANENTHOUSESTREETNUM, PERMANENTSTREETNAME,PERMANENTBARANGAY,PERMANENTMUNICIPALITY,PERMANENTPROVINCE,
                     PERMANENTCOUNTRY='""',PERMANENTZIPCODE='""',4PS_BENEFECIARY='""',4PS_HOUSEHOLDIDNUM='""',
                     LASTGRADELEVELCOMPLETED='""',LASTSCHOOLATTENDED='""',LASTSCHOOLYEARCOMPLETED='""',LASTSCHOOLID='""'"

                     
                      "', '"  "', '"  "', '"  "', '" _
                      "', '"  "', '"  "', '"  "', '" _
                     "', '"  "', '"  "', '"  "', '" _
                      "', '"  "', '" "', '" & txtMother_Mname.Text _
                     & "', '" & txtMother_ContactNum.Text & "', '" & txtGuardian_Fname.Text & "', '" & txtGuardian_Lname.Text & "', '" _
                     & txtGuardian_Mname.Text & "', '" & txtGuardian_ContactNum.Text & "', '" & txtCurrent_HouseNum.Text & "', '" _
                     & txtCurrent_StreetName.Text & "', '" & txtCurrent_Barangay.Text & "', '" & txtCurrent_MunicipalityorCity.Text & "', '" _
                     & txtCurrent_Province.Text & "', '" & txtCurrent_Country.Text & "', '" & txtCurrent_ZipCode.Text & "', '" _
                     & txtPerm_HouseNum.Text & "', '" & txtPerm_StreetName.Text & "', '" & txtPerm_Barangay.Text & "', '" _
                     & txtPerm_MunicipalityorCity.Text & "', '" & txtPerm_Province.Text & "', '" & txtPerm_Country.Text & "', '" _
                     & txtPerm_ZipCode.Text & "', '" & FourPs & "', '" & txt4Ps.Text & "', '" & txtLastGradeLevelComp.Text & "', '" _
                     & txtLastSchoolAttended.Text & "', '" & lastSchoolYearComp.Text & "', '" & txtLastSchoolID.Text & "'

            sqlCmd = New MySqlCommand(Query, sqlConnection)
            sqlReader = sqlCmd.ExecuteReader

            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            sqlConnection.Open()
            Query2 = "Update elementaryenrollmentandmanagementsystem.4ps set 4Ps_Benefeciary= '" & FourPs & "',4Ps_HouseholdIDNum= '" & txt4Ps.Text & "' where enrollForm_ID= '" & foreignID & "' "
            sqlCmd = New MySqlCommand(Query2, sqlConnection)
            sqlReader = sqlCmd.ExecuteReader

            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            sqlConnection.Open()
            Query3 = "Update elementaryenrollmentandmanagementsystem.address set currentHouseStreetNum='" & txtCurrent_HouseNum.Text & "',currentStreetName= '" & txtCurrent_StreetName.Text & "',currentBarangay= '" & txtCurrent_Barangay.Text & "',currentMunicipality= '" & txtCurrent_MunicipalityorCity.Text & "',currentProvince= '" & txtCurrent_Province.Text & "',currentCountry= '" & txtCurrent_Country.Text & "',currentZipcode= '" & txtCurrent_ZipCode.Text & "',permanentHouseStreetNum= '" & txtPerm_HouseNum.Text & "',permanentStreetName= '" & txtPerm_StreetName.Text & "',permanentBarangay= '" & txtPerm_Barangay.Text & "',permanentMunicipality= '" & txtPerm_MunicipalityorCity.Text & "',permanentProvince= '" & txtPerm_Province.Text & "',permanentCountry= '" & txtPerm_Country.Text & "',permanentZipcode= '" & txtPerm_ZipCode.Text & "' where enrollForm_ID='" & foreignID & "' "
            sqlCmd = New MySqlCommand(Query3, sqlConnection)
            sqlReader = sqlCmd.ExecuteReader

            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            sqlConnection.Open()
            Query4 = "Update elementaryenrollmentandmanagementsystem.parent_guardian_information set father_Fname= '" & txtFather_Fname.Text & "',father_Lname= '" & txtFather_Lname.Text & "',father_Mname= '" & txtFather_Mname.Text & "',father_ContactNum= '" & txtFather_ContactNum.Text & "',mother_Fname= '" & txtMother_Fname.Text & "',mother_Lname= '" & txtMother_Lname.Text & "',mother_Mname= '" & txtMother_Mname.Text & "',mother_ContactNum= '" & txtMother_ContactNum.Text & "',Guardian_Fname= '" & txtGuardian_Fname.Text & "',Guardian_Lname= '" & txtGuardian_Lname.Text & "',Guardian_Mname= '" & txtGuardian_Mname.Text & "',Guardian_ContactNum= '" & txtGuardian_ContactNum.Text & "' where enrollForm_ID='" & foreignID & "' "
            sqlCmd = New MySqlCommand(Query4, sqlConnection)
            sqlReader = sqlCmd.ExecuteReader

            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            sqlConnection.Open()
            Query5 = "Update elementaryenrollmentandmanagementsystem.returning_and_transferee set lastGradeLevelCompleted= '" & txtLastGradeLevelComp.Text & "',lastSchoolAttended= '" & txtLastSchoolAttended.Text & "',lastschoolYearCompleted= '" & lastSchoolYearComp.Text & "',lastSchoolID= '" & txtLastSchoolID.Text & "' where enrollForm_ID='" & foreignID & "' "
            sqlCmd = New MySqlCommand(Query5, sqlConnection)
            sqlReader = sqlCmd.ExecuteReader

            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConnection.Dispose()
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

        Dim iConfirmation As DialogResult

        iConfirmation = MessageBox.Show("Do you want to submit the updated form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iConfirmation = DialogResult.Yes Then
            MessageBox.Show("Form submitted!")
            Me.Close()
            previewform.Show()
        Else

        End If

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
            For Each txt In Panel11.Controls
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
            For Each txt In Panel14.Controls
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

    End Sub
End Class