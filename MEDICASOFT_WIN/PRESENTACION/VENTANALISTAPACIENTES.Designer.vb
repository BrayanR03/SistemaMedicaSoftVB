<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENTANALISTAPACIENTES
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
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdnibusqueda = New System.Windows.Forms.TextBox()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
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
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(464, 62)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscar.TabIndex = 0
        Me.cmdBuscar.Text = "BUSCAR"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DNI:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = " LISTA DE PACIENTE REGISTRADOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdnibusqueda)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(715, 128)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESAR DNI DEL PACIENTE A BUSCAR:"
        '
        'txtdnibusqueda
        '
        Me.txtdnibusqueda.Location = New System.Drawing.Point(100, 63)
        Me.txtdnibusqueda.MaxLength = 8
        Me.txtdnibusqueda.Name = "txtdnibusqueda"
        Me.txtdnibusqueda.Size = New System.Drawing.Size(184, 22)
        Me.txtdnibusqueda.TabIndex = 2
        '
        'dgvPacientes
        '
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Location = New System.Drawing.Point(15, 240)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.RowHeadersWidth = 51
        Me.dgvPacientes.RowTemplate.Height = 24
        Me.dgvPacientes.Size = New System.Drawing.Size(715, 399)
        Me.dgvPacientes.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdSalir)
        Me.GroupBox2.Controls.Add(Me.cmdEliminar)
        Me.GroupBox2.Controls.Add(Me.cmdActualizar)
        Me.GroupBox2.Controls.Add(Me.dtpfecha)
        Me.GroupBox2.Controls.Add(Me.txtcorreo)
        Me.GroupBox2.Controls.Add(Me.txttelefono)
        Me.GroupBox2.Controls.Add(Me.txtdireccion)
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
        Me.GroupBox2.Location = New System.Drawing.Point(736, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(433, 546)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CAMPOS A EDITAR"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(291, 480)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(94, 44)
        Me.cmdSalir.TabIndex = 18
        Me.cmdSalir.Text = "SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(171, 480)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(98, 44)
        Me.cmdEliminar.TabIndex = 17
        Me.cmdEliminar.Text = "ELIMINAR"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Location = New System.Drawing.Point(31, 480)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(100, 44)
        Me.cmdActualizar.TabIndex = 16
        Me.cmdActualizar.Text = "ACTUALIZAR"
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(211, 425)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(200, 22)
        Me.dtpfecha.TabIndex = 15
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(31, 427)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(132, 22)
        Me.txtcorreo.TabIndex = 14
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(211, 330)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(174, 22)
        Me.txttelefono.TabIndex = 13
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(31, 330)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(132, 22)
        Me.txtdireccion.TabIndex = 12
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(211, 207)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(174, 22)
        Me.txtdni.TabIndex = 11
        '
        'txtnombres
        '
        Me.txtnombres.Location = New System.Drawing.Point(31, 207)
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(132, 22)
        Me.txtnombres.TabIndex = 10
        '
        'txtapellidos
        '
        Me.txtapellidos.Location = New System.Drawing.Point(211, 96)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(174, 22)
        Me.txtapellidos.TabIndex = 9
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Location = New System.Drawing.Point(31, 96)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 22)
        Me.txtid.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(208, 385)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = " FECHA NACIMIENTO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 385)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = " CORREO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(208, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = " TELEFONO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = " DIRECCION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = " DNI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = " NOMBRES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = " APELLIDOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ID PACIENTE"
        '
        'VENTANALISTAPACIENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1199, 688)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvPacientes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "VENTANALISTAPACIENTES"
        Me.Text = "VENTANALISTAPACIENTES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtdnibusqueda As TextBox
    Friend WithEvents dgvPacientes As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtdireccion As TextBox
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
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents cmdSalir As Button
End Class
