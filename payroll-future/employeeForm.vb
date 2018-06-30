Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Base

Public Class employeeForm


    Private Sub employeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDP("SELECT * FROM position", "info", dpPosition)
        getData("SELECT id, fname, lname, mname, position, address, contact FROM employees", "employees", EmployeesDGControl)
    End Sub

    Private Sub employeeForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub CheckEdit6_CheckedChanged(sender As Object, e As EventArgs) Handles txtSunday.CheckedChanged

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If btnsave.Text = "New" Then
            enableDisable(True)
            cleaFields()
            btnsave.Text = "Save"
            btndelete.Text = "Cancel"
            btnedit.Enabled = False
        Else
            If txtfname.Text = "" Or txtlname.Text = "" Or txtmname.Text = "" Or txtaddress.Text = "" _
           Or txtcontact.Text = "" Or txtbasicpay.Text = "" Or txtsickleave.Text = "" Or
           txtvacation.Text = "" Or txtcola.Text = "" Or txtdependent.Text = "" Or txtFirstTimein.Text = "" _
           Or txtFirstTimeout.Text = "" Or txtSecondTimein.Text = "" Or txtSecondTimeout.Text = "" Then
                MsgBox("Please fill up the empty fields to save employee data.", vbExclamation, "Empty Fields")
            Else
                If txtMonday.Checked = False And txtTuesday.Checked = False And txtWednesday.Checked = False _
                   And txtThursday.Checked = False And txtFriday.Checked = False And txtSaturday.Checked = False And txtSunday.Checked = False Then
                    MsgBox("Please select atleast one Rest day to save employee data.", vbExclamation, "Empty Fields")
                Else
                    updateDB("INSERT INTO employees 
        (fname, 
        lname, 
        mname, 
        position,
        address,
        contact,
        base_pay,
        sick_leave,
        vaca_leave,
        status,
        type,
        cola,
        relation,
        dependent
        ) VALUES 
        ('" & txtfname.Text & "',
        '" & txtlname.Text & "',
        '" & txtmname.Text & "',
        '" & dpPosition.Text & "',
        '" & txtaddress.Text & "',
        '" & txtcontact.Text & "',
        '" & txtbasicpay.Text & "',
        '" & txtsickleave.Text & "',
        '" & txtvacation.Text & "',
        '" & dpstatus.Text & "',
        '" & dptype.Text & "',
        '" & txtcola.Text & "',
        '" & dprelation.Text & "',
        '" & txtdependent.Text & "')")

                    Dim current_id As Integer = readDB("SELECT max(id) as id FROM employees", "id")
                    setRestday(current_id)

                    updateDB("INSERT INTO schedule (emp_id, first_in, first_out, second_in, second_out, shift) VALUES  
                ('" & current_id & "','" & txtFirstTimein.Text & "','" & txtFirstTimeout.Text & "','" & txtSecondTimein.Text & "','" & txtSecondTimeout.Text & "','" & dpShift.Text & "')")

                    MsgBox("Employee data successfully save.", vbInformation, "Data Saved")
                    getData("SELECT id, fname, lname, mname, position, address, contact FROM employees", "employees", EmployeesDGControl)
                    cleaFields()

                End If
            End If
        End If
    End Sub

    Public Sub setRestday(ByVal id As Integer)
        If txtMonday.Checked = True Then
            updateDB("INSERT INTO restday (restday, emp_id) VALUES ('Monday', '" & id & "')")
        End If
        If txtTuesday.Checked = True Then
            updateDB("INSERT INTO restday (restday, emp_id) VALUES ('Tuesday', '" & id & "')")
        End If
        If txtWednesday.Checked = True Then
            updateDB("INSERT INTO restday (restday, emp_id) VALUES ('Wednesday', '" & id & "')")
        End If
        If txtThursday.Checked = True Then
            updateDB("INSERT INTO restday (restday, emp_id) VALUES ('Thursday', '" & id & "')")
        End If
        If txtFriday.Checked = True Then
            updateDB("INSERT INTO restday (restday, emp_id) VALUES ('Friday', '" & id & "')")
        End If
        If txtSaturday.Checked = True Then
            updateDB("INSERT INTO restday (restday, emp_id) VALUES ('Saturday', '" & id & "')")
        End If
        If txtSunday.Checked = True Then
            updateDB("INSERT INTO restday (restday, emp_id) VALUES ('Sunday', '" & id & "')")
        End If
    End Sub

    Private Sub EmployeesDG_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles EmployeesDG.FocusedRowChanged
        viewChange()
    End Sub
    Public Sub viewChange()
        Dim id As Integer = showDGValue(EmployeesDG, "id")
        Dim fieldinfo() As String = {"fname", "lname", "mname", "position", "address", "contact", "base_pay", "sick_leave", "vaca_leave", "status", "type", "relation", "dependent", "cola"}
        Dim resultinfo() As String
        resultinfo = readDBMulti("SELECT * FROM employees WHERE id = '" & id & "'", fieldinfo)
        txtfname.Text = resultinfo(0)
        txtlname.Text = resultinfo(1)
        txtmname.Text = resultinfo(2)
        dpPosition.Text = resultinfo(3)
        txtaddress.Text = resultinfo(4)
        txtcontact.Text = resultinfo(5)
        txtbasicpay.Text = resultinfo(6)
        txtsickleave.Text = resultinfo(7)
        txtvacation.Text = resultinfo(8)
        dpstatus.Text = resultinfo(9)
        dptype.Text = resultinfo(10)
        dprelation.Text = resultinfo(11)
        txtdependent.Text = resultinfo(12)
        txtcola.Text = resultinfo(13)

        displaySchedule(id)
        displayRestDay(id)

        btnedit.Enabled = True
        btndelete.Enabled = True
        btnsave.Text = "New"
        btnedit.Text = "Edit"
        enableDisable(False)
    End Sub
    Public Sub enableDisable(ByVal condition As Boolean)
        txtfname.Enabled = condition
        txtlname.Enabled = condition
        txtmname.Enabled = condition
        dpPosition.Enabled = condition
        txtaddress.Enabled = condition
        txtcontact.Enabled = condition
        txtbasicpay.Enabled = condition
        txtsickleave.Enabled = condition
        txtvacation.Enabled = condition
        dpstatus.Enabled = condition
        dptype.Enabled = condition
        dprelation.Enabled = condition
        txtdependent.Enabled = condition
        txtcola.Enabled = condition
        txtFirstTimein.Enabled = condition
        txtFirstTimeout.Enabled = condition
        txtSecondTimein.Enabled = condition
        txtSecondTimeout.Enabled = condition
        txtMonday.Enabled = condition
        txtTuesday.Enabled = condition
        txtWednesday.Enabled = condition
        txtThursday.Enabled = condition
        txtFriday.Enabled = condition
        txtSaturday.Enabled = condition
        txtSunday.Enabled = condition
        dpShift.Enabled = condition
    End Sub

    Public Sub cleaFields()
        txtfname.Text = ""
        txtlname.Text = ""
        txtmname.Text = ""
        txtaddress.Text = ""
        txtcontact.Text = ""
        txtbasicpay.Text = ""
        txtsickleave.Text = ""
        txtvacation.Text = ""
        txtcola.Text = ""
        txtdependent.Text = ""

        dpPosition.SelectedIndex = 0
        dprelation.SelectedIndex = 0
        dpstatus.SelectedIndex = 0
        dptype.SelectedIndex = 0
        dpShift.SelectedIndex = 0

        txtMonday.Checked = False
        txtTuesday.Checked = False
        txtWednesday.Checked = False
        txtThursday.Checked = False
        txtFriday.Checked = False
        txtSaturday.Checked = False
        txtSunday.Checked = False

        txtFirstTimein.Text = ""
        txtFirstTimeout.Text = ""
        txtSecondTimein.Text = ""
        txtSecondTimeout.Text = ""
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If (btnedit.Text = "Edit") Then
            enableDisable(True)
            btnedit.Text = "Update"
            btnsave.Enabled = False
            btndelete.Text = "Cancel"
        Else
            Dim id As Integer = showDGValue(EmployeesDG, "id")
            Dim msg As MsgBoxResult = MsgBox("Are you sure you want to update [" + showDGValue(EmployeesDG, "fname") + " " + showDGValue(EmployeesDG, "lname") + "] info?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes
                    updateDB("UPDATE employees SET
                    fname = '" & txtfname.Text & "',
                    lname = '" & txtlname.Text & "',
                    mname = '" & txtmname.Text & "',
                    position = '" & dpPosition.Text & "',
                    address = '" & txtaddress.Text & "',
                    contact = '" & txtcontact.Text & "',
                    base_pay = '" & txtbasicpay.Text & "',
                    sick_leave = '" & txtsickleave.Text & "',
                    vaca_leave = '" & txtvacation.Text & "',
                    status = '" & dpstatus.Text & "',
                    type = '" & dptype.Text & "',
                    cola = '" & txtcola.Text & "',
                    relation = '" & dprelation.Text & "',
                    dependent ='" & txtdependent.Text & "'
                    WHERE id = '" & id & "'")
                    updateDB("UPDATE schedule SET first_in = '" & txtFirstTimein.Text & "', first_out = '" & txtFirstTimeout.Text & "', second_in = '" & txtSecondTimein.Text & "', second_out = '" & txtSecondTimeout.Text & "', shift = '" & dpShift.Text & "' WHERE emp_id = '" & id & "'")
                    updateDB("DELETE FROM restday WHERE emp_id = '" & id & "'")
                    setRestday(id)
                    btnedit.Text = "Edit"
                    enableDisable(False)
                    btnsave.Enabled = True
                    btndelete.Text = "Delete"
                    getData("SELECT id, fname, lname, mname, position, address, contact FROM employees", "employees", EmployeesDGControl)
            End Select
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If btndelete.Text = "Cancel" Then
            enableDisable(False)
            btnsave.Enabled = True
            btndelete.Text = "Delete"
            btnedit.Text = "Edit"
            btnsave.Text = "New"
            btnedit.Enabled = True
            viewChange()
        Else
            Dim msg As MsgBoxResult = MsgBox("Are you sure you want to delete [" + showDGValue(EmployeesDG, "fname") + " " + showDGValue(EmployeesDG, "lname") + "] info?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes
                    Dim id As Integer = showDGValue(EmployeesDG, "id")
                    updateDB("DELETE FROM employees WHERE id = '" & id & "'")
                    updateDB("DELETE FROM schedule WHERE emp_id = '" & id & "'")
                    updateDB("DELETE FROM restday WHERE emp_id = '" & id & "'")
                    getData("SELECT id, fname, lname, mname, position, address, contact FROM employees", "employees", EmployeesDGControl)
            End Select
        End If
    End Sub

    Private Sub EmployeesDGControl_Click(sender As Object, e As EventArgs) Handles EmployeesDGControl.Click

    End Sub
End Class