Public Class Factura
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function guardar(nombre As String, fecha As String, dia As String, sala As String, monto As Double, pago As Double, devolucion As Double)
        lblMostrarPelicula.Text = nombre
        lblMostrarFecha.Text = fecha
        lblMostrarDiaCorrespondiente.Text = dia
        lblMostrarNumSala.Text = sala
        lblMostrarMontoPagar.Text = monto
        lblMostrarPagoRealizado.Text = pago
        lblMostrarDevolucion.Text = devolucion
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ConsultarPelicula.Show()
        comprarBoleto.Close()
        Me.Close()
    End Sub
End Class