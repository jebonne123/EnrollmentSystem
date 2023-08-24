<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        lblHeader = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        btnEnrollmentForm = New Button()
        PictureBox4 = New PictureBox()
        btnStudentLogin = New Button()
        PictureBox5 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.My_project
        PictureBox1.Location = New Point(123, 84)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(107, 105)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' lblHeader
        ' 
        lblHeader.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeader.Location = New Point(63, 204)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(231, 28)
        lblHeader.TabIndex = 6
        lblHeader.Text = "Sinai Elementary School"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(87, 232)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 28)
        Label1.TabIndex = 6
        Label1.Text = "Laguindingan Misamis Oriental"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(-3, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(362, 40)
        Panel1.TabIndex = 7
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(328, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(27, 28)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' btnEnrollmentForm
        ' 
        btnEnrollmentForm.Cursor = Cursors.Hand
        btnEnrollmentForm.Location = New Point(123, 314)
        btnEnrollmentForm.Name = "btnEnrollmentForm"
        btnEnrollmentForm.Size = New Size(114, 34)
        btnEnrollmentForm.TabIndex = 8
        btnEnrollmentForm.Text = "Enrollment form"
        btnEnrollmentForm.UseVisualStyleBackColor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(77, 314)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(34, 34)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        ' 
        ' btnStudentLogin
        ' 
        btnStudentLogin.Cursor = Cursors.Hand
        btnStudentLogin.Location = New Point(123, 274)
        btnStudentLogin.Name = "btnStudentLogin"
        btnStudentLogin.Size = New Size(114, 34)
        btnStudentLogin.TabIndex = 8
        btnStudentLogin.Text = "Student login"
        btnStudentLogin.UseVisualStyleBackColor = True
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(77, 274)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(34, 34)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 9
        PictureBox5.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(357, 414)
        ControlBox = False
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox5)
        Controls.Add(btnEnrollmentForm)
        Controls.Add(btnStudentLogin)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(lblHeader)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnEnrollmentForm As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnStudentLogin As Button
    Friend WithEvents PictureBox5 As PictureBox
End Class
