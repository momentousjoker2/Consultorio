<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegristarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarDeMaterialMultimediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalagoToolStripMenuItem, Me.MovimientosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatalagoToolStripMenuItem
        '
        Me.CatalagoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteToolStripMenuItem, Me.MaterialToolStripMenuItem})
        Me.CatalagoToolStripMenuItem.Name = "CatalagoToolStripMenuItem"
        Me.CatalagoToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.CatalagoToolStripMenuItem.Text = "Catalago"
        '
        'PacienteToolStripMenuItem
        '
        Me.PacienteToolStripMenuItem.Name = "PacienteToolStripMenuItem"
        Me.PacienteToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.PacienteToolStripMenuItem.Text = "Paciente"
        '
        'MaterialToolStripMenuItem
        '
        Me.MaterialToolStripMenuItem.Name = "MaterialToolStripMenuItem"
        Me.MaterialToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.MaterialToolStripMenuItem.Text = "Material"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CitaToolStripMenuItem, Me.HistorialToolStripMenuItem, Me.PagoToolStripMenuItem, Me.EnviarDeMaterialMultimediaToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(107, 24)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'CitaToolStripMenuItem
        '
        Me.CitaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegristarToolStripMenuItem, Me.CancelarToolStripMenuItem})
        Me.CitaToolStripMenuItem.Name = "CitaToolStripMenuItem"
        Me.CitaToolStripMenuItem.Size = New System.Drawing.Size(284, 26)
        Me.CitaToolStripMenuItem.Text = "Cita"
        '
        'RegristarToolStripMenuItem
        '
        Me.RegristarToolStripMenuItem.Name = "RegristarToolStripMenuItem"
        Me.RegristarToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.RegristarToolStripMenuItem.Text = "Regristar"
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'PagoToolStripMenuItem
        '
        Me.PagoToolStripMenuItem.Name = "PagoToolStripMenuItem"
        Me.PagoToolStripMenuItem.Size = New System.Drawing.Size(284, 26)
        Me.PagoToolStripMenuItem.Text = "Pago"
        '
        'HistorialToolStripMenuItem
        '
        Me.HistorialToolStripMenuItem.Name = "HistorialToolStripMenuItem"
        Me.HistorialToolStripMenuItem.Size = New System.Drawing.Size(284, 26)
        Me.HistorialToolStripMenuItem.Text = "Historial"
        '
        'EnviarDeMaterialMultimediaToolStripMenuItem
        '
        Me.EnviarDeMaterialMultimediaToolStripMenuItem.Name = "EnviarDeMaterialMultimediaToolStripMenuItem"
        Me.EnviarDeMaterialMultimediaToolStripMenuItem.Size = New System.Drawing.Size(284, 26)
        Me.EnviarDeMaterialMultimediaToolStripMenuItem.Text = "Enviar de material multimedia"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatalagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CitaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegristarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnviarDeMaterialMultimediaToolStripMenuItem As ToolStripMenuItem
End Class
