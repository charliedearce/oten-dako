Public Class PasswordFrm
    Private Sub btnClosePayroll_Click(sender As Object, e As EventArgs) Handles btnClosePayroll.Click
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = " & Main.txtEmpID.Caption & " AND upass = '" & txtPass.Text & "'", "emp_id")

        If emp_id <> 0 Then
            Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'close_payroll_regular'", "id")
            If role_id <> 0 Then
                Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE status= 'Open' AND type = 'Regular'", "id")
                updateDB("UPDATE payroll_info SET status= 'Close' WHERE id = '" & pay_id & "'")
                MsgBox("Regular Employee Payroll has been successfully Closed.", vbInformation, "Message")
                Me.Dispose()
                computationFrm.Dispose()
            Else
                MsgBox("You are not allowed to do this operation. Pleas contact the administrator.", vbExclamation, "Permission denied")
            End If
        Else
            MsgBox("Incorrect Password please try again.", vbExclamation, "Message")
        End If
    End Sub

    Private Sub PasswordFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub PasswordFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class