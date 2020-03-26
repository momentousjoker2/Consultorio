Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If WindowState = FormWindowState.Normal Then
            maximizar.Visible = True
            Restaurar.Visible = False
        Else
            maximizar.Visible = False
            Restaurar.Visible = True
        End If
        hideSubMenu()

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

    Private Sub btnCatalagos_Click(sender As Object, e As EventArgs) Handles btnCatalagos.Click
        showSubMenu(PanelMenuCatalagos)
    End Sub

    Private Sub btMovimientos_Click(sender As Object, e As EventArgs) Handles btMovimientos.Click
        showSubMenu(PanelMenuMovimientos)
    End Sub
    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        showSubMenu(panelMenuReporte)
    End Sub
    Private Sub btnEnvioMaterial_Click(sender As Object, e As EventArgs) Handles btnEnvioMaterial.Click
        Openform(frmEnvioMaterial, btnEnvioMaterial)
    End Sub

    Private Sub btMateriales_Click(sender As Object, e As EventArgs) Handles btMateriales.Click
        Openform(frmMaterial, btMateriales)
    End Sub

    Private Sub btnCitas_Click(sender As Object, e As EventArgs) Handles btnCitas.Click
        Openform(frmCita, btnCitas)
    End Sub
    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        Openform(frmHistorial, btnHistorial)
    End Sub

    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        Openform(frmPago, btnPagos)
    End Sub

    Private Sub btPacientes_Click(sender As Object, e As EventArgs) Handles btPacientes.Click
        Openform(frmPaciente, btPacientes)
    End Sub


    Private currentForm As Form = Nothing
    Private Sub Openform(frmHijo As Form, btn As FontAwesome.Sharp.IconButton)

        If currentForm IsNot Nothing Then currentForm.Close()
        If frmHijo.Tag Is panelCentral.Tag Then
            btn.Enabled = False
        Else
            btn.Enabled = True
        End If
        currentForm = frmHijo
        currentForm.TopLevel = False
        currentForm.FormBorderStyle = FormBorderStyle.None
        currentForm.Dock = DockStyle.Fill
        panelCentral.Controls.Add(currentForm)
        panelCentral.Tag = currentForm
        currentForm.Show()
    End Sub

    Private Sub hideSubMenu()
        PanelMenuCatalagos.Visible = False
        PanelMenuMovimientos.Visible = False
    End Sub
    Private Sub showSubMenu(subMenu As Panel)
        If subMenu.Visible Then
            hideSubMenu()
            subMenu.Visible = False
        Else
            subMenu.Visible = True
        End If
    End Sub


End Class
