Imports System.Globalization
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class computationFrm
    Public earn_id As Integer = 0
    Public earn_desc As String
    Public deduc_id As Integer = 0
    Public deduc_desc As String
    Private Sub computationFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE type='Regular' and status='Open'", "id")
        getData("SELECT work_time.emp_id as emp_id, convert(varchar, work_time.emp_id) + ' Name: ' + employees.fname + ' ' + employees.lname as employee,   work_time.hours, work_time.date FROM work_time INNER JOIN employees ON emp_id=employees.id WHERE payroll_no = '" & pay_id & "'", "work_time", EmployeesDGControl)
        Dim columnName As String() = {"id"}
        showHideColumn(deductionsMiscDG, columnName, False)
        showHideColumn(earningsMiscDG, columnName, False)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmployeesDGControl_Click(sender As Object, e As EventArgs) Handles EmployeesDGControl.Click

    End Sub

    Private Sub EmployeesDG_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles EmployeesDG.FocusedRowChanged
        Dim id As Integer = showDGValue(EmployeesDG, "emp_id")
        txtEmp_id.Text = id

        Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE type='Regular' and status='Open'", "id")
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
        Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE type='Regular' and status='Open'", "id")
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
        txtindicator.Text = "1"
        miscFrm.ShowDialog()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles btnDeductions.Click
        txtindicator.Text = "2"
        miscFrm.ShowDialog()
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
                updateDB("DELETE FROM deductions WHERE id =" & deduc_id)
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

    Private Sub SimpleButton4_Click_1(sender As Object, e As EventArgs) Handles SimpleButton4.Click

    End Sub

    Private Sub LabelControl10_Click(sender As Object, e As EventArgs) Handles lblDeductions.Click

    End Sub

    Private Sub SimpleButton2_Click_2(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmPayslip.ShowDialog()
    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        PayrollComputations()
    End Sub
End Class