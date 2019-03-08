Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class viewGovDeduction
    Dim myAdapter As New SqlDataAdapter
    Dim myCmd As SqlCommand
    Dim myCmd1 As SqlCommand
    Dim connection As New SqlConnection(SQLServerConnection)
    Private Sub viewGovDeduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim field As Object = readDBMulti("SELECT * FROM settings", {"comp_name", "comp_address", "comp_contact"})

        'Try
        connection.Open()

            Dim ds As New DataSet1

            myCmd = New SqlCommand("payslip", connection)
        myCmd.Parameters.Add(New SqlParameter("@payroll_no", SqlDbType.Int)).Value = 1
        myCmd.CommandType = CommandType.StoredProcedure
            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(ds, "payslip")

            Dim crystal As New sss_r3



        'crystal.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = crystal
            CrystalReportViewer1.Refresh()
            connection.Close()
        'Catch ex As Exception
        '    MsgBox("NO RECORD TO SHOW...")
        '    connection.Close()
        '    Me.Dispose()
        'End Try

        WebBrowser1.Navigate("http://payroll.test/")
    End Sub
End Class