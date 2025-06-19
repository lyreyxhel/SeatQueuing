Public Class Admin
    Private currentbtn As Button
    Private leftborderbtn As Panel

    ' Shared forms
    Public Shared DineinQueueForm As New FormDinein()
    Public Shared ReservationForm As New Reservation()
    Public Shared ReservationQueueForm As New FormReservation()

    ' Dinein Queue Number
    Public Shared NextQueueNumber As Integer = 1

    ' Reservation queue number
    Public Shared NextReservationQueueNumber As Integer = 1


    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change_menu("Dine-in Queue") ' Show queue by default
    End Sub

    Public Shared Sub ShowAdmin()
        Static adminInstance As Admin = Nothing
        If adminInstance Is Nothing OrElse adminInstance.IsDisposed Then
            adminInstance = New Admin()
        End If
        adminInstance.Show()
    End Sub

    Public Sub New()
        InitializeComponent()
        leftborderbtn = New Panel()
        leftborderbtn.Size = New Size(7, 71)
        SidePanel.Controls.Add(leftborderbtn)
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisabledButton()
            currentbtn = CType(senderBtn, Button)
            currentbtn.BackColor = Color.FromArgb(44, 62, 80)
            currentbtn.ForeColor = Color.White

            leftborderbtn.BackColor = customColor
            leftborderbtn.Location = New Point(0, currentbtn.Location.Y)
            leftborderbtn.Visible = True
            leftborderbtn.BringToFront()
        End If
    End Sub

    Private Sub DisabledButton()
        If currentbtn IsNot Nothing Then
            currentbtn.BackColor = Color.FromArgb(44, 62, 80)
            currentbtn.ForeColor = Color.White
        End If
    End Sub

    Private Sub addForm(frm As Form)
        PanelContains.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PanelContains.Controls.Add(frm)
        frm.Show()
        frm.BringToFront()
        frm.Focus()
    End Sub

    Private Sub change_menu(menu As String)
        Select Case menu
            Case "Dine-in Queue"
                addForm(DineinQueueForm)
            Case "Reservation"
                addForm(ReservationForm)
            Case "Reservation Queue"
                addForm(ReservationQueueForm)
        End Select
    End Sub

    ' 👉 Opens the Dinein input form (separate form)
    Private Sub btnDinein_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, Color.FromArgb(0, 126, 249))
        Dim inputForm As New Dinein
        inputForm.Show()
        Hide()
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, Color.FromArgb(0, 126, 249))
        change_menu("Reservation")
    End Sub

    Private Sub btnDineinQueue_Click(sender As Object, e As EventArgs) Handles btnDineinQueue.Click
        ActivateButton(sender, Color.FromArgb(200, 20, 60))
        change_menu("Dine-in Queue")
    End Sub

    Private Sub btnReservationQueue_Click(sender As Object, e As EventArgs) Handles btnReservationQueue.Click
        ActivateButton(sender, Color.FromArgb(200, 20, 60))
        change_menu("Reservation Queue")
    End Sub

    Private Sub SidePanel_Paint(sender As Object, e As PaintEventArgs) Handles SidePanel.Paint
        ' Optional
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Dim lForm As New CustomerLoginForm()
        lForm.Show()    
    End Sub
End Class