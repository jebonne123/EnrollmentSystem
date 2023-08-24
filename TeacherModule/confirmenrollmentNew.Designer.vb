<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class confirmenrollmentNew
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
        btn = New Button()
        txtShowDate = New TextBox()
        txtshowAycode = New TextBox()
        txtHomeroomIDShow = New TextBox()
        txtshowtID = New TextBox()
        txtSectionNEWID = New TextBox()
        Label1 = New Label()
        txtConfirmstudentNewCode = New TextBox()
        SuspendLayout()
        ' 
        ' btn
        ' 
        btn.Location = New Point(148, 134)
        btn.Name = "btn"
        btn.Size = New Size(94, 31)
        btn.TabIndex = 71
        btn.Text = "OK"
        btn.UseVisualStyleBackColor = True
        ' 
        ' txtShowDate
        ' 
        txtShowDate.Location = New Point(262, 50)
        txtShowDate.Name = "txtShowDate"
        txtShowDate.Size = New Size(104, 23)
        txtShowDate.TabIndex = 66
        txtShowDate.Visible = False
        ' 
        ' txtshowAycode
        ' 
        txtshowAycode.Location = New Point(138, 50)
        txtshowAycode.Name = "txtshowAycode"
        txtshowAycode.Size = New Size(104, 23)
        txtshowAycode.TabIndex = 67
        txtshowAycode.Visible = False
        ' 
        ' txtHomeroomIDShow
        ' 
        txtHomeroomIDShow.Location = New Point(9, 50)
        txtHomeroomIDShow.Name = "txtHomeroomIDShow"
        txtHomeroomIDShow.Size = New Size(104, 23)
        txtHomeroomIDShow.TabIndex = 68
        txtHomeroomIDShow.Visible = False
        ' 
        ' txtshowtID
        ' 
        txtshowtID.Location = New Point(9, 13)
        txtshowtID.Name = "txtshowtID"
        txtshowtID.Size = New Size(104, 23)
        txtshowtID.TabIndex = 70
        txtshowtID.Visible = False
        ' 
        ' txtSectionNEWID
        ' 
        txtSectionNEWID.Location = New Point(138, 12)
        txtSectionNEWID.Name = "txtSectionNEWID"
        txtSectionNEWID.Size = New Size(104, 23)
        txtSectionNEWID.TabIndex = 73
        txtSectionNEWID.Visible = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(24, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(342, 55)
        Label1.TabIndex = 75
        Label1.Text = "Enrolled Successfully!"
        ' 
        ' txtConfirmstudentNewCode
        ' 
        txtConfirmstudentNewCode.Location = New Point(263, 13)
        txtConfirmstudentNewCode.Name = "txtConfirmstudentNewCode"
        txtConfirmstudentNewCode.Size = New Size(104, 23)
        txtConfirmstudentNewCode.TabIndex = 73
        txtConfirmstudentNewCode.Visible = False
        ' 
        ' confirmenrollmentNew
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(379, 178)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(txtConfirmstudentNewCode)
        Controls.Add(txtSectionNEWID)
        Controls.Add(btn)
        Controls.Add(txtShowDate)
        Controls.Add(txtshowAycode)
        Controls.Add(txtHomeroomIDShow)
        Controls.Add(txtshowtID)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "confirmenrollmentNew"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btn As Button
    Friend WithEvents txtShowDate As TextBox
    Friend WithEvents txtshowAycode As TextBox
    Friend WithEvents txtHomeroomIDShow As TextBox
    Friend WithEvents txtshowtID As TextBox
    Friend WithEvents txtSectionNEWID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConfirmstudentNewCode As TextBox
End Class
