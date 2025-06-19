Public Class Dinein
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim name As String = txtName.Text.Trim()
        Dim peopleCount As String = txtPeople.Text.Trim()

        If name = "" OrElse peopleCount = "" OrElse Not IsNumeric(peopleCount) Then
            MessageBox.Show("Please enter a valid name and number of people.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' ✅ Create queue entry
        Dim queueNumber As Integer = Admin.NextQueueNumber
        Dim entry As String = $"Queue #{queueNumber} - {name} ({peopleCount} people)"

        ' ✅ Add to shared queue display
        If Admin.DineinQueueForm Is Nothing OrElse Admin.DineinQueueForm.IsDisposed Then
            Admin.DineinQueueForm = New FormDinein()
        End If
        Admin.DineinQueueForm.AddQueueItem(entry)

        ' ✅ Show message to user with their queue number
        MessageBox.Show($"Thank you! Your queue number is #{queueNumber}", "Added to Queue", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' ✅ Increment queue number for next person
        Admin.NextQueueNumber += 1

        ' ✅ Clear input fields for next user
        txtName.Text = ""
        txtPeople.Text = ""
        txtName.Focus()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblGoToReservation.Click
        Me.Hide()
        Dim resForm As New Reservation()
        resForm.Show()
    End Sub

    Private Sub Dinein_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: show login before entering this form
        Me.Hide()
        Dim lForm As New CustomerLoginForm()
        lForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim lForm As New CustomerLoginForm()
        lForm.Show()
    End Sub
End Class
