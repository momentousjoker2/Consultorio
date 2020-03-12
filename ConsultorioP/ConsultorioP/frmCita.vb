Imports System.Data.SqlClient
Public Class frmCita
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Consultorio;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim transaction As SqlTransaction
    Dim idPaciente As Integer
    Dim sql As String
    Dim Fecha As String

    Private Sub frmCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "Select nombre From Paciente"
        lector = comando.ExecuteReader()

        While lector.Read()
            cbPaciente.Items.Add(lector(0))
        End While
        lector.Close()

        dtpFecha.MinDate = Date.Now

    End Sub

    Private Sub cbPaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaciente.SelectedIndexChanged
        sql = "Select * From Paciente where nombre='" & cbPaciente.Text & "'"
        comando.CommandText = sql
        lector = comando.ExecuteReader()
        lector.Read()
        idPaciente = lector("id")
        txtSexo.Text = lector("sexo")
        txtDomicilio.Text = lector("domicilio")
        txtTelefono.Text = lector("telefono")
        txtCorreo.Text = lector("email")
        lector.Close()
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged

        cbHoraD.Items.Clear()
        cbHoraD.Items.Add(Convert.ToDateTime("10:00").TimeOfDay)
        cbHoraD.Items.Add(Convert.ToDateTime("11:00").TimeOfDay)
        cbHoraD.Items.Add(Convert.ToDateTime("12:00").TimeOfDay)
        cbHoraD.Items.Add(Convert.ToDateTime("13:00").TimeOfDay)
        cbHoraD.Items.Add(Convert.ToDateTime("14:00").TimeOfDay)
        cbHoraD.Items.Add(Convert.ToDateTime("15:00").TimeOfDay)
        cbHoraD.Items.Add(Convert.ToDateTime("16:00").TimeOfDay)
        cbHoraD.Items.Add(Convert.ToDateTime("17:00").TimeOfDay)
        cbHoraD.Items.Add(Convert.ToDateTime("18:00").TimeOfDay)
        cbHoraD.Items.Add(Convert.ToDateTime("19:00").TimeOfDay)
        dgv.Rows.Clear()
        Fecha = dtpFecha.Text
        sql = "Select c.id as 'Numero de cita',p.nombre as 'Paciente', c.horaInicio as 'Hora',c.edo as 'Estado'  From cita as c INNER JOIN paciente as p on p.id = c.idPaciente  where c.fecha='" & CDate(Fecha&) & "'  order by c.horaInicio "
        comando.CommandText = sql
        lector = comando.ExecuteReader()
        While lector.Read()
            dgv.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            If lector(3) = "Registrada" Then
                cbHoraD.Items.Remove(lector(2))
            End If
        End While
        lector.Close()
        cbHoraD.SelectedIndex = 0
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        cbPaciente.Enabled = True
        dtpFecha.Enabled = True
        cbHoraD.Enabled = True
        Dim R = "Select count(*) From Cita"
        comando.CommandText = R
        txtIdCita.Text = CStr(comando.ExecuteScalar())

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim command As SqlCommand = conexion.CreateCommand
        Dim transaction As SqlTransaction
        Dim horaC As DateTime = Convert.ToDateTime(cbHoraD.Text.ToString)

        transaction = conexion.BeginTransaction("SimpleTransaction")
        command.Connection = conexion
        command.Transaction = transaction
        Try
            command.CommandText = "insert into Cita (id,idPaciente,fecha,horaInicio,edo) VALUES (" & txtIdCita.Text & "," & idPaciente & ",'" & CDate(Fecha) & "','" & horaC.TimeOfDay.ToString & "','Registrada')"
            command.ExecuteNonQuery()
            If MsgBox("desea ejecutar transaccion", MsgBoxStyle.YesNo, "Ejecutar") = MsgBoxResult.Yes Then
                transaction.Commit()
                dtpFecha.Text = Date.Now
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

        cbPaciente.Enabled = False
        dtpFecha.Enabled = False
        cbHoraD.Enabled = False

    End Sub
End Class