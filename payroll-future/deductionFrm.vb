Imports DevExpress.XtraGrid.Views.Base

Public Class deductionFrm
    Private Sub deductionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDPwithID("SELECT emp_id, fname + ' ' + lname as employee FROM employees", {"emp_id", "employee"}, dpEmployee)
        getDataMultiple("SELECT misc_deduction.id, fname + ' ' + lname as employee, misc_deduction.date, misc_deduction.description, misc_deduction.amount, misc_deduction.auto, misc_deduction.deduct_type, misc_deduction.amount_type FROM employees, misc_deduction WHERE employees.emp_id = misc_deduction.emp_id", {"employees", "misc_deduction"}, DeducDGControl)
    End Sub

    Private Sub dpType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dpType.SelectedIndexChanged
        If (dpType.Text = "FIX") Then
            txtamount.Visible = True
            txtpercent.Visible = False
            txtamount.Text = ""
            txtpercent.Text = ""
        Else
            txtamount.Visible = False
            txtpercent.Visible = True
            txtamount.Text = ""
            txtpercent.Text = ""
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If btnsave.Text = "New" Then
            clearFields()
            enableDisable(True)
            btnsave.Text = "Save"
            btndelete.Text = "Cancel"
            btnedit.Enabled = False
        Else
            Dim amount As String
            If dpType.Text = "FIX" Then
                amount = txtamount.Text
            Else
                amount = txtpercent.Text
            End If
            If dpEmployee.Text = "" Or txtdescription.Text = "" Or dpDate.Text = "" Or dpEnable.Text = "" Or dpType.Text = "" Or amount = "" Or txtLoanAmt.Text = "" Then
                MsgBox("Please fill up the empty fields to save deduction data.", vbExclamation, "Empty Fields")
            Else
                Dim emp_id As Integer = DirectCast(dpEmployee.SelectedItem, KeyValuePair(Of String, String)).Key
                updateDB("INSERT INTO misc_deduction (emp_id, date, description, auto, deduct_type, amount_type, amount) VALUES ('" & emp_id & "','" & dpDate.DateTime & "','" & txtdescription.Text & "','" & dpEnable.Text & "','" & dpType.Text & "','" & txtamount.Text & "','" & txtLoanAmt.Text & "')")
                clearFields()
                enableDisable(False)
                btnsave.Text = "New"
                getDataMultiple("SELECT misc_deduction.id, fname + ' ' + lname as employee, misc_deduction.date, misc_deduction.description, misc_deduction.amount, misc_deduction.auto, misc_deduction.deduct_type, misc_deduction.amount_type FROM employees, misc_deduction WHERE employees.emp_id = misc_deduction.emp_id", {"employees", "misc_deduction"}, DeducDGControl)
            End If
        End If

    End Sub

    Public Sub enableDisable(ByVal condition As Boolean)
        txtamount.Enabled = condition
        txtpercent.Enabled = condition
        dpEmployee.Enabled = condition
        dpType.Enabled = condition
        dpEnable.Enabled = condition
        dpDate.Enabled = condition
        txtdescription.Enabled = condition
        txtLoanAmt.Enabled = condition
    End Sub

    Public Sub clearFields()
        dpEmployee.Text = ""
        dpType.SelectedIndex = 0
        txtdescription.Text = ""
        dpDate.Text = ""
        txtamount.Text = ""
        txtpercent.Text = ""
        txtLoanAmt.Text = ""
        dpEnable.SelectedIndex = 0
        dpType.SelectedIndex = 0
        txtamount.Text = ""
        txtpercent.Text = ""
    End Sub

    Private Sub DeducDGControl_Click(sender As Object, e As EventArgs) Handles DeducDGControl.Click
        With listDeductionFrm
            .txtId.Text = showDGValue(DeducDG, "id")
            .lblemp.Text = showDGValue(DeducDG, "employee")
            .lblDesc.Text = showDGValue(DeducDG, "description")
        End With
        listDeductionFrm.ShowDialog()
    End Sub

    Private Sub DeducDG_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles DeducDG.FocusedRowChanged
        dpEmployee.Text = showDGValue(DeducDG, "employee")
        dpDate.DateTime = showDGValue(DeducDG, "date")
        txtdescription.Text = showDGValue(DeducDG, "description")
        txtLoanAmt.Text = showDGValue(DeducDG, "amount")
        dpEnable.Text = showDGValue(DeducDG, "auto")
        dpType.Text = showDGValue(DeducDG, "deduct_type")
        Dim amount As Double = showDGValue(DeducDG, "amount_type")
        If dpType.Text = "FIX" Then
            txtamount.Text = amount
            txtamount.Visible = True
            txtpercent.Visible = False
        Else
            txtpercent.Visible = True
            txtamount.Visible = False
            txtpercent.Text = amount
        End If
        enableDisable(False)

        btnedit.Enabled = True
        btndelete.Enabled = True
        btnsave.Enabled = True
        btnsave.Text = "New"
        btnedit.Text = "Edit"
        btndelete.Text = "Delete"
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim id As Integer = showDGValue(DeducDG, "id")
        Dim emp_id As Integer = DirectCast(dpEmployee.SelectedItem, KeyValuePair(Of String, String)).Key
        If btnedit.Text = "Edit" Then
            Dim get_id As Integer = readDB("SELECT deduction.id FROM deduction, payroll_info WHERE deduction.payroll_no = payroll_info.id AND payroll_info.status = 'Close' AND deduction.misc_id = '" & id & "'", "id")
            If get_id <> 0 Then
                enableDisable(False)
                dpEnable.Enabled = True
            Else
                enableDisable(True)
            End If
            btnedit.Text = "Update"
            btnsave.Enabled = False
            btndelete.Text = "Cancel"
        Else
            Dim amount As String
            If dpType.Text = "FIX" Then
                amount = txtamount.Text
            Else
                amount = txtpercent.Text
            End If
            updateDB("UPDATE misc_deduction SET emp_id = '" & emp_id & "',date = '" & dpDate.DateTime & "',description = '" & txtdescription.Text & "',amount = '" & txtLoanAmt.Text & "',auto = '" & dpEnable.Text & "',deduct_type = '" & dpType.Text & "',amount_type = '" & amount & "' WHERE id = '" & id & "'")
            btnedit.Text = "Edit"
            enableDisable(False)
            btnsave.Enabled = True
            btndelete.Text = "Delete"
            getDataMultiple("SELECT misc_deduction.id, fname + ' ' + lname as employee, misc_deduction.date, misc_deduction.description, misc_deduction.amount, misc_deduction.auto, misc_deduction.deduct_type, misc_deduction.amount_type FROM employees, misc_deduction WHERE employees.emp_id = misc_deduction.emp_id", {"employees", "misc_deduction"}, DeducDGControl)
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim id As Integer = showDGValue(DeducDG, "id")
        If btndelete.Text = "Cancel" Then
            enableDisable(False)
            btnsave.Enabled = True
            btndelete.Text = "Delete"
            btnedit.Text = "Edit"
            btnsave.Text = "New"
            btnedit.Enabled = True

        Else
            Dim msg As MsgBoxResult = MsgBox("Are you sure you want to delete [" + showDGValue(DeducDG, "employee") + "] info?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes
                    Dim get_id As Integer = readDB("SELECT deduction.id FROM deduction, payroll_info WHERE deduction.payroll_no = payroll_info.id AND payroll_info.status = 'Close' AND deduction.misc_id = '" & id & "'", "id")
                    If get_id <> 0 Then
                        MsgBox("Unable to delete deduction data, already processed, Please check.", vbExclamation, "Unable to delete data")
                    Else
                        updateDB("DELETE FROM misc_deduction WHERE id = '" & id & "'")
                        getDataMultiple("SELECT misc_deduction.id, fname + ' ' + lname as employee, misc_deduction.date, misc_deduction.description, misc_deduction.amount, misc_deduction.auto, misc_deduction.deduct_type, misc_deduction.amount_type FROM employees, misc_deduction WHERE employees.emp_id = misc_deduction.emp_id", {"employees", "misc_deduction"}, DeducDGControl)
                    End If

            End Select
        End If
    End Sub
End Class