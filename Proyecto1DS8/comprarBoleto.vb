Public Class comprarBoleto
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
        RevisarAsientos.Show()
        Me.Hide()
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Dim costo, pagas As Double
        Dim total As Double
        Dim movieName, movieDate, movieHour, movieDay As String
        movieName = ""
        movieHour = lbHorarioElegido.SelectedItem.ToString()
        movieDate = dtpFechaEntrada.Value.ToString("dd/MM/yyyy") & " " & movieHour
        movieDay = dtpFechaEntrada.Value.ToString("dddd")
        costo = txtCosto.Text
        pagas = txtPagas.Text
        total = pagas - costo
        If total < 0 Then
            MsgBox("Monto insuficiente.")
        ElseIf pagas > costo Then
            MsgBox("Pago efectuado." & total)
        End If
        'Validacion para el nombre


        If Movies.SalaElegida = 1 Then
            movieName = Movies.Nombres1()
        ElseIf Movies.SalaElegida = 2 Then
            movieName = Movies.Nombres2()
        ElseIf Movies.SalaElegida = 3 Then
            movieName = Movies.Nombres3()
        ElseIf Movies.SalaElegida = 4 Then
            movieName = Movies.Nombres4()
        End If

        'CambiarHorarios()
        Factura.guardar(movieName, movieDate, movieDay, "Sala " & Movies.SalaElegida, costo, pagas, total)
        Factura.Show()
    End Sub

    Sub CambiarHorarios()
        If Movies.SalaElegida = 1 Then
            For i1 = 0 To Movies.Horarios1().Length - 2
                lbHorarioElegido.Items.Add(Movies.Horarios1(i1).ToString())
            Next i1
        ElseIf Movies.SalaElegida = 2 Then
            For i1 = 0 To Movies.Horarios2().Length - 2
                lbHorarioElegido.Items.Add(Movies.Horarios2(i1).ToString())
            Next i1
        ElseIf Movies.SalaElegida = 3 Then
            For i1 = 0 To Movies.Horarios3().Length - 2
                lbHorarioElegido.Items.Add(Movies.Horarios3(i1).ToString())
            Next i1
        ElseIf Movies.SalaElegida = 4 Then
            For i1 = 0 To Movies.Horarios4().Length - 2
                lbHorarioElegido.Items.Add(Movies.Horarios4(i1).ToString())
            Next i1
        End If
    End Sub

    'Valida la edad
    Sub validarEdad()
        Dim costo As Double
        Dim seleccion As String
        Dim edad As Integer = nudEdad.Value
        seleccion = Movies.SalaElegida
        If seleccion = 1 Or seleccion = 2 Or seleccion = 4 Then
            If edad >= 1 And edad <= 12 Then
                costo = nudNumeroBoleto.Value * 2
            ElseIf seleccion = 1 Or seleccion = 2 Or seleccion = 4 Then
                If edad > 12 Then
                    costo = nudNumeroBoleto.Value * 4
                End If
            End If
        ElseIf seleccion = 3 And edad >= 1 And edad <= 12 Then
            costo = nudNumeroBoleto.Value * 5
        ElseIf seleccion = 3 And edad > 12 Then
            costo = nudNumeroBoleto.Value * 8
        End If
        txtCosto.Text = costo
    End Sub

    Function ValidacionesVarias() As Boolean

        Return True
    End Function

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Call validarEdad()
        btnPagar.Show()
        lblPagas.Show()
        txtPagas.Show()
        txtCosto.Show()
        lblCosto.Show()
    End Sub

    Private Sub ComprarBoleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sala As Integer
        sala = Movies.SalaElegida()
        'Inhabilita la opcion de agregar pelicula
        DisableAddMovies.IngresarPeliculasEnable(True)
        dtpFechaEntrada.Value = DateTime.Now()
        lblPeliculaEstrenoSiNo.Text = VentaEntradas.Estreno()

        txtNumeroSala.Text = "Sala " & sala

        Select Case sala
            Case 1
                lbHorarioElegido.Items.Clear()
                pbCartelera.ImageLocation = Movies.Fotos1
            Case 2
                lbHorarioElegido.Items.Clear()
                pbCartelera.ImageLocation = Movies.Fotos2
            Case 3
                lbHorarioElegido.Items.Clear()
                pbCartelera.ImageLocation = Movies.Fotos3
            Case 4
                lbHorarioElegido.Items.Clear()
                pbCartelera.ImageLocation = Movies.Fotos4
        End Select

        CambiarHorarios()
        'Mostrar los labels
        lblEdad.Show()
        lblFechaEntrada.Show()
        lblNumeroBoletos.Show()
        lblAsiento.Show()

        'Mostrar las entradas
        nudEdad.Show()
        nudNumeroBoleto.Show()
        dtpFechaEntrada.Show()
        txtAsiento.Show()
        lbHorarioElegido.SelectedIndex = 0
    End Sub

End Class