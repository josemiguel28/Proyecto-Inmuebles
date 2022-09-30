Imports System.Data.SqlClient

Public Class GestionClientes
    Sub Limpiar()
        txtNoIdentidad.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtMovil.Clear()
        txtTelefono.Clear()
        txtEstado.Clear()
    End Sub

    Dim mensaje As MsgBoxResult
    Public Validar As New VALIDACION_IDPERSONA

    Private Sub GestionClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarClientes", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvClientes.DataSource = dtpersonas
#End Region
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

        Dim activo As Integer
        activo = 1

#Region "Insertar Datos"
        Dim insertar As String = "insert into Personas (id_persona,nombre,apellido,movil,telefono_fijo,rol_cod,estado)
         values(@idpersona,@nombre,@apellido,@movil,@telefono,@rol,@estado)"

        If txtNoIdentidad.Text.Equals("") = False And txtNombre.Text.Equals("") = False And txtApellido.Text.Equals("") = False And txtMovil.Text.Equals("") = False And txtTelefono.Text.Equals("") = False And txtCodigoRol.Text.Equals("") = False And txtNombreRol.Text.Equals("") = False Then

            If Validar.personaRegistrada(txtNoIdentidad.Text) = False Then ''valida si la persona ya existe en la bd 

                Dim inserta_cliente As New SqlCommand(insertar, conexion)
                inserta_cliente.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
                inserta_cliente.Parameters.AddWithValue("@nombre", txtNombre.Text)
                inserta_cliente.Parameters.AddWithValue("@apellido", txtApellido.Text)
                inserta_cliente.Parameters.AddWithValue("@movil", txtMovil.Text)
                inserta_cliente.Parameters.AddWithValue("@telefono", txtTelefono.Text)
                inserta_cliente.Parameters.AddWithValue("@rol", txtCodigoRol.Text)
                inserta_cliente.Parameters.AddWithValue("@estado", activo)

                inserta_cliente.ExecuteNonQuery()

                ''inserta en la tabla clientes
                Dim insertarC As String = "insert into Clientes (id_persona,estado)
                values(@idpersona,@estado)"

                Dim insertar_clientes As New SqlCommand(insertarC, conexion)
                insertar_clientes.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
                insertar_clientes.Parameters.AddWithValue("@estado", activo)
                insertar_clientes.ExecuteNonQuery()

                mensaje = MsgBox("Registrado Exitosamente")
                Limpiar()
            Else
                MsgBox("Esta persona ya existe")
            End If
        Else
            MsgBox("No pueden existir campos vacios")
        End If
#End Region

#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarClientes", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvClientes.DataSource = dtpersonas
#End Region

    End Sub


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Actualizar"
        Dim actualizar As String = "update Personas set nombre = @nombre,apellido=@apellido,movil=@movil,telefono_fijo=@telefono,rol_cod=@rol where id_persona=@idpersona"
        Dim actualizar_personas As New SqlCommand(actualizar, conexion)
        Dim mensaje As String
        mensaje = " "

        mensaje = MsgBox("Desea Actualizar este registro?", vbYesNo, "Actualizar")

        If (mensaje = vbYes) Then
            actualizar_personas.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
            actualizar_personas.Parameters.AddWithValue("@nombre", txtNombre.Text)
            actualizar_personas.Parameters.AddWithValue("@apellido", txtApellido.Text)
            actualizar_personas.Parameters.AddWithValue("@movil", txtMovil.Text)
            actualizar_personas.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            actualizar_personas.Parameters.AddWithValue("@rol", txtCodigoRol.Text)

            actualizar_personas.ExecuteNonQuery()

            mensaje = MsgBox("Registro Actualizado Correctamente")
        End If
#End Region

#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarClientes", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvClientes.DataSource = dtpersonas
#End Region
        Limpiar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnDeshabilitar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Desabilitar"
        Dim actualizar As String = "update Personas set estado=@estado where id_persona=@idpersona"    'consulta para la tabla personas 
        Dim actualizarC As String = "update Clientes set estado=@estado where id_persona=@idpersona"   'consulta para la table clientes 

        Dim actualizar_personas As New SqlCommand(actualizar, conexion)
        Dim actualizar_cliente As New SqlCommand(actualizarC, conexion)

        Dim Inactivo As Integer
        Dim mensaje As String

        Inactivo = 0

        mensaje = " "

        mensaje = MsgBox("Desea Inhabilitar este Usuario?", vbYesNo, "Inhabilitar")

        If (mensaje = vbYes) Then
            actualizar_personas.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
            actualizar_personas.Parameters.AddWithValue("@estado", Inactivo)

            actualizar_cliente.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
            actualizar_cliente.Parameters.AddWithValue("@estado", Inactivo)

            actualizar_personas.ExecuteNonQuery()
            actualizar_cliente.ExecuteNonQuery()

            mensaje = MsgBox("Usuario Inhabilitado")
        End If

#End Region

#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarClientes", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvClientes.DataSource = dtpersonas
#End Region
        Limpiar()
    End Sub
    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Habilitar"
        Dim actualizar As String = "update Personas set estado=@estado where id_persona=@idpersona"    'consulta para la tabla personas 
        Dim actualizarC As String = "update Clientes set estado=@estado where id_persona=@idpersona"   'consulta para la table clientes 

        Dim actualizar_personas As New SqlCommand(actualizar, conexion)
        Dim actualizar_cliente As New SqlCommand(actualizarC, conexion)

        Dim activo As Integer
        Dim mensaje As String

        activo = 1

        mensaje = " "

        mensaje = MsgBox("Desea Habilitar este Usuario?", vbYesNo, "Inhabilitar")

        If (mensaje = vbYes) Then
            actualizar_personas.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
            actualizar_personas.Parameters.AddWithValue("@estado", activo)

            actualizar_cliente.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
            actualizar_cliente.Parameters.AddWithValue("@estado", activo)

            actualizar_personas.ExecuteNonQuery()
            actualizar_cliente.ExecuteNonQuery()

            mensaje = MsgBox("Usuario Habilitado")
        End If

#End Region

#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarClientes", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvClientes.DataSource = dtpersonas
#End Region
    End Sub
    Private Sub dgvClientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentDoubleClick
        txtNoIdentidad.Text = dgvClientes.CurrentRow.Cells(1).Value
        txtNombre.Text = dgvClientes.CurrentRow.Cells(2).Value
        txtApellido.Text = dgvClientes.CurrentRow.Cells(3).Value
        txtMovil.Text = dgvClientes.CurrentRow.Cells(4).Value
        txtTelefono.Text = dgvClientes.CurrentRow.Cells(5).Value
        txtEstado.Text = dgvClientes.CurrentRow.Cells(7).Value
    End Sub

    Private Sub txtEstado_TextChanged(sender As Object, e As EventArgs) Handles txtEstado.TextChanged
        If (txtEstado.Text = "Activo") Then
            btnHabilitar.Enabled = False
        Else
            btnDeshabilitar.Enabled = False
        End If

        If txtEstado.Text = "Activo" Then
            btnDeshabilitar.Enabled = True
        Else
            btnHabilitar.Enabled = True
        End If
    End Sub
End Class