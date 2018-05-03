Public Class attForm
    Private Sub attForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim result As Boolean
        Dim msg As MsgBoxResult
        msg = MsgBox("Are you sure you want to update [" + importBioDB.txtEmpName.Text + "] time?", vbYesNo + vbQuestion, "Message")
        Select Case msg
            Case vbYes
                result = updateDB("UPDATE biometrics SET CHECKTIME =  '" + importBioDB.txtDate.Text + " " + DateEdit1.Text + "' WHERE id = '" + txtId.Text + "'")
                If result = True Then
                    importBioDB.RefreshAttDG()
                    Me.Close()
                End If
        End Select
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim result As Boolean
        Dim msg As MsgBoxResult
        msg = MsgBox("Are you sure you want to delete [" + importBioDB.txtEmpName.Text + "] time?", vbYesNo + vbQuestion, "Message")
        Select Case msg
            Case vbYes
                result = updateDB("DELETE FROM biometrics WHERE id = '" + txtId.Text + "'")
                If result = True Then
                    importBioDB.RefreshAttDG()
                    Me.Close()
                End If
        End Select
    End Sub
End Class