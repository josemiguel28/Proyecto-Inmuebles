Imports System.Data.SqlClient

Public Class UsuariosRol
    Private Sub UsuariosRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()

        Dim dtproducto As New DataTable

        Using adaptador_rol As New SqlDataAdapter("exec pa_listarRolUsuarios", conexion)
            'guardar en dtproducto
            adaptador_rol.Fill(dtproducto)

        End Using
        conexion.Close()
        dgvUsuariosRol.DataSource = dtproducto
    End Sub

    Private Sub dgvUsuariosRol_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuariosRol.CellContentDoubleClick
        GestionUsuarios.txtIdRol.Text = dgvUsuariosRol.CurrentRow.Cells(0).Value
        GestionUsuarios.txtRolDescripcion.Text = dgvUsuariosRol.CurrentRow.Cells(1).Value

        Me.Close()
    End Sub


End Class