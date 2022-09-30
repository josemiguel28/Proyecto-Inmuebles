Imports System.Data.SqlClient

Public Class GestionGaraje
    Private Sub GestionGaraje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarGaraje", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvGaraje.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Insertar Datos"
        Dim insertar As String = "insert into Garajes (cod_garaje,cod_inmueble,cod_piso)
         values(@idGaraje,@idInmueble,@idPiso)"


        Dim insertar_Garaje As New SqlCommand(insertar, conexion)
        insertar_Garaje.Parameters.AddWithValue("@idGaraje", txtIDGaraje.Text)
        insertar_Garaje.Parameters.AddWithValue("@idInmueble", TextBox2.Text)
        insertar_Garaje.Parameters.AddWithValue("@idPiso", txtPiso.Text)


        insertar_Garaje.ExecuteNonQuery()

#End Region


#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarGaraje", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvGaraje.DataSource = dtpersonas
#End Region

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Insertar Datos"
        Dim actualizar As String = "update from Garajes set  cod_inmueble=@idInmueble,cod_piso=@idPiso where cod_garaje=@idGaraje)"


        Dim actualizar_Garaje As New SqlCommand(actualizar, conexion)
        actualizar_Garaje.Parameters.AddWithValue("@idGaraje", txtIDGaraje.Text)
        actualizar_Garaje.Parameters.AddWithValue("@idInmueble", TextBox2.Text)
        actualizar_Garaje.Parameters.AddWithValue("@idPiso", txtPiso.Text)


        actualizar_Garaje.ExecuteNonQuery()

#End Region


#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarGaraje", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvGaraje.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Eliminar"
        Dim eliminar As String = "delete from Garajes where cod_garaje=@idGaraje"

        Dim eliminar_Garaje As New SqlCommand(eliminar, conexion)
        eliminar_Garaje.Parameters.AddWithValue("@idGaraje", txtIDGaraje.Text)

        eliminar_Garaje.ExecuteNonQuery()
#End Region

#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarGaraje", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvGaraje.DataSource = dtpersonas
#End Region
    End Sub
End Class