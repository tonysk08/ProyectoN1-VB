Public Class RevisarAsientos
    Private Sub BienvenidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BienvenidaToolStripMenuItem.Click
        bienvenida.Show()
        Me.Hide()
    End Sub

    Private Sub IngresarPelículaYTandasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarPelículaYTandasToolStripMenuItem.Click
        IngresarPeliculas.Show()
        Me.Hide()
    End Sub

    Private Sub ConsultarPelículasYTandasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPelículasYTandasToolStripMenuItem.Click
        ConsultarPelicula.Show()
        Me.Close()
    End Sub

    Private Sub VerAsientosDisponiblesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerAsientosDisponiblesToolStripMenuItem.Click
        MsgBox("Ya estás en esta ventana")
    End Sub

    Private Sub VerTotalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTotalesToolStripMenuItem.Click
        Totales.Show()
        Me.Hide()
    End Sub

    Private Sub RevisarAsientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAsientos1.Text = VentaEntradas.asiento1
        lblAsientos2.Text = VentaEntradas.asiento2
        lblAsientos3.Text = VentaEntradas.asiento3
        lblAsientos4.Text = VentaEntradas.asiento4
    End Sub
End Class