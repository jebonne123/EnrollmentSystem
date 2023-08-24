Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHeader.Click, Label1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Me.Dispose()

    End Sub

    Private Sub btnEnrollmentForm_Click(sender As Object, e As EventArgs) Handles btnEnrollmentForm.Click

        enrollmentform.Show()
        Me.Hide()

    End Sub

    Private Sub btnStudentLogin_Click(sender As Object, e As EventArgs) Handles btnStudentLogin.Click

        Me.Hide()
        Form2.Show()

    End Sub
End Class
