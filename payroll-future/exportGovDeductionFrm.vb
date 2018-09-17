Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Public Class exportGovDeductionFrm


    Private Sub exportGovDeductionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim title As String = ""
        Dim sql As String = ""
        Dim report As String = ""
        Dim crystal As Object

        If dpType.Text = "SSS" Then
            title = "SSS Contribution "
            sql = "sss_export"
            crystal = New sssDeduction
        ElseIf dpType.Text = "PAG-IBIG" Then
            title = "PAG-IBIG Contribution "
            sql = "pagibig_export"
            crystal = New pagibigDeduction
        ElseIf dpType.Text = "PHIL-HEALTH" Then
            title = "PHIL-HEALTH Contribution "
            sql = "phil_export"
            crystal = New philhealthDeduction
        ElseIf dpType.Text = "WHTAX" Then
            title = "With Holding Tax Contribution "
            sql = "htax_export"
            crystal = New htaxDeduction
        End If
        Dim myAdapter As New SqlDataAdapter
        Dim myCmd As SqlCommand

        Dim connection As New SqlConnection(SQLServerConnection)
        Try

            connection.Open()
            Dim ds As New DataSet1

            myCmd = New SqlCommand(sql, connection)

            myCmd.Parameters.Add(New SqlParameter("@date_from", SqlDbType.DateTime)).Value = dpFrom.Text
            myCmd.Parameters.Add(New SqlParameter("@date_to", SqlDbType.DateTime)).Value = dpTo.Text
            myCmd.CommandType = CommandType.StoredProcedure
            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(ds, sql)

            crystal.SetDataSource(ds)

            SaveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx"
            SaveFileDialog1.Title = title
            SaveFileDialog1.FileName = title + Date.Now.ToString("MM-dd-yyyy")
            SaveFileDialog1.ShowDialog()
            Dim strExportFile As String = SaveFileDialog1.FileName

            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New _
            DiskFileDestinationOptions()
            Dim CrFormatTypeOptions As New ExcelFormatOptions
            CrDiskFileDestinationOptions.DiskFileName = strExportFile

            CrExportOptions = crystal.ExportOptions
            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.ExcelWorkbook
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With
            crystal.Export()

        Catch ex As Exception
            MsgBox("NO RECORD TO SHOW...")
            connection.Close()
        Finally
            If (connection.State = ConnectionState.Open) Then
                connection.Close()
            End If
        End Try
        connection.Close()
    End Sub
End Class