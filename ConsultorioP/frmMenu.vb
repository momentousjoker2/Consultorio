Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration

Public Class frmMenu
    Dim Conexion As SqlConnection


    Public opcion As Integer
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
        Conexion.Open()

        If WindowState = FormWindowState.Normal Then
            maximizar.Visible = True
            Restaurar.Visible = False
        Else
            maximizar.Visible = False
            Restaurar.Visible = True
        End If
        hideMenu()

    End Sub


    Private Sub btnCatalagos_Click(sender As Object, e As EventArgs) Handles btnCatalagos.Click
        showSubMenu(PanelMenuCatalagos, "menu")

    End Sub

    Private Sub btMovimientos_Click(sender As Object, e As EventArgs) Handles btMovimientos.Click
        showSubMenu(PanelMenuMovimientos, "menu")
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        showSubMenu(panelMenuReporte, "menu")
    End Sub
    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        showSubMenu(panelHistoriar, "SubMenu")
    End Sub
    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        showSubMenu(panelPago, "SubMenu")
    End Sub

    Private Sub btnCitas_Click(sender As Object, e As EventArgs) Handles btnCitas.Click
        showSubMenu(panelCitas, "SubMenu")
    End Sub

    Private Sub btnEnvioMaterial_Click(sender As Object, e As EventArgs) Handles btnEnvioMaterial.Click
        showSubMenu(panelEnvioMaterial, "SubMenu")
    End Sub
    Private Sub btnAddHistorial_Click(sender As Object, e As EventArgs) Handles btnAddHistorial.Click
        Openform(frmHistorial)
    End Sub
    Private Sub btnaddPago_Click(sender As Object, e As EventArgs) Handles btnaddPago.Click
        Openform(frmPago)
    End Sub

    Private Sub btnAddCita_Click(sender As Object, e As EventArgs) Handles btnAddCita.Click
        Openform(frmCita)

    End Sub

    Private Sub btnAddEnvio_Click(sender As Object, e As EventArgs) Handles btnAddEnvio.Click
        Openform(frmEnvioMaterial)

    End Sub

    Private Sub hideMenu()
        PanelMenuCatalagos.Visible = False
        PanelMenuMovimientos.Visible = False
        panelMenuReporte.Visible = False

    End Sub
    Private Sub hideSubMenu()
        panelHistoriar.Visible = False
        panelPago.Visible = False
        panelCitas.Visible = False
        panelEnvioMaterial.Visible = False
    End Sub


    Private currentForm As Form = Nothing
    Private Sub Openform(frmHija As Form)
        currentForm = frmHija
        If Me.panelCentral.Controls.Count > 0 Then Me.panelCentral.Controls.RemoveAt(0)
        currentForm.TopLevel = False
        currentForm.FormBorderStyle = FormBorderStyle.None
        currentForm.Dock = DockStyle.Fill
        Me.panelCentral.Controls.Add(currentForm)
        Me.panelCentral.Tag = currentForm
        currentForm.Show()
    End Sub

    Private Sub showSubMenu(subMenu As Panel, subType As String)
        If subType.Equals("SubMenu") Then
            hideSubMenu()
        Else
            hideMenu()
        End If

        If subMenu.Visible Then
            subMenu.Visible = False
        Else
            subMenu.Visible = True
        End If
    End Sub
    Private Sub Restaurar_Click(sender As Object, e As EventArgs) Handles Restaurar.Click
        WindowState = FormWindowState.Normal
        maximizar.Visible = True
        Restaurar.Visible = False
    End Sub

    Private Sub maximizar_Click(sender As Object, e As EventArgs) Handles maximizar.Click
        WindowState = FormWindowState.Maximized
        maximizar.Visible = False
        Restaurar.Visible = True
    End Sub

    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Application.Exit()
    End Sub

    Private Sub btnEnvioPaciente_Click(sender As Object, e As EventArgs) Handles btnEnvioPaciente.Click
        Openform(New frmConsultaEnvio(1))

    End Sub

    Private Sub btnEnvioPeriodo_Click(sender As Object, e As EventArgs) Handles btnEnvioPeriodo.Click
        Openform(New frmConsultaEnvio(2))
    End Sub

    Private Sub btnEnvioHistoriar_Click(sender As Object, e As EventArgs) Handles btnEnvioHistoriar.Click
        Openform(New frmConsultaEnvio(3))
    End Sub

    Private Sub btnHistoriarPacientes_Click(sender As Object, e As EventArgs) Handles btnHistoriarPacientes.Click
        Openform(New frmConsultaHistorial(1))
    End Sub

    Private Sub btnHistoriarEstado_Click(sender As Object, e As EventArgs) Handles btnHistoriarEstado.Click
        Openform(New frmConsultaHistorial(3))
    End Sub

    Private Sub btnHistoriarPacientePeriodo_Click(sender As Object, e As EventArgs) Handles btnHistoriarPacientePeriodo.Click
        Openform(New frmConsultaHistorial(2))
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Openform(New frmConsultaPagos(2))
    End Sub

    Private Sub btnPagoPeriodo_Click(sender As Object, e As EventArgs) Handles btnPagoPeriodo.Click
        Openform(New frmConsultaPagos(3))

    End Sub

    Private Sub btnPagoPaciente_Click(sender As Object, e As EventArgs) Handles btnPagoPaciente.Click
        Openform(New frmConsultaPagos(1))

    End Sub

    Private Sub btnCitaPeriodo_Click(sender As Object, e As EventArgs) Handles btnCitaPeriodo.Click
        Openform(New frmConsultaCita(3))
    End Sub

    Private Sub btnCitaPaciente_Click(sender As Object, e As EventArgs) Handles btnCitaPaciente.Click
        Openform(New frmConsultaCita(1))
    End Sub

    Private Sub btnCitaEstado_Click(sender As Object, e As EventArgs) Handles btnCitaEstado.Click
        Openform(New frmConsultaCita(2))


    End Sub

    Private Sub btnReporteCita_Click(sender As Object, e As EventArgs) Handles btnReporteCita.Click
        Dim Cmd As New SqlCommand("reporteCita", Conexion)
        Cmd.CommandType = CommandType.StoredProcedure
        Dim Adaptador As New SqlDataAdapter(Cmd)
        Dim Data As New Data.DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "DataSet1"
        Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(Reportes)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Consultorio\ConsultorioP\Reportes\reporteCita.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        Openform(frmReportes)
        Conexion.Close()

    End Sub

    Private Sub btnReportePagos_Click(sender As Object, e As EventArgs) Handles btnReportePagos.Click
        Dim Cmd As New SqlCommand("reportePagos", Conexion)
        Cmd.CommandType = CommandType.StoredProcedure
        Dim Adaptador As New SqlDataAdapter(Cmd)
        Dim Data As New Data.DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "DataSet1"
        Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(Reportes)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Consultorio\ConsultorioP\Reportes\reportePagos.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        Openform(frmReportes)
        Conexion.Close()
    End Sub

    Private Sub btnReporteMaterialEnviado_Click(sender As Object, e As EventArgs) Handles btnReporteMaterialEnviado.Click
        Dim Cmd As New SqlCommand("reporteMaterialEnviado", Conexion)
        Cmd.CommandType = CommandType.StoredProcedure
        Dim Adaptador As New SqlDataAdapter(Cmd)
        Dim Data As New Data.DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "DataSet1"
        Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(Reportes)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Consultorio\ConsultorioP\Reportes\reporteMaterialEnviado.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        Openform(frmReportes)
        Conexion.Close()
    End Sub

    Private Sub btnReporteMaterialEnviadoPeriodo_Click(sender As Object, e As EventArgs) Handles btnReporteMaterialEnviadoPeriodo.Click
        Openform(New frmReportePeriodo(3))
    End Sub

    Private Sub btnReportePagosPeriodo_Click(sender As Object, e As EventArgs) Handles btnReportePagosPeriodo.Click
        Openform(New frmReportePeriodo(2))
    End Sub

    Private Sub btnReporteCitaPeriodo_Click(sender As Object, e As EventArgs) Handles btnReporteCitaPeriodo.Click
        Openform(New frmReportePeriodo(1))
    End Sub

    Private Sub btnReporteMaterialPaciente_Click(sender As Object, e As EventArgs) Handles btnReporteMaterialPaciente.Click
        Openform(New frmReportePaciente(1))
    End Sub

    Private Sub btnReportePagosPaciente_Click(sender As Object, e As EventArgs) Handles btnReportePagosPaciente.Click
        Openform(New frmReportePaciente(2))
    End Sub

    Private Sub btnReporteCitaPaciente_Click(sender As Object, e As EventArgs) Handles btnReporteCitaPaciente.Click
        Openform(New frmReportePaciente(3))
    End Sub

    Private Sub btnReporteHistoral_Click(sender As Object, e As EventArgs) Handles btnReporteHistoral.Click
        Openform(New frmReportePaciente(4))

    End Sub
End Class
