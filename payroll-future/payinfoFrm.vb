Public Class payinfoFrm
    Dim payno As Integer = readDB("SELECT IDENT_CURRENT('payroll_info') + 1 as id FROM payroll_info WHERE status ='Close' AND type ='Regular'", "id")
    Private Sub payinfoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If btnsave.Text <> "Save" Then
            Dim fields As Object = readDBMulti("SELECT from_date, to_date FROM payroll_info WHERE status = 'Open' AND type = 'Regular'", {"from_date", "to_date"})
            If IsNothing(fields(0)) Then
                MsgBox("Payroll doesn't generated yet.", vbExclamation, "Message")
                Me.Dispose()
            Else
                payno = payno - 1
                txtFromDate.DateTime = fields(0)
                txtToDate.DateTime = fields(1)
            End If
        End If
        Txtpayno.Text = payno

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If btnsave.Text = "Save" Then
            Dim msg As MsgBoxResult = MsgBox("Are you sure you want to generate new payroll?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes
                    If (txtFromDate.Text = "" Or txtToDate.Text = "") Then
                        MsgBox("Please fill all empty fields.", vbExclamation, "Empty Fields")
                    ElseIf (txtFromDate.DateTime > txtToDate.DateTime) Then
                        MsgBox("Invalid dates please check.", vbExclamation, "Input error")
                    Else
                        updateDB("INSERT INTO payroll_info (from_date, to_date, status, type) VALUES ('" & txtFromDate.DateTime & "', '" & txtToDate.DateTime & "', 'Open', 'Regular')")
                        Me.Dispose()
                        frmDailiesPayrollNo.ShowDialog()
                    End If
            End Select
        Else
            Dim msg As MsgBoxResult = MsgBox("Are you sure you want to save changes in the current payroll info?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes
                    If (txtFromDate.Text = "" Or txtToDate.Text = "") Then
                        MsgBox("Please fill all empty fields.", vbExclamation, "Empty Fields")
                    ElseIf (txtFromDate.DateTime > txtToDate.DateTime) Then
                        MsgBox("Invalid dates please check.", vbExclamation, "Input error")
                    Else
                        updateDB("UPDATE payroll_info SET from_date = '" & txtFromDate.DateTime & "', to_date = '" & txtToDate.DateTime & "' WHERE id = '" & payno & "' AND status = 'Open' AND type = 'Regular'")
                        Me.Dispose()
                        frmDailiesPayrollNo.ShowDialog()
                    End If
            End Select
        End If
    End Sub

    Private Sub payinfoFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class