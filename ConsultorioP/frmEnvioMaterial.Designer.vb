<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvioMaterial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNumEnvio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPaciente = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboSesion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtActividad = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.cboTitulo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNumEnvio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtNumEnvio
        '
        Me.txtNumEnvio.Enabled = False
        Me.txtNumEnvio.Location = New System.Drawing.Point(141, 15)
        Me.txtNumEnvio.Name = "txtNumEnvio"
        Me.txtNumEnvio.Size = New System.Drawing.Size(100, 22)
        Me.txtNumEnvio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de envio"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDomicilio)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.txtCorreo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cboPaciente)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(524, 92)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Enabled = False
        Me.txtDomicilio.Location = New System.Drawing.Point(349, 21)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(138, 22)
        Me.txtDomicilio.TabIndex = 9
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(349, 49)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(138, 22)
        Me.txtTelefono.TabIndex = 8
        '
        'txtCorreo
        '
        Me.txtCorreo.Enabled = False
        Me.txtCorreo.Location = New System.Drawing.Point(87, 49)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(186, 22)
        Me.txtCorreo.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(279, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Paciente"
        '
        'cboPaciente
        '
        Me.cboPaciente.Enabled = False
        Me.cboPaciente.FormattingEnabled = True
        Me.cboPaciente.Location = New System.Drawing.Point(87, 19)
        Me.cboPaciente.Name = "cboPaciente"
        Me.cboPaciente.Size = New System.Drawing.Size(186, 24)
        Me.cboPaciente.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboSesion)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtActividad)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 164)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(524, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'cboSesion
        '
        Me.cboSesion.Enabled = False
        Me.cboSesion.FormattingEnabled = True
        Me.cboSesion.Location = New System.Drawing.Point(87, 20)
        Me.cboSesion.Name = "cboSesion"
        Me.cboSesion.Size = New System.Drawing.Size(188, 24)
        Me.cboSesion.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Actividad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Sesion "
        '
        'txtActividad
        '
        Me.txtActividad.Enabled = False
        Me.txtActividad.Location = New System.Drawing.Point(87, 50)
        Me.txtActividad.Multiline = True
        Me.txtActividad.Name = "txtActividad"
        Me.txtActividad.Size = New System.Drawing.Size(431, 44)
        Me.txtActividad.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtTipo)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtMaterial)
        Me.GroupBox4.Controls.Add(Me.cboTitulo)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 270)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(524, 169)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Location = New System.Drawing.Point(87, 55)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(188, 22)
        Me.txtTipo.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tipo"
        '
        'txtMaterial
        '
        Me.txtMaterial.Enabled = False
        Me.txtMaterial.Location = New System.Drawing.Point(87, 90)
        Me.txtMaterial.Multiline = True
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(400, 63)
        Me.txtMaterial.TabIndex = 6
        '
        'cboTitulo
        '
        Me.cboTitulo.Enabled = False
        Me.cboTitulo.FormattingEnabled = True
        Me.cboTitulo.Location = New System.Drawing.Point(87, 25)
        Me.cboTitulo.Name = "cboTitulo"
        Me.cboTitulo.Size = New System.Drawing.Size(188, 24)
        Me.cboTitulo.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Material"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Titulo"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnNuevo)
        Me.GroupBox5.Controls.Add(Me.btnEnviar)
        Me.GroupBox5.Controls.Add(Me.btnCancelar)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 445)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(524, 59)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(250, 21)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Enabled = False
        Me.btnEnviar.Location = New System.Drawing.Point(331, 21)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 1
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(412, 21)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmEnvioMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 514)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEnvioMaterial"
        Me.Text = "frmEnvioMaterial"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNumEnvio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboPaciente As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboSesion As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtActividad As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents cboTitulo As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEnviar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTipo As TextBox
End Class
