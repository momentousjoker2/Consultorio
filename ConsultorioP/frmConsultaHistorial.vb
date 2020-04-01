Imports System.Data.SqlClient
Public Class frmConsultaHistorial
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Consultorio;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Sub New(opcion As Integer)
        conexion.Open()
        comando = conexion.CreateCommand
        InitializeComponent()
        Select Case opcion
            Case 1
                comando.CommandText = "Select * From Paciente "
                lector = comando.ExecuteReader()

                While lector.Read()
                    cboPaciente.Items.Add(lector(0) & ") " & lector(1).ToString)
                End While
                lector.Close()
                Panel1.Dock = DockStyle.Fill
                Panel1.Visible = True
                Panel2.Visible = False
                Panel3.Visible = False
            Case 2
                Panel3.Dock = DockStyle.Fill
                Panel1.Visible = False
                Panel2.Visible = False
                Panel3.Visible = True
            Case 3
                Panel2.Dock = DockStyle.Fill

                Panel1.Visible = False
                Panel2.Visible = True
                Panel3.Visible = False
        End Select


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

        comando.CommandText = "select h.sesion,h.actividad,h.sugetivo,h.objetivo,h.analices,h.plantacion from Historial as h inner join Cita as c on h.idCita = c.id inner join Paciente as p on c.idPaciente = p.id  where p.id=" & idPaciente
        lector = comando.ExecuteReader()
        DataGridView1.Rows.Clear()

        While lector.Read()
            DataGridView1.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        comando.CommandText = "select p.nombre, h.sesion,h.actividad,h.sugetivo,h.objetivo,h.analices,h.plantacion,c.fecha from Historial as h inner join Cita as c on h.idCita = c.id inner join Paciente as p on c.idPaciente = p.id where  c.fecha   BETWEEN  '" & dtpInicio.Text & "' and '" & dtpFinal.Text & "'"
        lector = comando.ExecuteReader()
        DataGridView3.Rows.Clear()

        While lector.Read()
            DataGridView3.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
        End While
        lector.Close()
    End Sub
    Private Sub cboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstado.SelectedIndexChanged
        comando.CommandText = "select p.nombre, h.sesion,h.actividad,h.sugetivo,h.objetivo,h.analices,h.plantacion,c.fecha  from Historial as h inner join Cita as c on h.idCita = c.id inner join Paciente as p on c.idPaciente = p.id where c.edo='" & cboEstado.Text & "'"
        lector = comando.ExecuteReader()
        DataGridView2.Rows.Clear()

        While lector.Read()
            DataGridView2.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
        End While
        lector.Close()
    End Sub

End Class