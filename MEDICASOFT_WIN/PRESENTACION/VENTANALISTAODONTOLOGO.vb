Public Class VENTANALISTAODONTOLOGO
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub VENTANALISTAODONTOLOGO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Me.Size = New Size(1029, 739)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.ListadoOdontologo()
        Me.dgvOdontologo.ClearSelection()
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Me.BuscarDNIOdontologo()

    End Sub
    Public Sub BuscarDNIOdontologo()
        Dim dni As String = txtdnibusqueda.Text.Trim
        Dim odontoDatos As New OdontologoADO()
        Dim conexionDatos As New Conexion()
        conexionDatos.AbrirConexion()
        dgvOdontologo.DataSource = odontoDatos.ListadoOdontologoDNI(dni)
        conexionDatos.CerrarConexion()
    End Sub
    Public Sub ListadoOdontologo()
        Dim conexionDatos As New Conexion()
        Dim odontologoDatos As New OdontologoADO()
        conexionDatos.AbrirConexion()
        dgvOdontologo.DataSource = odontologoDatos.ListadoOdontologos()
        conexionDatos.CerrarConexion()
    End Sub
    Public Sub LimpiarENTRADAS()
        txtapellidos.Text = ""
        txtcorreo.Text = ""
        txtdireccion.Text = ""
        txtdni.Text = ""
        txtdnibusqueda.Text = ""
        txtnombres.Text = ""
        txttelefono.Text = ""
        dtpfecha.Value = Date.Now
    End Sub

    Private Sub dgvOdontologo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOdontologo.CellClick

        txtid.Text = dgvOdontologo.CurrentRow.Cells(0).Value.ToString
        txtapellidos.Text = dgvOdontologo.CurrentRow.Cells(1).Value.ToString
        txtnombres.Text = dgvOdontologo.CurrentRow.Cells(2).Value.ToString
        Dim fecha As String = dgvOdontologo.CurrentRow.Cells(3).Value.ToString
        dtpfecha.Value = fecha
        txtdni.Text = dgvOdontologo.CurrentRow.Cells(4).Value.ToString
        txttelefono.Text = dgvOdontologo.CurrentRow.Cells(5).Value.ToString
        txtcorreo.Text = dgvOdontologo.CurrentRow.Cells(6).Value.ToString
        txtdireccion.Text = dgvOdontologo.CurrentRow.Cells(7).Value.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ActualizarOdontologo()
    End Sub

    Public Sub ActualizarOdontologo()
        Dim odontoserv As New OdontologoServicio()
        Dim oodontologo As cODONTOLOGO
        Dim idodonto As String, apellidos As String, nombres As String, direccion As String, telefomo As String, fecha As String, dni As String, correo As String
        idodonto = txtid.Text.Trim
        apellidos = txtapellidos.Text.Trim
        nombres = txtnombres.Text.Trim
        direccion = txtdireccion.Text.Trim
        telefomo = txttelefono.Text.Trim
        fecha = dtpfecha.Value.ToString
        fecha = Format(CDate(dtpfecha.Value.ToString), "yyyy-MM-dd")
        dni = txtdni.Text.Trim
        correo = txtcorreo.Text.Trim
        oodontologo = New cODONTOLOGO(idodonto, apellidos, nombres, dni, direccion, telefomo, fecha, correo)
        If idodonto = "" Then
            MessageBox.Show("Debes Selecionar Un Registro Para Poder Editar")
        Else
            odontoserv.actualizar(oodontologo)
            Me.LimpiarENTRADAS()
            Me.ListadoOdontologo()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.EliminarOdontologo()
    End Sub

    Public Sub EliminarOdontologo()
        Dim idodontologo As String = txtid.Text.Trim
        Dim conexionDatos As New Conexion()
        Dim odontoserv As New OdontologoServicio()
        Try
            conexionDatos.AbrirConexion()
            odontoserv.eliminar(idodontologo)
            Me.LimpiarENTRADAS()
            Me.ListadoOdontologo()
            conexionDatos.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
            conexionDatos.CerrarConexion()
        End Try
    End Sub
End Class