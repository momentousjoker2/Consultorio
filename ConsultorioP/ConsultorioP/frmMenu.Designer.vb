<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Restaurar = New System.Windows.Forms.PictureBox()
        Me.maximizar = New System.Windows.Forms.PictureBox()
        Me.Minimizar = New System.Windows.Forms.PictureBox()
        Me.salir = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.panelMenuReporte = New System.Windows.Forms.Panel()
        Me.btnHistorialPaciente = New FontAwesome.Sharp.IconButton()
        Me.btnListadoPaciente = New FontAwesome.Sharp.IconButton()
        Me.btnListadoMaterial = New FontAwesome.Sharp.IconButton()
        Me.btnPeriodo = New FontAwesome.Sharp.IconButton()
        Me.btnEstado = New FontAwesome.Sharp.IconButton()
        Me.btnPaciente = New FontAwesome.Sharp.IconButton()
        Me.btnMes = New FontAwesome.Sharp.IconButton()
        Me.btnSemana = New FontAwesome.Sharp.IconButton()
        Me.btnReporte = New FontAwesome.Sharp.IconButton()
        Me.PanelMenuMovimientos = New System.Windows.Forms.Panel()
        Me.btnEnvioMaterial = New FontAwesome.Sharp.IconButton()
        Me.btnPagos = New FontAwesome.Sharp.IconButton()
        Me.btnHistorial = New FontAwesome.Sharp.IconButton()
        Me.btnCitas = New FontAwesome.Sharp.IconButton()
        Me.btMovimientos = New FontAwesome.Sharp.IconButton()
        Me.PanelMenuCatalagos = New System.Windows.Forms.Panel()
        Me.btMateriales = New FontAwesome.Sharp.IconButton()
        Me.btPacientes = New FontAwesome.Sharp.IconButton()
        Me.btnCatalagos = New FontAwesome.Sharp.IconButton()
        Me.panelCentral = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnImprimirRecibo = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.panelMenuReporte.SuspendLayout()
        Me.PanelMenuMovimientos.SuspendLayout()
        Me.PanelMenuCatalagos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Restaurar)
        Me.Panel1.Controls.Add(Me.maximizar)
        Me.Panel1.Controls.Add(Me.Minimizar)
        Me.Panel1.Controls.Add(Me.salir)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1400, 116)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ConsultorioP.My.Resources.Resources.log
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Restaurar
        '
        Me.Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Restaurar.Image = Global.ConsultorioP.My.Resources.Resources.Restore_Window_2_48px
        Me.Restaurar.Location = New System.Drawing.Point(1310, 12)
        Me.Restaurar.Name = "Restaurar"
        Me.Restaurar.Size = New System.Drawing.Size(36, 29)
        Me.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Restaurar.TabIndex = 4
        Me.Restaurar.TabStop = False
        '
        'maximizar
        '
        Me.maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizar.Image = Global.ConsultorioP.My.Resources.Resources.Maximize_Window_2_48px
        Me.maximizar.Location = New System.Drawing.Point(1310, 12)
        Me.maximizar.Name = "maximizar"
        Me.maximizar.Size = New System.Drawing.Size(36, 29)
        Me.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.maximizar.TabIndex = 3
        Me.maximizar.TabStop = False
        '
        'Minimizar
        '
        Me.Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizar.Image = Global.ConsultorioP.My.Resources.Resources.Minimize_Window_2_48px
        Me.Minimizar.Location = New System.Drawing.Point(1268, 12)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.Size = New System.Drawing.Size(36, 29)
        Me.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Minimizar.TabIndex = 2
        Me.Minimizar.TabStop = False
        '
        'salir
        '
        Me.salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.salir.Image = Global.ConsultorioP.My.Resources.Resources.Close_Window__2_48px
        Me.salir.Location = New System.Drawing.Point(1352, 12)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(36, 29)
        Me.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.salir.TabIndex = 1
        Me.salir.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(307, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Principal"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BunifuGradientPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 116)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(307, 784)
        Me.Panel2.TabIndex = 1
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuGradientPanel1.AutoScroll = True
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.panelMenuReporte)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnReporte)
        Me.BunifuGradientPanel1.Controls.Add(Me.PanelMenuMovimientos)
        Me.BunifuGradientPanel1.Controls.Add(Me.btMovimientos)
        Me.BunifuGradientPanel1.Controls.Add(Me.PanelMenuCatalagos)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnCatalagos)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(16, 24)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(273, 766)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'panelMenuReporte
        '
        Me.panelMenuReporte.AutoSize = True
        Me.panelMenuReporte.BackColor = System.Drawing.Color.Transparent
        Me.panelMenuReporte.Controls.Add(Me.btnImprimirRecibo)
        Me.panelMenuReporte.Controls.Add(Me.btnHistorialPaciente)
        Me.panelMenuReporte.Controls.Add(Me.btnListadoPaciente)
        Me.panelMenuReporte.Controls.Add(Me.btnListadoMaterial)
        Me.panelMenuReporte.Controls.Add(Me.btnPeriodo)
        Me.panelMenuReporte.Controls.Add(Me.btnEstado)
        Me.panelMenuReporte.Controls.Add(Me.btnPaciente)
        Me.panelMenuReporte.Controls.Add(Me.btnMes)
        Me.panelMenuReporte.Controls.Add(Me.btnSemana)
        Me.panelMenuReporte.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMenuReporte.Location = New System.Drawing.Point(0, 462)
        Me.panelMenuReporte.Name = "panelMenuReporte"
        Me.panelMenuReporte.Size = New System.Drawing.Size(252, 450)
        Me.panelMenuReporte.TabIndex = 5
        '
        'btnHistorialPaciente
        '
        Me.btnHistorialPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHistorialPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHistorialPaciente.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnHistorialPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnHistorialPaciente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHistorialPaciente.IconChar = FontAwesome.Sharp.IconChar.Copy
        Me.btnHistorialPaciente.IconColor = System.Drawing.Color.White
        Me.btnHistorialPaciente.IconSize = 30
        Me.btnHistorialPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistorialPaciente.Location = New System.Drawing.Point(0, 350)
        Me.btnHistorialPaciente.Name = "btnHistorialPaciente"
        Me.btnHistorialPaciente.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnHistorialPaciente.Rotation = 0R
        Me.btnHistorialPaciente.Size = New System.Drawing.Size(252, 50)
        Me.btnHistorialPaciente.TabIndex = 7
        Me.btnHistorialPaciente.Text = "Historial Paciente"
        Me.btnHistorialPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHistorialPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistorialPaciente.UseVisualStyleBackColor = True
        '
        'btnListadoPaciente
        '
        Me.btnListadoPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListadoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnListadoPaciente.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnListadoPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnListadoPaciente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnListadoPaciente.IconChar = FontAwesome.Sharp.IconChar.Copy
        Me.btnListadoPaciente.IconColor = System.Drawing.Color.White
        Me.btnListadoPaciente.IconSize = 30
        Me.btnListadoPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListadoPaciente.Location = New System.Drawing.Point(0, 300)
        Me.btnListadoPaciente.Name = "btnListadoPaciente"
        Me.btnListadoPaciente.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnListadoPaciente.Rotation = 0R
        Me.btnListadoPaciente.Size = New System.Drawing.Size(252, 50)
        Me.btnListadoPaciente.TabIndex = 6
        Me.btnListadoPaciente.Text = "Listado de Paciente"
        Me.btnListadoPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListadoPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnListadoPaciente.UseVisualStyleBackColor = True
        '
        'btnListadoMaterial
        '
        Me.btnListadoMaterial.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListadoMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnListadoMaterial.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnListadoMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnListadoMaterial.ForeColor = System.Drawing.SystemColors.Control
        Me.btnListadoMaterial.IconChar = FontAwesome.Sharp.IconChar.Copy
        Me.btnListadoMaterial.IconColor = System.Drawing.Color.White
        Me.btnListadoMaterial.IconSize = 30
        Me.btnListadoMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListadoMaterial.Location = New System.Drawing.Point(0, 250)
        Me.btnListadoMaterial.Name = "btnListadoMaterial"
        Me.btnListadoMaterial.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnListadoMaterial.Rotation = 0R
        Me.btnListadoMaterial.Size = New System.Drawing.Size(252, 50)
        Me.btnListadoMaterial.TabIndex = 5
        Me.btnListadoMaterial.Text = "Listado de material"
        Me.btnListadoMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListadoMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnListadoMaterial.UseVisualStyleBackColor = True
        '
        'btnPeriodo
        '
        Me.btnPeriodo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPeriodo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnPeriodo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPeriodo.IconChar = FontAwesome.Sharp.IconChar.Copy
        Me.btnPeriodo.IconColor = System.Drawing.Color.White
        Me.btnPeriodo.IconSize = 30
        Me.btnPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPeriodo.Location = New System.Drawing.Point(0, 200)
        Me.btnPeriodo.Name = "btnPeriodo"
        Me.btnPeriodo.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnPeriodo.Rotation = 0R
        Me.btnPeriodo.Size = New System.Drawing.Size(252, 50)
        Me.btnPeriodo.TabIndex = 4
        Me.btnPeriodo.Text = "Citas por periodo"
        Me.btnPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPeriodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPeriodo.UseVisualStyleBackColor = True
        '
        'btnEstado
        '
        Me.btnEstado.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEstado.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnEstado.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEstado.IconChar = FontAwesome.Sharp.IconChar.Copy
        Me.btnEstado.IconColor = System.Drawing.Color.White
        Me.btnEstado.IconSize = 30
        Me.btnEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEstado.Location = New System.Drawing.Point(0, 150)
        Me.btnEstado.Name = "btnEstado"
        Me.btnEstado.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnEstado.Rotation = 0R
        Me.btnEstado.Size = New System.Drawing.Size(252, 50)
        Me.btnEstado.TabIndex = 3
        Me.btnEstado.Text = "Citas por estado"
        Me.btnEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEstado.UseVisualStyleBackColor = True
        '
        'btnPaciente
        '
        Me.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPaciente.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnPaciente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPaciente.IconChar = FontAwesome.Sharp.IconChar.Copy
        Me.btnPaciente.IconColor = System.Drawing.Color.White
        Me.btnPaciente.IconSize = 30
        Me.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaciente.Location = New System.Drawing.Point(0, 100)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnPaciente.Rotation = 0R
        Me.btnPaciente.Size = New System.Drawing.Size(252, 50)
        Me.btnPaciente.TabIndex = 2
        Me.btnPaciente.Text = "Citas por paciente"
        Me.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'btnMes
        '
        Me.btnMes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMes.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnMes.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMes.IconChar = FontAwesome.Sharp.IconChar.Copy
        Me.btnMes.IconColor = System.Drawing.Color.White
        Me.btnMes.IconSize = 30
        Me.btnMes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMes.Location = New System.Drawing.Point(0, 50)
        Me.btnMes.Name = "btnMes"
        Me.btnMes.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnMes.Rotation = 0R
        Me.btnMes.Size = New System.Drawing.Size(252, 50)
        Me.btnMes.TabIndex = 1
        Me.btnMes.Text = "Citas por Mes"
        Me.btnMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMes.UseVisualStyleBackColor = True
        '
        'btnSemana
        '
        Me.btnSemana.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSemana.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSemana.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnSemana.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSemana.IconChar = FontAwesome.Sharp.IconChar.Copy
        Me.btnSemana.IconColor = System.Drawing.Color.White
        Me.btnSemana.IconSize = 30
        Me.btnSemana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSemana.Location = New System.Drawing.Point(0, 0)
        Me.btnSemana.Name = "btnSemana"
        Me.btnSemana.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnSemana.Rotation = 0R
        Me.btnSemana.Size = New System.Drawing.Size(252, 50)
        Me.btnSemana.TabIndex = 0
        Me.btnSemana.Text = "Citas por semana"
        Me.btnSemana.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSemana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSemana.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.Color.Transparent
        Me.btnReporte.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReporte.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnReporte.IconChar = FontAwesome.Sharp.IconChar.Copy
        Me.btnReporte.IconColor = System.Drawing.Color.White
        Me.btnReporte.IconSize = 40
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.Location = New System.Drawing.Point(0, 406)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Rotation = 0R
        Me.btnReporte.Size = New System.Drawing.Size(252, 56)
        Me.btnReporte.TabIndex = 4
        Me.btnReporte.Text = "Reportes"
        Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'PanelMenuMovimientos
        '
        Me.PanelMenuMovimientos.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenuMovimientos.Controls.Add(Me.btnEnvioMaterial)
        Me.PanelMenuMovimientos.Controls.Add(Me.btnPagos)
        Me.PanelMenuMovimientos.Controls.Add(Me.btnHistorial)
        Me.PanelMenuMovimientos.Controls.Add(Me.btnCitas)
        Me.PanelMenuMovimientos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenuMovimientos.Location = New System.Drawing.Point(0, 212)
        Me.PanelMenuMovimientos.Name = "PanelMenuMovimientos"
        Me.PanelMenuMovimientos.Size = New System.Drawing.Size(252, 194)
        Me.PanelMenuMovimientos.TabIndex = 3
        Me.PanelMenuMovimientos.Visible = False
        '
        'btnEnvioMaterial
        '
        Me.btnEnvioMaterial.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnvioMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnvioMaterial.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEnvioMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnEnvioMaterial.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEnvioMaterial.IconChar = FontAwesome.Sharp.IconChar.Inbox
        Me.btnEnvioMaterial.IconColor = System.Drawing.Color.White
        Me.btnEnvioMaterial.IconSize = 30
        Me.btnEnvioMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnvioMaterial.Location = New System.Drawing.Point(0, 150)
        Me.btnEnvioMaterial.Name = "btnEnvioMaterial"
        Me.btnEnvioMaterial.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnEnvioMaterial.Rotation = 0R
        Me.btnEnvioMaterial.Size = New System.Drawing.Size(252, 50)
        Me.btnEnvioMaterial.TabIndex = 3
        Me.btnEnvioMaterial.Text = "Enviar Material"
        Me.btnEnvioMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnvioMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnvioMaterial.UseVisualStyleBackColor = True
        '
        'btnPagos
        '
        Me.btnPagos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnPagos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPagos.IconChar = FontAwesome.Sharp.IconChar.CreditCard
        Me.btnPagos.IconColor = System.Drawing.Color.White
        Me.btnPagos.IconSize = 30
        Me.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagos.Location = New System.Drawing.Point(0, 100)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnPagos.Rotation = 0R
        Me.btnPagos.Size = New System.Drawing.Size(252, 50)
        Me.btnPagos.TabIndex = 2
        Me.btnPagos.Text = "Pago"
        Me.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPagos.UseVisualStyleBackColor = True
        '
        'btnHistorial
        '
        Me.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHistorial.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnHistorial.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHistorial.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnHistorial.IconColor = System.Drawing.Color.White
        Me.btnHistorial.IconSize = 30
        Me.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistorial.Location = New System.Drawing.Point(0, 50)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnHistorial.Rotation = 0R
        Me.btnHistorial.Size = New System.Drawing.Size(252, 50)
        Me.btnHistorial.TabIndex = 1
        Me.btnHistorial.Text = "Historial"
        Me.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'btnCitas
        '
        Me.btnCitas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCitas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnCitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCitas.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCitas.IconChar = FontAwesome.Sharp.IconChar.Clock
        Me.btnCitas.IconColor = System.Drawing.Color.White
        Me.btnCitas.IconSize = 30
        Me.btnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCitas.Location = New System.Drawing.Point(0, 0)
        Me.btnCitas.Name = "btnCitas"
        Me.btnCitas.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnCitas.Rotation = 0R
        Me.btnCitas.Size = New System.Drawing.Size(252, 50)
        Me.btnCitas.TabIndex = 0
        Me.btnCitas.Text = "Citas"
        Me.btnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCitas.UseVisualStyleBackColor = True
        '
        'btMovimientos
        '
        Me.btMovimientos.BackColor = System.Drawing.Color.Transparent
        Me.btMovimientos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btMovimientos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btMovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMovimientos.ForeColor = System.Drawing.Color.AliceBlue
        Me.btMovimientos.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.btMovimientos.IconColor = System.Drawing.Color.White
        Me.btMovimientos.IconSize = 40
        Me.btMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btMovimientos.Location = New System.Drawing.Point(0, 156)
        Me.btMovimientos.Name = "btMovimientos"
        Me.btMovimientos.Rotation = 0R
        Me.btMovimientos.Size = New System.Drawing.Size(252, 56)
        Me.btMovimientos.TabIndex = 2
        Me.btMovimientos.Text = "Movimientos"
        Me.btMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btMovimientos.UseVisualStyleBackColor = False
        '
        'PanelMenuCatalagos
        '
        Me.PanelMenuCatalagos.AutoSize = True
        Me.PanelMenuCatalagos.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenuCatalagos.Controls.Add(Me.btMateriales)
        Me.PanelMenuCatalagos.Controls.Add(Me.btPacientes)
        Me.PanelMenuCatalagos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenuCatalagos.Location = New System.Drawing.Point(0, 56)
        Me.PanelMenuCatalagos.Name = "PanelMenuCatalagos"
        Me.PanelMenuCatalagos.Size = New System.Drawing.Size(252, 100)
        Me.PanelMenuCatalagos.TabIndex = 1
        Me.PanelMenuCatalagos.Visible = False
        '
        'btMateriales
        '
        Me.btMateriales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btMateriales.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btMateriales.ForeColor = System.Drawing.SystemColors.Control
        Me.btMateriales.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btMateriales.IconColor = System.Drawing.Color.White
        Me.btMateriales.IconSize = 30
        Me.btMateriales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btMateriales.Location = New System.Drawing.Point(0, 50)
        Me.btMateriales.Name = "btMateriales"
        Me.btMateriales.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btMateriales.Rotation = 0R
        Me.btMateriales.Size = New System.Drawing.Size(252, 50)
        Me.btMateriales.TabIndex = 1
        Me.btMateriales.Text = "Materiales"
        Me.btMateriales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btMateriales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btMateriales.UseVisualStyleBackColor = True
        '
        'btPacientes
        '
        Me.btPacientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btPacientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btPacientes.ForeColor = System.Drawing.SystemColors.Control
        Me.btPacientes.IconChar = FontAwesome.Sharp.IconChar.User
        Me.btPacientes.IconColor = System.Drawing.Color.White
        Me.btPacientes.IconSize = 30
        Me.btPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPacientes.Location = New System.Drawing.Point(0, 0)
        Me.btPacientes.Name = "btPacientes"
        Me.btPacientes.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btPacientes.Rotation = 0R
        Me.btPacientes.Size = New System.Drawing.Size(252, 50)
        Me.btPacientes.TabIndex = 0
        Me.btPacientes.Text = "Pacientes"
        Me.btPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPacientes.UseVisualStyleBackColor = True
        '
        'btnCatalagos
        '
        Me.btnCatalagos.BackColor = System.Drawing.Color.Transparent
        Me.btnCatalagos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCatalagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCatalagos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnCatalagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCatalagos.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCatalagos.IconChar = FontAwesome.Sharp.IconChar.ListAlt
        Me.btnCatalagos.IconColor = System.Drawing.Color.White
        Me.btnCatalagos.IconSize = 40
        Me.btnCatalagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCatalagos.Location = New System.Drawing.Point(0, 0)
        Me.btnCatalagos.Name = "btnCatalagos"
        Me.btnCatalagos.Rotation = 0R
        Me.btnCatalagos.Size = New System.Drawing.Size(252, 56)
        Me.btnCatalagos.TabIndex = 0
        Me.btnCatalagos.Text = "Catalagos"
        Me.btnCatalagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCatalagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCatalagos.UseVisualStyleBackColor = False
        '
        'panelCentral
        '
        Me.panelCentral.BackgroundImage = CType(resources.GetObject("panelCentral.BackgroundImage"), System.Drawing.Image)
        Me.panelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCentral.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelCentral.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.panelCentral.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.panelCentral.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.panelCentral.Location = New System.Drawing.Point(307, 116)
        Me.panelCentral.Name = "panelCentral"
        Me.panelCentral.Quality = 10
        Me.panelCentral.Size = New System.Drawing.Size(1093, 784)
        Me.panelCentral.TabIndex = 2
        '
        'btnImprimirRecibo
        '
        Me.btnImprimirRecibo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImprimirRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimirRecibo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnImprimirRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnImprimirRecibo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnImprimirRecibo.IconChar = FontAwesome.Sharp.IconChar.Copy
        Me.btnImprimirRecibo.IconColor = System.Drawing.Color.White
        Me.btnImprimirRecibo.IconSize = 30
        Me.btnImprimirRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimirRecibo.Location = New System.Drawing.Point(0, 400)
        Me.btnImprimirRecibo.Name = "btnImprimirRecibo"
        Me.btnImprimirRecibo.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnImprimirRecibo.Rotation = 0R
        Me.btnImprimirRecibo.Size = New System.Drawing.Size(252, 50)
        Me.btnImprimirRecibo.TabIndex = 8
        Me.btnImprimirRecibo.Text = "Imprimir Recibos"
        Me.btnImprimirRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimirRecibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimirRecibo.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 900)
        Me.Controls.Add(Me.panelCentral)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.panelMenuReporte.ResumeLayout(False)
        Me.PanelMenuMovimientos.ResumeLayout(False)
        Me.PanelMenuCatalagos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents salir As PictureBox
    Friend WithEvents Restaurar As PictureBox
    Friend WithEvents maximizar As PictureBox
    Friend WithEvents Minimizar As PictureBox
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PanelMenuCatalagos As Panel
    Friend WithEvents btMateriales As FontAwesome.Sharp.IconButton
    Friend WithEvents btPacientes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCatalagos As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btMovimientos As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelMenuMovimientos As Panel
    Friend WithEvents btnHistorial As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCitas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPagos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEnvioMaterial As FontAwesome.Sharp.IconButton
    Friend WithEvents panelCentral As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents panelMenuReporte As Panel
    Friend WithEvents btnHistorialPaciente As FontAwesome.Sharp.IconButton
    Friend WithEvents btnListadoPaciente As FontAwesome.Sharp.IconButton
    Friend WithEvents btnListadoMaterial As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPeriodo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEstado As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPaciente As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSemana As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReporte As FontAwesome.Sharp.IconButton
    Friend WithEvents btnImprimirRecibo As FontAwesome.Sharp.IconButton
End Class
