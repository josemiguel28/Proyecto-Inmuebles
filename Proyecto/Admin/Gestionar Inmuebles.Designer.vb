<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestionar_Inmuebles
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
        Me.dgvInmuebles = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdInmueble = New System.Windows.Forms.TextBox()
        Me.txtNombreInmueble = New System.Windows.Forms.TextBox()
        Me.txtMetrosInmueble = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoCalleInmueble = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreCalle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDeshabilitar = New System.Windows.Forms.Button()
        Me.btnHabilitar = New System.Windows.Forms.Button()
        Me.btnMostrarEnUso = New System.Windows.Forms.Button()
        Me.btnInmueblesSinUso = New System.Windows.Forms.Button()
        Me.btnInmueblesDehabilitados = New System.Windows.Forms.Button()
        Me.btnMostrarInmubles = New System.Windows.Forms.Button()
        CType(Me.dgvInmuebles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInmuebles
        '
        Me.dgvInmuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInmuebles.Location = New System.Drawing.Point(25, 244)
        Me.dgvInmuebles.Name = "dgvInmuebles"
        Me.dgvInmuebles.RowHeadersWidth = 51
        Me.dgvInmuebles.RowTemplate.Height = 24
        Me.dgvInmuebles.Size = New System.Drawing.Size(1122, 405)
        Me.dgvInmuebles.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(366, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inmuebles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(214, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Inmueble:"
        '
        'txtIdInmueble
        '
        Me.txtIdInmueble.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdInmueble.Location = New System.Drawing.Point(64, 68)
        Me.txtIdInmueble.Name = "txtIdInmueble"
        Me.txtIdInmueble.Size = New System.Drawing.Size(100, 24)
        Me.txtIdInmueble.TabIndex = 4
        '
        'txtNombreInmueble
        '
        Me.txtNombreInmueble.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreInmueble.Location = New System.Drawing.Point(279, 71)
        Me.txtNombreInmueble.Name = "txtNombreInmueble"
        Me.txtNombreInmueble.Size = New System.Drawing.Size(100, 24)
        Me.txtNombreInmueble.TabIndex = 5
        '
        'txtMetrosInmueble
        '
        Me.txtMetrosInmueble.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMetrosInmueble.Location = New System.Drawing.Point(460, 68)
        Me.txtMetrosInmueble.Name = "txtMetrosInmueble"
        Me.txtMetrosInmueble.Size = New System.Drawing.Size(100, 24)
        Me.txtMetrosInmueble.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(403, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Metros:"
        '
        'txtNoCalleInmueble
        '
        Me.txtNoCalleInmueble.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCalleInmueble.Location = New System.Drawing.Point(104, 117)
        Me.txtNoCalleInmueble.Name = "txtNoCalleInmueble"
        Me.txtNoCalleInmueble.Size = New System.Drawing.Size(117, 24)
        Me.txtNoCalleInmueble.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "No. Calle:"
        '
        'txtNombreCalle
        '
        Me.txtNombreCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCalle.Location = New System.Drawing.Point(703, 65)
        Me.txtNombreCalle.Name = "txtNombreCalle"
        Me.txtNombreCalle.Size = New System.Drawing.Size(112, 24)
        Me.txtNombreCalle.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(590, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nombre Calle: "
        '
        'txtCiudad
        '
        Me.txtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Location = New System.Drawing.Point(305, 120)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(128, 24)
        Me.txtCiudad.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(241, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Ciudad:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(900, 23)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(90, 44)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(900, 93)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(90, 44)
        Me.btnEditar.TabIndex = 15
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(900, 163)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(90, 44)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(513, 117)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 24)
        Me.txtPrecio.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(448, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Precio:"
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(703, 120)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(112, 24)
        Me.txtEstado.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(638, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 18)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Estado:"
        '
        'btnDeshabilitar
        '
        Me.btnDeshabilitar.Location = New System.Drawing.Point(1037, 93)
        Me.btnDeshabilitar.Name = "btnDeshabilitar"
        Me.btnDeshabilitar.Size = New System.Drawing.Size(90, 44)
        Me.btnDeshabilitar.TabIndex = 21
        Me.btnDeshabilitar.Text = "Deshabilitar"
        Me.btnDeshabilitar.UseVisualStyleBackColor = True
        '
        'btnHabilitar
        '
        Me.btnHabilitar.Location = New System.Drawing.Point(1037, 23)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(90, 44)
        Me.btnHabilitar.TabIndex = 22
        Me.btnHabilitar.Text = "Habilitar"
        Me.btnHabilitar.UseVisualStyleBackColor = True
        '
        'btnMostrarEnUso
        '
        Me.btnMostrarEnUso.Location = New System.Drawing.Point(478, 182)
        Me.btnMostrarEnUso.Name = "btnMostrarEnUso"
        Me.btnMostrarEnUso.Size = New System.Drawing.Size(135, 56)
        Me.btnMostrarEnUso.TabIndex = 23
        Me.btnMostrarEnUso.Text = "Mostrar Inmuebles En Uso"
        Me.btnMostrarEnUso.UseVisualStyleBackColor = True
        '
        'btnInmueblesSinUso
        '
        Me.btnInmueblesSinUso.Location = New System.Drawing.Point(630, 182)
        Me.btnInmueblesSinUso.Name = "btnInmueblesSinUso"
        Me.btnInmueblesSinUso.Size = New System.Drawing.Size(135, 56)
        Me.btnInmueblesSinUso.TabIndex = 24
        Me.btnInmueblesSinUso.Text = "Mostrar Inmuebles Sin Usar"
        Me.btnInmueblesSinUso.UseVisualStyleBackColor = True
        '
        'btnInmueblesDehabilitados
        '
        Me.btnInmueblesDehabilitados.Location = New System.Drawing.Point(327, 182)
        Me.btnInmueblesDehabilitados.Name = "btnInmueblesDehabilitados"
        Me.btnInmueblesDehabilitados.Size = New System.Drawing.Size(135, 56)
        Me.btnInmueblesDehabilitados.TabIndex = 25
        Me.btnInmueblesDehabilitados.Text = "Mostrar Inmuebles Deshabilitados"
        Me.btnInmueblesDehabilitados.UseVisualStyleBackColor = True
        '
        'btnMostrarInmubles
        '
        Me.btnMostrarInmubles.Location = New System.Drawing.Point(177, 182)
        Me.btnMostrarInmubles.Name = "btnMostrarInmubles"
        Me.btnMostrarInmubles.Size = New System.Drawing.Size(135, 56)
        Me.btnMostrarInmubles.TabIndex = 26
        Me.btnMostrarInmubles.Text = "Mostrar Todos Los Inmuebles "
        Me.btnMostrarInmubles.UseVisualStyleBackColor = True
        '
        'Gestionar_Inmuebles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 686)
        Me.Controls.Add(Me.btnMostrarInmubles)
        Me.Controls.Add(Me.btnInmueblesDehabilitados)
        Me.Controls.Add(Me.btnInmueblesSinUso)
        Me.Controls.Add(Me.btnMostrarEnUso)
        Me.Controls.Add(Me.btnHabilitar)
        Me.Controls.Add(Me.btnDeshabilitar)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNombreCalle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNoCalleInmueble)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMetrosInmueble)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombreInmueble)
        Me.Controls.Add(Me.txtIdInmueble)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvInmuebles)
        Me.Name = "Gestionar_Inmuebles"
        Me.Text = "Gestionar_Inmuebles"
        CType(Me.dgvInmuebles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvInmuebles As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdInmueble As TextBox
    Friend WithEvents txtNombreInmueble As TextBox
    Friend WithEvents txtMetrosInmueble As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNoCalleInmueble As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombreCalle As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnDeshabilitar As Button
    Friend WithEvents btnHabilitar As Button
    Friend WithEvents btnMostrarEnUso As Button
    Friend WithEvents btnInmueblesSinUso As Button
    Friend WithEvents btnInmueblesDehabilitados As Button
    Friend WithEvents btnMostrarInmubles As Button
End Class
