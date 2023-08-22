<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENTANAPACIENTE
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdRegistrar = New System.Windows.Forms.Button()
        Me.dtpfechanacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtidpaciente = New System.Windows.Forms.TextBox()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.txtnombres = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID PACIENTE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = " APELLIDOS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(281, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = " NOMBRES:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = " TELEFONO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(281, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = " DIRECCION:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(558, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = " CORREO ELECTRONICO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(3, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = " FECHA NACIMIENTO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(558, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = " DNI:"
        '
        'cmdRegistrar
        '
        Me.cmdRegistrar.BackColor = System.Drawing.Color.LightCyan
        Me.cmdRegistrar.Font = New System.Drawing.Font("Microsoft Uighur", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRegistrar.ForeColor = System.Drawing.Color.Black
        Me.cmdRegistrar.Location = New System.Drawing.Point(42, 460)
        Me.cmdRegistrar.Name = "cmdRegistrar"
        Me.cmdRegistrar.Size = New System.Drawing.Size(123, 48)
        Me.cmdRegistrar.TabIndex = 8
        Me.cmdRegistrar.Text = "REGISTRAR"
        Me.cmdRegistrar.UseVisualStyleBackColor = False
        '
        'dtpfechanacimiento
        '
        Me.dtpfechanacimiento.CalendarForeColor = System.Drawing.SystemColors.ScrollBar
        Me.dtpfechanacimiento.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar
        Me.dtpfechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechanacimiento.Location = New System.Drawing.Point(10, 45)
        Me.dtpfechanacimiento.Name = "dtpfechanacimiento"
        Me.dtpfechanacimiento.Size = New System.Drawing.Size(200, 22)
        Me.dtpfechanacimiento.TabIndex = 9
        '
        'txtidpaciente
        '
        Me.txtidpaciente.BackColor = System.Drawing.SystemColors.Info
        Me.txtidpaciente.Enabled = False
        Me.txtidpaciente.Location = New System.Drawing.Point(153, 143)
        Me.txtidpaciente.Name = "txtidpaciente"
        Me.txtidpaciente.Size = New System.Drawing.Size(100, 22)
        Me.txtidpaciente.TabIndex = 10
        '
        'txtapellidos
        '
        Me.txtapellidos.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtapellidos.Location = New System.Drawing.Point(121, 264)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(132, 22)
        Me.txtapellidos.TabIndex = 11
        '
        'txtnombres
        '
        Me.txtnombres.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtnombres.Location = New System.Drawing.Point(357, 264)
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(132, 22)
        Me.txtnombres.TabIndex = 12
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txttelefono.Location = New System.Drawing.Point(121, 396)
        Me.txttelefono.MaxLength = 9
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(132, 22)
        Me.txttelefono.TabIndex = 13
        '
        'txtdni
        '
        Me.txtdni.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtdni.Location = New System.Drawing.Point(589, 264)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(204, 22)
        Me.txtdni.TabIndex = 14
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtdireccion.Location = New System.Drawing.Point(358, 396)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(175, 22)
        Me.txtdireccion.TabIndex = 15
        '
        'txtcorreo
        '
        Me.txtcorreo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtcorreo.Location = New System.Drawing.Point(589, 406)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(204, 22)
        Me.txtcorreo.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.dtpfechanacimiento)
        Me.Panel1.Location = New System.Drawing.Point(657, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 83)
        Me.Panel1.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MEDICASOFT_WIN.My.Resources.Resources.LOGIN
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(896, 188)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(37, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = " REGISTRAR PACIENTE"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Uighur", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(193, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 48)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'VENTANAPACIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(889, 520)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtnombres)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.txtidpaciente)
        Me.Controls.Add(Me.cmdRegistrar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "VENTANAPACIENTE"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdRegistrar As Button
    Friend WithEvents dtpfechanacimiento As DateTimePicker
    Friend WithEvents txtidpaciente As TextBox
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents txtnombres As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
End Class
