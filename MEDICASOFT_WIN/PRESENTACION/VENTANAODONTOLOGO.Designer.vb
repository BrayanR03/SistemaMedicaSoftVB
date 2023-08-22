<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENTANAODONTOLOGO
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtidodontologo = New System.Windows.Forms.TextBox()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.txtnombres = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.dtpfechanacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.cmdRegistrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " ID ODONTOLOGO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = " APELLIDOS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = " NOMBRES:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = " DNI:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(397, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = " FECHA NACIMIENTO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = " TELEFONO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(408, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = " CORREO:"
        '
        'txtidodontologo
        '
        Me.txtidodontologo.BackColor = System.Drawing.SystemColors.Info
        Me.txtidodontologo.Enabled = False
        Me.txtidodontologo.Location = New System.Drawing.Point(117, 51)
        Me.txtidodontologo.Name = "txtidodontologo"
        Me.txtidodontologo.Size = New System.Drawing.Size(186, 22)
        Me.txtidodontologo.TabIndex = 7
        '
        'txtapellidos
        '
        Me.txtapellidos.Location = New System.Drawing.Point(117, 97)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(186, 22)
        Me.txtapellidos.TabIndex = 8
        '
        'txtnombres
        '
        Me.txtnombres.Location = New System.Drawing.Point(117, 165)
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(186, 22)
        Me.txtnombres.TabIndex = 9
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(117, 232)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(186, 22)
        Me.txtdni.TabIndex = 10
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(547, 88)
        Me.txttelefono.MaxLength = 9
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(200, 22)
        Me.txttelefono.TabIndex = 11
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(547, 151)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(200, 22)
        Me.txtcorreo.TabIndex = 12
        '
        'dtpfechanacimiento
        '
        Me.dtpfechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechanacimiento.Location = New System.Drawing.Point(559, 22)
        Me.dtpfechanacimiento.Name = "dtpfechanacimiento"
        Me.dtpfechanacimiento.Size = New System.Drawing.Size(200, 22)
        Me.dtpfechanacimiento.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(408, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = " DIRECCION"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(547, 214)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(200, 22)
        Me.txtdireccion.TabIndex = 15
        '
        'cmdRegistrar
        '
        Me.cmdRegistrar.Location = New System.Drawing.Point(122, 298)
        Me.cmdRegistrar.Name = "cmdRegistrar"
        Me.cmdRegistrar.Size = New System.Drawing.Size(110, 23)
        Me.cmdRegistrar.TabIndex = 16
        Me.cmdRegistrar.Text = "REGISTRAR"
        Me.cmdRegistrar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(275, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VENTANAODONTOLOGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdRegistrar)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpfechanacimiento)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.txtnombres)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.txtidodontologo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VENTANAODONTOLOGO"
        Me.Text = "VENTANAODONTOLOGO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtidodontologo As TextBox
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents txtnombres As TextBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents dtpfechanacimiento As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents cmdRegistrar As Button
    Friend WithEvents Button1 As Button
End Class
