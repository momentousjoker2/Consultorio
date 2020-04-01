
Imports System.Data.SqlClient

Public Class frmConsultaEnvio
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Consultorio;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim idPaciente
    Sub New(opcion As Integer)
        conexion.Open()
        comando = conexion.CreateCommand
        ' This call is required by the designer.
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
<<<<<<< HEAD
                Panel4.Visible = False
=======
                panel3.visible = False
>>>>>>> master
            Case 2
                Panel2.Dock = DockStyle.Fill

                Panel1.Visible = False
                Panel2.Visible = True
<<<<<<< HEAD
                Panel4.Visible = False
=======
                panel3.visible = False
>>>>>>> master
            Case 3
                comando.CommandText = "Select DISTINCT  Paciente.* From Paciente inner join Cita on Cita.idPaciente=Paciente.id where Cita.edo='Atentido' or Cita.edo='Pagado'  "
                lector = comando.ExecuteReader()

                While lector.Read()
                    ComboBox1.Items.Add(lector(0) & ") " & lector(1).ToString)
                End While
                lector.Close()
<<<<<<< HEAD
                Panel4.Dock = DockStyle.Fill
                Panel1.Visible = False
                Panel2.Visible = False
                Panel4.Visible = True
=======
                Panel3.Dock = DockStyle.Fill
                Panel1.Visible = False
                Panel2.Visible = False
                panel3.visible = True
>>>>>>> master
        End Select
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmConsultaEnvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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

        comando.CommandText = "select m.titulo,m.material, m.tipo from Material as m inner join EnvioMaterial as e on e.idMaterial = m.id inner join Historial as h on e.idHistorial = h.id inner join Cita as c on h.idCita = c.id inner join Paciente as p on c.idPaciente = p.id where p.id=" & idPaciente
        lector = comando.ExecuteReader()
        dgv1.Rows.Clear()

        While lector.Read()
            dgv1.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()
    End Sub

<<<<<<< HEAD
    Private Sub Button1_Click(sender As Object, e As EventArgs)
=======
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
>>>>>>> master
        comando.CommandText = "select p.nombre,m.titulo,m.material, m.tipo from Material as m inner join EnvioMaterial as e on e.idMaterial = m.id inner join Historial as h on e.idHistorial = h.id inner join Cita as c on h.idCita = c.id inner join Paciente as p on c.idPaciente = p.id where  c.fecha   BETWEEN '" & dtpInicio.Text & "' and '" & dtpFinal.Text & "'"
        lector = comando.ExecuteReader()
        dgv2.Rows.Clear()

        While lector.Read()
            dgv2.Rows.Add(lector(0), lector(1), lector(2), lector(3))
        End While
        lector.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim idPaciente = ComboBox1.Text.ToString.Substring(0, InStr(ComboBox1.Text.ToString, ")") - 1)

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
        Dim idHistorial = cboSesion.Text.ToString.Substring(0, InStr(cboSesion.Text.ToString, ")") - 1)
        comando.CommandText = "select m.titulo,m.material, m.tipo from Material as m inner join EnvioMaterial as e on e.idMaterial = m.id inner join Historial as h on e.idHistorial = h.id inner join Cita as c on h.idCita = c.id inner join Paciente as p on c.idPaciente = p.id where h.id=" & idHistorial

        lector = comando.ExecuteReader()
        dgv3.Rows.Clear()

        While lector.Read()
            dgv3.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()

    End Sub

End Class