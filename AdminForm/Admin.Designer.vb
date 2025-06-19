<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        PanelContain = New Panel()
        PanelContainer = New Panel()
        SidePanel = New Panel()
        btnLogout = New Button()
        btnReservationQueue = New Button()
        btnDineinQueue = New Button()
        PanelContains = New Panel()
        Panel1.SuspendLayout()
        SidePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(220), CByte(29), CByte(60))
        Panel1.Controls.Add(PanelContain)
        Panel1.Controls.Add(PanelContainer)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 19)
        Panel1.TabIndex = 0
        ' 
        ' PanelContain
        ' 
        PanelContain.Location = New Point(202, 19)
        PanelContain.Name = "PanelContain"
        PanelContain.Size = New Size(598, 431)
        PanelContain.TabIndex = 2
        ' 
        ' PanelContainer
        ' 
        PanelContainer.Location = New Point(202, 19)
        PanelContainer.Name = "PanelContainer"
        PanelContainer.Size = New Size(598, 431)
        PanelContainer.TabIndex = 2
        ' 
        ' SidePanel
        ' 
        SidePanel.BackColor = Color.FromArgb(CByte(41), CByte(39), CByte(40))
        SidePanel.Controls.Add(btnLogout)
        SidePanel.Controls.Add(btnReservationQueue)
        SidePanel.Controls.Add(btnDineinQueue)
        SidePanel.Dock = DockStyle.Left
        SidePanel.Location = New Point(0, 19)
        SidePanel.Name = "SidePanel"
        SidePanel.Size = New Size(202, 431)
        SidePanel.TabIndex = 1
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(41), CByte(39), CByte(40))
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(105, 399)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(94, 29)
        btnLogout.TabIndex = 0
        btnLogout.Text = "LOG-OUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnReservationQueue
        ' 
        btnReservationQueue.FlatAppearance.BorderSize = 0
        btnReservationQueue.FlatStyle = FlatStyle.Flat
        btnReservationQueue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReservationQueue.ForeColor = Color.White
        btnReservationQueue.Location = New Point(3, 206)
        btnReservationQueue.Name = "btnReservationQueue"
        btnReservationQueue.Size = New Size(197, 71)
        btnReservationQueue.TabIndex = 1
        btnReservationQueue.Text = "Reservation Queue"
        btnReservationQueue.UseVisualStyleBackColor = True
        ' 
        ' btnDineinQueue
        ' 
        btnDineinQueue.FlatAppearance.BorderSize = 0
        btnDineinQueue.FlatStyle = FlatStyle.Flat
        btnDineinQueue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDineinQueue.ForeColor = Color.White
        btnDineinQueue.ImageAlign = ContentAlignment.BottomCenter
        btnDineinQueue.Location = New Point(5, 93)
        btnDineinQueue.Name = "btnDineinQueue"
        btnDineinQueue.Size = New Size(197, 71)
        btnDineinQueue.TabIndex = 0
        btnDineinQueue.Text = "Dine-in Queue"
        btnDineinQueue.UseVisualStyleBackColor = True
        ' 
        ' PanelContains
        ' 
        PanelContains.Location = New Point(208, 22)
        PanelContains.Name = "PanelContains"
        PanelContains.Size = New Size(580, 422)
        PanelContains.TabIndex = 2
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(PanelContains)
        Controls.Add(SidePanel)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        Panel1.ResumeLayout(False)
        SidePanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SidePanel As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents btnReservationQueue As Button
    Friend WithEvents btnDineinQueue As Button
    Friend WithEvents PanelContain As Panel
    Friend WithEvents PanelContains As Panel
    Friend WithEvents btnLogout As Button

End Class
