<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENTANAHORARIO
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
        Me.cmdRegistrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtidodontologo = New System.Windows.Forms.TextBox()
        Me.txtdatosodontologo = New System.Windows.Forms.TextBox()
        Me.txtdniodontologo = New System.Windows.Forms.TextBox()
        Me.cmdVerOdontologo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtidhorario = New System.Windows.Forms.TextBox()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.dtphorainicio = New System.Windows.Forms.DateTimePicker()
        Me.dtphorafin = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID HORARIO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = " ESTADO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = " FECHA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(413, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = " HORA INICIO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(413, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = " HORA FIN:"
        '
        'cmdRegistrar
        '
        Me.cmdRegistrar.Location = New System.Drawing.Point(30, 328)
        Me.cmdRegistrar.Name = "cmdRegistrar"
        Me.cmdRegistrar.Size = New System.Drawing.Size(166, 47)
        Me.cmdRegistrar.TabIndex = 6
        Me.cmdRegistrar.Text = " REGISTRAR HORARIO "
        Me.cmdRegistrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtidodontologo)
        Me.GroupBox1.Controls.Add(Me.txtdatosodontologo)
        Me.GroupBox1.Controls.Add(Me.txtdniodontologo)
        Me.GroupBox1.Controls.Add(Me.cmdVerOdontologo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(416, 213)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 183)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ODONTOLOGO"
        '
        'txtidodontologo
        '
        Me.txtidodontologo.Location = New System.Drawing.Point(173, 87)
        Me.txtidodontologo.Name = "txtidodontologo"
        Me.txtidodontologo.Size = New System.Drawing.Size(154, 22)
        Me.txtidodontologo.TabIndex = 5
        Me.txtidodontologo.Visible = False
        '
        'txtdatosodontologo
        '
        Me.txtdatosodontologo.BackColor = System.Drawing.SystemColors.Info
        Me.txtdatosodontologo.Enabled = False
        Me.txtdatosodontologo.Location = New System.Drawing.Point(173, 115)
        Me.txtdatosodontologo.Name = "txtdatosodontologo"
        Me.txtdatosodontologo.Size = New System.Drawing.Size(235, 22)
        Me.txtdatosodontologo.TabIndex = 4
        '
        'txtdniodontologo
        '
        Me.txtdniodontologo.Location = New System.Drawing.Point(173, 44)
        Me.txtdniodontologo.MaxLength = 8
        Me.txtdniodontologo.Name = "txtdniodontologo"
        Me.txtdniodontologo.Size = New System.Drawing.Size(154, 22)
        Me.txtdniodontologo.TabIndex = 3
        '
        'cmdVerOdontologo
        '
        Me.cmdVerOdontologo.Location = New System.Drawing.Point(333, 45)
        Me.cmdVerOdontologo.Name = "cmdVerOdontologo"
        Me.cmdVerOdontologo.Size = New System.Drawing.Size(75, 23)
        Me.cmdVerOdontologo.TabIndex = 2
        Me.cmdVerOdontologo.Text = "BUSCAR"
        Me.cmdVerOdontologo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = " APELLIDOS Y NOMBRES:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "DNI ODONTOLOGO:"
        '
        'txtidhorario
        '
        Me.txtidhorario.BackColor = System.Drawing.SystemColors.Info
        Me.txtidhorario.Enabled = False
        Me.txtidhorario.Location = New System.Drawing.Point(160, 28)
        Me.txtidhorario.Name = "txtidhorario"
        Me.txtidhorario.Size = New System.Drawing.Size(171, 22)
        Me.txtidhorario.TabIndex = 8
        '
        'txtestado
        '
        Me.txtestado.BackColor = System.Drawing.SystemColors.Info
        Me.txtestado.Enabled = False
        Me.txtestado.Location = New System.Drawing.Point(160, 107)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(171, 22)
        Me.txtestado.TabIndex = 9
        Me.txtestado.Text = " DISPONIBLE"
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(160, 213)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(171, 22)
        Me.dtpfecha.TabIndex = 10
        '
        'dtphorainicio
        '
        Me.dtphorainicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtphorainicio.Location = New System.Drawing.Point(532, 28)
        Me.dtphorainicio.Name = "dtphorainicio"
        Me.dtphorainicio.Size = New System.Drawing.Size(200, 22)
        Me.dtphorainicio.TabIndex = 11
        '
        'dtphorafin
        '
        Me.dtphorafin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtphorafin.Location = New System.Drawing.Point(532, 110)
        Me.dtphorafin.Name = "dtphorafin"
        Me.dtphorafin.Size = New System.Drawing.Size(200, 22)
        Me.dtphorafin.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(215, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 47)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VENTANAHORARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtphorafin)
        Me.Controls.Add(Me.dtphorainicio)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.txtestado)
        Me.Controls.Add(Me.txtidhorario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdRegistrar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VENTANAHORARIO"
        Me.Text = "VENTANAHORARIO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdRegistrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtdatosodontologo As TextBox
    Friend WithEvents txtdniodontologo As TextBox
    Friend WithEvents cmdVerOdontologo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtidhorario As TextBox
    Friend WithEvents txtestado As TextBox
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents dtphorainicio As DateTimePicker
    Friend WithEvents dtphorafin As DateTimePicker
    Friend WithEvents txtidodontologo As TextBox
    Friend WithEvents Button1 As Button
End Class
