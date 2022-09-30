Imports System.Data.SqlClient

Public Class DetallesCompra

    Public NO_Alquiler As New ConsultaNO

    Sub Limpiar()
        RealizarCompra.txtNombreInmueble.Clear()
        RealizarCompra.txtIDInmueble.Clear()
        RealizarCompra.txtCiudad.Clear()
        RealizarCompra.txtDireccion.Clear()
        RealizarCompra.txtMetros.Clear()
        RealizarCompra.txtPrecio.Clear()
    End Sub
    Private Sub DetallesCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'paso lo que tiene el form de alquiler a los textbox
        txtIDCompra.Text = RealizarCompra.txtIDCompra.Text
        txtNombreInmueble.Text = RealizarCompra.txtNombreInmueble.Text
        txtIDPersona.Text = RealizarCompra.txtNoIdentidad.Text
        txtCostoInmueble.Text = RealizarCompra.txtPrecio.Text

        txtTotal.Text = RealizarCompra.txtPrecio.Text
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region
        Dim mensaje As MsgBoxResult
        Dim insertar As String = "insert into Compras (valor,fecha,cod_inmueble,id_persona)
         values(@valor,@fecha,@cod_inmueble,@id_persona)"

        Dim actualizarInmueble As String = "update Inmuebles set estado=@estado where cod_inmueble = @cod_inmueble"
        Dim estado As String
        estado = "Inmueble Comprado"

        mensaje = MsgBox("Desea Realizar esta Compra?", vbYesNo, "Compra")

        If (mensaje = vbYes) Then
#Region "Insertar"
            Dim inserta_compra As New SqlCommand(insertar, conexion)
            inserta_compra.Parameters.AddWithValue("@valor", RealizarCompra.txtPrecio.Text)
            inserta_compra.Parameters.AddWithValue("@fecha", Date.Now)
            inserta_compra.Parameters.AddWithValue("@cod_inmueble", RealizarCompra.txtIDInmueble.Text)
            inserta_compra.Parameters.AddWithValue("@id_persona", RealizarCompra.txtNoIdentidad.Text)

            inserta_compra.ExecuteNonQuery()

            Dim actualizaInmueble As New SqlCommand(actualizarInmueble, conexion)
            actualizaInmueble.Parameters.AddWithValue("@cod_inmueble", RealizarCompra.txtIDInmueble.Text)
            actualizaInmueble.Parameters.AddWithValue("@estado", estado)
            actualizaInmueble.ExecuteNonQuery()

            MsgBox("Compra realizada correctamente")
            RealizarCompra.txtIDCompra.Text = NO_Alquiler.consultaIDCompra()
            Limpiar()

#End Region

        Else
            MsgBox("Compra no realizada")
        End If
    End Sub
End Class