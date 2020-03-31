Imports System.Data.SqlClient

Public Class frmPaciente

    Private Sub frmPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlDataAdapter1.Fill(DataSet11.Paciente)
    End Sub
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        PacienteBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        PacienteBindingSource.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        PacienteBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        PacienteBindingSource.MoveLast()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Enabled = True
        txtDomicilio.Enabled = True
        cbSexo.Enabled = True
        txtEmail.Enabled = True
        dtpFechaNac.Enabled = True
        mtxtTelefono.Enabled = True
        txtOcupacion.Enabled = True
        PacienteBindingSource.AddNew()

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        txtNombre.Enabled = False
        txtDomicilio.Enabled = False
        cbSexo.Enabled = False
        txtEmail.Enabled = False
        dtpFechaNac.Enabled = False
        mtxtTelefono.Enabled = False
        txtOcupacion.Enabled = False
        PacienteBindingSource.EndEdit()

        SqlDataAdapter1.Update(DataSet11.Paciente)
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.Paciente)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtNombre.Enabled = True
        txtDomicilio.Enabled = True
        cbSexo.Enabled = True
        txtEmail.Enabled = True
        dtpFechaNac.Enabled = True
        mtxtTelefono.Enabled = True
        txtOcupacion.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf &
                                e.Row.Item("NOMBRE", DataRowVersion.Original) & vbCrLf &
                                e.Row.Item("NOMBRE", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub
End Class