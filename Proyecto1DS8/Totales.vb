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

    Private Sub Totales_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        montoTotal = montoTotal + comprarBoleto.monto
        mayorEdad = mayorEdad + comprarBoleto.mayoresEdad
        menorEdad = mayorEdad + comprarBoleto.mayoresEdad


        If Movies.SalaElegida = 1 Then
            totalSala1 = totalSala1 + comprarBoleto.monto
        ElseIf Movies.SalaElegida = 2 Then
            totalSala2 = totalSala2 + comprarBoleto.monto
        ElseIf Movies.SalaElegida = 3 Then
            totalSala3 = totalSala3 + comprarBoleto.monto
        ElseIf Movies.SalaElegida = 4 Then
            totalSala4 = totalSala4 + comprarBoleto.monto
        End If

        lblTotalSala1.Text = totalSala1
        lblTotalSala2.Text = totalSala2
        lblTotalSala3.Text = totalSala3
        lblTotalSala4.Text = totalSala4
        lblTotalAdulto.Text = mayorEdad
        lblTotalNinos.Text = menorEdad
        lblTotalRecaudado.Text = montoTotal

    End Sub
End Class