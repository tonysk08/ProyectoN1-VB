Public Class Totales
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
        Me.Hide()
    End Sub

    Private Sub VerAsientosDisponiblesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerAsientosDisponiblesToolStripMenuItem.Click
        RevisarAsientos.Show()
        Me.Hide()
    End Sub

    Private Sub VerTotalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTotalesToolStripMenuItem.Click
        MsgBox("Ya estás en esta ventana")
    End Sub
End Class