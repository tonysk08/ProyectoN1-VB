<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarPelicula
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BienvenidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarPelículaYTandasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPelículasYTandasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerAsientosDisponiblesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerTotalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbSala1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnComprarTicketSala1 = New System.Windows.Forms.Button()
        Me.lbConsultarHorarioSala1 = New System.Windows.Forms.ListBox()
        Me.lblConsultarNombrePeliculaSala1 = New System.Windows.Forms.Label()
        Me.pbConsultarImagenPeliculaSala1 = New System.Windows.Forms.PictureBox()
        Me.gbSala2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnComprarTicketSala2 = New System.Windows.Forms.Button()
        Me.lbConsultarHorarioSala2 = New System.Windows.Forms.ListBox()
        Me.lblConsultarNombrePeliculaSala2 = New System.Windows.Forms.Label()
        Me.pbConsultarImagenPeliculaSala2 = New System.Windows.Forms.PictureBox()
        Me.gbSala3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnComprarTicketSala3 = New System.Windows.Forms.Button()
        Me.lbConsultarHorarioSala3 = New System.Windows.Forms.ListBox()
        Me.lblConsultarNombrePeliculaSala3 = New System.Windows.Forms.Label()
        Me.pbConsultarImagenPeliculaSala3 = New System.Windows.Forms.PictureBox()
        Me.gbSala4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnComprarTicketSala4 = New System.Windows.Forms.Button()
        Me.lbConsultarHorarioSala4 = New System.Windows.Forms.ListBox()
        Me.lblConsultarNombrePeliculaSala4 = New System.Windows.Forms.Label()
        Me.pbConsultarImagenPeliculaSala4 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.gbSala1.SuspendLayout()
        CType(Me.pbConsultarImagenPeliculaSala1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSala2.SuspendLayout()
        CType(Me.pbConsultarImagenPeliculaSala2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSala3.SuspendLayout()
        CType(Me.pbConsultarImagenPeliculaSala3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSala4.SuspendLayout()
        CType(Me.pbConsultarImagenPeliculaSala4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BienvenidaToolStripMenuItem, Me.IngresarPelículaYTandasToolStripMenuItem, Me.ConsultarPelículasYTandasToolStripMenuItem, Me.VerAsientosDisponiblesToolStripMenuItem, Me.VerTotalesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1070, 29)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BienvenidaToolStripMenuItem
        '
        Me.BienvenidaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BienvenidaToolStripMenuItem.Name = "BienvenidaToolStripMenuItem"
        Me.BienvenidaToolStripMenuItem.Size = New System.Drawing.Size(98, 25)
        Me.BienvenidaToolStripMenuItem.Text = "Bienvenida"
        '
        'IngresarPelículaYTandasToolStripMenuItem
        '
        Me.IngresarPelículaYTandasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.IngresarPelículaYTandasToolStripMenuItem.Name = "IngresarPelículaYTandasToolStripMenuItem"
        Me.IngresarPelículaYTandasToolStripMenuItem.Size = New System.Drawing.Size(205, 25)
        Me.IngresarPelículaYTandasToolStripMenuItem.Text = "Ingresar películas y tandas"
        '
        'ConsultarPelículasYTandasToolStripMenuItem
        '
        Me.ConsultarPelículasYTandasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ConsultarPelículasYTandasToolStripMenuItem.Name = "ConsultarPelículasYTandasToolStripMenuItem"
        Me.ConsultarPelículasYTandasToolStripMenuItem.Size = New System.Drawing.Size(215, 25)
        Me.ConsultarPelículasYTandasToolStripMenuItem.Text = "Consultar películas y tandas"
        '
        'VerAsientosDisponiblesToolStripMenuItem
        '
        Me.VerAsientosDisponiblesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.VerAsientosDisponiblesToolStripMenuItem.Name = "VerAsientosDisponiblesToolStripMenuItem"
        Me.VerAsientosDisponiblesToolStripMenuItem.Size = New System.Drawing.Size(189, 25)
        Me.VerAsientosDisponiblesToolStripMenuItem.Text = "Ver asientos disponibles"
        '
        'VerTotalesToolStripMenuItem
        '
        Me.VerTotalesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerTotalesToolStripMenuItem.Name = "VerTotalesToolStripMenuItem"
        Me.VerTotalesToolStripMenuItem.Size = New System.Drawing.Size(96, 25)
        Me.VerTotalesToolStripMenuItem.Text = "Ver Totales"
        '
        'gbSala1
        '
        Me.gbSala1.BackColor = System.Drawing.SystemColors.Control
        Me.gbSala1.Controls.Add(Me.Label1)
        Me.gbSala1.Controls.Add(Me.btnComprarTicketSala1)
        Me.gbSala1.Controls.Add(Me.lbConsultarHorarioSala1)
        Me.gbSala1.Controls.Add(Me.lblConsultarNombrePeliculaSala1)
        Me.gbSala1.Controls.Add(Me.pbConsultarImagenPeliculaSala1)
        Me.gbSala1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbSala1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSala1.Location = New System.Drawing.Point(12, 56)
        Me.gbSala1.Name = "gbSala1"
        Me.gbSala1.Size = New System.Drawing.Size(262, 565)
        Me.gbSala1.TabIndex = 13
        Me.gbSala1.TabStop = False
        Me.gbSala1.Text = "Sala 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Horario"
        '
        'btnComprarTicketSala1
        '
        Me.btnComprarTicketSala1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprarTicketSala1.Location = New System.Drawing.Point(64, 509)
        Me.btnComprarTicketSala1.Name = "btnComprarTicketSala1"
        Me.btnComprarTicketSala1.Size = New System.Drawing.Size(129, 35)
        Me.btnComprarTicketSala1.TabIndex = 3
        Me.btnComprarTicketSala1.Text = "Comprar ticket"
        Me.btnComprarTicketSala1.UseVisualStyleBackColor = True
        '
        'lbConsultarHorarioSala1
        '
        Me.lbConsultarHorarioSala1.FormattingEnabled = True
        Me.lbConsultarHorarioSala1.ItemHeight = 24
        Me.lbConsultarHorarioSala1.Location = New System.Drawing.Point(15, 417)
        Me.lbConsultarHorarioSala1.Name = "lbConsultarHorarioSala1"
        Me.lbConsultarHorarioSala1.Size = New System.Drawing.Size(229, 28)
        Me.lbConsultarHorarioSala1.TabIndex = 2
        '
        'lblConsultarNombrePeliculaSala1
        '
        Me.lblConsultarNombrePeliculaSala1.AutoSize = True
        Me.lblConsultarNombrePeliculaSala1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblConsultarNombrePeliculaSala1.Location = New System.Drawing.Point(11, 346)
        Me.lblConsultarNombrePeliculaSala1.MaximumSize = New System.Drawing.Size(250, 72)
        Me.lblConsultarNombrePeliculaSala1.Name = "lblConsultarNombrePeliculaSala1"
        Me.lblConsultarNombrePeliculaSala1.Size = New System.Drawing.Size(129, 24)
        Me.lblConsultarNombrePeliculaSala1.TabIndex = 1
        Me.lblConsultarNombrePeliculaSala1.Text = "Pelicula sala 1"
        Me.lblConsultarNombrePeliculaSala1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbConsultarImagenPeliculaSala1
        '
        Me.pbConsultarImagenPeliculaSala1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbConsultarImagenPeliculaSala1.Image = Global.Proyecto1DS8.My.Resources.Resources.emptyImage
        Me.pbConsultarImagenPeliculaSala1.InitialImage = Nothing
        Me.pbConsultarImagenPeliculaSala1.Location = New System.Drawing.Point(15, 40)
        Me.pbConsultarImagenPeliculaSala1.Name = "pbConsultarImagenPeliculaSala1"
        Me.pbConsultarImagenPeliculaSala1.Size = New System.Drawing.Size(229, 303)
        Me.pbConsultarImagenPeliculaSala1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbConsultarImagenPeliculaSala1.TabIndex = 0
        Me.pbConsultarImagenPeliculaSala1.TabStop = False
        '
        'gbSala2
        '
        Me.gbSala2.BackColor = System.Drawing.SystemColors.Control
        Me.gbSala2.Controls.Add(Me.Label2)
        Me.gbSala2.Controls.Add(Me.btnComprarTicketSala2)
        Me.gbSala2.Controls.Add(Me.lbConsultarHorarioSala2)
        Me.gbSala2.Controls.Add(Me.lblConsultarNombrePeliculaSala2)
        Me.gbSala2.Controls.Add(Me.pbConsultarImagenPeliculaSala2)
        Me.gbSala2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbSala2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSala2.Location = New System.Drawing.Point(280, 56)
        Me.gbSala2.Name = "gbSala2"
        Me.gbSala2.Size = New System.Drawing.Size(262, 565)
        Me.gbSala2.TabIndex = 14
        Me.gbSala2.TabStop = False
        Me.gbSala2.Text = "Sala 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Horario"
        '
        'btnComprarTicketSala2
        '
        Me.btnComprarTicketSala2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprarTicketSala2.Location = New System.Drawing.Point(64, 509)
        Me.btnComprarTicketSala2.Name = "btnComprarTicketSala2"
        Me.btnComprarTicketSala2.Size = New System.Drawing.Size(129, 35)
        Me.btnComprarTicketSala2.TabIndex = 3
        Me.btnComprarTicketSala2.Text = "Comprar ticket"
        Me.btnComprarTicketSala2.UseVisualStyleBackColor = True
        '
        'lbConsultarHorarioSala2
        '
        Me.lbConsultarHorarioSala2.FormattingEnabled = True
        Me.lbConsultarHorarioSala2.ItemHeight = 24
        Me.lbConsultarHorarioSala2.Location = New System.Drawing.Point(15, 417)
        Me.lbConsultarHorarioSala2.Name = "lbConsultarHorarioSala2"
        Me.lbConsultarHorarioSala2.Size = New System.Drawing.Size(229, 28)
        Me.lbConsultarHorarioSala2.TabIndex = 2
        '
        'lblConsultarNombrePeliculaSala2
        '
        Me.lblConsultarNombrePeliculaSala2.AutoSize = True
        Me.lblConsultarNombrePeliculaSala2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblConsultarNombrePeliculaSala2.Location = New System.Drawing.Point(11, 346)
        Me.lblConsultarNombrePeliculaSala2.MaximumSize = New System.Drawing.Size(250, 72)
        Me.lblConsultarNombrePeliculaSala2.Name = "lblConsultarNombrePeliculaSala2"
        Me.lblConsultarNombrePeliculaSala2.Size = New System.Drawing.Size(129, 24)
        Me.lblConsultarNombrePeliculaSala2.TabIndex = 1
        Me.lblConsultarNombrePeliculaSala2.Text = "Pelicula sala 1"
        Me.lblConsultarNombrePeliculaSala2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbConsultarImagenPeliculaSala2
        '
        Me.pbConsultarImagenPeliculaSala2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbConsultarImagenPeliculaSala2.Image = Global.Proyecto1DS8.My.Resources.Resources.emptyImage
        Me.pbConsultarImagenPeliculaSala2.InitialImage = Nothing
        Me.pbConsultarImagenPeliculaSala2.Location = New System.Drawing.Point(15, 40)
        Me.pbConsultarImagenPeliculaSala2.Name = "pbConsultarImagenPeliculaSala2"
        Me.pbConsultarImagenPeliculaSala2.Size = New System.Drawing.Size(229, 303)
        Me.pbConsultarImagenPeliculaSala2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbConsultarImagenPeliculaSala2.TabIndex = 0
        Me.pbConsultarImagenPeliculaSala2.TabStop = False
        '
        'gbSala3
        '
        Me.gbSala3.BackColor = System.Drawing.SystemColors.Control
        Me.gbSala3.Controls.Add(Me.Label4)
        Me.gbSala3.Controls.Add(Me.btnComprarTicketSala3)
        Me.gbSala3.Controls.Add(Me.lbConsultarHorarioSala3)
        Me.gbSala3.Controls.Add(Me.lblConsultarNombrePeliculaSala3)
        Me.gbSala3.Controls.Add(Me.pbConsultarImagenPeliculaSala3)
        Me.gbSala3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbSala3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSala3.Location = New System.Drawing.Point(548, 56)
        Me.gbSala3.Name = "gbSala3"
        Me.gbSala3.Size = New System.Drawing.Size(262, 565)
        Me.gbSala3.TabIndex = 15
        Me.gbSala3.TabStop = False
        Me.gbSala3.Text = "Sala 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Horario"
        '
        'btnComprarTicketSala3
        '
        Me.btnComprarTicketSala3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprarTicketSala3.Location = New System.Drawing.Point(64, 509)
        Me.btnComprarTicketSala3.Name = "btnComprarTicketSala3"
        Me.btnComprarTicketSala3.Size = New System.Drawing.Size(129, 35)
        Me.btnComprarTicketSala3.TabIndex = 3
        Me.btnComprarTicketSala3.Text = "Comprar ticket"
        Me.btnComprarTicketSala3.UseVisualStyleBackColor = True
        '
        'lbConsultarHorarioSala3
        '
        Me.lbConsultarHorarioSala3.FormattingEnabled = True
        Me.lbConsultarHorarioSala3.ItemHeight = 24
        Me.lbConsultarHorarioSala3.Location = New System.Drawing.Point(15, 417)
        Me.lbConsultarHorarioSala3.Name = "lbConsultarHorarioSala3"
        Me.lbConsultarHorarioSala3.Size = New System.Drawing.Size(229, 28)
        Me.lbConsultarHorarioSala3.TabIndex = 2
        '
        'lblConsultarNombrePeliculaSala3
        '
        Me.lblConsultarNombrePeliculaSala3.AutoSize = True
        Me.lblConsultarNombrePeliculaSala3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblConsultarNombrePeliculaSala3.Location = New System.Drawing.Point(11, 346)
        Me.lblConsultarNombrePeliculaSala3.MaximumSize = New System.Drawing.Size(250, 72)
        Me.lblConsultarNombrePeliculaSala3.Name = "lblConsultarNombrePeliculaSala3"
        Me.lblConsultarNombrePeliculaSala3.Size = New System.Drawing.Size(129, 24)
        Me.lblConsultarNombrePeliculaSala3.TabIndex = 1
        Me.lblConsultarNombrePeliculaSala3.Text = "Pelicula sala 1"
        Me.lblConsultarNombrePeliculaSala3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbConsultarImagenPeliculaSala3
        '
        Me.pbConsultarImagenPeliculaSala3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbConsultarImagenPeliculaSala3.Image = Global.Proyecto1DS8.My.Resources.Resources.emptyImage
        Me.pbConsultarImagenPeliculaSala3.InitialImage = Nothing
        Me.pbConsultarImagenPeliculaSala3.Location = New System.Drawing.Point(15, 40)
        Me.pbConsultarImagenPeliculaSala3.Name = "pbConsultarImagenPeliculaSala3"
        Me.pbConsultarImagenPeliculaSala3.Size = New System.Drawing.Size(229, 303)
        Me.pbConsultarImagenPeliculaSala3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbConsultarImagenPeliculaSala3.TabIndex = 0
        Me.pbConsultarImagenPeliculaSala3.TabStop = False
        '
        'gbSala4
        '
        Me.gbSala4.BackColor = System.Drawing.SystemColors.Control
        Me.gbSala4.Controls.Add(Me.Label6)
        Me.gbSala4.Controls.Add(Me.btnComprarTicketSala4)
        Me.gbSala4.Controls.Add(Me.lbConsultarHorarioSala4)
        Me.gbSala4.Controls.Add(Me.lblConsultarNombrePeliculaSala4)
        Me.gbSala4.Controls.Add(Me.pbConsultarImagenPeliculaSala4)
        Me.gbSala4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbSala4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSala4.Location = New System.Drawing.Point(816, 56)
        Me.gbSala4.Name = "gbSala4"
        Me.gbSala4.Size = New System.Drawing.Size(262, 565)
        Me.gbSala4.TabIndex = 16
        Me.gbSala4.TabStop = False
        Me.gbSala4.Text = "Sala 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Horario"
        '
        'btnComprarTicketSala4
        '
        Me.btnComprarTicketSala4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprarTicketSala4.Location = New System.Drawing.Point(64, 509)
        Me.btnComprarTicketSala4.Name = "btnComprarTicketSala4"
        Me.btnComprarTicketSala4.Size = New System.Drawing.Size(129, 35)
        Me.btnComprarTicketSala4.TabIndex = 3
        Me.btnComprarTicketSala4.Text = "Comprar ticket"
        Me.btnComprarTicketSala4.UseVisualStyleBackColor = True
        '
        'lbConsultarHorarioSala4
        '
        Me.lbConsultarHorarioSala4.FormattingEnabled = True
        Me.lbConsultarHorarioSala4.ItemHeight = 24
        Me.lbConsultarHorarioSala4.Location = New System.Drawing.Point(15, 417)
        Me.lbConsultarHorarioSala4.Name = "lbConsultarHorarioSala4"
        Me.lbConsultarHorarioSala4.Size = New System.Drawing.Size(229, 28)
        Me.lbConsultarHorarioSala4.TabIndex = 2
        '
        'lblConsultarNombrePeliculaSala4
        '
        Me.lblConsultarNombrePeliculaSala4.AutoSize = True
        Me.lblConsultarNombrePeliculaSala4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblConsultarNombrePeliculaSala4.Location = New System.Drawing.Point(11, 346)
        Me.lblConsultarNombrePeliculaSala4.MaximumSize = New System.Drawing.Size(250, 72)
        Me.lblConsultarNombrePeliculaSala4.Name = "lblConsultarNombrePeliculaSala4"
        Me.lblConsultarNombrePeliculaSala4.Size = New System.Drawing.Size(129, 24)
        Me.lblConsultarNombrePeliculaSala4.TabIndex = 1
        Me.lblConsultarNombrePeliculaSala4.Text = "Pelicula sala 1"
        Me.lblConsultarNombrePeliculaSala4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbConsultarImagenPeliculaSala4
        '
        Me.pbConsultarImagenPeliculaSala4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbConsultarImagenPeliculaSala4.Image = Global.Proyecto1DS8.My.Resources.Resources.emptyImage
        Me.pbConsultarImagenPeliculaSala4.InitialImage = Nothing
        Me.pbConsultarImagenPeliculaSala4.Location = New System.Drawing.Point(15, 40)
        Me.pbConsultarImagenPeliculaSala4.Name = "pbConsultarImagenPeliculaSala4"
        Me.pbConsultarImagenPeliculaSala4.Size = New System.Drawing.Size(229, 303)
        Me.pbConsultarImagenPeliculaSala4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbConsultarImagenPeliculaSala4.TabIndex = 0
        Me.pbConsultarImagenPeliculaSala4.TabStop = False
        '
        'ConsultarPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 603)
        Me.Controls.Add(Me.gbSala4)
        Me.Controls.Add(Me.gbSala3)
        Me.Controls.Add(Me.gbSala2)
        Me.Controls.Add(Me.gbSala1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "ConsultarPelicula"
        Me.Text = "ConsultarPelicula"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbSala1.ResumeLayout(False)
        Me.gbSala1.PerformLayout()
        CType(Me.pbConsultarImagenPeliculaSala1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSala2.ResumeLayout(False)
        Me.gbSala2.PerformLayout()
        CType(Me.pbConsultarImagenPeliculaSala2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSala3.ResumeLayout(False)
        Me.gbSala3.PerformLayout()
        CType(Me.pbConsultarImagenPeliculaSala3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSala4.ResumeLayout(False)
        Me.gbSala4.PerformLayout()
        CType(Me.pbConsultarImagenPeliculaSala4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BienvenidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarPelículaYTandasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPelículasYTandasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerAsientosDisponiblesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbSala1 As GroupBox
    Friend WithEvents pbConsultarImagenPeliculaSala1 As PictureBox
    Friend WithEvents lbConsultarHorarioSala1 As ListBox
    Friend WithEvents lblConsultarNombrePeliculaSala1 As Label
    Friend WithEvents btnComprarTicketSala1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents gbSala2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnComprarTicketSala2 As Button
    Friend WithEvents lbConsultarHorarioSala2 As ListBox
    Friend WithEvents lblConsultarNombrePeliculaSala2 As Label
    Friend WithEvents pbConsultarImagenPeliculaSala2 As PictureBox
    Friend WithEvents gbSala3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnComprarTicketSala3 As Button
    Friend WithEvents lbConsultarHorarioSala3 As ListBox
    Friend WithEvents lblConsultarNombrePeliculaSala3 As Label
    Friend WithEvents pbConsultarImagenPeliculaSala3 As PictureBox
    Friend WithEvents gbSala4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnComprarTicketSala4 As Button
    Friend WithEvents lbConsultarHorarioSala4 As ListBox
    Friend WithEvents lblConsultarNombrePeliculaSala4 As Label
    Friend WithEvents pbConsultarImagenPeliculaSala4 As PictureBox
    Friend WithEvents VerTotalesToolStripMenuItem As ToolStripMenuItem
End Class
