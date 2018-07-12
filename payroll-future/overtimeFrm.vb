Imports DevExpress.XtraGrid.Views.Base
Imports System.Text.RegularExpressions
Public Class overtimeFrm
    Private Sub overtimeFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDPwithID("SELECT emp_id, fname + ' ' + lname as employee FROM employees", {"emp_id", "employee"}, dpEmployee)
        getDataMultiple("SELECT overtime.id, fname + ' ' + lname as employee, from_time, to_time, approve, description FROM employees, overtime WHERE employees.emp_id = overtime.emp_id", {"employees", "overtime"}, OverTimeDGControl)
    End Sub

    Public Sub enableDisable(ByVal condition As Boolean)
        dpEmployee.Enabled = condition
        txtdescription.Enabled = condition
        dpFrom.Enabled = condition
        dpTo.Enabled = condition
        dpApprove.Enabled = condition
    End Sub

    Public Sub clearFields()
        dpEmployee.Text = ""
        txtdescription.Text = ""
        dpFrom.Text = ""
        dpTo.Text = ""
        dpApprove.SelectedIndex = 0
    End Sub

    Private Sub OverTimeDG_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles OverTimeDG.FocusedRowChanged
        dpEmployee.Text = showDGValue(OverTimeDG, "employee")
        txtdescription.Text = showDGValue(OverTimeDG, "description")
        dpFrom.Time = showDGValue(OverTimeDG, "from_time")
        dpTo.Time = showDGValue(OverTimeDG, "to_time")
        dpApprove.Text = showDGValue(OverTimeDG, "approve")
        enableDisable(False)
        btnsave.Text = "New"
        btndelete.Enabled = True
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim emp_id As Integer = DirectCast(dpEmployee.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim cur_date As Integer = readDB("SELECT id FROM overtime WHERE emp_id = '" & emp_id & "' AND CONVERT(date,from_time,110) = '" & dpFrom.Time.ToString("MM-dd-yyyy") & "' AND CONVERT(date,to_time,110) = '" & dpTo.Time.ToString("MM-dd-yyyy") & "'", "id")

        If (btnsave.Text = "Save") Then
            If (dpEmployee.Text = "" Or txtdescription.Text = "" Or dpFrom.Text = "" Or dpApprove.Text = "") Then
                MsgBox("Please fill up the empty fields to save overtime data.", vbExclamation, "Empty Fields")
            ElseIf (dpFrom.time > dpTo.time) Then
                MsgBox("Please check the date/time.", vbExclamation, "Invalid Dates")
            ElseIf (dpFrom.Time.ToString("MM-dd-yyyy") <> dpto.Time.ToString("MM-dd-yyyy")) Then
                MsgBox("OverTime dates must be the same. Please double check.", vbExclamation, "Invalid Dates")
            ElseIf (cur_date <> 0) Then
                MsgBox("OverTime date/time is already existing for this employee. Please double check.", vbExclamation, "Invalid Dates")
            Else
                updateDB("INSERT INTO overtime (emp_id, from_time, to_time, approve, description) VALUES ('" & emp_id & "','" & dpFrom.Time & "','" & dpTo.Time & "','" & dpApprove.Text & "','" & txtdescription.Text & "')")
                getDataMultiple("SELECT overtime.id, fname + ' ' + lname as employee, from_time, to_time, approve, description FROM employees, overtime WHERE employees.emp_id = overtime.emp_id", {"employees", "overtime"}, OverTimeDGControl)
                btnsave.Text = "New"
                clearFields()
                enableDisable(False)
            End If
        Else
            btnsave.Text = "Save"
            clearFields()
            enableDisable(True)
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim id As Integer = showDGValue(OverTimeDG, "id")
        If (id <> 0) Then
            Dim msg As MsgBoxResult = MsgBox("Are you sure you want to delete [" + showDGValue(OverTimeDG, "employee") + "] overtime info?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes

                    Dim emp_id As Integer = DirectCast(dpEmployee.SelectedItem, KeyValuePair(Of String, String)).Key
                    Dim ot As Integer = readDB("SELECT earnings.id FROM earnings,payroll_info WHERE earnings.payroll_no = payroll_info.id AND payroll_info.status = 'Close' AND earnings.emp_id = '" & emp_id & "' AND earnings.date BETWEEN '" & dpFrom.Time.ToString("MM-dd-yyyy") & "' AND '" & dpTo.Time.ToString("MM-dd-yyyy") & "'  AND earnings.description LIKE '%OT%'", "id")
                    If (ot <> 0) Then
                        MsgBox("Employee OT Date already used, Please check.", vbExclamation, "Date already used")
                    Else
                        updateDB("DELETE FROM overtime WHERE id = '" & id & "'")
                        getDataMultiple("SELECT overtime.id, fname + ' ' + lname as employee, from_time, to_time, approve, description FROM employees, overtime WHERE employees.emp_id = overtime.emp_id", {"employees", "overtime"}, OverTimeDGControl)
                    End If

            End Select
        End If
    End Sub

    Private Sub GroupControl2_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub
End Class