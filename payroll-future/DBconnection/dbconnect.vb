Imports System.IO

Public Class dbconnect
    Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub dbconnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim directory As String = My.Application.Info.DirectoryPath
        Dim curFile As String = directory + "\dbconfig.ini"
        Dim host As String = ""
        Dim user As String = ""
        Dim pass As String = ""
        Dim db As String = ""
        If (File.Exists(curFile)) Then
            Dim db_data() As String = IO.File.ReadAllLines(curFile)
            Try
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
            Catch ex As Exception
                MsgBox("failed to read database connection", vbExclamation, "Error")
                dbcreds.ShowDialog()
            Finally
                Try
                    If dbchecking.IsConnected(host, user, pass) And dbchecking.CheckDatabaseExists(host, user, pass, db) Then
                        MsgBox(host + "-" + user + "-" + pass + "-" + db)
                    Else
                        dbcreds.ShowDialog()
                    End If
                Catch ex As Exception
                    dbcreds.ShowDialog()
                End Try


            End Try

        Else
            dbcreds.ShowDialog()
        End If
    End Sub


End Class
