Imports System.Data.SqlClient

Public Class fmrRoles
    Private Sub fmrRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()

        Dim dtproducto As New DataTable

        Using adaptador_rol As New SqlDataAdapter("exec pa_ListarRol", conexion)
            'guardar en dtproducto
            adaptador_rol.Fill(dtproducto)

        End Using
        conexion.Close()
        dgvRoles.DataSource = dtproducto
    End Sub

    Private Sub dgvRoles_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRoles.CellContentDoubleClick
        Gestionar_Personas.txtCodigoRol.Text = dgvRoles.CurrentRow.Cells(0).Value
        Gestionar_Personas.txtNombreRol.Text = dgvRoles.CurrentRow.Cells(1).Value

        Me.Close()
    End Sub
End Class