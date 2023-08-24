<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enrollmentforms
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Enrollmentforms))
        DataGridView1 = New DataGridView()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        txtShowDate = New TextBox()
        txtshowAycode = New TextBox()
        txtHomeroomIDShow = New TextBox()
        txtSectionNEWID = New TextBox()
        txtShowSectOLDID = New TextBox()
        txtshowtID = New TextBox()
        txtTeacherPassword = New TextBox()
        dateCurrDate = New DateTimePicker()
        btnDelete = New Button()
        btnReset = New Button()
        btnEnroll = New Button()
        txtNewSCode = New TextBox()
        Panel2 = New Panel()
        cbxGradeLevelOldStudent = New ComboBox()
        cbxSectionOldStudent = New ComboBox()
        btnMoreInfo = New Button()
        btnSearch = New Button()
        lblMiddleName = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtOldSCode = New TextBox()
        txtOldStudentMname = New TextBox()
        Label1 = New Label()
        txtOldStudentLname = New TextBox()
        txtOldStudentFname = New TextBox()
        TextBox1 = New TextBox()
        btnRefreshOld = New Button()
        Panel6 = New Panel()
        Label8 = New Label()
        Panel5 = New Panel()
        Label4 = New Label()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Label11 = New Label()
        Label7 = New Label()
        Label12 = New Label()
        Label10 = New Label()
        Label5 = New Label()
        Label9 = New Label()
        Label6 = New Label()
        txtNewStudentPlaceOfBirth = New TextBox()
        txtNewStudentGradeLevelToEnroll = New TextBox()
        txtNewStudentBirthdate = New TextBox()
        txtNewStudentMiddleName = New TextBox()
        txtNewStudentGender = New TextBox()
        txtNewStudentLastName = New TextBox()
        txtNewStudentFirstName = New TextBox()
        cbxNewStudentSection = New ComboBox()
        PictureBox3 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        lblStudentLRN = New Label()
        Label15 = New Label()
        txtsearch = New TextBox()
        TextBox13 = New TextBox()
        btnRefreshNew = New Button()
        DataGridView2 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridView1.BackgroundColor = Color.Gray
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(-1, 155)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(758, 127)
        DataGridView1.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Location = New Point(964, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(25, 22)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = My.Resources.Resources.close
        PictureBox2.Location = New Point(940, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 22)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(977, 28)
        Panel1.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientActiveCaption
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Panel4)
        Panel3.Location = New Point(757, 28)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(220, 645)
        Panel3.TabIndex = 7
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Gainsboro
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(txtShowDate)
        Panel4.Controls.Add(txtshowAycode)
        Panel4.Controls.Add(txtHomeroomIDShow)
        Panel4.Controls.Add(txtSectionNEWID)
        Panel4.Controls.Add(txtShowSectOLDID)
        Panel4.Controls.Add(txtshowtID)
        Panel4.Controls.Add(txtTeacherPassword)
        Panel4.Controls.Add(dateCurrDate)
        Panel4.Controls.Add(btnDelete)
        Panel4.Controls.Add(btnReset)
        Panel4.Controls.Add(btnEnroll)
        Panel4.Location = New Point(10, 6)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(202, 623)
        Panel4.TabIndex = 49
        ' 
        ' txtShowDate
        ' 
        txtShowDate.Location = New Point(50, 161)
        txtShowDate.Name = "txtShowDate"
        txtShowDate.Size = New Size(104, 23)
        txtShowDate.TabIndex = 50
        txtShowDate.Visible = False
        ' 
        ' txtshowAycode
        ' 
        txtshowAycode.Location = New Point(50, 132)
        txtshowAycode.Name = "txtshowAycode"
        txtshowAycode.Size = New Size(104, 23)
        txtshowAycode.TabIndex = 50
        txtshowAycode.Visible = False
        ' 
        ' txtHomeroomIDShow
        ' 
        txtHomeroomIDShow.Location = New Point(50, 103)
        txtHomeroomIDShow.Name = "txtHomeroomIDShow"
        txtHomeroomIDShow.Size = New Size(104, 23)
        txtHomeroomIDShow.TabIndex = 50
        txtHomeroomIDShow.Visible = False
        ' 
        ' txtSectionNEWID
        ' 
        txtSectionNEWID.Location = New Point(50, 74)
        txtSectionNEWID.Name = "txtSectionNEWID"
        txtSectionNEWID.Size = New Size(104, 23)
        txtSectionNEWID.TabIndex = 50
        txtSectionNEWID.Visible = False
        ' 
        ' txtShowSectOLDID
        ' 
        txtShowSectOLDID.Location = New Point(51, 45)
        txtShowSectOLDID.Name = "txtShowSectOLDID"
        txtShowSectOLDID.Size = New Size(104, 23)
        txtShowSectOLDID.TabIndex = 50
        txtShowSectOLDID.Visible = False
        ' 
        ' txtshowtID
        ' 
        txtshowtID.Location = New Point(52, 16)
        txtshowtID.Name = "txtshowtID"
        txtshowtID.Size = New Size(104, 23)
        txtshowtID.TabIndex = 50
        txtshowtID.Visible = False
        ' 
        ' txtTeacherPassword
        ' 
        txtTeacherPassword.Location = New Point(51, 575)
        txtTeacherPassword.Name = "txtTeacherPassword"
        txtTeacherPassword.Size = New Size(104, 23)
        txtTeacherPassword.TabIndex = 50
        txtTeacherPassword.Visible = False
        ' 
        ' dateCurrDate
        ' 
        dateCurrDate.CustomFormat = "yyyy-MM-dd"
        dateCurrDate.Format = DateTimePickerFormat.Custom
        dateCurrDate.Location = New Point(52, 539)
        dateCurrDate.Name = "dateCurrDate"
        dateCurrDate.Size = New Size(102, 23)
        dateCurrDate.TabIndex = 49
        dateCurrDate.Value = New DateTime(2023, 6, 2, 0, 19, 14, 0)
        ' 
        ' btnDelete
        ' 
        btnDelete.FlatAppearance.BorderColor = Color.Black
        btnDelete.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.Location = New Point(25, 262)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(160, 45)
        btnDelete.TabIndex = 47
        btnDelete.Text = "Unenroll"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.FlatAppearance.BorderColor = Color.Black
        btnReset.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnReset.Location = New Point(25, 313)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(160, 45)
        btnReset.TabIndex = 46
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnEnroll
        ' 
        btnEnroll.FlatAppearance.BorderColor = Color.Black
        btnEnroll.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnEnroll.Location = New Point(25, 211)
        btnEnroll.Name = "btnEnroll"
        btnEnroll.Size = New Size(160, 45)
        btnEnroll.TabIndex = 48
        btnEnroll.Text = "Enroll"
        btnEnroll.UseVisualStyleBackColor = True
        ' 
        ' txtNewSCode
        ' 
        txtNewSCode.BackColor = SystemColors.Window
        txtNewSCode.BorderStyle = BorderStyle.FixedSingle
        txtNewSCode.Enabled = False
        txtNewSCode.ForeColor = Color.Black
        txtNewSCode.Location = New Point(523, 90)
        txtNewSCode.Multiline = True
        txtNewSCode.Name = "txtNewSCode"
        txtNewSCode.Size = New Size(118, 23)
        txtNewSCode.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(cbxGradeLevelOldStudent)
        Panel2.Controls.Add(cbxSectionOldStudent)
        Panel2.Controls.Add(btnMoreInfo)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(lblMiddleName)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtOldSCode)
        Panel2.Controls.Add(txtOldStudentMname)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtOldStudentLname)
        Panel2.Controls.Add(txtOldStudentFname)
        Panel2.Controls.Add(TextBox1)
        Panel2.Location = New Point(0, 52)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(759, 105)
        Panel2.TabIndex = 8
        ' 
        ' cbxGradeLevelOldStudent
        ' 
        cbxGradeLevelOldStudent.BackColor = SystemColors.Window
        cbxGradeLevelOldStudent.FormattingEnabled = True
        cbxGradeLevelOldStudent.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        cbxGradeLevelOldStudent.Location = New Point(470, 10)
        cbxGradeLevelOldStudent.Name = "cbxGradeLevelOldStudent"
        cbxGradeLevelOldStudent.Size = New Size(137, 23)
        cbxGradeLevelOldStudent.TabIndex = 4
        ' 
        ' cbxSectionOldStudent
        ' 
        cbxSectionOldStudent.BackColor = SystemColors.Window
        cbxSectionOldStudent.FormattingEnabled = True
        cbxSectionOldStudent.Items.AddRange(New Object() {"A", "B"})
        cbxSectionOldStudent.Location = New Point(280, 10)
        cbxSectionOldStudent.Name = "cbxSectionOldStudent"
        cbxSectionOldStudent.Size = New Size(118, 23)
        cbxSectionOldStudent.TabIndex = 4
        ' 
        ' btnMoreInfo
        ' 
        btnMoreInfo.BackColor = Color.White
        btnMoreInfo.FlatStyle = FlatStyle.Flat
        btnMoreInfo.Location = New Point(643, 45)
        btnMoreInfo.Name = "btnMoreInfo"
        btnMoreInfo.Size = New Size(107, 23)
        btnMoreInfo.TabIndex = 2
        btnMoreInfo.Text = "More Info"
        btnMoreInfo.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.White
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(643, 10)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(107, 23)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' lblMiddleName
        ' 
        lblMiddleName.AutoSize = True
        lblMiddleName.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblMiddleName.Location = New Point(410, 52)
        lblMiddleName.Name = "lblMiddleName"
        lblMiddleName.Size = New Size(77, 15)
        lblMiddleName.TabIndex = 1
        lblMiddleName.Text = "Middle name"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(426, 18)
        Label14.Name = "Label14"
        Label14.Size = New Size(38, 15)
        Label14.TabIndex = 1
        Label14.Text = "Grade"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(227, 18)
        Label13.Name = "Label13"
        Label13.Size = New Size(47, 15)
        Label13.TabIndex = 1
        Label13.Text = "Section"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(213, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 15)
        Label3.TabIndex = 1
        Label3.Text = "Last name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(5, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 1
        Label2.Text = "First name"
        ' 
        ' txtOldSCode
        ' 
        txtOldSCode.Location = New Point(489, 73)
        txtOldSCode.Name = "txtOldSCode"
        txtOldSCode.Size = New Size(118, 23)
        txtOldSCode.TabIndex = 0
        ' 
        ' txtOldStudentMname
        ' 
        txtOldStudentMname.Location = New Point(489, 45)
        txtOldStudentMname.Name = "txtOldStudentMname"
        txtOldStudentMname.Size = New Size(118, 23)
        txtOldStudentMname.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(0, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 1
        Label1.Text = "Student LRN"
        ' 
        ' txtOldStudentLname
        ' 
        txtOldStudentLname.Location = New Point(280, 45)
        txtOldStudentLname.Name = "txtOldStudentLname"
        txtOldStudentLname.Size = New Size(118, 23)
        txtOldStudentLname.TabIndex = 0
        ' 
        ' txtOldStudentFname
        ' 
        txtOldStudentFname.Location = New Point(79, 45)
        txtOldStudentFname.Name = "txtOldStudentFname"
        txtOldStudentFname.Size = New Size(118, 23)
        txtOldStudentFname.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(79, 10)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(118, 23)
        TextBox1.TabIndex = 0
        ' 
        ' btnRefreshOld
        ' 
        btnRefreshOld.BackColor = SystemColors.ControlLightLight
        btnRefreshOld.FlatStyle = FlatStyle.Flat
        btnRefreshOld.Location = New Point(-1, 259)
        btnRefreshOld.Name = "btnRefreshOld"
        btnRefreshOld.Size = New Size(58, 23)
        btnRefreshOld.TabIndex = 6
        btnRefreshOld.Text = "Refresh"
        btnRefreshOld.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.AppWorkspace
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Label8)
        Panel6.ForeColor = SystemColors.ControlText
        Panel6.Location = New Point(0, 28)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(758, 25)
        Panel6.TabIndex = 51
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(318, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(169, 20)
        Label8.TabIndex = 38
        Label8.Text = "Returning/Old Student"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.AppWorkspace
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Label4)
        Panel5.ForeColor = SystemColors.ControlText
        Panel5.Location = New Point(0, 278)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(758, 25)
        Panel5.TabIndex = 52
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(280, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(214, 20)
        Label4.TabIndex = 38
        Label4.Text = "New and Transferee students"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Silver
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(Panel8)
        Panel7.Controls.Add(cbxNewStudentSection)
        Panel7.Controls.Add(PictureBox3)
        Panel7.Controls.Add(Button2)
        Panel7.Controls.Add(Button1)
        Panel7.Controls.Add(lblStudentLRN)
        Panel7.Controls.Add(Label15)
        Panel7.Controls.Add(txtsearch)
        Panel7.Controls.Add(TextBox13)
        Panel7.Location = New Point(0, 302)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(759, 213)
        Panel7.TabIndex = 53
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(Label11)
        Panel8.Controls.Add(Label7)
        Panel8.Controls.Add(Label12)
        Panel8.Controls.Add(Label10)
        Panel8.Controls.Add(Label5)
        Panel8.Controls.Add(Label9)
        Panel8.Controls.Add(Label6)
        Panel8.Controls.Add(txtNewStudentPlaceOfBirth)
        Panel8.Controls.Add(txtNewSCode)
        Panel8.Controls.Add(txtNewStudentGradeLevelToEnroll)
        Panel8.Controls.Add(txtNewStudentBirthdate)
        Panel8.Controls.Add(txtNewStudentMiddleName)
        Panel8.Controls.Add(txtNewStudentGender)
        Panel8.Controls.Add(txtNewStudentLastName)
        Panel8.Controls.Add(txtNewStudentFirstName)
        Panel8.Location = New Point(12, 67)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(718, 118)
        Panel8.TabIndex = 5
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(423, 58)
        Label11.Name = "Label11"
        Label11.Size = New Size(77, 15)
        Label11.TabIndex = 1
        Label11.Text = "Place of birth"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(423, 20)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 15)
        Label7.TabIndex = 1
        Label7.Text = "Middle name"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(162, 92)
        Label12.Name = "Label12"
        Label12.Size = New Size(112, 15)
        Label12.TabIndex = 1
        Label12.Text = "Grade level to enroll"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(218, 58)
        Label10.Name = "Label10"
        Label10.Size = New Size(58, 15)
        Label10.TabIndex = 1
        Label10.Text = "Birth date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(218, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 1
        Label5.Text = "Last name"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(30, 58)
        Label9.Name = "Label9"
        Label9.Size = New Size(45, 15)
        Label9.TabIndex = 1
        Label9.Text = "Gender"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(13, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 15)
        Label6.TabIndex = 1
        Label6.Text = "First name"
        ' 
        ' txtNewStudentPlaceOfBirth
        ' 
        txtNewStudentPlaceOfBirth.BackColor = SystemColors.Window
        txtNewStudentPlaceOfBirth.BorderStyle = BorderStyle.FixedSingle
        txtNewStudentPlaceOfBirth.Enabled = False
        txtNewStudentPlaceOfBirth.ForeColor = Color.Black
        txtNewStudentPlaceOfBirth.Location = New Point(523, 50)
        txtNewStudentPlaceOfBirth.Multiline = True
        txtNewStudentPlaceOfBirth.Name = "txtNewStudentPlaceOfBirth"
        txtNewStudentPlaceOfBirth.ReadOnly = True
        txtNewStudentPlaceOfBirth.Size = New Size(118, 23)
        txtNewStudentPlaceOfBirth.TabIndex = 0
        ' 
        ' txtNewStudentGradeLevelToEnroll
        ' 
        txtNewStudentGradeLevelToEnroll.BackColor = SystemColors.Window
        txtNewStudentGradeLevelToEnroll.BorderStyle = BorderStyle.FixedSingle
        txtNewStudentGradeLevelToEnroll.Enabled = False
        txtNewStudentGradeLevelToEnroll.ForeColor = Color.Black
        txtNewStudentGradeLevelToEnroll.Location = New Point(286, 90)
        txtNewStudentGradeLevelToEnroll.Multiline = True
        txtNewStudentGradeLevelToEnroll.Name = "txtNewStudentGradeLevelToEnroll"
        txtNewStudentGradeLevelToEnroll.ReadOnly = True
        txtNewStudentGradeLevelToEnroll.Size = New Size(118, 23)
        txtNewStudentGradeLevelToEnroll.TabIndex = 0
        ' 
        ' txtNewStudentBirthdate
        ' 
        txtNewStudentBirthdate.BackColor = SystemColors.Window
        txtNewStudentBirthdate.BorderStyle = BorderStyle.FixedSingle
        txtNewStudentBirthdate.Enabled = False
        txtNewStudentBirthdate.ForeColor = Color.Black
        txtNewStudentBirthdate.Location = New Point(286, 50)
        txtNewStudentBirthdate.Multiline = True
        txtNewStudentBirthdate.Name = "txtNewStudentBirthdate"
        txtNewStudentBirthdate.ReadOnly = True
        txtNewStudentBirthdate.Size = New Size(118, 23)
        txtNewStudentBirthdate.TabIndex = 0
        ' 
        ' txtNewStudentMiddleName
        ' 
        txtNewStudentMiddleName.BackColor = SystemColors.Window
        txtNewStudentMiddleName.BorderStyle = BorderStyle.FixedSingle
        txtNewStudentMiddleName.Enabled = False
        txtNewStudentMiddleName.ForeColor = Color.Black
        txtNewStudentMiddleName.Location = New Point(523, 12)
        txtNewStudentMiddleName.Multiline = True
        txtNewStudentMiddleName.Name = "txtNewStudentMiddleName"
        txtNewStudentMiddleName.ReadOnly = True
        txtNewStudentMiddleName.Size = New Size(118, 23)
        txtNewStudentMiddleName.TabIndex = 0
        ' 
        ' txtNewStudentGender
        ' 
        txtNewStudentGender.BackColor = SystemColors.Window
        txtNewStudentGender.BorderStyle = BorderStyle.FixedSingle
        txtNewStudentGender.Enabled = False
        txtNewStudentGender.ForeColor = Color.Black
        txtNewStudentGender.Location = New Point(81, 50)
        txtNewStudentGender.Multiline = True
        txtNewStudentGender.Name = "txtNewStudentGender"
        txtNewStudentGender.ReadOnly = True
        txtNewStudentGender.Size = New Size(118, 23)
        txtNewStudentGender.TabIndex = 0
        ' 
        ' txtNewStudentLastName
        ' 
        txtNewStudentLastName.BackColor = SystemColors.Window
        txtNewStudentLastName.BorderStyle = BorderStyle.FixedSingle
        txtNewStudentLastName.Enabled = False
        txtNewStudentLastName.ForeColor = Color.Black
        txtNewStudentLastName.Location = New Point(286, 12)
        txtNewStudentLastName.Multiline = True
        txtNewStudentLastName.Name = "txtNewStudentLastName"
        txtNewStudentLastName.ReadOnly = True
        txtNewStudentLastName.Size = New Size(118, 23)
        txtNewStudentLastName.TabIndex = 0
        ' 
        ' txtNewStudentFirstName
        ' 
        txtNewStudentFirstName.BackColor = SystemColors.Window
        txtNewStudentFirstName.BorderStyle = BorderStyle.FixedSingle
        txtNewStudentFirstName.Enabled = False
        txtNewStudentFirstName.ForeColor = Color.Black
        txtNewStudentFirstName.Location = New Point(81, 12)
        txtNewStudentFirstName.Multiline = True
        txtNewStudentFirstName.Name = "txtNewStudentFirstName"
        txtNewStudentFirstName.ReadOnly = True
        txtNewStudentFirstName.Size = New Size(118, 23)
        txtNewStudentFirstName.TabIndex = 0
        ' 
        ' cbxNewStudentSection
        ' 
        cbxNewStudentSection.BackColor = SystemColors.Window
        cbxNewStudentSection.FormattingEnabled = True
        cbxNewStudentSection.Items.AddRange(New Object() {"A", "B"})
        cbxNewStudentSection.Location = New Point(336, 8)
        cbxNewStudentSection.Name = "cbxNewStudentSection"
        cbxNewStudentSection.Size = New Size(118, 23)
        cbxNewStudentSection.TabIndex = 4
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.InactiveBorder
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(640, 11)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(20, 18)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(669, 37)
        Button2.Name = "Button2"
        Button2.Size = New Size(81, 23)
        Button2.TabIndex = 2
        Button2.Text = "More Info"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(669, 8)
        Button1.Name = "Button1"
        Button1.Size = New Size(81, 23)
        Button1.TabIndex = 2
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblStudentLRN
        ' 
        lblStudentLRN.AutoSize = True
        lblStudentLRN.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblStudentLRN.Location = New Point(5, 16)
        lblStudentLRN.Name = "lblStudentLRN"
        lblStudentLRN.Size = New Size(74, 15)
        lblStudentLRN.TabIndex = 1
        lblStudentLRN.Text = "Student LRN"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(280, 16)
        Label15.Name = "Label15"
        Label15.Size = New Size(47, 15)
        Label15.TabIndex = 1
        Label15.Text = "Section"
        ' 
        ' txtsearch
        ' 
        txtsearch.BackColor = SystemColors.InactiveBorder
        txtsearch.BorderStyle = BorderStyle.FixedSingle
        txtsearch.Location = New Point(517, 8)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(146, 23)
        txtsearch.TabIndex = 0
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(93, 8)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(162, 23)
        TextBox13.TabIndex = 0
        ' 
        ' btnRefreshNew
        ' 
        btnRefreshNew.BackColor = SystemColors.ControlLightLight
        btnRefreshNew.FlatStyle = FlatStyle.Flat
        btnRefreshNew.Location = New Point(-1, 650)
        btnRefreshNew.Name = "btnRefreshNew"
        btnRefreshNew.Size = New Size(58, 23)
        btnRefreshNew.TabIndex = 6
        btnRefreshNew.Text = "Refresh"
        btnRefreshNew.UseVisualStyleBackColor = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridView2.BackgroundColor = Color.Gray
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(-1, 515)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(760, 158)
        DataGridView2.TabIndex = 39
        ' 
        ' Enrollmentforms
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(977, 673)
        ControlBox = False
        Controls.Add(btnRefreshNew)
        Controls.Add(btnRefreshOld)
        Controls.Add(Panel3)
        Controls.Add(DataGridView2)
        Controls.Add(Panel1)
        Controls.Add(Panel6)
        Controls.Add(Panel7)
        Controls.Add(Panel2)
        Controls.Add(DataGridView1)
        Controls.Add(Panel5)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Enrollmentforms"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnroll As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOldStudentLname As TextBox
    Friend WithEvents txtOldStudentFname As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNewStudentLastName As TextBox
    Friend WithEvents txtNewStudentFirstName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNewStudentMiddleName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNewStudentPlaceOfBirth As TextBox
    Friend WithEvents txtNewStudentBirthdate As TextBox
    Friend WithEvents txtNewStudentGender As TextBox
    Friend WithEvents lblStudentLRN As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents btnMoreInfo As Button
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtOldStudentMname As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents cbxNewStudentSection As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNewStudentGradeLevelToEnroll As TextBox
    Friend WithEvents cbxGradeLevelOldStudent As ComboBox
    Friend WithEvents cbxSectionOldStudent As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnRefreshNew As Button
    Friend WithEvents txtNewSCode As TextBox
    Friend WithEvents btnRefreshOld As Button
    Friend WithEvents txtOldSCode As TextBox
    Friend WithEvents dateCurrDate As DateTimePicker
    Friend WithEvents txtTeacherPassword As TextBox
    Friend WithEvents txtshowtID As TextBox
    Friend WithEvents txtShowSectOLDID As TextBox
    Friend WithEvents txtSectionNEWID As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtHomeroomIDShow As TextBox
    Friend WithEvents txtshowAycode As TextBox
    Friend WithEvents txtShowDate As TextBox
    Friend WithEvents btnDelete As Button
End Class
