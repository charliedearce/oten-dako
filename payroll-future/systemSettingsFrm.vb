Public Class systemSettingsFrm
    Private Sub systemSettingsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim field As Object = readDBMulti("SELECT * FROM settings",
                                          {"comp_name", "comp_address", "comp_contact", "work_days",
                                          "sss_share", "pagibig_share", "philhealth_share", "tax_pay"})
        txtname.Text = field(0)
        txtaddress.Text = field(1)
        txttelno.Text = field(2)
        txtworkdays.Text = field(3)
        txtsss.Text = field(4)
        txtpagibig.Text = field(5)
        txtphilhealth.Text = field(6)
        txthtax.Text = field(7)
    End Sub

    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click
        Dim msg As MsgBoxResult = MsgBox("Are you sure you want To Save this system settings?", vbYesNo + vbQuestion, "Message")
        Select Case msg
            Case vbYes
                updateDB("UPDATE settings SET comp_name = '" & txtname.Text & "', comp_address = '" & txtaddress.Text & "',
                           comp_contact = '" & txttelno.Text & "', work_days = '" & txtworkdays.Text & "',
                           sss_share = '" & txtsss.Text & "', pagibig_share = '" & txtpagibig.Text & "',
                           philhealth_share = '" & txtphilhealth.Text & "', tax_pay = '" & txthtax.Text & "'")
                MsgBox("System settings updated.", vbInformation, "Info")
        End Select
    End Sub
End Class