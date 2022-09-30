<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesCompra
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
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.groupbox = New System.Windows.Forms.GroupBox()
        Me.txtIDCompra = New System.Windows.Forms.TextBox()
        Me.txtCostoInmueble = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreInmueble = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIDPersona = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(169, 496)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(140, 53)
        Me.btnConfirmar.TabIndex = 17
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(345, 421)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(117, 22)
        Me.txtTotal.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(270, 423)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Total:"
        '
        'groupbox
        '
        Me.groupbox.Controls.Add(Me.txtIDCompra)
        Me.groupbox.Controls.Add(Me.txtCostoInmueble)
        Me.groupbox.Controls.Add(Me.Label6)
        Me.groupbox.Controls.Add(Me.Label3)
        Me.groupbox.Controls.Add(Me.txtNombreInmueble)
        Me.groupbox.Controls.Add(Me.Label5)
        Me.groupbox.Controls.Add(Me.txtIDPersona)
        Me.groupbox.Controls.Add(Me.Label2)
        Me.groupbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupbox.Location = New System.Drawing.Point(37, 74)
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(425, 303)
        Me.groupbox.TabIndex = 14
        Me.groupbox.TabStop = False
        Me.groupbox.Text = "Detalles"
        '
        'txtIDCompra
        '
        Me.txtIDCompra.Location = New System.Drawing.Point(112, 35)
        Me.txtIDCompra.Name = "txtIDCompra"
        Me.txtIDCompra.Size = New System.Drawing.Size(121, 27)
        Me.txtIDCompra.TabIndex = 12
        '
        'txtCostoInmueble
        '
        Me.txtCostoInmueble.Location = New System.Drawing.Point(75, 196)
        Me.txtCostoInmueble.Name = "txtCostoInmueble"
        Me.txtCostoInmueble.Size = New System.Drawing.Size(158, 27)
        Me.txtCostoInmueble.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID Compra:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Costo:"
        '
        'txtNombreInmueble
        '
        Me.txtNombreInmueble.Location = New System.Drawing.Point(106, 140)
        Me.txtNombreInmueble.Name = "txtNombreInmueble"
        Me.txtNombreInmueble.Size = New System.Drawing.Size(158, 27)
        Me.txtNombreInmueble.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Inmueble: "
        '
        'txtIDPersona
        '
        Me.txtIDPersona.Location = New System.Drawing.Point(154, 83)
        Me.txtIDPersona.Name = "txtIDPersona"
        Me.txtIDPersona.Size = New System.Drawing.Size(158, 27)
        Me.txtIDPersona.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Identidad Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Detalles de la Compra"
        '
        'DetallesCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 561)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.groupbox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DetallesCompra"
        Me.Text = "DetallesCompra"
        Me.groupbox.ResumeLayout(False)
        Me.groupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfirmar As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents groupbox As GroupBox
    Friend WithEvents txtIDCompra As TextBox
    Friend WithEvents txtCostoInmueble As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreInmueble As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIDPersona As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
