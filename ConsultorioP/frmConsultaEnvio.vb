
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
                frmPaciente.Visible = True
            Case 2
                frmPaciente.Visible = False
            Case 3

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

        comando.CommandText = "Select e.id,h.sesion, h.actividad , m.titulo, m.material from EnvioMaterial as E Join Historial as h on h.id= e.idHistorial Join Material as m on e.idMaterial=m.id Join Cita as c on h.idCita=c.id where c.idPaciente=" & idPaciente
        lector = comando.ExecuteReader()
        dtgPaciente.Rows.Clear()

        While lector.Read()
            dtgPaciente.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub
End Class