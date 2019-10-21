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
        Me.Close()
    End Sub

    Private Sub IngresarPelículaYTandasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarPelículaYTandasToolStripMenuItem.Click
        IngresarPeliculas.Show()
        Me.Close()
    End Sub

    Private Sub ConsultarPelículasYTandasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPelículasYTandasToolStripMenuItem.Click
        ConsultarPelicula.Show()
        Me.Close()
    End Sub

    Private Sub VerAsientosDisponiblesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerAsientosDisponiblesToolStripMenuItem.Click
        RevisarAsientos.Show()
        Me.Close()
    End Sub

    Private Sub VerTotalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTotalesToolStripMenuItem.Click
        MsgBox("Ya estás en esta ventana")
    End Sub

    Private Sub Totales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTotalSala1.Text = AlmacenandoTotales.returnTotalSala1(0) & "$"
        lblTotalSala2.Text = AlmacenandoTotales.returnTotalSala2(0) & "$"
        lblTotalSala3.Text = AlmacenandoTotales.returnTotalSala3(0) & "$"
        lblTotalSala4.Text = AlmacenandoTotales.returnTotalSala4(0) & "$"
        lblTotalAdulto.Text = AlmacenandoTotales.returnMayorEdad(0) & " clientes adultos"
        lblTotalNinos.Text = AlmacenandoTotales.returnMenorEdad(0) & " clientes niños"
        lblTotalRecaudado.Text = AlmacenandoTotales.returnMontoTotal(0) & "$"
    End Sub

End Class