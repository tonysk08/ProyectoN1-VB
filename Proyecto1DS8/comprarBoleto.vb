Public Class comprarBoleto
    Private montoGanado As Double
    Private menorEdad, mayorEdad As Single
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
        If (txtPagas.Text = "0") Then
            MsgBox("Su pago no puede ser 0")
        Else
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
            End If

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

            'Numero de asientos
            VentaEntradas.numAsiento(nudNumeroBoleto.Value)

            'Numero de edad
            mayorEdad = nudMayores.Value
            menorEdad = nudMenores.Value

            'Monto generado 
            montoGanado = montoGanado + total
        End If
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
        Dim costo As Double = 0
        If (nudMayores.Value + nudMenores.Value = nudNumeroBoleto.Value) Then
            costo = costo + (nudMayores.Value * 4)
            costo = costo + (nudMenores.Value * 2)
        Else
            MsgBox("Verifique que la cantidad de boletos coincida con el numero de boleto para menores y mayores")
        End If

        txtCosto.Text = costo

    End Sub

    Function ValidacionesVarias() As Boolean
        Dim paso As Boolean = False
        If (nudNumeroBoleto.Value <> 0) Then
            paso = True
        End If
        Return paso
    End Function

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Call validarEdad()
        If (ValidacionesVarias() And nudEdad.Value <> 0 And txtCosto.Text <> 0) Then
            btnPagar.Show()
            lblPagas.Show()
            txtPagas.Show()
            txtCosto.Show()
            lblCosto.Show()
        Else
            MsgBox("Rellene todos los datos solicitados")
        End If
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

    Public Function monto() As Double
        Return montoGanado
    End Function

    Public Function mayoresEdad() As Single
        Return mayorEdad
    End Function

    Public Function menoresEdad() As Single
        Return menorEdad
    End Function

End Class