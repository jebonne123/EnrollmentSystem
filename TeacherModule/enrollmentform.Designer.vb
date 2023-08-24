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
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        txtLastname = New TextBox()
        txtFirstname = New TextBox()
        txtStudentID = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnReset = New Button()
        btnDelete = New Button()
        btnEnroll = New Button()
        Panel2 = New Panel()
        dateEnrollment = New DateTimePicker()
        ComboBox1 = New ComboBox()
        cbxSection = New ComboBox()
        Panel6 = New Panel()
        Label8 = New Label()
        Panel5 = New Panel()
        Label1 = New Label()
        txtEnrollForm_ID = New TextBox()
        txtBirthdate = New TextBox()
        txtGradelevel = New TextBox()
        txtPlaceOfBirth = New TextBox()
        lblGradeLevel = New Label()
        txtGender = New TextBox()
        Label7 = New Label()
        txtMiddlename = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Mname = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label12 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        DataGridView1 = New DataGridView()
        Panel7 = New Panel()
        Label9 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        SuspendLayout()
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
        Panel1.TabIndex = 4
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
        ' txtLastname
        ' 
        txtLastname.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtLastname.Location = New Point(272, 256)
        txtLastname.Multiline = True
        txtLastname.Name = "txtLastname"
        txtLastname.ReadOnly = True
        txtLastname.Size = New Size(214, 29)
        txtLastname.TabIndex = 43
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtFirstname.Location = New Point(19, 256)
        txtFirstname.Multiline = True
        txtFirstname.Name = "txtFirstname"
        txtFirstname.ReadOnly = True
        txtFirstname.Size = New Size(214, 29)
        txtFirstname.TabIndex = 44
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudentID.Location = New Point(16, 69)
        txtStudentID.Multiline = True
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(388, 25)
        txtStudentID.TabIndex = 45
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(276, 238)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 15)
        Label4.TabIndex = 37
        Label4.Text = "Last name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(25, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 15)
        Label3.TabIndex = 38
        Label3.Text = "First name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(16, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 20)
        Label2.TabIndex = 39
        Label2.Text = "Student LRN"
        ' 
        ' btnReset
        ' 
        btnReset.FlatAppearance.BorderColor = Color.Black
        btnReset.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnReset.Location = New Point(25, 216)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(160, 45)
        btnReset.TabIndex = 46
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.FlatAppearance.BorderColor = Color.Black
        btnDelete.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.Location = New Point(25, 165)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(160, 45)
        btnDelete.TabIndex = 47
        btnDelete.Text = "Unenroll"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEnroll
        ' 
        btnEnroll.FlatAppearance.BorderColor = Color.Black
        btnEnroll.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnEnroll.Location = New Point(25, 114)
        btnEnroll.Name = "btnEnroll"
        btnEnroll.Size = New Size(160, 45)
        btnEnroll.TabIndex = 48
        btnEnroll.Text = "Enroll"
        btnEnroll.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(dateEnrollment)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(cbxSection)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(txtEnrollForm_ID)
        Panel2.Controls.Add(txtBirthdate)
        Panel2.Controls.Add(txtGradelevel)
        Panel2.Controls.Add(txtPlaceOfBirth)
        Panel2.Controls.Add(lblGradeLevel)
        Panel2.Controls.Add(txtGender)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(txtMiddlename)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(txtLastname)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txtFirstname)
        Panel2.Controls.Add(Mname)
        Panel2.Controls.Add(txtStudentID)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(0, 27)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(758, 413)
        Panel2.TabIndex = 49
        ' 
        ' dateEnrollment
        ' 
        dateEnrollment.CustomFormat = "yyyy-MM-dd"
        dateEnrollment.Location = New Point(17, 146)
        dateEnrollment.Name = "dateEnrollment"
        dateEnrollment.Size = New Size(387, 25)
        dateEnrollment.TabIndex = 52
        dateEnrollment.Value = New DateTime(2023, 5, 30, 0, 0, 0, 0)
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"2022 - 2023"})
        ComboBox1.Location = New Point(481, 145)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(188, 25)
        ComboBox1.TabIndex = 51
        ' 
        ' cbxSection
        ' 
        cbxSection.DropDownStyle = ComboBoxStyle.DropDownList
        cbxSection.FormattingEnabled = True
        cbxSection.Items.AddRange(New Object() {"Loyal", "Respectful"})
        cbxSection.Location = New Point(481, 69)
        cbxSection.Name = "cbxSection"
        cbxSection.Size = New Size(188, 25)
        cbxSection.TabIndex = 51
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.AppWorkspace
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Label8)
        Panel6.ForeColor = SystemColors.ControlText
        Panel6.Location = New Point(0, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(758, 25)
        Panel6.TabIndex = 50
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(323, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(109, 20)
        Label8.TabIndex = 38
        Label8.Text = "ENROLLMENT"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.AppWorkspace
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Label1)
        Panel5.ForeColor = SystemColors.ControlText
        Panel5.Location = New Point(0, 207)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(758, 25)
        Panel5.TabIndex = 50
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(278, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(205, 20)
        Label1.TabIndex = 38
        Label1.Text = "ENROLLEE'S INFORMATION"
        ' 
        ' txtEnrollForm_ID
        ' 
        txtEnrollForm_ID.Location = New Point(525, 374)
        txtEnrollForm_ID.Name = "txtEnrollForm_ID"
        txtEnrollForm_ID.Size = New Size(204, 25)
        txtEnrollForm_ID.TabIndex = 49
        txtEnrollForm_ID.Visible = False
        ' 
        ' txtBirthdate
        ' 
        txtBirthdate.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtBirthdate.Location = New Point(270, 319)
        txtBirthdate.Multiline = True
        txtBirthdate.Name = "txtBirthdate"
        txtBirthdate.ReadOnly = True
        txtBirthdate.Size = New Size(214, 29)
        txtBirthdate.TabIndex = 43
        ' 
        ' txtGradelevel
        ' 
        txtGradelevel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtGradelevel.Location = New Point(270, 374)
        txtGradelevel.Multiline = True
        txtGradelevel.Name = "txtGradelevel"
        txtGradelevel.ReadOnly = True
        txtGradelevel.Size = New Size(214, 29)
        txtGradelevel.TabIndex = 43
        ' 
        ' txtPlaceOfBirth
        ' 
        txtPlaceOfBirth.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtPlaceOfBirth.Location = New Point(525, 319)
        txtPlaceOfBirth.Multiline = True
        txtPlaceOfBirth.Name = "txtPlaceOfBirth"
        txtPlaceOfBirth.ReadOnly = True
        txtPlaceOfBirth.Size = New Size(214, 29)
        txtPlaceOfBirth.TabIndex = 43
        ' 
        ' lblGradeLevel
        ' 
        lblGradeLevel.AutoSize = True
        lblGradeLevel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblGradeLevel.Location = New Point(270, 356)
        lblGradeLevel.Name = "lblGradeLevel"
        lblGradeLevel.Size = New Size(120, 15)
        lblGradeLevel.TabIndex = 37
        lblGradeLevel.Text = "Grade level to Enroll"
        ' 
        ' txtGender
        ' 
        txtGender.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtGender.Location = New Point(19, 319)
        txtGender.Multiline = True
        txtGender.Name = "txtGender"
        txtGender.ReadOnly = True
        txtGender.Size = New Size(214, 29)
        txtGender.TabIndex = 43
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(531, 301)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 15)
        Label7.TabIndex = 37
        Label7.Text = "PlaceOfBirth"
        ' 
        ' txtMiddlename
        ' 
        txtMiddlename.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtMiddlename.Location = New Point(525, 256)
        txtMiddlename.Multiline = True
        txtMiddlename.Name = "txtMiddlename"
        txtMiddlename.ReadOnly = True
        txtMiddlename.Size = New Size(214, 29)
        txtMiddlename.TabIndex = 43
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(276, 301)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 15)
        Label6.TabIndex = 37
        Label6.Text = "Birthdate"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(25, 301)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 15)
        Label5.TabIndex = 37
        Label5.Text = "Gender"
        ' 
        ' Mname
        ' 
        Mname.AutoSize = True
        Mname.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Mname.Location = New Point(531, 238)
        Mname.Name = "Mname"
        Mname.Size = New Size(79, 15)
        Mname.TabIndex = 37
        Mname.Text = "Middle name"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(481, 122)
        Label11.Name = "Label11"
        Label11.Size = New Size(111, 20)
        Label11.TabIndex = 39
        Label11.Text = "Academic Year"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(481, 46)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 20)
        Label10.TabIndex = 39
        Label10.Text = "Section"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(19, 122)
        Label12.Name = "Label12"
        Label12.Size = New Size(42, 20)
        Label12.TabIndex = 39
        Label12.Text = "Date"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientActiveCaption
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Panel4)
        Panel3.Location = New Point(757, 27)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(220, 413)
        Panel3.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Gainsboro
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(btnDelete)
        Panel4.Controls.Add(btnReset)
        Panel4.Controls.Add(btnEnroll)
        Panel4.Location = New Point(10, 9)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(202, 390)
        Panel4.TabIndex = 49
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 460)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(977, 214)
        DataGridView1.TabIndex = 50
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.AppWorkspace
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(Label9)
        Panel7.ForeColor = SystemColors.ControlText
        Panel7.Location = New Point(0, 436)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(977, 25)
        Panel7.TabIndex = 50
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(407, 2)
        Label9.Name = "Label9"
        Label9.Size = New Size(233, 21)
        Label9.TabIndex = 38
        Label9.Text = "LIST OF PENDING ENROLLEES"
        ' 
        ' enrollmentform
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(977, 673)
        ControlBox = False
        Controls.Add(DataGridView1)
        Controls.Add(Panel7)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "enrollmentform"
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEnroll As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtPlaceOfBirth As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Mname As Label
    Friend WithEvents txtGradelevel As TextBox
    Friend WithEvents lblGradeLevel As Label
    Friend WithEvents txtEnrollForm_ID As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cbxSection As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dateEnrollment As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBirthdate As TextBox
End Class
