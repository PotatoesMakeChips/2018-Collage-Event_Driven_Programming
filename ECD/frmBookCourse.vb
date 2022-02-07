Public Class frmBookCourse
    Dim Currentvalue As Date = Nothing

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DatePicker.ValueChanged 'Runs code to check weththe date selected was a weekend without the need for the user to click another button
        Dim i As Integer = DatePicker.Value.DayOfWeek
        If i = 0 Or i = 6 Then
            If Not Currentvalue = Nothing Then DatePicker.Value = Currentvalue
            MsgBox("Please try again, can't select a weekend day")
        Else
            Currentvalue = DatePicker.Value
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click 'Opens the main menu form when the user clicks the button
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBook.Click 'Runs code to book the course and displays a confirmation message box when the user clicks the button
        If txtName.Text IsNot "" And txtEmail.Text IsNot "" And cmbNumPeople.Text IsNot "" And cmbTime.Text IsNot "" Then
            'checks boxes not empty
            MsgBox(txtName.Text + " has booked a course on the " + DatePicker.Text + " at " + cmbTime.Text + " for " + cmbNumPeople.Text + " people. It will cost " + txtCost.Text + ". Their email is " + txtEmail.Text)
        Else
            MsgBox("Fill all fields")
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNumPeople.SelectedIndexChanged 'Runs code to calculate and display the cost of the course for that number of people without the need for the user to click another button
        Dim person As String = CInt(cmbNumPeople.Text)
        Dim cost As Integer = person * 120
        txtCost.Text = "£" + cost.ToString
    End Sub

    Private Sub frmBookCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class