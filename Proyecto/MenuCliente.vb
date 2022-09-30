Public Class MenuCliente
    Private Sub btnComprarInmueble_Click(sender As Object, e As EventArgs) Handles btnComprarInmueble.Click
        RealizarAlquiler.Show()
    End Sub

    Private Sub btnRealizarAlquiler_Click(sender As Object, e As EventArgs) Handles btnRealizarAlquiler.Click
        RealizarCompra.Show()
    End Sub
End Class