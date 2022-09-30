Public Class MenuAdmin
    Private Sub btnGestionarPersonas_Click(sender As Object, e As EventArgs) Handles btnGestionarPersonas.Click
        Gestionar_Personas.Show()
    End Sub

    Private Sub btnGestionarInmuebles_Click(sender As Object, e As EventArgs) Handles btnGestionarInmuebles.Click
        Gestionar_Inmuebles.show()
    End Sub

    Private Sub btnVerCompras_Click(sender As Object, e As EventArgs) Handles btnVerCompras.Click
        Compras.Show()
    End Sub

    Private Sub btnGarajes_Click(sender As Object, e As EventArgs) Handles btnGarajes.Click
        GestionGaraje.Show()
    End Sub

    Private Sub btnLocal_Click(sender As Object, e As EventArgs) Handles btnLocal.Click
        Gestion_Local.Show()
    End Sub

    Private Sub btnPisos_Click(sender As Object, e As EventArgs) Handles btnPisos.Click
        Gestion_Pisos.Show()
    End Sub

    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class