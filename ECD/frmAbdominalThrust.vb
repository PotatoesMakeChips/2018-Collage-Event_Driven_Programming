Public Class frmAbdominalThrust
    Private Sub btnAbThrAns_Click(sender As Object, e As EventArgs) Handles btnAbThrAns.Click 'Moves onto the next question when the user clicks the button and saves the answer
        If cbAbThrTrue.Checked = True And cbAbThrFalse.Checked = False Then
            clsStorage.ansAbThr = "True"
            frmRecoveryPosition.Show()
            Me.Close()
        ElseIf cbAbThrTrue.Checked = False And cbAbThrFalse.Checked = True Then
            clsStorage.ansAbThr = "False"
            frmRecoveryPosition.Show()
            Me.Close()
        Else
            MsgBox("Select one answer")
        End If
    End Sub
End Class