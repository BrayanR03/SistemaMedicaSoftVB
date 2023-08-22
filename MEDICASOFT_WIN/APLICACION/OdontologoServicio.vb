Public Class OdontologoServicio
    Private conexionDatos As New Conexion()
    Private odontologoDatos As New OdontologoADO()

    Public Sub GuardarOdontologo(odontologo As cODONTOLOGO)
        conexionDatos.AbrirConexion()
        odontologoDatos.RegistrarOdontologo(odontologo)
        conexionDatos.CerrarConexion()
    End Sub
    Public Sub actualizar(odontologo As cODONTOLOGO)
        conexionDatos.AbrirConexion()
        odontologoDatos.ActualizarOdontologo(odontologo)
        conexionDatos.CerrarConexion()
    End Sub
    Public Sub eliminar(codigo As String)
        conexionDatos.AbrirConexion()
        odontologoDatos.EliminarOdontologo(codigo)
        conexionDatos.CerrarConexion()
    End Sub
End Class
