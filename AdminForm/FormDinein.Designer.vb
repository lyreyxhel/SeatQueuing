<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDinein
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
        lstQueueDisplay = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        lstServing = New ListBox()
        btnServe = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' lstQueueDisplay
        ' 
        lstQueueDisplay.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstQueueDisplay.FormattingEnabled = True
        lstQueueDisplay.ItemHeight = 28
        lstQueueDisplay.Location = New Point(24, 58)
        lstQueueDisplay.Name = "lstQueueDisplay"
        lstQueueDisplay.Size = New Size(237, 256)
        lstQueueDisplay.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(89, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 31)
        Label1.TabIndex = 2
        Label1.Text = "Waiting:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(360, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 31)
        Label2.TabIndex = 3
        Label2.Text = "Serving:"
        ' 
        ' lstServing
        ' 
        lstServing.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstServing.FormattingEnabled = True
        lstServing.ItemHeight = 28
        lstServing.Location = New Point(313, 58)
        lstServing.Name = "lstServing"
        lstServing.Size = New Size(237, 256)
        lstServing.TabIndex = 4
        ' 
        ' btnServe
        ' 
        btnServe.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnServe.Location = New Point(167, 329)
        btnServe.Name = "btnServe"
        btnServe.Size = New Size(94, 44)
        btnServe.TabIndex = 5
        btnServe.Text = "Serve"
        btnServe.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Location = New Point(282, 329)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 44)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' FormDinein
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(580, 385)
        Controls.Add(btnDelete)
        Controls.Add(btnServe)
        Controls.Add(lstServing)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lstQueueDisplay)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormDinein"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormDinein"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstQueueDisplay As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstServing As ListBox
    Friend WithEvents btnServe As Button
    Friend WithEvents btnDelete As Button
End Class
