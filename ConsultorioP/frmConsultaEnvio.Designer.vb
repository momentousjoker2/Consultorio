<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaEnvio
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
        Me.frmPaciente = New System.Windows.Forms.Panel()
        Me.dtgPaciente = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.cboPaciente = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.frmPaciente.SuspendLayout()
        CType(Me.dtgPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'frmPaciente
        '
        Me.frmPaciente.BackColor = System.Drawing.Color.Transparent
        Me.frmPaciente.Controls.Add(Me.dtgPaciente)
        Me.frmPaciente.Controls.Add(Me.GroupBox2)
        Me.frmPaciente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmPaciente.Location = New System.Drawing.Point(0, 0)
        Me.frmPaciente.Name = "frmPaciente"
        Me.frmPaciente.Size = New System.Drawing.Size(828, 303)
        Me.frmPaciente.TabIndex = 0
        Me.frmPaciente.Visible = False
        '
        'dtgPaciente
        '
        Me.dtgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPaciente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6})
        Me.dtgPaciente.Location = New System.Drawing.Point(12, 118)
        Me.dtgPaciente.Name = "dtgPaciente"
        Me.dtgPaciente.RowHeadersWidth = 51
        Me.dtgPaciente.RowTemplate.Height = 24
        Me.dtgPaciente.Size = New System.Drawing.Size(811, 176)
        Me.dtgPaciente.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Numero de envio"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Sesion "
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Actividad"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Titulo de material"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Materiar"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.txtDomicilio)
        Me.GroupBox2.Controls.Add(Me.txtCorreo)
        Me.GroupBox2.Controls.Add(Me.cboPaciente)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(811, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(295, 43)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(150, 22)
        Me.txtTelefono.TabIndex = 7
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Enabled = False
        Me.txtDomicilio.Location = New System.Drawing.Point(295, 15)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(150, 22)
        Me.txtDomicilio.TabIndex = 6
        '
        'txtCorreo
        '
        Me.txtCorreo.Enabled = False
        Me.txtCorreo.Location = New System.Drawing.Point(75, 41)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(144, 22)
        Me.txtCorreo.TabIndex = 5
        '
        'cboPaciente
        '
        Me.cboPaciente.FormattingEnabled = True
        Me.cboPaciente.Location = New System.Drawing.Point(75, 11)
        Me.cboPaciente.Name = "cboPaciente"
        Me.cboPaciente.Size = New System.Drawing.Size(144, 24)
        Me.cboPaciente.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(225, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Correo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Paciente"
        '
        'frmConsultaEnvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 303)
        Me.Controls.Add(Me.frmPaciente)
        Me.Name = "frmConsultaEnvio"
        Me.Text = "frmConsultaEnvio"
        Me.frmPaciente.ResumeLayout(False)
        CType(Me.dtgPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents frmPaciente As Panel
    Friend WithEvents dtgPaciente As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents cboPaciente As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
