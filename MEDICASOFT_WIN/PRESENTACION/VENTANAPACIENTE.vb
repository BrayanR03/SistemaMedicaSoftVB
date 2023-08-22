Public Class VENTANAPACIENTE
    Private Sub cmdRegistrar_Click(sender As Object, e As EventArgs) Handles cmdRegistrar.Click
        Me.registrarPaciente()
        Me.limpiarEntradas()
    End Sub

    Public Sub limpiarEntradas()
        Me.txtapellidos.Text = ""
        Me.txtcorreo.Text = ""
        Me.txtdireccion.Text = ""
        Me.txtdni.Text = ""
        Me.txtnombres.Text = ""
        Me.txttelefono.Text = ""
        dtpfechanacimiento.Value = Date.Now
        Me.txtapellidos.Select()
        Me.MostrarId()
    End Sub

    Public Sub MostrarId()
        Dim conexionDatos As New Conexion()
        Dim pacienteDatoas As New PacienteADO()
        conexionDatos.AbrirConexion()
        txtidpaciente.Text = pacienteDatoas.MostrarId()
    End Sub

    Private Sub registrarPaciente()
        Dim paciente As CPACIENTE
        Dim pacienteDatos As New PacienteADO
        Dim serPaciente As New PacienteServicio
        Dim fecha As String = dtpfechanacimiento.Value.ToString
        Console.WriteLine(fecha)
        fecha = Format(CDate(dtpfechanacimiento.Value.ToString), "yyyy-MM-dd")
        Dim cod As String, apel As String, nomb As String, dni As String, tel As String, direccion As String, correo As String
        cod = txtidpaciente.Text.Trim
        apel = txtapellidos.Text.Trim
        nomb = txtnombres.Text.Trim
        dni = txtdni.Text.Trim
        direccion = txtdireccion.Text.Trim
        tel = txttelefono.Text.Trim
        correo = txtcorreo.Text.Trim
        paciente = New CPACIENTE(cod, apel, nomb, dni, direccion, tel, fecha, correo)
        If paciente Is Nothing Then
            MessageBox.Show("Debes llenar todos los campos", Err.Description)

        Else
            serPaciente.guardar(paciente)
        End If

    End Sub

    Private Sub VENTANAPACIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Me.Size = New Size(907, 567)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.limpiarEntradas()
    End Sub

    Private Sub txttelefono_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtdni_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtapellidos_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtapellidos.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombres_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtnombres.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


End Class
