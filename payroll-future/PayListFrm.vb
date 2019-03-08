Public Class PayListFrm
    Private Sub PayListFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getData("SELECT * FROM payroll_info WHERE status = 'Close'", "payroll_info", PayListDGControl)
    End Sub

    Private Sub PayListDGControl_Click(sender As Object, e As EventArgs) Handles PayListDGControl.Click
        Dim id As Integer = showDGValue(PayListDG, "id")
        Dim from_date As String = showDGValue(PayListDG, "from_date")
        Dim to_date As String = showDGValue(PayListDG, "to_date")
        Dim status As String = showDGValue(PayListDG, "status")
        computationFrm.Text = "[Payroll No: " & id & "] [Payroll Date From: " & from_date & " - To: " & to_date & "] [Status: " & status & "]"
        computationFrm.txtSearchindicator.Text = id
        computationFrm.ShowDialog()
    End Sub

    Private Sub PayListFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class