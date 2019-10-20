<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresarPeliculas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpAñadirFechaPelicula1 = New System.Windows.Forms.DateTimePicker()
        Me.lbHorariosAgregados1 = New System.Windows.Forms.ListBox()
        Me.btnAgregarHorario1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbAgregarHorario1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAñadirNombrePelicula1 = New System.Windows.Forms.TextBox()
        Me.btnCargarImagenPelicula1 = New System.Windows.Forms.Button()
        Me.pbImagenAñadidaPelicula1 = New System.Windows.Forms.PictureBox()
        Me.btnFinalizarIngresoPeliculas = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpAñadirFechaPelicula2 = New System.Windows.Forms.DateTimePicker()
        Me.lbHorariosAgregados2 = New System.Windows.Forms.ListBox()
        Me.btnAgregarHorario2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbAgregarHorario2 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAñadirNombrePelicula2 = New System.Windows.Forms.TextBox()
        Me.btnCargarImagenPelicula2 = New System.Windows.Forms.Button()
        Me.pbImagenAñadidaPelicula2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpAñadirFechaPelicula3 = New System.Windows.Forms.DateTimePicker()
        Me.lbHorariosAgregados3 = New System.Windows.Forms.ListBox()
        Me.btnAgregarHorario3 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbAgregarHorario3 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAñadirNombrePelicula3 = New System.Windows.Forms.TextBox()
        Me.btnCargarImagenPelicula3 = New System.Windows.Forms.Button()
        Me.pbImagenAñadidaPelicula3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpAñadirFechaPelicula4 = New System.Windows.Forms.DateTimePicker()
        Me.lbHorariosAgregados4 = New System.Windows.Forms.ListBox()
        Me.btnAgregarHorario4 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbAgregarHorario4 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtAñadirNombrePelicula4 = New System.Windows.Forms.TextBox()
        Me.btnCargarImagenPelicula4 = New System.Windows.Forms.Button()
        Me.pbImagenAñadidaPelicula4 = New System.Windows.Forms.PictureBox()
        Me.pfdCargaImagen = New System.Windows.Forms.OpenFileDialog()
        Me.VERTOTALESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbImagenAñadidaPelicula1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbImagenAñadidaPelicula2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pbImagenAñadidaPelicula3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pbImagenAñadidaPelicula4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BienvenidaToolStripMenuItem, Me.IngresarPelículaYTandasToolStripMenuItem, Me.ConsultarPelículasYTandasToolStripMenuItem, Me.VerAsientosDisponiblesToolStripMenuItem, Me.VERTOTALESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1081, 29)
        Me.MenuStrip1.TabIndex = 2
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpAñadirFechaPelicula1)
        Me.GroupBox1.Controls.Add(Me.lbHorariosAgregados1)
        Me.GroupBox1.Controls.Add(Me.btnAgregarHorario1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbAgregarHorario1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAñadirNombrePelicula1)
        Me.GroupBox1.Controls.Add(Me.btnCargarImagenPelicula1)
        Me.GroupBox1.Controls.Add(Me.pbImagenAñadidaPelicula1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 561)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sala 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha de estreno de la película"
        '
        'dtpAñadirFechaPelicula1
        '
        Me.dtpAñadirFechaPelicula1.CustomFormat = "ddd d MMM yyyy"
        Me.dtpAñadirFechaPelicula1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAñadirFechaPelicula1.Location = New System.Drawing.Point(25, 94)
        Me.dtpAñadirFechaPelicula1.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpAñadirFechaPelicula1.Name = "dtpAñadirFechaPelicula1"
        Me.dtpAñadirFechaPelicula1.Size = New System.Drawing.Size(212, 20)
        Me.dtpAñadirFechaPelicula1.TabIndex = 4
        '
        'lbHorariosAgregados1
        '
        Me.lbHorariosAgregados1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHorariosAgregados1.FormattingEnabled = True
        Me.lbHorariosAgregados1.Location = New System.Drawing.Point(29, 501)
        Me.lbHorariosAgregados1.Name = "lbHorariosAgregados1"
        Me.lbHorariosAgregados1.Size = New System.Drawing.Size(132, 43)
        Me.lbHorariosAgregados1.TabIndex = 10
        '
        'btnAgregarHorario1
        '
        Me.btnAgregarHorario1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarHorario1.Location = New System.Drawing.Point(174, 458)
        Me.btnAgregarHorario1.Name = "btnAgregarHorario1"
        Me.btnAgregarHorario1.Size = New System.Drawing.Size(67, 23)
        Me.btnAgregarHorario1.TabIndex = 9
        Me.btnAgregarHorario1.Text = "Agregar"
        Me.btnAgregarHorario1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 484)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ver horarios agregados"
        '
        'cmbAgregarHorario1
        '
        Me.cmbAgregarHorario1.DisplayMember = "11:00"
        Me.cmbAgregarHorario1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgregarHorario1.FormattingEnabled = True
        Me.cmbAgregarHorario1.Items.AddRange(New Object() {"11:30 AM", "01:00 PM", "02:15 PM", "03:40 PM", "05:00 PM", "06:20 PM", "07:40 PM", "09:15 PM", "10:40 PM"})
        Me.cmbAgregarHorario1.Location = New System.Drawing.Point(29, 433)
        Me.cmbAgregarHorario1.Name = "cmbAgregarHorario1"
        Me.cmbAgregarHorario1.Size = New System.Drawing.Size(132, 21)
        Me.cmbAgregarHorario1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Agregar horario de película"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cartelera de la película"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre de la película"
        '
        'txtAñadirNombrePelicula1
        '
        Me.txtAñadirNombrePelicula1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAñadirNombrePelicula1.Location = New System.Drawing.Point(25, 42)
        Me.txtAñadirNombrePelicula1.Name = "txtAñadirNombrePelicula1"
        Me.txtAñadirNombrePelicula1.Size = New System.Drawing.Size(212, 20)
        Me.txtAñadirNombrePelicula1.TabIndex = 3
        '
        'btnCargarImagenPelicula1
        '
        Me.btnCargarImagenPelicula1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarImagenPelicula1.Location = New System.Drawing.Point(149, 386)
        Me.btnCargarImagenPelicula1.Name = "btnCargarImagenPelicula1"
        Me.btnCargarImagenPelicula1.Size = New System.Drawing.Size(92, 23)
        Me.btnCargarImagenPelicula1.TabIndex = 2
        Me.btnCargarImagenPelicula1.Text = "Cargar Imagen"
        Me.btnCargarImagenPelicula1.UseVisualStyleBackColor = True
        '
        'pbImagenAñadidaPelicula1
        '
        Me.pbImagenAñadidaPelicula1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImagenAñadidaPelicula1.Image = Global.Proyecto1DS8.My.Resources.Resources.emptyImage
        Me.pbImagenAñadidaPelicula1.InitialImage = Nothing
        Me.pbImagenAñadidaPelicula1.Location = New System.Drawing.Point(44, 145)
        Me.pbImagenAñadidaPelicula1.Name = "pbImagenAñadidaPelicula1"
        Me.pbImagenAñadidaPelicula1.Size = New System.Drawing.Size(174, 235)
        Me.pbImagenAñadidaPelicula1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagenAñadidaPelicula1.TabIndex = 0
        Me.pbImagenAñadidaPelicula1.TabStop = False
        '
        'btnFinalizarIngresoPeliculas
        '
        Me.btnFinalizarIngresoPeliculas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizarIngresoPeliculas.Location = New System.Drawing.Point(965, 620)
        Me.btnFinalizarIngresoPeliculas.Name = "btnFinalizarIngresoPeliculas"
        Me.btnFinalizarIngresoPeliculas.Size = New System.Drawing.Size(113, 30)
        Me.btnFinalizarIngresoPeliculas.TabIndex = 4
        Me.btnFinalizarIngresoPeliculas.Text = "Finalizar"
        Me.btnFinalizarIngresoPeliculas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dtpAñadirFechaPelicula2)
        Me.GroupBox2.Controls.Add(Me.lbHorariosAgregados2)
        Me.GroupBox2.Controls.Add(Me.btnAgregarHorario2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbAgregarHorario2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtAñadirNombrePelicula2)
        Me.GroupBox2.Controls.Add(Me.btnCargarImagenPelicula2)
        Me.GroupBox2.Controls.Add(Me.pbImagenAñadidaPelicula2)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(280, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 561)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sala 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fecha de estreno de la película"
        '
        'dtpAñadirFechaPelicula2
        '
        Me.dtpAñadirFechaPelicula2.CustomFormat = "ddd d MMM yyyy"
        Me.dtpAñadirFechaPelicula2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAñadirFechaPelicula2.Location = New System.Drawing.Point(25, 94)
        Me.dtpAñadirFechaPelicula2.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpAñadirFechaPelicula2.Name = "dtpAñadirFechaPelicula2"
        Me.dtpAñadirFechaPelicula2.Size = New System.Drawing.Size(212, 20)
        Me.dtpAñadirFechaPelicula2.TabIndex = 4
        '
        'lbHorariosAgregados2
        '
        Me.lbHorariosAgregados2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHorariosAgregados2.FormattingEnabled = True
        Me.lbHorariosAgregados2.Location = New System.Drawing.Point(29, 501)
        Me.lbHorariosAgregados2.Name = "lbHorariosAgregados2"
        Me.lbHorariosAgregados2.Size = New System.Drawing.Size(132, 43)
        Me.lbHorariosAgregados2.TabIndex = 10
        '
        'btnAgregarHorario2
        '
        Me.btnAgregarHorario2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarHorario2.Location = New System.Drawing.Point(174, 458)
        Me.btnAgregarHorario2.Name = "btnAgregarHorario2"
        Me.btnAgregarHorario2.Size = New System.Drawing.Size(67, 23)
        Me.btnAgregarHorario2.TabIndex = 9
        Me.btnAgregarHorario2.Text = "Agregar"
        Me.btnAgregarHorario2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 484)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Ver horarios agregados"
        '
        'cmbAgregarHorario2
        '
        Me.cmbAgregarHorario2.DisplayMember = "11:00"
        Me.cmbAgregarHorario2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgregarHorario2.FormattingEnabled = True
        Me.cmbAgregarHorario2.Items.AddRange(New Object() {"11:30 AM", "01:00 PM", "02:15 PM", "03:40 PM", "05:00 PM", "06:20 PM", "07:40 PM", "09:15 PM", "10:40 PM"})
        Me.cmbAgregarHorario2.Location = New System.Drawing.Point(29, 433)
        Me.cmbAgregarHorario2.Name = "cmbAgregarHorario2"
        Me.cmbAgregarHorario2.Size = New System.Drawing.Size(132, 21)
        Me.cmbAgregarHorario2.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 416)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Agregar horario de película"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Cartelera de la película"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Nombre de la película"
        '
        'txtAñadirNombrePelicula2
        '
        Me.txtAñadirNombrePelicula2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAñadirNombrePelicula2.Location = New System.Drawing.Point(25, 42)
        Me.txtAñadirNombrePelicula2.Name = "txtAñadirNombrePelicula2"
        Me.txtAñadirNombrePelicula2.Size = New System.Drawing.Size(212, 20)
        Me.txtAñadirNombrePelicula2.TabIndex = 3
        '
        'btnCargarImagenPelicula2
        '
        Me.btnCargarImagenPelicula2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarImagenPelicula2.Location = New System.Drawing.Point(149, 386)
        Me.btnCargarImagenPelicula2.Name = "btnCargarImagenPelicula2"
        Me.btnCargarImagenPelicula2.Size = New System.Drawing.Size(92, 23)
        Me.btnCargarImagenPelicula2.TabIndex = 2
        Me.btnCargarImagenPelicula2.Text = "Cargar Imagen"
        Me.btnCargarImagenPelicula2.UseVisualStyleBackColor = True
        '
        'pbImagenAñadidaPelicula2
        '
        Me.pbImagenAñadidaPelicula2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImagenAñadidaPelicula2.Image = Global.Proyecto1DS8.My.Resources.Resources.emptyImage
        Me.pbImagenAñadidaPelicula2.InitialImage = Nothing
        Me.pbImagenAñadidaPelicula2.Location = New System.Drawing.Point(44, 145)
        Me.pbImagenAñadidaPelicula2.Name = "pbImagenAñadidaPelicula2"
        Me.pbImagenAñadidaPelicula2.Size = New System.Drawing.Size(174, 235)
        Me.pbImagenAñadidaPelicula2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagenAñadidaPelicula2.TabIndex = 0
        Me.pbImagenAñadidaPelicula2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.dtpAñadirFechaPelicula3)
        Me.GroupBox3.Controls.Add(Me.lbHorariosAgregados3)
        Me.GroupBox3.Controls.Add(Me.btnAgregarHorario3)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.cmbAgregarHorario3)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtAñadirNombrePelicula3)
        Me.GroupBox3.Controls.Add(Me.btnCargarImagenPelicula3)
        Me.GroupBox3.Controls.Add(Me.pbImagenAñadidaPelicula3)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(548, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(262, 561)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sala 3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Fecha de estreno de la película"
        '
        'dtpAñadirFechaPelicula3
        '
        Me.dtpAñadirFechaPelicula3.CustomFormat = "ddd d MMM yyyy"
        Me.dtpAñadirFechaPelicula3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAñadirFechaPelicula3.Location = New System.Drawing.Point(25, 94)
        Me.dtpAñadirFechaPelicula3.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpAñadirFechaPelicula3.Name = "dtpAñadirFechaPelicula3"
        Me.dtpAñadirFechaPelicula3.Size = New System.Drawing.Size(212, 20)
        Me.dtpAñadirFechaPelicula3.TabIndex = 4
        '
        'lbHorariosAgregados3
        '
        Me.lbHorariosAgregados3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHorariosAgregados3.FormattingEnabled = True
        Me.lbHorariosAgregados3.Location = New System.Drawing.Point(29, 501)
        Me.lbHorariosAgregados3.Name = "lbHorariosAgregados3"
        Me.lbHorariosAgregados3.Size = New System.Drawing.Size(132, 43)
        Me.lbHorariosAgregados3.TabIndex = 10
        '
        'btnAgregarHorario3
        '
        Me.btnAgregarHorario3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarHorario3.Location = New System.Drawing.Point(174, 458)
        Me.btnAgregarHorario3.Name = "btnAgregarHorario3"
        Me.btnAgregarHorario3.Size = New System.Drawing.Size(67, 23)
        Me.btnAgregarHorario3.TabIndex = 9
        Me.btnAgregarHorario3.Text = "Agregar"
        Me.btnAgregarHorario3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 484)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Ver horarios agregados"
        '
        'cmbAgregarHorario3
        '
        Me.cmbAgregarHorario3.DisplayMember = "11:00"
        Me.cmbAgregarHorario3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgregarHorario3.FormattingEnabled = True
        Me.cmbAgregarHorario3.Items.AddRange(New Object() {"11:30 AM", "01:00 PM", "02:15 PM", "03:40 PM", "05:00 PM", "06:20 PM", "07:40 PM", "09:15 PM", "10:40 PM"})
        Me.cmbAgregarHorario3.Location = New System.Drawing.Point(29, 433)
        Me.cmbAgregarHorario3.Name = "cmbAgregarHorario3"
        Me.cmbAgregarHorario3.Size = New System.Drawing.Size(132, 21)
        Me.cmbAgregarHorario3.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(26, 416)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Agregar horario de película"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Cartelera de la película"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(22, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Nombre de la película"
        '
        'txtAñadirNombrePelicula3
        '
        Me.txtAñadirNombrePelicula3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAñadirNombrePelicula3.Location = New System.Drawing.Point(25, 42)
        Me.txtAñadirNombrePelicula3.Name = "txtAñadirNombrePelicula3"
        Me.txtAñadirNombrePelicula3.Size = New System.Drawing.Size(212, 20)
        Me.txtAñadirNombrePelicula3.TabIndex = 3
        '
        'btnCargarImagenPelicula3
        '
        Me.btnCargarImagenPelicula3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarImagenPelicula3.Location = New System.Drawing.Point(149, 386)
        Me.btnCargarImagenPelicula3.Name = "btnCargarImagenPelicula3"
        Me.btnCargarImagenPelicula3.Size = New System.Drawing.Size(92, 23)
        Me.btnCargarImagenPelicula3.TabIndex = 2
        Me.btnCargarImagenPelicula3.Text = "Cargar Imagen"
        Me.btnCargarImagenPelicula3.UseVisualStyleBackColor = True
        '
        'pbImagenAñadidaPelicula3
        '
        Me.pbImagenAñadidaPelicula3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImagenAñadidaPelicula3.Image = Global.Proyecto1DS8.My.Resources.Resources.emptyImage
        Me.pbImagenAñadidaPelicula3.InitialImage = Nothing
        Me.pbImagenAñadidaPelicula3.Location = New System.Drawing.Point(44, 145)
        Me.pbImagenAñadidaPelicula3.Name = "pbImagenAñadidaPelicula3"
        Me.pbImagenAñadidaPelicula3.Size = New System.Drawing.Size(174, 235)
        Me.pbImagenAñadidaPelicula3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagenAñadidaPelicula3.TabIndex = 0
        Me.pbImagenAñadidaPelicula3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.dtpAñadirFechaPelicula4)
        Me.GroupBox4.Controls.Add(Me.lbHorariosAgregados4)
        Me.GroupBox4.Controls.Add(Me.btnAgregarHorario4)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.cmbAgregarHorario4)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtAñadirNombrePelicula4)
        Me.GroupBox4.Controls.Add(Me.btnCargarImagenPelicula4)
        Me.GroupBox4.Controls.Add(Me.pbImagenAñadidaPelicula4)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(816, 53)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(262, 561)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sala 4"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(22, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(157, 13)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Fecha de estreno de la película"
        '
        'dtpAñadirFechaPelicula4
        '
        Me.dtpAñadirFechaPelicula4.CustomFormat = "ddd d MMM yyyy"
        Me.dtpAñadirFechaPelicula4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAñadirFechaPelicula4.Location = New System.Drawing.Point(25, 94)
        Me.dtpAñadirFechaPelicula4.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpAñadirFechaPelicula4.Name = "dtpAñadirFechaPelicula4"
        Me.dtpAñadirFechaPelicula4.Size = New System.Drawing.Size(212, 20)
        Me.dtpAñadirFechaPelicula4.TabIndex = 4
        '
        'lbHorariosAgregados4
        '
        Me.lbHorariosAgregados4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHorariosAgregados4.FormattingEnabled = True
        Me.lbHorariosAgregados4.Location = New System.Drawing.Point(25, 499)
        Me.lbHorariosAgregados4.Name = "lbHorariosAgregados4"
        Me.lbHorariosAgregados4.Size = New System.Drawing.Size(132, 43)
        Me.lbHorariosAgregados4.TabIndex = 10
        '
        'btnAgregarHorario4
        '
        Me.btnAgregarHorario4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarHorario4.Location = New System.Drawing.Point(174, 458)
        Me.btnAgregarHorario4.Name = "btnAgregarHorario4"
        Me.btnAgregarHorario4.Size = New System.Drawing.Size(67, 23)
        Me.btnAgregarHorario4.TabIndex = 9
        Me.btnAgregarHorario4.Text = "Agregar"
        Me.btnAgregarHorario4.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(22, 482)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(116, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Ver horarios agregados"
        '
        'cmbAgregarHorario4
        '
        Me.cmbAgregarHorario4.DisplayMember = "11:00"
        Me.cmbAgregarHorario4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgregarHorario4.FormattingEnabled = True
        Me.cmbAgregarHorario4.Items.AddRange(New Object() {"11:30 AM", "01:00 PM", "02:15 PM", "03:40 PM", "05:00 PM", "06:20 PM", "07:40 PM", "09:15 PM", "10:40 PM"})
        Me.cmbAgregarHorario4.Location = New System.Drawing.Point(29, 433)
        Me.cmbAgregarHorario4.Name = "cmbAgregarHorario4"
        Me.cmbAgregarHorario4.Size = New System.Drawing.Size(132, 21)
        Me.cmbAgregarHorario4.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(26, 416)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(135, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Agregar horario de película"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(26, 129)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Cartelera de la película"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(22, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(111, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Nombre de la película"
        '
        'txtAñadirNombrePelicula4
        '
        Me.txtAñadirNombrePelicula4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAñadirNombrePelicula4.Location = New System.Drawing.Point(25, 42)
        Me.txtAñadirNombrePelicula4.Name = "txtAñadirNombrePelicula4"
        Me.txtAñadirNombrePelicula4.Size = New System.Drawing.Size(212, 20)
        Me.txtAñadirNombrePelicula4.TabIndex = 3
        '
        'btnCargarImagenPelicula4
        '
        Me.btnCargarImagenPelicula4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarImagenPelicula4.Location = New System.Drawing.Point(149, 386)
        Me.btnCargarImagenPelicula4.Name = "btnCargarImagenPelicula4"
        Me.btnCargarImagenPelicula4.Size = New System.Drawing.Size(92, 23)
        Me.btnCargarImagenPelicula4.TabIndex = 2
        Me.btnCargarImagenPelicula4.Text = "Cargar Imagen"
        Me.btnCargarImagenPelicula4.UseVisualStyleBackColor = True
        '
        'pbImagenAñadidaPelicula4
        '
        Me.pbImagenAñadidaPelicula4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImagenAñadidaPelicula4.Image = Global.Proyecto1DS8.My.Resources.Resources.emptyImage
        Me.pbImagenAñadidaPelicula4.InitialImage = Nothing
        Me.pbImagenAñadidaPelicula4.Location = New System.Drawing.Point(44, 145)
        Me.pbImagenAñadidaPelicula4.Name = "pbImagenAñadidaPelicula4"
        Me.pbImagenAñadidaPelicula4.Size = New System.Drawing.Size(174, 235)
        Me.pbImagenAñadidaPelicula4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagenAñadidaPelicula4.TabIndex = 0
        Me.pbImagenAñadidaPelicula4.TabStop = False
        '
        'pfdCargaImagen
        '
        Me.pfdCargaImagen.FileName = "OpenFileDialog1"
        '
        'VERTOTALESToolStripMenuItem
        '
        Me.VERTOTALESToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VERTOTALESToolStripMenuItem.Name = "VERTOTALESToolStripMenuItem"
        Me.VERTOTALESToolStripMenuItem.Size = New System.Drawing.Size(96, 25)
        Me.VERTOTALESToolStripMenuItem.Text = "Ver Totales"
        '
        'IngresarPeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 652)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnFinalizarIngresoPeliculas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "IngresarPeliculas"
        Me.Text = "Ingresar Películas y Horarios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbImagenAñadidaPelicula1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbImagenAñadidaPelicula2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pbImagenAñadidaPelicula3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pbImagenAñadidaPelicula4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BienvenidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarPelículaYTandasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPelículasYTandasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerAsientosDisponiblesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pbImagenAñadidaPelicula1 As PictureBox
    Friend WithEvents btnCargarImagenPelicula1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAñadirNombrePelicula1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpAñadirFechaPelicula1 As DateTimePicker
    Friend WithEvents lbHorariosAgregados1 As ListBox
    Friend WithEvents btnAgregarHorario1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbAgregarHorario1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnFinalizarIngresoPeliculas As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpAñadirFechaPelicula2 As DateTimePicker
    Friend WithEvents lbHorariosAgregados2 As ListBox
    Friend WithEvents btnAgregarHorario2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbAgregarHorario2 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAñadirNombrePelicula2 As TextBox
    Friend WithEvents btnCargarImagenPelicula2 As Button
    Friend WithEvents pbImagenAñadidaPelicula2 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpAñadirFechaPelicula3 As DateTimePicker
    Friend WithEvents lbHorariosAgregados3 As ListBox
    Friend WithEvents btnAgregarHorario3 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbAgregarHorario3 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtAñadirNombrePelicula3 As TextBox
    Friend WithEvents btnCargarImagenPelicula3 As Button
    Friend WithEvents pbImagenAñadidaPelicula3 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents dtpAñadirFechaPelicula4 As DateTimePicker
    Friend WithEvents lbHorariosAgregados4 As ListBox
    Friend WithEvents btnAgregarHorario4 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbAgregarHorario4 As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtAñadirNombrePelicula4 As TextBox
    Friend WithEvents btnCargarImagenPelicula4 As Button
    Friend WithEvents pbImagenAñadidaPelicula4 As PictureBox
    Friend WithEvents pfdCargaImagen As OpenFileDialog
    Friend WithEvents VERTOTALESToolStripMenuItem As ToolStripMenuItem
End Class
