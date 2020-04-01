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
        Me.btnImprimirRecibo = New FontAwesome.Sharp.IconButton()
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnEnvioMaterial = New FontAwesome.Sharp.IconButton()
        Me.panelEnvioMaterial = New System.Windows.Forms.Panel()
        Me.btnEnvio = New System.Windows.Forms.Panel()
        Me.btnEnvioHistoriar = New FontAwesome.Sharp.IconButton()
        Me.btnEnvioPeriodo = New FontAwesome.Sharp.IconButton()
        Me.btnEnvioPaciente = New FontAwesome.Sharp.IconButton()
        Me.btnAddEnvio = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCitas = New FontAwesome.Sharp.IconButton()
        Me.panelCitas = New System.Windows.Forms.Panel()
        Me.btnCitaEstado = New FontAwesome.Sharp.IconButton()
        Me.btnCitaPeriodo = New FontAwesome.Sharp.IconButton()
        Me.btnCitaPaciente = New FontAwesome.Sharp.IconButton()
        Me.btnAddCita = New FontAwesome.Sharp.IconButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.panelPago = New System.Windows.Forms.Panel()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.btnPagoPeriodo = New FontAwesome.Sharp.IconButton()
        Me.btnPagoPaciente = New FontAwesome.Sharp.IconButton()
        Me.btnaddPago = New FontAwesome.Sharp.IconButton()
        Me.btnPagos = New FontAwesome.Sharp.IconButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnHistorial = New FontAwesome.Sharp.IconButton()
        Me.panelHistoriar = New System.Windows.Forms.Panel()
        Me.btnHistoriarEstado = New FontAwesome.Sharp.IconButton()
        Me.btnHistoriarPacientePeriodo = New FontAwesome.Sharp.IconButton()
        Me.btnHistoriarPacientes = New FontAwesome.Sharp.IconButton()
        Me.btnAddHistorial = New FontAwesome.Sharp.IconButton()
        Me.btMovimientos = New FontAwesome.Sharp.IconButton()
        Me.PanelMenuCatalagos = New System.Windows.Forms.Panel()
        Me.btMateriales = New FontAwesome.Sharp.IconButton()
        Me.btPacientes = New FontAwesome.Sharp.IconButton()
        Me.btnCatalagos = New FontAwesome.Sharp.IconButton()
        Me.panelCentral = New Bunifu.Framework.UI.BunifuGradientPanel()
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
        Me.Panel6.SuspendLayout()
        Me.panelEnvioMaterial.SuspendLayout()
        Me.btnEnvio.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panelCitas.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.panelPago.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.panelHistoriar.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(402, 784)
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
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(368, 766)
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
        Me.panelMenuReporte.Location = New System.Drawing.Point(0, 1235)
        Me.panelMenuReporte.Name = "panelMenuReporte"
        Me.panelMenuReporte.Size = New System.Drawing.Size(347, 450)
        Me.panelMenuReporte.TabIndex = 5
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
        Me.btnImprimirRecibo.Size = New System.Drawing.Size(347, 50)
        Me.btnImprimirRecibo.TabIndex = 8
        Me.btnImprimirRecibo.Text = "Imprimir Recibos"
        Me.btnImprimirRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimirRecibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimirRecibo.UseVisualStyleBackColor = True
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
        Me.btnHistorialPaciente.Size = New System.Drawing.Size(347, 50)
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
        Me.btnListadoPaciente.Size = New System.Drawing.Size(347, 50)
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
        Me.btnListadoMaterial.Size = New System.Drawing.Size(347, 50)
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
        Me.btnPeriodo.Size = New System.Drawing.Size(347, 50)
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
        Me.btnEstado.Size = New System.Drawing.Size(347, 50)
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
        Me.btnPaciente.Size = New System.Drawing.Size(347, 50)
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
        Me.btnMes.Size = New System.Drawing.Size(347, 50)
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
        Me.btnSemana.Size = New System.Drawing.Size(347, 50)
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
        Me.btnReporte.Location = New System.Drawing.Point(0, 1190)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Rotation = 0R
        Me.btnReporte.Size = New System.Drawing.Size(347, 45)
        Me.btnReporte.TabIndex = 4
        Me.btnReporte.Text = "Reportes"
        Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'PanelMenuMovimientos
        '
        Me.PanelMenuMovimientos.AutoSize = True
        Me.PanelMenuMovimientos.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenuMovimientos.Controls.Add(Me.Panel6)
        Me.PanelMenuMovimientos.Controls.Add(Me.Panel3)
        Me.PanelMenuMovimientos.Controls.Add(Me.Panel5)
        Me.PanelMenuMovimientos.Controls.Add(Me.Panel4)
        Me.PanelMenuMovimientos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenuMovimientos.Location = New System.Drawing.Point(0, 190)
        Me.PanelMenuMovimientos.Name = "PanelMenuMovimientos"
        Me.PanelMenuMovimientos.Size = New System.Drawing.Size(347, 1000)
        Me.PanelMenuMovimientos.TabIndex = 3
        Me.PanelMenuMovimientos.Visible = False
        '
        'Panel6
        '
        Me.Panel6.AutoSize = True
        Me.Panel6.Controls.Add(Me.btnEnvioMaterial)
        Me.Panel6.Controls.Add(Me.panelEnvioMaterial)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 750)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(347, 250)
        Me.Panel6.TabIndex = 12
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
        Me.btnEnvioMaterial.Location = New System.Drawing.Point(0, 0)
        Me.btnEnvioMaterial.Name = "btnEnvioMaterial"
        Me.btnEnvioMaterial.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnEnvioMaterial.Rotation = 0R
        Me.btnEnvioMaterial.Size = New System.Drawing.Size(347, 50)
        Me.btnEnvioMaterial.TabIndex = 3
        Me.btnEnvioMaterial.Text = "Enviar Material"
        Me.btnEnvioMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnvioMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnvioMaterial.UseVisualStyleBackColor = True
        '
        'panelEnvioMaterial
        '
        Me.panelEnvioMaterial.AutoSize = True
        Me.panelEnvioMaterial.Controls.Add(Me.btnEnvio)
        Me.panelEnvioMaterial.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelEnvioMaterial.Location = New System.Drawing.Point(0, 50)
        Me.panelEnvioMaterial.Name = "panelEnvioMaterial"
        Me.panelEnvioMaterial.Size = New System.Drawing.Size(347, 200)
        Me.panelEnvioMaterial.TabIndex = 11
        '
        'btnEnvio
        '
        Me.btnEnvio.AutoSize = True
        Me.btnEnvio.Controls.Add(Me.btnEnvioHistoriar)
        Me.btnEnvio.Controls.Add(Me.btnEnvioPeriodo)
        Me.btnEnvio.Controls.Add(Me.btnEnvioPaciente)
        Me.btnEnvio.Controls.Add(Me.btnAddEnvio)
        Me.btnEnvio.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnEnvio.Location = New System.Drawing.Point(0, 0)
        Me.btnEnvio.Name = "btnEnvio"
        Me.btnEnvio.Size = New System.Drawing.Size(347, 200)
        Me.btnEnvio.TabIndex = 8
        '
        'btnEnvioHistoriar
        '
        Me.btnEnvioHistoriar.AutoSize = True
        Me.btnEnvioHistoriar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnvioHistoriar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnvioHistoriar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEnvioHistoriar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnEnvioHistoriar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEnvioHistoriar.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnEnvioHistoriar.IconColor = System.Drawing.Color.White
        Me.btnEnvioHistoriar.IconSize = 30
        Me.btnEnvioHistoriar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnvioHistoriar.Location = New System.Drawing.Point(0, 150)
        Me.btnEnvioHistoriar.Name = "btnEnvioHistoriar"
        Me.btnEnvioHistoriar.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnEnvioHistoriar.Rotation = 0R
        Me.btnEnvioHistoriar.Size = New System.Drawing.Size(347, 50)
        Me.btnEnvioHistoriar.TabIndex = 5
        Me.btnEnvioHistoriar.Text = "Envio de materiar por Historiar"
        Me.btnEnvioHistoriar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnvioHistoriar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnvioHistoriar.UseVisualStyleBackColor = True
        '
        'btnEnvioPeriodo
        '
        Me.btnEnvioPeriodo.AutoSize = True
        Me.btnEnvioPeriodo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnvioPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnvioPeriodo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEnvioPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnEnvioPeriodo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEnvioPeriodo.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnEnvioPeriodo.IconColor = System.Drawing.Color.White
        Me.btnEnvioPeriodo.IconSize = 30
        Me.btnEnvioPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnvioPeriodo.Location = New System.Drawing.Point(0, 100)
        Me.btnEnvioPeriodo.Name = "btnEnvioPeriodo"
        Me.btnEnvioPeriodo.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnEnvioPeriodo.Rotation = 0R
        Me.btnEnvioPeriodo.Size = New System.Drawing.Size(347, 50)
        Me.btnEnvioPeriodo.TabIndex = 4
        Me.btnEnvioPeriodo.Text = "Envio de Materiar por periodo"
        Me.btnEnvioPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnvioPeriodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnvioPeriodo.UseVisualStyleBackColor = True
        '
        'btnEnvioPaciente
        '
        Me.btnEnvioPaciente.AutoSize = True
        Me.btnEnvioPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnvioPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnvioPaciente.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEnvioPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnEnvioPaciente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEnvioPaciente.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnEnvioPaciente.IconColor = System.Drawing.Color.White
        Me.btnEnvioPaciente.IconSize = 30
        Me.btnEnvioPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnvioPaciente.Location = New System.Drawing.Point(0, 50)
        Me.btnEnvioPaciente.Name = "btnEnvioPaciente"
        Me.btnEnvioPaciente.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnEnvioPaciente.Rotation = 0R
        Me.btnEnvioPaciente.Size = New System.Drawing.Size(347, 50)
        Me.btnEnvioPaciente.TabIndex = 3
        Me.btnEnvioPaciente.Text = "Envio de materiar por paciente"
        Me.btnEnvioPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnvioPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnvioPaciente.UseVisualStyleBackColor = True
        '
        'btnAddEnvio
        '
        Me.btnAddEnvio.AutoSize = True
        Me.btnAddEnvio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddEnvio.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAddEnvio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnAddEnvio.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAddEnvio.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnAddEnvio.IconColor = System.Drawing.Color.White
        Me.btnAddEnvio.IconSize = 30
        Me.btnAddEnvio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddEnvio.Location = New System.Drawing.Point(0, 0)
        Me.btnAddEnvio.Name = "btnAddEnvio"
        Me.btnAddEnvio.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnAddEnvio.Rotation = 0R
        Me.btnAddEnvio.Size = New System.Drawing.Size(347, 50)
        Me.btnAddEnvio.TabIndex = 2
        Me.btnAddEnvio.Text = "Agregar Envio de materiar"
        Me.btnAddEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddEnvio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddEnvio.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.Controls.Add(Me.btnCitas)
        Me.Panel3.Controls.Add(Me.panelCitas)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 500)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(347, 250)
        Me.Panel3.TabIndex = 9
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
        Me.btnCitas.Size = New System.Drawing.Size(347, 50)
        Me.btnCitas.TabIndex = 0
        Me.btnCitas.Text = "Citas"
        Me.btnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCitas.UseVisualStyleBackColor = True
        '
        'panelCitas
        '
        Me.panelCitas.AutoSize = True
        Me.panelCitas.Controls.Add(Me.btnCitaEstado)
        Me.panelCitas.Controls.Add(Me.btnCitaPeriodo)
        Me.panelCitas.Controls.Add(Me.btnCitaPaciente)
        Me.panelCitas.Controls.Add(Me.btnAddCita)
        Me.panelCitas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelCitas.Location = New System.Drawing.Point(0, 50)
        Me.panelCitas.Name = "panelCitas"
        Me.panelCitas.Size = New System.Drawing.Size(347, 200)
        Me.panelCitas.TabIndex = 0
        '
        'btnCitaEstado
        '
        Me.btnCitaEstado.AutoSize = True
        Me.btnCitaEstado.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCitaEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCitaEstado.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnCitaEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCitaEstado.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCitaEstado.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnCitaEstado.IconColor = System.Drawing.Color.White
        Me.btnCitaEstado.IconSize = 30
        Me.btnCitaEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCitaEstado.Location = New System.Drawing.Point(0, 150)
        Me.btnCitaEstado.Name = "btnCitaEstado"
        Me.btnCitaEstado.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnCitaEstado.Rotation = 0R
        Me.btnCitaEstado.Size = New System.Drawing.Size(347, 50)
        Me.btnCitaEstado.TabIndex = 5
        Me.btnCitaEstado.Text = "Citas por estado"
        Me.btnCitaEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCitaEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCitaEstado.UseVisualStyleBackColor = True
        '
        'btnCitaPeriodo
        '
        Me.btnCitaPeriodo.AutoSize = True
        Me.btnCitaPeriodo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCitaPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCitaPeriodo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnCitaPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCitaPeriodo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCitaPeriodo.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnCitaPeriodo.IconColor = System.Drawing.Color.White
        Me.btnCitaPeriodo.IconSize = 30
        Me.btnCitaPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCitaPeriodo.Location = New System.Drawing.Point(0, 100)
        Me.btnCitaPeriodo.Name = "btnCitaPeriodo"
        Me.btnCitaPeriodo.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnCitaPeriodo.Rotation = 0R
        Me.btnCitaPeriodo.Size = New System.Drawing.Size(347, 50)
        Me.btnCitaPeriodo.TabIndex = 4
        Me.btnCitaPeriodo.Text = "Cita por periodo"
        Me.btnCitaPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCitaPeriodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCitaPeriodo.UseVisualStyleBackColor = True
        '
        'btnCitaPaciente
        '
        Me.btnCitaPaciente.AutoSize = True
        Me.btnCitaPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCitaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCitaPaciente.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnCitaPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCitaPaciente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCitaPaciente.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnCitaPaciente.IconColor = System.Drawing.Color.White
        Me.btnCitaPaciente.IconSize = 30
        Me.btnCitaPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCitaPaciente.Location = New System.Drawing.Point(0, 50)
        Me.btnCitaPaciente.Name = "btnCitaPaciente"
        Me.btnCitaPaciente.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnCitaPaciente.Rotation = 0R
        Me.btnCitaPaciente.Size = New System.Drawing.Size(347, 50)
        Me.btnCitaPaciente.TabIndex = 3
        Me.btnCitaPaciente.Text = "citas por paciente"
        Me.btnCitaPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCitaPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCitaPaciente.UseVisualStyleBackColor = True
        '
        'btnAddCita
        '
        Me.btnAddCita.AutoSize = True
        Me.btnAddCita.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddCita.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddCita.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAddCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnAddCita.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAddCita.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnAddCita.IconColor = System.Drawing.Color.White
        Me.btnAddCita.IconSize = 30
        Me.btnAddCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddCita.Location = New System.Drawing.Point(0, 0)
        Me.btnAddCita.Name = "btnAddCita"
        Me.btnAddCita.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnAddCita.Rotation = 0R
        Me.btnAddCita.Size = New System.Drawing.Size(347, 50)
        Me.btnAddCita.TabIndex = 2
        Me.btnAddCita.Text = "Agregar Citas"
        Me.btnAddCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddCita.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.AutoSize = True
        Me.Panel5.Controls.Add(Me.panelPago)
        Me.Panel5.Controls.Add(Me.btnPagos)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 250)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(347, 250)
        Me.Panel5.TabIndex = 10
        '
        'panelPago
        '
        Me.panelPago.AutoSize = True
        Me.panelPago.Controls.Add(Me.IconButton5)
        Me.panelPago.Controls.Add(Me.btnPagoPeriodo)
        Me.panelPago.Controls.Add(Me.btnPagoPaciente)
        Me.panelPago.Controls.Add(Me.btnaddPago)
        Me.panelPago.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelPago.Location = New System.Drawing.Point(0, 50)
        Me.panelPago.Name = "panelPago"
        Me.panelPago.Size = New System.Drawing.Size(347, 200)
        Me.panelPago.TabIndex = 7
        '
        'IconButton5
        '
        Me.IconButton5.AutoSize = True
        Me.IconButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.IconButton5.ForeColor = System.Drawing.SystemColors.Control
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.IconButton5.IconColor = System.Drawing.Color.White
        Me.IconButton5.IconSize = 30
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.Location = New System.Drawing.Point(0, 150)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.IconButton5.Rotation = 0R
        Me.IconButton5.Size = New System.Drawing.Size(347, 50)
        Me.IconButton5.TabIndex = 5
        Me.IconButton5.Text = "pago por importe"
        Me.IconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton5.UseVisualStyleBackColor = True
        '
        'btnPagoPeriodo
        '
        Me.btnPagoPeriodo.AutoSize = True
        Me.btnPagoPeriodo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPagoPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagoPeriodo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnPagoPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnPagoPeriodo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPagoPeriodo.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnPagoPeriodo.IconColor = System.Drawing.Color.White
        Me.btnPagoPeriodo.IconSize = 30
        Me.btnPagoPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagoPeriodo.Location = New System.Drawing.Point(0, 100)
        Me.btnPagoPeriodo.Name = "btnPagoPeriodo"
        Me.btnPagoPeriodo.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnPagoPeriodo.Rotation = 0R
        Me.btnPagoPeriodo.Size = New System.Drawing.Size(347, 50)
        Me.btnPagoPeriodo.TabIndex = 4
        Me.btnPagoPeriodo.Text = "Pago por periodo"
        Me.btnPagoPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagoPeriodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPagoPeriodo.UseVisualStyleBackColor = True
        '
        'btnPagoPaciente
        '
        Me.btnPagoPaciente.AutoSize = True
        Me.btnPagoPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPagoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagoPaciente.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnPagoPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnPagoPaciente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPagoPaciente.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnPagoPaciente.IconColor = System.Drawing.Color.White
        Me.btnPagoPaciente.IconSize = 30
        Me.btnPagoPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagoPaciente.Location = New System.Drawing.Point(0, 50)
        Me.btnPagoPaciente.Name = "btnPagoPaciente"
        Me.btnPagoPaciente.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnPagoPaciente.Rotation = 0R
        Me.btnPagoPaciente.Size = New System.Drawing.Size(347, 50)
        Me.btnPagoPaciente.TabIndex = 3
        Me.btnPagoPaciente.Text = "Pago por paciente"
        Me.btnPagoPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagoPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPagoPaciente.UseVisualStyleBackColor = True
        '
        'btnaddPago
        '
        Me.btnaddPago.AutoSize = True
        Me.btnaddPago.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnaddPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnaddPago.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnaddPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnaddPago.ForeColor = System.Drawing.SystemColors.Control
        Me.btnaddPago.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnaddPago.IconColor = System.Drawing.Color.White
        Me.btnaddPago.IconSize = 30
        Me.btnaddPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddPago.Location = New System.Drawing.Point(0, 0)
        Me.btnaddPago.Name = "btnaddPago"
        Me.btnaddPago.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnaddPago.Rotation = 0R
        Me.btnaddPago.Size = New System.Drawing.Size(347, 50)
        Me.btnaddPago.TabIndex = 2
        Me.btnaddPago.Text = "Agregar Pago"
        Me.btnaddPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaddPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnaddPago.UseVisualStyleBackColor = True
        '
        'btnPagos
        '
        Me.btnPagos.AutoSize = True
        Me.btnPagos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnPagos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPagos.IconChar = FontAwesome.Sharp.IconChar.CreditCard
        Me.btnPagos.IconColor = System.Drawing.Color.White
        Me.btnPagos.IconSize = 30
        Me.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagos.Location = New System.Drawing.Point(0, 0)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnPagos.Rotation = 0R
        Me.btnPagos.Size = New System.Drawing.Size(347, 50)
        Me.btnPagos.TabIndex = 2
        Me.btnPagos.Text = "Pago"
        Me.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPagos.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.Controls.Add(Me.btnHistorial)
        Me.Panel4.Controls.Add(Me.panelHistoriar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(347, 250)
        Me.Panel4.TabIndex = 9
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
        Me.btnHistorial.Location = New System.Drawing.Point(0, 0)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnHistorial.Rotation = 0R
        Me.btnHistorial.Size = New System.Drawing.Size(347, 50)
        Me.btnHistorial.TabIndex = 1
        Me.btnHistorial.Text = "Historial"
        Me.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'panelHistoriar
        '
        Me.panelHistoriar.AutoSize = True
        Me.panelHistoriar.Controls.Add(Me.btnHistoriarEstado)
        Me.panelHistoriar.Controls.Add(Me.btnHistoriarPacientePeriodo)
        Me.panelHistoriar.Controls.Add(Me.btnHistoriarPacientes)
        Me.panelHistoriar.Controls.Add(Me.btnAddHistorial)
        Me.panelHistoriar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelHistoriar.Location = New System.Drawing.Point(0, 50)
        Me.panelHistoriar.Name = "panelHistoriar"
        Me.panelHistoriar.Size = New System.Drawing.Size(347, 200)
        Me.panelHistoriar.TabIndex = 6
        '
        'btnHistoriarEstado
        '
        Me.btnHistoriarEstado.AutoSize = True
        Me.btnHistoriarEstado.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHistoriarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHistoriarEstado.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnHistoriarEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnHistoriarEstado.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHistoriarEstado.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnHistoriarEstado.IconColor = System.Drawing.Color.White
        Me.btnHistoriarEstado.IconSize = 30
        Me.btnHistoriarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistoriarEstado.Location = New System.Drawing.Point(0, 150)
        Me.btnHistoriarEstado.Name = "btnHistoriarEstado"
        Me.btnHistoriarEstado.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnHistoriarEstado.Rotation = 0R
        Me.btnHistoriarEstado.Size = New System.Drawing.Size(347, 50)
        Me.btnHistoriarEstado.TabIndex = 5
        Me.btnHistoriarEstado.Text = "Historial por estados de cita"
        Me.btnHistoriarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHistoriarEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistoriarEstado.UseVisualStyleBackColor = True
        '
        'btnHistoriarPacientePeriodo
        '
        Me.btnHistoriarPacientePeriodo.AutoSize = True
        Me.btnHistoriarPacientePeriodo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHistoriarPacientePeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHistoriarPacientePeriodo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnHistoriarPacientePeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnHistoriarPacientePeriodo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHistoriarPacientePeriodo.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnHistoriarPacientePeriodo.IconColor = System.Drawing.Color.White
        Me.btnHistoriarPacientePeriodo.IconSize = 30
        Me.btnHistoriarPacientePeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistoriarPacientePeriodo.Location = New System.Drawing.Point(0, 100)
        Me.btnHistoriarPacientePeriodo.Name = "btnHistoriarPacientePeriodo"
        Me.btnHistoriarPacientePeriodo.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnHistoriarPacientePeriodo.Rotation = 0R
        Me.btnHistoriarPacientePeriodo.Size = New System.Drawing.Size(347, 50)
        Me.btnHistoriarPacientePeriodo.TabIndex = 4
        Me.btnHistoriarPacientePeriodo.Text = "Historiar de paciente por periodo"
        Me.btnHistoriarPacientePeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHistoriarPacientePeriodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistoriarPacientePeriodo.UseVisualStyleBackColor = True
        '
        'btnHistoriarPacientes
        '
        Me.btnHistoriarPacientes.AutoSize = True
        Me.btnHistoriarPacientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHistoriarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHistoriarPacientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnHistoriarPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnHistoriarPacientes.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHistoriarPacientes.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnHistoriarPacientes.IconColor = System.Drawing.Color.White
        Me.btnHistoriarPacientes.IconSize = 30
        Me.btnHistoriarPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistoriarPacientes.Location = New System.Drawing.Point(0, 50)
        Me.btnHistoriarPacientes.Name = "btnHistoriarPacientes"
        Me.btnHistoriarPacientes.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnHistoriarPacientes.Rotation = 0R
        Me.btnHistoriarPacientes.Size = New System.Drawing.Size(347, 50)
        Me.btnHistoriarPacientes.TabIndex = 3
        Me.btnHistoriarPacientes.Text = "Historiar por paciente"
        Me.btnHistoriarPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHistoriarPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistoriarPacientes.UseVisualStyleBackColor = True
        '
        'btnAddHistorial
        '
        Me.btnAddHistorial.AutoSize = True
        Me.btnAddHistorial.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddHistorial.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAddHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnAddHistorial.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAddHistorial.IconChar = FontAwesome.Sharp.IconChar.Folder
        Me.btnAddHistorial.IconColor = System.Drawing.Color.White
        Me.btnAddHistorial.IconSize = 30
        Me.btnAddHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddHistorial.Location = New System.Drawing.Point(0, 0)
        Me.btnAddHistorial.Name = "btnAddHistorial"
        Me.btnAddHistorial.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.btnAddHistorial.Rotation = 0R
        Me.btnAddHistorial.Size = New System.Drawing.Size(347, 50)
        Me.btnAddHistorial.TabIndex = 2
        Me.btnAddHistorial.Text = "Agregar Historiar"
        Me.btnAddHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddHistorial.UseVisualStyleBackColor = True
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
        Me.btMovimientos.Location = New System.Drawing.Point(0, 145)
        Me.btMovimientos.Name = "btMovimientos"
        Me.btMovimientos.Rotation = 0R
        Me.btMovimientos.Size = New System.Drawing.Size(347, 45)
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
        Me.PanelMenuCatalagos.Location = New System.Drawing.Point(0, 45)
        Me.PanelMenuCatalagos.Name = "PanelMenuCatalagos"
        Me.PanelMenuCatalagos.Size = New System.Drawing.Size(347, 100)
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
        Me.btMateriales.Size = New System.Drawing.Size(347, 50)
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
        Me.btPacientes.Size = New System.Drawing.Size(347, 50)
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
        Me.btnCatalagos.Size = New System.Drawing.Size(347, 45)
        Me.btnCatalagos.TabIndex = 0
        Me.btnCatalagos.Text = "Catalagos"
        Me.btnCatalagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCatalagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCatalagos.UseVisualStyleBackColor = False
        '
        'panelCentral
        '
        Me.panelCentral.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panelCentral.BackgroundImage = CType(resources.GetObject("panelCentral.BackgroundImage"), System.Drawing.Image)
        Me.panelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCentral.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelCentral.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.panelCentral.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.panelCentral.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.panelCentral.Location = New System.Drawing.Point(402, 116)
        Me.panelCentral.Name = "panelCentral"
        Me.panelCentral.Quality = 10
        Me.panelCentral.Size = New System.Drawing.Size(998, 784)
        Me.panelCentral.TabIndex = 2
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
        Me.PanelMenuMovimientos.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.panelEnvioMaterial.ResumeLayout(False)
        Me.panelEnvioMaterial.PerformLayout()
        Me.btnEnvio.ResumeLayout(False)
        Me.btnEnvio.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.panelCitas.ResumeLayout(False)
        Me.panelCitas.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.panelPago.ResumeLayout(False)
        Me.panelPago.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.panelHistoriar.ResumeLayout(False)
        Me.panelHistoriar.PerformLayout()
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
    Friend WithEvents panelCitas As Panel
    Friend WithEvents btnCitaEstado As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCitaPeriodo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCitaPaciente As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddCita As FontAwesome.Sharp.IconButton
    Friend WithEvents panelEnvioMaterial As Panel
    Friend WithEvents btnEnvio As Panel
    Friend WithEvents btnEnvioHistoriar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEnvioPeriodo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEnvioPaciente As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddEnvio As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents panelPago As Panel
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPagoPeriodo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPagoPaciente As FontAwesome.Sharp.IconButton
    Friend WithEvents btnaddPago As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panelHistoriar As Panel
    Friend WithEvents btnHistoriarPacientePeriodo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHistoriarPacientes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddHistorial As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnHistoriarEstado As FontAwesome.Sharp.IconButton
End Class
