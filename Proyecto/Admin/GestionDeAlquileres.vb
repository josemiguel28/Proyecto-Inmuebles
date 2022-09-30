Imports System.Data.SqlClient

Public Class GestionDeAlquileres


    Private dtproducto As New DataView
    Private Sub GestionDeAlquileres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Pa_GestionAlquilerTableAdapter.Fill(Me.DataSet1.pa_GestionAlquiler)
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region

        Dim adaptador_producto As New SqlDataAdapter("exec pa_GestionAlquiler", conexion)
        'guardar en dtproducto


        Dim ds As New DataSet

        adaptador_producto.Fill(ds)

        dtproducto.Table = ds.Tables(0)

        dgvAlquiler.DataSource = dtproducto

        conexion.Close()

    End Sub

    Private Sub txtNOAlquiler_TextChanged(sender As Object, e As EventArgs) Handles txtNOAlquiler.TextChanged
        dtproducto.RowFilter = String.Format("convert(ID, 'System.String') like '%{0}%'", txtNOAlquiler.Text)

    End Sub

    Private Sub txtNombreInmueble_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroInmueble.TextChanged
        dtproducto.RowFilter = String.Format("Inmueble like '%{0}%'", txtFiltroInmueble.Text)

    End Sub

    Private Sub txtNombreCliente_TextChanged(sender As Object, e As EventArgs) Handles txtNombreCliente.TextChanged
        dtproducto.RowFilter = String.Format("Cliente like '%{0}%'", txtNombreCliente.Text)

    End Sub

    Private Sub btnCancelarAlquiler_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub dgvAlquiler_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlquiler.CellContentDoubleClick
        txtIDAlquiler.Text = dgvAlquiler.CurrentRow.Cells(0).Value
        txtNombreInmueble.Text = dgvAlquiler.CurrentRow.Cells(1).Value
        txtClienteAlquiler.Text = dgvAlquiler.CurrentRow.Cells(3).Value

    End Sub

    Private Sub btnCancelarAlquiler_Click_1(sender As Object, e As EventArgs) Handles btnCancelarAlquiler.Click
#Region "Conexion"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-DQ5RIOU;Initial Catalog=DB_Alquileres;Integrated Security=True"
        conexion.Open()
#End Region
        Dim mensaje As MsgBoxResult
        'consulta para la tabla de alquileres
        Dim insertar As String = "update alquiler set estado = @estado where numero_alquiler =@cod_alquiler"
        Dim estado As String
        estado = "Sin Usar"


        mensaje = MsgBox("Desea Cancelar este Contrato?", vbYesNo, "Cancelar")

        If (mensaje = vbYes) Then
#Region "Insertar en la tabla alquileres"
            Dim actualizar_alquiler As New SqlCommand(insertar, conexion)
            actualizar_alquiler.Parameters.AddWithValue("@estado", estado)
            actualizar_alquiler.Parameters.AddWithValue("@cod_alquiler", txtIDAlquiler.Text)

            actualizar_alquiler.ExecuteNonQuery()
#Region "Actualiza Grid"
            Dim adaptador_producto As New SqlDataAdapter("exec pa_GestionAlquiler", conexion)
            'guardar en dtproducto


            Dim ds As New DataSet

            adaptador_producto.Fill(ds)

            dtproducto.Table = ds.Tables(0)

            dgvAlquiler.DataSource = dtproducto

            conexion.Close()
#End Region
        Else
            MsgBox("No se realizaron cambios")
        End If
#End Region
    End Sub
End Class