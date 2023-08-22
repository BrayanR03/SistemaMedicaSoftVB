Public Class LOGIN
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim menuventana As New MENU()
        menuventana.Show()
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.limpiarEntradas()
        ''Me.Size = New Size(592, 788)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub

    Private Sub cmdIniciarSesion_Click(sender As Object, e As EventArgs) Handles cmdIniciarSesion.Click
        Me.validar()
        Me.limpiarEntradas()
    End Sub

    Public Sub limpiarEntradas()
        Me.txtusername.Text = ""
        Me.txtcontraseña.Text = ""
        Me.txtusername.Select()
    End Sub
    Public Sub validar()
        Dim usuario As String, contraseña As String
        usuario = txtusername.Text.Trim
        contraseña = txtcontraseña.Text
        Dim conexionDatos As New Conexion()
        Dim loginuser As New LoginUsuario()
        conexionDatos.AbrirConexion()
        Dim validarusuario As Boolean = loginuser.VerificarUusarioContraseña(usuario, contraseña)
        If validarusuario = True Then

            MessageBox.Show("Bienvenido")
            Me.Hide()
            Dim ventmenu As New MENU()
            ventmenu.Show()

        Else
            MessageBox.Show("Error No Son Los Datos Correctos")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class