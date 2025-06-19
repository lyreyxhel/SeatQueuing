Imports MySql.Data.MySqlClient

Public Class database_connection

    ' Create the connection
    Private connection As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=vb_users")

    ' Return the connection
    ReadOnly Property getConnection() As MySqlConnection
    Get
            Return connection
        End Get
    End Property

    'open the connection
    Sub openConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    'close the connection 
    Sub closeConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

End Class
