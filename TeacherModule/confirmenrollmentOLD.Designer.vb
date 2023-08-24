<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class confirmenrollmentOLD
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
        txtShowSectOLDID = New TextBox()
        txtshowtID = New TextBox()
        txtOldStudentSCode = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btn
        ' 
        btn.Location = New Point(151, 143)
        btn.Name = "btn"
        btn.Size = New Size(94, 31)
        btn.TabIndex = 64
        btn.Text = "OK"
        btn.UseVisualStyleBackColor = True
        ' 
        ' txtShowDate
        ' 
        txtShowDate.Location = New Point(265, 59)
        txtShowDate.Name = "txtShowDate"
        txtShowDate.Size = New Size(104, 23)
        txtShowDate.TabIndex = 58
        txtShowDate.Visible = False
        ' 
        ' txtshowAycode
        ' 
        txtshowAycode.Location = New Point(141, 59)
        txtshowAycode.Name = "txtshowAycode"
        txtshowAycode.Size = New Size(104, 23)
        txtshowAycode.TabIndex = 59
        txtshowAycode.Visible = False
        ' 
        ' txtHomeroomIDShow
        ' 
        txtHomeroomIDShow.Location = New Point(12, 50)
        txtHomeroomIDShow.Name = "txtHomeroomIDShow"
        txtHomeroomIDShow.Size = New Size(104, 23)
        txtHomeroomIDShow.TabIndex = 60
        txtHomeroomIDShow.Visible = False
        ' 
        ' txtShowSectOLDID
        ' 
        txtShowSectOLDID.Location = New Point(141, 12)
        txtShowSectOLDID.Name = "txtShowSectOLDID"
        txtShowSectOLDID.Size = New Size(104, 23)
        txtShowSectOLDID.TabIndex = 62
        txtShowSectOLDID.Visible = False
        ' 
        ' txtshowtID
        ' 
        txtshowtID.Location = New Point(12, 12)
        txtshowtID.Name = "txtshowtID"
        txtshowtID.Size = New Size(104, 23)
        txtshowtID.TabIndex = 63
        txtshowtID.Visible = False
        ' 
        ' txtOldStudentSCode
        ' 
        txtOldStudentSCode.Location = New Point(265, 12)
        txtOldStudentSCode.Name = "txtOldStudentSCode"
        txtOldStudentSCode.Size = New Size(108, 23)
        txtOldStudentSCode.TabIndex = 65
        txtOldStudentSCode.Visible = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(27, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(342, 75)
        Label1.TabIndex = 76
        Label1.Text = "Enrolled Successfully!"
        ' 
        ' confirmenrollmentOLD
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(379, 186)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(txtOldStudentSCode)
        Controls.Add(btn)
        Controls.Add(txtShowDate)
        Controls.Add(txtshowAycode)
        Controls.Add(txtHomeroomIDShow)
        Controls.Add(txtShowSectOLDID)
        Controls.Add(txtshowtID)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "confirmenrollmentOLD"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn As Button
    Friend WithEvents txtShowDate As TextBox
    Friend WithEvents txtshowAycode As TextBox
    Friend WithEvents txtHomeroomIDShow As TextBox
    Friend WithEvents txtShowSectOLDID As TextBox
    Friend WithEvents txtshowtID As TextBox
    Friend WithEvents txtOldStudentSCode As TextBox
    Friend WithEvents Label1 As Label
End Class
