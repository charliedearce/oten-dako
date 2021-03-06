﻿Imports System.Data.SqlClient
Module dbchecking
    Public Function CheckDatabaseExists(ByVal server As String,
                                            ByVal user As String, ByVal password As String, ByVal db As String) As Boolean
        Dim connString As String = ("Data Source=" _
                + (server + ";User ID=" + user + ";Password=" + password + ";Initial Catalog=master;Integrated Security=false;"))

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
            connStr &= ";Integrated Security=false"
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
        Dim curFile As String = My.Application.Info.DirectoryPath + "\dbconfig.ini"
        Dim db_data() As String = IO.File.ReadAllLines(curFile)
        Dim host, user, pass, db As String
        EncryptS.UniCod.txt2Decrypt = db_data(0)
        EncryptS.UniCod.DecryptNow()
        host = EncryptS.UniCod.DecryptedText

        EncryptS.UniCod.txt2Decrypt = db_data(1)
        EncryptS.UniCod.DecryptNow()
        user = EncryptS.UniCod.DecryptedText

        EncryptS.UniCod.txt2Decrypt = db_data(2)
        EncryptS.UniCod.DecryptNow()
        pass = EncryptS.UniCod.DecryptedText

        EncryptS.UniCod.txt2Decrypt = db_data(3)
        EncryptS.UniCod.DecryptNow()
        db = EncryptS.UniCod.DecryptedText
        Return String.Format("Data Source={0}; Initial Catalog={1}; User Id={2}; Password={3}; Integrated Security=false", host, db, user, pass)
    End Function

End Module
