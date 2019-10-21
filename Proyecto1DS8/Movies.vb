Module Movies
    'Declaracion d evariables
    Private nombre1, nombre2, nombre3, nombre4 As String
    Private fecha1, fecha2, fecha3, fecha4 As Date
    Private foto1, foto2, foto3, foto4 As String
    Private horario1(), horario2(), horario3(), horario4() As String
    Private sala As Integer
    'Obtencion de datos para sala 1
    Public Sub Sala1(name1 As String, date1 As Date, image1 As String, schedule1() As String)
        nombre1 = name1
        fecha1 = date1
        foto1 = image1
        horario1 = schedule1
    End Sub
    'Obtencion de datos para sala 2
    Public Sub Sala2(name2 As String, date2 As Date, image2 As String, schedule2() As String)
        nombre2 = name2
        fecha2 = date2
        foto2 = image2
        horario2 = schedule2
    End Sub
    'Obtencion de datos para sala 3
    Public Sub Sala3(name3 As String, date3 As Date, image3 As String, schedule3() As String)
        nombre3 = name3
        fecha3 = date3
        foto3 = image3
        horario3 = schedule3
    End Sub
    'Obtencion de datos para sala 4
    Public Sub Sala4(name4 As String, date4 As Date, image4 As String, schedule4() As String)
        nombre4 = name4
        fecha4 = date4
        foto4 = image4
        horario4 = schedule4
    End Sub
    'Retorno de nombre de pelicula para sala 1 
    Public Function Nombres1() As String
        Return nombre1
    End Function
    'Retorno de nombre de pelicula para sala 2
    Public Function Nombres2() As String
        Return nombre2
    End Function
    'Retorno de nombre de pelicula para sala 3
    Public Function Nombres3() As String
        Return nombre3
    End Function
    'Retorno de nombre de pelicula para sala 4

    Public Function Nombres4() As String
        Return nombre4
    End Function
    'Retorno de fecha de pelicula para sala 1 
    Public Function Fechas1() As Date
        Return fecha1
    End Function
    'Retorno de fecha de pelicula para sala 2 
    Public Function Fechas2() As Date
        Return fecha2
    End Function
    'Retorno de fecha de pelicula para sala 3
    Public Function Fechas3() As Date
        Return fecha3
    End Function
    'Retorno de fecha de pelicula para sala 4
    Public Function Fechas4() As Date
        Return fecha4
    End Function
    'Retorno de imagen de pelicula para sala 1
    Public Function Fotos1() As String
        Return foto1
    End Function
    'Retorno de imagen de pelicula para sala 2
    Public Function Fotos2() As String
        Return foto2
    End Function
    'Retorno de imagen de pelicula para sala 3
    Public Function Fotos3() As String
        Return foto3
    End Function
    'Retorno de imagen de pelicula para sala 4
    Public Function Fotos4() As String
        Return foto4
    End Function

    'Retorno de horarios de pelicula para sala 1
    Public Function Horarios1() As String()
        Dim i As Long
        Dim tmpArray() As String

        ReDim tmpArray(horario1.Length)
        'For para recorrer el combo box
        For i = 0 To horario1.Length - 1
            tmpArray(i) = horario1(i)
        Next i

        Horarios1 = tmpArray
    End Function
    'Retorno de horarios de pelicula para sala 2
    Public Function Horarios2() As String()
        Dim i As Long
        Dim tmpArray() As String

        ReDim tmpArray(horario2.Length)
        'For para recorrer el combo box
        For i = 0 To horario2.Length - 1
            tmpArray(i) = horario2(i)
        Next i

        Horarios2 = tmpArray
    End Function
    'Retorno de horarios de pelicula para sala 3
    Public Function Horarios3() As String()
        Dim i As Long
        Dim tmpArray() As String

        ReDim tmpArray(horario3.Length)
        'For para recorrer el combo box
        For i = 0 To horario3.Length - 1
            tmpArray(i) = horario3(i)
        Next i

        Horarios3 = tmpArray
    End Function
    'Retorno de horarios de pelicula para sala 4
    Public Function Horarios4() As String()
        Dim i As Long
        Dim tmpArray() As String

        ReDim tmpArray(horario4.Length)
        'For para recorrer el combo box
        For i = 0 To horario4.Length - 1
            tmpArray(i) = horario4(i)
        Next i

        Horarios4 = tmpArray
    End Function
    'Retorno de numero sala 
    Public Sub NumeroSala(ByRef salita As Integer)
        sala = salita
    End Sub
    'Retorno de sala elegida
    Public Function SalaElegida() As Integer
        Return sala
    End Function
End Module
