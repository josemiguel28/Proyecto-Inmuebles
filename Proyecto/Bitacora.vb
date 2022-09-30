Imports System.Data.SqlClient

Public Class Bitacora
    Private Sub Bitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("select usuario[Usuario],tabla_afectada[Tabla Afectada],accion_realizada[Accion Realizada],fecha[Fecha] from bitacora order by fecha asc", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvBitacora.DataSource = dtpersonas
#End Region
    End Sub
End Class