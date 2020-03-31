Imports System.Data.SqlClient
Public Class frmEnvioMaterial
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Consultorio;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim transaction As SqlTransaction
    Private Sub frmEnvioMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim R = "Select count(*) From EnvioMaterial"
        comando.CommandText = R
        txtNumEnvio.Text = CStr(comando.ExecuteScalar() + 1)
        cboPaciente.Items.Clear()

        comando.CommandText = "Select Paciente.* From Paciente inner join Cita on Cita.idPaciente=Paciente.id where Cita.edo='Atentido' or Cita.edo='Pagado'"
        lector = comando.ExecuteReader()

        While lector.Read()
            cboPaciente.Items.Add(lector(0) & ") " & lector(1).ToString)
        End While
        lector.Close()
        cboPaciente.Enabled = True
        btnNuevo.Enabled = False
        GroupBox3.Visible = True
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim idTitulo = cboTitulo.Text.ToString.Substring(0, InStr(cboPaciente.Text.ToString, ")") - 1)
        Dim idHistorial = cboSesion.Text.ToString.Substring(0, InStr(cboPaciente.Text.ToString, ")") - 1)

        Dim transaction As SqlTransaction
        transaction = conexion.BeginTransaction("SimpleTransaction")
        comando.Connection = conexion
        comando.Transaction = transaction
        Try
            comando.CommandText = "insert into EnvioMaterial values (" & txtNumEnvio.Text & " , " & idHistorial & "," & idTitulo & ")"
            comando.ExecuteNonQuery()
            If MsgBox("desea ejecutar transaccion", MsgBoxStyle.YesNo, "Ejecutar") = MsgBoxResult.Yes Then
                transaction.Commit()
            Else
                transaction.Rollback()
                MsgBox("Transaccion Cancelada")
            End If
        Catch ex As Exception
            MsgBox("Transaccion erronea")
            Try
                transaction.Rollback()
            Catch ex2 As Exception
                MsgBox("Error rollback")
            End Try

        End Try
        btnNuevo.Enabled = True
        btnEnviar.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub cboPaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaciente.SelectedIndexChanged
        Dim idPaciente = cboPaciente.Text.ToString.Substring(0, InStr(cboPaciente.Text.ToString, ")") - 1)

        comando.CommandText = "Select * From Paciente where id= " & idPaciente & ""
        lector = comando.ExecuteReader()
        lector.Read()
        txtCorreo.Text = lector("email")
        txtDomicilio.Text = lector("domicilio")
        txtTelefono.Text = lector("telefono")
        lector.Close()
        cboSesion.Items.Clear()

        comando.CommandText = " select Historial.id,Historial.sesion from Historial inner join Cita on Cita.id = Historial.idCita inner join Paciente on Cita.idPaciente = Paciente.id where Cita.idPaciente =" & idPaciente
        lector = comando.ExecuteReader()

        While lector.Read()
            cboSesion.Items.Add(lector(0) & ") Sesion " & lector(1).ToString)
        End While
        lector.Close()
        cboSesion.Enabled = True

    End Sub

    Private Sub cboSesion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSesion.SelectedIndexChanged
        Dim idHistorial = cboSesion.Text.ToString.Substring(0, InStr(cboPaciente.Text.ToString, ")") - 1)
        comando.CommandText = "Select Actividad From Historial where id= " & idHistorial & ""
        lector = comando.ExecuteReader()
        lector.Read()
        txtActividad.Text = lector(0)
        lector.Close()

        comando.CommandText = " select * from Material "
        lector = comando.ExecuteReader()

        While lector.Read()
            cboTitulo.Items.Add(lector(0) & ") " & lector(1).ToString)
        End While
        lector.Close()
        cboSesion.Enabled = True
        cboTitulo.Enabled = True
    End Sub

    Private Sub cboTitulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTitulo.SelectedIndexChanged
        Dim idTitulo = cboTitulo.Text.ToString.Substring(0, InStr(cboPaciente.Text.ToString, ")") - 1)
        comando.CommandText = "Select * From Material where id= " & idTitulo & ""
        lector = comando.ExecuteReader()
        lector.Read()
        txtMaterial.Text = lector(2)
        txtTipo.Text = lector(3)
        lector.Close()
        btnEnviar.Enabled = True
    End Sub

End Class