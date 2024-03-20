Public Class Form1

    Dim intCountTask As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If inputTask.Text = "" Then
            inputTask.Text = InputBox("Do you forget to add task, Please enter Task!", "Enter Task", "coding!")

        Else
            intCountTask = intCountTask + 1
            TaskBox.Items.Add("-" & intCountTask & ". " & inputTask.Text)
            inputTask.Select()
            inputTask.Text = ""
        End If


    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        TaskBox.Items.RemoveAt(TaskBox.SelectedIndex)
        MsgBox("Task number - " & intCountTask & " removed", vbInformation, "Task Removed")

        intCountTask = intCountTask - 1
    End Sub

End Class
