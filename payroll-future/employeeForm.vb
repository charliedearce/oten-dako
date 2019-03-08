Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Base

Public Class employeeForm


    Private Sub employeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDP("SELECT * FROM position", "info", dpPosition)
        getEmplist()
    End Sub

    Private Sub employeeForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub CheckEdit6_CheckedChanged(sender As Object, e As EventArgs) Handles txtSunday.CheckedChanged

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim bypass As Integer
        Dim val_phil As Integer
        Dim val_sss As Integer
        Dim val_pagibig As Integer
        Dim val_tax As Integer
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
           Or txtFirstTimeout.Text = "" Or txtSecondTimein.Text = "" Or txtSecondTimeout.Text = "" _
           Or sssId.Text = "" Or philId.Text = "" Or taxId.Text = "" Or pagibigId.Text = "" Then
                MsgBox("Please fill up the empty fields to save employee data.", vbExclamation, "Empty Fields")
            Else
                If txtMonday.Checked = False And txtTuesday.Checked = False And txtWednesday.Checked = False _
                   And txtThursday.Checked = False And txtFriday.Checked = False And txtSaturday.Checked = False And txtSunday.Checked = False Then
                    MsgBox("Please select atleast one Rest day to save employee data.", vbExclamation, "Empty Fields")
                Else
                    If txtbypass.Checked = True Then
                        bypass = 1
                    Else
                        bypass = 0
                    End If

                    If philhealth.Checked = True Then
                        val_phil = 1
                    Else
                        val_phil = 0
                    End If

                    If sss.Checked = True Then
                        val_sss = 1
                    Else
                        val_sss = 0
                    End If

                    If pagibig.Checked = True Then
                        val_pagibig = 1
                    Else
                        val_pagibig = 0
                    End If

                    If tax.Checked = True Then
                        val_tax = 1
                    Else
                        val_tax = 0
                    End If


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
        dependent,
        emp_id,
        bypass,
        philhealth,
        sss,
        pagibig,
        sss_id,
        pagibig_id,
        philhealth_id,
        tax_id,
        separation_date,
        tax
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
        '" & txtdependent.Text & "',
        '" & txtEmpId.Text & "',
        '" & bypass & "',
        '" & val_phil & "',
        '" & val_sss & "',
        '" & val_pagibig & "',
        '" & sssId.Text & "',
        '" & pagibigId.Text & "',
        '" & philId.Text & "',
        '" & taxId.Text & "',
        '" & txtSeparationdate.Text & "',
        '" & val_tax & "'
        )")


                    setRestday(txtEmpId.Text)

                    updateDB("INSERT INTO schedule (emp_id, first_in, first_out, second_in, second_out, shift) VALUES  
                ('" & txtEmpId.Text & "','" & txtFirstTimein.Text & "','" & txtFirstTimeout.Text & "','" & txtSecondTimein.Text & "','" & txtSecondTimeout.Text & "','" & dpShift.Text & "')")

                    MsgBox("Employee data successfully save.", vbInformation, "Data Saved")
                    getEmplist()
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
        Dim id As Integer = showDGValue(EmployeesDG, "emp_id")
        Dim fieldinfo() As String = {"fname", "lname", "mname", "position", "address", "contact", "base_pay", "sick_leave", "vaca_leave", "status", "type", "relation", "dependent", "cola", "emp_id", "bypass", "philhealth", "sss", "pagibig", "sss_id", "pagibig_id", "philhealth_id", "tax_id", "separation_date", "tax"}
        Dim resultinfo() As Object
        resultinfo = readDBMulti("SELECT * FROM employees WHERE emp_id = '" & id & "'", fieldinfo)
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
        txtEmpId.Text = resultinfo(14)

        If (resultinfo(15) <> 0) Then
            txtbypass.Checked = True
        Else
            txtbypass.Checked = False
        End If

        If (resultinfo(16) <> 0) Then
            philhealth.Checked = True
        Else
            philhealth.Checked = False
        End If

        If (resultinfo(17) <> 0) Then
            sss.Checked = True
        Else
            sss.Checked = False
        End If

        If (resultinfo(18) <> 0) Then
            pagibig.Checked = True
        Else
            pagibig.Checked = False
        End If

        If (resultinfo(24) <> 0) Then
            tax.Checked = True
        Else
            tax.Checked = False
        End If


        sssId.Text = resultinfo(19)
        pagibigId.Text = resultinfo(20)
        philId.Text = resultinfo(21)
        taxId.Text = resultinfo(22)
        txtSeparationdate.Text = resultinfo(23)


        txtMonday.Checked = False
        txtTuesday.Checked = False
        txtWednesday.Checked = False
        txtThursday.Checked = False
        txtFriday.Checked = False
        txtSaturday.Checked = False
        txtSunday.Checked = False

        displaySchedule(id)
        displayRestDay(id)

        btnedit.Enabled = True
        btndelete.Enabled = True
        btnsave.Enabled = True
        btnsave.Text = "New"
        btnedit.Text = "Edit"
        btndelete.Text = "Delete"
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
        txtEmpId.Enabled = condition
        txtbypass.Enabled = condition
        philhealth.Enabled = condition
        sss.Enabled = condition
        pagibig.Enabled = condition
        sssId.Enabled = condition
        pagibigId.Enabled = condition
        philId.Enabled = condition
        taxId.Enabled = condition
        tax.Enabled = condition
        txtSeparationdate.Enabled = condition
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
        txtSeparationdate.Text = ""

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
        txtbypass.Checked = False
        philhealth.Checked = False
        sss.Checked = False
        pagibig.Checked = False
        tax.Checked = False

        txtEmpId.Text = ""
        txtFirstTimein.Text = ""
        txtFirstTimeout.Text = ""
        txtSecondTimein.Text = ""
        txtSecondTimeout.Text = ""

        sssId.Text = ""
        pagibigId.Text = ""
        philId.Text = ""
        taxId.Text = ""
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If (btnedit.Text = "Edit") Then
            enableDisable(True)
            btnedit.Text = "Update"
            btnsave.Enabled = False
            btndelete.Text = "Cancel"
        Else
            Dim emp_id As Integer = showDGValue(EmployeesDG, "emp_id")
            Dim id As Integer = showDGValue(EmployeesDG, "id")
            Dim bypass As Integer
            Dim val_phil As Integer
            Dim val_sss As Integer
            Dim val_pagibig As Integer
            Dim val_tax As Integer
            Dim msg As MsgBoxResult = MsgBox("Are you sure you want to update [" + showDGValue(EmployeesDG, "fname") + " " + showDGValue(EmployeesDG, "lname") + "] info?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes
                    If txtbypass.Checked = True Then
                        bypass = 1
                    Else
                        bypass = 0
                    End If

                    If philhealth.Checked = True Then
                        val_phil = 1
                    Else
                        val_phil = 0
                    End If

                    If sss.Checked = True Then
                        val_sss = 1
                    Else
                        val_sss = 0
                    End If

                    If pagibig.Checked = True Then
                        val_pagibig = 1
                    Else
                        val_pagibig = 0
                    End If

                    If tax.Checked = True Then
                        val_tax = 1
                    Else
                        val_tax = 0
                    End If

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
                    dependent ='" & txtdependent.Text & "',
                    emp_id ='" & txtEmpId.Text & "',
                    bypass ='" & bypass & "',
                    philhealth ='" & val_phil & "',
                    sss ='" & val_sss & "',
                    pagibig ='" & val_pagibig & "',
                    sss_id ='" & sssId.Text & "',
                    pagibig_id ='" & pagibigId.Text & "',
                    philhealth_id ='" & philId.Text & "',
                    tax_id ='" & taxId.Text & "',
                    separation_date = '" & txtSeparationdate.Text & "',
                    tax = '" & val_tax & "'
                    WHERE id = '" & id & "'")

                    'updateDB("UPDATE schedule SET first_in = '" & txtFirstTimein.Text & "', first_out = '" & txtFirstTimeout.Text & "', second_in = '" & txtSecondTimein.Text & "', second_out = '" & txtSecondTimeout.Text & "', shift = '" & dpShift.Text & "' WHERE emp_id = '" & txtEmpId.Text & "'")
                    updateDB("DELETE FROM restday WHERE emp_id = '" & emp_id & "'")
                    updateDB("DELETE FROM schedule WHERE emp_id = '" & emp_id & "'")
                    updateDB("INSERT INTO schedule (emp_id, first_in, first_out, second_in, second_out, shift) VALUES  
                ('" & txtEmpId.Text & "','" & txtFirstTimein.Text & "','" & txtFirstTimeout.Text & "','" & txtSecondTimein.Text & "','" & txtSecondTimeout.Text & "','" & dpShift.Text & "')")
                    setRestday(txtEmpId.Text)
                    btnedit.Text = "Edit"
                    enableDisable(False)
                    btnsave.Enabled = True
                    btndelete.Text = "Delete"
                    getEmplist()
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
                    updateDB("DELETE FROM employees WHERE id = '" & showDGValue(EmployeesDG, "id") & "'")
                    updateDB("DELETE FROM schedule WHERE emp_id = '" & txtEmpId.Text & "'")
                    updateDB("DELETE FROM restday WHERE emp_id = '" & txtEmpId.Text & "'")
                    updateDB("DELETE FROM deduction WHERE emp_id = '" & txtEmpId.Text & "'")
                    updateDB("DELETE FROM earnings WHERE emp_id = '" & txtEmpId.Text & "'")
                    updateDB("DELETE FROM leave WHERE emp_id = '" & txtEmpId.Text & "'")
                    updateDB("DELETE FROM misc_deduction WHERE emp_id = '" & txtEmpId.Text & "'")
                    updateDB("DELETE FROM overtime WHERE emp_id = '" & txtEmpId.Text & "'")
                    updateDB("DELETE FROM pay_emp WHERE emp_id = '" & txtEmpId.Text & "'")
                    updateDB("DELETE FROM work_time WHERE emp_id = '" & txtEmpId.Text & "'")
                    updateDB("DELETE FROM u_roles WHERE emp_id = '" & showDGValue(EmployeesDG, "id") & "'")
                    getEmplist()
            End Select
        End If
    End Sub

    Public Sub getEmplist()
        getData("SELECT id, fname, lname, mname, position, address, contact, emp_id FROM employees", "employees", EmployeesDGControl)
    End Sub

    Private Sub EmployeesDGControl_Click(sender As Object, e As EventArgs) Handles EmployeesDGControl.Click

    End Sub

    Private Sub dpstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dpstatus.SelectedIndexChanged
        If dpstatus.Text = "In-Active" Then
            lblSeparation.Visible = True
            txtSeparationdate.Visible = True
        Else
            lblSeparation.Visible = False
            txtSeparationdate.Visible = False
            txtSeparationdate.Text = ""
        End If
    End Sub
End Class