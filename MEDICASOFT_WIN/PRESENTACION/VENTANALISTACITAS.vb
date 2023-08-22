Public Class VENTANALISTACITAS
    Dim conexionDatos As New Conexion()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdElegirOtroHorario.Click
        Dim idhorario As String = txtcodigohorarioeditar.Text.Trim
        If idhorario = "" Then
            MessageBox.Show("No Hay Ningun Horario De La Cita Seleccionada")
        Else

            Me.grupoHorariosLista.Visible = False
            Me.MostrarHorariosDisponibles()
            Me.grupoHorariosDisponibles.Visible = True
        End If
    End Sub

    Private Sub cmdCancelarHorario_Click(sender As Object, e As EventArgs) Handles cmdCancelarHorario.Click
        Me.grupoHorariosDisponibles.Visible = False
        Me.grupoHorariosLista.Visible = True
    End Sub

    Private Sub VENTANALISTACITAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dgvCitasRegistradas.ClearSelection()
        ''Me.Size = New Size(1544, 666)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub

    Public Sub MostrarCitasRegistradasFecha()
        Dim citaDatos As New CitaADO()
        Dim fecha As String = dtpfecharegistro.Value.ToString
        fecha = Format(CDate(dtpfecharegistro.Value.ToString), "yyyy-MM-dd")
        Try
            dgvCitasRegistradas.DataSource = citaDatos.ListaCitasRegistradas(fecha)
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub cmdBuscarFechaCita_Click(sender As Object, e As EventArgs) Handles cmdBuscarFechaCita.Click
        Me.MostrarCitasRegistradasFecha()
    End Sub

    Private Sub dgvCitasRegistradas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCitasRegistradas.CellClick
        txtidcita.Text = dgvCitasRegistradas.CurrentRow.Cells(0).Value.ToString()
        txtmonto.Text = dgvCitasRegistradas.CurrentRow.Cells(1).Value.ToString()
        txtdnibuscar.Text = dgvCitasRegistradas.CurrentRow.Cells(2).Value.ToString()
        txtdatospaciente.Text = dgvCitasRegistradas.CurrentRow.Cells(3).Value.ToString()
        txtidpaciente.Text = dgvCitasRegistradas.CurrentRow.Cells(4).Value.ToString()
        txtcodigohorarioeditar.Text = dgvCitasRegistradas.CurrentRow.Cells(5).Value.ToString()
        txtestadohorarioeditar.Text = dgvCitasRegistradas.CurrentRow.Cells(6).Value.ToString()
        Dim fecha As String = dgvCitasRegistradas.CurrentRow.Cells(7).Value.ToString()
        fecha = Format(CDate(dgvCitasRegistradas.CurrentRow.Cells(7).Value.ToString()), "yyyy-MM-dd")
        txtfechahorarioeditar.Text = fecha
        txthorainicioeditar.Text = dgvCitasRegistradas.CurrentRow.Cells(8).Value.ToString()
        txthorafineditar.Text = dgvCitasRegistradas.CurrentRow.Cells(9).Value.ToString()
        txtodontologoeditar.Text = dgvCitasRegistradas.CurrentRow.Cells(10).Value.ToString()
    End Sub

    Public Sub MostrarHorariosDisponibles()
        Dim horarioDatos As New HorarioAtencionADO1()
        Try

            dgvHorariosDisponibles.DataSource = horarioDatos.MostrarHorarios()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub cmdSeleccionarHorario_Click(sender As Object, e As EventArgs) Handles cmdSeleccionarHorario.Click
        Me.SeleccionarHorarioNuevo()
        Me.grupoHorariosDisponibles.Visible = False
        Me.grupoHorariosLista.Visible = True
    End Sub

    Public Sub SeleccionarHorarioNuevo()
        txtcodigohorarioeditar.Text = dgvHorariosDisponibles.CurrentRow.Cells(0).Value.ToString()
        txtestadohorarioeditar.Text = dgvHorariosDisponibles.CurrentRow.Cells(1).Value.ToString()
        Dim fecha As String = dgvHorariosDisponibles.CurrentRow.Cells(2).Value.ToString()
        fecha = Format(CDate(dgvHorariosDisponibles.CurrentRow.Cells(2).Value.ToString()), "yyyy-MM-dd")
        txtfechahorarioeditar.Text = fecha
        txthorainicioeditar.Text = dgvHorariosDisponibles.CurrentRow.Cells(3).Value.ToString()
        txthorafineditar.Text = dgvHorariosDisponibles.CurrentRow.Cells(4).Value.ToString()
        txtodontologoeditar.Text = dgvHorariosDisponibles.CurrentRow.Cells(6).Value.ToString()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        Me.ActualizarCita()
        Me.LimpiarEntradas()
    End Sub

    Public Sub LimpiarEntradas()
        dtpfecharegistro.Value = Date.Now()
        txtidcita.Text = ""
        txtmonto.Text = ""
        txtcodigohorarioeditar.Text = ""
        txtdatospaciente.Text = ""
        txtdnibuscar.Text = ""
        txtestadohorarioeditar.Text = ""
        txtfechahorarioeditar.Text = ""
        txthorafineditar.Text = ""
        txthorainicioeditar.Text = ""
        txtidpaciente.Text = ""
        txtodontologoeditar.Text = ""
        dgvCitasRegistradas.DataSource = Nothing
    End Sub
    Public Sub ActualizarCita()
        Dim idcita As String, monto As Double, idhorario As String, idpaciente As String
        idcita = txtidcita.Text.Trim
        monto = Convert.ToDouble(txtmonto.Text.Trim)
        idhorario = txtcodigohorarioeditar.Text.Trim
        idpaciente = txtidpaciente.Text.Trim
        If idcita = "" Then
            MessageBox.Show("Debes Elegir Una Cita Para Actualizar")
        Else
            Dim ohorario As New cHORARIOATENCION(idhorario)
            Dim opaciente As New CPACIENTE(idpaciente)
            Dim ocita As New cCITA(idcita, monto, ohorario, opaciente)
            Dim citaser As New CitaServicio()
            Try
                conexionDatos.AbrirConexion()
                citaser.ActualizaCita(ocita)
                conexionDatos.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show(Err.Description)
                conexionDatos.CerrarConexion()
            End Try
        End If

    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Me.BuscarPaciente()
    End Sub

    Public Sub BuscarPaciente()
        Dim conexionDatos As New Conexion()
        Dim citaser As New CitaServicio()
        Dim dni As String = txtdnibuscar.Text.Trim
        Dim objPaciente As CPACIENTE
        Try
            conexionDatos.AbrirConexion()
            objPaciente = citaser.BuscarPaciente(dni)
            txtdatospaciente.Text = objPaciente.Apellido + " " + objPaciente.Nombre
            txtidpaciente.Text = objPaciente.Codigo
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Me.EliminaCitaRegistrada()
        Me.LimpiarEntradas()
    End Sub

    Public Sub EliminaCitaRegistrada()
        Dim idcita As String = txtidcita.Text.Trim
        If idcita = "" Then
            MessageBox.Show("Debes Seleccionar Una Cita Para Eliminar")
        Else

            Dim citaserv As New CitaServicio()
            Try
                citaserv.EliminaCita(idcita)
            Catch ex As Exception
                MessageBox.Show(Err.Description)
            End Try
        End If
    End Sub
End Class