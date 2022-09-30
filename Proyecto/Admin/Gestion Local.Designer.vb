<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_Local
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
        Me.txtUso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Inmueble = New System.Windows.Forms.Label()
        Me.txtIDLocal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dgvLocal = New System.Windows.Forms.DataGridView()
        Me.txtIDInmueble = New System.Windows.Forms.TextBox()
        CType(Me.dgvLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUso
        '
        Me.txtUso.Location = New System.Drawing.Point(67, 110)
        Me.txtUso.Name = "txtUso"
        Me.txtUso.Size = New System.Drawing.Size(100, 22)
        Me.txtUso.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Uso:"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(122, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 17
        Me.TextBox2.Text = "Local"
        '
        'Inmueble
        '
        Me.Inmueble.AutoSize = True
        Me.Inmueble.Location = New System.Drawing.Point(27, 66)
        Me.Inmueble.Name = "Inmueble"
        Me.Inmueble.Size = New System.Drawing.Size(62, 16)
        Me.Inmueble.TabIndex = 16
        Me.Inmueble.Text = "Inmueble"
        '
        'txtIDLocal
        '
        Me.txtIDLocal.Location = New System.Drawing.Point(81, 18)
        Me.txtIDLocal.Name = "txtIDLocal"
        Me.txtIDLocal.Size = New System.Drawing.Size(100, 22)
        Me.txtIDLocal.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(430, 111)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(430, 66)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 12
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(430, 21)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'dgvLocal
        '
        Me.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLocal.Location = New System.Drawing.Point(30, 164)
        Me.dgvLocal.Name = "dgvLocal"
        Me.dgvLocal.ReadOnly = True
        Me.dgvLocal.RowHeadersWidth = 51
        Me.dgvLocal.RowTemplate.Height = 24
        Me.dgvLocal.Size = New System.Drawing.Size(475, 256)
        Me.dgvLocal.TabIndex = 10
        '
        'txtIDInmueble
        '
        Me.txtIDInmueble.Enabled = False
        Me.txtIDInmueble.Location = New System.Drawing.Point(95, 63)
        Me.txtIDInmueble.Name = "txtIDInmueble"
        Me.txtIDInmueble.ReadOnly = True
        Me.txtIDInmueble.Size = New System.Drawing.Size(21, 22)
        Me.txtIDInmueble.TabIndex = 20
        Me.txtIDInmueble.Text = "2"
        '
        'Gestion_Local
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 453)
        Me.Controls.Add(Me.txtIDInmueble)
        Me.Controls.Add(Me.txtUso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Inmueble)
        Me.Controls.Add(Me.txtIDLocal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dgvLocal)
        Me.Name = "Gestion_Local"
        Me.Text = "Gestion_Local"
        CType(Me.dgvLocal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUso As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Inmueble As Label
    Friend WithEvents txtIDLocal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dgvLocal As DataGridView
    Friend WithEvents txtIDInmueble As TextBox
End Class
