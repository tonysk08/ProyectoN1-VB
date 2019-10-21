Public Class bienvenida

    'Carga el GIF que se usa en la pantalla bienvenida al cargar esta y se define el modo de tamaño
    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbBienvenida.Image = Image.FromFile(Application.StartupPath & "\animacionP.gif")
        pbBienvenida.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    'Indica que se abrirá cuando se presione dicho botón
    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        IngresarPeliculas.Show()
        Me.Hide()

    End Sub
End Class
