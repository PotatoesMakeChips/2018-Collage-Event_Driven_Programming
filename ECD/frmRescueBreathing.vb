Public Class frmRescueBreathing
    Private Sub btnResBreAns_Click(sender As Object, e As EventArgs) Handles btnResBreAns.Click 'Moves onto the next question when the user clicks the button and saves the answer
        If cbResBreTrue.Checked = True And cbResBreFalse.Checked = False Then
            clsStorage.ansResBre = "True"
            frmAbdominalThrust.Show()
            Me.Close()
        ElseIf cbResBreTrue.Checked = False And cbResBreFalse.Checked = True Then
            clsStorage.ansResBre = "False"
            frmAbdominalThrust.Show()
            Me.Close()
        Else
            MsgBox("Select one answer")
        End If

    End Sub
End Class