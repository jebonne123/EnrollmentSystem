<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel2 = New Panel()
        PictureBox4 = New PictureBox()
        lblTotalTeacher = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        PictureBox5 = New PictureBox()
        lblTotalStudentValue = New Label()
        lblTotalStudentTitle = New Label()
        lblAY = New Label()
        Panel4 = New Panel()
        PictureBox6 = New PictureBox()
        lblTotalPending = New Label()
        Label2 = New Label()
        lblUnenrolledStudents = New Label()
        Panel5 = New Panel()
        lblAcademicYear = New Label()
        Label4 = New Label()
        lblHeader = New Label()
        btnRefresh = New Button()
        TextBox1 = New TextBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        SuspendLayout()
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
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.My_project
        PictureBox3.Location = New Point(321, 293)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(320, 260)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(102))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(lblTotalTeacher)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(34, 62)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(206, 187)
        Panel2.TabIndex = 7
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(96, 32)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(90, 91)
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' lblTotalTeacher
        ' 
        lblTotalTeacher.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalTeacher.ForeColor = SystemColors.ButtonHighlight
        lblTotalTeacher.Location = New Point(3, 49)
        lblTotalTeacher.Name = "lblTotalTeacher"
        lblTotalTeacher.Size = New Size(87, 91)
        lblTotalTeacher.TabIndex = 0
        lblTotalTeacher.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(27, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(158, 32)
        Label3.TabIndex = 0
        Label3.Text = "Total Teacher"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(102))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(PictureBox5)
        Panel3.Controls.Add(lblTotalStudentValue)
        Panel3.Controls.Add(lblTotalStudentTitle)
        Panel3.Location = New Point(265, 62)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(206, 187)
        Panel3.TabIndex = 7
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Location = New Point(96, 32)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(90, 91)
        PictureBox5.TabIndex = 1
        PictureBox5.TabStop = False
        ' 
        ' lblTotalStudentValue
        ' 
        lblTotalStudentValue.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalStudentValue.ForeColor = SystemColors.ButtonHighlight
        lblTotalStudentValue.Location = New Point(16, 49)
        lblTotalStudentValue.Name = "lblTotalStudentValue"
        lblTotalStudentValue.Size = New Size(96, 91)
        lblTotalStudentValue.TabIndex = 0
        lblTotalStudentValue.Text = "0"
        ' 
        ' lblTotalStudentTitle
        ' 
        lblTotalStudentTitle.AutoSize = True
        lblTotalStudentTitle.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalStudentTitle.ForeColor = SystemColors.ButtonHighlight
        lblTotalStudentTitle.Location = New Point(28, 140)
        lblTotalStudentTitle.Name = "lblTotalStudentTitle"
        lblTotalStudentTitle.Size = New Size(159, 32)
        lblTotalStudentTitle.TabIndex = 0
        lblTotalStudentTitle.Text = "Total Student"
        ' 
        ' lblAY
        ' 
        lblAY.AutoSize = True
        lblAY.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblAY.ForeColor = SystemColors.ButtonHighlight
        lblAY.Location = New Point(-2, 63)
        lblAY.Name = "lblAY"
        lblAY.Size = New Size(211, 47)
        lblAY.TabIndex = 0
        lblAY.Text = "2022 - 2023"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(102))
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(PictureBox6)
        Panel4.Controls.Add(lblTotalPending)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(lblUnenrolledStudents)
        Panel4.Location = New Point(500, 62)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(206, 187)
        Panel4.TabIndex = 7
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Location = New Point(96, 32)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(90, 91)
        PictureBox6.TabIndex = 1
        PictureBox6.TabStop = False
        ' 
        ' lblTotalPending
        ' 
        lblTotalPending.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalPending.ForeColor = SystemColors.ButtonHighlight
        lblTotalPending.Location = New Point(16, 50)
        lblTotalPending.Name = "lblTotalPending"
        lblTotalPending.Size = New Size(96, 90)
        lblTotalPending.TabIndex = 0
        lblTotalPending.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(42, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 25)
        Label2.TabIndex = 0
        Label2.Text = "New Student"
        ' 
        ' lblUnenrolledStudents
        ' 
        lblUnenrolledStudents.AutoSize = True
        lblUnenrolledStudents.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblUnenrolledStudents.ForeColor = SystemColors.ButtonHighlight
        lblUnenrolledStudents.Location = New Point(28, 137)
        lblUnenrolledStudents.Name = "lblUnenrolledStudents"
        lblUnenrolledStudents.Size = New Size(150, 25)
        lblUnenrolledStudents.TabIndex = 0
        lblUnenrolledStudents.Text = "Total of Pending"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(102))
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(lblAcademicYear)
        Panel5.Controls.Add(lblAY)
        Panel5.Location = New Point(736, 62)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(206, 187)
        Panel5.TabIndex = 7
        ' 
        ' lblAcademicYear
        ' 
        lblAcademicYear.AutoSize = True
        lblAcademicYear.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblAcademicYear.ForeColor = SystemColors.ButtonHighlight
        lblAcademicYear.Location = New Point(14, 140)
        lblAcademicYear.Name = "lblAcademicYear"
        lblAcademicYear.Size = New Size(173, 32)
        lblAcademicYear.TabIndex = 0
        lblAcademicYear.Text = "Academic Year"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(367, 598)
        Label4.Name = "Label4"
        Label4.Size = New Size(274, 28)
        Label4.TabIndex = 8
        Label4.Text = "Laguindingan Misamis Oriental"
        ' 
        ' lblHeader
        ' 
        lblHeader.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeader.Location = New Point(332, 556)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(356, 51)
        lblHeader.TabIndex = 9
        lblHeader.Text = "Sinai Elementary School"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(102))
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Popup
        btnRefresh.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.ForeColor = SystemColors.ControlLightLight
        btnRefresh.Location = New Point(34, 629)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Padding = New Padding(13, 0, 0, 5)
        btnRefresh.Size = New Size(108, 32)
        btnRefresh.TabIndex = 10
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(55, 288)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(139, 23)
        TextBox1.TabIndex = 11
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(977, 673)
        ControlBox = False
        Controls.Add(TextBox1)
        Controls.Add(btnRefresh)
        Controls.Add(Label4)
        Controls.Add(lblHeader)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(PictureBox3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblTotalStudentValue As Label
    Friend WithEvents lblAY As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblTotalPending As Label
    Friend WithEvents lblUnenrolledStudents As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblAcademicYear As Label
    Friend WithEvents lblTotalStudentTitle As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblTotalTeacher As Label
    Friend WithEvents Label3 As Label
End Class
