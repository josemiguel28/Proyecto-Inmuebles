Imports System.Data.SqlClient

Public Class RealizarCompra
    Public Validar As New VALIDACION_IDPERSONA  'instancia de la clase 
    Public NO_Alquiler As New ConsultaNO

    Sub Limpiar()
        txtNombreInmueble.Clear()
        txtIDInmueble.Clear()
        txtCiudad.Clear()
        txtDireccion.Clear()
        txtMetros.Clear()
        txtPrecio.Clear()
    End Sub

    Private Sub btnBuscarInmueble_Click(sender As Object, e As EventArgs) Handles btnBuscarInmueble.Click
        MostrarInmuebleCompra.ShowDialog()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region
        Dim mensaje As MsgBoxResult


        If txtNoIdentidad.Text.Equals("") = False And txtIDInmueble.Text.Equals("") = False And txtNombreInmueble.Text.Equals("") = False And txtMetros.Text.Equals("") = False And txtDireccion.Text.Equals("") = False And txtPrecio.Text.Equals("") = False Then

            If Validar.personaRegistrada(txtNoIdentidad.Text) = True Then ''valida si la persona  existe en la bd

                mensaje = MsgBox("Desea Realizar esta Compra?", vbYesNo, "Comprar")
                DetallesCompra.Show()

            Else
                MsgBox("Cliente no registrado")
            End If
        Else
            MsgBox("Todos los campos deben ser rellenados")
        End If

    End Sub

    Private Sub RealizarCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIDCompra.Text = NO_Alquiler.consultaIDCompra()

    End Sub
End Class