<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENTANALISTAHORARIOS
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label = New System.Windows.Forms.Label()
        Me.cboFiltroEstado = New System.Windows.Forms.ComboBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechainicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgcFechasHorarios = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdEditar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcodigoodontologo = New System.Windows.Forms.TextBox()
        Me.txtdatosodontologo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtphorafineditar = New System.Windows.Forms.DateTimePicker()
        Me.dtphorainicioeditar = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaeditar = New System.Windows.Forms.DateTimePicker()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.txtcodigohorario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgcFechasHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Controls.Add(Me.cboFiltroEstado)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.dtpfechafinal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpfechainicio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 217)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HORARIOS ATENCION REGISTRADOS"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(6, 159)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(63, 16)
        Me.label.TabIndex = 5
        Me.label.Text = "ESTADO"
        '
        'cboFiltroEstado
        '
        Me.cboFiltroEstado.FormattingEnabled = True
        Me.cboFiltroEstado.Items.AddRange(New Object() {"TODOS", "DISPONIBLE", "NO DISPONIBLE"})
        Me.cboFiltroEstado.Location = New System.Drawing.Point(124, 151)
        Me.cboFiltroEstado.Name = "cboFiltroEstado"
        Me.cboFiltroEstado.Size = New System.Drawing.Size(200, 24)
        Me.cboFiltroEstado.TabIndex = 2
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(365, 57)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(123, 46)
        Me.cmdBuscar.TabIndex = 4
        Me.cmdBuscar.Text = "BUSCAR"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinal.Location = New System.Drawing.Point(124, 96)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(200, 22)
        Me.dtpfechafinal.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FECHA FINAL:"
        '
        'dtpfechainicio
        '
        Me.dtpfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechainicio.Location = New System.Drawing.Point(124, 37)
        Me.dtpfechainicio.Name = "dtpfechainicio"
        Me.dtpfechainicio.Size = New System.Drawing.Size(200, 22)
        Me.dtpfechainicio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FECHA INICIO:"
        '
        'dgcFechasHorarios
        '
        Me.dgcFechasHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcFechasHorarios.Location = New System.Drawing.Point(26, 258)
        Me.dgcFechasHorarios.Name = "dgcFechasHorarios"
        Me.dgcFechasHorarios.RowHeadersWidth = 51
        Me.dgcFechasHorarios.RowTemplate.Height = 24
        Me.dgcFechasHorarios.Size = New System.Drawing.Size(543, 334)
        Me.dgcFechasHorarios.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdSalir)
        Me.GroupBox2.Controls.Add(Me.cmdEliminar)
        Me.GroupBox2.Controls.Add(Me.cmdEditar)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.dtphorafineditar)
        Me.GroupBox2.Controls.Add(Me.dtphorainicioeditar)
        Me.GroupBox2.Controls.Add(Me.dtpfechaeditar)
        Me.GroupBox2.Controls.Add(Me.txtestado)
        Me.GroupBox2.Controls.Add(Me.txtcodigohorario)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(602, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(546, 554)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CAMPOS A EDITAR"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(42, 487)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(133, 44)
        Me.cmdSalir.TabIndex = 14
        Me.cmdSalir.Text = "SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(42, 434)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(133, 47)
        Me.cmdEliminar.TabIndex = 13
        Me.cmdEliminar.Text = "ELIMINAR"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdEditar
        '
        Me.cmdEditar.Location = New System.Drawing.Point(42, 374)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(133, 46)
        Me.cmdEditar.TabIndex = 12
        Me.cmdEditar.Text = "ACTUALIZAR"
        Me.cmdEditar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtcodigoodontologo)
        Me.GroupBox3.Controls.Add(Me.txtdatosodontologo)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.txtdni)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(205, 310)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(320, 238)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ODONTOLOGO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = " CODIGO ODONTOLOGO:"
        '
        'txtcodigoodontologo
        '
        Me.txtcodigoodontologo.Enabled = False
        Me.txtcodigoodontologo.Location = New System.Drawing.Point(9, 195)
        Me.txtcodigoodontologo.Name = "txtcodigoodontologo"
        Me.txtcodigoodontologo.Size = New System.Drawing.Size(295, 22)
        Me.txtcodigoodontologo.TabIndex = 5
        '
        'txtdatosodontologo
        '
        Me.txtdatosodontologo.Enabled = False
        Me.txtdatosodontologo.Location = New System.Drawing.Point(9, 125)
        Me.txtdatosodontologo.Name = "txtdatosodontologo"
        Me.txtdatosodontologo.Size = New System.Drawing.Size(295, 22)
        Me.txtdatosodontologo.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "APELLIDOS Y NOMBRES:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(229, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(58, 33)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(165, 22)
        Me.txtdni.TabIndex = 1
        Me.txtdni.Text = " "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "DNI:"
        '
        'dtphorafineditar
        '
        Me.dtphorafineditar.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtphorafineditar.Location = New System.Drawing.Point(42, 310)
        Me.dtphorafineditar.Name = "dtphorafineditar"
        Me.dtphorafineditar.Size = New System.Drawing.Size(133, 22)
        Me.dtphorafineditar.TabIndex = 10
        '
        'dtphorainicioeditar
        '
        Me.dtphorainicioeditar.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtphorainicioeditar.Location = New System.Drawing.Point(235, 206)
        Me.dtphorainicioeditar.Name = "dtphorainicioeditar"
        Me.dtphorainicioeditar.Size = New System.Drawing.Size(146, 22)
        Me.dtphorainicioeditar.TabIndex = 9
        '
        'dtpfechaeditar
        '
        Me.dtpfechaeditar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaeditar.Location = New System.Drawing.Point(42, 206)
        Me.dtpfechaeditar.Name = "dtpfechaeditar"
        Me.dtpfechaeditar.Size = New System.Drawing.Size(133, 22)
        Me.dtpfechaeditar.TabIndex = 8
        '
        'txtestado
        '
        Me.txtestado.Location = New System.Drawing.Point(235, 95)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(146, 22)
        Me.txtestado.TabIndex = 7
        '
        'txtcodigohorario
        '
        Me.txtcodigohorario.Enabled = False
        Me.txtcodigohorario.Location = New System.Drawing.Point(42, 95)
        Me.txtcodigohorario.Name = "txtcodigohorario"
        Me.txtcodigohorario.Size = New System.Drawing.Size(133, 22)
        Me.txtcodigohorario.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "HORA FIN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "HORA INICIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "FECHA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ESTADO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CODIGO HORARIO"
        '
        'VENTANALISTAHORARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 629)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgcFechasHorarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "VENTANALISTAHORARIOS"
        Me.Text = "VENTANALISTAHORARIOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgcFechasHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents dtpfechafinal As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpfechainicio As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dgcFechasHorarios As DataGridView
    Friend WithEvents cboFiltroEstado As ComboBox
    Friend WithEvents label As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtphorafineditar As DateTimePicker
    Friend WithEvents dtphorainicioeditar As DateTimePicker
    Friend WithEvents dtpfechaeditar As DateTimePicker
    Friend WithEvents txtestado As TextBox
    Friend WithEvents txtcodigohorario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents cmdEditar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtcodigoodontologo As TextBox
    Friend WithEvents txtdatosodontologo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label8 As Label
End Class
