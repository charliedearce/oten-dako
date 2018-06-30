Imports DevExpress.XtraGrid.Views.Base

Public Class holiday
    Private Sub holiday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDataMultiple("SELECT * FROM holiday", {"holiday"}, holidayDGControl)
    End Sub

    Private Sub holidayDG_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles holidayDG.FocusedRowChanged
        txtDate.Text = showDGValue(holidayDG, "date")
        txtdescription.Text = showDGValue(holidayDG, "description")
        dpEnable.Text = showDGValue(holidayDG, "enable")
        dpType.Text = showDGValue(holidayDG, "type")
    End Sub

    Public Sub clearFields()
        dpEnable.SelectedIndex = 0
        dpType.SelectedIndex = 0
        txtDate.Text = ""
        txtdescription.Text = ""
    End Sub

    Public Sub enableDisable(ByVal condition As Boolean)
        dpEnable.Enabled = condition
        dpType.Enabled = condition
        txtDate.Enabled = condition
        txtdescription.Enabled = condition
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If (btnsave.Text = "Save") Then
            btnsave.Text = "New"
            updateDB("INSERT INTO holiday (date, description, type, enable) VALUES ('" & txtDate.DateTime & "','" & txtdescription.Text & "','" & dpType.Text & "','" & dpEnable.Text & "')")
            getDataMultiple("SELECT * FROM holiday", {"holiday"}, holidayDGControl)
            clearFields()
            enableDisable(False)
        Else
            clearFields()
            btnsave.Text = "Save"
            enableDisable(True)
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim id As String = showDGValue(holidayDG, "id")
        If (id <> "") Then
            Dim msg As MsgBoxResult = MsgBox("Are you sure you want to delete holiday [" + showDGValue(holidayDG, "description") + "] info?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes
                    updateDB("DELETE FROM holiday WHERE id ='" & id & "'")
                    getDataMultiple("SELECT * FROM holiday", {"holiday"}, holidayDGControl)
            End Select
        End If
    End Sub
End Class