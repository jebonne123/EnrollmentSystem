Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports MySql.Data.MySqlClient

Public Class mainform

    Public Shared sqlConnection As MySqlConnection
    Public Shared sqlCmd As MySqlCommand
    Public Shared sqlReader As MySqlDataReader
    Public Shared sqlData As DataTable
    Private bitmap As Bitmap

    Dim Query As String
    Dim TotalPending As String

    Sub switchPanel(ByVal panel As Form)
        Panel6.Controls.Clear()
        panel.TopLevel = False
        Panel6.Controls.Add(panel)
        panel.Show()


    End Sub

    Private Sub btnEnrollment_Click(sender As Object, e As EventArgs) Handles btnEnrollment.Click

        switchPanel(Enrollmentforms)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Hide()
        loginform.Show()

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

        switchPanel(Dashboard)

    End Sub

    Private Sub btnSections_Click(sender As Object, e As EventArgs) Handles btnClasslist.Click

        switchPanel(classlist)

    End Sub

    Private Sub btnPupils_Click(sender As Object, e As EventArgs) Handles btnPupils.Click

        switchPanel(Pupils)

    End Sub
End Class