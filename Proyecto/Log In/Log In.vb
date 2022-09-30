Imports System.Data.SqlClient

Public Class Log_In

    Private Sub Log_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region
        Try
            If usuarioRegistrado(txtUsuario.Text) = True Then
                Dim contra As String = contrasena(txtUsuario.Text)
                If contra.Equals(txtContrasena.Text) = True Then
                    Me.Hide()
                    If ConsultarTipoUsuario(txtUsuario.Text) = 1 Then
                        Dim usuario1 As String
                        usuario1 = "Administrador Nivel 1"

#Region "Inserta el Usuario que ingreso en RegistroLogin"
                        Dim insertar1 As String = "insert into RegistroLogin (ingreso_usuario,ingreso_fecha_hora) values(@usuario,@fecha)"

                        Dim insertar_usuario1 As New SqlCommand(insertar1, conexion)
                        insertar_usuario1.Parameters.AddWithValue("@usuario", usuario1)
                        insertar_usuario1.Parameters.AddWithValue("@fecha", DateAndTime.Now)

                        insertar_usuario1.ExecuteNonQuery()
#End Region

#Region "Desactiva Botones"
                        Gestion_Local.btnEditar.Enabled = False
                        Gestion_Local.btnEliminar.Enabled = False
                        Gestion_Pisos.btnEliminar.Enabled = False
                        Gestion_Pisos.btnEditar.Enabled = False
                        Gestionar_Inmuebles.btnEliminar.Enabled = False
                        Gestionar_Inmuebles.btnEditar.Enabled = False
                        Gestionar_Personas.btnEditar.Enabled = False
                        Gestionar_Personas.btnDesabilitar.Enabled = False
                        Gestionar_Personas.btnHabilitar.Enabled = False
                        GestionarEmpleados.btnHabilitar.Enabled = False
                        GestionarEmpleados.btnHabilitar.Enabled = False
                        GestionClientes.btnDeshabilitar.Enabled = False
                        GestionClientes.btnHabilitar.Enabled = False
                        GestionClientes.btnEditar.Enabled = False
                        GestionGaraje.btnEditar.Enabled = False
                        GestionGaraje.btnEliminar.Enabled = False
                        GestionUsuarios.btnEditar.Enabled = False
                        GestionUsuarios.btnDesabilitar.Enabled = False
                        GestionUsuarios.btnHabilitar.Enabled = False
                        GestionTipoUsuario.btnEditar.Enabled = False
                        GestionTipoUsuario.btnEliminar.Enabled = False
                        MenuA.Button2.Enabled = False

#End Region

                        MenuA.Show()
                    ElseIf ConsultarTipoUsuario(txtUsuario.Text) = 2 Then
                        Dim usuario2 As String
                        usuario2 = "Administrador Nivel 2"
#Region "Desactiva Botones"
                        Gestion_Local.btnGuardar.Enabled = False
                        Gestion_Pisos.btnGuardar.Enabled = False
                        Gestionar_Inmuebles.btnAgregar.Enabled = False
                        Gestionar_Personas.btnAgregar.Enabled = False
                        GestionarEmpleados.btnAgregar.Enabled = False
                        GestionClientes.btnAgregar.Enabled = False
                        GestionGaraje.btnGuardar.Enabled = False
                        GestionUsuarios.btnGuardar.Enabled = False
                        GestionTipoUsuario.btnGuardar.Enabled = False
                        MenuA.Button2.Enabled = False
#End Region

#Region "Inserta el Usuario que ingreso en RegistroLogin"
                        Dim insertar2 As String = "insert into RegistroLogin (ingreso_usuario,ingreso_fecha_hora) values(@usuario,@fecha)"

                        Dim insertar_usuario2 As New SqlCommand(insertar2, conexion)
                        insertar_usuario2.Parameters.AddWithValue("@usuario", usuario2)
                        insertar_usuario2.Parameters.AddWithValue("@fecha", DateAndTime.Now)

                        insertar_usuario2.ExecuteNonQuery()
#End Region
                        MenuA.Show()
                    ElseIf ConsultarTipoUsuario(txtUsuario.Text) = 3 Then
#Region "Inserta el Usuario que ingreso en RegistroLogin"
                        Dim insertar3 As String = "insert into RegistroLogin (ingreso_usuario,ingreso_fecha_hora) values(@usuario,@fecha)"
                        Dim usuario3 As String
                        usuario3 = "Administrador Nivel 3"
                        Dim insertar_usuario3 As New SqlCommand(insertar3, conexion)
                        insertar_usuario3.Parameters.AddWithValue("@usuario", usuario3)
                        insertar_usuario3.Parameters.AddWithValue("@fecha", DateAndTime.Now)

                        insertar_usuario3.ExecuteNonQuery()
#End Region
                        MenuA.Show()

                    Else
                        MenuC.Show()
                    End If 
                Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("El Usuario: " + txtUsuario.Text + " no se encuentra registrado")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub


End Class