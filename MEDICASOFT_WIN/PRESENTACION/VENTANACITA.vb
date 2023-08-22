Public Class VENTANACITA

    Dim conexionDatos As New Conexion()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdBuscarPaciente.Click
        Me.PacienteBusqueda()
    End Sub

    Public Sub PacienteBusqueda()
        Dim dni As String = txtdnipaciente.Text.Trim
        Try
            Dim citaserv As New CitaServicio()
            Dim objpaciente As CPACIENTE = citaserv.BuscarPaciente(dni)
            If objpaciente Is Nothing Then
                Console.WriteLine("Objeto Vacio")
                Me.LimpiarEntradas()
            Else
                txtdatospaciente.Text = objpaciente.Apellido + " " + objpaciente.Nombre
                txtidpaciente.Text = objpaciente.Codigo
                conexionDatos.CerrarConexion()

            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub VENTANACITA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LimpiarEntradas()
        ''  Me.Size = New Size(1137, 961)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub

    Public Sub mostrarID()
        Dim ocita As New CitaADO()
        Try
            conexionDatos.AbrirConexion()
            txtidcita.Text = ocita.MostrarSiguienteID()
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error Al Mostrar El Id", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Sub
    Public Sub HorariosDisponibles()
        Dim horarioDatos As New HorarioAtencionADO1

        dvgHorarioAtencion.DataSource = horarioDatos.MostrarHorarios()
    End Sub

    Private Sub dvgHorarioAtencion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgHorarioAtencion.CellClick

        txtcodigohorario.Text = dvgHorarioAtencion.CurrentRow.Cells(0).Value.ToString()
        txtestado.Text = dvgHorarioAtencion.CurrentRow.Cells(1).Value.ToString()
        Dim fechaconver As String = dvgHorarioAtencion.CurrentRow.Cells(2).Value.ToString()
        fechaconver = Format(CDate(dvgHorarioAtencion.CurrentRow.Cells(2).Value.ToString()), "dd-MM-yyyy")
        txtfecha.Text = fechaconver
        txthorainicio.Text = dvgHorarioAtencion.CurrentRow.Cells(3).Value.ToString()
        txthorafin.Text = dvgHorarioAtencion.CurrentRow.Cells(4).Value.ToString()
        txtodontologo.Text = dvgHorarioAtencion.CurrentRow.Cells(5).Value.ToString
        txtcodigoodontologo.Text = dvgHorarioAtencion.CurrentRow.Cells(6).Value.ToString()

    End Sub

    Private Sub cmdRegistrarCita_Click(sender As Object, e As EventArgs) Handles cmdRegistrarCita.Click
        Me.GrabaCita()
        Me.LimpiarEntradas()
    End Sub

    Public Sub GrabaCita()
        Dim ocita As cCITA
        Dim codpaciente As String, codhorario As String, cododontologo As String, estado As String, fecha As String, horain As String, horafin As String, monto As Double, idcita As Integer
        codpaciente = txtidpaciente.Text.Trim
        codhorario = txtcodigohorario.Text.Trim
        estado = txtestado.Text.Trim
        fecha = txtfecha.Text.Trim
        horain = txthorainicio.Text.Trim
        horafin = txthorafin.Text.Trim
        monto = Convert.ToDouble(txtmonto.Text.Trim)
        idcita = txtidcita.Text.Trim
        cododontologo = txtcodigoodontologo.Text.Trim
        Dim datosodontologo As New OdontologoADO()
        Dim objpaciente As New CPACIENTE(codpaciente)
        Dim objodontologo As New cODONTOLOGO(cododontologo)
        Dim citaserv As New CitaServicio()
        Dim fechaconver As String = Format(CDate(fecha), "yyyy-MM-dd")
        Dim objhorario As cHORARIOATENCION
        objhorario = New cHORARIOATENCION(codhorario, estado, fechaconver, horain, horafin, objodontologo)
        ocita = New cCITA(idcita, monto, objhorario, objpaciente)
        Try
            citaserv.GuardarCita(ocita)
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub
    Public Sub LimpiarEntradas()
        Me.txtdnipaciente.Text = ""
        Me.txtdatospaciente.Text = ""
        Me.mostrarID()
        Me.HorariosDisponibles()
        Me.dvgHorarioAtencion.ClearSelection()
        Me.txtcodigohorario.Text = ""
        Me.txtestado.Text = ""
        Me.txtfecha.Text = ""
        Me.txthorainicio.Text = ""
        Me.txthorafin.Text = ""
        Me.txtcodigoodontologo.Text = ""
        Me.txtodontologo.Text = ""
        Me.txtdnipaciente.Select()
    End Sub

    Private Sub txtdnipaciente_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtdnipaciente.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dvgHorarioAtencion_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dvgHorarioAtencion.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class