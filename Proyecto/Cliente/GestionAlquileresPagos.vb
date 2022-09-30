Imports System.Data.SqlClient

Public Class GestionAlquileresPagos

    Private dtproducto As New DataView
    Private Sub GestionAlquileresPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Alquileres.pa_ListarPagosAlquiler' Puede moverla o quitarla según sea necesario.
        Me.Pa_ListarPagosAlquilerTableAdapter.Fill(Me.Alquileres.pa_ListarPagosAlquiler)


#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region


        Dim adaptador_producto As New SqlDataAdapter("exec pa_ListarPagosAlquiler", conexion)
        'guardar en dtproducto


        Dim ds As New DataSet

        adaptador_producto.Fill(ds)

        dtproducto.Table = ds.Tables(0)

        dgvPagosAlquiler.DataSource = dtproducto

        conexion.Close()

        'calcular el total de ventas 
        Dim total As Integer
        Dim row As DataGridViewRow = New DataGridViewRow()
        total = 0

        For Each row In dgvPagosAlquiler.Rows
            total += Convert.ToDouble(row.Cells("costo").Value)
        Next

        txtTotalIngresos.Text = Convert.ToString(total)
    End Sub

End Class