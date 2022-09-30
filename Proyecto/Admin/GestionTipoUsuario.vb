Imports System.Data.SqlClient

Public Class GestionTipoUsuario
    Sub Limpiar()
        txtDescripcion.Clear()
        txtID.Clear()
    End Sub

    Dim mensaje As String
    Private Sub GestionTipoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("select id_tipo_usuario[ID], usuario_descripcion[Tipo Usuario] from Tipo_Usuario ", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvTipoUsuarios.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Insertar Datos"
        Dim insertar As String = "insert into Tipo_Usuario (usuario_descripcion)
         values(@usuarioDescripcion)"


        Dim insertar_usuario As New SqlCommand(insertar, conexion)
        insertar_usuario.Parameters.AddWithValue("@usuarioDescripcion", txtDescripcion.Text)
        insertar_usuario.ExecuteNonQuery()

#End Region
#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("select id_tipo_usuario[ID], usuario_descripcion[Tipo Usuario] from Tipo_Usuario ", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvTipoUsuarios.DataSource = dtpersonas
#End Region
        mensaje = MsgBox("Registro Agregado Correctamente")

        Limpiar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Actualizar"
        Dim actualizar As String = "update Tipo_Usuario set usuario_descripcion=@descripcion where id_tipo_usuario=@id"

        Dim actualizar_tipoU As New SqlCommand(actualizar, conexion)

        mensaje = MsgBox("Desea Actualizar este registro?", vbYesNo, "Actualizar")

        If (mensaje = vbYes) Then
            actualizar_tipoU.Parameters.AddWithValue("@id", txtID.Text)
            actualizar_tipoU.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)

            actualizar_tipoU.ExecuteNonQuery()
            mensaje = MsgBox("Registro Actualizado Correctamente")
        End If
#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("select id_tipo_usuario[ID], usuario_descripcion[Tipo Usuario] from Tipo_Usuario ", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvTipoUsuarios.DataSource = dtpersonas
#End Region
        Limpiar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Eliminar"
        Dim eliminar As String = "delete from Tipo_Usuario where id_tipo_usuario=@id"
        Dim eliminar_usuarioT As New SqlCommand(eliminar, conexion)

        mensaje = MsgBox("Desea Eliminar este registro?", vbYesNo, "Eliminar")

        If (mensaje = vbYes) Then
            eliminar_usuarioT.Parameters.AddWithValue("@id", txtID.Text)
            eliminar_usuarioT.ExecuteNonQuery()
            mensaje = MsgBox("Registro Eliminado Correctamente")
        End If
#End Region
#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("select id_tipo_usuario[ID], usuario_descripcion[Tipo Usuario] from Tipo_Usuario ", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvTipoUsuarios.DataSource = dtpersonas
#End Region
        Limpiar()
    End Sub

    Private Sub dgvTipoUsuarios_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipoUsuarios.CellContentDoubleClick
        txtID.Text = dgvTipoUsuarios.CurrentRow.Cells(0).Value
        txtDescripcion.Text = dgvTipoUsuarios.CurrentRow.Cells(1).Value

    End Sub


End Class