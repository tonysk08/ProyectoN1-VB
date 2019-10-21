Public Class Totales
    Private montoTotal = 0
    Private menorEdad = 0
    Private mayorEdad = 0
    Private totalSala1 = 0
    Private totalSala2 = 0
    Private totalSala3 = 0
    Private totalSala4 = 0
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





    'Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    'End Sub
End Class