Public Class previewform

    Public Shared test As String

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Me.Close()
        Form1.Show()

    End Sub
End Class