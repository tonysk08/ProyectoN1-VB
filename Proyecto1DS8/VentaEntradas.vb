Module VentaEntradas
    Private asientos1 = 30, asientos2 = 30, asientos3 = 30, asientos4 = 30


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

        If DifDias <= 7 Then
            Return "Si"
        ElseIf DifDias > 7 Then
            Return "No"
        Else
            Return "Error"
        End If
    End Function

    Public Sub numAsiento(asientos As Single)
        Dim SalaElegida As Integer = Movies.SalaElegida()

        If SalaElegida = 1 Then
            asientos1 = asientos1 - asientos
        ElseIf SalaElegida = 2 Then
            asientos2 = asientos2 - asientos
        ElseIf SalaElegida = 3 Then
            asientos3 = asientos3 - asientos
        Else
            asientos4 = asientos4 - asientos
        End If
    End Sub

    Public Function asiento1() As Single
        Return asientos1
    End Function
    Public Function asiento2() As Single
        Return asientos2
    End Function
    Public Function asiento3() As Single
        Return asientos3
    End Function
    Public Function asiento4() As Single
        Return asientos4
    End Function
End Module
