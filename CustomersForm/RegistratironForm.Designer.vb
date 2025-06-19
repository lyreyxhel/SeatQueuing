<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistratironForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistratironForm))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btnClose = New Button()
        btnRegister = New Button()
        txtFirstname = New TextBox()
        lblFN = New Label()
        lblLN = New Label()
        txtLastName = New TextBox()
        lblUsn = New Label()
        txtUsernamee = New TextBox()
        lblPASS2 = New Label()
        txtConfirmPassword = New TextBox()
        lblPASS = New Label()
        txtPasswordd = New TextBox()
        lblGoToLogin = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(357, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 28)
        Label1.TabIndex = 7
        Label1.Text = "SIGN UP"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(314, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 156)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(235, 562)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(323, 55)
        btnClose.TabIndex = 11
        btnClose.Text = "Exit"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.ForestGreen
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(235, 501)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(323, 55)
        btnRegister.TabIndex = 10
        btnRegister.Text = "SIGN UP"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' txtFirstname
        ' 
        txtFirstname.BorderStyle = BorderStyle.None
        txtFirstname.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFirstname.ForeColor = Color.DarkGray
        txtFirstname.Location = New Point(46, 253)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(358, 31)
        txtFirstname.TabIndex = 1
        ' 
        ' lblFN
        ' 
        lblFN.AutoSize = True
        lblFN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFN.Location = New Point(46, 214)
        lblFN.Name = "lblFN"
        lblFN.Size = New Size(109, 28)
        lblFN.TabIndex = 12
        lblFN.Text = "*Firstname:"
        ' 
        ' lblLN
        ' 
        lblLN.AutoSize = True
        lblLN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLN.Location = New Point(427, 214)
        lblLN.Name = "lblLN"
        lblLN.Size = New Size(106, 28)
        lblLN.TabIndex = 14
        lblLN.Text = "*Lastname:"
        ' 
        ' txtLastName
        ' 
        txtLastName.BorderStyle = BorderStyle.None
        txtLastName.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLastName.ForeColor = Color.DarkGray
        txtLastName.Location = New Point(427, 253)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(259, 31)
        txtLastName.TabIndex = 13
        ' 
        ' lblUsn
        ' 
        lblUsn.AutoSize = True
        lblUsn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsn.Location = New Point(44, 300)
        lblUsn.Name = "lblUsn"
        lblUsn.Size = New Size(111, 28)
        lblUsn.TabIndex = 16
        lblUsn.Text = "*Username:"
        ' 
        ' txtUsernamee
        ' 
        txtUsernamee.BorderStyle = BorderStyle.None
        txtUsernamee.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsernamee.ForeColor = Color.DarkGray
        txtUsernamee.Location = New Point(44, 341)
        txtUsernamee.Name = "txtUsernamee"
        txtUsernamee.Size = New Size(640, 31)
        txtUsernamee.TabIndex = 15
        ' 
        ' lblPASS2
        ' 
        lblPASS2.AutoSize = True
        lblPASS2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPASS2.Location = New Point(429, 398)
        lblPASS2.Name = "lblPASS2"
        lblPASS2.Size = New Size(180, 28)
        lblPASS2.TabIndex = 20
        lblPASS2.Text = "*Confirm Password:"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BorderStyle = BorderStyle.None
        txtConfirmPassword.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtConfirmPassword.ForeColor = Color.DarkGray
        txtConfirmPassword.Location = New Point(429, 437)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(259, 31)
        txtConfirmPassword.TabIndex = 19
        ' 
        ' lblPASS
        ' 
        lblPASS.AutoSize = True
        lblPASS.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPASS.Location = New Point(48, 398)
        lblPASS.Name = "lblPASS"
        lblPASS.Size = New Size(105, 28)
        lblPASS.TabIndex = 18
        lblPASS.Text = "*Password:"
        ' 
        ' txtPasswordd
        ' 
        txtPasswordd.BorderStyle = BorderStyle.None
        txtPasswordd.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPasswordd.ForeColor = Color.DarkGray
        txtPasswordd.Location = New Point(48, 437)
        txtPasswordd.Name = "txtPasswordd"
        txtPasswordd.Size = New Size(358, 31)
        txtPasswordd.TabIndex = 17
        ' 
        ' lblGoToLogin
        ' 
        lblGoToLogin.AutoSize = True
        lblGoToLogin.Cursor = Cursors.Hand
        lblGoToLogin.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGoToLogin.Location = New Point(265, 621)
        lblGoToLogin.Name = "lblGoToLogin"
        lblGoToLogin.Size = New Size(262, 23)
        lblGoToLogin.TabIndex = 21
        lblGoToLogin.Text = "Already Have an Account? Log in"
        ' 
        ' RegistratironForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 653)
        Controls.Add(lblGoToLogin)
        Controls.Add(lblPASS2)
        Controls.Add(txtConfirmPassword)
        Controls.Add(lblPASS)
        Controls.Add(txtPasswordd)
        Controls.Add(lblUsn)
        Controls.Add(txtUsernamee)
        Controls.Add(lblLN)
        Controls.Add(txtLastName)
        Controls.Add(lblFN)
        Controls.Add(txtFirstname)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(btnClose)
        Controls.Add(btnRegister)
        MaximizeBox = False
        MinimizeBox = False
        Name = "RegistratironForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegistratironForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents lblFN As Label
    Friend WithEvents lblLN As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblUsn As Label
    Friend WithEvents txtUsernamee As TextBox
    Friend WithEvents lblPASS2 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblPASS As Label
    Friend WithEvents txtPasswordd As TextBox
    Friend WithEvents lblGoToLogin As Label
End Class
