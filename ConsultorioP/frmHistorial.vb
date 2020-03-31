Imports System.Data.SqlClient
Public Class frmHistorial
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Consultorio;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim transaction As SqlTransaction
    Dim idPaciente

    Private Sub frmHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim R = "Select count(*) From Historial"
        comando.CommandText = R
        txtIdHistorial.Text = CStr(comando.ExecuteScalar() + 1)

        cboCita.Items.Clear()

        comando.CommandText = "Select * From Cita where edo='Registrada'"
        lector = comando.ExecuteReader()

        While lector.Read()
            Dim fechas = lector(2)
            Dim fecha = fechas.Day & "/" & fechas.Month & "/" & fechas.Year
            cboCita.Items.Add(lector(0) & ") " & fecha & " " & lector(3).ToString)
        End While
        lector.Close()
        cboCita.Enabled = True
        txtActividad.Enabled = True
        txtSubjetivo.Enabled = True
        txtObjetivo.Enabled = True
        txtAnalisis.Enabled = True
        txtPlan.Enabled = True
        btnNew.Enabled = False
        btnGuardar.Enabled = True
    End Sub

    Private Sub cboCita_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCita.SelectedIndexChanged
        Dim idCita = cboCita.Text.ToString.Substring(0, InStr(cboCita.Text.ToString, ")") - 1)
        comando.CommandText = "Select c.edo,p.nombre,p.ocupacion,p.sexo,p.domicilio,p.id From Cita As C Join Paciente As P  On C.idPaciente = P.id  where c.id=" & idCita

        lector = comando.ExecuteReader()
        lector.Read()
        txtEstado.Text = lector(0)
        txtNombre.Text = lector(1)
        txtOcupacion.Text = lector(2)
        txtSexo.Text = lector(3)
        txtDomicilio.Text = lector(4)
        idPaciente = lector(5)
        lector.Close()

        comando.CommandText = "Select count(*) From Cita Join Paciente on Cita.idPaciente=Paciente.id where Paciente.nombre='" & txtNombre.Text & "' and Cita.edo!='Registrada'"
        txtSesion.Text = CStr(comando.ExecuteScalar() + 1)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim idCita = cboCita.Text.ToString.Substring(0, InStr(cboCita.Text.ToString, ")") - 1)

        Dim transaction As SqlTransaction
        transaction = conexion.BeginTransaction("SimpleTransaction")
        comando.Connection = conexion
        comando.Transaction = transaction
        Try


            comando.CommandText = "insert into Historial values (" & txtIdHistorial.Text & " , " & idCita & "," & txtSesion.Text & ",'" & txtActividad.Text & "','" & txtSubjetivo.Text & "','" & txtObjetivo.Text & "','" & txtAnalisis.Text & "','" & txtPlan.Text & "')"
            comando.ExecuteNonQuery()
            comando.CommandText = "update Cita set edo = 'Atentido' where id=" & idCita
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
        cboCita.Items.Clear()
        cboCita.Enabled = False
        txtActividad.Enabled = False
        txtSubjetivo.Enabled = False
        txtObjetivo.Enabled = False
        txtAnalisis.Enabled = False
        txtPlan.Enabled = False
        btnNew.Enabled = True
        btnGuardar.Enabled = False
        txtActividad.Text = ""
        txtSubjetivo.Text = ""
        txtObjetivo.Text = ""
        txtAnalisis.Text = ""
        txtPlan.Text = ""

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
End Class