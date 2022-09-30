Imports System.Data.SqlClient

Public Class PagoAlquiler
    Public NO_Alquiler As New ConsultaNO

    Sub Limpiar()
        RealizarAlquiler.txtNombreInmueble.Clear()
        RealizarAlquiler.txtIDInmueble.Clear()
        RealizarAlquiler.txtCiudad.Clear()
        RealizarAlquiler.txtDireccion.Clear()
        RealizarAlquiler.txtMetros.Clear()
        RealizarAlquiler.txtPrecio.Clear()
    End Sub

    Private Sub PagoAlquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'paso lo que tiene el form de alquiler a los textbox
        txtIDAlquiler.Text = RealizarAlquiler.txtIDAlquiler.Text
        txtNombreInmueble.Text = RealizarAlquiler.txtNombreInmueble.Text
        txtIDPersona.Text = RealizarAlquiler.txtNoIdentidad.Text
        txtCostoInmueble.Text = RealizarAlquiler.txtPrecio.Text
        txtCODEmpleado.Text = RealizarAlquiler.txtCODEmpleado.Text

        txtTotal.Text = RealizarAlquiler.txtPrecio.Text

    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region
        Dim mensaje As MsgBoxResult
        'consulta para la tabla de alquileres
        Dim insertar As String = "insert into alquiler (cod_inmueble,cod_empleado,id_persona,estado)
         values(@cod_inmueble,@cod_empleado,@id_persona,@estado)"

        'consulta para la tabla pagos
        Dim insertarP As String = "insert into pagos (fecha,valor,numero_alquiler)
         values(@fecha,@valor,@numero_alquiler)"

        Dim estado As String
        estado = "En Curso"

        mensaje = MsgBox("Desea Realizar esta Alquiler?", vbYesNo, "Alquiler")

        If (mensaje = vbYes) Then
#Region "Insertar en la tabla alquileres"
            Dim inserta_alquiler As New SqlCommand(insertar, conexion)
            inserta_alquiler.Parameters.AddWithValue("@cod_inmueble", RealizarAlquiler.txtIDInmueble.Text)
            inserta_alquiler.Parameters.AddWithValue("@cod_empleado", txtCODEmpleado.Text)
            inserta_alquiler.Parameters.AddWithValue("@id_persona", txtIDPersona.Text)
            inserta_alquiler.Parameters.AddWithValue("@estado", estado)

            inserta_alquiler.ExecuteNonQuery()

            ''inserta en la tabla pagos alquiler
            Dim inserta_pago As New SqlCommand(insertarP, conexion)
            inserta_pago.Parameters.AddWithValue("@fecha", Date.Now())
            inserta_pago.Parameters.AddWithValue("@valor", txtTotal.Text)
            inserta_pago.Parameters.AddWithValue("@numero_alquiler", txtIDAlquiler.Text)

            inserta_pago.ExecuteNonQuery()

            MsgBox("Alquiler realizado correctamente")
            RealizarAlquiler.txtIDAlquiler.Text = NO_Alquiler.consultaID()
            Limpiar()


        Else
            MsgBox("Alquiler no realizado")
        End If
#End Region
    End Sub
End Class