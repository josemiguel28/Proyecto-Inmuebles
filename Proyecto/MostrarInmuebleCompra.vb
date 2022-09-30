Imports System.Data.SqlClient


Public Class MostrarInmuebleCompra
    Private Sub MostrarInmuebleCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

#Region "CargarGrid"
        Dim dtpersonas As New DataTable
        Using adaptador As New SqlDataAdapter("exec pa_MostrarInmueble", conexion)
            adaptador.Fill(dtpersonas)
        End Using

        dgvInmueblesC.DataSource = dtpersonas
#End Region
    End Sub


    Private Sub dgvInmueblesC_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInmueblesC.CellContentDoubleClick
        'pasa los datos al form de Realizar compra 
        RealizarCompra.txtIDInmueble.Text = dgvInmueblesC.CurrentRow.Cells(0).Value
        RealizarCompra.txtNombreInmueble.Text = dgvInmueblesC.CurrentRow.Cells(1).Value
        RealizarCompra.txtMetros.Text = dgvInmueblesC.CurrentRow.Cells(2).Value
        RealizarCompra.txtDireccion.Text = dgvInmueblesC.CurrentRow.Cells(3).Value
        RealizarCompra.txtCiudad.Text = dgvInmueblesC.CurrentRow.Cells(4).Value
        RealizarCompra.txtPrecio.Text = dgvInmueblesC.CurrentRow.Cells(5).Value


        ''pasa los datos al form realizar alquiler
        RealizarAlquiler.txtIDInmueble.Text = dgvInmueblesC.CurrentRow.Cells(0).Value
        RealizarAlquiler.txtNombreInmueble.Text = dgvInmueblesC.CurrentRow.Cells(1).Value
        RealizarAlquiler.txtMetros.Text = dgvInmueblesC.CurrentRow.Cells(2).Value
        RealizarAlquiler.txtDireccion.Text = dgvInmueblesC.CurrentRow.Cells(3).Value
        RealizarAlquiler.txtCiudad.Text = dgvInmueblesC.CurrentRow.Cells(4).Value
        RealizarAlquiler.txtPrecio.Text = dgvInmueblesC.CurrentRow.Cells(5).Value

        Me.Close()

    End Sub

End Class