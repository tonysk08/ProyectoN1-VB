<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Totales
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalSala4 = New System.Windows.Forms.Label()
        Me.lblTotalSala3 = New System.Windows.Forms.Label()
        Me.lblTotalSala2 = New System.Windows.Forms.Label()
        Me.lblTotalSala1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalRecaudado = New System.Windows.Forms.Label()
        Me.lblTotalAdulto = New System.Windows.Forms.Label()
        Me.lblTotalNinos = New System.Windows.Forms.Label()
        Me.lblTotalDineroCortesia = New System.Windows.Forms.Label()
        Me.lblTotalCortesia = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BienvenidaToolStripMenuItem, Me.IngresarPelículaYTandasToolStripMenuItem, Me.ConsultarPelículasYTandasToolStripMenuItem, Me.VerAsientosDisponiblesToolStripMenuItem, Me.VerTotalesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1423, 29)
        Me.MenuStrip1.TabIndex = 4
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total de sala 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total de sala 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total de sala 4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total de sala 3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalSala4)
        Me.GroupBox1.Controls.Add(Me.lblTotalSala3)
        Me.GroupBox1.Controls.Add(Me.lblTotalSala2)
        Me.GroupBox1.Controls.Add(Me.lblTotalSala1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 177)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(579, 239)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total ingresado por sala"
        '
        'lblTotalSala4
        '
        Me.lblTotalSala4.AutoSize = True
        Me.lblTotalSala4.Location = New System.Drawing.Point(251, 188)
        Me.lblTotalSala4.Name = "lblTotalSala4"
        Me.lblTotalSala4.Size = New System.Drawing.Size(15, 16)
        Me.lblTotalSala4.TabIndex = 12
        Me.lblTotalSala4.Text = "0"
        '
        'lblTotalSala3
        '
        Me.lblTotalSala3.AutoSize = True
        Me.lblTotalSala3.Location = New System.Drawing.Point(251, 139)
        Me.lblTotalSala3.Name = "lblTotalSala3"
        Me.lblTotalSala3.Size = New System.Drawing.Size(15, 16)
        Me.lblTotalSala3.TabIndex = 11
        Me.lblTotalSala3.Text = "0"
        '
        'lblTotalSala2
        '
        Me.lblTotalSala2.AutoSize = True
        Me.lblTotalSala2.Location = New System.Drawing.Point(251, 87)
        Me.lblTotalSala2.Name = "lblTotalSala2"
        Me.lblTotalSala2.Size = New System.Drawing.Size(15, 16)
        Me.lblTotalSala2.TabIndex = 10
        Me.lblTotalSala2.Text = "0"
        '
        'lblTotalSala1
        '
        Me.lblTotalSala1.AutoSize = True
        Me.lblTotalSala1.Location = New System.Drawing.Point(251, 41)
        Me.lblTotalSala1.Name = "lblTotalSala1"
        Me.lblTotalSala1.Size = New System.Drawing.Size(15, 16)
        Me.lblTotalSala1.TabIndex = 9
        Me.lblTotalSala1.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalRecaudado)
        Me.GroupBox2.Controls.Add(Me.lblTotalAdulto)
        Me.GroupBox2.Controls.Add(Me.lblTotalNinos)
        Me.GroupBox2.Controls.Add(Me.lblTotalDineroCortesia)
        Me.GroupBox2.Controls.Add(Me.lblTotalCortesia)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(700, 177)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(579, 239)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales"
        '
        'lblTotalRecaudado
        '
        Me.lblTotalRecaudado.AutoSize = True
        Me.lblTotalRecaudado.Location = New System.Drawing.Point(385, 201)
        Me.lblTotalRecaudado.Name = "lblTotalRecaudado"
        Me.lblTotalRecaudado.Size = New System.Drawing.Size(15, 16)
        Me.lblTotalRecaudado.TabIndex = 17
        Me.lblTotalRecaudado.Text = "0"
        '
        'lblTotalAdulto
        '
        Me.lblTotalAdulto.AutoSize = True
        Me.lblTotalAdulto.Location = New System.Drawing.Point(385, 165)
        Me.lblTotalAdulto.Name = "lblTotalAdulto"
        Me.lblTotalAdulto.Size = New System.Drawing.Size(15, 16)
        Me.lblTotalAdulto.TabIndex = 16
        Me.lblTotalAdulto.Text = "0"
        '
        'lblTotalNinos
        '
        Me.lblTotalNinos.AutoSize = True
        Me.lblTotalNinos.Location = New System.Drawing.Point(385, 124)
        Me.lblTotalNinos.Name = "lblTotalNinos"
        Me.lblTotalNinos.Size = New System.Drawing.Size(15, 16)
        Me.lblTotalNinos.TabIndex = 15
        Me.lblTotalNinos.Text = "0"
        '
        'lblTotalDineroCortesia
        '
        Me.lblTotalDineroCortesia.AutoSize = True
        Me.lblTotalDineroCortesia.Location = New System.Drawing.Point(385, 87)
        Me.lblTotalDineroCortesia.Name = "lblTotalDineroCortesia"
        Me.lblTotalDineroCortesia.Size = New System.Drawing.Size(15, 16)
        Me.lblTotalDineroCortesia.TabIndex = 14
        Me.lblTotalDineroCortesia.Text = "0"
        '
        'lblTotalCortesia
        '
        Me.lblTotalCortesia.AutoSize = True
        Me.lblTotalCortesia.Location = New System.Drawing.Point(385, 41)
        Me.lblTotalCortesia.Name = "lblTotalCortesia"
        Me.lblTotalCortesia.Size = New System.Drawing.Size(15, 16)
        Me.lblTotalCortesia.TabIndex = 13
        Me.lblTotalCortesia.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Total de adultos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(258, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total de dinero no ingresado por cortesia "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total de niños "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Total de clientes pase de cortesia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total recaudado"
        '
        'Totales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1423, 591)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Totales"
        Me.Text = "Totales"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BienvenidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarPelículaYTandasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPelículasYTandasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerAsientosDisponiblesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerTotalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotalSala4 As Label
    Friend WithEvents lblTotalSala3 As Label
    Friend WithEvents lblTotalSala2 As Label
    Friend WithEvents lblTotalSala1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTotalRecaudado As Label
    Friend WithEvents lblTotalAdulto As Label
    Friend WithEvents lblTotalNinos As Label
    Friend WithEvents lblTotalDineroCortesia As Label
    Friend WithEvents lblTotalCortesia As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
