Module VentaEntradas
    Public Function Estreno() As String
        Dim SalaElegida As Integer = Movies.SalaElegida()
        Dim fechaEstreno, fechaPelicula As Date
        Dim DifDias As Integer

        If SalaElegida = 1 Then
            fechaEstreno = Movies.Fechas1()
        ElseIf SalaElegida = 2 Then
            fechaEstreno = Movies.Fechas2()
        ElseIf SalaElegida = 3 Then
            fechaEstreno = Movies.Fechas3()
        ElseIf SalaElegida = 4 Then
            fechaEstreno = Movies.Fechas4()
        End If

        fechaPelicula = DateTime.Now()

        DifDias = DateDiff("d", fechaEstreno, fechaPelicula)

        Return CStr(DifDias)
    End Function


End Module
