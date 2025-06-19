Imports AdminForm
Imports MySql.Data.MySqlClient
Public Class CustomerLoginForm

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.ForeColor = Color.Red
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnCancel.ForeColor = Color.Black
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtName.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or username.ToLower() = "username" Then
            MessageBox.Show("Please enter your username.")
            Return
        ElseIf password = "" Or password.ToLower() = "password" Then
            MessageBox.Show("Please enter your password.")
            Return
        End If

        ' ✅ ADMIN LOGIN
        If username = "admin" And password = "admin123" Then
            MessageBox.Show("Welcome, Admin!")
            Me.Hide()
            Dim aForm As New Admin()
            aForm.Show()
            Return
        End If

        ' ✅ USER LOGIN
        Dim conn As New database_connection()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT `username`, `password` FROM `users` WHERE `username`=@usn AND `password`=@pass", conn.getConnection())

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            MessageBox.Show("Login successful!")
            Me.Hide()
            Dim dForm As New Dinein()
            dForm.Show()
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub

    Private Sub lblGoToSignUp_MouseEnter(sender As Object, e As EventArgs) Handles lblGoToSignUp.MouseEnter
        lblGoToSignUp.ForeColor = Color.Black
    End Sub

    Private Sub lblGoToSignUp_Leave(sender As Object, e As EventArgs) Handles lblGoToSignUp.Leave
        lblGoToSignUp.ForeColor = Color.Red
    End Sub

    Private Sub lblGoToSignUp_Click(sender As Object, e As EventArgs) Handles lblGoToSignUp.Click
        Me.Hide()
        Dim rForm As New RegistratironForm()
        rForm.Show()
    End Sub

    Private Sub CustomerLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

