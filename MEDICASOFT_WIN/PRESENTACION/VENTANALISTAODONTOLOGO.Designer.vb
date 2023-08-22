<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENTANALISTAODONTOLOGO
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdnibusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.dgvOdontologo = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.txtnombres = New System.Windows.Forms.TextBox()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvOdontologo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LISTA ODONTOLOGO REGISTRADOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdnibusqueda)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 106)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESAR DNI DE ODONTOLOGO A BUSCAR"
        '
        'txtdnibusqueda
        '
        Me.txtdnibusqueda.Location = New System.Drawing.Point(77, 49)
        Me.txtdnibusqueda.MaxLength = 8
        Me.txtdnibusqueda.Name = "txtdnibusqueda"
        Me.txtdnibusqueda.Size = New System.Drawing.Size(183, 22)
        Me.txtdnibusqueda.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DNI:"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(311, 49)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscar.TabIndex = 0
        Me.cmdBuscar.Text = "BUSCAR"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'dgvOdontologo
        '
        Me.dgvOdontologo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOdontologo.Location = New System.Drawing.Point(12, 207)
        Me.dgvOdontologo.Name = "dgvOdontologo"
        Me.dgvOdontologo.RowHeadersWidth = 51
        Me.dgvOdontologo.RowTemplate.Height = 24
        Me.dgvOdontologo.Size = New System.Drawing.Size(549, 445)
        Me.dgvOdontologo.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.dtpfecha)
        Me.GroupBox2.Controls.Add(Me.txtdireccion)
        Me.GroupBox2.Controls.Add(Me.txtcorreo)
        Me.GroupBox2.Controls.Add(Me.txttelefono)
        Me.GroupBox2.Controls.Add(Me.txtdni)
        Me.GroupBox2.Controls.Add(Me.txtnombres)
        Me.GroupBox2.Controls.Add(Me.txtapellidos)
        Me.GroupBox2.Controls.Add(Me.txtid)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(580, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(419, 574)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " "
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(292, 517)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 36)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(161, 517)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 36)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "ELIMINAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 517)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 36)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "ACTUALIZAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(230, 359)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(163, 22)
        Me.dtpfecha.TabIndex = 16
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(230, 467)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(163, 22)
        Me.txtdireccion.TabIndex = 15
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(21, 467)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(143, 22)
        Me.txtcorreo.TabIndex = 14
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(21, 359)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(143, 22)
        Me.txttelefono.TabIndex = 12
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(230, 221)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(127, 22)
        Me.txtdni.TabIndex = 11
        '
        'txtnombres
        '
        Me.txtnombres.Location = New System.Drawing.Point(21, 221)
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(143, 22)
        Me.txtnombres.TabIndex = 10
        '
        'txtapellidos
        '
        Me.txtapellidos.Location = New System.Drawing.Point(230, 97)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(163, 22)
        Me.txtapellidos.TabIndex = 9
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Location = New System.Drawing.Point(21, 97)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(124, 22)
        Me.txtid.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(219, 421)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "DIRECCION"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 421)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "CORREO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(219, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "FECHA NACIMIENTO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = " TELEFONO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(219, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "DNI:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "NOMBRES:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "APELLIDOS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ID ODONTOLOGO"
        '
        'VENTANALISTAODONTOLOGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 692)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvOdontologo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VENTANALISTAODONTOLOGO"
        Me.Text = "VENTANALISTAODONTOLOGO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvOdontologo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtdnibusqueda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents dgvOdontologo As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents txtnombres As TextBox
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
