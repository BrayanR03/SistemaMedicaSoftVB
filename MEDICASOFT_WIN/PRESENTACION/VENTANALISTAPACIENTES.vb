Imports System.Data.SqlClient

Public Class VENTANALISTAPACIENTES
    Private Sub txtdnipaciente_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtdnibusqueda.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Me.buscarDNI()
    End Sub

    Public Sub buscarDNI()
        Dim conexionDatos As New Conexion()
        Dim pacienteDatos As New PacienteADO()
        conexionDatos.AbrirConexion()
        Dim dni As String = txtdnibusqueda.Text.Trim
        dgvPacientes.DataSource = pacienteDatos.ListadoPacienteDNI(dni)
        conexionDatos.CerrarConexion()
    End Sub

    Public Sub ListadoPacientes()
        Dim conexionDatos As New Conexion()
        Dim pacienteDatos As New PacienteADO()
        conexionDatos.AbrirConexion()
        dgvPacientes.DataSource = pacienteDatos.ListadoPacientes()
        conexionDatos.CerrarConexion()
    End Sub

    Private Sub VENTANALISTAPACIENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Me.Size = New Size(1217, 735)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.LimpiarEntradas()
        '' Me.dgvPacientes.CurrentCell = Nothing
        Me.ListadoPacientes()

        Me.dgvPacientes.ClearSelection()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
    Public Sub LimpiarEntradas()
        txtapellidos.Text = ""
        txtcorreo.Text = ""
        txtdireccion.Text = ""
        txtdni.Text = ""
        txtdnibusqueda.Text = ""
        txtid.Text = ""
        txtnombres.Text = ""
        txttelefono.Text = ""
        txtdnibusqueda.Select()
        dtpfecha.Value = Date.Now
    End Sub

    Private Sub dgvPacientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPacientes.CellClick

        txtid.Text = dgvPacientes.CurrentRow.Cells(0).Value.ToString
        txtapellidos.Text = dgvPacientes.CurrentRow.Cells(1).Value.ToString
        txtnombres.Text = dgvPacientes.CurrentRow.Cells(2).Value.ToString
        Dim fecha As String = dgvPacientes.CurrentRow.Cells(3).Value.ToString
        dtpfecha.Value = fecha
        txtdni.Text = dgvPacientes.CurrentRow.Cells(4).Value.ToString
        txttelefono.Text = dgvPacientes.CurrentRow.Cells(5).Value.ToString
        txtdireccion.Text = dgvPacientes.CurrentRow.Cells(6).Value.ToString
        txtcorreo.Text = dgvPacientes.CurrentRow.Cells(7).Value.ToString
    End Sub

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        Me.ActualizarPaciente()
        Me.LimpiarEntradas()
        Me.ListadoPacientes()
    End Sub

    Public Sub ActualizarPaciente()
        Dim conexionDatos As New Conexion()
        Dim pacietneserv As New PacienteServicio()
        Dim opaciente As CPACIENTE = Nothing
        Dim idpac As String, apellidos As String, nombres As String, fecha As String, dni As String, telefono As String, direccion As String, correo As String
        idpac = txtid.Text.Trim
        apellidos = txtapellidos.Text.Trim
        nombres = txtnombres.Text.Trim
        fecha = dtpfecha.Value.ToString
        fecha = Format(CDate(dtpfecha.Value.ToString), "yyyy-MM-dd")
        dni = txtdni.Text.Trim
        telefono = txttelefono.Text.Trim
        direccion = txtdireccion.Text.Trim
        correo = txtcorreo.Text.Trim
        opaciente = New CPACIENTE(idpac, apellidos, nombres, dni, direccion, telefono, fecha, correo)
        If idpac = "" Then
            MessageBox.Show("Debes Seleccionar Un Registro Para Editar")
        Else
            pacietneserv.actualizar(opaciente)

        End If

    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Me.EliminarPaciente()
        Me.LimpiarEntradas()
        Me.ListadoPacientes()
    End Sub
    Public Sub EliminarPaciente()
        Dim idpac As String = txtid.Text.Trim
        Dim conexionDatos As New Conexion()
        Dim pacienteDatos As New PacienteADO()
        conexionDatos.AbrirConexion()
        pacienteDatos.EliminarPaciente(idpac)
        conexionDatos.CerrarConexion()
    End Sub

    Private Sub txtapellidos_TextChanged(sender As Object, e As EventArgs) Handles txtapellidos.TextChanged

    End Sub
End Class