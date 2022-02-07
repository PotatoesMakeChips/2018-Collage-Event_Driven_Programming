Public Class frmResults
    Private Sub frmResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Calculates the overall score from the quiz without the need for the user to create an event themselves 
        Dim q1 As String = "True"
        Dim q2 As String = "False"
        Dim q3 As String = "False"
        Dim q4 As String = "True"
        Dim score As Integer = 0
        If clsStorage.ansCPR = q1 Then
            score = score + 1
        End If
        If clsStorage.ansResBre = q2 Then
            score = score + 1
        End If
        If clsStorage.ansAbThr = q3 Then
            score = score + 1
        End If
        If clsStorage.ansRecPos = q4 Then
            score = score + 1
        End If
        Label2.Text = score
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click 'Opens the main menu and closes the results form
        frmMainMenu.Show()
        Me.Close()
    End Sub
End Class