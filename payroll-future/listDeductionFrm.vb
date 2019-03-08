Public Class listDeductionFrm
    Private Sub listDeductionFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub listDeductionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDataMultiple("SELECT * FROM deduction WHERE misc_id = '" & txtId.Text & "'", {"deduction"}, deductionListDGControl)
    End Sub
End Class