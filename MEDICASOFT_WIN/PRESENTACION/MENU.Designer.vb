<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PACIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRARPACIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTAPACIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ODONTOLOGOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRARODONTOLOGOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTADOODONTOLOGOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HORARIOATENCIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRARHORARIOATENCIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTADOHORARIOSATENCIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CITAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRARCITAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTADOCITASREGISTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCerrarSesion = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gray
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PACIENTEToolStripMenuItem, Me.ODONTOLOGOToolStripMenuItem, Me.HORARIOATENCIONToolStripMenuItem, Me.CITAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(665, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PACIENTEToolStripMenuItem
        '
        Me.PACIENTEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRARPACIENTEToolStripMenuItem, Me.LISTAPACIENTESToolStripMenuItem})
        Me.PACIENTEToolStripMenuItem.Name = "PACIENTEToolStripMenuItem"
        Me.PACIENTEToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.PACIENTEToolStripMenuItem.Text = "PACIENTE"
        '
        'REGISTRARPACIENTEToolStripMenuItem
        '
        Me.REGISTRARPACIENTEToolStripMenuItem.Name = "REGISTRARPACIENTEToolStripMenuItem"
        Me.REGISTRARPACIENTEToolStripMenuItem.Size = New System.Drawing.Size(248, 26)
        Me.REGISTRARPACIENTEToolStripMenuItem.Text = "REGISTRAR PACIENTE"
        '
        'LISTAPACIENTESToolStripMenuItem
        '
        Me.LISTAPACIENTESToolStripMenuItem.Name = "LISTAPACIENTESToolStripMenuItem"
        Me.LISTAPACIENTESToolStripMenuItem.Size = New System.Drawing.Size(248, 26)
        Me.LISTAPACIENTESToolStripMenuItem.Text = "LISTA PACIENTES"
        '
        'ODONTOLOGOToolStripMenuItem
        '
        Me.ODONTOLOGOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRARODONTOLOGOToolStripMenuItem, Me.LISTADOODONTOLOGOSToolStripMenuItem})
        Me.ODONTOLOGOToolStripMenuItem.Name = "ODONTOLOGOToolStripMenuItem"
        Me.ODONTOLOGOToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.ODONTOLOGOToolStripMenuItem.Text = "ODONTOLOGO"
        '
        'REGISTRARODONTOLOGOToolStripMenuItem
        '
        Me.REGISTRARODONTOLOGOToolStripMenuItem.Name = "REGISTRARODONTOLOGOToolStripMenuItem"
        Me.REGISTRARODONTOLOGOToolStripMenuItem.Size = New System.Drawing.Size(283, 26)
        Me.REGISTRARODONTOLOGOToolStripMenuItem.Text = "REGISTRAR ODONTOLOGO"
        '
        'LISTADOODONTOLOGOSToolStripMenuItem
        '
        Me.LISTADOODONTOLOGOSToolStripMenuItem.Name = "LISTADOODONTOLOGOSToolStripMenuItem"
        Me.LISTADOODONTOLOGOSToolStripMenuItem.Size = New System.Drawing.Size(283, 26)
        Me.LISTADOODONTOLOGOSToolStripMenuItem.Text = "LISTADO ODONTOLOGOS"
        '
        'HORARIOATENCIONToolStripMenuItem
        '
        Me.HORARIOATENCIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRARHORARIOATENCIONToolStripMenuItem, Me.LISTADOHORARIOSATENCIONToolStripMenuItem})
        Me.HORARIOATENCIONToolStripMenuItem.Name = "HORARIOATENCIONToolStripMenuItem"
        Me.HORARIOATENCIONToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.HORARIOATENCIONToolStripMenuItem.Text = "HORARIO ATENCION"
        '
        'REGISTRARHORARIOATENCIONToolStripMenuItem
        '
        Me.REGISTRARHORARIOATENCIONToolStripMenuItem.Name = "REGISTRARHORARIOATENCIONToolStripMenuItem"
        Me.REGISTRARHORARIOATENCIONToolStripMenuItem.Size = New System.Drawing.Size(327, 26)
        Me.REGISTRARHORARIOATENCIONToolStripMenuItem.Text = "REGISTRAR HORARIO ATENCION"
        '
        'LISTADOHORARIOSATENCIONToolStripMenuItem
        '
        Me.LISTADOHORARIOSATENCIONToolStripMenuItem.Name = "LISTADOHORARIOSATENCIONToolStripMenuItem"
        Me.LISTADOHORARIOSATENCIONToolStripMenuItem.Size = New System.Drawing.Size(327, 26)
        Me.LISTADOHORARIOSATENCIONToolStripMenuItem.Text = "LISTADO HORARIOS ATENCION"
        '
        'CITAToolStripMenuItem
        '
        Me.CITAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRARCITAToolStripMenuItem, Me.LISTADOCITASREGISTRADASToolStripMenuItem})
        Me.CITAToolStripMenuItem.Name = "CITAToolStripMenuItem"
        Me.CITAToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.CITAToolStripMenuItem.Text = "CITA"
        '
        'REGISTRARCITAToolStripMenuItem
        '
        Me.REGISTRARCITAToolStripMenuItem.Name = "REGISTRARCITAToolStripMenuItem"
        Me.REGISTRARCITAToolStripMenuItem.Size = New System.Drawing.Size(287, 26)
        Me.REGISTRARCITAToolStripMenuItem.Text = "REGISTRAR CITA"
        '
        'LISTADOCITASREGISTRADASToolStripMenuItem
        '
        Me.LISTADOCITASREGISTRADASToolStripMenuItem.Name = "LISTADOCITASREGISTRADASToolStripMenuItem"
        Me.LISTADOCITASREGISTRADASToolStripMenuItem.Size = New System.Drawing.Size(287, 26)
        Me.LISTADOCITASREGISTRADASToolStripMenuItem.Text = " LISTA CITAS REGISTRADAS"
        '
        'cmdCerrarSesion
        '
        Me.cmdCerrarSesion.Image = Global.MEDICASOFT_WIN.My.Resources.Resources._3
        Me.cmdCerrarSesion.Location = New System.Drawing.Point(571, 327)
        Me.cmdCerrarSesion.Name = "cmdCerrarSesion"
        Me.cmdCerrarSesion.Size = New System.Drawing.Size(108, 104)
        Me.cmdCerrarSesion.TabIndex = 1
        Me.cmdCerrarSesion.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MEDICASOFT_WIN.My.Resources.Resources.LOGIN3
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1095, 652)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.MEDICASOFT_WIN.My.Resources.Resources._4
        Me.PictureBox2.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(665, 400)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MEDICASOFT_WIN.My.Resources.Resources.FONDO_FRM_PRINCIPAL1
        Me.ClientSize = New System.Drawing.Size(665, 423)
        Me.Controls.Add(Me.cmdCerrarSesion)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MENU"
        Me.Text = "MENU"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PACIENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTRARPACIENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ODONTOLOGOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTRARODONTOLOGOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HORARIOATENCIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTRARHORARIOATENCIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CITAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTRARCITAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdCerrarSesion As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LISTAPACIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LISTADOODONTOLOGOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LISTADOHORARIOSATENCIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LISTADOCITASREGISTRADASToolStripMenuItem As ToolStripMenuItem
End Class
