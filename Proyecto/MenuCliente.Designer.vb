<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuCliente
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
        Me.btnVerAlquileres = New System.Windows.Forms.Button()
        Me.btnRealizarAlquiler = New System.Windows.Forms.Button()
        Me.btnComprarInmueble = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVerAlquileres
        '
        Me.btnVerAlquileres.Location = New System.Drawing.Point(43, 36)
        Me.btnVerAlquileres.Name = "btnVerAlquileres"
        Me.btnVerAlquileres.Size = New System.Drawing.Size(121, 56)
        Me.btnVerAlquileres.TabIndex = 0
        Me.btnVerAlquileres.Text = "Ver mis Alquileres "
        Me.btnVerAlquileres.UseVisualStyleBackColor = True
        '
        'btnRealizarAlquiler
        '
        Me.btnRealizarAlquiler.Location = New System.Drawing.Point(222, 36)
        Me.btnRealizarAlquiler.Name = "btnRealizarAlquiler"
        Me.btnRealizarAlquiler.Size = New System.Drawing.Size(121, 56)
        Me.btnRealizarAlquiler.TabIndex = 1
        Me.btnRealizarAlquiler.Text = "Realizar Nuevo Alquiler"
        Me.btnRealizarAlquiler.UseVisualStyleBackColor = True
        '
        'btnComprarInmueble
        '
        Me.btnComprarInmueble.Location = New System.Drawing.Point(43, 134)
        Me.btnComprarInmueble.Name = "btnComprarInmueble"
        Me.btnComprarInmueble.Size = New System.Drawing.Size(121, 56)
        Me.btnComprarInmueble.TabIndex = 2
        Me.btnComprarInmueble.Text = "Comprar un Inmueble"
        Me.btnComprarInmueble.UseVisualStyleBackColor = True
        '
        'MenuCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 427)
        Me.Controls.Add(Me.btnComprarInmueble)
        Me.Controls.Add(Me.btnRealizarAlquiler)
        Me.Controls.Add(Me.btnVerAlquileres)
        Me.Name = "MenuCliente"
        Me.Text = "MenuCliente"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVerAlquileres As Button
    Friend WithEvents btnRealizarAlquiler As Button
    Friend WithEvents btnComprarInmueble As Button
End Class
