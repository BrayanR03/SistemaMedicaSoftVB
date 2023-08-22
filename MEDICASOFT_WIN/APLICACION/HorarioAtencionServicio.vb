Public Class HorarioAtencionServicio
    Dim conexionDatos As New Conexion
    Dim odontologoDatos As New OdontologoADO

    Public Function OdontologoBuscar(Dni As String) As cODONTOLOGO
        conexionDatos.AbrirConexion()
        Dim oodontologo As New cODONTOLOGO()
        oodontologo = odontologoDatos.BuscaOdontologoCodigo(Dni)
        ''Console.WriteLine(oodontologo.Codigo)
        conexionDatos.CerrarConexion()
        Return oodontologo
    End Function
    Public Sub GuardarHorario(horario As cHORARIOATENCION)
        Dim horarioDatos As New HorarioAtencionADO1
        Dim lista As List(Of String)
        lista = horarioDatos.ListaHorasRegistradas(horario)
        conexionDatos.AbrirConexion()
        If Not horario.TieneHoraValida Then
            MessageBox.Show("Error, Las Horas Ingresadas No Son Validas", Err.Description)
        ElseIf lista.Contains(horario.InicioHorario) Or lista.Contains(horario.FinalHorario) Then
            MessageBox.Show("Error, esta hora ya esta registrada en otra fecha", Err.Description)
        Else
            horarioDatos.InsertarHorarioAtencion(horario)
            conexionDatos.CerrarConexion()

        End If

    End Sub
    Public Sub ActualzarHorario(horario As cHORARIOATENCION)
        Dim horarioDatos As New HorarioAtencionADO1()
        conexionDatos.AbrirConexion()
        horarioDatos.ActualizarHorario(horario)
        conexionDatos.CerrarConexion()
    End Sub
    Public Sub EliminarHorarioAtencion(idhorario As String)
        conexionDatos.AbrirConexion()
        Dim horarioDatos As New HorarioAtencionADO1()
        horarioDatos.EliminarHorario(idhorario)
        conexionDatos.CerrarConexion()
    End Sub
End Class
