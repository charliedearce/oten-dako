Public Class miscFrm
    Private Sub miscFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If computationFrm.txtindicator.Text = "1" Then
            Me.Text = "Misc Earning Form"
        Else
            Me.Text = "Misc Deduction Form"
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE type='Regular' and status='Open'", "id")
        If txtAmount.Text <> "" And txtDesc.Text <> "" Then
            If computationFrm.txtindicator.Text = "1" Then
                updateDB("INSERT INTO earnings (emp_id, earning_type, amount, payroll_no, description) VALUES (" & computationFrm.txtEmp_id.Text & ",'MISC'," & txtAmount.Text & " ," & pay_id & ", '" & txtDesc.Text & "')")
                Me.Dispose()
                computationFrm.miscDG()
                computationFrm.getSum()
            Else
                updateDB("INSERT INTO deduction (emp_id, deduction_type, amount, payroll_no, description) VALUES (" & computationFrm.txtEmp_id.Text & ",'MISC'," & txtAmount.Text & " ," & pay_id & ", '" & txtDesc.Text & "')")
                Me.Dispose()
                computationFrm.miscDG()
                computationFrm.getSum()
            End If
        Else
            MsgBox("Please enter Amount and Description.", vbExclamation, "Empty fields")
        End If


    End Sub
End Class