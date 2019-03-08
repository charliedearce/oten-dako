Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class leaveFrm
    Private Sub leaveFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDPwithID("SELECT emp_id, fname + ' ' + lname as employee FROM employees", {"emp_id", "employee"}, dpEmployee)
        getDataMultiple("SELECT leave.id, fname + ' ' + lname as employee, from_leave, to_leave, approve, leave.type, leave.days, description FROM employees, leave WHERE employees.emp_id = leave.emp_id", {"employees", "leave"}, LeaveDGControl)
    End Sub

    Private Sub LeaveDG_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles LeaveDG.FocusedRowChanged
        getView()
        enableDisable(False)
        btnsave.Text = "New"
    End Sub
    Public Sub getView()
        dpEmployee.Text = showDGValue(LeaveDG, "employee")
        dpType.Text = showDGValue(LeaveDG, "type")
        txtdescription.Text = showDGValue(LeaveDG, "description")
        dpFrom.Text = showDGValue(LeaveDG, "from_leave")
        dpTo.Text = showDGValue(LeaveDG, "to_leave")
        dpApprove.Text = showDGValue(LeaveDG, "approve")
        dpDays.Text = showDGValue(LeaveDG, "days")

        btndelete.Enabled = True
    End Sub
    Public Sub enableDisable(ByVal condition As Boolean)
        dpEmployee.Enabled = condition
        dpType.Enabled = condition
        txtdescription.Enabled = condition
        dpFrom.Enabled = condition
        dpTo.Enabled = condition
        dpApprove.Enabled = condition
        dpDays.Enabled = condition
    End Sub



    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim id As Integer = showDGValue(LeaveDG, "id")
        If (id <> 0) Then
            Dim msg As MsgBoxResult = MsgBox("Are you sure you want to delete [" + showDGValue(LeaveDG, "employee") + "] info?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes

                    Dim emp_id As Integer = DirectCast(dpEmployee.SelectedItem, KeyValuePair(Of String, String)).Key
                    Dim use_leave As Double = readDB("SELECT earnings.id FROM earnings,payroll_info WHERE earnings.payroll_no = payroll_info.id AND payroll_info.status <> 'Open' AND earnings.emp_id = '" & emp_id & "' AND earnings.date BETWEEN '" & dpFrom.DateTime & "' AND '" & dpTo.DateTime & "' AND earnings.description LIKE '%Leave%'", "id")
                    If (use_leave <> 0) Then
                        MsgBox("Employee Leave Date already used, Please check.", vbExclamation, "Date already used")
                    Else
                        updateDB("DELETE FROM leave WHERE id = '" & id & "'")
                        getDataMultiple("SELECT leave.id, fname + ' ' + lname as employee, from_leave, to_leave, approve, leave.type, leave.days FROM employees, leave WHERE employees.emp_id = leave.emp_id", {"employees", "leave"}, LeaveDGControl)
                    End If

            End Select
        End If
    End Sub
    Public Sub clearFields()
        dpEmployee.Text = ""
        dpType.SelectedIndex = 0
        txtdescription.Text = ""
        dpFrom.Text = ""
        dpTo.Text = ""
        dpApprove.SelectedIndex = 0
        dpDays.SelectedIndex = 0
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If btnsave.Text = "New" Then
            enableDisable(True)
            clearFields()
            btnsave.Text = "Save"
        Else
            If dpEmployee.Text = "" Or txtdescription.Text = "" Or dpFrom.Text = "" Or dpTo.Text = "" Then
                MsgBox("Please fill up the empty fields to save leave application data.", vbExclamation, "Empty Fields")
            Else
                Dim emp_id As Integer = DirectCast(dpEmployee.SelectedItem, KeyValuePair(Of String, String)).Key
                Dim leave_render As Double = readDB("SELECT SUM(days) as days  FROM leave WHERE year(from_leave) = '" & dpFrom.DateTime.Year & "' AND year(to_leave) = '" & dpTo.DateTime.Year & "' AND emp_id = '" & emp_id & "'", "days")
                Dim total_leave As Double = readDB("SELECT SUM(sick_leave + vaca_leave) as days  FROM employees WHERE emp_id = '" & emp_id & "'", "days")
                Dim use_leave As Double = readDB("SELECT id FROM leave WHERE emp_id = '" & emp_id & "' AND convert(date, from_leave, 110) = '" & dpFrom.DateTime.ToString("MM-dd-yyyy") & "' AND convert(date, to_leave, 110) = '" & dpTo.DateTime.ToString("MM-dd-yyyy") & "'", "id")
                Dim result As Integer = DateTime.Compare(dpFrom.DateTime, dpTo.DateTime)

                If (result = 1) Or dpFrom.DateTime.Year <> Date.Now.Year Or dpTo.DateTime.Year <> Date.Now.Year Then
                    MsgBox("Please enter valid dates.", vbExclamation, "Date Fields")
                ElseIf (use_leave <> 0) Then
                    MsgBox("Employee Leave Date already used, Please check.", vbExclamation, "Date already used")
                ElseIf (total_leave - leave_render) < Convert.ToDouble(dpDays.Text) Then
                    MsgBox("Employee leave is Insufficient. Available Leaves [" & total_leave - leave_render & "] for the year.", vbExclamation, "Insufficient Leave")
                Else
                    updateDB("INSERT INTO leave (emp_id, from_leave, to_leave, description, days, approve, Type) VALUES ('" & emp_id & "', '" & dpFrom.DateTime & "', '" & dpTo.DateTime & "','" & txtdescription.Text & "', '" & dpDays.Text & "', '" & dpApprove.Text & "', '" & dpType.Text & "')")
                    MsgBox("Leave Successfully added.", vbInformation, "Successfull")
                    getDataMultiple("SELECT leave.id, fname + ' ' + lname as employee, from_leave, to_leave, approve, leave.type, leave.days FROM employees, leave WHERE employees.emp_id = leave.emp_id", {"employees", "leave"}, LeaveDGControl)
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim value As String = DirectCast(dpEmployee.SelectedItem, KeyValuePair(Of String, String)).Key
        MsgBox(value)
    End Sub

    Private Sub LeaveDGControl_Click(sender As Object, e As EventArgs) Handles LeaveDGControl.Click

    End Sub

    Private Sub leaveFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class