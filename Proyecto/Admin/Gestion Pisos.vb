Imports System.Data.SqlClient

Public Class Gestion_Pisos
    Private Sub Gestion_Pisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarPiso", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvPiso.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Insertar Datos"
        Dim insertar As String = "insert into Pisos (cod_piso,cod_inmueble)
         values(@idpiso,@idInmueble)"


        Dim insertar_piso As New SqlCommand(insertar, conexion)
        insertar_piso.Parameters.AddWithValue("@idpiso", txtIDPiso.Text)
        insertar_piso.Parameters.AddWithValue("@idInmueble", TextBox2.Text)

        insertar_piso.ExecuteNonQuery()

#End Region
#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarPiso", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvPiso.DataSource = dtpersonas
#End Region

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Insertar Datos"
        Dim insertar As String = "update from Pisos (cod_piso,cod_inmueble @idpiso,@idInmueble)"


        Dim insertar_piso As New SqlCommand(insertar, conexion)
        insertar_piso.Parameters.AddWithValue("@idpiso", txtIDPiso.Text)
        insertar_piso.Parameters.AddWithValue("@idInmueble", TextBox2.Text)

        insertar_piso.ExecuteNonQuery()

#End Region
#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarPiso", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvPiso.DataSource = dtpersonas
#End Region
    End Sub
End Class