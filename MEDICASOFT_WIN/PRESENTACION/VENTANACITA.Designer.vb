<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENTANACITA
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtidpaciente = New System.Windows.Forms.TextBox()
        Me.txtdnipaciente = New System.Windows.Forms.TextBox()
        Me.txtdatospaciente = New System.Windows.Forms.TextBox()
        Me.cmdBuscarPaciente = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidcita = New System.Windows.Forms.TextBox()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.dvgHorarioAtencion = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcodigohorario = New System.Windows.Forms.TextBox()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txthorainicio = New System.Windows.Forms.TextBox()
        Me.txthorafin = New System.Windows.Forms.TextBox()
        Me.txtodontologo = New System.Windows.Forms.TextBox()
        Me.txtcodigoodontologo = New System.Windows.Forms.TextBox()
        Me.cmdRegistrarCita = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dvgHorarioAtencion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID CITA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MONTO TOTAL:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtidpaciente)
        Me.GroupBox1.Controls.Add(Me.txtdnipaciente)
        Me.GroupBox1.Controls.Add(Me.txtdatospaciente)
        Me.GroupBox1.Controls.Add(Me.cmdBuscarPaciente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(622, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 221)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PACIENTE"
        '
        'txtidpaciente
        '
        Me.txtidpaciente.Location = New System.Drawing.Point(196, 90)
        Me.txtidpaciente.Name = "txtidpaciente"
        Me.txtidpaciente.Size = New System.Drawing.Size(100, 22)
        Me.txtidpaciente.TabIndex = 6
        Me.txtidpaciente.Visible = False
        '
        'txtdnipaciente
        '
        Me.txtdnipaciente.Location = New System.Drawing.Point(9, 67)
        Me.txtdnipaciente.MaxLength = 8
        Me.txtdnipaciente.Name = "txtdnipaciente"
        Me.txtdnipaciente.Size = New System.Drawing.Size(157, 22)
        Me.txtdnipaciente.TabIndex = 5
        '
        'txtdatospaciente
        '
        Me.txtdatospaciente.BackColor = System.Drawing.SystemColors.Info
        Me.txtdatospaciente.Enabled = False
        Me.txtdatospaciente.Location = New System.Drawing.Point(9, 155)
        Me.txtdatospaciente.Name = "txtdatospaciente"
        Me.txtdatospaciente.Size = New System.Drawing.Size(320, 22)
        Me.txtdatospaciente.TabIndex = 4
        '
        'cmdBuscarPaciente
        '
        Me.cmdBuscarPaciente.Location = New System.Drawing.Point(263, 34)
        Me.cmdBuscarPaciente.Name = "cmdBuscarPaciente"
        Me.cmdBuscarPaciente.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscarPaciente.TabIndex = 2
        Me.cmdBuscarPaciente.Text = "BUSCAR"
        Me.cmdBuscarPaciente.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "APELLIDOS Y NOMBRES:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = " DNI PACIENTE:"
        '
        'txtidcita
        '
        Me.txtidcita.BackColor = System.Drawing.SystemColors.Info
        Me.txtidcita.Enabled = False
        Me.txtidcita.Location = New System.Drawing.Point(134, 64)
        Me.txtidcita.Name = "txtidcita"
        Me.txtidcita.Size = New System.Drawing.Size(224, 22)
        Me.txtidcita.TabIndex = 3
        '
        'txtmonto
        '
        Me.txtmonto.BackColor = System.Drawing.SystemColors.Info
        Me.txtmonto.Enabled = False
        Me.txtmonto.Location = New System.Drawing.Point(134, 170)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(224, 22)
        Me.txtmonto.TabIndex = 4
        Me.txtmonto.Text = "20"
        '
        'dvgHorarioAtencion
        '
        Me.dvgHorarioAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgHorarioAtencion.Location = New System.Drawing.Point(39, 360)
        Me.dvgHorarioAtencion.Name = "dvgHorarioAtencion"
        Me.dvgHorarioAtencion.RowHeadersWidth = 51
        Me.dvgHorarioAtencion.RowTemplate.Height = 24
        Me.dvgHorarioAtencion.Size = New System.Drawing.Size(949, 277)
        Me.dvgHorarioAtencion.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "HORARIO ATENCION:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 664)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "ID HORARIO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(214, 664)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ESTADO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(388, 664)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = " FECHA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(531, 664)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = " HORA INICIO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(710, 664)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = " HORA FIN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(882, 664)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = " ODONTOLOGO"
        '
        'txtcodigohorario
        '
        Me.txtcodigohorario.BackColor = System.Drawing.SystemColors.Info
        Me.txtcodigohorario.Location = New System.Drawing.Point(39, 714)
        Me.txtcodigohorario.Name = "txtcodigohorario"
        Me.txtcodigohorario.Size = New System.Drawing.Size(121, 22)
        Me.txtcodigohorario.TabIndex = 13
        '
        'txtestado
        '
        Me.txtestado.BackColor = System.Drawing.SystemColors.Info
        Me.txtestado.Enabled = False
        Me.txtestado.Location = New System.Drawing.Point(217, 714)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(130, 22)
        Me.txtestado.TabIndex = 14
        '
        'txtfecha
        '
        Me.txtfecha.BackColor = System.Drawing.SystemColors.Info
        Me.txtfecha.Enabled = False
        Me.txtfecha.Location = New System.Drawing.Point(391, 714)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(91, 22)
        Me.txtfecha.TabIndex = 15
        '
        'txthorainicio
        '
        Me.txthorainicio.BackColor = System.Drawing.SystemColors.Info
        Me.txthorainicio.Enabled = False
        Me.txthorainicio.Location = New System.Drawing.Point(534, 714)
        Me.txthorainicio.Name = "txthorainicio"
        Me.txthorainicio.Size = New System.Drawing.Size(127, 22)
        Me.txthorainicio.TabIndex = 16
        '
        'txthorafin
        '
        Me.txthorafin.BackColor = System.Drawing.SystemColors.Info
        Me.txthorafin.Enabled = False
        Me.txthorafin.Location = New System.Drawing.Point(713, 714)
        Me.txthorafin.Name = "txthorafin"
        Me.txthorafin.Size = New System.Drawing.Size(124, 22)
        Me.txthorafin.TabIndex = 17
        '
        'txtodontologo
        '
        Me.txtodontologo.BackColor = System.Drawing.SystemColors.Info
        Me.txtodontologo.Enabled = False
        Me.txtodontologo.Location = New System.Drawing.Point(885, 714)
        Me.txtodontologo.Name = "txtodontologo"
        Me.txtodontologo.Size = New System.Drawing.Size(100, 22)
        Me.txtodontologo.TabIndex = 18
        '
        'txtcodigoodontologo
        '
        Me.txtcodigoodontologo.BackColor = System.Drawing.SystemColors.Info
        Me.txtcodigoodontologo.Enabled = False
        Me.txtcodigoodontologo.Location = New System.Drawing.Point(1010, 714)
        Me.txtcodigoodontologo.Name = "txtcodigoodontologo"
        Me.txtcodigoodontologo.Size = New System.Drawing.Size(72, 22)
        Me.txtcodigoodontologo.TabIndex = 19
        '
        'cmdRegistrarCita
        '
        Me.cmdRegistrarCita.Location = New System.Drawing.Point(217, 795)
        Me.cmdRegistrarCita.Name = "cmdRegistrarCita"
        Me.cmdRegistrarCita.Size = New System.Drawing.Size(141, 45)
        Me.cmdRegistrarCita.TabIndex = 20
        Me.cmdRegistrarCita.Text = "REGISTRAR CITA"
        Me.cmdRegistrarCita.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(433, 795)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 45)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'VENTANACITA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 914)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdRegistrarCita)
        Me.Controls.Add(Me.txtcodigoodontologo)
        Me.Controls.Add(Me.txtodontologo)
        Me.Controls.Add(Me.txthorafin)
        Me.Controls.Add(Me.txthorainicio)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.txtestado)
        Me.Controls.Add(Me.txtcodigohorario)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dvgHorarioAtencion)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.txtidcita)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VENTANACITA"
        Me.Text = "VENTANACITA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dvgHorarioAtencion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdBuscarPaciente As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtidcita As TextBox
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents txtdatospaciente As TextBox
    Friend WithEvents dvgHorarioAtencion As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcodigohorario As TextBox
    Friend WithEvents txtestado As TextBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents txthorainicio As TextBox
    Friend WithEvents txthorafin As TextBox
    Friend WithEvents txtodontologo As TextBox
    Friend WithEvents txtcodigoodontologo As TextBox
    Friend WithEvents cmdRegistrarCita As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtdnipaciente As TextBox
    Friend WithEvents txtidpaciente As TextBox
End Class
