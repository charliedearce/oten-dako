Public Class deductionRefFrm
    Private Sub deductionRefFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewDeductions()
    End Sub

    Public Sub viewDeductions()
        getDataMultiple("SELECT * FROM sss ORDER BY sss_from", {"sss"}, sssDGControl)
        getDataMultiple("SELECT * FROM pagibig ORDER BY pagibig_from", {"pagibig"}, pagibigDGControl)
        getDataMultiple("SELECT * FROM tax ORDER BY tax_from", {"tax"}, taxDGControl)
        getDataMultiple("SELECT * FROM philhealth ORDER BY phil_from", {"philhealth"}, philhealthDGControl)
    End Sub

    Private Sub TextEdit4_EditValueChanged(sender As Object, e As EventArgs) Handles pagibig_amount.EditValueChanged

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If (sss_amount.Text = "" Or sss_from.Text = "" Or sss_to.Text = "") Then
            MsgBox("Please fill up all the fields.", vbExclamation, "Error")
        ElseIf (Double.Parse(sss_from.Text) > Double.Parse(sss_to.Text)) Then
            MsgBox("[From] field must not be greater than [To] field. Please try again.", vbExclamation, "Error")
        Else
            updateDB("INSERT INTO sss (sss_from, sss_to, amount) VALUES ('" & sss_from.Text & "', '" & sss_to.Text & "', '" & sss_amount.Text & "')")
            viewDeductions()
            MsgBox("SSS deduction range added.", vbInformation, "Info")
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If (pagibig_from.Text = "" Or pagibig_from.Text = "" Or pagibig_to.Text = "") Then
            MsgBox("Please fill up all the fields.", vbExclamation, "Error")
        ElseIf (Double.Parse(pagibig_from.Text) > Double.Parse(pagibig_to.Text)) Then
            MsgBox("[From] field must not be greater than [To] field. Please try again.", vbExclamation, "Error")
        Else
            updateDB("INSERT INTO pagibig (pagibig_from, pagibig_to, amount) VALUES ('" & pagibig_from.Text & "', '" & pagibig_to.Text & "', '" & pagibig_amount.Text & "')")
            viewDeductions()
            MsgBox("PAG-IBIG deduction range added.", vbInformation, "Info")
        End If
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        If (tax_amount.Text = "" Or tax_from.Text = "" Or tax_to.Text = "") Then
            MsgBox("Please fill up all the fields.", vbExclamation, "Error")
        ElseIf (Double.Parse(tax_from.Text) > Double.Parse(tax_to.Text)) Then
            MsgBox("[From] field must not be greater than [To] field. Please try again.", vbExclamation, "Error")
        Else
            updateDB("INSERT INTO tax (tax_from, tax_to, amount) VALUES ('" & tax_from.Text & "', '" & tax_to.Text & "', '" & tax_amount.Text & "')")
            viewDeductions()
            MsgBox("TAX deduction range added.", vbInformation, "Info")
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If (phil_amount.Text = "" Or phil_from.Text = "" Or phil_to.Text = "") Then
            MsgBox("Please fill up all the fields.", vbExclamation, "Error")
        ElseIf (Double.Parse(phil_from.Text) > Double.Parse(phil_to.Text)) Then
            MsgBox("[From] field must not be greater than [To] field. Please try again.", vbExclamation, "Error")
        Else
            updateDB("INSERT INTO philhealth (phil_from, phil_to, amount) VALUES ('" & phil_from.Text & "', '" & phil_to.Text & "', '" & phil_amount.Text & "')")
            viewDeductions()
            MsgBox("PHILHEALTH deduction range added.", vbInformation, "Info")
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim id As Integer = showDGValue(sssDG, "id")
        If (id <> 0) Then
            Dim msg As MsgBoxResult = MsgBox("Are you sure you want to delete SSS deduction range data?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes
                    updateDB("DELETE FROM sss WHERE id = '" & id & "'")
                    viewDeductions()
                    MsgBox("SSS range deleted.", vbInformation, "Message")
            End Select
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim id As Integer = showDGValue(pagibigDG, "id")
        If (id <> 0) Then
            Dim msg As MsgBoxResult = MsgBox("Are you sure you want to delete PAG-IBIG deduction range data?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes
                    updateDB("DELETE FROM pagibig WHERE id = '" & id & "'")
                    viewDeductions()
                    MsgBox("PAG-IBIG range deleted.", vbInformation, "Message")
            End Select
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim id As Integer = showDGValue(philhealthDG, "id")
        If (id <> 0) Then
            Dim msg As MsgBoxResult = MsgBox("Are you sure you want to delete PHIL-HEALTH deduction range data?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes
                    updateDB("DELETE FROM philhealth WHERE id = '" & id & "'")
                    viewDeductions()
                    MsgBox("PHIL-HEALTH range deleted.", vbInformation, "Message")
            End Select
        End If
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Dim id As Integer = showDGValue(taxDG, "id")
        If (id <> 0) Then
            Dim msg As MsgBoxResult = MsgBox("Are you sure you want to delete HTAX deduction range data?", vbYesNo + vbQuestion, "Message")
            Select Case msg
                Case vbYes
                    updateDB("DELETE FROM tax WHERE id = '" & id & "'")
                    viewDeductions()
                    MsgBox("HTAX range deleted.", vbInformation, "Message")
            End Select
        End If
    End Sub

    Private Sub deductionRefFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class