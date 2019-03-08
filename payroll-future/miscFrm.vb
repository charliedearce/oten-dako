Public Class miscFrm
    Private Sub miscFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub miscFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If computationFrm.txtindicator.Text = "1" Then
            Me.Text = "Misc Earning Form"
            lbltax.Visible = True
            cbTaxable.Visible = True
        ElseIf computationFrm.txtindicator.Text = "2" Then
            Me.Text = "Misc Deduction Form"
        ElseIf computationFrm.txtindicator.Text = "3" Then
            Me.Text = "Update Deduction"
            txtDesc.Enabled = False
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE type='Regular' and status='Open'", "id")
        If txtAmount.Text <> "" And txtDesc.Text <> "" Then
            If computationFrm.txtindicator.Text = "1" Then
                If cbTaxable.Text <> "" Then
                    Dim earn_id As Integer = readDB("SELECT IDENT_CURRENT('earnings') + 1 as id FROM earnings ", "id")
                    updateDB("INSERT INTO taxable (earn_id, taxable) VALUES (" & earn_id & ", '" & cbTaxable.Text & "')")
                    updateDB("INSERT INTO earnings (emp_id, earning_type, amount, payroll_no, description) VALUES (" & computationFrm.txtEmp_id.Text & ",'MISC'," & txtAmount.Text & " ," & pay_id & ", '" & txtDesc.Text & "')")

                    Me.Dispose()
                    computationFrm.miscDG()
                    computationFrm.getSum()
                Else
                    MsgBox("Please select Taxable info.", vbExclamation, "Empty fields")
                End If
            ElseIf computationFrm.txtindicator.Text = "2" Then
                    updateDB("INSERT INTO deduction (emp_id, deduction_type, amount, payroll_no, description) VALUES (" & computationFrm.txtEmp_id.Text & ",'MISC'," & txtAmount.Text & " ," & pay_id & ", '" & txtDesc.Text & "')")
                    Me.Dispose()
                    computationFrm.miscDG()
                    computationFrm.getSum()
                ElseIf computationFrm.txtindicator.Text = "3" Then
                    updateDB("UPDATE deduction SET amount = " & txtAmount.Text & " WHERE id = '" & miscId.Text & "'")
                Me.Dispose()
                computationFrm.miscDG()
                computationFrm.getSum()
            End If
        Else
            MsgBox("Please enter Amount and Description.", vbExclamation, "Empty fields")
        End If


    End Sub
End Class