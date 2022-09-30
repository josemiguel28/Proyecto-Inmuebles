Imports System.Data.SqlClient

Public Class ConsultaNO

    Public Function consultaID() As String   ''genera el siguiente id de alquiler en el form Realizar alquiler

        Using conexion As New SqlClient.SqlConnection
            conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
            conexion.Open()


            Using daClientes As New SqlCommand("select (select distinct top 1 numero_alquiler from Alquiler order by numero_alquiler desc) + 1 as numero_alquiler", conexion)   'ejecuta el proc y se guarda en daclientes

                Using reg As SqlDataReader = daClientes.ExecuteReader()

                    If reg.Read Then
                        Return reg("numero_alquiler").ToString()
                    Else
                        Return "Null"
                    End If
                End Using
            End Using
        End Using

    End Function

    Public Function GenerarIDEmpleado() As String   ''genera un id random de empleado en el form de realizaralquiler

        Using conexion As New SqlClient.SqlConnection
            conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
            conexion.Open()


            Using Empleados As New SqlCommand("select cod_empleado from empleados order by NEWID()", conexion)

                Using idEmpleado As SqlDataReader = Empleados.ExecuteReader()

                    If idEmpleado.Read Then
                        Return idEmpleado("cod_empleado").ToString()
                    Else
                        Return "Null"
                    End If
                End Using
            End Using
        End Using

    End Function

    Public Function consultaIDCompra() As String   ''genera el siguiente id de alquiler en el form Realizar alquiler

        Using conexion As New SqlClient.SqlConnection
            conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
            conexion.Open()


            Using daClientes As New SqlCommand("select (select distinct top 1 cod_compra from Compras order by cod_compra desc) + 1 as numero_compra", conexion)   'ejecuta el proc y se guarda en daclientes

                Using reg As SqlDataReader = daClientes.ExecuteReader()

                    If reg.Read Then
                        Return reg("numero_compra").ToString()
                    Else
                        Return "Null"
                    End If
                End Using
            End Using
        End Using

    End Function

End Class
