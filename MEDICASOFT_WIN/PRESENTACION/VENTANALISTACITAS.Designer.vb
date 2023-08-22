<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENTANALISTACITAS
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
        Me.dtpfecharegistro = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdBuscarFechaCita = New System.Windows.Forms.Button()
        Me.dgvCitasRegistradas = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtidpaciente = New System.Windows.Forms.TextBox()
        Me.txtdatospaciente = New System.Windows.Forms.TextBox()
        Me.txtdnibuscar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.txtidcita = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtcodigohorarioeditar = New System.Windows.Forms.TextBox()
        Me.txtestadohorarioeditar = New System.Windows.Forms.TextBox()
        Me.txtfechahorarioeditar = New System.Windows.Forms.TextBox()
        Me.txthorainicioeditar = New System.Windows.Forms.TextBox()
        Me.txthorafineditar = New System.Windows.Forms.TextBox()
        Me.txtodontologoeditar = New System.Windows.Forms.TextBox()
        Me.grupoHorariosLista = New System.Windows.Forms.GroupBox()
        Me.cmdElegirOtroHorario = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.grupoHorariosDisponibles = New System.Windows.Forms.GroupBox()
        Me.cmdCancelarHorario = New System.Windows.Forms.Button()
        Me.cmdSeleccionarHorario = New System.Windows.Forms.Button()
        Me.dgvHorariosDisponibles = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCitasRegistradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grupoHorariosLista.SuspendLayout()
        Me.grupoHorariosDisponibles.SuspendLayout()
        CType(Me.dgvHorariosDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpfecharegistro
        '
        Me.dtpfecharegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecharegistro.Location = New System.Drawing.Point(6, 75)
        Me.dtpfecharegistro.Name = "dtpfecharegistro"
        Me.dtpfecharegistro.Size = New System.Drawing.Size(168, 22)
        Me.dtpfecharegistro.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FECHA REGISTRO CITA:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdBuscarFechaCita)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpfecharegistro)
        Me.Panel1.Location = New System.Drawing.Point(30, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 150)
        Me.Panel1.TabIndex = 2
        '
        'cmdBuscarFechaCita
        '
        Me.cmdBuscarFechaCita.Location = New System.Drawing.Point(295, 77)
        Me.cmdBuscarFechaCita.Name = "cmdBuscarFechaCita"
        Me.cmdBuscarFechaCita.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscarFechaCita.TabIndex = 2
        Me.cmdBuscarFechaCita.Text = "BUSCAR"
        Me.cmdBuscarFechaCita.UseVisualStyleBackColor = True
        '
        'dgvCitasRegistradas
        '
        Me.dgvCitasRegistradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCitasRegistradas.Location = New System.Drawing.Point(30, 191)
        Me.dgvCitasRegistradas.Name = "dgvCitasRegistradas"
        Me.dgvCitasRegistradas.RowHeadersWidth = 51
        Me.dgvCitasRegistradas.RowTemplate.Height = 24
        Me.dgvCitasRegistradas.Size = New System.Drawing.Size(452, 244)
        Me.dgvCitasRegistradas.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtidpaciente)
        Me.GroupBox1.Controls.Add(Me.txtdatospaciente)
        Me.GroupBox1.Controls.Add(Me.txtdnibuscar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(821, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(599, 152)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PACIENTE"
        '
        'txtidpaciente
        '
        Me.txtidpaciente.BackColor = System.Drawing.SystemColors.Info
        Me.txtidpaciente.Enabled = False
        Me.txtidpaciente.Location = New System.Drawing.Point(317, 115)
        Me.txtidpaciente.Name = "txtidpaciente"
        Me.txtidpaciente.Size = New System.Drawing.Size(271, 22)
        Me.txtidpaciente.TabIndex = 6
        '
        'txtdatospaciente
        '
        Me.txtdatospaciente.BackColor = System.Drawing.SystemColors.Info
        Me.txtdatospaciente.Enabled = False
        Me.txtdatospaciente.Location = New System.Drawing.Point(18, 113)
        Me.txtdatospaciente.Name = "txtdatospaciente"
        Me.txtdatospaciente.Size = New System.Drawing.Size(271, 22)
        Me.txtdatospaciente.TabIndex = 5
        '
        'txtdnibuscar
        '
        Me.txtdnibuscar.Location = New System.Drawing.Point(67, 32)
        Me.txtdnibuscar.MaxLength = 8
        Me.txtdnibuscar.Name = "txtdnibuscar"
        Me.txtdnibuscar.Size = New System.Drawing.Size(127, 22)
        Me.txtdnibuscar.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(314, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CODIGO PACIENTE:"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(214, 31)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscar.TabIndex = 2
        Me.cmdBuscar.Text = "BUSCAR"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "APELLIDOS Y NOMBRES:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DNI:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtmonto)
        Me.GroupBox2.Controls.Add(Me.txtidcita)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(502, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 152)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CITA"
        '
        'txtmonto
        '
        Me.txtmonto.BackColor = System.Drawing.SystemColors.Info
        Me.txtmonto.Enabled = False
        Me.txtmonto.Location = New System.Drawing.Point(152, 95)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(100, 22)
        Me.txtmonto.TabIndex = 3
        '
        'txtidcita
        '
        Me.txtidcita.BackColor = System.Drawing.SystemColors.Info
        Me.txtidcita.Enabled = False
        Me.txtidcita.Location = New System.Drawing.Point(152, 34)
        Me.txtidcita.Name = "txtidcita"
        Me.txtidcita.Size = New System.Drawing.Size(100, 22)
        Me.txtidcita.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "MONTO TOTAL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ID CITA:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CODIGO HORARIO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(161, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ESTADO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(305, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "FECHA REGISTRO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(472, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "HORA INICIO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(633, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "HORA FIN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(815, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "ODONTOLOGO"
        '
        'txtcodigohorarioeditar
        '
        Me.txtcodigohorarioeditar.BackColor = System.Drawing.SystemColors.Info
        Me.txtcodigohorarioeditar.Enabled = False
        Me.txtcodigohorarioeditar.Location = New System.Drawing.Point(16, 60)
        Me.txtcodigohorarioeditar.Name = "txtcodigohorarioeditar"
        Me.txtcodigohorarioeditar.Size = New System.Drawing.Size(100, 22)
        Me.txtcodigohorarioeditar.TabIndex = 12
        '
        'txtestadohorarioeditar
        '
        Me.txtestadohorarioeditar.BackColor = System.Drawing.SystemColors.Info
        Me.txtestadohorarioeditar.Enabled = False
        Me.txtestadohorarioeditar.Location = New System.Drawing.Point(152, 60)
        Me.txtestadohorarioeditar.Name = "txtestadohorarioeditar"
        Me.txtestadohorarioeditar.Size = New System.Drawing.Size(100, 22)
        Me.txtestadohorarioeditar.TabIndex = 13
        '
        'txtfechahorarioeditar
        '
        Me.txtfechahorarioeditar.BackColor = System.Drawing.SystemColors.Info
        Me.txtfechahorarioeditar.Enabled = False
        Me.txtfechahorarioeditar.Location = New System.Drawing.Point(297, 60)
        Me.txtfechahorarioeditar.Name = "txtfechahorarioeditar"
        Me.txtfechahorarioeditar.Size = New System.Drawing.Size(141, 22)
        Me.txtfechahorarioeditar.TabIndex = 14
        '
        'txthorainicioeditar
        '
        Me.txthorainicioeditar.BackColor = System.Drawing.SystemColors.Info
        Me.txthorainicioeditar.Enabled = False
        Me.txthorainicioeditar.Location = New System.Drawing.Point(475, 60)
        Me.txthorainicioeditar.Name = "txthorainicioeditar"
        Me.txthorainicioeditar.Size = New System.Drawing.Size(100, 22)
        Me.txthorainicioeditar.TabIndex = 15
        '
        'txthorafineditar
        '
        Me.txthorafineditar.BackColor = System.Drawing.SystemColors.Info
        Me.txthorafineditar.Enabled = False
        Me.txthorafineditar.Location = New System.Drawing.Point(636, 60)
        Me.txthorafineditar.Name = "txthorafineditar"
        Me.txthorafineditar.Size = New System.Drawing.Size(100, 22)
        Me.txthorafineditar.TabIndex = 16
        '
        'txtodontologoeditar
        '
        Me.txtodontologoeditar.BackColor = System.Drawing.SystemColors.Info
        Me.txtodontologoeditar.Enabled = False
        Me.txtodontologoeditar.Location = New System.Drawing.Point(818, 60)
        Me.txtodontologoeditar.Name = "txtodontologoeditar"
        Me.txtodontologoeditar.Size = New System.Drawing.Size(100, 22)
        Me.txtodontologoeditar.TabIndex = 17
        '
        'grupoHorariosLista
        '
        Me.grupoHorariosLista.Controls.Add(Me.cmdElegirOtroHorario)
        Me.grupoHorariosLista.Controls.Add(Me.Label12)
        Me.grupoHorariosLista.Controls.Add(Me.txtodontologoeditar)
        Me.grupoHorariosLista.Controls.Add(Me.Label7)
        Me.grupoHorariosLista.Controls.Add(Me.txthorafineditar)
        Me.grupoHorariosLista.Controls.Add(Me.Label8)
        Me.grupoHorariosLista.Controls.Add(Me.txthorainicioeditar)
        Me.grupoHorariosLista.Controls.Add(Me.Label9)
        Me.grupoHorariosLista.Controls.Add(Me.txtfechahorarioeditar)
        Me.grupoHorariosLista.Controls.Add(Me.Label10)
        Me.grupoHorariosLista.Controls.Add(Me.txtestadohorarioeditar)
        Me.grupoHorariosLista.Controls.Add(Me.Label11)
        Me.grupoHorariosLista.Controls.Add(Me.txtcodigohorarioeditar)
        Me.grupoHorariosLista.Location = New System.Drawing.Point(502, 193)
        Me.grupoHorariosLista.Name = "grupoHorariosLista"
        Me.grupoHorariosLista.Size = New System.Drawing.Size(947, 160)
        Me.grupoHorariosLista.TabIndex = 18
        Me.grupoHorariosLista.TabStop = False
        Me.grupoHorariosLista.Text = "HORARIO ATENCION"
        '
        'cmdElegirOtroHorario
        '
        Me.cmdElegirOtroHorario.Location = New System.Drawing.Point(16, 95)
        Me.cmdElegirOtroHorario.Name = "cmdElegirOtroHorario"
        Me.cmdElegirOtroHorario.Size = New System.Drawing.Size(179, 23)
        Me.cmdElegirOtroHorario.TabIndex = 18
        Me.cmdElegirOtroHorario.Text = "ELEGIR OTRO HORARIO"
        Me.cmdElegirOtroHorario.UseVisualStyleBackColor = True
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Location = New System.Drawing.Point(502, 392)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(131, 43)
        Me.cmdActualizar.TabIndex = 18
        Me.cmdActualizar.Text = "ACTUALIZAR"
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(671, 392)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(125, 43)
        Me.cmdEliminar.TabIndex = 19
        Me.cmdEliminar.Text = "ELIMINAR"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'grupoHorariosDisponibles
        '
        Me.grupoHorariosDisponibles.Controls.Add(Me.cmdCancelarHorario)
        Me.grupoHorariosDisponibles.Controls.Add(Me.cmdSeleccionarHorario)
        Me.grupoHorariosDisponibles.Controls.Add(Me.dgvHorariosDisponibles)
        Me.grupoHorariosDisponibles.Location = New System.Drawing.Point(502, 193)
        Me.grupoHorariosDisponibles.Name = "grupoHorariosDisponibles"
        Me.grupoHorariosDisponibles.Size = New System.Drawing.Size(918, 183)
        Me.grupoHorariosDisponibles.TabIndex = 20
        Me.grupoHorariosDisponibles.TabStop = False
        Me.grupoHorariosDisponibles.Text = "HORARIOS ATENCION DISPONIBLES:"
        '
        'cmdCancelarHorario
        '
        Me.cmdCancelarHorario.Location = New System.Drawing.Point(751, 86)
        Me.cmdCancelarHorario.Name = "cmdCancelarHorario"
        Me.cmdCancelarHorario.Size = New System.Drawing.Size(116, 23)
        Me.cmdCancelarHorario.TabIndex = 2
        Me.cmdCancelarHorario.Text = "CANCELAR"
        Me.cmdCancelarHorario.UseVisualStyleBackColor = True
        '
        'cmdSeleccionarHorario
        '
        Me.cmdSeleccionarHorario.Location = New System.Drawing.Point(751, 45)
        Me.cmdSeleccionarHorario.Name = "cmdSeleccionarHorario"
        Me.cmdSeleccionarHorario.Size = New System.Drawing.Size(110, 23)
        Me.cmdSeleccionarHorario.TabIndex = 1
        Me.cmdSeleccionarHorario.Text = "SELECCIONAR"
        Me.cmdSeleccionarHorario.UseVisualStyleBackColor = True
        '
        'dgvHorariosDisponibles
        '
        Me.dgvHorariosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHorariosDisponibles.Location = New System.Drawing.Point(6, 32)
        Me.dgvHorariosDisponibles.Name = "dgvHorariosDisponibles"
        Me.dgvHorariosDisponibles.RowHeadersWidth = 51
        Me.dgvHorariosDisponibles.RowTemplate.Height = 24
        Me.dgvHorariosDisponibles.Size = New System.Drawing.Size(730, 128)
        Me.dgvHorariosDisponibles.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(821, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 43)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VENTANALISTACITAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1526, 619)
        Me.Controls.Add(Me.grupoHorariosLista)
        Me.Controls.Add(Me.grupoHorariosDisponibles)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.dgvCitasRegistradas)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "VENTANALISTACITAS"
        Me.Text = "VENTANALISTACITAS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvCitasRegistradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grupoHorariosLista.ResumeLayout(False)
        Me.grupoHorariosLista.PerformLayout()
        Me.grupoHorariosDisponibles.ResumeLayout(False)
        CType(Me.dgvHorariosDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpfecharegistro As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdBuscarFechaCita As Button
    Friend WithEvents dgvCitasRegistradas As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtidpaciente As TextBox
    Friend WithEvents txtdatospaciente As TextBox
    Friend WithEvents txtdnibuscar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents txtidcita As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtcodigohorarioeditar As TextBox
    Friend WithEvents txtestadohorarioeditar As TextBox
    Friend WithEvents txtfechahorarioeditar As TextBox
    Friend WithEvents txthorainicioeditar As TextBox
    Friend WithEvents txthorafineditar As TextBox
    Friend WithEvents txtodontologoeditar As TextBox
    Friend WithEvents grupoHorariosLista As GroupBox
    Friend WithEvents cmdElegirOtroHorario As Button
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents grupoHorariosDisponibles As GroupBox
    Friend WithEvents dgvHorariosDisponibles As DataGridView
    Friend WithEvents cmdCancelarHorario As Button
    Friend WithEvents cmdSeleccionarHorario As Button
    Friend WithEvents Button1 As Button
End Class
