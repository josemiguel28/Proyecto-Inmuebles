Public Class MenuC
    Private Sub MenuC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarSubMenu()
    End Sub

    Private Sub OcultarSubMenu()
        PanelSubMenuC.Visible = False
        PanelSubMenuAdmin.Visible = False
    End Sub
    Private Sub MostrarSUbMenu(submenu As Panel)
        If submenu.Visible = False Then
            OcultarSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MostrarSUbMenu(PanelSubMenuC)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MostrarSUbMenu(PanelSubMenuAdmin)
    End Sub

    Private currentform As Form
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RealizarCompra.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RealizarAlquiler.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AbrirForm(New Gestionar_Inmuebles())
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AbrirForm(New Compras())
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AbrirForm(New GestionDeAlquileres())
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AbrirForm(New GestionAlquileresPagos())
    End Sub
End Class