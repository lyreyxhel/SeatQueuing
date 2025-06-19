Public Class Reservation
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddd.Click
        Dim name As String = txtNamee.Text.Trim()
        Dim peopleCount As String = txtPeoplee.Text.Trim()

        If name = "" OrElse peopleCount = "" OrElse Not IsNumeric(peopleCount) Then
            MessageBox.Show("Please enter a valid name and number of people.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' ✅ Use Reservation Queue Number
        Dim queueNumber As Integer = Admin.NextReservationQueueNumber
        Dim entry As String = $"Reservation #{queueNumber} - {name} ({peopleCount} people)"

        ' ✅ Add to Reservation Queue Form
        If Admin.ReservationQueueForm Is Nothing OrElse Admin.ReservationQueueForm.IsDisposed Then
            Admin.ReservationQueueForm = New FormReservation()
        End If
        Admin.ReservationQueueForm.AddQueueItem(entry)

        ' ✅ Show confirmation
        MessageBox.Show($"Thank you! Your reservation number is #{queueNumber}", "Added to Queue", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' ✅ Increment only Reservation queue number
        Admin.NextReservationQueueNumber += 1

        ' ✅ Clear for next input
        txtNamee.Text = ""
        txtPeoplee.Text = ""
        txtNamee.Focus()
    End Sub


    Private Sub lblGoToDinein_Click(sender As Object, e As EventArgs) Handles lblGoToDinein.Click
        Me.Hide()
        Dim dForm As New Dinein()
        dForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim lForm As New CustomerLoginForm()
        lForm.Show()
    End Sub

    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
