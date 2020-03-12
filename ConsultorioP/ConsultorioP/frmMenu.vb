Public Class frmMenu
    Private Sub PacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteToolStripMenuItem.Click
        frmPaciente.ShowDialog()
    End Sub

    Private Sub MaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialToolStripMenuItem.Click
        frmMaterial.ShowDialog()
    End Sub

    Private Sub HistorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialToolStripMenuItem.Click
        frmHistorial.ShowDialog()
    End Sub

    Private Sub CitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CitaToolStripMenuItem.Click
        frmRegristarCita.ShowDialog()
    End Sub
End Class
