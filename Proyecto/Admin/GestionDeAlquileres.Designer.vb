<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionDeAlquileres
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNOAlquiler = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFiltroInmueble = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataSet1 = New Proyecto.DataSet1()
        Me.PaGestionAlquilerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pa_GestionAlquilerTableAdapter = New Proyecto.DataSet1TableAdapters.pa_GestionAlquilerTableAdapter()
        Me.DataSet11 = New Proyecto.DataSet1()
        Me.PaGestionAlquilerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaGestionAlquilerBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvAlquiler = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inmueble = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaGestionAlquilerBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNombreInmueble = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtClienteAlquiler = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIDAlquiler = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancelarAlquiler = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaGestionAlquilerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaGestionAlquilerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaGestionAlquilerBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaGestionAlquilerBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Por No. Alquiler: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gestion de Alquileres"
        '
        'txtNOAlquiler
        '
        Me.txtNOAlquiler.Location = New System.Drawing.Point(121, 31)
        Me.txtNOAlquiler.Name = "txtNOAlquiler"
        Me.txtNOAlquiler.Size = New System.Drawing.Size(69, 22)
        Me.txtNOAlquiler.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombreCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtFiltroInmueble)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNOAlquiler)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 123)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(483, 18)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(95, 22)
        Me.txtNombreCliente.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(329, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Por Nombre De Cliente:"
        '
        'txtFiltroInmueble
        '
        Me.txtFiltroInmueble.Location = New System.Drawing.Point(175, 74)
        Me.txtFiltroInmueble.Name = "txtFiltroInmueble"
        Me.txtFiltroInmueble.Size = New System.Drawing.Size(102, 22)
        Me.txtFiltroInmueble.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Por Nombre de Inmueble:"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaGestionAlquilerBindingSource
        '
        Me.PaGestionAlquilerBindingSource.DataMember = "pa_GestionAlquiler"
        Me.PaGestionAlquilerBindingSource.DataSource = Me.DataSet1
        '
        'Pa_GestionAlquilerTableAdapter
        '
        Me.Pa_GestionAlquilerTableAdapter.ClearBeforeFill = True
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaGestionAlquilerBindingSource1
        '
        Me.PaGestionAlquilerBindingSource1.DataMember = "pa_GestionAlquiler"
        Me.PaGestionAlquilerBindingSource1.DataSource = Me.DataSet11
        '
        'PaGestionAlquilerBindingSource2
        '
        Me.PaGestionAlquilerBindingSource2.DataMember = "pa_GestionAlquiler"
        Me.PaGestionAlquilerBindingSource2.DataSource = Me.DataSet11
        '
        'dgvAlquiler
        '
        Me.dgvAlquiler.AutoGenerateColumns = False
        Me.dgvAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlquiler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Inmueble, Me.EmpleadoIDDataGridViewTextBoxColumn, Me.Cliente, Me.EstadoDataGridViewTextBoxColumn})
        Me.dgvAlquiler.DataSource = Me.PaGestionAlquilerBindingSource3
        Me.dgvAlquiler.Location = New System.Drawing.Point(39, 362)
        Me.dgvAlquiler.Name = "dgvAlquiler"
        Me.dgvAlquiler.RowHeadersWidth = 51
        Me.dgvAlquiler.RowTemplate.Height = 24
        Me.dgvAlquiler.Size = New System.Drawing.Size(838, 385)
        Me.dgvAlquiler.TabIndex = 6
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 125
        '
        'Inmueble
        '
        Me.Inmueble.DataPropertyName = "Inmueble"
        Me.Inmueble.HeaderText = "Inmueble"
        Me.Inmueble.MinimumWidth = 6
        Me.Inmueble.Name = "Inmueble"
        Me.Inmueble.Width = 125
        '
        'EmpleadoIDDataGridViewTextBoxColumn
        '
        Me.EmpleadoIDDataGridViewTextBoxColumn.DataPropertyName = "Empleado ID"
        Me.EmpleadoIDDataGridViewTextBoxColumn.HeaderText = "Empleado ID"
        Me.EmpleadoIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmpleadoIDDataGridViewTextBoxColumn.Name = "EmpleadoIDDataGridViewTextBoxColumn"
        Me.EmpleadoIDDataGridViewTextBoxColumn.Width = 125
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.MinimumWidth = 6
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 125
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.Width = 125
        '
        'PaGestionAlquilerBindingSource3
        '
        Me.PaGestionAlquilerBindingSource3.DataMember = "pa_GestionAlquiler"
        Me.PaGestionAlquilerBindingSource3.DataSource = Me.DataSet1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNombreInmueble)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtClienteAlquiler)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtIDAlquiler)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnCancelarAlquiler)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(773, 154)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cerrar Contrato"
        '
        'txtNombreInmueble
        '
        Me.txtNombreInmueble.Location = New System.Drawing.Point(78, 118)
        Me.txtNombreInmueble.Name = "txtNombreInmueble"
        Me.txtNombreInmueble.Size = New System.Drawing.Size(95, 22)
        Me.txtNombreInmueble.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Inmueble:"
        '
        'txtClienteAlquiler
        '
        Me.txtClienteAlquiler.Location = New System.Drawing.Point(74, 71)
        Me.txtClienteAlquiler.Name = "txtClienteAlquiler"
        Me.txtClienteAlquiler.Size = New System.Drawing.Size(137, 22)
        Me.txtClienteAlquiler.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cliente:"
        '
        'txtIDAlquiler
        '
        Me.txtIDAlquiler.Enabled = False
        Me.txtIDAlquiler.Location = New System.Drawing.Point(105, 30)
        Me.txtIDAlquiler.Name = "txtIDAlquiler"
        Me.txtIDAlquiler.ReadOnly = True
        Me.txtIDAlquiler.Size = New System.Drawing.Size(85, 22)
        Me.txtIDAlquiler.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "No. Alquiler: "
        '
        'btnCancelarAlquiler
        '
        Me.btnCancelarAlquiler.Location = New System.Drawing.Point(414, 107)
        Me.btnCancelarAlquiler.Name = "btnCancelarAlquiler"
        Me.btnCancelarAlquiler.Size = New System.Drawing.Size(135, 41)
        Me.btnCancelarAlquiler.TabIndex = 11
        Me.btnCancelarAlquiler.Text = "Cancelar Contrato"
        Me.btnCancelarAlquiler.UseVisualStyleBackColor = True
        '
        'GestionDeAlquileres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 800)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvAlquiler)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "GestionDeAlquileres"
        Me.Text = "GestionDeAlquileres"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaGestionAlquilerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaGestionAlquilerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaGestionAlquilerBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaGestionAlquilerBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNOAlquiler As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFiltroInmueble As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents PaGestionAlquilerBindingSource As BindingSource
    Friend WithEvents Pa_GestionAlquilerTableAdapter As DataSet1TableAdapters.pa_GestionAlquilerTableAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents PaGestionAlquilerBindingSource1 As BindingSource
    Friend WithEvents PaGestionAlquilerBindingSource2 As BindingSource
    Friend WithEvents dgvAlquiler As DataGridView
    Friend WithEvents PaGestionAlquilerBindingSource3 As BindingSource
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Inmueble As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNombreInmueble As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtClienteAlquiler As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIDAlquiler As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCancelarAlquiler As Button
End Class
