<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RevisarAsientos
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BienvenidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarPelículaYTandasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPelículasYTandasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerAsientosDisponiblesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerTotalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(861, 29)
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
        'RevisarAsientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "RevisarAsientos"
        Me.Text = "RevisarAsientos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BienvenidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarPelículaYTandasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPelículasYTandasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerAsientosDisponiblesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerTotalesToolStripMenuItem As ToolStripMenuItem
End Class
