Imports System.Globalization
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class computationFrm
    Public earn_id As Integer = 0
    Public earn_desc As String
    Public deduc_id As Integer = 0
    Public deduc_desc As String
    Public pay_id As Integer
    Private Sub computationFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE type='Regular' and status='Open'", "id")
        Dim fields As Object = readDBMulti("SELECT id, from_date, to_date FROM payroll_info WHERE status = 'Open' AND type = 'Regular'", {"id", "from_date", "to_date"})
        If IsNothing(fields(0)) And txtSearchindicator.Text = "" Then
            MsgBox("Payroll doesn't generated yet.", vbExclamation, "Message")
            Me.Dispose()
        ElseIf txtSearchindicator.Text <> "" Then
            pay_id = txtSearchindicator.Text
            'Me.Text = "[Payroll No: " & pay_id & "] [Payroll Date From: "" - To: ""]"
            btnProcess.Enabled = False
            btnClose.Enabled = False
        Else
            pay_id = fields(0)
            Me.Text = "[Payroll No: " & pay_id & "] [Payroll Date From: " & Format(fields(1), "MM-dd-yyyy") & " - To: " & Format(fields(2), "MM-dd-yyyy") & "]"
            'lblfrom.Text = Format(fields(1), "MM-dd-yyyy")
            'lblto.Text = Format(fields(2), "MM-dd-yyyy")
        End If
        txtPayno.Text = pay_id
        getData("SELECT work_time.emp_id as emp_id, convert(varchar, work_time.emp_id) + ' Name: ' + employees.fname + ' ' + employees.lname as employee,   work_time.hours, work_time.date FROM work_time INNER JOIN employees ON work_time.emp_id=employees.emp_id WHERE payroll_no = '" & pay_id & "'", "work_time", EmployeesDGControl)
        If EmployeesDG.RowCount = 0 Then
            MsgBox("Please process attendance first.", vbExclamation, "No Data to be process")
            Me.Dispose()
        Else
            Dim columnName As String() = {"id"}
            showHideColumn(deductionsMiscDG, columnName, False)
            showHideColumn(earningsMiscDG, columnName, False)
        End If

        PayrollComputations()

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmployeesDGControl_Click(sender As Object, e As EventArgs) Handles EmployeesDGControl.Click

    End Sub

    Private Sub EmployeesDG_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles EmployeesDG.FocusedRowChanged
        Dim id As Integer = showDGValue(EmployeesDG, "emp_id")
        txtEmp_id.Text = id

        'Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE type='Regular' and status='Open'", "id")
        getData("SELECT id, amount, description, date FROM earnings WHERE earning_type = 'WORK' and emp_id = '" & id & "' AND payroll_no = '" & pay_id & "'", "earnings", earningsDGControl)
        getData("SELECT description as DESCRIPTION, amount as AMOUNT FROM deduction WHERE deduction_type = 'GVNMNT' AND emp_id = '" & id & "' AND payroll_no = '" & pay_id & "'", "deduction", deductionsDGControl)
        getData("SELECT id, description as DESCRIPTION, amount as AMOUNT FROM deduction WHERE deduction_type = 'MISC' AND emp_id = '" & id & "' AND payroll_no = '" & pay_id & "'", "deduction", deductionsMiscDGControl)
        getData("SELECT id, description as DESCRIPTION, amount as AMOUNT FROM earnings WHERE earning_type = 'MISC' AND emp_id = '" & id & "' AND payroll_no = '" & pay_id & "'", "earnings", earningsMiscDGControl)
        If id = 0 Then
            btnDeductions.Enabled = False
            btnEarnings.Enabled = False
        Else
            btnEarnings.Enabled = True
            btnDeductions.Enabled = True
        End If

        getSum()
    End Sub

    Public Sub getSum()
        Dim earnings As Double = Convert.ToDouble(earningsDG.Columns(1).SummaryItem.SummaryValue) + Convert.ToDouble(earningsMiscDG.Columns(0).SummaryItem.SummaryValue)
        Dim deduction As Double = Convert.ToDouble(deductionsDG.Columns(0).SummaryItem.SummaryValue) + Convert.ToDouble(deductionsMiscDG.Columns(0).SummaryItem.SummaryValue)
        Dim netpay As Double = earnings - deduction
        lblGross.Text = earnings.ToString("N", CultureInfo.InvariantCulture)
        lblDeductions.Text = deduction.ToString("N", CultureInfo.InvariantCulture)
        lblNet.Text = netpay.ToString("N", CultureInfo.InvariantCulture)
    End Sub
    Public Function miscDG()
        'Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE type='Regular' and status='Open'", "id")
        getData("SELECT id, description as DESCRIPTION, amount as AMOUNT FROM deduction WHERE deduction_type = 'MISC' AND emp_id = '" & txtEmp_id.Text & "' AND payroll_no = '" & pay_id & "'", "deduction", deductionsMiscDGControl)
        getData("SELECT id, description as DESCRIPTION, amount as AMOUNT FROM earnings WHERE earning_type = 'MISC' AND emp_id = '" & txtEmp_id.Text & "' AND payroll_no = '" & pay_id & "'", "earnings", earningsMiscDGControl)
    End Function
    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub LabelControl5_Click(sender As Object, e As EventArgs) Handles LabelControl5.Click

    End Sub

    Private Sub LabelControl2_Click(sender As Object, e As EventArgs) Handles LabelControl2.Click

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles btnEarnings.Click
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & Main.txtEmpID.Caption & "'", "emp_id")
        txtindicator.Text = "1"
        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'misc_earnings'", "id")
        If role_id <> 0 Then
            miscFrm.ShowDialog()
        Else
            MsgBox("You are not allowed to do this operation. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles btnDeductions.Click
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & Main.txtEmpID.Caption & "'", "emp_id")
        txtindicator.Text = "2"
        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'misc_deductions'", "id")
        If role_id <> 0 Then
            miscFrm.ShowDialog()
        Else
            MsgBox("You are not allowed to do this operation. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If
    End Sub

    Private Sub earningsMiscDGControl_Click(sender As Object, e As EventArgs) Handles earningsMiscDGControl.Click

    End Sub

    Private Sub earningsMiscDG_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles earningsMiscDG.FocusedRowChanged
        earn_id = showDGValue(earningsMiscDG, "id")
        earn_desc = showDGValue(earningsMiscDG, "DESCRIPTION")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If earn_id <> 0 Then
            Dim msg = MsgBox("Are you sure you want to delete this [" & earn_desc & "]?", MsgBoxStyle.YesNo, "Misc Earnings Deletion")
            If msg = MsgBoxResult.Yes Then
                updateDB("DELETE FROM earnings WHERE id =" & earn_id)
                miscDG()
                getSum()
            End If
        End If
    End Sub

    Private Sub earningsMiscDG_GotFocus(sender As Object, e As EventArgs) Handles earningsMiscDG.GotFocus
        earn_id = showDGValue(earningsMiscDG, "id")
        earn_desc = showDGValue(earningsMiscDG, "DESCRIPTION")
    End Sub

    Private Sub earningsMiscDG_CalcPreviewText(sender As Object, e As CalcPreviewTextEventArgs) Handles earningsMiscDG.CalcPreviewText

    End Sub

    Private Sub deductionsMiscDG_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles deductionsMiscDG.FocusedRowChanged
        deduc_id = showDGValue(deductionsMiscDG, "id")
        deduc_desc = showDGValue(deductionsMiscDG, "DESCRIPTION")
    End Sub



    Private Sub deductionsMiscDG_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles deductionsMiscDG.FocusedColumnChanged
        deduc_id = showDGValue(deductionsMiscDG, "id")
        deduc_desc = showDGValue(deductionsMiscDG, "DESCRIPTION")
    End Sub

    Private Sub earningsMiscDG_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles earningsMiscDG.FocusedColumnChanged
        earn_id = showDGValue(earningsMiscDG, "id")
        earn_desc = showDGValue(earningsMiscDG, "DESCRIPTION")
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If deduc_id <> 0 Then
            Dim msg = MsgBox("Are you sure you want to delete this [" & deduc_desc & "]?", MsgBoxStyle.YesNo, "Misc Deduction Deletion")
            If msg = MsgBoxResult.Yes Then
                updateDB("DELETE FROM deduction WHERE id =" & deduc_id)
                miscDG()
                getSum()
            End If
        End If
    End Sub

    Private Sub deductionsMiscDG_RowCountChanged(sender As Object, e As EventArgs) Handles deductionsMiscDG.RowCountChanged
        deduc_id = showDGValue(deductionsMiscDG, "id")
        deduc_desc = showDGValue(deductionsMiscDG, "DESCRIPTION")
    End Sub

    Private Sub earningsMiscDG_RowCountChanged(sender As Object, e As EventArgs) Handles earningsMiscDG.RowCountChanged
        earn_id = showDGValue(earningsMiscDG, "id")
        earn_desc = showDGValue(earningsMiscDG, "DESCRIPTION")
    End Sub

    Private Sub deductionsMiscDG_RowClick(sender As Object, e As RowClickEventArgs) Handles deductionsMiscDG.RowClick
        deduc_id = showDGValue(deductionsMiscDG, "id")
        deduc_desc = showDGValue(deductionsMiscDG, "DESCRIPTION")
    End Sub

    Private Sub earningsMiscDG_RowClick(sender As Object, e As RowClickEventArgs) Handles earningsMiscDG.RowClick
        earn_id = showDGValue(earningsMiscDG, "id")
        earn_desc = showDGValue(earningsMiscDG, "DESCRIPTION")
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton4_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        PasswordFrm.ShowDialog()
    End Sub

    Private Sub LabelControl10_Click(sender As Object, e As EventArgs) Handles lblDeductions.Click

    End Sub

    Private Sub SimpleButton2_Click_2(sender As Object, e As EventArgs) Handles btnViewpay.Click
        frmPayslip.ShowDialog()
    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & Main.txtEmpID.Caption & "'", "emp_id")

        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'process_payroll'", "id")
        If role_id <> 0 Then
            PayrollComputations()
        Else
            MsgBox("You are not allowed to do this operation. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If

    End Sub

    Private Sub computationFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class