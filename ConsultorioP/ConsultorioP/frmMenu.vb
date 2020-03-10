Public Class frmMenu
    Private Sub PacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteToolStripMenuItem.Click
        frmPaciente.ShowDialog()
    End Sub

    Private Sub MaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialToolStripMenuItem.Click
        frmMaterial.ShowDialog()
    End Sub

    Private Sub RegristarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegristarToolStripMenuItem.Click
        frmRegristarCita.ShowDialog()
    End Sub
End Class
