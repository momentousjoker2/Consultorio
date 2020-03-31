<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorial
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIdHistorial = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboCita = New System.Windows.Forms.ComboBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSesion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOcupacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtPlan = New System.Windows.Forms.TextBox()
        Me.txtAnalisis = New System.Windows.Forms.TextBox()
        Me.txtObjetivo = New System.Windows.Forms.TextBox()
        Me.txtSubjetivo = New System.Windows.Forms.TextBox()
        Me.txtActividad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "idHistorial"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIdHistorial)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 60)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtIdHistorial
        '
        Me.txtIdHistorial.Enabled = False
        Me.txtIdHistorial.Location = New System.Drawing.Point(135, 26)
        Me.txtIdHistorial.Name = "txtIdHistorial"
        Me.txtIdHistorial.Size = New System.Drawing.Size(147, 22)
        Me.txtIdHistorial.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboCita)
        Me.GroupBox2.Controls.Add(Me.txtEstado)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 55)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(296, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Estado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Cita"
        '
        'cboCita
        '
        Me.cboCita.Enabled = False
        Me.cboCita.FormattingEnabled = True
        Me.cboCita.Location = New System.Drawing.Point(47, 19)
        Me.cboCita.Name = "cboCita"
        Me.cboCita.Size = New System.Drawing.Size(235, 24)
        Me.cboCita.TabIndex = 3
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(365, 19)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(139, 22)
        Me.txtEstado.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSesion)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtOcupacion)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtDomicilio)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtSexo)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtNombre)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(518, 118)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'txtSesion
        '
        Me.txtSesion.Enabled = False
        Me.txtSesion.Location = New System.Drawing.Point(226, 21)
        Me.txtSesion.Name = "txtSesion"
        Me.txtSesion.Size = New System.Drawing.Size(158, 22)
        Me.txtSesion.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(157, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Sesion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(264, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Ocupacion"
        '
        'txtOcupacion
        '
        Me.txtOcupacion.Enabled = False
        Me.txtOcupacion.Location = New System.Drawing.Point(346, 83)
        Me.txtOcupacion.Name = "txtOcupacion"
        Me.txtOcupacion.Size = New System.Drawing.Size(158, 22)
        Me.txtOcupacion.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Sexo"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Enabled = False
        Me.txtDomicilio.Location = New System.Drawing.Point(75, 81)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(174, 22)
        Me.txtDomicilio.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 12
        '
        'txtSexo
        '
        Me.txtSexo.Enabled = False
        Me.txtSexo.Location = New System.Drawing.Point(345, 50)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(158, 22)
        Me.txtSexo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Domicilio"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(76, 49)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(173, 22)
        Me.txtNombre.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Paciente"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtPlan)
        Me.GroupBox4.Controls.Add(Me.txtAnalisis)
        Me.GroupBox4.Controls.Add(Me.txtObjetivo)
        Me.GroupBox4.Controls.Add(Me.txtSubjetivo)
        Me.GroupBox4.Controls.Add(Me.txtActividad)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 263)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(518, 327)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'txtPlan
        '
        Me.txtPlan.Enabled = False
        Me.txtPlan.Location = New System.Drawing.Point(123, 252)
        Me.txtPlan.MaxLength = 255
        Me.txtPlan.Multiline = True
        Me.txtPlan.Name = "txtPlan"
        Me.txtPlan.Size = New System.Drawing.Size(381, 60)
        Me.txtPlan.TabIndex = 9
        '
        'txtAnalisis
        '
        Me.txtAnalisis.Enabled = False
        Me.txtAnalisis.Location = New System.Drawing.Point(123, 187)
        Me.txtAnalisis.MaxLength = 255
        Me.txtAnalisis.Multiline = True
        Me.txtAnalisis.Name = "txtAnalisis"
        Me.txtAnalisis.Size = New System.Drawing.Size(381, 59)
        Me.txtAnalisis.TabIndex = 8
        '
        'txtObjetivo
        '
        Me.txtObjetivo.Enabled = False
        Me.txtObjetivo.Location = New System.Drawing.Point(123, 122)
        Me.txtObjetivo.MaxLength = 255
        Me.txtObjetivo.Multiline = True
        Me.txtObjetivo.Name = "txtObjetivo"
        Me.txtObjetivo.Size = New System.Drawing.Size(381, 59)
        Me.txtObjetivo.TabIndex = 7
        '
        'txtSubjetivo
        '
        Me.txtSubjetivo.Enabled = False
        Me.txtSubjetivo.Location = New System.Drawing.Point(123, 57)
        Me.txtSubjetivo.MaxLength = 255
        Me.txtSubjetivo.Multiline = True
        Me.txtSubjetivo.Name = "txtSubjetivo"
        Me.txtSubjetivo.Size = New System.Drawing.Size(381, 59)
        Me.txtSubjetivo.TabIndex = 6
        '
        'txtActividad
        '
        Me.txtActividad.Enabled = False
        Me.txtActividad.Location = New System.Drawing.Point(123, 13)
        Me.txtActividad.MaxLength = 255
        Me.txtActividad.Multiline = True
        Me.txtActividad.Name = "txtActividad"
        Me.txtActividad.Size = New System.Drawing.Size(381, 38)
        Me.txtActividad.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 252)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 17)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Plan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 17)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Analisis"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 17)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Objetivo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Subjetivo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Actividad"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnCancelar)
        Me.GroupBox5.Controls.Add(Me.btnGuardar)
        Me.GroupBox5.Controls.Add(Me.btnNew)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 596)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(518, 52)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(428, 21)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(346, 21)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(265, 21)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "Nuevo"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'frmHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 671)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmHistorial"
        Me.Text = "frmHistorial"
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

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIdHistorial As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboCita As ComboBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtOcupacion As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSesion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtPlan As TextBox
    Friend WithEvents txtAnalisis As TextBox
    Friend WithEvents txtObjetivo As TextBox
    Friend WithEvents txtSubjetivo As TextBox
    Friend WithEvents txtActividad As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNew As Button
End Class
