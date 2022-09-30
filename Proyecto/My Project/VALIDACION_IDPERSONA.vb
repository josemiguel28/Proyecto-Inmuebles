Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class VALIDACION_IDPERSONA
    Public cn As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader

    Sub New()
        Try
            cn = New SqlConnection("Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True")
            cn.Open()

        Catch ex As Exception
            MsgBox("Error al conectarse debido a: " + ex.ToString)
        End Try
    End Sub

    Function personaRegistrada(ByVal id As String) As Boolean
        Dim resultado As Boolean = False
        Try
            cmd = New SqlCommand("Select * from Personas where id_persona='" & id & "'", cn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error en el procedimiento: " + ex.ToString)
        End Try
        Return resultado
    End Function

End Class
