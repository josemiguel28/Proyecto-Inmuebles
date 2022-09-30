<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TEMPFORM
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 67)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "FORM USUARIOS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(34, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 67)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "FORM LOCALES"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(268, 279)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 67)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "FORM PERSONAS"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(34, 279)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(125, 67)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "FORM EMPLEADOS"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(268, 154)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(125, 67)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "FORM CLIENTES"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(268, 48)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(125, 67)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "FORM TIPO USUARIO"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TEMPFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 624)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "TEMPFORM"
        Me.Text = "TEMPFORM"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
