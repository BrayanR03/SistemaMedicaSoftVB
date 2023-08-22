Imports System.Globalization

Public Class VENTANALISTAHORARIOS

    Private Sub VENTANALISTAHORARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Me.Size = New Size(1178, 676)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        cboFiltroEstado.SelectedIndex = 1
        Me.dgcFechasHorarios.ClearSelection()
        '' txtdni.Text.TrimStart()
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Me.LimpiarEntradas()
        Me.BuscarHorarios()
    End Sub

    Public Sub LimpiarEntradas()
        txtcodigohorario.Text = ""
        txtestado.Text = ""
        dtpfechaeditar.Value = Date.Now
        dtphorainicioeditar.Value = DateTime.Now
        dtphorafineditar.Value = DateTime.Now
        txtdni.Text = ""
        txtcodigoodontologo.Text = ""
        txtdatosodontologo.Text = ""
    End Sub

    Public Sub BuscarHorarios()
        Dim horarioDatos As New HorarioAtencionADO1()
        Dim fechaInicio As String, fechaFin As String, estado As String
        fechaInicio = dtpfechainicio.Value.ToString
        fechaInicio = Format(CDate(dtpfechainicio.Value.ToString), "yyyy-MM-dd")
        fechaFin = dtpfechafinal.Value.ToString
        fechaFin = Format(CDate(dtpfechafinal.Value.ToString), "yyyy-MM-dd")
        estado = cboFiltroEstado.SelectedItem.ToString
        Try
            dgcFechasHorarios.DataSource = horarioDatos.EstadoHorario(estado, fechaInicio, fechaFin)

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub txtdni_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtestado_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtestado.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Me.editarHorario()
        Me.LimpiarEntradas()
        Me.BuscarHorarios()
    End Sub

    Public Sub editarHorario()
        Dim oohorario As cHORARIOATENCION
        Dim cod As String, estado As String, fecha As String, horainicio As String, horafin As String, oodontologo As cODONTOLOGO
        cod = txtcodigohorario.Text.Trim
        estado = txtestado.Text.Trim
        fecha = dtpfechaeditar.Value.ToString
        fecha = Format(CDate(dtpfechaeditar.Value.ToString), "yyyy-MM-dd")
        horainicio = Format(CDate(dtphorainicioeditar.Value.ToString), "HH::mm")
        horafin = Format(CDate(dtphorafineditar.Value.ToString), "HH:mm")
        Dim horarioserv As New HorarioAtencionServicio()
        Dim cododonto As String = txtcodigoodontologo.Text.Trim
        oodontologo = New cODONTOLOGO(cododonto)
        oohorario = New cHORARIOATENCION(cod, estado, fecha, horainicio, horafin, oodontologo)
        If cod = "" Then
            MessageBox.Show("Debes Seleccionar Una Fila para Editar")
        Else
            Try
                horarioserv.ActualzarHorario(oohorario)
            Catch ex As Exception
                MessageBox.Show(Err.Description)
            End Try
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.OdontologoBuscar()
    End Sub
    Public Sub OdontologoBuscar()
        Dim horarioservicio As New HorarioAtencionServicio()
        ''Dim objodonto As cODONTOLOGO
        Dim codigo As String = txtdni.Text.TrimStart
        Console.WriteLine(codigo)
        If Not codigo = "" Then
            Console.WriteLine(horarioservicio.OdontologoBuscar(codigo))
            Dim objodontologo As cODONTOLOGO = horarioservicio.OdontologoBuscar(codigo)
            If objodontologo Is Nothing Then
                Console.WriteLine("Esta Vacio EL oBJETO")

            Else
                txtdatosodontologo.Text = objodontologo.ApellidoOdontologo + " " + objodontologo.NombreOdontologo
                txtcodigoodontologo.Text = objodontologo.Codigo

            End If
        Else
            MessageBox.Show("Debes Ingresar Un DNI")
        End If
    End Sub

    Private Sub dgcFechasHorarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgcFechasHorarios.CellClick

        Dim fecha As String, horain As String, horafin As String
        txtcodigohorario.Text = dgcFechasHorarios.CurrentRow.Cells(0).Value.ToString
        txtestado.Text = dgcFechasHorarios.CurrentRow.Cells(1).Value.ToString
        fecha = dgcFechasHorarios.CurrentRow.Cells(2).Value.ToString
        horain = dgcFechasHorarios.CurrentRow.Cells(3).Value.ToString
        horafin = dgcFechasHorarios.CurrentRow.Cells(4).Value.ToString

        horain = Format(CDate(horain), "HH:mm:ss")
        horafin = Format(CDate(horafin), "HH:mm:ss")
        Dim tiempoHoraInicio As DateTime = Convert.ToDateTime(horain)
        Dim tiempoHoraFin As DateTime = Convert.ToDateTime(horafin)
        dtpfechaeditar.Value = Format(CDate(fecha), "dd-MM-yyyy")
        dtphorainicioeditar.Value = tiempoHoraInicio
        dtphorafineditar.Value = tiempoHoraFin

        txtdatosodontologo.Text = dgcFechasHorarios.CurrentRow.Cells(5).Value.ToString
        txtcodigoodontologo.Text = dgcFechasHorarios.CurrentRow.Cells(6).Value.ToString
        txtdni.Text = dgcFechasHorarios.CurrentRow.Cells(7).Value.ToString
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Me.EliminarHorario()
        Me.LimpiarEntradas()
        Me.BuscarHorarios()
    End Sub

    Public Sub EliminarHorario()
        Dim id As String = txtcodigohorario.Text.Trim
        Dim horarioserv As New HorarioAtencionServicio()
        If id = "" Then
            MessageBox.Show("Debes Seleccionar Un Registro para ELIMINAR")
        Else
            horarioserv.EliminarHorarioAtencion(id)
        End If
    End Sub


End Class