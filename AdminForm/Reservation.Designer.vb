<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservation))
        PictureBox1 = New PictureBox()
        txtNamee = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtPeoplee = New TextBox()
        btnAddd = New Button()
        Label4 = New Label()
        lblGoToDinein = New Label()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(202, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 156)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtNamee
        ' 
        txtNamee.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNamee.Location = New Point(196, 213)
        txtNamee.Name = "txtNamee"
        txtNamee.Size = New Size(236, 34)
        txtNamee.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(119, 215)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 28)
        Label1.TabIndex = 2
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(119, 265)
        Label2.Name = "Label2"
        Label2.Size = New Size(185, 28)
        Label2.TabIndex = 3
        Label2.Text = "Number of People:"
        ' 
        ' txtPeoplee
        ' 
        txtPeoplee.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPeoplee.Location = New Point(310, 262)
        txtPeoplee.Name = "txtPeoplee"
        txtPeoplee.Size = New Size(44, 34)
        txtPeoplee.TabIndex = 4
        ' 
        ' btnAddd
        ' 
        btnAddd.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnAddd.Location = New Point(196, 317)
        btnAddd.Name = "btnAddd"
        btnAddd.Size = New Size(176, 50)
        btnAddd.TabIndex = 6
        btnAddd.Text = "Add to Reservation"
        btnAddd.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(214, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 31)
        Label4.TabIndex = 7
        Label4.Text = "Reservation"
        ' 
        ' lblGoToDinein
        ' 
        lblGoToDinein.AutoSize = True
        lblGoToDinein.Cursor = Cursors.Hand
        lblGoToDinein.Location = New Point(174, 389)
        lblGoToDinein.Name = "lblGoToDinein"
        lblGoToDinein.Size = New Size(208, 20)
        lblGoToDinein.TabIndex = 8
        lblGoToDinein.Text = "Do You Want To Dine? Dine in"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(456, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 9
        Button2.Text = "LOG OUT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Reservation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(562, 433)
        Controls.Add(Button2)
        Controls.Add(lblGoToDinein)
        Controls.Add(Label4)
        Controls.Add(btnAddd)
        Controls.Add(txtPeoplee)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNamee)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Reservation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reservation"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNamee As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPeoplee As TextBox
    Friend WithEvents btnAddd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblGoToDinein As Label
    Friend WithEvents Button2 As Button
End Class
