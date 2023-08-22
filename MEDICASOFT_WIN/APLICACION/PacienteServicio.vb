Public Class PacienteServicio
    Dim conexionDatos As New Conexion()
    Dim pacienteDatos As New PacienteADO()

    Public Sub guardar(paciente As CPACIENTE)
        conexionDatos.AbrirConexion()
        If Not paciente.TieneEdadValida Then
            MessageBox.Show("Edad No Valida")
            conexionDatos.CerrarConexion()
        Else
            pacienteDatos.InsertarPaciente(paciente)
            conexionDatos.CerrarConexion()
        End If
    End Sub
    Public Sub actualizar(paciente As CPACIENTE)
        conexionDatos.AbrirConexion()
        pacienteDatos.ActualizarPacienteDatos(paciente)
        conexionDatos.CerrarConexion()
    End Sub
End Class
