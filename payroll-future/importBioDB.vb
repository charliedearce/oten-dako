﻿Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Base

Public Class importBioDB
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
        getData("SELECT id , lname AS LastName, fname AS FirstName, type as EMP_TYPE FROM employees WHERE status = 'Active'", "employee", EmployeesDGControl)
        getData("SELECT CONVERT(VARCHAR(10),CHECKTIME,110) as AttendanceDates FROM biometrics group by CONVERT(VARCHAR(10),CHECKTIME,110) order by CONVERT(VARCHAR(10),CHECKTIME,110) DESC", "biometrics", AttDatesControl)
        paynolbl.Text = Main.lblPayNo.Caption
        Dim columnName As String() = {"id"}
        showHideColumn(EmployeesDG, columnName, False)
        showHideColumn(FirstInDG, columnName, False)
        showHideColumn(FirstOutDG, columnName, False)
        showHideColumn(SecondInDG, columnName, False)
        showHideColumn(SecondOutDG, columnName, False)
    End Sub

    Public Function test()

    End Function

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        PerformImportToSql(txtFn.Text)
    End Sub

    Private Sub PerformImportToSql(ByVal Filename As String)
        Dim table As DataTable = New DataTable
        Dim accConnection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Filename & ";")

        Dim sqlConnection As New SqlConnection(SQLServerConnection)
        Try
            SplashScreenManager1.ShowForm(GetType(progressbar))

            'Import the Access data
            accConnection.Open()
            Dim accDataAdapter = New OleDbDataAdapter("SELECT USERID,CHECKTIME,CHECKTYPE FROM CHECKINOUT", accConnection)
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
            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If
            MessageBox.Show("Import failed with error: " & Environment.NewLine & Environment.NewLine _
            & ex.ToString)

        End Try


        SplashScreenManager1.CloseForm()


    End Sub

    Private Sub EmployeesDG_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles EmployeesDG.FocusedRowChanged

        RefreshAttDG()
    End Sub

    Private Sub AttDatesControl_Click(sender As Object, e As EventArgs) Handles AttDatesControl.Click

    End Sub

    Private Sub AttDates_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles AttDates.FocusedRowChanged

        RefreshAttDG()
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
        txtEmpName.Text = showDGValue(EmployeesDG, "LastName") + ", " + showDGValue(EmployeesDG, "FirstName")
        txtDate.Text = showDGValue(AttDates, "AttendanceDates")
        Dim id As Integer = showDGValue(EmployeesDG, "id")

        getData("SELECT id, convert(char(8), CHECKTIME, 114) as TimeIn FROM biometrics WHERE USERID = '" & id & "'
        AND convert(char(8), CHECKTIME, 114) < (Select Convert(Char(8), first_out, 114) FROM schedule WHERE emp_id = '" & id & "') AND CHECKTYPE = 'I' AND CONVERT(VARCHAR(10),CHECKTIME,110) = '" & txtDate.Text & "'", "biometrics", FirstInDGControl)

        getData("SELECT id, convert(char(8), CHECKTIME, 114) as TimeOut FROM biometrics WHERE USERID = '" & id & "'
        AND convert(char(8), CHECKTIME, 114) < (Select Convert(Char(8), second_in, 114) FROM schedule WHERE emp_id = '" & id & "') AND CHECKTYPE = 'O' AND CONVERT(VARCHAR(10),CHECKTIME,110) = '" & txtDate.Text & "'", "biometrics", FirstOutDGControl)

        getData("SELECT id, convert(char(8), CHECKTIME, 114) as TimeIn FROM biometrics WHERE USERID = '" & id & "'
        AND convert(char(8), CHECKTIME, 114) > (Select Convert(Char(8), first_out, 114) FROM schedule WHERE emp_id = '" & id & "') AND CHECKTYPE = 'I' AND CONVERT(VARCHAR(10),CHECKTIME,110) = '" & txtDate.Text & "'", "biometrics", SecondInDGControl)

        getData("SELECT id, convert(char(8), CHECKTIME, 114) as TimeOut FROM biometrics WHERE USERID = '" & id & "'
        AND convert(char(8), CHECKTIME, 114) > (Select Convert(Char(8), second_in, 114) FROM schedule WHERE emp_id = '" & id & "') AND CHECKTYPE = 'O' AND CONVERT(VARCHAR(10),CHECKTIME,110) = '" & txtDate.Text & "'", "biometrics", SecondOutDGControl)
    End Function

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If txtEmpName.Text = "" Then
            MsgBox("Please select employee name first.", vbExclamation, "Something went wrong")
        Else
            attFormNew.ShowDialog()
        End If
    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        'daterange.ShowDialog()
        OverallComputations("SELECT id FROM employees")
    End Sub
End Class