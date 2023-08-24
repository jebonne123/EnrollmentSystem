<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginform
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(loginform))
        Button1 = New Button()
        btnLogin = New Button()
        lblPassword = New Label()
        lblUsername = New Label()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(111, 307)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 32)
        Button1.TabIndex = 9
        Button1.Text = "Forgot password"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(146, 269)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 32)
        btnLogin.TabIndex = 10
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(56, 246)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(66, 17)
        lblPassword.TabIndex = 7
        lblPassword.Text = "Password"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(56, 215)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(69, 17)
        lblUsername.TabIndex = 8
        lblUsername.Text = "Username"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(131, 238)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(107, 25)
        txtPassword.TabIndex = 5
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(131, 207)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(107, 25)
        txtUsername.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.My_project
        PictureBox1.Location = New Point(131, 74)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(107, 105)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(318, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(27, 28)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' loginform
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(357, 414)
        ControlBox = False
        Controls.Add(PictureBox2)
        Controls.Add(Button1)
        Controls.Add(btnLogin)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "loginform"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
