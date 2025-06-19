Public Class FormReservation
    Public Shared Instance As FormReservation
    Private ServingTimers As New Dictionary(Of String, Timer)

    Private Sub FormDinein_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Instance = Me
    End Sub

    Public Sub AddQueueItem(entry As String)
        lstQueueDisplay.Items.Add(entry)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDeletee.Click
        If lstServing.SelectedIndex <> -1 Then
            Dim selectedItem As String = lstServing.SelectedItem.ToString()
            Dim result = MessageBox.Show($"Are you sure you want to remove: {selectedItem}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                lstServing.Items.RemoveAt(lstServing.SelectedIndex)

                ' If the item has a timer, stop and remove it
                If ServingTimers.ContainsKey(selectedItem) Then
                    ServingTimers(selectedItem).Stop()
                    ServingTimers(selectedItem).Dispose()
                    ServingTimers.Remove(selectedItem)
                End If
            End If
        Else
            MessageBox.Show("Please select a serving item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub btnServe_Click(sender As Object, e As EventArgs) Handles btnServe.Click
        If lstQueueDisplay.Items.Count > 0 Then
            Dim firstInQueue As String = lstQueueDisplay.Items(0).ToString()
            lstQueueDisplay.Items.RemoveAt(0)
            lstServing.Items.Add(firstInQueue)


            Dim deleteTimer As New Timer()
            deleteTimer.Interval = 300000 ' 30 second in milliseconds
            AddHandler deleteTimer.Tick, Sub(senderTimer, eTimer)
                                             If lstServing.Items.Contains(firstInQueue) Then
                                                 lstServing.Items.Remove(firstInQueue)
                                             End If
                                             ServingTimers.Remove(firstInQueue)
                                             deleteTimer.Stop()
                                             deleteTimer.Dispose()
                                         End Sub
            ServingTimers.Add(firstInQueue, deleteTimer)
            deleteTimer.Start()
        Else
            MessageBox.Show("No one is in the queue.", "Queue Empty", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
