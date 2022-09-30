<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestionar_Personas
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoIdentidad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtMovil = New System.Windows.Forms.TextBox()
        Me.dgvPersonas = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnDesabilitar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNombreRol = New System.Windows.Forms.TextBox()
        Me.txtCodigoRol = New System.Windows.Forms.TextBox()
        Me.btnMostrarEmpleados = New System.Windows.Forms.Button()
        Me.btnMostrarClientes = New System.Windows.Forms.Button()
        Me.btnMostrarTodo = New System.Windows.Forms.Button()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnHabilitar = New System.Windows.Forms.Button()
        Me.validaciones = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.validaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestionar Personas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero de identidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Movil:"
        '
        'txtNoIdentidad
        '
        Me.txtNoIdentidad.Location = New System.Drawing.Point(197, 64)
        Me.txtNoIdentidad.Name = "txtNoIdentidad"
        Me.txtNoIdentidad.Size = New System.Drawing.Size(154, 22)
        Me.txtNoIdentidad.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(91, 106)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(126, 22)
        Me.txtNombre.TabIndex = 7
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(91, 148)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(126, 22)
        Me.txtApellido.TabIndex = 8
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(97, 238)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(120, 22)
        Me.txtTelefono.TabIndex = 9
        '
        'txtMovil
        '
        Me.txtMovil.Location = New System.Drawing.Point(71, 196)
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.Size = New System.Drawing.Size(126, 22)
        Me.txtMovil.TabIndex = 10
        '
        'dgvPersonas
        '
        Me.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonas.Location = New System.Drawing.Point(15, 432)
        Me.dgvPersonas.Name = "dgvPersonas"
        Me.dgvPersonas.RowHeadersWidth = 51
        Me.dgvPersonas.RowTemplate.Height = 24
        Me.dgvPersonas.Size = New System.Drawing.Size(993, 290)
        Me.dgvPersonas.TabIndex = 11
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(411, 55)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 40)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(411, 117)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(94, 40)
        Me.btnEditar.TabIndex = 13
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnDesabilitar
        '
        Me.btnDesabilitar.Location = New System.Drawing.Point(411, 187)
        Me.btnDesabilitar.Name = "btnDesabilitar"
        Me.btnDesabilitar.Size = New System.Drawing.Size(94, 40)
        Me.btnDesabilitar.TabIndex = 14
        Me.btnDesabilitar.Text = "Desabilitar"
        Me.btnDesabilitar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 364)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tipo Rol: "
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(226, 364)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(79, 25)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtNombreRol
        '
        Me.txtNombreRol.Enabled = False
        Me.txtNombreRol.Location = New System.Drawing.Point(87, 364)
        Me.txtNombreRol.Name = "txtNombreRol"
        Me.txtNombreRol.ReadOnly = True
        Me.txtNombreRol.Size = New System.Drawing.Size(120, 22)
        Me.txtNombreRol.TabIndex = 16
        '
        'txtCodigoRol
        '
        Me.txtCodigoRol.Enabled = False
        Me.txtCodigoRol.Location = New System.Drawing.Point(92, 336)
        Me.txtCodigoRol.Name = "txtCodigoRol"
        Me.txtCodigoRol.ReadOnly = True
        Me.txtCodigoRol.Size = New System.Drawing.Size(37, 22)
        Me.txtCodigoRol.TabIndex = 18
        '
        'btnMostrarEmpleados
        '
        Me.btnMostrarEmpleados.Location = New System.Drawing.Point(422, 346)
        Me.btnMostrarEmpleados.Name = "btnMostrarEmpleados"
        Me.btnMostrarEmpleados.Size = New System.Drawing.Size(122, 60)
        Me.btnMostrarEmpleados.TabIndex = 19
        Me.btnMostrarEmpleados.Text = "Mostrar Solo Empleados"
        Me.btnMostrarEmpleados.UseVisualStyleBackColor = True
        '
        'btnMostrarClientes
        '
        Me.btnMostrarClientes.Location = New System.Drawing.Point(567, 348)
        Me.btnMostrarClientes.Name = "btnMostrarClientes"
        Me.btnMostrarClientes.Size = New System.Drawing.Size(112, 56)
        Me.btnMostrarClientes.TabIndex = 20
        Me.btnMostrarClientes.Text = "Mostrar Solo Clientes"
        Me.btnMostrarClientes.UseVisualStyleBackColor = True
        '
        'btnMostrarTodo
        '
        Me.btnMostrarTodo.Location = New System.Drawing.Point(697, 348)
        Me.btnMostrarTodo.Name = "btnMostrarTodo"
        Me.btnMostrarTodo.Size = New System.Drawing.Size(112, 56)
        Me.btnMostrarTodo.TabIndex = 21
        Me.btnMostrarTodo.Text = "Mostrar Todos los Datos"
        Me.btnMostrarTodo.UseVisualStyleBackColor = True
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(86, 278)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(120, 22)
        Me.txtEstado.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Estado: "
        '
        'btnHabilitar
        '
        Me.btnHabilitar.Location = New System.Drawing.Point(411, 256)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(94, 40)
        Me.btnHabilitar.TabIndex = 24
        Me.btnHabilitar.Text = "Habilitar"
        Me.btnHabilitar.UseVisualStyleBackColor = True
        '
        'validaciones
        '
        Me.validaciones.ContainerControl = Me
        '
        'Gestionar_Personas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 747)
        Me.Controls.Add(Me.btnHabilitar)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnMostrarTodo)
        Me.Controls.Add(Me.btnMostrarClientes)
        Me.Controls.Add(Me.btnMostrarEmpleados)
        Me.Controls.Add(Me.txtCodigoRol)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtNombreRol)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnDesabilitar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvPersonas)
        Me.Controls.Add(Me.txtMovil)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtNoIdentidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Gestionar_Personas"
        Me.Text = " "
        CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.validaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNoIdentidad As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtMovil As TextBox
    Friend WithEvents dgvPersonas As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnDesabilitar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtNombreRol As TextBox
    Friend WithEvents txtCodigoRol As TextBox
    Friend WithEvents btnMostrarEmpleados As Button
    Friend WithEvents btnMostrarClientes As Button
    Friend WithEvents btnMostrarTodo As Button
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnHabilitar As Button
    Friend WithEvents validaciones As ErrorProvider
End Class
