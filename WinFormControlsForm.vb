Public Class WinFormControlsForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim message As String
        Dim userAge As Integer

        EvaluateCheckboxes()

        If FirstNameTextBox.Text = "" Then
            message = "First name is required" & vbNewLine
        End If

        If LastNameTextBox.Text = "" Then
            message &= "Last name is required" & vbNewLine
        End If

        'If AgeTextBox.Text = "" Then
        '    message &= "Age name is required" & vbNewLine
        'End If

        'make sure age is a number
        Try
            userAge = CInt(AgeTextBox.Text)

            Select Case userAge
                Case 0 To 5
                    message = "You are too young to ride" & vbNewLine
                Case 6 To 17
                    message = "Where are your parents?" & vbNewLine
                Case 18 To 45
                    message = "Ride at your own risk" & vbNewLine
                Case >= 46
                    message = "Are you looking for the buffet?" & vbNewLine
                Case Else
                    message = "well this is weird..." & vbNewLine
            End Select

        Catch
            message &= "Age must be whole number" & vbNewLine
        End Try

        If message <> "" Then
            MsgBox(message)
        End If

        'MsgBox("Yippeee!!!")
    End Sub

    Sub EvaluateCheckboxes()
        If CheckBox1.Checked = True Then
            MsgBox("The box is checked!")
        End If
    End Sub

    Private Sub WinFormControlsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        RadioButton1.Checked = True
        RadioButton4.Checked = True

        ToolStripTextBox1.Text = "hello"
    End Sub

End Class
