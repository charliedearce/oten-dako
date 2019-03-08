Imports System.Collections

Public Class frmDailiesPayrollNo
    Private Sub frmDailiesPayrollNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpayno.Text = readDB("SELECT id FROM payroll_info WHERE (type='Regular' OR type = 'Irregular') and status='Open'", "id")
        refreshDG()
    End Sub
    Public Function refreshDG()
        getData("SELECT id, fname + ' ' + lname as emp, emp_id FROM employees WHERE status = 'Active' AND (type='Regular' OR type = 'Irregular')", "employees", EmployeesDGControl)
        getDataMultiple("SELECT employees.id, employees.fname + ' ' + employees.lname as emp, employees.emp_id FROM employees,pay_emp WHERE pay_emp.emp_id = employees.emp_id AND pay_emp.payroll_no = '" & txtpayno.Text & "'", {"employees", "pay_emp"}, EmpImportDGControl)
    End Function
    Private Sub EmployeesDGControl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDeductions_Click(sender As Object, e As EventArgs) Handles btnDeductions.Click
        Dim pay_id As Integer = txtpayno.Text
        updateDB("DELETE FROM pay_emp WHERE payroll_no = '" & pay_id & "'")
        Dim Rows As New ArrayList()

        ' Add the selected rows to the list.
        Dim selectedRowHandles As Int32() = EmployeesDG.GetSelectedRows()
        Dim I As Integer
        For I = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(I)
            If (selectedRowHandle >= 0) Then
                Rows.Add(EmployeesDG.GetDataRow(selectedRowHandle))
            End If
        Next

        For I = 0 To Rows.Count - 1
            Dim Row As DataRow = CType(Rows(I), DataRow)
            ' Change the field value.
            'MsgBox(Row("id"))                
            updateDB("INSERT INTO pay_emp (emp_id, payroll_no) VALUES (" & Row("emp_id") & ", " & pay_id & ")")
        Next
        refreshDG()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim pay_id As Integer = txtpayno.Text

        Dim Rows As New ArrayList()

        ' Add the selected rows to the list.
        Dim selectedRowHandles As Int32() = EmpImportDG.GetSelectedRows()
        Dim I As Integer
        For I = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(I)
            If (selectedRowHandle >= 0) Then
                Rows.Add(EmpImportDG.GetDataRow(selectedRowHandle))
            End If
        Next

        For I = 0 To Rows.Count - 1
            Dim Row As DataRow = CType(Rows(I), DataRow)
            ' Change the field value.
            'MsgBox(Row("id"))                
            updateDB("DELETE FROM pay_emp WHERE emp_id = '" & Row("emp_id") & "' AND payroll_no = '" & pay_id & "'")
        Next
        refreshDG()
    End Sub

    Private Sub frmDailiesPayrollNo_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class