Public Class frmRecoveryPosition
    Private Sub btnRecPosAns_Click(sender As Object, e As EventArgs) Handles btnRecPosAns.Click 'Moves onto the next question when the user clicks the button and saves the answer
        If cbRecPosTrue.Checked = True And cbRecPosFalse.Checked = False Then
            clsStorage.ansRecPos = "True"
            frmResults.Show()
            Me.Close()
        ElseIf cbRecPosTrue.Checked = False And cbRecPosFalse.Checked = True Then
            clsStorage.ansRecPos = "False"
            frmResults.Show()
            Me.Close()
        Else
            MsgBox("Select one answer")
        End If
    End Sub
End Class