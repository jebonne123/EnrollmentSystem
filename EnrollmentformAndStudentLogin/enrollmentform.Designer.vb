<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enrollmentform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(enrollmentform))
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1 = New Panel()
        cbxGradelevel = New ComboBox()
        dateBirthdate = New DateTimePicker()
        Panel3 = New Panel()
        lblSex = New Label()
        rbtnMale = New RadioButton()
        rbtnFemale = New RadioButton()
        lbl = New Label()
        lblBirthplace = New Label()
        lblBirthdate = New Label()
        lblGradeLevelToEnroll = New Label()
        Label9 = New Label()
        lblBarangay = New Label()
        Label8 = New Label()
        lblZipcode = New Label()
        Label7 = New Label()
        lblCountry = New Label()
        Label6 = New Label()
        lblProvince = New Label()
        Label5 = New Label()
        lblStreetName = New Label()
        Label4 = New Label()
        lblMunicipality_City = New Label()
        Label2 = New Label()
        lblHouseNumStreet = New Label()
        Label1 = New Label()
        lblMiddlename = New Label()
        Label3 = New Label()
        lbllastName = New Label()
        txt4Ps = New TextBox()
        txtMiddlename = New TextBox()
        txtFirstname = New TextBox()
        txtLastname = New TextBox()
        txtBirthplace = New TextBox()
        txtPerm_Barangay = New TextBox()
        txtCurrent_Barangay = New TextBox()
        txtPerm_ZipCode = New TextBox()
        txtCurrent_ZipCode = New TextBox()
        txtPerm_Country = New TextBox()
        txtCurrent_Country = New TextBox()
        txtPerm_Province = New TextBox()
        txtCurrent_Province = New TextBox()
        txtPerm_StreetName = New TextBox()
        txtCurrent_StreetName = New TextBox()
        txtPerm_MunicipalityorCity = New TextBox()
        txtCurrent_MunicipalityorCity = New TextBox()
        txtPerm_HouseNum = New TextBox()
        txtCurrent_HouseNum = New TextBox()
        Panel9 = New Panel()
        lblCurrrentAddress = New Label()
        Panel6 = New Panel()
        lblpermAddress = New Label()
        Panel2 = New Panel()
        lblHeader = New Label()
        Panel5 = New Panel()
        lbl4Ps = New Label()
        rbtnYes = New RadioButton()
        rbtnNo = New RadioButton()
        Panel10 = New Panel()
        Panel11 = New Panel()
        lblGuardian = New Label()
        txtGuardian_ContactNum = New TextBox()
        txtGuardian_Mname = New TextBox()
        Label17 = New Label()
        Label14 = New Label()
        txtGuardian_Fname = New TextBox()
        Label16 = New Label()
        Label15 = New Label()
        txtGuardian_Lname = New TextBox()
        Panel12 = New Panel()
        lblMother = New Label()
        txtMother_ContactNum = New TextBox()
        txtMother_Mname = New TextBox()
        Label13 = New Label()
        Label10 = New Label()
        txtMother_Fname = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        txtMother_Lname = New TextBox()
        Panel14 = New Panel()
        Label18 = New Label()
        txtFather_ContactNum = New TextBox()
        lblFather_ContactNum = New Label()
        txtFather_Mname = New TextBox()
        Label19 = New Label()
        txtFather_Lname = New TextBox()
        lblFather_Lname = New Label()
        txtFather_Fname = New TextBox()
        lblFather_Fname = New Label()
        Label20 = New Label()
        lblLastSchoolID = New Label()
        lblLastSchoolAttend = New Label()
        lastSchoolYearComp = New Label()
        lblLastGradeLevelComp = New Label()
        txtLastSchoolID = New TextBox()
        txtLastSchoolYearComp = New TextBox()
        txtLastSchoolAttended = New TextBox()
        txtLastGradeLevelComp = New TextBox()
        Panel15 = New Panel()
        lblforReturning_Transferee = New Label()
        Panel16 = New Panel()
        Label21 = New Label()
        lblFather = New Panel()
        Panel13 = New Panel()
        Label22 = New Label()
        lblInformation = New Label()
        PictureBox1 = New PictureBox()
        btnClose = New Button()
        btnSubmit = New Button()
        btnReset = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        lblLRN = New Label()
        txtstudentLRN = New TextBox()
        rbtnLRNNO = New RadioButton()
        rbtnLRNYES = New RadioButton()
        lblWithLRN = New Label()
        Panel7 = New Panel()
        rbtnRETURNINGNO = New RadioButton()
        rbtnRETURNINGYES = New RadioButton()
        lblReturning = New Label()
        Panel8 = New Panel()
        FlowLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel9.SuspendLayout()
        Panel6.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel10.SuspendLayout()
        Panel11.SuspendLayout()
        Panel12.SuspendLayout()
        Panel14.SuspendLayout()
        Panel15.SuspendLayout()
        Panel16.SuspendLayout()
        lblFather.SuspendLayout()
        Panel13.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BackColor = SystemColors.ActiveBorder
        FlowLayoutPanel1.Controls.Add(Panel1)
        FlowLayoutPanel1.Controls.Add(Panel10)
        FlowLayoutPanel1.Location = New Point(8, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(863, 631)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gainsboro
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(cbxGradelevel)
        Panel1.Controls.Add(dateBirthdate)
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(lbl)
        Panel1.Controls.Add(lblBirthplace)
        Panel1.Controls.Add(lblBirthdate)
        Panel1.Controls.Add(lblGradeLevelToEnroll)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(lblBarangay)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(lblZipcode)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(lblCountry)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(lblProvince)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(lblStreetName)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblMunicipality_City)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(lblHouseNumStreet)
        Panel1.Controls.Add(lblLRN)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblMiddlename)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(lbllastName)
        Panel1.Controls.Add(txtstudentLRN)
        Panel1.Controls.Add(txt4Ps)
        Panel1.Controls.Add(txtMiddlename)
        Panel1.Controls.Add(txtFirstname)
        Panel1.Controls.Add(txtLastname)
        Panel1.Controls.Add(txtBirthplace)
        Panel1.Controls.Add(txtPerm_Barangay)
        Panel1.Controls.Add(txtCurrent_Barangay)
        Panel1.Controls.Add(txtPerm_ZipCode)
        Panel1.Controls.Add(txtCurrent_ZipCode)
        Panel1.Controls.Add(txtPerm_Country)
        Panel1.Controls.Add(txtCurrent_Country)
        Panel1.Controls.Add(txtPerm_Province)
        Panel1.Controls.Add(txtCurrent_Province)
        Panel1.Controls.Add(txtPerm_StreetName)
        Panel1.Controls.Add(txtCurrent_StreetName)
        Panel1.Controls.Add(txtPerm_MunicipalityorCity)
        Panel1.Controls.Add(txtCurrent_MunicipalityorCity)
        Panel1.Controls.Add(txtPerm_HouseNum)
        Panel1.Controls.Add(txtCurrent_HouseNum)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel5)
        Panel1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(835, 537)
        Panel1.TabIndex = 1
        ' 
        ' cbxGradelevel
        ' 
        cbxGradelevel.DropDownStyle = ComboBoxStyle.DropDownList
        cbxGradelevel.FormattingEnabled = True
        cbxGradelevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        cbxGradelevel.Location = New Point(624, 34)
        cbxGradelevel.Name = "cbxGradelevel"
        cbxGradelevel.Size = New Size(141, 23)
        cbxGradelevel.TabIndex = 8
        ' 
        ' dateBirthdate
        ' 
        dateBirthdate.CustomFormat = "yyyy-MM-dd"
        dateBirthdate.Format = DateTimePickerFormat.Custom
        dateBirthdate.Location = New Point(624, 68)
        dateBirthdate.Name = "dateBirthdate"
        dateBirthdate.Size = New Size(102, 23)
        dateBirthdate.TabIndex = 6
        dateBirthdate.Value = New DateTime(2023, 5, 30, 0, 0, 0, 0)
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(lblSex)
        Panel3.Controls.Add(rbtnMale)
        Panel3.Controls.Add(rbtnFemale)
        Panel3.Location = New Point(329, 52)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(142, 62)
        Panel3.TabIndex = 5
        ' 
        ' lblSex
        ' 
        lblSex.AutoSize = True
        lblSex.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblSex.Location = New Point(3, 0)
        lblSex.Name = "lblSex"
        lblSex.Size = New Size(29, 17)
        lblSex.TabIndex = 0
        lblSex.Text = "Sex"
        ' 
        ' rbtnMale
        ' 
        rbtnMale.AutoSize = True
        rbtnMale.Location = New Point(63, 8)
        rbtnMale.Name = "rbtnMale"
        rbtnMale.Size = New Size(51, 19)
        rbtnMale.TabIndex = 3
        rbtnMale.TabStop = True
        rbtnMale.Text = "Male"
        rbtnMale.UseVisualStyleBackColor = True
        ' 
        ' rbtnFemale
        ' 
        rbtnFemale.AutoSize = True
        rbtnFemale.Location = New Point(63, 33)
        rbtnFemale.Name = "rbtnFemale"
        rbtnFemale.Size = New Size(63, 19)
        rbtnFemale.TabIndex = 4
        rbtnFemale.TabStop = True
        rbtnFemale.Text = "Female"
        rbtnFemale.UseVisualStyleBackColor = True
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Location = New Point(-146, 183)
        lbl.Name = "lbl"
        lbl.Size = New Size(42, 15)
        lbl.TabIndex = 2
        lbl.Text = "Label2"
        ' 
        ' lblBirthplace
        ' 
        lblBirthplace.AutoSize = True
        lblBirthplace.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblBirthplace.Location = New Point(554, 113)
        lblBirthplace.Name = "lblBirthplace"
        lblBirthplace.Size = New Size(60, 15)
        lblBirthplace.TabIndex = 2
        lblBirthplace.Text = "Birthplace"
        ' 
        ' lblBirthdate
        ' 
        lblBirthdate.AutoSize = True
        lblBirthdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblBirthdate.Location = New Point(564, 76)
        lblBirthdate.Name = "lblBirthdate"
        lblBirthdate.Size = New Size(55, 15)
        lblBirthdate.TabIndex = 2
        lblBirthdate.Text = "Birthdate"
        ' 
        ' lblGradeLevelToEnroll
        ' 
        lblGradeLevelToEnroll.AutoSize = True
        lblGradeLevelToEnroll.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblGradeLevelToEnroll.Location = New Point(506, 42)
        lblGradeLevelToEnroll.Name = "lblGradeLevelToEnroll"
        lblGradeLevelToEnroll.Size = New Size(112, 15)
        lblGradeLevelToEnroll.TabIndex = 2
        lblGradeLevelToEnroll.Text = "Grade level to enroll"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(594, 435)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 15)
        Label9.TabIndex = 2
        Label9.Text = "Barangay"
        ' 
        ' lblBarangay
        ' 
        lblBarangay.AutoSize = True
        lblBarangay.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblBarangay.Location = New Point(594, 302)
        lblBarangay.Name = "lblBarangay"
        lblBarangay.Size = New Size(56, 15)
        lblBarangay.TabIndex = 2
        lblBarangay.Text = "Barangay"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(694, 491)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 15)
        Label8.TabIndex = 2
        Label8.Text = "Zip Code"
        ' 
        ' lblZipcode
        ' 
        lblZipcode.AutoSize = True
        lblZipcode.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblZipcode.Location = New Point(694, 358)
        lblZipcode.Name = "lblZipcode"
        lblZipcode.Size = New Size(54, 15)
        lblZipcode.TabIndex = 2
        lblZipcode.Text = "Zip Code"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(555, 491)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 15)
        Label7.TabIndex = 2
        Label7.Text = "Country"
        ' 
        ' lblCountry
        ' 
        lblCountry.AutoSize = True
        lblCountry.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblCountry.Location = New Point(555, 358)
        lblCountry.Name = "lblCountry"
        lblCountry.Size = New Size(49, 15)
        lblCountry.TabIndex = 2
        lblCountry.Text = "Country"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(283, 491)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 15)
        Label6.TabIndex = 2
        Label6.Text = "Province"
        ' 
        ' lblProvince
        ' 
        lblProvince.AutoSize = True
        lblProvince.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblProvince.Location = New Point(283, 358)
        lblProvince.Name = "lblProvince"
        lblProvince.Size = New Size(53, 15)
        lblProvince.TabIndex = 2
        lblProvince.Text = "Province"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(283, 435)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 15)
        Label5.TabIndex = 2
        Label5.Text = "Street name"
        ' 
        ' lblStreetName
        ' 
        lblStreetName.AutoSize = True
        lblStreetName.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblStreetName.Location = New Point(283, 302)
        lblStreetName.Name = "lblStreetName"
        lblStreetName.Size = New Size(71, 15)
        lblStreetName.TabIndex = 2
        lblStreetName.Text = "Street name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(15, 491)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 15)
        Label4.TabIndex = 2
        Label4.Text = "Municipality/City"
        ' 
        ' lblMunicipality_City
        ' 
        lblMunicipality_City.AutoSize = True
        lblMunicipality_City.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblMunicipality_City.Location = New Point(15, 358)
        lblMunicipality_City.Name = "lblMunicipality_City"
        lblMunicipality_City.Size = New Size(98, 15)
        lblMunicipality_City.TabIndex = 2
        lblMunicipality_City.Text = "Municipality/City"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(15, 435)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 15)
        Label2.TabIndex = 2
        Label2.Text = "House No./Street"
        ' 
        ' lblHouseNumStreet
        ' 
        lblHouseNumStreet.AutoSize = True
        lblHouseNumStreet.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblHouseNumStreet.Location = New Point(15, 302)
        lblHouseNumStreet.Name = "lblHouseNumStreet"
        lblHouseNumStreet.Size = New Size(99, 15)
        lblHouseNumStreet.TabIndex = 2
        lblHouseNumStreet.Text = "House No./Street"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(539, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(268, 15)
        Label1.TabIndex = 2
        Label1.Text = "If Yes, write the 4Ps Household ID Number below"
        ' 
        ' lblMiddlename
        ' 
        lblMiddlename.AutoSize = True
        lblMiddlename.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblMiddlename.Location = New Point(34, 146)
        lblMiddlename.Name = "lblMiddlename"
        lblMiddlename.Size = New Size(77, 15)
        lblMiddlename.TabIndex = 2
        lblMiddlename.Text = "Middle name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(34, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 15)
        Label3.TabIndex = 2
        Label3.Text = "First name"
        ' 
        ' lbllastName
        ' 
        lbllastName.AutoSize = True
        lbllastName.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lbllastName.Location = New Point(34, 90)
        lbllastName.Name = "lbllastName"
        lbllastName.Size = New Size(61, 15)
        lbllastName.TabIndex = 2
        lbllastName.Text = "Last name"
        ' 
        ' txt4Ps
        ' 
        txt4Ps.Location = New Point(539, 164)
        txt4Ps.Name = "txt4Ps"
        txt4Ps.Size = New Size(285, 23)
        txt4Ps.TabIndex = 1
        ' 
        ' txtMiddlename
        ' 
        txtMiddlename.Location = New Point(34, 164)
        txtMiddlename.Name = "txtMiddlename"
        txtMiddlename.Size = New Size(265, 23)
        txtMiddlename.TabIndex = 1
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Location = New Point(34, 52)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(265, 23)
        txtFirstname.TabIndex = 1
        ' 
        ' txtLastname
        ' 
        txtLastname.Location = New Point(34, 108)
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(265, 23)
        txtLastname.TabIndex = 1
        ' 
        ' txtBirthplace
        ' 
        txtBirthplace.Location = New Point(624, 105)
        txtBirthplace.Name = "txtBirthplace"
        txtBirthplace.Size = New Size(200, 23)
        txtBirthplace.TabIndex = 1
        ' 
        ' txtPerm_Barangay
        ' 
        txtPerm_Barangay.Location = New Point(594, 453)
        txtPerm_Barangay.Name = "txtPerm_Barangay"
        txtPerm_Barangay.Size = New Size(235, 23)
        txtPerm_Barangay.TabIndex = 1
        ' 
        ' txtCurrent_Barangay
        ' 
        txtCurrent_Barangay.Location = New Point(594, 320)
        txtCurrent_Barangay.Name = "txtCurrent_Barangay"
        txtCurrent_Barangay.Size = New Size(235, 23)
        txtCurrent_Barangay.TabIndex = 1
        ' 
        ' txtPerm_ZipCode
        ' 
        txtPerm_ZipCode.Location = New Point(694, 509)
        txtPerm_ZipCode.Name = "txtPerm_ZipCode"
        txtPerm_ZipCode.Size = New Size(131, 23)
        txtPerm_ZipCode.TabIndex = 1
        ' 
        ' txtCurrent_ZipCode
        ' 
        txtCurrent_ZipCode.Location = New Point(694, 376)
        txtCurrent_ZipCode.Name = "txtCurrent_ZipCode"
        txtCurrent_ZipCode.Size = New Size(131, 23)
        txtCurrent_ZipCode.TabIndex = 1
        ' 
        ' txtPerm_Country
        ' 
        txtPerm_Country.Location = New Point(555, 509)
        txtPerm_Country.Name = "txtPerm_Country"
        txtPerm_Country.Size = New Size(133, 23)
        txtPerm_Country.TabIndex = 1
        ' 
        ' txtCurrent_Country
        ' 
        txtCurrent_Country.Location = New Point(555, 376)
        txtCurrent_Country.Name = "txtCurrent_Country"
        txtCurrent_Country.Size = New Size(133, 23)
        txtCurrent_Country.TabIndex = 1
        ' 
        ' txtPerm_Province
        ' 
        txtPerm_Province.Location = New Point(282, 509)
        txtPerm_Province.Name = "txtPerm_Province"
        txtPerm_Province.Size = New Size(242, 23)
        txtPerm_Province.TabIndex = 1
        ' 
        ' txtCurrent_Province
        ' 
        txtCurrent_Province.Location = New Point(282, 376)
        txtCurrent_Province.Name = "txtCurrent_Province"
        txtCurrent_Province.Size = New Size(242, 23)
        txtCurrent_Province.TabIndex = 1
        ' 
        ' txtPerm_StreetName
        ' 
        txtPerm_StreetName.Location = New Point(282, 453)
        txtPerm_StreetName.Name = "txtPerm_StreetName"
        txtPerm_StreetName.Size = New Size(288, 23)
        txtPerm_StreetName.TabIndex = 1
        ' 
        ' txtCurrent_StreetName
        ' 
        txtCurrent_StreetName.Location = New Point(282, 320)
        txtCurrent_StreetName.Name = "txtCurrent_StreetName"
        txtCurrent_StreetName.Size = New Size(288, 23)
        txtCurrent_StreetName.TabIndex = 1
        ' 
        ' txtPerm_MunicipalityorCity
        ' 
        txtPerm_MunicipalityorCity.Location = New Point(15, 509)
        txtPerm_MunicipalityorCity.Name = "txtPerm_MunicipalityorCity"
        txtPerm_MunicipalityorCity.Size = New Size(239, 23)
        txtPerm_MunicipalityorCity.TabIndex = 1
        ' 
        ' txtCurrent_MunicipalityorCity
        ' 
        txtCurrent_MunicipalityorCity.Location = New Point(15, 376)
        txtCurrent_MunicipalityorCity.Name = "txtCurrent_MunicipalityorCity"
        txtCurrent_MunicipalityorCity.Size = New Size(239, 23)
        txtCurrent_MunicipalityorCity.TabIndex = 1
        ' 
        ' txtPerm_HouseNum
        ' 
        txtPerm_HouseNum.Location = New Point(15, 453)
        txtPerm_HouseNum.Name = "txtPerm_HouseNum"
        txtPerm_HouseNum.Size = New Size(239, 23)
        txtPerm_HouseNum.TabIndex = 1
        ' 
        ' txtCurrent_HouseNum
        ' 
        txtCurrent_HouseNum.Location = New Point(15, 320)
        txtCurrent_HouseNum.Name = "txtCurrent_HouseNum"
        txtCurrent_HouseNum.Size = New Size(239, 23)
        txtCurrent_HouseNum.TabIndex = 1
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Silver
        Panel9.BorderStyle = BorderStyle.FixedSingle
        Panel9.Controls.Add(lblCurrrentAddress)
        Panel9.Location = New Point(0, 272)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(837, 27)
        Panel9.TabIndex = 0
        ' 
        ' lblCurrrentAddress
        ' 
        lblCurrrentAddress.AutoSize = True
        lblCurrrentAddress.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblCurrrentAddress.Location = New Point(10, 10)
        lblCurrrentAddress.Name = "lblCurrrentAddress"
        lblCurrrentAddress.Size = New Size(97, 15)
        lblCurrrentAddress.TabIndex = 2
        lblCurrrentAddress.Text = "Current Address"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Silver
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(lblpermAddress)
        Panel6.Location = New Point(0, 405)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(837, 27)
        Panel6.TabIndex = 0
        ' 
        ' lblpermAddress
        ' 
        lblpermAddress.AutoSize = True
        lblpermAddress.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblpermAddress.Location = New Point(10, 10)
        lblpermAddress.Name = "lblpermAddress"
        lblpermAddress.Size = New Size(116, 15)
        lblpermAddress.TabIndex = 2
        lblpermAddress.Text = "Permanent Address"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(lblHeader)
        Panel2.Location = New Point(-1, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(837, 27)
        Panel2.TabIndex = 0
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeader.Location = New Point(346, 5)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(187, 20)
        lblHeader.TabIndex = 2
        lblHeader.Text = "LEARNER INFORMATION"
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(lbl4Ps)
        Panel5.Controls.Add(rbtnYes)
        Panel5.Controls.Add(rbtnNo)
        Panel5.Location = New Point(327, 140)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(206, 47)
        Panel5.TabIndex = 7
        ' 
        ' lbl4Ps
        ' 
        lbl4Ps.AutoSize = True
        lbl4Ps.BackColor = Color.Transparent
        lbl4Ps.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lbl4Ps.Location = New Point(5, 0)
        lbl4Ps.Name = "lbl4Ps"
        lbl4Ps.Size = New Size(190, 15)
        lbl4Ps.TabIndex = 2
        lbl4Ps.Text = "Is your family a beneficiary of 4Ps?"
        ' 
        ' rbtnYes
        ' 
        rbtnYes.AutoSize = True
        rbtnYes.Location = New Point(47, 23)
        rbtnYes.Name = "rbtnYes"
        rbtnYes.Size = New Size(42, 19)
        rbtnYes.TabIndex = 3
        rbtnYes.TabStop = True
        rbtnYes.Text = "Yes"
        rbtnYes.UseVisualStyleBackColor = True
        ' 
        ' rbtnNo
        ' 
        rbtnNo.AutoSize = True
        rbtnNo.Location = New Point(122, 23)
        rbtnNo.Name = "rbtnNo"
        rbtnNo.Size = New Size(41, 19)
        rbtnNo.TabIndex = 4
        rbtnNo.TabStop = True
        rbtnNo.Text = "No"
        rbtnNo.UseVisualStyleBackColor = True
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Gainsboro
        Panel10.BorderStyle = BorderStyle.FixedSingle
        Panel10.Controls.Add(Panel11)
        Panel10.Controls.Add(Panel12)
        Panel10.Controls.Add(Panel14)
        Panel10.Controls.Add(Label20)
        Panel10.Controls.Add(lblLastSchoolID)
        Panel10.Controls.Add(lblLastSchoolAttend)
        Panel10.Controls.Add(lastSchoolYearComp)
        Panel10.Controls.Add(lblLastGradeLevelComp)
        Panel10.Controls.Add(txtLastSchoolID)
        Panel10.Controls.Add(txtLastSchoolYearComp)
        Panel10.Controls.Add(txtLastSchoolAttended)
        Panel10.Controls.Add(txtLastGradeLevelComp)
        Panel10.Controls.Add(Panel15)
        Panel10.Controls.Add(Panel16)
        Panel10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Panel10.Location = New Point(3, 546)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(835, 412)
        Panel10.TabIndex = 4
        ' 
        ' Panel11
        ' 
        Panel11.BorderStyle = BorderStyle.FixedSingle
        Panel11.Controls.Add(lblGuardian)
        Panel11.Controls.Add(txtGuardian_ContactNum)
        Panel11.Controls.Add(txtGuardian_Mname)
        Panel11.Controls.Add(Label17)
        Panel11.Controls.Add(Label14)
        Panel11.Controls.Add(txtGuardian_Fname)
        Panel11.Controls.Add(Label16)
        Panel11.Controls.Add(Label15)
        Panel11.Controls.Add(txtGuardian_Lname)
        Panel11.Location = New Point(0, 183)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(833, 70)
        Panel11.TabIndex = 3
        ' 
        ' lblGuardian
        ' 
        lblGuardian.BorderStyle = BorderStyle.FixedSingle
        lblGuardian.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblGuardian.Location = New Point(9, 0)
        lblGuardian.Name = "lblGuardian"
        lblGuardian.Size = New Size(102, 17)
        lblGuardian.TabIndex = 0
        lblGuardian.Text = "Guardian's Name"
        ' 
        ' txtGuardian_ContactNum
        ' 
        txtGuardian_ContactNum.Location = New Point(641, 42)
        txtGuardian_ContactNum.Name = "txtGuardian_ContactNum"
        txtGuardian_ContactNum.Size = New Size(170, 23)
        txtGuardian_ContactNum.TabIndex = 1
        ' 
        ' txtGuardian_Mname
        ' 
        txtGuardian_Mname.Location = New Point(410, 42)
        txtGuardian_Mname.Name = "txtGuardian_Mname"
        txtGuardian_Mname.Size = New Size(192, 23)
        txtGuardian_Mname.TabIndex = 1
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(641, 24)
        Label17.Name = "Label17"
        Label17.Size = New Size(95, 15)
        Label17.TabIndex = 2
        Label17.Text = "Contact Number"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(13, 24)
        Label14.Name = "Label14"
        Label14.Size = New Size(64, 15)
        Label14.TabIndex = 2
        Label14.Text = "First Name"
        ' 
        ' txtGuardian_Fname
        ' 
        txtGuardian_Fname.Location = New Point(13, 42)
        txtGuardian_Fname.Name = "txtGuardian_Fname"
        txtGuardian_Fname.Size = New Size(192, 23)
        txtGuardian_Fname.TabIndex = 1
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(410, 24)
        Label16.Name = "Label16"
        Label16.Size = New Size(79, 15)
        Label16.TabIndex = 2
        Label16.Text = "Middle Name"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(211, 24)
        Label15.Name = "Label15"
        Label15.Size = New Size(63, 15)
        Label15.TabIndex = 2
        Label15.Text = "Last Name"
        ' 
        ' txtGuardian_Lname
        ' 
        txtGuardian_Lname.Location = New Point(211, 42)
        txtGuardian_Lname.Name = "txtGuardian_Lname"
        txtGuardian_Lname.Size = New Size(192, 23)
        txtGuardian_Lname.TabIndex = 1
        ' 
        ' Panel12
        ' 
        Panel12.BorderStyle = BorderStyle.FixedSingle
        Panel12.Controls.Add(lblMother)
        Panel12.Controls.Add(txtMother_ContactNum)
        Panel12.Controls.Add(txtMother_Mname)
        Panel12.Controls.Add(Label13)
        Panel12.Controls.Add(Label10)
        Panel12.Controls.Add(txtMother_Fname)
        Panel12.Controls.Add(Label12)
        Panel12.Controls.Add(Label11)
        Panel12.Controls.Add(txtMother_Lname)
        Panel12.Location = New Point(0, 107)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(833, 70)
        Panel12.TabIndex = 3
        ' 
        ' lblMother
        ' 
        lblMother.BorderStyle = BorderStyle.FixedSingle
        lblMother.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblMother.Location = New Point(13, 0)
        lblMother.Name = "lblMother"
        lblMother.Size = New Size(98, 15)
        lblMother.TabIndex = 0
        lblMother.Text = "Mother's Name"
        ' 
        ' txtMother_ContactNum
        ' 
        txtMother_ContactNum.Location = New Point(641, 42)
        txtMother_ContactNum.Name = "txtMother_ContactNum"
        txtMother_ContactNum.Size = New Size(170, 23)
        txtMother_ContactNum.TabIndex = 1
        ' 
        ' txtMother_Mname
        ' 
        txtMother_Mname.Location = New Point(410, 42)
        txtMother_Mname.Name = "txtMother_Mname"
        txtMother_Mname.Size = New Size(192, 23)
        txtMother_Mname.TabIndex = 1
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(641, 24)
        Label13.Name = "Label13"
        Label13.Size = New Size(95, 15)
        Label13.TabIndex = 2
        Label13.Text = "Contact Number"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(13, 24)
        Label10.Name = "Label10"
        Label10.Size = New Size(64, 15)
        Label10.TabIndex = 2
        Label10.Text = "First Name"
        ' 
        ' txtMother_Fname
        ' 
        txtMother_Fname.Location = New Point(13, 42)
        txtMother_Fname.Name = "txtMother_Fname"
        txtMother_Fname.Size = New Size(192, 23)
        txtMother_Fname.TabIndex = 1
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(410, 24)
        Label12.Name = "Label12"
        Label12.Size = New Size(79, 15)
        Label12.TabIndex = 2
        Label12.Text = "Middle Name"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(211, 24)
        Label11.Name = "Label11"
        Label11.Size = New Size(63, 15)
        Label11.TabIndex = 2
        Label11.Text = "Last Name"
        ' 
        ' txtMother_Lname
        ' 
        txtMother_Lname.Location = New Point(211, 42)
        txtMother_Lname.Name = "txtMother_Lname"
        txtMother_Lname.Size = New Size(192, 23)
        txtMother_Lname.TabIndex = 1
        ' 
        ' Panel14
        ' 
        Panel14.BorderStyle = BorderStyle.FixedSingle
        Panel14.Controls.Add(Label18)
        Panel14.Controls.Add(txtFather_ContactNum)
        Panel14.Controls.Add(lblFather_ContactNum)
        Panel14.Controls.Add(txtFather_Mname)
        Panel14.Controls.Add(Label19)
        Panel14.Controls.Add(txtFather_Lname)
        Panel14.Controls.Add(lblFather_Lname)
        Panel14.Controls.Add(txtFather_Fname)
        Panel14.Controls.Add(lblFather_Fname)
        Panel14.Location = New Point(0, 31)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(833, 70)
        Panel14.TabIndex = 3
        ' 
        ' Label18
        ' 
        Label18.BorderStyle = BorderStyle.FixedSingle
        Label18.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(13, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(87, 17)
        Label18.TabIndex = 0
        Label18.Text = "Father's name"
        ' 
        ' txtFather_ContactNum
        ' 
        txtFather_ContactNum.Location = New Point(641, 42)
        txtFather_ContactNum.Name = "txtFather_ContactNum"
        txtFather_ContactNum.Size = New Size(170, 23)
        txtFather_ContactNum.TabIndex = 1
        ' 
        ' lblFather_ContactNum
        ' 
        lblFather_ContactNum.AutoSize = True
        lblFather_ContactNum.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblFather_ContactNum.Location = New Point(641, 24)
        lblFather_ContactNum.Name = "lblFather_ContactNum"
        lblFather_ContactNum.Size = New Size(95, 15)
        lblFather_ContactNum.TabIndex = 2
        lblFather_ContactNum.Text = "Contact Number"
        ' 
        ' txtFather_Mname
        ' 
        txtFather_Mname.Location = New Point(410, 42)
        txtFather_Mname.Name = "txtFather_Mname"
        txtFather_Mname.Size = New Size(192, 23)
        txtFather_Mname.TabIndex = 1
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.Location = New Point(410, 24)
        Label19.Name = "Label19"
        Label19.Size = New Size(79, 15)
        Label19.TabIndex = 2
        Label19.Text = "Middle Name"
        ' 
        ' txtFather_Lname
        ' 
        txtFather_Lname.Location = New Point(211, 42)
        txtFather_Lname.Name = "txtFather_Lname"
        txtFather_Lname.Size = New Size(192, 23)
        txtFather_Lname.TabIndex = 1
        ' 
        ' lblFather_Lname
        ' 
        lblFather_Lname.AutoSize = True
        lblFather_Lname.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblFather_Lname.Location = New Point(211, 24)
        lblFather_Lname.Name = "lblFather_Lname"
        lblFather_Lname.Size = New Size(63, 15)
        lblFather_Lname.TabIndex = 2
        lblFather_Lname.Text = "Last Name"
        ' 
        ' txtFather_Fname
        ' 
        txtFather_Fname.Location = New Point(13, 42)
        txtFather_Fname.Name = "txtFather_Fname"
        txtFather_Fname.Size = New Size(192, 23)
        txtFather_Fname.TabIndex = 1
        ' 
        ' lblFather_Fname
        ' 
        lblFather_Fname.AutoSize = True
        lblFather_Fname.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblFather_Fname.Location = New Point(13, 24)
        lblFather_Fname.Name = "lblFather_Fname"
        lblFather_Fname.Size = New Size(64, 15)
        lblFather_Fname.TabIndex = 2
        lblFather_Fname.Text = "First Name"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(-146, 183)
        Label20.Name = "Label20"
        Label20.Size = New Size(42, 15)
        Label20.TabIndex = 2
        Label20.Text = "Label2"
        ' 
        ' lblLastSchoolID
        ' 
        lblLastSchoolID.AutoSize = True
        lblLastSchoolID.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblLastSchoolID.Location = New Point(449, 360)
        lblLastSchoolID.Name = "lblLastSchoolID"
        lblLastSchoolID.Size = New Size(84, 15)
        lblLastSchoolID.TabIndex = 2
        lblLastSchoolID.Text = "Last School ID"
        ' 
        ' lblLastSchoolAttend
        ' 
        lblLastSchoolAttend.AutoSize = True
        lblLastSchoolAttend.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblLastSchoolAttend.Location = New Point(14, 360)
        lblLastSchoolAttend.Name = "lblLastSchoolAttend"
        lblLastSchoolAttend.Size = New Size(120, 15)
        lblLastSchoolAttend.TabIndex = 2
        lblLastSchoolAttend.Text = "Last School Attended"
        ' 
        ' lastSchoolYearComp
        ' 
        lastSchoolYearComp.AutoSize = True
        lastSchoolYearComp.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lastSchoolYearComp.Location = New Point(449, 305)
        lastSchoolYearComp.Name = "lastSchoolYearComp"
        lastSchoolYearComp.Size = New Size(154, 15)
        lastSchoolYearComp.TabIndex = 2
        lastSchoolYearComp.Text = "Last School Year Completed"
        ' 
        ' lblLastGradeLevelComp
        ' 
        lblLastGradeLevelComp.AutoSize = True
        lblLastGradeLevelComp.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblLastGradeLevelComp.Location = New Point(14, 305)
        lblLastGradeLevelComp.Name = "lblLastGradeLevelComp"
        lblLastGradeLevelComp.Size = New Size(153, 15)
        lblLastGradeLevelComp.TabIndex = 2
        lblLastGradeLevelComp.Text = "Last Grade Level Completed"
        ' 
        ' txtLastSchoolID
        ' 
        txtLastSchoolID.Location = New Point(449, 378)
        txtLastSchoolID.Name = "txtLastSchoolID"
        txtLastSchoolID.Size = New Size(363, 23)
        txtLastSchoolID.TabIndex = 1
        ' 
        ' txtLastSchoolYearComp
        ' 
        txtLastSchoolYearComp.Location = New Point(449, 323)
        txtLastSchoolYearComp.Name = "txtLastSchoolYearComp"
        txtLastSchoolYearComp.Size = New Size(363, 23)
        txtLastSchoolYearComp.TabIndex = 1
        ' 
        ' txtLastSchoolAttended
        ' 
        txtLastSchoolAttended.Location = New Point(14, 378)
        txtLastSchoolAttended.Name = "txtLastSchoolAttended"
        txtLastSchoolAttended.Size = New Size(401, 23)
        txtLastSchoolAttended.TabIndex = 1
        ' 
        ' txtLastGradeLevelComp
        ' 
        txtLastGradeLevelComp.Location = New Point(14, 323)
        txtLastGradeLevelComp.Name = "txtLastGradeLevelComp"
        txtLastGradeLevelComp.Size = New Size(401, 23)
        txtLastGradeLevelComp.TabIndex = 1
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.Silver
        Panel15.BorderStyle = BorderStyle.FixedSingle
        Panel15.Controls.Add(lblforReturning_Transferee)
        Panel15.Location = New Point(0, 259)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(837, 27)
        Panel15.TabIndex = 0
        ' 
        ' lblforReturning_Transferee
        ' 
        lblforReturning_Transferee.AutoSize = True
        lblforReturning_Transferee.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblforReturning_Transferee.Location = New Point(173, 5)
        lblforReturning_Transferee.Name = "lblforReturning_Transferee"
        lblforReturning_Transferee.Size = New Size(514, 20)
        lblforReturning_Transferee.TabIndex = 2
        lblforReturning_Transferee.Text = "For Returning Learner (Balik-Aral) and Those Who will Transfer/Move In"
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = Color.Silver
        Panel16.BorderStyle = BorderStyle.FixedSingle
        Panel16.Controls.Add(Label21)
        Panel16.Location = New Point(-1, 0)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(837, 27)
        Panel16.TabIndex = 0
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label21.Location = New Point(302, 5)
        Label21.Name = "Label21"
        Label21.Size = New Size(291, 20)
        Label21.TabIndex = 2
        Label21.Text = "PARENT'S/GUARDIAN'S INFORMATION"
        ' 
        ' lblFather
        ' 
        lblFather.BackColor = Color.Turquoise
        lblFather.BorderStyle = BorderStyle.FixedSingle
        lblFather.Controls.Add(Panel13)
        lblFather.Location = New Point(877, 3)
        lblFather.Name = "lblFather"
        lblFather.Size = New Size(268, 631)
        lblFather.TabIndex = 3
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = SystemColors.ActiveBorder
        Panel13.BorderStyle = BorderStyle.FixedSingle
        Panel13.Controls.Add(Label22)
        Panel13.Controls.Add(lblInformation)
        Panel13.Controls.Add(PictureBox1)
        Panel13.Controls.Add(btnClose)
        Panel13.Controls.Add(btnSubmit)
        Panel13.Controls.Add(btnReset)
        Panel13.Location = New Point(26, 32)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(221, 577)
        Panel13.TabIndex = 0
        ' 
        ' Label22
        ' 
        Label22.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label22.Location = New Point(25, 212)
        Label22.Name = "Label22"
        Label22.Size = New Size(191, 29)
        Label22.TabIndex = 2
        Label22.Text = "Before submitting"
        ' 
        ' lblInformation
        ' 
        lblInformation.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblInformation.Location = New Point(3, 187)
        lblInformation.Name = "lblInformation"
        lblInformation.Size = New Size(226, 23)
        lblInformation.TabIndex = 2
        lblInformation.Text = "Please review your form"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonHighlight
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(75, 525)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 20)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = SystemColors.ButtonHighlight
        btnClose.Cursor = Cursors.Hand
        btnClose.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnClose.Location = New Point(61, 514)
        btnClose.Name = "btnClose"
        btnClose.Padding = New Padding(15, 0, 0, 0)
        btnClose.Size = New Size(97, 41)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Cursor = Cursors.Hand
        btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnSubmit.FlatStyle = FlatStyle.System
        btnSubmit.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.Location = New Point(52, 253)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(113, 41)
        btnSubmit.TabIndex = 0
        btnSubmit.Text = "Submit form"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Cursor = Cursors.Hand
        btnReset.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnReset.FlatStyle = FlatStyle.System
        btnReset.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnReset.Location = New Point(52, 305)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(113, 41)
        btnReset.TabIndex = 0
        btnReset.Text = "Reset form"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' lblLRN
        ' 
        lblLRN.AutoSize = True
        lblLRN.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblLRN.Location = New Point(539, 225)
        lblLRN.Name = "lblLRN"
        lblLRN.Size = New Size(164, 15)
        lblLRN.TabIndex = 2
        lblLRN.Text = "If Yes, write your Student LRN"
        ' 
        ' txtstudentLRN
        ' 
        txtstudentLRN.Location = New Point(539, 243)
        txtstudentLRN.Name = "txtstudentLRN"
        txtstudentLRN.Size = New Size(285, 23)
        txtstudentLRN.TabIndex = 1
        ' 
        ' rbtnLRNNO
        ' 
        rbtnLRNNO.AutoSize = True
        rbtnLRNNO.Location = New Point(126, 21)
        rbtnLRNNO.Name = "rbtnLRNNO"
        rbtnLRNNO.Size = New Size(41, 19)
        rbtnLRNNO.TabIndex = 4
        rbtnLRNNO.TabStop = True
        rbtnLRNNO.Text = "No"
        rbtnLRNNO.UseVisualStyleBackColor = True
        ' 
        ' rbtnLRNYES
        ' 
        rbtnLRNYES.AutoSize = True
        rbtnLRNYES.Location = New Point(41, 21)
        rbtnLRNYES.Name = "rbtnLRNYES"
        rbtnLRNYES.Size = New Size(42, 19)
        rbtnLRNYES.TabIndex = 3
        rbtnLRNYES.TabStop = True
        rbtnLRNYES.Text = "Yes"
        rbtnLRNYES.UseVisualStyleBackColor = True
        ' 
        ' lblWithLRN
        ' 
        lblWithLRN.AutoSize = True
        lblWithLRN.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblWithLRN.Location = New Point(3, 0)
        lblWithLRN.Name = "lblWithLRN"
        lblWithLRN.Size = New Size(71, 17)
        lblWithLRN.TabIndex = 0
        lblWithLRN.Text = "With LRN?"
        ' 
        ' Panel7
        ' 
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(lblWithLRN)
        Panel7.Controls.Add(rbtnLRNYES)
        Panel7.Controls.Add(rbtnLRNNO)
        Panel7.Location = New Point(329, 204)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(204, 62)
        Panel7.TabIndex = 5
        ' 
        ' rbtnRETURNINGNO
        ' 
        rbtnRETURNINGNO.AutoSize = True
        rbtnRETURNINGNO.Location = New Point(142, 21)
        rbtnRETURNINGNO.Name = "rbtnRETURNINGNO"
        rbtnRETURNINGNO.Padding = New Padding(4, 6, 0, 0)
        rbtnRETURNINGNO.Size = New Size(45, 25)
        rbtnRETURNINGNO.TabIndex = 4
        rbtnRETURNINGNO.TabStop = True
        rbtnRETURNINGNO.Text = "No"
        rbtnRETURNINGNO.UseVisualStyleBackColor = True
        ' 
        ' rbtnRETURNINGYES
        ' 
        rbtnRETURNINGYES.AutoSize = True
        rbtnRETURNINGYES.Location = New Point(57, 21)
        rbtnRETURNINGYES.Name = "rbtnRETURNINGYES"
        rbtnRETURNINGYES.Padding = New Padding(4, 6, 0, 0)
        rbtnRETURNINGYES.Size = New Size(46, 25)
        rbtnRETURNINGYES.TabIndex = 3
        rbtnRETURNINGYES.TabStop = True
        rbtnRETURNINGYES.Text = "Yes"
        rbtnRETURNINGYES.UseVisualStyleBackColor = True
        ' 
        ' lblReturning
        ' 
        lblReturning.AutoSize = True
        lblReturning.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblReturning.Location = New Point(3, 0)
        lblReturning.Name = "lblReturning"
        lblReturning.Size = New Size(136, 17)
        lblReturning.TabIndex = 0
        lblReturning.Text = "Returning (Balik-Aral)"
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(lblReturning)
        Panel8.Controls.Add(rbtnRETURNINGYES)
        Panel8.Controls.Add(rbtnRETURNINGNO)
        Panel8.Location = New Point(34, 204)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(265, 62)
        Panel8.TabIndex = 5
        ' 
        ' enrollmentform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1146, 634)
        ControlBox = False
        Controls.Add(lblFather)
        Controls.Add(FlowLayoutPanel1)
        Name = "enrollmentform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Enrollment Form"
        FlowLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        Panel15.ResumeLayout(False)
        Panel15.PerformLayout()
        Panel16.ResumeLayout(False)
        Panel16.PerformLayout()
        lblFather.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dateBirthdate As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblSex As Label
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents lbl As Label
    Friend WithEvents lblBirthplace As Label
    Friend WithEvents lblBirthdate As Label
    Friend WithEvents lblGradeLevelToEnroll As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblBarangay As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblZipcode As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblProvince As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStreetName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMunicipality_City As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHouseNumStreet As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMiddlename As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbllastName As Label
    Friend WithEvents txt4Ps As TextBox
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtBirthplace As TextBox
    Friend WithEvents txtPerm_Barangay As TextBox
    Friend WithEvents txtCurrent_Barangay As TextBox
    Friend WithEvents txtPerm_ZipCode As TextBox
    Friend WithEvents txtCurrent_ZipCode As TextBox
    Friend WithEvents txtPerm_Country As TextBox
    Friend WithEvents txtCurrent_Country As TextBox
    Friend WithEvents txtPerm_Province As TextBox
    Friend WithEvents txtCurrent_Province As TextBox
    Friend WithEvents txtPerm_StreetName As TextBox
    Friend WithEvents txtCurrent_StreetName As TextBox
    Friend WithEvents txtPerm_MunicipalityorCity As TextBox
    Friend WithEvents txtCurrent_MunicipalityorCity As TextBox
    Friend WithEvents txtPerm_HouseNum As TextBox
    Friend WithEvents txtCurrent_HouseNum As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblpermAddress As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl4Ps As Label
    Friend WithEvents rbtnYes As RadioButton
    Friend WithEvents rbtnNo As RadioButton
    Friend WithEvents lblFather As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblCurrrentAddress As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblGuardian As Label
    Friend WithEvents txtGuardian_ContactNum As TextBox
    Friend WithEvents txtGuardian_Mname As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtGuardian_Fname As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtGuardian_Lname As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents lblMother As Label
    Friend WithEvents txtMother_ContactNum As TextBox
    Friend WithEvents txtMother_Mname As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMother_Fname As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMother_Lname As TextBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents txtFather_ContactNum As TextBox
    Friend WithEvents lblFather_ContactNum As Label
    Friend WithEvents txtFather_Mname As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtFather_Lname As TextBox
    Friend WithEvents lblFather_Lname As Label
    Friend WithEvents txtFather_Fname As TextBox
    Friend WithEvents lblFather_Fname As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblLastSchoolID As Label
    Friend WithEvents lblLastSchoolAttend As Label
    Friend WithEvents lastSchoolYearComp As Label
    Friend WithEvents lblLastGradeLevelComp As Label
    Friend WithEvents txtLastSchoolID As TextBox
    Friend WithEvents txtLastSchoolYearComp As TextBox
    Friend WithEvents txtLastSchoolAttended As TextBox
    Friend WithEvents txtLastGradeLevelComp As TextBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents lblforReturning_Transferee As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label22 As Label
    Friend WithEvents lblInformation As Label
    Friend WithEvents cbxGradelevel As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblReturning As Label
    Friend WithEvents rbtnRETURNINGYES As RadioButton
    Friend WithEvents rbtnRETURNINGNO As RadioButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblWithLRN As Label
    Friend WithEvents rbtnLRNYES As RadioButton
    Friend WithEvents rbtnLRNNO As RadioButton
    Friend WithEvents lblLRN As Label
    Friend WithEvents txtstudentLRN As TextBox
End Class
