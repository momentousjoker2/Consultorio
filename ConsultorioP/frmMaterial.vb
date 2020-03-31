Imports System.Data.SqlClient

Public Class frmMaterial
    Private Sub frmMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlDataAdapter1.Fill(DataSet11.Material)
    End Sub
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        MaterialBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        MaterialBindingSource.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        MaterialBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        MaterialBindingSource.MoveLast()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtTitulo.Enabled = True
        txtMaterial.Enabled = True
        btnBuscar.Enabled = True
        cbTipo.Enabled = True
        MaterialBindingSource.AddNew()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        MaterialBindingSource.Current("tipo") = cbTipo.Text
        txtTitulo.Enabled = False
        txtMaterial.Enabled = False
        btnBuscar.Enabled = False
        cbTipo.Enabled = False

        MaterialBindingSource.EndEdit()
        SqlDataAdapter1.Update(DataSet11.Material)
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.Material)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtTitulo.Enabled = True
        txtMaterial.Enabled = True
        btnBuscar.Enabled = True
        cbTipo.Enabled = True

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf &
                          e.Row.Item("descripcion", DataRowVersion.Original) & vbCrLf &
                         e.Row.Item("descripcion", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtMaterial.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged
        '156, 22 originaal con boton
        '237, 22 sin boton
        '152, 101
        If cbTipo.Text = "Archvios" Then
            ''txtMaterial.SetBounds(114, 82, 118, 19)
            btnBuscar.Visible = True
        Else
            ''txtMaterial.SetBounds(114, 82, 237, 86)
            btnBuscar.Visible = False
        End If
        MsgBox(" x " & txtMaterial.Bounds.X)
        MsgBox(" y " & txtMaterial.Bounds.Y)
        MsgBox(" Width " & txtMaterial.Bounds.Width)
        MsgBox(" Height " & txtMaterial.Bounds.Height)

    End Sub
End Class