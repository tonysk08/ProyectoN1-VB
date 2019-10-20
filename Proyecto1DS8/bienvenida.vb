Public Class bienvenida
    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbBienvenida.Image = Image.FromFile(Application.StartupPath & "\animacionP.gif")
        pbBienvenida.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        IngresarPeliculas.Show()
        Me.Hide()

    End Sub
End Class
