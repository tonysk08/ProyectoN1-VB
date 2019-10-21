Public Class RevisarAsientos
    'Boton para ir a pantalla de bienvenida
    Private Sub BienvenidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BienvenidaToolStripMenuItem.Click
        bienvenida.Show()
        Me.Hide()
    End Sub
    'Boton para ir a pantalla de ingresar peliculas
    Private Sub IngresarPelículaYTandasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarPelículaYTandasToolStripMenuItem.Click
        IngresarPeliculas.Show()
        Me.Hide()
    End Sub
    'Boton para ir a pantalla de consultar pelicula
    Private Sub ConsultarPelículasYTandasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPelículasYTandasToolStripMenuItem.Click
        ConsultarPelicula.Show()
        Me.Close()
    End Sub
    'Evento click para decir que ya estas en la ventana seleccionada
    Private Sub VerAsientosDisponiblesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerAsientosDisponiblesToolStripMenuItem.Click
        MsgBox("Ya estás en esta ventana")
    End Sub
    'Evento para mostrar pantalla
    Private Sub VerTotalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTotalesToolStripMenuItem.Click
        Totales.Show()
        Me.Hide()
    End Sub
    'Evento load
    Private Sub RevisarAsientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Aqui se cargan los asientos que quedan disponibles por sala
        lblAsientos1.Text = VentaEntradas.asiento1
        lblAsientos2.Text = VentaEntradas.asiento2
        lblAsientos3.Text = VentaEntradas.asiento3
        lblAsientos4.Text = VentaEntradas.asiento4
    End Sub
End Class