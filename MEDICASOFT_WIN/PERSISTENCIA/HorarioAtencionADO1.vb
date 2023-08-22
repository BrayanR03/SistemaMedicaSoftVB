Imports System.Data.SqlClient
Imports System.Drawing.Design

Public Class HorarioAtencionADO1
    Private conexionDatos As New Conexion()

    Public Sub InsertarHorarioAtencion(horario As cHORARIOATENCION)
        Dim insertar As String = "EXEC _grabaHorario @estado='" & horario.EstadoHorario & "',@fecha='" & horario.FechaHorario & "',
                                  @horainicio='" & horario.InicioHorario & "',@horafin='" & horario.FinalHorario & "',@idodontologo='" & horario.OdontologoCodigo.Codigo & "'"
        Try
            conexionDatos.AbrirConexion()
            conexionDatos.EjecutarInserrcionDatos(insertar)
            MessageBox.Show("Se Registro el Horario de Atencion")
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error Al Registrar El Horario de Atencion", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Sub

    Public Function BuscarHorario(idHorario As String) As cHORARIOATENCION
        Dim sql As String = "SELECT estado,FechaRegistro,horainicio,horafin,IdOdontologo FROM HorarioAtencion where IdHorarioAtencion='" & idHorario & "'"
        Dim cn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=Win_MedicaSoft;Integrated Security=true")
        cn.Open()
        Dim rs As SqlDataReader
        Dim cmHorarioBusca As New SqlCommand(sql, cn)
        Dim objhorario As New cHORARIOATENCION()
        Dim odontologoDatos As New OdontologoADO()
        Try
            rs = cmHorarioBusca.ExecuteReader()
            If rs.Read() Then
                objhorario.EstadoHorario = rs("estado")
                objhorario.FechaHorario = rs("FechaRegistro")
                objhorario.InicioHorario = rs("horainicio")
                objhorario.FinalHorario = rs("horafin")
                Dim cododontologo As String = rs("IdOdontologo")
                Dim objodontologo As cODONTOLOGO = odontologoDatos.BuscaOdontologoCodigo(cododontologo)
                objhorario.OdontologoCodigo = objodontologo
                Return objhorario
            End If
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("Error Al Buscar El Horario", Err.Description)
            cn.Close()
        End Try
    End Function
    Public Function MostrarHorarios() As DataTable
        Dim sqlDatos As String = "SELECT hor.IdHorarioAtencion AS CODIGO_HORARIO,hor.estado as ESTADO,hor.FechaRegistro as FECHA,hor.horainicio as H_INICIO,hor.horafin as H_FIN,odo.apellidos+' '+odo.nombres as ODONTOGOLO,odo.IdOdontologo as COD_ODONTOLOGO
                                  FROM HorarioAtencion hor INNER JOIN Odontologo odo
                                  ON odo.IdOdontologo=hor.IdOdontologo
                                  WHERE hor.estado='DISPONIBLE' AND HOR.FechaRegistro>=CONVERT(DATE,GETDATE())"
        Try
            conexionDatos.AbrirConexion()
            Return conexionDatos.EjecutarConsultaSQL(sqlDatos)
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error Al Mostrar Los Horario", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Function
    Public Function ListaHorasRegistradas(horario As cHORARIOATENCION) As List(Of String)
        Dim cn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=Win_MedicaSoft;Integrated Security=true")
        Dim listaHoras = New List(Of String)
        Dim sql As String = "SELECT horainicio,horafin FROM HorarioAtencion WHERE FechaRegistro= '" & horario.FechaHorario & "'"
        cn.Open()
        Dim rs As SqlDataReader
        Dim cmListaHorario As New SqlCommand(sql, cn)
        Try

            rs = cmListaHorario.ExecuteReader()
            While rs.Read()
                listaHoras.Add(rs("horainicio"))
                listaHoras.Add(rs("horafin"))
            End While
            Return listaHoras
            rs.Close()
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(Err.Description)
            cn.Close()
        End Try

    End Function

    Public Function MostrarId() As Object
        Dim sql As String = "SELECT ISNULL(MAX(IdHorarioAtencion),0)+1 as ID FROM HorarioAtencion"
        Try
            conexionDatos.AbrirConexion()
            Dim datosSQL As String = conexionDatos.EjecutarLecturaDatos(sql)
            Return datosSQL.ToString()
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error Al Mostrar El ID Siguiente", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Function

    Public Function EstadoHorario(estado As String, fechainicio As String, fechafin As String) As DataTable
        Dim sql As String = "EXEC EstadoHorario @estado='" & estado & "', @fechainicio='" & fechainicio & "',@fechafin='" & fechafin & "'"
        Try
            conexionDatos.AbrirConexion()
            Return conexionDatos.EjecutarConsultaSQL(sql)
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error Al Mostrar Lista Horarios", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Function
    Public Sub ActualizarHorario(horario As cHORARIOATENCION)
        Dim sql As String = "UPDATE HorarioAtencion SET Estado='" & horario.EstadoHorario & "',FechaRegistro='" & horario.FechaHorario & "',
                            HoraInicio='" & horario.InicioHorario & "',HoraFin='" & horario.FinalHorario & "',IdOdontologo='" & horario.OdontologoCodigo.Codigo & "' WHERE IdHorarioAtencion='" & horario.Codigo & "'"
        Try
            conexionDatos.AbrirConexion()
            conexionDatos.EjecutarInserrcionDatos(sql)
            MessageBox.Show("Se Actualizo EL Horario De Atencion")
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error, Este Horario Esta Registrado en Una Cita. Primero Debes Eliminar La Cita Registrada Con Esete Horario de Atencion", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Sub

    Public Sub EliminarHorario(idhorario As String)
        Dim sql As String = "DELETE FROM HorarioAtencion WHERE IdHorarioAtencion='" & idhorario & "'"
        Try
            conexionDatos.AbrirConexion()
            conexionDatos.EjecutarInserrcionDatos(sql)
            MessageBox.Show("Se Elimino El Horario De Atencion")
            conexionDatos.CerrarConexion()

        Catch ex As Exception
            MessageBox.Show("Error Al Eliminar, Este Horario De Atencion Debe Estar Registrado en Una Cita", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Sub

End Class
