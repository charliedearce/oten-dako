Public Class loginFrm
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click

        If txtpassword.Text = "" Or txtusername.Text = "" Then
            MsgBox("Please fill up all fields. Try again.", vbExclamation, "Empty fields")
        Else
            Dim fields As Object = readDBMulti("SELECT * FROM users WHERE uname = '" & txtusername.Text & "' AND upass = '" & txtpassword.Text & "'", {"id", "emp_id"})
            If (fields(0) = vbEmpty) Then
                MsgBox("Incorrect Username/Password. Try again.", vbExclamation, "Wrong Credentials")
            Else
                Dim fields_user As Object = readDBMulti("SELECT * FROM employees WHERE id = '" & fields(1) & "'", {"fname", "lname", "emp_id"})
                With Main
                    .txtEmpName.Caption = fields_user(0) & " " & fields_user(1)
                    .txtEmpIdDynamic.Caption = fields_user(2)
                    .txtEmpID.Caption = fields(1)
                End With
                txtusername.Text = ""
                txtpassword.Text = ""
                Me.Close()
            End If
        End If
    End Sub

    Private Sub loginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim msg As MsgBoxResult = MsgBox("Hey! Are you sure you want close this program?", vbYesNo + vbQuestion, "Exit System")
        Select Case msg
            Case vbYes
                End
        End Select
    End Sub
End Class