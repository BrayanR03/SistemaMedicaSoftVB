Imports System.Data.SqlClient

Public Class PacienteADO
    Private conexionDatos As New Conexion()

    Public Sub InsertarPaciente(paciente As CPACIENTE)

        Dim insertarDatos As String = "EXEC _grabaPaciente @apellidos='" & paciente.Apellido & "',@nombres='" & paciente.Nombre & "',@dni='" & paciente.DniPaciente & "',@direccion='" & paciente.DireccionPaciente & "',@telefono='" & paciente.TelefonoPaciente & "',@fecha='" & paciente.FechaNacimientoPaciente & "',
                                       @correo='" & paciente.Correo & "'"
        Try
            conexionDatos.AbrirConexion()
            conexionDatos.EjecutarInserrcionDatos(insertarDatos)
            MessageBox.Show("Se Registro el Paciente")
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Sub

    Public Function PacienteBuscar(Dni As String) As CPACIENTE
        Dim sql As String = "SELECT apellidos,nombres,dni,IdPaciente FROM PACIENTE where Dni='" & Dni & "'"
        Dim cn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=Win_MedicaSoft;Integrated Security=true")
        cn.Open()
        Dim rs As SqlDataReader
        Dim cmPaciente As New SqlCommand(sql, cn)
        Dim opaciente As New CPACIENTE()

        Try

            rs = cmPaciente.ExecuteReader()
            If rs.Read() Then
                opaciente.Apellido = rs("apellidos")
                opaciente.Nombre = rs("nombres")
                opaciente.DniPaciente = Dni
                opaciente.Codigo = rs("IdPaciente")
                Return opaciente
            Else
                MessageBox.Show("No existe EL DNI Del Paciente", Err.Description)
            End If
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("Error Al Buscar EL Paciente", Err.Description)
            cn.Close()
        End Try
    End Function

    Public Function MostrarId() As Object
        Dim sql As String = "SELECT ISNULL(MAX(IdPaciente),0)+1 as ID FROM PACIENTE"
        Try
            conexionDatos.AbrirConexion()
            Dim datosSQl As String = conexionDatos.EjecutarLecturaDatos(sql)
            Return datosSQl.ToString()
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error Al Mostrar El ID Siguiente", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Function

    Public Function ListadoPacientes() As DataTable
        Dim sql As String = "SELECT *FROM PACIENTE"
        Return conexionDatos.EjecutarConsultaSQL(sql)
    End Function
    Public Function ListadoPacienteDNI(dni As String) As DataTable
        Dim sql As String = "SELECT *FROM PACIENTE WHERE Dni LIKE '%" & dni & "%'"
        Return conexionDatos.EjecutarConsultaSQL(sql)
    End Function

    Public Sub ActualizarPacienteDatos(paciente As CPACIENTE)

        Try
            Dim sql As String = "UPDATE Paciente set Apellidos='" & paciente.Apellido & "',Nombres='" & paciente.Nombre & "',FechaNacimiento='" & paciente.FechaNacimientoPaciente & "',
                            Dni='" & paciente.DniPaciente & "',Telefono='" & paciente.TelefonoPaciente & "',Direccion='" & paciente.DireccionPaciente & "',
                            Correo='" & paciente.Correo & "' where IdPaciente='" & paciente.Codigo & "'"
            conexionDatos.AbrirConexion()
            conexionDatos.EjecutarInserrcionDatos(sql)
            MessageBox.Show("Se Actualizo Los Datos Del Paciente")
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error Al Actualizar Los Datos", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Sub
    Public Function EliminarPaciente(codigo As String) As CPACIENTE
        Dim sql As String = "DELETE FROM PACIENTE WHERE IdPaciente='" & codigo & "'"
        Try
            conexionDatos.AbrirConexion()
            conexionDatos.EjecutarInserrcionDatos(sql)
            MessageBox.Show("Se Elimino El Paciente")
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error, Este Paciente esta Registrado en Una Cita. ¡¡ Debes Eliminar La Cita !!", Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Function
End Class


