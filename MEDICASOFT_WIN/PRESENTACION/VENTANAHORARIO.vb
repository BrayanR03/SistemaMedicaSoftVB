Imports System.Runtime.Remoting.Messaging

Public Class VENTANAHORARIO

    Dim conexionDatos As New Conexion()
    Private Sub cmdRegistrar_Click(sender As Object, e As EventArgs) Handles cmdRegistrar.Click
        Me.registrarHorario()
        Me.limpiarEntradas()
    End Sub

    Public Sub limpiarEntradas()
        dtpfecha.Value = Date.Now
        dtphorainicio.Value = New DateTime(Date.Now.Year, Date.Now.Month, Date.Now.Day, 9, 0, 0)
        dtphorafin.Value = New DateTime(Date.Now.Year, Date.Now.Month, Date.Now.Day, 9, 59, 0)
        Me.txtdniodontologo.Text = ""
        Me.txtidodontologo.Text = ""
        Me.txtdatosodontologo.Text = ""
        Me.MostrarIdHorario()
        txtdniodontologo.Select()
    End Sub
    Public Sub MostrarIdHorario()
        conexionDatos.AbrirConexion()
        Dim horarioDatos As New HorarioAtencionADO1()
        txtidhorario.Text = horarioDatos.MostrarId()
    End Sub
    Public Sub registrarHorario()
        Dim odonto As cODONTOLOGO
        Dim horarioDatos As New HorarioAtencionADO1
        Dim ohorario As cHORARIOATENCION
        Dim horarioServicio As New HorarioAtencionServicio
        Dim cod As String, estado As String
        cod = txtidhorario.Text.Trim
        estado = txtestado.Text.Trim
        Dim fecha As String = dtpfecha.Value.ToString
        fecha = Format(CDate(dtpfecha.Value.ToString), "yyyy-MM-dd")
        Dim inicio As String = dtphorainicio.Value.ToString
        inicio = Format(CDate(dtphorainicio.Value.ToString), "HH:mm")
        Dim fin As String = dtphorafin.Value.ToString
        fin = Format(CDate(dtphorafin.Value.ToString), "HH:mm")
        Dim idodontologo As String = txtidodontologo.Text.Trim
        odonto = New cODONTOLOGO(idodontologo)
        ohorario = New cHORARIOATENCION(cod, estado, fecha, inicio, fin, odonto)
        If odonto Is Nothing Or ohorario Is Nothing Then

            MessageBox.Show("Necesitas Llenar Todos Los Campos Necesarios")
        Else
            horarioServicio.GuardarHorario(ohorario)

        End If
    End Sub

    Private Sub cmdVerOdontologo_Click(sender As Object, e As EventArgs) Handles cmdVerOdontologo.Click
        Me.OdontologoBuscar()
    End Sub

    Public Sub OdontologoBuscar()
        Dim horarioservicio As New HorarioAtencionServicio()
        ''Dim objodonto As cODONTOLOGO
        Dim codigo As String = txtdniodontologo.Text.Trim
        If Not codigo = "" Then
            Dim objodontologo As cODONTOLOGO = horarioservicio.OdontologoBuscar(codigo)
            If objodontologo Is Nothing Then
                Console.WriteLine("Esta Vacio EL oBJETO")
                Me.limpiarEntradas()
            Else
                txtdatosodontologo.Text = objodontologo.ApellidoOdontologo + " " + objodontologo.NombreOdontologo
                txtidodontologo.Text = objodontologo.Codigo

            End If
        Else
            MessageBox.Show("Debes Ingresar Un DNI")
        End If
    End Sub
    Private Sub VENTANAHORARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.limpiarEntradas()
        ''Me.Size = New Size(888, 497)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub

    Private Sub txtdniodontologo_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtdniodontologo.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class