Public Class frmMainMenu
    Private Sub btnBookCourse_Click(sender As Object, e As EventArgs) Handles btnBookCourse.Click  'Opens the book course form when the user clicks the button
        frmBookCourse.Show()
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click 'Opens the help web page when the user clicks the button
        Process.Start(My.Application.Info.DirectoryPath + "\help.html")
    End Sub

    Private Sub btnECD_Click(sender As Object, e As EventArgs) Handles btnECD.Click 'Opens the first question when the user clicks the button
        frmCPR.Show()
        Me.Close()
    End Sub

End Class
