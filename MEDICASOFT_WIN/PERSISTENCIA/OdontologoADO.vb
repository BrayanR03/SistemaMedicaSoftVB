Imports System.Data.SqlClient

Public Class OdontologoADO
    Private conexionDatos As New Conexion()

    Public Sub RegistrarOdontologo(odontologo As cODONTOLOGO)
        Dim insertar As String = "EXEC _grabaOdontologo @apellidos='" & odontologo.ApellidoOdontologo & "',@nombres='" & odontologo.NombreOdontologo & "',
                                  @fecha='" & odontologo.FechaNacimientoOdontologo & "',@dni='" & odontologo.DniOdontologo & "',@telefono='" & odontologo.TelefonoOdontologo & "',@direccion='" & odontologo.DireccionOdontologo & "',
                                  @correo='" & odontologo.Correo & "'"
        Try
            conexionDatos.AbrirConexion()
            conexionDatos.EjecutarInserrcionDatos(insertar)
            MessageBox.Show("Se Registro El Odontologo")
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error al Registrar El Odontologo", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Sub


    Public Function BuscaOdontologoCodigo(Dni As String) As cODONTOLOGO
        Dim sql As String = "SELECT apellidos,nombres,dni,IdOdontologo FROM Odontologo where Dni='" & Dni & "'"

        Dim cn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=Win_MedicaSoft;Integrated Security=true")
        cn.Open()
        Dim rs As SqlDataReader
        Dim cmOdontologo As New SqlCommand(sql, cn)
        Dim oodontologo As New cODONTOLOGO()
        Try

            rs = cmOdontologo.ExecuteReader()

            If rs.Read() Then
                oodontologo.ApellidoOdontologo = rs("apellidos")
                oodontologo.NombreOdontologo = rs("nombres")
                oodontologo.DniOdontologo = Dni
                oodontologo.Codigo = rs("IdOdontologo")
                Return oodontologo
            Else
                MessageBox.Show("No existe el DNI del Odontologo", Err.Description)
                cn.Close()
            End If
            cn.Close()

        Catch ex As Exception
            MessageBox.Show("Error al buscar el odontologo", Err.Description)
            cn.Close()
        End Try
    End Function

    Public Function MostrarId() As Object
        Dim sql As String = "SELECT ISNULL(MAX(IdOdontologo),0)+1 as ID from Odontologo"
        Try
            conexionDatos.AbrirConexion()
            Dim datosSQL As String = conexionDatos.EjecutarLecturaDatos(sql)
            Return datosSQL.ToString()
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error Al Mostrar El Siguiente ID", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Function
    Public Function ListadoOdontologos() As DataTable
        Dim sql As String = "SELECT *FROM ODONTOLOGO"
        Try
            conexionDatos.AbrirConexion()
            Return conexionDatos.EjecutarConsultaSQL(sql)
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("ERROR AL MOSTRAR LOS ODONTOLOGO REGISTRADOS", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Function
    Public Function ListadoOdontologoDNI(dni As String) As DataTable
        Dim sql As String = "SELECT *FROM ODONTOLOGO where Dni LIKE '%" & dni & "%'"
        Try
            conexionDatos.AbrirConexion()
            Return conexionDatos.EjecutarConsultaSQL(sql)
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error Al Mostrar Listado Odotnolgoo", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Function
    Public Sub ActualizarOdontologo(odontologo As cODONTOLOGO)
        Dim sql As String = "UPDATE Odontologo SET Apellidos='" & odontologo.ApellidoOdontologo & "',Nombres='" & odontologo.NombreOdontologo & "',
                             FechaNacimiento='" & odontologo.FechaNacimientoOdontologo & "',Dni='" & odontologo.DniOdontologo & "',Telefono='" & odontologo.TelefonoOdontologo & "',
                             Direccion='" & odontologo.DireccionOdontologo & "',Correo='" & odontologo.Correo & "' where IdOdontologo='" & odontologo.Codigo & "'"
        Try
            conexionDatos.AbrirConexion()
            conexionDatos.EjecutarInserrcionDatos(sql)
            MessageBox.Show("Se Actualizaron Los Datos del Odontologo")
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error Al Actualizar Los Datos Del Paciente", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Sub

    Public Sub EliminarOdontologo(codido As String)
        Dim sql As String = "DELETE FROM ODONTOLOGO WHERE IdOdontologo='" & codido & "'"
        Try
            conexionDatos.AbrirConexion()
            conexionDatos.EjecutarInserrcionDatos(sql)
            MessageBox.Show("Se Elimino El Odontolgo")
            conexionDatos.CerrarConexion()

        Catch ex As Exception
            MessageBox.Show("Error, Este Odontologo Esta Registrado En Un Horario de Atencion. 
                             ¡¡ Debes Eliminar El Horario de Atencion !!", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Sub
End Class
