Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmPayslip
    Dim myAdapter As New SqlDataAdapter
    Dim myCmd As SqlCommand
    Dim myCmd1 As SqlCommand
    Dim connection As New SqlConnection(SQLServerConnection)
    Private Sub frmPayslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim field As Object = readDBMulti("SELECT * FROM settings", {"comp_name", "comp_address", "comp_contact"})

        Try
            connection.Open()

            Dim ds As New DataSet1

            myCmd = New SqlCommand("payslip", connection)
            myCmd.Parameters.Add(New SqlParameter("@payroll_no", SqlDbType.Int)).Value = computationFrm.txtPayno.Text
            myCmd.CommandType = CommandType.StoredProcedure
            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(ds, "payslip")

            Dim crystal As New Payslip

            Dim comp_name As TextObject = CType(crystal.ReportDefinition.ReportObjects("comp_name"), TextObject)
            Dim comp_address As TextObject = CType(crystal.ReportDefinition.ReportObjects("comp_address"), TextObject)
            Dim comp_contact As TextObject = CType(crystal.ReportDefinition.ReportObjects("comp_contact"), TextObject)
            comp_name.Text = field(0)
            comp_address.Text = field(1)
            comp_contact.Text = field(2)

            crystal.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crystal
            CrystalReportViewer1.Refresh()
            connection.Close()
        Catch ex As Exception
            MsgBox("NO RECORD TO SHOW...")
            connection.Close()
            Me.Dispose()
        End Try
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class