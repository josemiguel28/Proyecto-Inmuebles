<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionAlquileresPagos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvPagosAlquiler = New System.Windows.Forms.DataGridView()
        Me.PagoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alquiler = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaListarPagosAlquilerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquileres = New Proyecto.alquileres()
        Me.txtTotalIngresos = New System.Windows.Forms.TextBox()
        Me.Pa_ListarPagosAlquilerTableAdapter = New Proyecto.alquileresTableAdapters.pa_ListarPagosAlquilerTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvPagosAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaListarPagosAlquilerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquileres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPagosAlquiler
        '
        Me.dgvPagosAlquiler.AutoGenerateColumns = False
        Me.dgvPagosAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagosAlquiler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PagoIDDataGridViewTextBoxColumn, Me.Alquiler, Me.costo, Me.FechaDataGridViewTextBoxColumn})
        Me.dgvPagosAlquiler.DataSource = Me.PaListarPagosAlquilerBindingSource
        Me.dgvPagosAlquiler.Location = New System.Drawing.Point(32, 74)
        Me.dgvPagosAlquiler.Name = "dgvPagosAlquiler"
        Me.dgvPagosAlquiler.RowHeadersWidth = 51
        Me.dgvPagosAlquiler.RowTemplate.Height = 24
        Me.dgvPagosAlquiler.Size = New System.Drawing.Size(687, 277)
        Me.dgvPagosAlquiler.TabIndex = 0
        '
        'PagoIDDataGridViewTextBoxColumn
        '
        Me.PagoIDDataGridViewTextBoxColumn.DataPropertyName = "Pago ID"
        Me.PagoIDDataGridViewTextBoxColumn.HeaderText = "Pago ID"
        Me.PagoIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PagoIDDataGridViewTextBoxColumn.Name = "PagoIDDataGridViewTextBoxColumn"
        Me.PagoIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PagoIDDataGridViewTextBoxColumn.Width = 125
        '
        'Alquiler
        '
        Me.Alquiler.DataPropertyName = "NoAlquiler"
        Me.Alquiler.HeaderText = "NoAlquiler"
        Me.Alquiler.MinimumWidth = 6
        Me.Alquiler.Name = "Alquiler"
        Me.Alquiler.Width = 125
        '
        'costo
        '
        Me.costo.DataPropertyName = "Costo"
        Me.costo.HeaderText = "Costo"
        Me.costo.MinimumWidth = 6
        Me.costo.Name = "costo"
        Me.costo.Width = 125
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 125
        '
        'PaListarPagosAlquilerBindingSource
        '
        Me.PaListarPagosAlquilerBindingSource.DataMember = "pa_ListarPagosAlquiler"
        Me.PaListarPagosAlquilerBindingSource.DataSource = Me.Alquileres
        '
        'Alquileres
        '
        Me.Alquileres.DataSetName = "alquileres"
        Me.Alquileres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTotalIngresos
        '
        Me.txtTotalIngresos.Location = New System.Drawing.Point(619, 370)
        Me.txtTotalIngresos.Name = "txtTotalIngresos"
        Me.txtTotalIngresos.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalIngresos.TabIndex = 1
        '
        'Pa_ListarPagosAlquilerTableAdapter
        '
        Me.Pa_ListarPagosAlquilerTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(495, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total de Ingresos: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gestion de Pagos de Alquiler"
        '
        'GestionAlquileresPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 442)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalIngresos)
        Me.Controls.Add(Me.dgvPagosAlquiler)
        Me.Name = "GestionAlquileresPagos"
        Me.Text = "GestionAlquileresPagos"
        CType(Me.dgvPagosAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaListarPagosAlquilerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquileres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPagosAlquiler As DataGridView
    Friend WithEvents txtTotalIngresos As TextBox
    Friend WithEvents Alquileres As alquileres
    Friend WithEvents PaListarPagosAlquilerBindingSource As BindingSource
    Friend WithEvents Pa_ListarPagosAlquilerTableAdapter As alquileresTableAdapters.pa_ListarPagosAlquilerTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PagoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Alquiler As DataGridViewTextBoxColumn
    Friend WithEvents costo As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
