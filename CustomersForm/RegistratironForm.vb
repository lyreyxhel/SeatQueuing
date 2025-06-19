Imports System.Diagnostics.Eventing.Reader
Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class RegistratironForm
    Private Sub RegistratironForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseEnter

        btnClose.ForeColor = Color.Red

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Application.Exit()

    End Sub
    Private Sub txtFirstname_Enter(sender As Object, e As EventArgs) Handles txtFirstname.Enter

        lblFN.ForeColor = Color.Red

    End Sub
    Private Sub txtFirstname_Leave(sender As Object, e As EventArgs) Handles txtFirstname.Leave

        lblFN.ForeColor = Color.Black

    End Sub

    Private Sub txtLastName_Enter(sender As Object, e As EventArgs) Handles txtLastName.Enter

        lblLN.ForeColor = Color.Red

    End Sub

    Private Sub txtLastName_Leave(sender As Object, e As EventArgs) Handles txtLastName.Leave

        lblLN.ForeColor = Color.Black

    End Sub
    Private Sub txtUsernamee_Enter(sender As Object, e As EventArgs) Handles txtUsernamee.Enter

        lblUsn.ForeColor = Color.Red

    End Sub

    Private Sub txtUsernamee_Leave(sender As Object, e As EventArgs) Handles txtUsernamee.Leave

        lblUsn.ForeColor = Color.Black

    End Sub
    Private Sub txtPasswordd_Enter(sender As Object, e As EventArgs) Handles txtPasswordd.Enter

        lblPASS.ForeColor = Color.Red

    End Sub

    Private Sub txtPasswordd_Leave(sender As Object, e As EventArgs) Handles txtPasswordd.Leave


        lblPASS.ForeColor = Color.Black

    End Sub
    Private Sub txtConfirmPassword_Enter(sender As Object, e As EventArgs) Handles txtConfirmPassword.Enter

        lblPASS2.ForeColor = Color.Red

    End Sub

    Private Sub txtConfirmPassword_Leave(sender As Object, e As EventArgs) Handles txtConfirmPassword.Leave

        lblPASS2.ForeColor = Color.Black

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        'check if the fields are empty
        'check if the password =  the confirm password
        'check if the username already exists

        'Get the values from the textboxes
        Dim Fname As String = txtFirstname.Text
        Dim Lname As String = txtLastName.Text
        Dim username As String = txtUsernamee.Text
        Dim password As String = txtPasswordd.Text
        Dim cpassword As String = txtConfirmPassword.Text

        If Fname.Trim() = "" Or Lname.Trim() = "" Or username.Trim() = "" Or password.Trim() = "" Then

            MessageBox.Show("One or More Fields Are Empty.", "Mising Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Not String.Equals(password, cpassword) Then

            MessageBox.Show("Password do not match.", "password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf UsernameeExist(username) Then
            MessageBox.Show("This Username Already Exist, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            'add new user
            Dim conn As New database_connection()
            Dim command As New MySqlCommand("INSERT INTO `users`(`First_name`, `Last_name`, `username`, `password`) VALUES (@fn, @ln, @usn, @pass)", conn.getConnection)

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = Fname
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = Lname
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Registration successful!", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.closeConnection()

                'clear the textboxes
                txtFirstname.Clear()
                txtLastName.Clear()
                txtUsernamee.Clear()
                txtPasswordd.Clear()
                txtConfirmPassword.Clear()
            Else
                MessageBox.Show("Registration failed. Please try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If
        End If

    End Sub

    'create a function to check if the username exists in the database
    Public Function UsernameeExist(ByVal Usernamee As String) As Boolean

        Dim con As New database_connection()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", con.getConnection())
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = Usernamee

        Adapter.SelectCommand = command
        Adapter.Fill(table)


        'if the username exists return true
        If table.Rows.Count > 0 Then

            Return True

            'if the username does not exist, then return false
        Else

            Return False
        End If
    End Function


    Private Sub lblGoToLogin_MouseEnter(sender As Object, e As EventArgs) Handles lblGoToLogin.MouseEnter

        lblGoToLogin.ForeColor = Color.Black

    End Sub

    Private Sub lblGoToLogin_Leave(sender As Object, e As EventArgs) Handles lblGoToLogin.Leave

        lblGoToLogin.ForeColor = Color.Red

    End Sub

    Private Sub lblGoToLogin_Click(sender As Object, e As EventArgs) Handles lblGoToLogin.Click

        Me.Hide()
        Dim lForm As New CustomerLoginForm()
        lForm.Show()

    End Sub
End Class