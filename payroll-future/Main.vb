
Imports System.ComponentModel
Imports System.Text
Imports AutoUpdaterDotNET

Partial Public Class Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoUpdater.Start("http://top.app/update.xml")
        AutoUpdater.Mandatory = True
        AutoUpdater.AppTitle = "Payroll Updater"
        'MsgBox(CpuId())
        
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        importBioDB.ShowDialog()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        computationFrm.ShowDialog()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & txtEmpID.Caption & "'", "emp_id")

        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'employee_module'", "id")
        If role_id <> 0 Then
            employeeForm.ShowDialog()
        Else
            MsgBox("You are not allowed to use this module. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If

    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & txtEmpID.Caption & "'", "emp_id")

        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'leave_module'", "id")
        If role_id <> 0 Then
            leaveFrm.ShowDialog()
        Else
            MsgBox("You are not allowed to use this module. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If

    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & txtEmpID.Caption & "'", "emp_id")

        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'holiday_module'", "id")
        If role_id <> 0 Then
            holiday.ShowDialog()
        Else
            MsgBox("You are not allowed to use this module. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If

    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & txtEmpID.Caption & "'", "emp_id")

        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'overtime_module'", "id")
        If role_id <> 0 Then
            overtimeFrm.ShowDialog()
        Else
            MsgBox("You are not allowed to use this module. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If

    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & txtEmpID.Caption & "'", "emp_id")

        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'deduction_module'", "id")
        If role_id <> 0 Then
            deductionFrm.ShowDialog()
        Else
            MsgBox("You are not allowed to use this module. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If

    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        Dim id As Integer = readDB("SELECT id FROM payroll_info WHERE status = 'Open' AND type = 'Regular'", "id")
        If id = 0 Then
            Dim msg As MsgBoxResult = MsgBox("Currently no Payroll Open for Regular Employees, do you want to generate?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes
                    payinfoFrm.ShowDialog()
            End Select
        Else
            frmDailiesPayrollNo.ShowDialog()
        End If
    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        payinfoFrm.btnsave.Text = "Update"
        payinfoFrm.ShowDialog()
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        PayListFrm.ShowDialog()
    End Sub

    Private Sub BarButtonItem21_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & txtEmpID.Caption & "'", "emp_id")

        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'user_module'", "id")
        If role_id <> 0 Then
            userFrm.ShowDialog()
        Else
            MsgBox("You are not allowed to use this module. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If
    End Sub
End Class
