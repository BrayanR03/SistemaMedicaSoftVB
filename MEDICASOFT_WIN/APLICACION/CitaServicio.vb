Public Class CitaServicio

    Dim conexionDatos As New Conexion()
    Dim citaDatos As New CitaADO()
    Dim pacienteDatos As New PacienteADO()
    Public Function BuscarHorario(IdHorario As String) As cHORARIOATENCION
        conexionDatos.AbrirConexion()
        Dim horarioDatos As New HorarioAtencionADO1()
        Dim objhorario As cHORARIOATENCION = horarioDatos.BuscarHorario(IdHorario)
        conexionDatos.CerrarConexion()
        Return objhorario
    End Function

    Public Function BuscarPaciente(DniPaciente As String) As CPACIENTE
        conexionDatos.AbrirConexion()
        Dim objpaciente As New CPACIENTE()
        objpaciente = pacienteDatos.PacienteBuscar(DniPaciente)
        conexionDatos.CerrarConexion()
        Return objpaciente
    End Function
    Public Sub GuardarCita(cita As cCITA)
        Dim objhorario As cHORARIOATENCION = cita.oHorario
        conexionDatos.AbrirConexion()
        Dim totalC As Integer = citaDatos.TotalCitasRegistradas(objhorario)
        Dim citaEntero As Integer = Convert.ToInt32(totalC)
        If Not cita.MontoValido Then
            MessageBox.Show("Error, El Monto Supera el Estipulado", Err.Description)
            conexionDatos.CerrarConexion()
        ElseIf Not cita.PermitirNuevaCita(totalC) Then
            MessageBox.Show("Se Alcanzo El Limite de Registros de Cita Diarias", Err.Description)
            conexionDatos.CerrarConexion()
        Else
            citaDatos.RegistrarCita(cita)
            conexionDatos.CerrarConexion()
        End If

    End Sub
    Public Sub ActualizaCita(objcita As cCITA)
        conexionDatos.AbrirConexion()
        citaDatos.ActualizarCitaDatos(objcita)
        conexionDatos.CerrarConexion()
    End Sub

    Public Sub EliminaCita(idcita As String)
        conexionDatos.AbrirConexion()
        citaDatos.EliminarCita(idcita)
        conexionDatos.CerrarConexion()
    End Sub
End Class
