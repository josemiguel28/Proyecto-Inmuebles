Imports System.Data.SqlClient

Public Class Compras

    Private dtproducto As New DataView
    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.pa_ListarCompras' Puede moverla o quitarla según sea necesario.
        Me.Pa_ListarComprasTableAdapter.Fill(Me.DataSet1.pa_ListarCompras)
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

        Dim adaptador_producto As New SqlDataAdapter("exec pa_ListarCompras", conexion)
        'guardar en dtproducto


        Dim ds As New DataSet

        adaptador_producto.Fill(ds)

        dtproducto.Table = ds.Tables(0)

        dgvCompras.DataSource = dtproducto

        conexion.Close()

        'calcular el total de ventas 
        Dim total As Integer
        Dim row As DataGridViewRow = New DataGridViewRow()
        total = 0

        For Each row In dgvCompras.Rows
            total += Convert.ToDouble(row.Cells("costo").Value)
        Next

        txtTotalIngresos.Text = Convert.ToString(total)
    End Sub

    Private Sub txtFiltroInmueble_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroInmueble.TextChanged
        dtproducto.RowFilter = String.Format("Inmueble like '%{0}%'", txtFiltroInmueble.Text)
    End Sub

    Private Sub txtFiltroCliente_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroCliente.TextChanged
        dtproducto.RowFilter = String.Format("Cliente like '%{0}%'", txtFiltroCliente.Text)
    End Sub

End Class