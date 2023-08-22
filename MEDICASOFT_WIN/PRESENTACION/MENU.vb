Public Class MENU
    Private Sub REGISTRARPACIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRARPACIENTEToolStripMenuItem.Click
        Dim ventpaciente As New VENTANAPACIENTE()
        ventpaciente.Show()
    End Sub

    Private Sub REGISTRARCITAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRARCITAToolStripMenuItem.Click
        Dim ventCita As New VENTANACITA()
        ventCita.Show()
    End Sub

    Private Sub REGISTRARODONTOLOGOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRARODONTOLOGOToolStripMenuItem.Click
        Dim ventodontologo As New VENTANAODONTOLOGO()
        ventodontologo.Show()
    End Sub

    Private Sub REGISTRARHORARIOATENCIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRARHORARIOATENCIONToolStripMenuItem.Click
        Dim venthorario As New VENTANAHORARIO()
        venthorario.Show()
    End Sub

    Private Sub cmdCerrarSesion_Click(sender As Object, e As EventArgs) Handles cmdCerrarSesion.Click
        Me.Hide()
        LOGIN.Show()
    End Sub

    Private Sub LISTAPACIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTAPACIENTESToolStripMenuItem.Click
        Dim ventanalistapcientes As New VENTANALISTAPACIENTES()
        ventanalistapcientes.Show()
    End Sub

    Private Sub LISTADOODONTOLOGOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTADOODONTOLOGOSToolStripMenuItem.Click
        Dim ventlistadoodontologo As New VENTANALISTAODONTOLOGO()
        ventlistadoodontologo.Show()
    End Sub

    Private Sub LISTADOHORARIOSATENCIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTADOHORARIOSATENCIONToolStripMenuItem.Click
        Dim ventlistahorarios As New VENTANALISTAHORARIOS()
        ventlistahorarios.Show()
    End Sub

    Private Sub LISTADOCITASREGISTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTADOCITASREGISTRADASToolStripMenuItem.Click
        Dim ventlistacitas As New VENTANALISTACITAS()
        ventlistacitas.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub MENU_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            MessageBox.Show("Debes Cerrar Sesion!!")
        End If
    End Sub

    Private Sub MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Me.Size = New Size(683, 470)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub
End Class