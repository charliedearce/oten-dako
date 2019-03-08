Public Class attFormNew
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim result As Boolean
        Dim msg As MsgBoxResult
        Dim type As String
        Dim id As Integer = showDGValue(importBioDB.EmployeesDG, "emp_id")

        If RadioButton1.Checked = True Then
            type = "I"
        ElseIf RadioButton2.Checked = True Then
            type = "O"
        End If

        msg = MsgBox("Are you sure you want to add New Attendance to [" + importBioDB.txtEmpName.Text + "]?", vbYesNo + vbQuestion, "Message")
        Select Case msg
            Case vbYes
                result = updateDB("INSERT INTO biometrics (USERID, CHECKTIME, CHECKTYPE) VALUES (" & id & ",'" & DateEdit1.Text & "','" & type & "')")
                If result = True Then
                    importBioDB.RefreshAttDG()
                    Me.Close()
                End If
        End Select

    End Sub

    Private Sub attFormNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateEdit1.DateTime = showDGValue(importBioDB.AttDates, "AttendanceDates")
    End Sub

    Private Sub attFormNew_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class