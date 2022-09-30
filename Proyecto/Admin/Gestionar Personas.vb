Imports System.Data.SqlClient

Public Class Gestionar_Personas
    Public Validar As New VALIDACION_IDPERSONA  'instancia de la clase 
    Sub Limpiar()
        txtNoIdentidad.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtMovil.Clear()
        txtTelefono.Clear()
        txtCodigoRol.Clear()
        txtNombreRol.Clear()
        txtEstado.Clear()

    End Sub
    Dim activo, inactivo As Integer
    Private Sub Gestionar_Personas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarPersonas", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvPersonas.DataSource = dtpersonas
#End Region
        txtNoIdentidad.MaxLength = 13  ''define el numero max de caracteres
        txtMovil.MaxLength = 8  ''define el numero max de caracteres
        txtTelefono.MaxLength = 8  ''define el numero max de caracteres
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region
        activo = 1

#Region "Insertar Datos"
        ''valida los textbox vacios
        If txtNoIdentidad.Text.Equals("") = False And txtNombre.Text.Equals("") = False And txtApellido.Text.Equals("") = False And txtMovil.Text.Equals("") = False And txtTelefono.Text.Equals("") = False And txtCodigoRol.Text.Equals("") = False And txtNombreRol.Text.Equals("") = False Then

            If Validar.personaRegistrada(txtNoIdentidad.Text) = False Then ''valida si la persona ya existe en la bd 

                Dim insertar As String = "insert into Personas (id_persona,nombre,apellido,movil,telefono_fijo,rol_cod,estado)
                values(@idpersona,@nombre,@apellido,@movil,@telefono,@rol,@estado)"

                Dim insertar_persona As New SqlCommand(insertar, conexion)
                insertar_persona.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
                insertar_persona.Parameters.AddWithValue("@nombre", txtNombre.Text)
                insertar_persona.Parameters.AddWithValue("@apellido", txtApellido.Text)
                insertar_persona.Parameters.AddWithValue("@movil", txtMovil.Text)
                insertar_persona.Parameters.AddWithValue("@telefono", txtTelefono.Text)
                insertar_persona.Parameters.AddWithValue("@rol", txtCodigoRol.Text)
                insertar_persona.Parameters.AddWithValue("@estado", activo)

                insertar_persona.ExecuteNonQuery()
#End Region

#Region "insertar Cliente/Empleado"
                If (txtCodigoRol.Text = 1) Then
                    Dim insertarC As String = "insert into Clientes (id_persona,estado)
             values(@idpersona,@estado)"

                    Dim insertar_cliente As New SqlCommand(insertarC, conexion)
                    insertar_cliente.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
                    insertar_cliente.Parameters.AddWithValue("@estado", activo)

                    insertar_cliente.ExecuteNonQuery()

                Else
                    Dim insertarE As String = "insert into Empleados (id_persona,estado)
             values(@idpersona,@estado)"

                    Dim insertar_empleado As New SqlCommand(insertarE, conexion)
                    insertar_empleado.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
                    insertar_empleado.Parameters.AddWithValue("@estado", activo)

                    insertar_empleado.ExecuteNonQuery()
                End If

            Else
                MsgBox("La persona ya esta registrada")
            End If

        Else
            MsgBox("No puede existir campos vacios")
        End If
#End Region

#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarPersonas", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvPersonas.DataSource = dtpersonas
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
        Using adaptador As New SqlDataAdapter("exec pa_MostrarPersonas", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvPersonas.DataSource = dtpersonas
#End Region

        Limpiar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnDesabilitar.Click

#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Desabilitar"
        Dim actualizar As String = "update Personas set estado=@estado where id_persona=@idpersona"    'consulta para la tabla personas 
        Dim actualizarC As String = "update Clientes set estado=@estado where id_persona=@idpersona"   'consulta para la table clientes 
        Dim actualizarE As String = "update Empleados set estado=@estado where id_persona=@idpersona"  'consulta para ;a tabla empleados

        Dim actualizar_personas As New SqlCommand(actualizar, conexion)
        Dim actualizar_cliente As New SqlCommand(actualizarC, conexion)
        Dim actualizar_empleado As New SqlCommand(actualizarE, conexion)

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

            actualizar_empleado.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
            actualizar_empleado.Parameters.AddWithValue("@estado", Inactivo)

            actualizar_personas.ExecuteNonQuery()
            actualizar_cliente.ExecuteNonQuery()
            actualizar_empleado.ExecuteNonQuery()

            mensaje = MsgBox("Usuario Inhabilitado")
        End If

#End Region

#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarPersonas", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvPersonas.DataSource = dtpersonas
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
        Dim actualizarE As String = "update Empleados set estado=@estado where id_persona=@idpersona"  'consulta para ;a tabla empleados

        Dim actualizar_personas As New SqlCommand(actualizar, conexion)
        Dim actualizar_cliente As New SqlCommand(actualizarC, conexion)
        Dim actualizar_empleado As New SqlCommand(actualizarE, conexion)

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

            actualizar_empleado.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
            actualizar_empleado.Parameters.AddWithValue("@estado", activo)

            actualizar_personas.ExecuteNonQuery()
            actualizar_cliente.ExecuteNonQuery()
            actualizar_empleado.ExecuteNonQuery()

            mensaje = MsgBox("Usuario Habilitado")
        End If

#End Region

#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarPersonas", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvPersonas.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        fmrRoles.Show()
    End Sub


    Private Sub btnMostrarEmpleados_Click(sender As Object, e As EventArgs) Handles btnMostrarEmpleados.Click

#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid/Empleados"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarEmpleados", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvPersonas.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnMostrarClientes_Click(sender As Object, e As EventArgs) Handles btnMostrarClientes.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid/Personas"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarClientes", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvPersonas.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnMostrarTodo_Click(sender As Object, e As EventArgs) Handles btnMostrarTodo.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid/Personas"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarPersonas", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvPersonas.DataSource = dtpersonas
#End Region
    End Sub


    Private Sub dgvPersonas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersonas.CellContentDoubleClick
        txtNoIdentidad.Text = dgvPersonas.CurrentRow.Cells(0).Value
        txtNombre.Text = dgvPersonas.CurrentRow.Cells(1).Value
        txtApellido.Text = dgvPersonas.CurrentRow.Cells(2).Value
        txtMovil.Text = dgvPersonas.CurrentRow.Cells(3).Value
        txtTelefono.Text = dgvPersonas.CurrentRow.Cells(4).Value
        txtEstado.Text = dgvPersonas.CurrentRow.Cells(6).Value


        If (dgvPersonas.CurrentRow.Cells(5).Value = "Cliente") Then
            txtNombreRol.Text = "Cliente"
            txtCodigoRol.Text = 1
        Else
            txtNombreRol.Text = "Empleado"
            txtCodigoRol.Text = 2
        End If

    End Sub

    Private Sub txtEstado_TextChanged(sender As Object, e As EventArgs) Handles txtEstado.TextChanged
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

    Private Sub txtNoIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoIdentidad.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            Me.validaciones.SetError(sender, "")
        Else
            e.Handled = True
            Me.validaciones.SetError(sender, "Ingrese un dato numerico")
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            Me.validaciones.SetError(sender, "")
        Else
            e.Handled = True
            Me.validaciones.SetError(sender, "El campo debe ser texto")
        End If
    End Sub

    Private Sub txtMovil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMovil.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            Me.validaciones.SetError(sender, "")
        Else
            e.Handled = True
            Me.validaciones.SetError(sender, "Ingrese un dato numerico")
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            Me.validaciones.SetError(sender, "")
        Else
            e.Handled = True
            Me.validaciones.SetError(sender, "Ingrese un dato numerico")
        End If
    End Sub

    Private Sub txtNoIdentidad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNoIdentidad.Validating
        If DirectCast(sender, TextBox).Text.Length < 13 Then
            Me.validaciones.SetError(sender, "Numero de identidad no valido")
        End If
    End Sub


    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            Me.validaciones.SetError(sender, "")
        Else
            e.Handled = True
            Me.validaciones.SetError(sender, "El campo debe ser texto")
        End If
    End Sub
End Class