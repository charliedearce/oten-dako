Public Class dbcreds
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim directory As String = My.Application.Info.DirectoryPath
        Dim curFile As String = directory + "\dbconfig.ini"
        Dim i As Integer
        Dim field As Integer = 3
        Dim aryText(field) As String
        Dim host As String = ""
        Dim user As String = ""
        Dim pass As String = ""
        Dim db As String = ""

        EncryptS.UniCod.txt2Encrypt = txtHost.Text
        EncryptS.UniCod.EncryptNow()
        host = EncryptS.UniCod.EncryptedText

        EncryptS.UniCod.txt2Encrypt = txtUsername.Text
        EncryptS.UniCod.EncryptNow()
        user = EncryptS.UniCod.EncryptedText

        EncryptS.UniCod.txt2Encrypt = txtPassword.Text
        EncryptS.UniCod.EncryptNow()
        pass = EncryptS.UniCod.EncryptedText

        EncryptS.UniCod.txt2Encrypt = txtDatabase.Text
        EncryptS.UniCod.EncryptNow()
        db = EncryptS.UniCod.EncryptedText

        aryText(0) = host
        aryText(1) = user
        aryText(2) = pass
        aryText(3) = db

        Dim objWriter As New System.IO.StreamWriter(curFile)

        For i = 0 To field
            objWriter.WriteLine(aryText(i))
        Next

        objWriter.Close()

        dbconnect.Close()
        Me.Close()

    End Sub

    Private Sub dbcreds_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim host As String = ""
        Dim user As String = ""
        Dim pass As String = ""
        Dim db As String = ""
        SplashScreenManager1.ShowForm(GetType(progressbar))
        Try
            If dbchecking.IsConnected(txtHost.Text, txtUsername.Text, txtPassword.Text) And dbchecking.CheckDatabaseExists(txtHost.Text, txtUsername.Text, txtPassword.Text, txtDatabase.Text) Then
                MsgBox("Connection Successful", , "Payroll")
            Else
                MsgBox("Failed to connect to database.", vbExclamation, "Error Data Base")
            End If
        Catch ex As Exception
            MsgBox("Failed to connect to database.", vbExclamation, "Error Data Base")
        End Try
        SplashScreenManager1.CloseForm()
    End Sub
End Class