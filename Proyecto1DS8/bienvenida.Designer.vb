<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bienvenida
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
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.pbBienvenida = New System.Windows.Forms.PictureBox()
        CType(Me.pbBienvenida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Transparent
        Me.btnSiguiente.Font = New System.Drawing.Font("MS PGothic", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(247, 343)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(225, 57)
        Me.btnSiguiente.TabIndex = 0
        Me.btnSiguiente.Text = "Siguiente ->"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'pbBienvenida
        '
        Me.pbBienvenida.Location = New System.Drawing.Point(-1, 0)
        Me.pbBienvenida.Name = "pbBienvenida"
        Me.pbBienvenida.Size = New System.Drawing.Size(738, 423)
        Me.pbBienvenida.TabIndex = 1
        Me.pbBienvenida.TabStop = False
        '
        'bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(737, 422)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.pbBienvenida)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "bienvenida"
        Me.Text = "Bienvenida"
        CType(Me.pbBienvenida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSiguiente As Button
    Friend WithEvents pbBienvenida As PictureBox
End Class
