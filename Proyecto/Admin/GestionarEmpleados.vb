Imports System.Data.SqlClient

Public Class GestionarEmpleados
    Sub Limpiar()
        txtNoIdentidad.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtMovil.Clear()
        txtTelefono.Clear()

    End Sub
    Dim mensaje As MsgBoxResult
    Public Validar As New VALIDACION_IDPERSONA
    Private Sub GestionarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarEmpleados", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvEmpleados.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "Insertar Datos"
        Dim insertar As String = "insert into Personas (id_persona,nombre,apellido,movil,telefono_fijo,rol_cod)
         values(@idpersona,@nombre,@apellido,@movil,@telefono,@rol)"

        If txtNoIdentidad.Text.Equals("") = False And txtNombre.Text.Equals("") = False And txtApellido.Text.Equals("") = False And txtMovil.Text.Equals("") = False And txtTelefono.Text.Equals("") = False And txtCodigoRol.Text.Equals("") = False And txtNombreRol.Text.Equals("") = False Then
            If Validar.personaRegistrada(txtNoIdentidad.Text) = False Then ''valida si la persona ya existe en la bd 

                Dim inserta_empleado As New SqlCommand(insertar, conexion)
                inserta_empleado.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
                inserta_empleado.Parameters.AddWithValue("@nombre", txtNombre.Text)
                inserta_empleado.Parameters.AddWithValue("@apellido", txtApellido.Text)
                inserta_empleado.Parameters.AddWithValue("@movil", txtMovil.Text)
                inserta_empleado.Parameters.AddWithValue("@telefono", txtTelefono.Text)
                inserta_empleado.Parameters.AddWithValue("@rol", txtCodigoRol.Text)

                inserta_empleado.ExecuteNonQuery()

                ''inserta en la tabla empleados
                Dim insertarE As String = "insert into Empleados (id_persona)
                values(@idpersona)"

                Dim insertar_empleado As New SqlCommand(insertarE, conexion)
                insertar_empleado.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)

                insertar_empleado.ExecuteNonQuery()
                MsgBox("Registrado Exitosamente")
                Limpiar()

            Else
                MsgBox("La persona ya existe")
            End If
        Else
            MsgBox("No pueden existir campos vacios")
        End If
#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarEmpleados", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvEmpleados.DataSource = dtpersonas
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
        Dim actualizar_empleados As New SqlCommand(actualizar, conexion)
        Dim mensaje As String
        mensaje = " "

        mensaje = MsgBox("Desea Actualizar este registro?", vbYesNo, "Actualizar")

        If (mensaje = vbYes) Then
            actualizar_empleados.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
            actualizar_empleados.Parameters.AddWithValue("@nombre", txtNombre.Text)
            actualizar_empleados.Parameters.AddWithValue("@apellido", txtApellido.Text)
            actualizar_empleados.Parameters.AddWithValue("@movil", txtMovil.Text)
            actualizar_empleados.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            actualizar_empleados.Parameters.AddWithValue("@rol", txtCodigoRol.Text)

            actualizar_empleados.ExecuteNonQuery()

            mensaje = MsgBox("Registro Actualizado Correctamente")
        End If
#End Region
#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarEmpleados", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvEmpleados.DataSource = dtpersonas
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
        Dim actualizarE As String = "update Empleados set estado=@estado where id_persona=@idpersona"  'consulta para ;a tabla empleados

        Dim actualizar_personas As New SqlCommand(actualizar, conexion)
        Dim actualizar_empleado As New SqlCommand(actualizarE, conexion)

        Dim Inactivo As Integer
        Dim mensaje As String

        Inactivo = 0

        mensaje = " "

        mensaje = MsgBox("Desea Inhabilitar este Usuario?", vbYesNo, "Inhabilitar")

        If (mensaje = vbYes) Then
            actualizar_personas.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
            actualizar_personas.Parameters.AddWithValue("@estado", Inactivo)

            actualizar_empleado.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
            actualizar_empleado.Parameters.AddWithValue("@estado", Inactivo)

            actualizar_personas.ExecuteNonQuery()
            actualizar_empleado.ExecuteNonQuery()

            mensaje = MsgBox("Usuario Inhabilitado")
        End If

#End Region

#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarEmpleados", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvEmpleados.DataSource = dtpersonas
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
        Dim actualizarE As String = "update Empleados set estado=@estado where id_persona=@idpersona"  'consulta para ;a tabla empleados

        Dim actualizar_personas As New SqlCommand(actualizar, conexion)
        Dim actualizar_empleado As New SqlCommand(actualizarE, conexion)

        Dim activo As Integer
        Dim mensaje As String

        activo = 1

        mensaje = " "

        mensaje = MsgBox("Desea Habilitar este Usuario?", vbYesNo, "Inhabilitar")

        If (mensaje = vbYes) Then
            actualizar_personas.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
            actualizar_personas.Parameters.AddWithValue("@estado", activo)

            'empleado
            actualizar_empleado.Parameters.AddWithValue("@idpersona", txtNoIdentidad.Text)
            actualizar_empleado.Parameters.AddWithValue("@estado", activo)

            actualizar_personas.ExecuteNonQuery()
            actualizar_empleado.ExecuteNonQuery()

            mensaje = MsgBox("Usuario Habilitado")
        End If

#End Region

#Region "CargarGrid"
        ''cargar el dgv
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_ListarEmpleados", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvEmpleados.DataSource = dtpersonas
#End Region
    End Sub

    Private Sub txtEstado_TextChanged(sender As Object, e As EventArgs) Handles txtEstado.TextChanged
        ''validacion de los botones
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
    Private Sub dgvEmpleados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellContentDoubleClick
        txtNoIdentidad.Text = dgvEmpleados.CurrentRow.Cells(1).Value
        txtNombre.Text = dgvEmpleados.CurrentRow.Cells(2).Value
        txtApellido.Text = dgvEmpleados.CurrentRow.Cells(3).Value
        txtMovil.Text = dgvEmpleados.CurrentRow.Cells(4).Value
        txtTelefono.Text = dgvEmpleados.CurrentRow.Cells(5).Value
        txtEstado.Text = dgvEmpleados.CurrentRow.Cells(7).Value
    End Sub
End Class