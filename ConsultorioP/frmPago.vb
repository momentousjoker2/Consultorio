Imports System.Data.SqlClient
Public Class frmPago
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Consultorio;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim transaction As SqlTransaction
    Dim idPaciente
    Private Sub frmPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        lblFecha.Text = Date.Now
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim R = "Select count(*) From pago"
        comando.CommandText = R
        txtNumeroPago.Text = CStr(comando.ExecuteScalar() + 1)
        cboPaciente.Items.Clear()
        comando.CommandText = "Select * From Paciente "
        lector = comando.ExecuteReader()

        While lector.Read()
            cboPaciente.Items.Add(lector(0) & ") " & lector(1).ToString)
        End While
        lector.Close()
        cboPaciente.Enabled = True
    End Sub

    Private Sub cboPaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaciente.SelectedIndexChanged
        idPaciente = cboPaciente.Text.ToString.Substring(0, InStr(cboPaciente.Text.ToString, ")") - 1)

        comando.CommandText = "Select * From Paciente where id= " & idPaciente & ""
        lector = comando.ExecuteReader()
        lector.Read()
        txtCorreo.Text = lector("email")
        txtDomicilio.Text = lector("domicilio")
        txtTelefono.Text = lector("telefono")
        lector.Close()
        cboCita.Items.Clear()

        comando.CommandText = " select * from Cita where idPaciente =" & idPaciente & " and edo != 'Pagado' and edo='Atentido'"
        lector = comando.ExecuteReader()

        While lector.Read()
            Dim fechas = lector(2)
            Dim fecha = fechas.Day & "/" & fechas.Month & "/" & fechas.Year
            cboCita.Items.Add(lector(0) & ") " & fecha & " " & lector(3).ToString)
        End While
        lector.Close()
        cboCita.Enabled = True
    End Sub

    Private Sub cboCita_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCita.SelectedIndexChanged
        Dim idCita = cboCita.Text.ToString.Substring(0, InStr(cboPaciente.Text.ToString, ")") - 1)
        comando.CommandText = "Select * From Cita where edo='Atentido' and idPaciente= " & idPaciente & "and id=" & idCita
        lector = comando.ExecuteReader()
        lector.Read()
        txtEstado.Text = lector("edo")
        txtImporte.Enabled = True
        lector.Close()
        btnGuardar.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim idCita = cboCita.Text.ToString.Substring(0, InStr(cboCita.Text.ToString, ")") - 1)
        Dim fechas = Convert.ToDateTime(lblFecha.Text)
        Dim fecha = fechas.Day & "/" & fechas.Month & "/" & fechas.Year

        Dim transaction As SqlTransaction
        transaction = conexion.BeginTransaction("SimpleTransaction")
        comando.Connection = conexion
        comando.Transaction = transaction
        Try

            comando.CommandText = "insert into Pago values (" & txtNumeroPago.Text & " , " & idCita & ",'" & txtImporte.Text & "','" & lblFecha.Text & "')"
            comando.ExecuteNonQuery()
            comando.CommandText = "update Cita set edo = 'Pagado' where id=" & idCita
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
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
End Class