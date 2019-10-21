<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class comprarBoleto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gbdatosEntrada = New System.Windows.Forms.GroupBox()
        Me.lblPeliculaEstrenoSiNo = New System.Windows.Forms.Label()
        Me.lblPeliculaEstreno = New System.Windows.Forms.Label()
        Me.txtNumeroSala = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPagas = New System.Windows.Forms.Label()
        Me.txtPagas = New System.Windows.Forms.TextBox()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.lblAsiento = New System.Windows.Forms.Label()
        Me.txtAsiento = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.lbHorarioElegido = New System.Windows.Forms.ListBox()
        Me.pbCartelera = New System.Windows.Forms.PictureBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.nudNumeroBoleto = New System.Windows.Forms.NumericUpDown()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblFechaEntrada = New System.Windows.Forms.Label()
        Me.lblNumeroSala = New System.Windows.Forms.Label()
        Me.lblNumeroBoletos = New System.Windows.Forms.Label()
        Me.nudEdad = New System.Windows.Forms.NumericUpDown()
        Me.dtpFechaEntrada = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BienvenidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarPelículaYTandasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPelículasYTandasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerAsientosDisponiblesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerTotalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nudMayores = New System.Windows.Forms.NumericUpDown()
        Me.nudMenores = New System.Windows.Forms.NumericUpDown()
        Me.gbdatosEntrada.SuspendLayout()
        CType(Me.pbCartelera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumeroBoleto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.nudMayores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMenores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbdatosEntrada
        '
        Me.gbdatosEntrada.BackColor = System.Drawing.Color.SkyBlue
        Me.gbdatosEntrada.Controls.Add(Me.nudMenores)
        Me.gbdatosEntrada.Controls.Add(Me.nudMayores)
        Me.gbdatosEntrada.Controls.Add(Me.lblPeliculaEstrenoSiNo)
        Me.gbdatosEntrada.Controls.Add(Me.lblPeliculaEstreno)
        Me.gbdatosEntrada.Controls.Add(Me.txtNumeroSala)
        Me.gbdatosEntrada.Controls.Add(Me.Label1)
        Me.gbdatosEntrada.Controls.Add(Me.lblPagas)
        Me.gbdatosEntrada.Controls.Add(Me.txtPagas)
        Me.gbdatosEntrada.Controls.Add(Me.btnPagar)
        Me.gbdatosEntrada.Controls.Add(Me.lblAsiento)
        Me.gbdatosEntrada.Controls.Add(Me.txtAsiento)
        Me.gbdatosEntrada.Controls.Add(Me.txtCosto)
        Me.gbdatosEntrada.Controls.Add(Me.lblCosto)
        Me.gbdatosEntrada.Controls.Add(Me.lbHorarioElegido)
        Me.gbdatosEntrada.Controls.Add(Me.pbCartelera)
        Me.gbdatosEntrada.Controls.Add(Me.btnProcesar)
        Me.gbdatosEntrada.Controls.Add(Me.nudNumeroBoleto)
        Me.gbdatosEntrada.Controls.Add(Me.lblEdad)
        Me.gbdatosEntrada.Controls.Add(Me.lblFechaEntrada)
        Me.gbdatosEntrada.Controls.Add(Me.lblNumeroSala)
        Me.gbdatosEntrada.Controls.Add(Me.lblNumeroBoletos)
        Me.gbdatosEntrada.Controls.Add(Me.nudEdad)
        Me.gbdatosEntrada.Controls.Add(Me.dtpFechaEntrada)
        Me.gbdatosEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbdatosEntrada.Location = New System.Drawing.Point(11, 43)
        Me.gbdatosEntrada.Margin = New System.Windows.Forms.Padding(2)
        Me.gbdatosEntrada.Name = "gbdatosEntrada"
        Me.gbdatosEntrada.Padding = New System.Windows.Forms.Padding(2)
        Me.gbdatosEntrada.Size = New System.Drawing.Size(847, 423)
        Me.gbdatosEntrada.TabIndex = 0
        Me.gbdatosEntrada.TabStop = False
        Me.gbdatosEntrada.Text = "Datos de entrada"
        '
        'lblPeliculaEstrenoSiNo
        '
        Me.lblPeliculaEstrenoSiNo.AutoSize = True
        Me.lblPeliculaEstrenoSiNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeliculaEstrenoSiNo.Location = New System.Drawing.Point(203, 193)
        Me.lblPeliculaEstrenoSiNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPeliculaEstrenoSiNo.Name = "lblPeliculaEstrenoSiNo"
        Me.lblPeliculaEstrenoSiNo.Size = New System.Drawing.Size(52, 17)
        Me.lblPeliculaEstrenoSiNo.TabIndex = 52
        Me.lblPeliculaEstrenoSiNo.Text = "Estado"
        Me.lblPeliculaEstrenoSiNo.Visible = False
        '
        'lblPeliculaEstreno
        '
        Me.lblPeliculaEstreno.AutoSize = True
        Me.lblPeliculaEstreno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeliculaEstreno.Location = New System.Drawing.Point(31, 193)
        Me.lblPeliculaEstreno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPeliculaEstreno.Name = "lblPeliculaEstreno"
        Me.lblPeliculaEstreno.Size = New System.Drawing.Size(138, 17)
        Me.lblPeliculaEstreno.TabIndex = 51
        Me.lblPeliculaEstreno.Text = "Película en Estreno: "
        Me.lblPeliculaEstreno.Visible = False
        '
        'txtNumeroSala
        '
        Me.txtNumeroSala.Enabled = False
        Me.txtNumeroSala.Location = New System.Drawing.Point(206, 50)
        Me.txtNumeroSala.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroSala.Name = "txtNumeroSala"
        Me.txtNumeroSala.Size = New System.Drawing.Size(76, 26)
        Me.txtNumeroSala.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(490, 214)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Horario/Tandas"
        '
        'lblPagas
        '
        Me.lblPagas.AutoSize = True
        Me.lblPagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagas.Location = New System.Drawing.Point(31, 315)
        Me.lblPagas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPagas.Name = "lblPagas"
        Me.lblPagas.Size = New System.Drawing.Size(48, 17)
        Me.lblPagas.TabIndex = 48
        Me.lblPagas.Text = "Pagas"
        Me.lblPagas.Visible = False
        '
        'txtPagas
        '
        Me.txtPagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagas.Location = New System.Drawing.Point(349, 313)
        Me.txtPagas.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPagas.Name = "txtPagas"
        Me.txtPagas.Size = New System.Drawing.Size(105, 23)
        Me.txtPagas.TabIndex = 47
        Me.txtPagas.Text = "0"
        Me.txtPagas.Visible = False
        '
        'btnPagar
        '
        Me.btnPagar.BackColor = System.Drawing.Color.ForestGreen
        Me.btnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPagar.Location = New System.Drawing.Point(352, 371)
        Me.btnPagar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(83, 32)
        Me.btnPagar.TabIndex = 46
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = False
        Me.btnPagar.Visible = False
        '
        'lblAsiento
        '
        Me.lblAsiento.AutoSize = True
        Me.lblAsiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsiento.Location = New System.Drawing.Point(31, 247)
        Me.lblAsiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAsiento.Name = "lblAsiento"
        Me.lblAsiento.Size = New System.Drawing.Size(62, 17)
        Me.lblAsiento.TabIndex = 45
        Me.lblAsiento.Text = "Asientos"
        Me.lblAsiento.Visible = False
        '
        'txtAsiento
        '
        Me.txtAsiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsiento.Location = New System.Drawing.Point(206, 245)
        Me.txtAsiento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAsiento.Name = "txtAsiento"
        Me.txtAsiento.ReadOnly = True
        Me.txtAsiento.Size = New System.Drawing.Size(95, 23)
        Me.txtAsiento.TabIndex = 44
        Me.txtAsiento.Visible = False
        '
        'txtCosto
        '
        Me.txtCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.Location = New System.Drawing.Point(349, 281)
        Me.txtCosto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.ReadOnly = True
        Me.txtCosto.Size = New System.Drawing.Size(105, 23)
        Me.txtCosto.TabIndex = 43
        Me.txtCosto.Text = "0"
        Me.txtCosto.Visible = False
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosto.Location = New System.Drawing.Point(31, 284)
        Me.lblCosto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(44, 17)
        Me.lblCosto.TabIndex = 42
        Me.lblCosto.Text = "Costo"
        Me.lblCosto.Visible = False
        '
        'lbHorarioElegido
        '
        Me.lbHorarioElegido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHorarioElegido.FormattingEnabled = True
        Me.lbHorarioElegido.ItemHeight = 16
        Me.lbHorarioElegido.Location = New System.Drawing.Point(490, 232)
        Me.lbHorarioElegido.Margin = New System.Windows.Forms.Padding(2)
        Me.lbHorarioElegido.Name = "lbHorarioElegido"
        Me.lbHorarioElegido.Size = New System.Drawing.Size(126, 116)
        Me.lbHorarioElegido.TabIndex = 41
        '
        'pbCartelera
        '
        Me.pbCartelera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbCartelera.Image = Global.Proyecto1DS8.My.Resources.Resources.emptyImage
        Me.pbCartelera.Location = New System.Drawing.Point(620, 25)
        Me.pbCartelera.Margin = New System.Windows.Forms.Padding(2)
        Me.pbCartelera.Name = "pbCartelera"
        Me.pbCartelera.Size = New System.Drawing.Size(210, 341)
        Me.pbCartelera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCartelera.TabIndex = 39
        Me.pbCartelera.TabStop = False
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnProcesar.Location = New System.Drawing.Point(214, 371)
        Me.btnProcesar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(110, 32)
        Me.btnProcesar.TabIndex = 38
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'nudNumeroBoleto
        '
        Me.nudNumeroBoleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumeroBoleto.Location = New System.Drawing.Point(206, 88)
        Me.nudNumeroBoleto.Margin = New System.Windows.Forms.Padding(2)
        Me.nudNumeroBoleto.Name = "nudNumeroBoleto"
        Me.nudNumeroBoleto.Size = New System.Drawing.Size(112, 23)
        Me.nudNumeroBoleto.TabIndex = 37
        Me.nudNumeroBoleto.Visible = False
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(31, 161)
        Me.lblEdad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(41, 17)
        Me.lblEdad.TabIndex = 36
        Me.lblEdad.Text = "Edad"
        Me.lblEdad.Visible = False
        '
        'lblFechaEntrada
        '
        Me.lblFechaEntrada.AutoSize = True
        Me.lblFechaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEntrada.Location = New System.Drawing.Point(32, 128)
        Me.lblFechaEntrada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaEntrada.Name = "lblFechaEntrada"
        Me.lblFechaEntrada.Size = New System.Drawing.Size(120, 17)
        Me.lblFechaEntrada.TabIndex = 35
        Me.lblFechaEntrada.Text = "Fecha de entrada"
        Me.lblFechaEntrada.Visible = False
        '
        'lblNumeroSala
        '
        Me.lblNumeroSala.AutoSize = True
        Me.lblNumeroSala.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroSala.Location = New System.Drawing.Point(31, 56)
        Me.lblNumeroSala.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumeroSala.Name = "lblNumeroSala"
        Me.lblNumeroSala.Size = New System.Drawing.Size(108, 17)
        Me.lblNumeroSala.TabIndex = 34
        Me.lblNumeroSala.Text = "Número de sala"
        '
        'lblNumeroBoletos
        '
        Me.lblNumeroBoletos.AutoSize = True
        Me.lblNumeroBoletos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroBoletos.Location = New System.Drawing.Point(31, 89)
        Me.lblNumeroBoletos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumeroBoletos.Name = "lblNumeroBoletos"
        Me.lblNumeroBoletos.Size = New System.Drawing.Size(128, 17)
        Me.lblNumeroBoletos.TabIndex = 33
        Me.lblNumeroBoletos.Text = "Número de boletos"
        Me.lblNumeroBoletos.Visible = False
        '
        'nudEdad
        '
        Me.nudEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudEdad.Location = New System.Drawing.Point(206, 159)
        Me.nudEdad.Margin = New System.Windows.Forms.Padding(2)
        Me.nudEdad.Name = "nudEdad"
        Me.nudEdad.Size = New System.Drawing.Size(112, 23)
        Me.nudEdad.TabIndex = 32
        Me.nudEdad.Visible = False
        '
        'dtpFechaEntrada
        '
        Me.dtpFechaEntrada.Enabled = False
        Me.dtpFechaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEntrada.Location = New System.Drawing.Point(206, 124)
        Me.dtpFechaEntrada.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaEntrada.Name = "dtpFechaEntrada"
        Me.dtpFechaEntrada.Size = New System.Drawing.Size(245, 23)
        Me.dtpFechaEntrada.TabIndex = 31
        Me.dtpFechaEntrada.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BienvenidaToolStripMenuItem, Me.IngresarPelículaYTandasToolStripMenuItem, Me.ConsultarPelículasYTandasToolStripMenuItem, Me.VerAsientosDisponiblesToolStripMenuItem, Me.VerTotalesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(867, 29)
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
        'nudMayores
        '
        Me.nudMayores.Location = New System.Drawing.Point(366, 85)
        Me.nudMayores.Name = "nudMayores"
        Me.nudMayores.Size = New System.Drawing.Size(50, 26)
        Me.nudMayores.TabIndex = 53
        '
        'nudMenores
        '
        Me.nudMenores.Location = New System.Drawing.Point(432, 85)
        Me.nudMenores.Name = "nudMenores"
        Me.nudMenores.Size = New System.Drawing.Size(38, 26)
        Me.nudMenores.TabIndex = 54
        '
        'comprarBoleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(867, 475)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbdatosEntrada)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "comprarBoleto"
        Me.Text = "Form2"
        Me.gbdatosEntrada.ResumeLayout(False)
        Me.gbdatosEntrada.PerformLayout()
        CType(Me.pbCartelera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumeroBoleto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.nudMayores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMenores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbdatosEntrada As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BienvenidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarPelículaYTandasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPelículasYTandasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerAsientosDisponiblesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPagas As Label
    Friend WithEvents txtPagas As TextBox
    Friend WithEvents btnPagar As Button
    Friend WithEvents lblAsiento As Label
    Friend WithEvents txtAsiento As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents lblCosto As Label
    Friend WithEvents lbHorarioElegido As ListBox
    Friend WithEvents pbCartelera As PictureBox
    Friend WithEvents btnProcesar As Button
    Friend WithEvents nudNumeroBoleto As NumericUpDown
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblFechaEntrada As Label
    Friend WithEvents lblNumeroSala As Label
    Friend WithEvents lblNumeroBoletos As Label
    Friend WithEvents nudEdad As NumericUpDown
    Friend WithEvents dtpFechaEntrada As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumeroSala As TextBox
    Friend WithEvents VerTotalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPeliculaEstreno As Label
    Friend WithEvents lblPeliculaEstrenoSiNo As Label
    Friend WithEvents nudMenores As NumericUpDown
    Friend WithEvents nudMayores As NumericUpDown
End Class
