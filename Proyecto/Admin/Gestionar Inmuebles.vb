Imports System.Data.SqlClient

Public Class Gestionar_Inmuebles
    Private Sub Gestionar_Inmuebles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarInmuebles", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvInmuebles.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Insertar Datos"
        Dim insertar As String = "insert into Inmuebles (cod_inmueble,metros,descripcion,numero_calle,nombre_calle,ciudad,precio,estado)
         values(@idinmueble,@metros,@descripcion,@numero_calle,@nombre_calle,@ciudad,@precio,@estado)"
        Dim estado As String
        estado = "Sin Usar"

        Dim insertar_inmueble As New SqlCommand(insertar, conexion)
        insertar_inmueble.Parameters.AddWithValue("@idinmueble", txtIdInmueble.Text)
        insertar_inmueble.Parameters.AddWithValue("@metros", txtMetrosInmueble.Text)
        insertar_inmueble.Parameters.AddWithValue("@descripcion", txtNombreInmueble.Text)
        insertar_inmueble.Parameters.AddWithValue("@numero_calle", txtNoCalleInmueble.Text)
        insertar_inmueble.Parameters.AddWithValue("@nombre_calle", txtNombreCalle.Text)
        insertar_inmueble.Parameters.AddWithValue("@ciudad", txtCiudad.Text)
        insertar_inmueble.Parameters.AddWithValue("@precio", txtPrecio.Text)
        insertar_inmueble.Parameters.AddWithValue("@estado", estado)
        insertar_inmueble.ExecuteNonQuery()

#End Region


#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarInmuebles", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvInmuebles.DataSource = dtpersonas
#End Region

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Actualizar"
        Dim actualizar As String = "update Inmuebles set metros=@metros,descripcion=@descripcion,numero_calle=@numero_calle,nombre_calle=@nombre_calle,ciudad=@ciudad,precio=@precio,estado=@estado where cod_inmueble=@idinmueble"

        Dim actualizar_inmueble As New SqlCommand(actualizar, conexion)

        actualizar_inmueble.Parameters.AddWithValue("@idinmueble", txtIdInmueble.Text)
        actualizar_inmueble.Parameters.AddWithValue("@metros", txtMetrosInmueble.Text)
        actualizar_inmueble.Parameters.AddWithValue("@descripcion", txtNombreInmueble.Text)
        actualizar_inmueble.Parameters.AddWithValue("@numero_calle", txtNoCalleInmueble.Text)
        actualizar_inmueble.Parameters.AddWithValue("@nombre_calle", txtNombreCalle.Text)
        actualizar_inmueble.Parameters.AddWithValue("@ciudad", txtCiudad.Text)
        actualizar_inmueble.Parameters.AddWithValue("@precio", txtPrecio.Text)
        actualizar_inmueble.Parameters.AddWithValue("@estado", txtEstado.Text)

        actualizar_inmueble.ExecuteNonQuery()
#End Region

#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarInmuebles", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvInmuebles.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Eliminar"
        Dim eliminar As String = "delete from Inmuebles where cod_inmueble=@idinmueble"

        Dim eliminar_inmueble As New SqlCommand(eliminar, conexion)
        eliminar_inmueble.Parameters.AddWithValue("@idinmueble", txtIdInmueble.Text)

        eliminar_inmueble.ExecuteNonQuery()
#End Region

#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarInmuebles", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvInmuebles.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region
        Dim Habilitar As String = "update Inmuebles set estado=@estado where cod_inmueble=@idinmueble"
        Dim activo As String
        activo = "Sin Usar"

        Dim actualizar_inmuebleA As New SqlCommand(Habilitar, conexion)
        actualizar_inmuebleA.Parameters.AddWithValue("@idinmueble", txtIdInmueble.Text)
        actualizar_inmuebleA.Parameters.AddWithValue("@estado", activo)

        actualizar_inmuebleA.ExecuteNonQuery()

#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarInmuebles", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvInmuebles.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnDeshabilitar_Click(sender As Object, e As EventArgs) Handles btnDeshabilitar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region
        Dim Desactivar As String = "update Inmuebles set estado=@estado where cod_inmueble=@idinmueble"
        Dim desactiva As String
        desactiva = "Deshabilitado"

        Dim actualizar_inmuebleD As New SqlCommand(Desactivar, conexion)
        actualizar_inmuebleD.Parameters.AddWithValue("@idinmueble", txtIdInmueble.Text)
        actualizar_inmuebleD.Parameters.AddWithValue("@estado", desactiva)

        actualizar_inmuebleD.ExecuteNonQuery()
#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarInmuebles", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvInmuebles.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub dgvInmuebles_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInmuebles.CellContentDoubleClick
        txtIdInmueble.Text = dgvInmuebles.CurrentRow.Cells(0).Value
        txtNombreInmueble.Text = dgvInmuebles.CurrentRow.Cells(1).Value
        txtMetrosInmueble.Text = dgvInmuebles.CurrentRow.Cells(2).Value
        txtNoCalleInmueble.Text = dgvInmuebles.CurrentRow.Cells(3).Value
        txtNombreCalle.Text = dgvInmuebles.CurrentRow.Cells(4).Value
        txtCiudad.Text = dgvInmuebles.CurrentRow.Cells(5).Value
        txtPrecio.Text = dgvInmuebles.CurrentRow.Cells(6).Value
        txtEstado.Text = dgvInmuebles.CurrentRow.Cells(7).Value

    End Sub

    Private Sub txtEstado_TextChanged(sender As Object, e As EventArgs) Handles txtEstado.TextChanged
        If (txtEstado.Text = "Deshabilitado") Then
            btnHabilitar.Enabled = True
            btnDeshabilitar.Enabled = False
        End If

        If txtEstado.Text = "Sin Usar" Then
            btnDeshabilitar.Enabled = True
            btnHabilitar.Enabled = False
        End If

        If txtEstado.Text = "En Uso" Then
            btnDeshabilitar.Enabled = False
            btnHabilitar.Enabled = False
        End If
    End Sub

    Private Sub btnMostrarEnUso_Click(sender As Object, e As EventArgs) Handles btnMostrarEnUso.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid/Personas"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("select * from inmuebles where estado = 'En Uso'", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvInmuebles.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnInmueblesSinUso_Click(sender As Object, e As EventArgs) Handles btnInmueblesSinUso.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid/Personas"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("select * from inmuebles where estado = 'Sin Usar'", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvInmuebles.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnInmueblesDehabilitados_Click(sender As Object, e As EventArgs) Handles btnInmueblesDehabilitados.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid/Personas"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("select * from inmuebles where estado = 'Deshabilitado'", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvInmuebles.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnMostrarInmubles_Click(sender As Object, e As EventArgs) Handles btnMostrarInmubles.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region
#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarInmuebles", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvInmuebles.DataSource = dtpersonas
#End Region
    End Sub
End Class