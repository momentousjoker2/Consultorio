Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration

Public Class frmReportePeriodo
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Consultorio;Integrated Security = Yes")
    Dim consulta As String
    Dim reporte As String

    Private Sub frmReportePeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub New(opcion As Integer)

        InitializeComponent()

        conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
        conexion.Open()

        Select Case opcion
            Case 1
                lblConsulta.Text = "Consultas por citas en un periodo"
                consulta = "reporteCitaPeriodo"
                reporte = "C:\Consultorio\ConsultorioP\Reportes\reporteCitaPeriodo.rdlc"
            Case 2
                lblConsulta.Text = "Consultas por pagos en un periodo"
                consulta = "reportePagosPeriodo"
                reporte = "C:\Consultorio\ConsultorioP\Reportes\reportePagosPeriodo.rdlc"
            Case 3
                lblConsulta.Text = "Consultas por Envio de material en un periodo"
                consulta = "reporteMaterialEnviadoPeriodo"
                reporte = "C:\Consultorio\ConsultorioP\Reportes\reporteMaterialEnviadosPeriodo.rdlc"
        End Select


    End Sub


    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim f1 As Date
        Dim f2 As Date
        f1 = dtpFechaInicio.Text
        f2 = dtpFechaFinal.Text

        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = conexion
        Adaptador.SelectCommand.CommandText = consulta
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim param1 = New SqlParameter("@FI", SqlDbType.Date)
        Dim param2 = New SqlParameter("@FF", SqlDbType.Date)

        param1.Direction = ParameterDirection.Input
        param2.Direction = ParameterDirection.Input

        param1.Value = f1
        param2.Value = f2

        Adaptador.SelectCommand.Parameters.Add(param1)
        Adaptador.SelectCommand.Parameters.Add(param2)

        Dim Data As New DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource(consulta, Data.Tables(0))
        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)

        Dim p1 As New ReportParameter("FI", f1)
        Dim p2 As New ReportParameter("FF", f2)

        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        frmReportes.ReportViewer1.LocalReport.ReportPath = reporte
        frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.Show()
        conexion.Close()
    End Sub
End Class