Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration

Public Class frmReportePaciente
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Consultorio;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim consulta As String
    Dim idPaciente As Integer
    Dim reporte As String
    Private Sub frmReportePaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "Select * From Paciente "
        lector = comando.ExecuteReader()

        While lector.Read()
            cboPaciente.Items.Add(lector(0) & ") " & lector(1).ToString)
        End While
        lector.Close()
    End Sub
    Sub New(opcion As Integer)

        InitializeComponent()



        Select Case opcion
            Case 1
                lblReporte.Text = "Reportes de envios de material por paciente"
                btnBuscar.Text = "Buscar Envios "
                consulta = "reporteMaterialEnviadoPaciente"
                reporte = "C:\Consultorio\ConsultorioP\Reportes\reporteEnvioMaterialPaciente.rdlc"
            Case 2
                lblReporte.Text = "Reporte de pagos por paciente"
                btnBuscar.Text = "Buscar pagos "
                consulta = "reportePagoPaciente"
                reporte = "C:\Consultorio\ConsultorioP\Reportes\reportePagoPaciente.rdlc"
            Case 3
                lblReporte.Text = "Reporte de citas por paciente"
                btnBuscar.Text = "Buscar citas"
                consulta = "reporteCitaPaciente"
                reporte = "C:\Consultorio\ConsultorioP\Reportes\reporteCitaPaciente.rdlc"
            Case 4
                lblReporte.Text = "Reporte de Historial de pacientes "
                btnBuscar.Text = "Buscar Historial de Paciente "
                consulta = "reporteHistorialPaciente"
                reporte = "C:\Consultorio\ConsultorioP\Reportes\reporteHistorialPaciente.rdlc"
        End Select
    End Sub
    Private Sub cboPaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaciente.SelectedIndexChanged
        idPaciente = cboPaciente.Text.ToString.Substring(0, InStr(cboPaciente.Text.ToString, ")") - 1)
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = conexion
        Adaptador.SelectCommand.CommandText = consulta
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@clave", SqlDbType.Int)
        param1.Direction = ParameterDirection.Input
        param1.Value = idPaciente
        Adaptador.SelectCommand.Parameters.Add(param1)
        Dim Data As New DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource(consulta, Data.Tables(0))
        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)

        Dim p1 As New ReportParameter("clave", idPaciente)

        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        frmReportes.ReportViewer1.LocalReport.ReportPath = reporte
        frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.Show()
        conexion.Close()
    End Sub


End Class