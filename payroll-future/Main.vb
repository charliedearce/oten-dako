Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
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
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height

        Me.Width = intX
        Me.Height = intY - (intX * 0.02)

        AutoUpdater.Start("http://top.app/update.xml")
        AutoUpdater.Mandatory = True
        AutoUpdater.AppTitle = "Payroll Updater"
        'MsgBox(CpuId())
        Dim field As Object = readDBMulti("SELECT * FROM settings", {"comp_name"})
        Me.Text = field(0) & " Payroll System [Ver. " & Application.ProductVersion.Substring(0, 3) & "]"

        txtdate.Caption = Date.Now.ToString("MM-dd-yyyy")
        loginFrm.ShowDialog()
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

        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'loan_module'", "id")
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

    Private Sub BarButtonItem22_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & txtEmpID.Caption & "'", "emp_id")

        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'deduction_table_module'", "id")
        If role_id <> 0 Then
            deductionRefFrm.ShowDialog()
        Else
            MsgBox("You are not allowed to use this module. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If
    End Sub

    Private Sub BarButtonItem17_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & txtEmpID.Caption & "'", "emp_id")

        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'export_government_deductions'", "id")
        If role_id <> 0 Then
            exportGovDeductionFrm.ShowDialog()
        Else
            MsgBox("You are not allowed to use this module. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If

    End Sub

    Private Sub BarButtonItem23_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        systemSettingsFrm.ShowDialog()
    End Sub

    Private Sub BarButtonItem25_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        Dim msg As MsgBoxResult = MsgBox("Hey! " & txtEmpName.Caption & " Are you sure you want logout?", vbYesNo + vbQuestion, "Message")
        Select Case msg
            Case vbYes
                txtEmpID.Caption = ""
                txtEmpIdDynamic.Caption = ""
                txtEmpName.Caption = ""
                loginFrm.ShowDialog()
        End Select
    End Sub

    Private Sub BarButtonItem20_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & txtEmpID.Caption & "'", "emp_id")

        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'export_misc_deductions'", "id")
        If role_id <> 0 Then
            Dim myAdapter As New SqlDataAdapter
            Dim myCmd As SqlCommand

            Dim connection As New SqlConnection(SQLServerConnection)
            Try

                connection.Open()
                Dim ds As New DataSet1

                myCmd = New SqlCommand("misc_export", connection)

                myCmd.CommandType = CommandType.StoredProcedure
                myAdapter.SelectCommand = myCmd
                myAdapter.Fill(ds, "misc_export")

                Dim crystal As New misc_deduction
                crystal.SetDataSource(ds)

                SaveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx"
                SaveFileDialog1.Title = "Misc. Deductions"
                SaveFileDialog1.FileName = "Misc. Deductions " + Date.Now.ToString("MM-dd-yyyy")
                SaveFileDialog1.ShowDialog()
                Dim strExportFile As String = SaveFileDialog1.FileName

                Dim CrExportOptions As ExportOptions
                Dim CrDiskFileDestinationOptions As New _
            DiskFileDestinationOptions()
                Dim CrFormatTypeOptions As New ExcelFormatOptions
                CrDiskFileDestinationOptions.DiskFileName = strExportFile

                CrExportOptions = crystal.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.ExcelWorkbook
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With
                crystal.Export()

            Catch ex As Exception
                MsgBox("NO RECORD TO SHOW...")
                connection.Close()
            Finally
                If (connection.State = ConnectionState.Open) Then
                    connection.Close()
                End If
            End Try
            connection.Close()
        Else
            MsgBox("You are not allowed to use this module. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If

    End Sub

    Private Sub BarButtonItem26_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        viewGovDeduction.ShowDialog()
    End Sub
End Class
