Imports System.Data.SqlClient

Public Class GestionUsuarios
    Sub Limpiar()
        txtUsuario.Clear()
        txtEstado.Clear()

    End Sub

    Dim mensaje As String
    Dim Activo, inactivo As Integer


    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarUsuarios ", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvUsuarios.DataSource = dtpersonas
#End Region
        btnHabilitar.Enabled = False
        btnDesabilitar.Enabled = False

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Insertar Datos"
        Dim insertar As String = "insert into usuarios (username,pass, id_tipo_usuario,estado)
         values(@user,@pass,@idtipouser,@estado)"
        Activo = 1

        Dim insertar_usuario As New SqlCommand(insertar, conexion)
        insertar_usuario.Parameters.AddWithValue("@user", txtUsuario.Text)
        insertar_usuario.Parameters.AddWithValue("@pass", txtEstado.Text)
        insertar_usuario.Parameters.AddWithValue("@idtipouser", txtIdRol.Text)
        insertar_usuario.Parameters.AddWithValue("@estado", Activo)
        insertar_usuario.ExecuteNonQuery()

#End Region
#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarUsuarios ", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvUsuarios.DataSource = dtpersonas
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
        Dim actualizar As String = "update usuarios set username=@usuario,pass=@pass, id_tipo_usuario=@idTipoUser where id_usuario=@idUsuario"

        Dim actualizar_usuario As New SqlCommand(actualizar, conexion)

        mensaje = MsgBox("Desea Actualizar este registro?", vbYesNo, "Actualizar")

        If (mensaje = vbYes) Then
            actualizar_usuario.Parameters.AddWithValue("@idUsuario", txtIDUsuario.Text)
            actualizar_usuario.Parameters.AddWithValue("@usuario", txtUsuario.Text)
            actualizar_usuario.Parameters.AddWithValue("@pass", txtEstado.Text)
            actualizar_usuario.Parameters.AddWithValue("@idTipoUser", txtIdRol.Text)

            actualizar_usuario.ExecuteNonQuery()

            mensaje = MsgBox("Registro Actualizado Correctamente")
        End If

#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarUsuarios ", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvUsuarios.DataSource = dtpersonas
#End Region

        Limpiar()


    End Sub
    Private Sub btnBuscarRol_Click(sender As Object, e As EventArgs) Handles btnBuscarRol.Click
        UsuariosRol.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnDesabilitar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Deshabilitado"
        Dim actualizar As String = "update usuarios set username=@usuario,pass=@pass, id_tipo_usuario=@idTipoUser,estado=@estado where id_usuario=@idUsuario"

        Dim actualizar_usuario As New SqlCommand(actualizar, conexion)

        mensaje = MsgBox("Desea Deshabilitar este registro?", vbYesNo, "Actualizar")

        inactivo = 0
        If (mensaje = vbYes) Then
            actualizar_usuario.Parameters.AddWithValue("@idUsuario", txtIDUsuario.Text)
            actualizar_usuario.Parameters.AddWithValue("@usuario", txtUsuario.Text)
            actualizar_usuario.Parameters.AddWithValue("@pass", txtEstado.Text)
            actualizar_usuario.Parameters.AddWithValue("@idTipoUser", txtIdRol.Text)
            actualizar_usuario.Parameters.AddWithValue("@estado", inactivo)
            actualizar_usuario.ExecuteNonQuery()

            mensaje = MsgBox("Usuario Inhabilitado Correctamente")
        End If

#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarUsuarios ", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvUsuarios.DataSource = dtpersonas
#End Region

    End Sub

    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Habilitado"
        Dim actualizar As String = "update usuarios set username=@usuario,pass=@pass, id_tipo_usuario=@idTipoUser,estado=@estado where id_usuario=@idUsuario"

        Dim actualizar_usuario As New SqlCommand(actualizar, conexion)

        mensaje = MsgBox("Desea Habilitar este Usuario?", vbYesNo, "Actualizar")

        Activo = 1
        If (mensaje = vbYes) Then
            actualizar_usuario.Parameters.AddWithValue("@idUsuario", txtIDUsuario.Text)
            actualizar_usuario.Parameters.AddWithValue("@usuario", txtUsuario.Text)
            actualizar_usuario.Parameters.AddWithValue("@pass", txtEstado.Text)
            actualizar_usuario.Parameters.AddWithValue("@idTipoUser", txtIdRol.Text)
            actualizar_usuario.Parameters.AddWithValue("@estado", Activo)
            actualizar_usuario.ExecuteNonQuery()

            mensaje = MsgBox("Usuario Habilitado Correctamente")
        End If

#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarUsuarios ", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvUsuarios.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub dgvUsuarios_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentDoubleClick
        txtIDUsuario.Text = dgvUsuarios.CurrentRow.Cells(0).Value
        txtUsuario.Text = dgvUsuarios.CurrentRow.Cells(1).Value
        txtEstado.Text = dgvUsuarios.CurrentRow.Cells(3).Value

        If (dgvUsuarios.CurrentRow.Cells(2).Value = "Administrador") Then
            txtIdRol.Text = 1
            txtRolDescripcion.Text = dgvUsuarios.CurrentRow.Cells(2).Value
        Else
            txtIdRol.Text = 2
            txtRolDescripcion.Text = dgvUsuarios.CurrentRow.Cells(2).Value
        End If

    End Sub

    Private Sub txtEstado_TextChanged(sender As Object, e As EventArgs) Handles txtEstado.TextChanged
        'validacion de botones habilitar/inhabilitar

        If (txtEstado.Text = "Activo") Then
            btnHabilitar.Enabled = False
        Else
            btnDesabilitar.Enabled = False
        End If

        If txtEstado.Text = "Activo" Then
            btnDesabilitar.Enabled = True
        Else
            btnHabilitar.Enabled = True
        End If
    End Sub
End Class