Public Class Factura

    'En esta función que se llama en el formulario comprarBoleto se asignan los valores correspondientes al formulario Factura
    Function guardar(nombre As String, fecha As String, dia As String, sala As String, monto As Double, pago As Double, devolucion As Double)
        lblMostrarPelicula.Text = nombre
        lblMostrarFecha.Text = fecha
        lblMostrarDiaCorrespondiente.Text = dia
        lblMostrarNumSala.Text = sala
        lblMostrarMontoPagar.Text = monto & "$"
        lblMostrarPagoRealizado.Text = pago & "$"
        lblMostrarDevolucion.Text = devolucion & "$"
    End Function

    'Al darle click a Aceptar se muestra la pantalla Consultar Película y se cierran Factura y comprarBoleto para que los métodos que se usan al cargarlas se vuelvan a ejecutar
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ConsultarPelicula.Show()
        comprarBoleto.Close()
        Me.Close()
    End Sub
End Class