Imports System.Data.SqlClient

Public Class LoginUsuario


    Public Function VerificarUusarioContraseña(usuario As String, contraseña As String) As Boolean
        Dim conexionDatos As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=Win_MedicaSoft;Integrated Security=true")

        Try

            Dim sql As String = "SELECT us.Usuario as USUARIO,us.Contraseña as Contraseña,odo.Apellidos as ODONTOLOGO FROM USUARIO us INNER JOIN Odontologo ODO 
                                 ON odo.IdOdontologo=us.IdAdministrador"
            conexionDatos.Open()
            Dim rs As SqlDataReader
            Dim cmValida As New SqlCommand(sql, conexionDatos)
            rs = cmValida.ExecuteReader()
            Dim listausuarios As New List(Of String)
            Dim listacontrasena As New List(Of String)
            While rs.Read()
                listausuarios.Add(rs("USUARIO"))
                listacontrasena.Add(rs("Contraseña"))
                ''Dim usuariol As String = rs("USUARIO")
                ''Dim contral As String = rs("Contraseña")
            End While
            If listausuarios.Contains(usuario) And listacontrasena.Contains(contraseña) Then
                Return True
            Else
                Return False
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("No existe este Usuario")
            conexionDatos.Close()
        End Try

    End Function
End Class
