Public Class userFrm
    Private Sub userFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDPwithID("SELECT emp_id, fname + ' ' + lname as employee FROM employees", {"emp_id", "employee"}, cbEmployee)
        DisplayDP("SELECT role_desc FROM role_list", "role_desc", cbPermission)
    End Sub

    Private Sub dpEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmployee.SelectedIndexChanged

    End Sub

    Private Sub btadd_Click(sender As Object, e As EventArgs) Handles btadd.Click
        Dim emp_id As Integer = DirectCast(cbEmployee.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim msg As MsgBoxResult = MsgBox("Are you sure you want to add this permission [ " & cbPermission.Text & "] to [" & cbEmployee.Text & "]?", vbYesNo + vbQuestion, "Message")
        Select Case msg
            Case vbYes
                updateDB("INSERT INTO u_roles (emp_id, description) VALUES ('" & emp_id & "', '" & cbPermission.Text & "', 'Open', 'Regular')")
        End Select
    End Sub


End Class