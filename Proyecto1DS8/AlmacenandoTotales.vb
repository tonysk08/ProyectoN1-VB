Module AlmacenandoTotales
    Private montoTotal = 0, totalSala1 = 0, totalSala2 = 0, totalSala3 = 0, totalSala4 = 0
    Private mayorEdad = 0, menorEdad = 0, cantidadPaseCortesiaSi = 0, cantidadPaseCortesiaNo = 0

    Public Function returnMayorEdad(ByRef numeroMayores As Integer) As Integer
        mayorEdad = mayorEdad + numeroMayores
        Return mayorEdad
    End Function

    Public Function returnMenorEdad(ByRef numeroMenores As Integer) As Integer
        menorEdad = menorEdad + numeroMenores
        Return menorEdad
    End Function

    Public Function returnTotalSala1(ByRef numeroSala1 As Single) As Single
        totalSala1 = totalSala1 + numeroSala1
        Return totalSala1
    End Function

    Public Function returnTotalSala2(ByRef numeroSala2 As Single) As Single
        totalSala2 = totalSala2 + numeroSala2
        Return totalSala2
    End Function

    Public Function returnTotalSala3(ByRef numeroSala3 As Single) As Single
        totalSala3 = totalSala3 + numeroSala3
        Return totalSala3
    End Function

    Public Function returnTotalSala4(ByRef numeroSala4 As Single) As Single
        totalSala4 = totalSala4 + numeroSala4
        Return totalSala4
    End Function

    Public Function returnMontoTotal(ByRef numeroMontoTotal As Single) As Single
        montoTotal = montoTotal + numeroMontoTotal
        Return montoTotal
    End Function

    Public Function returnPaseCortesiaSi(ByRef cantidadPersonas As Integer) As Integer
        cantidadPaseCortesiaSi = cantidadPaseCortesiaSi + cantidadPersonas
        Return cantidadPersonas
    End Function

    Public Function returnPaseCortesiaNo(ByRef cantidadPersonas As Integer) As Integer
        cantidadPaseCortesiaNo = cantidadPaseCortesiaNo + cantidadPersonas
        Return cantidadPersonas
    End Function
End Module
