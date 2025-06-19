<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReservation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnServe = New Button()
        lstServing = New ListBox()
        Label2 = New Label()
        Label1 = New Label()
        lstQueueDisplay = New ListBox()
        btnDeletee = New Button()
        SuspendLayout()
        ' 
        ' btnServe
        ' 
        btnServe.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnServe.Location = New Point(172, 331)
        btnServe.Name = "btnServe"
        btnServe.Size = New Size(94, 44)
        btnServe.TabIndex = 10
        btnServe.Text = "Serve"
        btnServe.UseVisualStyleBackColor = False
        ' 
        ' lstServing
        ' 
        lstServing.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstServing.FormattingEnabled = True
        lstServing.ItemHeight = 28
        lstServing.Location = New Point(318, 60)
        lstServing.Name = "lstServing"
        lstServing.Size = New Size(237, 256)
        lstServing.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(365, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 31)
        Label2.TabIndex = 8
        Label2.Text = "Reservation:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(94, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 31)
        Label1.TabIndex = 7
        Label1.Text = "Waiting:"
        ' 
        ' lstQueueDisplay
        ' 
        lstQueueDisplay.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstQueueDisplay.FormattingEnabled = True
        lstQueueDisplay.ItemHeight = 28
        lstQueueDisplay.Location = New Point(29, 60)
        lstQueueDisplay.Name = "lstQueueDisplay"
        lstQueueDisplay.Size = New Size(237, 256)
        lstQueueDisplay.TabIndex = 6
        ' 
        ' btnDeletee
        ' 
        btnDeletee.BackColor = Color.Red
        btnDeletee.Location = New Point(272, 331)
        btnDeletee.Name = "btnDeletee"
        btnDeletee.Size = New Size(94, 44)
        btnDeletee.TabIndex = 11
        btnDeletee.Text = "Delete"
        btnDeletee.UseVisualStyleBackColor = False
        ' 
        ' FormReservation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(580, 385)
        Controls.Add(btnDeletee)
        Controls.Add(btnServe)
        Controls.Add(lstServing)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lstQueueDisplay)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormReservation"
        Text = "FormReservation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnServe As Button
    Friend WithEvents lstServing As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstQueueDisplay As ListBox
    Friend WithEvents btnDeletee As Button
End Class
