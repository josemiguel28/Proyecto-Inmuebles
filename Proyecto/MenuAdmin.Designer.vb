<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdmin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVerCompras = New System.Windows.Forms.Button()
        Me.btnGestionarInmuebles = New System.Windows.Forms.Button()
        Me.btnGestionarPersonas = New System.Windows.Forms.Button()
        Me.btnGarajes = New System.Windows.Forms.Button()
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.btnPisos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(390, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Bienvenido"
        '
        'btnVerCompras
        '
        Me.btnVerCompras.BackColor = System.Drawing.Color.White
        Me.btnVerCompras.Location = New System.Drawing.Point(46, 226)
        Me.btnVerCompras.Name = "btnVerCompras"
        Me.btnVerCompras.Size = New System.Drawing.Size(135, 83)
        Me.btnVerCompras.TabIndex = 6
        Me.btnVerCompras.Text = "Ver Compras"
        Me.btnVerCompras.UseVisualStyleBackColor = False
        '
        'btnGestionarInmuebles
        '
        Me.btnGestionarInmuebles.BackColor = System.Drawing.Color.White
        Me.btnGestionarInmuebles.Location = New System.Drawing.Point(270, 99)
        Me.btnGestionarInmuebles.Name = "btnGestionarInmuebles"
        Me.btnGestionarInmuebles.Size = New System.Drawing.Size(135, 83)
        Me.btnGestionarInmuebles.TabIndex = 5
        Me.btnGestionarInmuebles.Text = "Gestionar Inmuebles"
        Me.btnGestionarInmuebles.UseVisualStyleBackColor = False
        '
        'btnGestionarPersonas
        '
        Me.btnGestionarPersonas.BackColor = System.Drawing.Color.White
        Me.btnGestionarPersonas.Location = New System.Drawing.Point(46, 99)
        Me.btnGestionarPersonas.Name = "btnGestionarPersonas"
        Me.btnGestionarPersonas.Size = New System.Drawing.Size(135, 83)
        Me.btnGestionarPersonas.TabIndex = 4
        Me.btnGestionarPersonas.Text = "Gestionar Personas"
        Me.btnGestionarPersonas.UseVisualStyleBackColor = False
        '
        'btnGarajes
        '
        Me.btnGarajes.BackColor = System.Drawing.Color.White
        Me.btnGarajes.Location = New System.Drawing.Point(270, 226)
        Me.btnGarajes.Name = "btnGarajes"
        Me.btnGarajes.Size = New System.Drawing.Size(135, 83)
        Me.btnGarajes.TabIndex = 8
        Me.btnGarajes.Text = "Gestion de Garajes"
        Me.btnGarajes.UseVisualStyleBackColor = False
        '
        'btnLocal
        '
        Me.btnLocal.BackColor = System.Drawing.Color.White
        Me.btnLocal.Location = New System.Drawing.Point(46, 358)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(135, 83)
        Me.btnLocal.TabIndex = 9
        Me.btnLocal.Text = "Gestion de Locales"
        Me.btnLocal.UseVisualStyleBackColor = False
        '
        'btnPisos
        '
        Me.btnPisos.BackColor = System.Drawing.Color.White
        Me.btnPisos.Location = New System.Drawing.Point(270, 358)
        Me.btnPisos.Name = "btnPisos"
        Me.btnPisos.Size = New System.Drawing.Size(135, 83)
        Me.btnPisos.TabIndex = 10
        Me.btnPisos.Text = "Gestion de Pisos"
        Me.btnPisos.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(496, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 83)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Ver Mis Alquileres"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(496, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 83)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Adquirir Alquiler"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(496, 358)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 83)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Comprar Inmueble"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 505)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPisos)
        Me.Controls.Add(Me.btnLocal)
        Me.Controls.Add(Me.btnGarajes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVerCompras)
        Me.Controls.Add(Me.btnGestionarInmuebles)
        Me.Controls.Add(Me.btnGestionarPersonas)
        Me.Name = "MenuAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuAdmin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnVerCompras As Button
    Friend WithEvents btnGestionarInmuebles As Button
    Friend WithEvents btnGestionarPersonas As Button
    Friend WithEvents btnGarajes As Button
    Friend WithEvents btnLocal As Button
    Friend WithEvents btnPisos As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
