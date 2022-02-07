Public Class frmCPR
    Private Sub btnCprAns_Click(sender As Object, e As EventArgs) Handles btnCprAns.Click 'Moves onto the next question when the user clicks the button and saves the answer
        If cbCprTrue.Checked = True And cbCprFalse.Checked = False Then
            clsStorage.ansCPR = "True"
            frmRescueBreathing.Show()
            Me.Close()
        ElseIf cbCprTrue.Checked = False And cbCprFalse.Checked = True Then
            clsStorage.ansCPR = "False"
            frmRescueBreathing.Show()
            Me.Close()
        Else
            MsgBox("Select one answer")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged 'Mutes or unmutes the background music when the user changes the state of the mute checkbox
        If CheckBox1.Checked = True Then
            My.Computer.Audio.Stop()
        Else
            My.Computer.Audio.Play(clsStorage.varAppPath + "\song.wav")
        End If
    End Sub

    Private Sub frmCPR_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Plays the staying alive music
        My.Computer.Audio.Play(clsStorage.varAppPath + "\song.wav")
    End Sub

End Class