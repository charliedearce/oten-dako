Imports System.Data.SqlClient
Module dbchecking
    Public Function CheckDatabaseExists(ByVal server As String,
                                            ByVal user As String, ByVal password As String, ByVal db As String) As Boolean
        Dim connString As String = ("Data Source=" _
                + (server + ";User ID=" + user + ";Password=" + password + ";Initial Catalog=master;Integrated Security=True;"))

        Dim cmdText As String =
       ("select * from master.dbo.sysdatabases where name='" + db + "'")

        Dim bRet As Boolean = False

        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()

            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
        End Using

        Return bRet

    End Function
    Public Function IsConnected(ServerName As String, UserID As String, Password As String) As Boolean
        Dim connStr As String = String.Format("Data Source={0}", ServerName)
        If Not String.IsNullOrEmpty(UserID) Then
            connStr &= String.Format(";User ID={0};Password={1}", UserID, Password)
        Else
            connStr &= ";Integrated Security=True"
        End If
        Return IsConnected(connStr)
    End Function

    Public Function IsConnected(Connection As String) As Boolean
        Static conn As SqlConnection
        If conn Is Nothing Then

            Try
                conn = New SqlConnection(Connection)
                conn.Open()
            Catch ex As Exception
                Return False
            End Try

        End If
        Return IsConnected(conn)
    End Function

    Public Function IsConnected(ByRef Conn As SqlConnection) As Boolean
        If Conn IsNot Nothing Then Return (Conn.State = ConnectionState.Open)
        Return False
    End Function

    Public Function SQLServerConnection() As String
        Return "Data Source=CHARLIE-ASUS\SQLEXPRESS; Initial Catalog=payroll; User Id=sa; Password=1234;"
    End Function

End Module
