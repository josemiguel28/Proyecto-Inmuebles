<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Compras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvCompras = New System.Windows.Forms.DataGridView()
        Me.IDCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InmuebleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeAdquisicionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaListarComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Proyecto.DataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalIngresos = New System.Windows.Forms.TextBox()
        Me.Pa_ListarComprasTableAdapter = New Proyecto.DataSet1TableAdapters.pa_ListarComprasTableAdapter()
        Me.txtFiltroInmueble = New System.Windows.Forms.TextBox()
        Me.txtFiltroCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaListarComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCompras
        '
        Me.dgvCompras.AutoGenerateColumns = False
        Me.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCompraDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.InmuebleDataGridViewTextBoxColumn, Me.Costo, Me.FechaDeAdquisicionDataGridViewTextBoxColumn})
        Me.dgvCompras.DataSource = Me.PaListarComprasBindingSource
        Me.dgvCompras.Location = New System.Drawing.Point(96, 161)
        Me.dgvCompras.Name = "dgvCompras"
        Me.dgvCompras.RowHeadersWidth = 51
        Me.dgvCompras.RowTemplate.Height = 24
        Me.dgvCompras.Size = New System.Drawing.Size(843, 266)
        Me.dgvCompras.TabIndex = 0
        '
        'IDCompraDataGridViewTextBoxColumn
        '
        Me.IDCompraDataGridViewTextBoxColumn.DataPropertyName = "ID Compra"
        Me.IDCompraDataGridViewTextBoxColumn.HeaderText = "ID Compra"
        Me.IDCompraDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDCompraDataGridViewTextBoxColumn.Name = "IDCompraDataGridViewTextBoxColumn"
        Me.IDCompraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCompraDataGridViewTextBoxColumn.Width = 125
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 125
        '
        'InmuebleDataGridViewTextBoxColumn
        '
        Me.InmuebleDataGridViewTextBoxColumn.DataPropertyName = "Inmueble"
        Me.InmuebleDataGridViewTextBoxColumn.HeaderText = "Inmueble"
        Me.InmuebleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InmuebleDataGridViewTextBoxColumn.Name = "InmuebleDataGridViewTextBoxColumn"
        Me.InmuebleDataGridViewTextBoxColumn.Width = 125
        '
        'Costo
        '
        Me.Costo.DataPropertyName = "Costo"
        Me.Costo.HeaderText = "Costo"
        Me.Costo.MinimumWidth = 6
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        Me.Costo.Width = 125
        '
        'FechaDeAdquisicionDataGridViewTextBoxColumn
        '
        Me.FechaDeAdquisicionDataGridViewTextBoxColumn.DataPropertyName = "Fecha de Adquisicion"
        Me.FechaDeAdquisicionDataGridViewTextBoxColumn.HeaderText = "Fecha de Adquisicion"
        Me.FechaDeAdquisicionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaDeAdquisicionDataGridViewTextBoxColumn.Name = "FechaDeAdquisicionDataGridViewTextBoxColumn"
        Me.FechaDeAdquisicionDataGridViewTextBoxColumn.Width = 125
        '
        'PaListarComprasBindingSource
        '
        Me.PaListarComprasBindingSource.DataMember = "pa_ListarCompras"
        Me.PaListarComprasBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(468, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Compras"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(721, 475)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total de Ingresos"
        '
        'txtTotalIngresos
        '
        Me.txtTotalIngresos.Location = New System.Drawing.Point(839, 469)
        Me.txtTotalIngresos.Name = "txtTotalIngresos"
        Me.txtTotalIngresos.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalIngresos.TabIndex = 3
        '
        'Pa_ListarComprasTableAdapter
        '
        Me.Pa_ListarComprasTableAdapter.ClearBeforeFill = True
        '
        'txtFiltroInmueble
        '
        Me.txtFiltroInmueble.Location = New System.Drawing.Point(167, 97)
        Me.txtFiltroInmueble.Name = "txtFiltroInmueble"
        Me.txtFiltroInmueble.Size = New System.Drawing.Size(100, 22)
        Me.txtFiltroInmueble.TabIndex = 4
        '
        'txtFiltroCliente
        '
        Me.txtFiltroCliente.Location = New System.Drawing.Point(153, 52)
        Me.txtFiltroCliente.Name = "txtFiltroCliente"
        Me.txtFiltroCliente.Size = New System.Drawing.Size(100, 22)
        Me.txtFiltroCliente.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Filtrar Por Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Filtrar Por Inmueble"
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 517)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFiltroCliente)
        Me.Controls.Add(Me.txtFiltroInmueble)
        Me.Controls.Add(Me.txtTotalIngresos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCompras)
        Me.Name = "Compras"
        Me.Text = "Compras"
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaListarComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCompras As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalIngresos As TextBox
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents PaListarComprasBindingSource As BindingSource
    Friend WithEvents Pa_ListarComprasTableAdapter As DataSet1TableAdapters.pa_ListarComprasTableAdapter
    Friend WithEvents IDCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InmuebleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeAdquisicionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtFiltroInmueble As TextBox
    Friend WithEvents txtFiltroCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
