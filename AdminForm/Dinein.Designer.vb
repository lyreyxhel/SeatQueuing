<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dinein
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dinein))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtName = New TextBox()
        txtPeople = New TextBox()
        btnAdd = New Button()
        lblGoToReservation = New Label()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(196, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 156)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(225, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 31)
        Label1.TabIndex = 1
        Label1.Text = "Dine-In"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(86, 217)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 28)
        Label2.TabIndex = 2
        Label2.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(86, 261)
        Label3.Name = "Label3"
        Label3.Size = New Size(185, 28)
        Label3.TabIndex = 3
        Label3.Text = "Number of People:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(163, 220)
        txtName.Name = "txtName"
        txtName.Size = New Size(272, 34)
        txtName.TabIndex = 4
        ' 
        ' txtPeople
        ' 
        txtPeople.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPeople.Location = New Point(277, 260)
        txtPeople.Name = "txtPeople"
        txtPeople.Size = New Size(42, 34)
        txtPeople.TabIndex = 5
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.Location = New Point(211, 318)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(119, 45)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Add to Queue"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' lblGoToReservation
        ' 
        lblGoToReservation.AutoSize = True
        lblGoToReservation.Cursor = Cursors.Hand
        lblGoToReservation.Location = New Point(130, 390)
        lblGoToReservation.Name = "lblGoToReservation"
        lblGoToReservation.Size = New Size(305, 20)
        lblGoToReservation.TabIndex = 7
        lblGoToReservation.Text = "Do You Want To Reserve A Seat? Reservation"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(465, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 8
        Button1.Text = "LOG OUT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Dinein
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(562, 433)
        Controls.Add(Button1)
        Controls.Add(lblGoToReservation)
        Controls.Add(btnAdd)
        Controls.Add(txtPeople)
        Controls.Add(txtName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Dinein"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dinein"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPeople As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblGoToReservation As Label
    Friend WithEvents Button1 As Button
End Class
