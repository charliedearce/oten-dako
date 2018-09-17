Public Class userFrm
    Private Sub userFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDPwithID("SELECT id, fname + ' ' + lname as employee FROM employees", {"id", "employee"}, cbEmployee)
        DisplayDP("SELECT role_desc FROM role_list", "role_desc", cbPermission)
    End Sub

    Private Sub dpEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmployee.SelectedIndexChanged
        viewPermission()
    End Sub

    Public Sub viewPermission()
        Dim id As Integer = DirectCast(cbEmployee.SelectedItem, KeyValuePair(Of String, String)).Key

        getDataMultiple("SELECT * FROM u_roles WHERE emp_id = '" & id & "'", {"u_roles"}, permissionsDGControl)
        Dim field As Object = readDBMulti("SELECT uname, upass FROM users WHERE emp_id = '" & id & "'", {"uname", "upass"})
        txtUsername.Text = field(0)
        txtPass.Text = field(1)
    End Sub

    Private Sub btadd_Click(sender As Object, e As EventArgs) Handles btsave.Click
        Dim id As Integer = DirectCast(cbEmployee.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim id_user As Integer = readDB("SELECT id FROM users WHERE emp_id = '" & id & "'", "id")
        Dim msg As MsgBoxResult = MsgBox("Are you sure you want To Save this usernam & password for  [" & cbEmployee.Text & "]?", vbYesNo + vbQuestion, "Message")
        Select Case msg
            Case vbYes
                If (id_user <> 0) Then
                    updateDB("UPDATE users SET uname = '" & txtUsername.Text & "', upass = '" & txtPass.Text & "' WHERE id = '" & id_user & "'")
                    MsgBox("User credentials updated.", vbInformation, "Info")
                Else
                    updateDB("INSERT INTO users (emp_id, uname, upass) VALUES ('" & id & "', '" & txtUsername.Text & "', '" & txtPass.Text & "')")
                    MsgBox("User credentials inserted.", vbInformation, "Info")
                End If

        End Select
    End Sub

    Private Sub LabelControl4_Click(sender As Object, e As EventArgs) Handles LabelControl4.Click

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim id As Integer = DirectCast(cbEmployee.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim permission_id As Integer = readDB("SELECT id FROM u_roles WHERE description = '" & cbPermission.Text & "' AND emp_id = '" & id & "'", "id")
        Dim msg As MsgBoxResult = MsgBox("Are you sure you want To add this permission for  [" & cbEmployee.Text & "]?", vbYesNo + vbQuestion, "Message")
        Select Case msg
            Case vbYes
                If (permission_id <> 0) Then
                    MsgBox("Permission already exist for this user.", vbExclamation, "Error")
                Else
                    updateDB("INSERT INTO u_roles (emp_id, description) VALUES ('" & id & "', '" & cbPermission.Text & "')")
                    viewPermission()
                    MsgBox("User permission added.", vbInformation, "Info")
                End If

        End Select
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim id As Integer = showDGValue(permissionsDG, "id")
        If (id <> 0) Then
            Dim msg As MsgBoxResult = MsgBox("Are you sure you want to delete this permission [" + showDGValue(permissionsDG, "description") + "] for [" & cbEmployee.Text & "]?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes
                    updateDB("DELETE FROM u_roles WHERE id = '" & id & "'")
                    viewPermission()
                    MsgBox("Permission deleted.", vbInformation, "Info")
            End Select
        End If
    End Sub
End Class