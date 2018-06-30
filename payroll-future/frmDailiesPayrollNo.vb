﻿Imports System.Collections

Public Class frmDailiesPayrollNo
    Private Sub frmDailiesPayrollNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshDG()
    End Sub
    Public Function refreshDG()
        getData("SELECT id, fname + ' ' + lname as emp FROM employees WHERE status = 'Active' AND type = 'Daily' ", "employees", EmployeesDGControl)
        getDataMultiple("SELECT employees.id, employees.fname + ' ' + employees.lname as emp FROM employees,pay_emp WHERE pay_emp.emp_id = employees.id", {"employees", "pay_emp"}, EmpImportDGControl)
    End Function
    Private Sub EmployeesDGControl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDeductions_Click(sender As Object, e As EventArgs) Handles btnDeductions.Click
        Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE type='Regular' and status='Open'", "id")
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
            updateDB("INSERT INTO pay_emp (emp_id, payroll_no) VALUES (" & Row("id") & ", " & pay_id & ")")
        Next
        refreshDG()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE type='Regular' and status='Open'", "id")

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
            updateDB("DELETE FROM pay_emp WHERE emp_id = '" & Row("id") & "' AND payroll_no = '" & pay_id & "'")
        Next
        refreshDG()
    End Sub
End Class