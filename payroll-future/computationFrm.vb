Imports DevExpress.XtraGrid.Views.Base

Public Class computationFrm
    Private Sub computationFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE type='Regular' and status='Open'", "id")
        getData("SELECT work_time.emp_id as emp_id, convert(varchar, work_time.emp_id) + ' Name: ' + employees.fname + ' ' + employees.lname as employee,   work_time.hours, work_time.date FROM work_time INNER JOIN employees ON emp_id=employees.id WHERE payroll_no = '" & pay_id & "'", "work_time", EmployeesDGControl)
        'Dim columnName As String() = {"id"}
        'showHideColumn(earningsDGControl, columnName, False)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        PayrollComputations()
    End Sub

    Private Sub EmployeesDGControl_Click(sender As Object, e As EventArgs) Handles EmployeesDGControl.Click

    End Sub

    Private Sub EmployeesDG_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles EmployeesDG.FocusedRowChanged
        Dim id As Integer = showDGValue(EmployeesDG, "emp_id")

        Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE type='Regular' and status='Open'", "id")
        getData("SELECT id, amount, description, date FROM earnings WHERE emp_id = '" & id & "' AND payroll_no = '" & pay_id & "'", "earnings", earningsDGControl)
    End Sub
End Class