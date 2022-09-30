<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuC
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuC))
        Me.PanelSlide = New System.Windows.Forms.Panel()
        Me.PanelSubMenuC = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelImagen = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PanelSubMenuAdmin = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelFormHijo = New System.Windows.Forms.Panel()
        Me.PanelSlide.SuspendLayout()
        Me.PanelSubMenuC.SuspendLayout()
        Me.PanelImagen.SuspendLayout()
        Me.PanelSubMenuAdmin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSlide
        '
        Me.PanelSlide.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.PanelSlide.Controls.Add(Me.PanelSubMenuAdmin)
        Me.PanelSlide.Controls.Add(Me.Button4)
        Me.PanelSlide.Controls.Add(Me.PanelSubMenuC)
        Me.PanelSlide.Controls.Add(Me.Button1)
        Me.PanelSlide.Controls.Add(Me.PanelImagen)
        Me.PanelSlide.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSlide.Location = New System.Drawing.Point(0, 0)
        Me.PanelSlide.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelSlide.Name = "PanelSlide"
        Me.PanelSlide.Size = New System.Drawing.Size(250, 655)
        Me.PanelSlide.TabIndex = 0
        '
        'PanelSubMenuC
        '
        Me.PanelSubMenuC.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.PanelSubMenuC.Controls.Add(Me.Button3)
        Me.PanelSubMenuC.Controls.Add(Me.Button2)
        Me.PanelSubMenuC.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuC.Location = New System.Drawing.Point(0, 162)
        Me.PanelSubMenuC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelSubMenuC.Name = "PanelSubMenuC"
        Me.PanelSubMenuC.Size = New System.Drawing.Size(250, 111)
        Me.PanelSubMenuC.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button3.Location = New System.Drawing.Point(0, 45)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(250, 45)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Realizar Alquiler"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(250, 45)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Realizar Compra"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(0, 116)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(250, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ver"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PanelImagen
        '
        Me.PanelImagen.Controls.Add(Me.PictureBox1)
        Me.PanelImagen.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelImagen.Location = New System.Drawing.Point(0, 0)
        Me.PanelImagen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelImagen.Name = "PanelImagen"
        Me.PanelImagen.Size = New System.Drawing.Size(250, 116)
        Me.PanelImagen.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button4.Location = New System.Drawing.Point(0, 273)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(250, 46)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Admin"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PanelSubMenuAdmin
        '
        Me.PanelSubMenuAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.PanelSubMenuAdmin.Controls.Add(Me.Button8)
        Me.PanelSubMenuAdmin.Controls.Add(Me.Button7)
        Me.PanelSubMenuAdmin.Controls.Add(Me.Button5)
        Me.PanelSubMenuAdmin.Controls.Add(Me.Button6)
        Me.PanelSubMenuAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuAdmin.Location = New System.Drawing.Point(0, 319)
        Me.PanelSubMenuAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelSubMenuAdmin.Name = "PanelSubMenuAdmin"
        Me.PanelSubMenuAdmin.Size = New System.Drawing.Size(250, 191)
        Me.PanelSubMenuAdmin.TabIndex = 4
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button5.Location = New System.Drawing.Point(0, 45)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(250, 45)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Gestion Compras"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button6.Location = New System.Drawing.Point(0, 0)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(250, 45)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Inmuebles"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button7.Location = New System.Drawing.Point(0, 90)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button7.Size = New System.Drawing.Size(250, 45)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Gestion Alquiler"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button8.Location = New System.Drawing.Point(0, 135)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button8.Size = New System.Drawing.Size(250, 45)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "Gestion Alquiler Pagos"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelFormHijo
        '
        Me.PanelFormHijo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormHijo.Location = New System.Drawing.Point(250, 0)
        Me.PanelFormHijo.Name = "PanelFormHijo"
        Me.PanelFormHijo.Size = New System.Drawing.Size(984, 655)
        Me.PanelFormHijo.TabIndex = 1
        '
        'MenuC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 655)
        Me.Controls.Add(Me.PanelFormHijo)
        Me.Controls.Add(Me.PanelSlide)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MenuC"
        Me.Text = "MenuC"
        Me.PanelSlide.ResumeLayout(False)
        Me.PanelSubMenuC.ResumeLayout(False)
        Me.PanelImagen.ResumeLayout(False)
        Me.PanelSubMenuAdmin.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSlide As Panel
    Friend WithEvents PanelSubMenuC As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelImagen As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PanelSubMenuAdmin As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelFormHijo As Panel
End Class
