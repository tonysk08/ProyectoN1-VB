Public Class ConsultarPelicula

    Dim i1, i2, i3, i4 As Integer
    Private Sub BienvenidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BienvenidaToolStripMenuItem.Click
        bienvenida.Show()
        Me.Hide()
    End Sub

    Private Sub IngresarPelículaYTandasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarPelículaYTandasToolStripMenuItem.Click
        IngresarPeliculas.Show()
        Me.Hide()
    End Sub

    Private Sub ConsultarPelículasYTandasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPelículasYTandasToolStripMenuItem.Click
        MsgBox("Ya estás en esta ventana")
    End Sub

    Private Sub VerAsientosDisponiblesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerAsientosDisponiblesToolStripMenuItem.Click
        RevisarAsientos.Show()
        Me.Hide()
    End Sub

    Private Sub BtnComprarTicketSala1_Click(sender As Object, e As EventArgs) Handles btnComprarTicketSala1.Click
        Movies.NumeroSala(1)
        comprarBoleto.Show()
        Me.Hide()
    End Sub

    Private Sub BtnComprarTicketSala2_Click(sender As Object, e As EventArgs) Handles btnComprarTicketSala2.Click
        Movies.NumeroSala(2)
        comprarBoleto.Show()
        Me.Hide()
    End Sub

    Private Sub BtnComprarTicketSala3_Click(sender As Object, e As EventArgs) Handles btnComprarTicketSala3.Click
        Movies.NumeroSala(3)
        comprarBoleto.Show()
        Me.Hide()
    End Sub

    Private Sub BtnComprarTicketSala4_Click(sender As Object, e As EventArgs) Handles btnComprarTicketSala4.Click
        Movies.NumeroSala(4)
        comprarBoleto.Show()
        Me.Hide()
    End Sub

    Private Sub VerTotalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTotalesToolStripMenuItem.Click
        Totales.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Click(sender As Object, e As EventArgs) Handles gbSala1.Click
        bienvenida.Show()
        Me.Hide()
    End Sub

    Private Sub ConsultarPelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carga de fotos de las películas desde el módulo Movies
        pbConsultarImagenPeliculaSala1.ImageLocation = Movies.Fotos1
        pbConsultarImagenPeliculaSala2.ImageLocation = Movies.Fotos2
        pbConsultarImagenPeliculaSala3.ImageLocation = Movies.Fotos3
        pbConsultarImagenPeliculaSala4.ImageLocation = Movies.Fotos4

        'Carga del nombre de las películas desde el módulo Movies
        lblConsultarNombrePeliculaSala1.Text = Movies.Nombres1
        lblConsultarNombrePeliculaSala2.Text = Movies.Nombres2
        lblConsultarNombrePeliculaSala3.Text = Movies.Nombres3
        lblConsultarNombrePeliculaSala4.Text = Movies.Nombres4

        'Carga de los horarios de las películas desde el módulo Movies
        For i1 = 0 To Movies.Horarios1().Length - 2
            lbConsultarHorarioSala1.Items.Add(Movies.Horarios1(i1).ToString())
        Next i1

        For i2 = 0 To Movies.Horarios2().Length - 2
            lbConsultarHorarioSala2.Items.Add(Movies.Horarios2(i2).ToString())
        Next i2

        For i3 = 0 To Movies.Horarios3().Length - 2
            lbConsultarHorarioSala3.Items.Add(Movies.Horarios3(i3).ToString())
        Next i3

        For i4 = 0 To Movies.Horarios4().Length - 2
            lbConsultarHorarioSala4.Items.Add(Movies.Horarios4(i4).ToString())
        Next i4

    End Sub
End Class