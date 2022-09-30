Imports System.Data.SqlClient

Public Class Gestion_Local

    Dim mensaje As MsgBoxResult
    Private Sub Gestion_Local_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarLocal", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvLocal.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Insertar Datos"
        Dim insertar As String = "insert into Locales (servicio,cod_inmueble)
         values(@servicio,@idInmueble)"

        Dim insertar_local As New SqlCommand(insertar, conexion)
        insertar_local.Parameters.AddWithValue("@idInmueble", txtIDInmueble.Text)
        insertar_local.Parameters.AddWithValue("@servicio", txtUso.Text)

        insertar_local.ExecuteNonQuery()

#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarLocal", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvLocal.DataSource = dtpersonas
#End Region
        mensaje = MsgBox("Registro Agregado Correctamente")
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Insertar Datos"
        Dim actualizar As String = "update Locales set servicio=@servicio where cod_local=@idlocal"

        Dim actualizar_local As New SqlCommand(actualizar, conexion)

        mensaje = MsgBox("Desea Actualizar este registro?", vbYesNo, "Actualizar")

        If (mensaje = vbYes) Then
            actualizar_local.Parameters.AddWithValue("@idlocal", txtIDLocal.Text)
            actualizar_local.Parameters.AddWithValue("@idInmueble", TextBox2.Text)
            actualizar_local.Parameters.AddWithValue("@servicio", txtUso.Text)

            actualizar_local.ExecuteNonQuery()

            mensaje = MsgBox("Registro Actualizado Correctamente")
        End If

#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarLocal", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvLocal.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Eliminar Datos"
        Dim eliminar As String = "delete from Locales where cod_local=@idlocal"

        Dim eliminar_local As New SqlCommand(eliminar, conexion)

        mensaje = MsgBox("Desea Eliminar este registro?", vbYesNo, "Actualizar")

        If (mensaje = vbYes) Then
            eliminar_local.Parameters.AddWithValue("@idlocal", txtIDLocal.Text)

            eliminar_local.ExecuteNonQuery()
            mensaje = MsgBox("Registro Eliminado Correctamente")
        End If
#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarLocal", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvLocal.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub dgvLocal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLocal.CellContentClick
        txtIDLocal.Text = dgvLocal.CurrentRow.Cells(0).Value
        txtUso.Text = dgvLocal.CurrentRow.Cells(1).Value
    End Sub
End Class