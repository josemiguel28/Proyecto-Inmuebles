<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUsuarios
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
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnDesabilitar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscarRol = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtIdRol = New System.Windows.Forms.TextBox()
        Me.txtRolDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIDUsuario = New System.Windows.Forms.TextBox()
        Me.btnHabilitar = New System.Windows.Forms.Button()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(78, 220)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.RowHeadersWidth = 51
        Me.dgvUsuarios.RowTemplate.Height = 24
        Me.dgvUsuarios.Size = New System.Drawing.Size(610, 294)
        Me.dgvUsuarios.TabIndex = 0
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(546, 68)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(85, 24)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(546, 28)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 23)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnDesabilitar
        '
        Me.btnDesabilitar.Location = New System.Drawing.Point(546, 109)
        Me.btnDesabilitar.Name = "btnDesabilitar"
        Me.btnDesabilitar.Size = New System.Drawing.Size(85, 26)
        Me.btnDesabilitar.TabIndex = 3
        Me.btnDesabilitar.Text = "Desabilitar"
        Me.btnDesabilitar.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(138, 55)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 22)
        Me.txtUsuario.TabIndex = 4
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(140, 106)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(100, 22)
        Me.txtEstado.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Estado:  "
        '
        'btnBuscarRol
        '
        Me.btnBuscarRol.Location = New System.Drawing.Point(114, 162)
        Me.btnBuscarRol.Name = "btnBuscarRol"
        Me.btnBuscarRol.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarRol.TabIndex = 9
        Me.btnBuscarRol.Text = "Buscar"
        Me.btnBuscarRol.UseVisualStyleBackColor = True
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(77, 165)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(31, 16)
        Me.lbl.TabIndex = 10
        Me.lbl.Text = "Rol:"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtIdRol
        '
        Me.txtIdRol.Location = New System.Drawing.Point(114, 191)
        Me.txtIdRol.Name = "txtIdRol"
        Me.txtIdRol.ReadOnly = True
        Me.txtIdRol.Size = New System.Drawing.Size(31, 22)
        Me.txtIdRol.TabIndex = 11
        '
        'txtRolDescripcion
        '
        Me.txtRolDescripcion.Location = New System.Drawing.Point(152, 192)
        Me.txtRolDescripcion.Name = "txtRolDescripcion"
        Me.txtRolDescripcion.ReadOnly = True
        Me.txtRolDescripcion.Size = New System.Drawing.Size(100, 22)
        Me.txtRolDescripcion.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ID:"
        '
        'txtIDUsuario
        '
        Me.txtIDUsuario.Location = New System.Drawing.Point(104, 12)
        Me.txtIDUsuario.Name = "txtIDUsuario"
        Me.txtIDUsuario.Size = New System.Drawing.Size(100, 22)
        Me.txtIDUsuario.TabIndex = 13
        '
        'btnHabilitar
        '
        Me.btnHabilitar.Location = New System.Drawing.Point(546, 155)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(85, 26)
        Me.btnHabilitar.TabIndex = 15
        Me.btnHabilitar.Text = "Habilitar"
        Me.btnHabilitar.UseVisualStyleBackColor = True
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 546)
        Me.Controls.Add(Me.btnHabilitar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIDUsuario)
        Me.Controls.Add(Me.txtRolDescripcion)
        Me.Controls.Add(Me.txtIdRol)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.btnBuscarRol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnDesabilitar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Name = "GestionUsuarios"
        Me.Text = "GestionUsuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnDesabilitar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscarRol As Button
    Friend WithEvents lbl As Label
    Friend WithEvents txtIdRol As TextBox
    Friend WithEvents txtRolDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIDUsuario As TextBox
    Friend WithEvents btnHabilitar As Button
End Class
