Public Class MenuA
    Private Sub MenuA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarSubMenu()

    End Sub
    Private Sub OcultarSubMenu()
        PanelSubMenuAlquileres.Visible = False
        PanelSubmenuCompras.Visible = False
        PanelSubMenuInmuebles.Visible = False
        PanelSubMenuPersonas.Visible = False
        PanelSubMenuUsuarios.Visible = False
    End Sub

    Private Sub MostrarSUbMenu(submenu As Panel)
        If submenu.Visible = False Then
            OcultarSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btnGestionInmuebles_Click(sender As Object, e As EventArgs) Handles btnGestionInmuebles.Click
        MostrarSUbMenu(PanelSubMenuInmuebles)
    End Sub

    Private Sub btnPersonas_Click(sender As Object, e As EventArgs) Handles btnPersonas.Click
        MostrarSUbMenu(PanelSubMenuPersonas)
    End Sub

    Private Sub btnAlquileres_Click(sender As Object, e As EventArgs) Handles btnAlquileres.Click
        MostrarSUbMenu(PanelSubMenuAlquileres)
    End Sub

    Private Sub btnGestionCompras_Click(sender As Object, e As EventArgs) Handles btnGestionCompras.Click
        MostrarSUbMenu(PanelSubmenuCompras)
    End Sub

    Private Sub btnGestionUsuarios_Click(sender As Object, e As EventArgs) Handles btnGestionUsuarios.Click
        MostrarSUbMenu(PanelSubMenuUsuarios)
    End Sub

    Private Sub btnGarajes_Click(sender As Object, e As EventArgs) Handles btnGarajes.Click
        GestionGaraje.Show()
        OcultarSubMenu()
    End Sub

    Private Sub btnLocal_Click(sender As Object, e As EventArgs) Handles btnLocal.Click
        Gestionar_Inmuebles.Show()
        OcultarSubMenu()
    End Sub

    Private Sub btnPisos_Click(sender As Object, e As EventArgs) Handles btnPisos.Click
        Gestion_Pisos.Show()
        OcultarSubMenu()
    End Sub

    Private Sub btnMPersonas_Click(sender As Object, e As EventArgs) Handles btnMPersonas.Click
        Gestionar_Personas.Show()
        OcultarSubMenu()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        GestionClientes.Show()
        OcultarSubMenu()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        GestionarEmpleados.Show()
        OcultarSubMenu()
    End Sub

    Private Sub btnGAlquileres_Click(sender As Object, e As EventArgs) Handles btnGAlquileres.Click
        AbrirForm(New GestionDeAlquileres())
        OcultarSubMenu()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AbrirForm(New GestionAlquileresPagos())
        OcultarSubMenu()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AbrirForm(New Compras())
        OcultarSubMenu()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        AbrirForm(New GestionUsuarios())
        OcultarSubMenu()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirForm(New GestionTipoUsuario())
        OcultarSubMenu()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Bitacora.Show()
        OcultarSubMenu()
    End Sub

    Private currentform As Form = Nothing
    Private Sub AbrirForm(childform As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        PanelFormHijo.Controls.Add(childform)
        PanelFormHijo.Tag = childform
        childform.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirForm(New Gestion_Local())
        OcultarSubMenu()
    End Sub
End Class