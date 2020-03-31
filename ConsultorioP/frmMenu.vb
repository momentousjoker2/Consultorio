Public Class frmMenu
    Public opcion As Integer
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        opcion = 1
        Openform(New frmConsultaEnvio(1))

    End Sub

    Private Sub btnEnvioPeriodo_Click(sender As Object, e As EventArgs) Handles btnEnvioPeriodo.Click
        opcion = 2
        Openform(New frmConsultaEnvio(0))
    End Sub

    Private Sub btnEnvioHistoriar_Click(sender As Object, e As EventArgs) Handles btnEnvioHistoriar.Click
        opcion = 3
        Openform(New frmConsultaEnvio(0))
    End Sub
End Class
