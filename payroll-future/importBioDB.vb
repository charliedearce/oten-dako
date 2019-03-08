Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class importBioDB
    Dim cur_date As Date
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        OpenFileDialog1.Title = "Locate Biometrics Data File"
        OpenFileDialog1.Filter = "MS Access|*.mdb"

        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then
            ' Get the file name.
            Dim path As String = OpenFileDialog1.FileName
            txtFn.Text = path
        End If
    End Sub

    Private Sub importBioDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getData("SELECT id , lname + ' ' + fname as employee,  emp_id FROM employees WHERE status = 'Active' AND (type='Regular' OR type = 'Irregular') ", "employees", EmployeesDGControl)
        getData("SELECT CONVERT(date,CHECKTIME) as AttendanceDates FROM biometrics group by CONVERT(date,CHECKTIME) order by CONVERT(date,CHECKTIME) DESC", "biometrics", AttDatesControl)
        Dim fields As Object = readDBMulti("SELECT id, from_date, to_date FROM payroll_info WHERE status = 'Open' AND (type='Regular' OR type = 'Irregular')", {"id", "from_date", "to_date"})
        If IsNothing(fields(0)) Then
            MsgBox("Payroll doesn't generated yet.", vbExclamation, "Message")
            Me.Dispose()
        Else
            paynolbl.Text = fields(0)
            lblfrom.Text = Format(fields(1), "MM-dd-yyyy")
            lblto.Text = Format(fields(2), "MM-dd-yyyy")
        End If
        'Dim columnName As String() = {"id"}
        'showHideColumn(EmployeesDG, columnName, False)
        'showHideColumn(FirstInDG, columnName, False)
        'showHideColumn(FirstOutDG, columnName, False)
        'showHideColumn(SecondInDG, columnName, False)
        'showHideColumn(SecondOutDG, columnName, False)
    End Sub

    Public Function test()

    End Function

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & Main.txtEmpID.Caption & "'", "emp_id")

        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'import_biometrics'", "id")
        If role_id <> 0 Then
            If txtFn.Text = "" Then
                MsgBox("Please select biometrics database first.", vbExclamation, "No database found.")
            Else
                PerformImportToSql(txtFn.Text)
            End If
        Else
            MsgBox("You are not allowed to do this operation. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If

    End Sub

    Private Sub PerformImportToSql(ByVal Filename As String)
        Dim fields As Object = readDBMulti("SELECT from_date, to_date FROM payroll_info WHERE status = 'Open' AND (type='Regular' OR type = 'Irregular')", {"from_date", "to_date"})
        Dim table As DataTable = New DataTable
        Dim accConnection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Filename & ";")

        Dim sqlConnection As New SqlConnection(SQLServerConnection)
        Try
            SplashScreenManager1.ShowForm(GetType(progressbar))

            'Import the Access data
            accConnection.Open()
            Dim accDataAdapter = New OleDbDataAdapter("SELECT USERINFO.badgenumber as USERID, CHECKINOUT.CHECKTIME, CHECKINOUT.CHECKTYPE FROM CHECKINOUT, USERINFO WHERE CHECKINOUT.USERID = USERINFO.USERID AND FORMAT(CHECKINOUT.CHECKTIME, 'Short Date') >=  DateValue('" & fields(0) & "') AND FORMAT(CHECKINOUT.CHECKTIME, 'Short Date') <= DateValue('" & fields(1) & "')", accConnection)
            accDataAdapter.Fill(table)
            accConnection.Close()

            For Each row As DataRow In table.Rows
                row.SetAdded()
            Next

            'Export to MS SQL
            sqlConnection.Open()
            Dim adapter As New SqlDataAdapter()
            'Delete All Data before importing
            adapter.DeleteCommand = sqlConnection.CreateCommand()
            adapter.DeleteCommand.CommandText = "delete from biometrics"
            adapter.DeleteCommand.ExecuteNonQuery()
            'Inserting Data from Access
            Dim sqlDataAdapter As New SqlDataAdapter("SELECT * FROM biometrics", sqlConnection)
            Dim sqlCommandBuilder As New SqlCommandBuilder(sqlDataAdapter)
            sqlDataAdapter.InsertCommand = sqlCommandBuilder.GetInsertCommand()
            sqlDataAdapter.DeleteCommand = sqlCommandBuilder.GetDeleteCommand()
            sqlDataAdapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand()

            sqlDataAdapter.Update(table)
            sqlConnection.Close()
        Catch ex As Exception
            If accConnection.State = ConnectionState.Open Then
                accConnection.Close()
            End If
            MessageBox.Show("Import failed with error: " & Environment.NewLine & Environment.NewLine _
            & ex.ToString)

        End Try

        getData("SELECT id , lname AS LastName, fname AS FirstName, type as EMP_TYPE , emp_id FROM employees WHERE status = 'Active' AND (type='Regular' OR type = 'Irregular')", "employees", EmployeesDGControl)
        getData("SELECT CONVERT(date,CHECKTIME) as AttendanceDates FROM biometrics group by CONVERT(date,CHECKTIME) order by CONVERT(date,CHECKTIME) DESC", "biometrics", AttDatesControl)
        SplashScreenManager1.CloseForm()


    End Sub



    Private Sub AttDatesControl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FirstInDGControl_Click(sender As Object, e As EventArgs) Handles FirstInDGControl.Click

    End Sub

    Private Sub FirstInDG_Click(sender As Object, e As EventArgs) Handles FirstInDG.Click
        attForm.txtId.Text = showDGValue(FirstInDG, "id")
        attForm.DateEdit1.EditValue = showDGValue(FirstInDG, "TimeIn")
        If attForm.txtId.Text <> "" Then
            attForm.ShowDialog()
        End If

    End Sub

    Private Sub FirstOutDG_Click(sender As Object, e As EventArgs) Handles FirstOutDG.Click
        attForm.txtId.Text = showDGValue(FirstOutDG, "id")
        attForm.DateEdit1.EditValue = showDGValue(FirstOutDG, "TimeOut")
        If attForm.txtId.Text <> "" Then
            attForm.ShowDialog()
        End If
    End Sub

    Private Sub SecondInDG_Click(sender As Object, e As EventArgs) Handles SecondInDG.Click
        attForm.txtId.Text = showDGValue(SecondInDG, "id")
        attForm.DateEdit1.EditValue = showDGValue(SecondInDG, "TimeIn")
        If attForm.txtId.Text <> "" Then
            attForm.ShowDialog()
        End If
    End Sub

    Private Sub SecondOutDG_Click(sender As Object, e As EventArgs) Handles SecondOutDG.Click
        attForm.txtId.Text = showDGValue(SecondOutDG, "id")
        attForm.DateEdit1.EditValue = showDGValue(SecondOutDG, "TimeOut")
        If attForm.txtId.Text <> "" Then
            attForm.ShowDialog()
        End If
    End Sub

    Public Function RefreshAttDG() As Object
        txtEmpName.Text = showDGValue(EmployeesDG, "employee")
        cur_date = showDGValue(AttDates, "AttendanceDates")
        txtDate.Text = cur_date
        Dim id As Integer = showDGValue(EmployeesDG, "emp_id")

        getData("SELECT id, convert(char(8), CHECKTIME, 114) as TimeIn FROM biometrics WHERE USERID = '" & id & "'
        AND convert(char(8), CHECKTIME, 114) < (Select Convert(Char(8), first_out, 114) FROM schedule WHERE emp_id = '" & id & "') AND CHECKTYPE = 'I' AND CONVERT(VARCHAR(10),CHECKTIME,110) = '" & cur_date.ToString("MM-dd-yyyy") & "'", "biometrics", FirstInDGControl)

        getData("SELECT id, convert(char(8), CHECKTIME, 114) as TimeOut FROM biometrics WHERE USERID = '" & id & "'
        AND convert(char(8), CHECKTIME, 114) < (Select Convert(Char(8), second_in, 114) FROM schedule WHERE emp_id = '" & id & "') AND CHECKTYPE = 'O' AND CONVERT(VARCHAR(10),CHECKTIME,110) = '" & cur_date.ToString("MM-dd-yyyy") & "'", "biometrics", FirstOutDGControl)

        getData("SELECT id, convert(char(8), CHECKTIME, 114) as TimeIn FROM biometrics WHERE USERID = '" & id & "'
        AND convert(char(8), CHECKTIME, 114) > (Select Convert(Char(8), first_out, 114) FROM schedule WHERE emp_id = '" & id & "') AND CHECKTYPE = 'I' AND CONVERT(VARCHAR(10),CHECKTIME,110) = '" & cur_date.ToString("MM-dd-yyyy") & "'", "biometrics", SecondInDGControl)

        getData("SELECT id, convert(char(8), CHECKTIME, 114) as TimeOut FROM biometrics WHERE USERID = '" & id & "'
        AND convert(char(8), CHECKTIME, 114) > (Select Convert(Char(8), second_in, 114) FROM schedule WHERE emp_id = '" & id & "') AND CHECKTYPE = 'O' AND CONVERT(VARCHAR(10),CHECKTIME,110) = '" & cur_date.ToString("MM-dd-yyyy") & "'", "biometrics", SecondOutDGControl)


    End Function

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & Main.txtEmpID.Caption & "'", "emp_id")

        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'new_attendance_biometrics'", "id")
        If role_id <> 0 Then
            If txtEmpName.Text = "" Then
                MsgBox("Please select employee name first.", vbExclamation, "Something went wrong")
            Else

                attFormNew.DateEdit1.DateTime = showDGValue(AttDates, "AttendanceDates")
                attFormNew.ShowDialog()
            End If
        Else
            MsgBox("You are not allowed to do this operation. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If
    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        'daterange.ShowDialog()
        Dim emp_id As Integer = readDB("SELECT emp_id FROM users WHERE emp_id = '" & Main.txtEmpID.Caption & "'", "emp_id")

        Dim role_id As Integer = readDB("SELECT id FROM u_roles WHERE emp_id = " & emp_id & " AND description = 'process_biometrics'", "id")
        If role_id <> 0 Then
            Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE (type='Regular' OR type = 'Irregular') and status='Open'", "id")
            OverallComputations("SELECT employees.emp_id, employees.bypass FROM employees,pay_emp WHERE status = 'Active' AND (type='Regular' OR type = 'Irregular') AND pay_emp.emp_id = employees.emp_id AND pay_emp.payroll_no = '" & pay_id & "'")
        Else
            MsgBox("You are not allowed to do this operation. Pleas contact the administrator.", vbExclamation, "Permission denied")
        End If

    End Sub




    Private Sub importBioDB_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub GroupControl2_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub AttDatesControl_Click_1(sender As Object, e As EventArgs) Handles AttDatesControl.Click

    End Sub

    Private Sub AttDates_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles AttDates.FocusedRowChanged
        RefreshAttDG()
    End Sub

    Private Sub SimpleButton5_Click_1(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        getData("SELECT CONVERT(date,CHECKTIME) as AttendanceDates FROM biometrics group by CONVERT(date,CHECKTIME) order by CONVERT(date,CHECKTIME) DESC", "biometrics", AttDatesControl)
        RefreshAttDG()
    End Sub

    Private Sub EmployeesDGControl_Click(sender As Object, e As EventArgs) Handles EmployeesDGControl.Click

    End Sub

    Private Sub EmployeesDG_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles EmployeesDG.FocusedRowChanged
        RefreshAttDG()
    End Sub
End Class