Public Class Totales
    'Declaracion de variables
    Private montoTotal = 0
    Private menorEdad = 0
    Private mayorEdad = 0
    Private totalSala1 = 0
    Private totalSala2 = 0
    Private totalSala3 = 0
    Private totalSala4 = 0
    'Boton para ir a pantalla de bienvenida
    Private Sub BienvenidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BienvenidaToolStripMenuItem.Click
        bienvenida.Show()
        Me.Close()
    End Sub
    'Boton para ir a pantalla de ingresar pelicula
    Private Sub IngresarPelículaYTandasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarPelículaYTandasToolStripMenuItem.Click
        IngresarPeliculas.Show()
        Me.Close()
    End Sub
    'Boton para ir a pantalla de consultar pelicula
    Private Sub ConsultarPelículasYTandasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPelículasYTandasToolStripMenuItem.Click
        ConsultarPelicula.Show()
        Me.Close()
    End Sub
    'Boton para ir a pantalla de ver asientos disponibles
    Private Sub VerAsientosDisponiblesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerAsientosDisponiblesToolStripMenuItem.Click
        RevisarAsientos.Show()
        Me.Close()
    End Sub
    'Evento click para decir que ya se encuentra en la ventana seleccionada
    Private Sub VerTotalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTotalesToolStripMenuItem.Click
        MsgBox("Ya estás en esta ventana")
    End Sub
    'Evento load
    Private Sub Totales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Aqui se cargan los totales por sala generado, generado total, total de clientes adultos, total de clientes niños, total de cortesias, total de dinero perdido por cortesias
        lblTotalSala1.Text = AlmacenandoTotales.returnTotalSala1(0) & "$"
        lblTotalSala2.Text = AlmacenandoTotales.returnTotalSala2(0) & "$"
        lblTotalSala3.Text = AlmacenandoTotales.returnTotalSala3(0) & "$"
        lblTotalSala4.Text = AlmacenandoTotales.returnTotalSala4(0) & "$"
        lblTotalAdulto.Text = AlmacenandoTotales.returnMayorEdad(0) & " clientes adultos"
        lblTotalNinos.Text = AlmacenandoTotales.returnMenorEdad(0) & " clientes niños"
        lblTotalRecaudado.Text = AlmacenandoTotales.returnMontoTotal(0) & "$"
        lblTotalCortesia.Text = AlmacenandoTotales.returnPaseCortesiaSi(0) & " personas"
        lblTotalDineroCortesia.Text = AlmacenandoTotales.returnDineroCortesia(0) & "$"
    End Sub

End Class