Imports System.Drawing.Imaging

Public Class CitaADO

    Private conexionDatos As New Conexion()

    Public Sub RegistrarCita(cita As cCITA)
        Dim sql As String = "EXEC grabarCita @monto='" & cita.MontoCita & "',@idhorario='" & cita.oHorario.Codigo & "',@idpaciente='" & cita.oPaciente.Codigo & "'"
        Try
            conexionDatos.AbrirConexion()
            conexionDatos.EjecutarInserrcionDatos(sql)
            MessageBox.Show("Se Registro La Cita")
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Sub
    Public Function MostrarSiguienteID() As Object
        Try
            conexionDatos.AbrirConexion()
            Dim sql As String = "SELECT ISNULL(MAX(IdCita),0)+1 AS ID FROM Cita"
            Return conexionDatos.EjecutarLecturaDatos(sql)
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Function
    Public Function TotalCitasRegistradas(horario As cHORARIOATENCION) As Object

        Try
            conexionDatos.AbrirConexion()
            Dim sql As String = "select count(a.FechaRegistro) as totalCitas from cita as c inner join HorarioAtencion as a on c.IdHorarioAtencion = a.IdHorarioAtencion where a.FechaRegistro = '" & horario.FechaHorario & "' group by  a.FechaRegistro"
            Dim citaTotal As Integer = conexionDatos.EjecutarLecturaDatos(sql)
            Return citaTotal

            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error al consultar Total Fecha", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Function

    Public Function ListaCitasRegistradas(fecha As String) As DataTable

        Dim sql As String = "EXEC ListaCitasPorFecha @fecha='" & fecha & "'"

        Try
            conexionDatos.AbrirConexion()
            Return conexionDatos.EjecutarConsultaSQL(sql)
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Function
    Public Sub ActualizarCitaDatos(objcita As cCITA)
        Dim idhorario As String = objcita.oHorario.Codigo
        Dim idpaciente As String = objcita.oPaciente.Codigo
        Dim sql As String = "UPDATE CITA SET MontoTotal='" & objcita.MontoCita & "',IdHorarioAtencion='" & idhorario & "',IdPaciente='" & idpaciente & "' where IdCita='" & objcita.CitaID & "'"
        Try
            conexionDatos.AbrirConexion()
            conexionDatos.EjecutarInserrcionDatos(sql)
            MessageBox.Show("Se Actualizo La Cita")
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error Al Actualizar La Cita", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Sub
    Public Sub EliminarCita(idcita As String)
        Dim sql As String = "DELETE FROM CITA WHERE IdCita='" & idcita & "'"
        Try
            conexionDatos.AbrirConexion()
            conexionDatos.EjecutarInserrcionDatos(sql)
            MessageBox.Show("Se Elimino La Cita")
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error Al Eliminar La Cita", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Sub
End Class
