Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmCitaSemana
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Consultorio;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim fechaInicio = dtpInicio.Value
        Dim fechaFin = dtpFinal.Value
        conexion.Open()
        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = conexion
        Adaptador.SelectCommand.CommandText = "citasSemana"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@FI", SqlDbType.Date)
        Dim param2 = New SqlParameter("@FF", SqlDbType.Date)
        param1.Direction = ParameterDirection.Input
        param2.Direction = ParameterDirection.Input
        param1.Value = CDate(fechaInicio)
        param2.Value = CDate(fechaFin)
        Adaptador.SelectCommand.Parameters.Add(param1)
        Adaptador.SelectCommand.Parameters.Add(param2)

        Dim Data As New DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("FI", fechaInicio)
        Dim p2 As New ReportParameter("FF", fechaFin)

        frmReportView.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportView.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        frmReportView.ReportViewer1.LocalReport.ReportPath = "C:\ConsultorioP\ConsultorioP\ConsultorioP\Reports\citaSemana.rdlc"
        frmReportView.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
        frmReportView.ReportViewer1.RefreshReport()
        frmReportView.Show()
        conexion.Close()
    End Sub

    Private Sub CitaSemana_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class