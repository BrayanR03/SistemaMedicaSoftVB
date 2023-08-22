Public Class cODONTOLOGO
    Private codigoodontologo As String
    Private apellidos As String
    Private nombres As String
    Private dni As String
    Private direccion As String
    Private telefono As String
    Private fechanacimiento As String
    Private correoelectronico As String

    Public Property Codigo() As String
        Get
            Return codigoodontologo
        End Get
        Set(ByVal codigo As String)
            Me.codigoodontologo = codigo
        End Set
    End Property

    Public Property ApellidoOdontologo() As String
        Get
            Return apellidos
        End Get
        Set(ByVal apel As String)
            Me.apellidos = apel
        End Set
    End Property

    Public Property NombreOdontologo() As String
        Get
            Return nombres
        End Get
        Set(ByVal nombres As String)
            Me.nombres = nombres
        End Set
    End Property

    Public Property DniOdontologo() As String
        Get
            Return dni
        End Get
        Set(ByVal dni As String)
            Me.dni = dni
        End Set
    End Property

    Public Property DireccionOdontologo() As String
        Get
            Return direccion
        End Get
        Set(ByVal direccion As String)
            Me.direccion = direccion
        End Set
    End Property

    Public Property TelefonoOdontologo() As String
        Get
            Return telefono
        End Get
        Set(ByVal value As String)
            Me.telefono = value
        End Set
    End Property

    Public Property FechaNacimientoOdontologo() As String
        Get
            Return fechanacimiento
        End Get
        Set(ByVal value As String)
            Me.fechanacimiento = value
        End Set
    End Property

    Public Property Correo() As String
        Get
            Return correoelectronico
        End Get
        Set(ByVal value As String)
            Me.correoelectronico = value
        End Set
    End Property
    Public Sub New(ByVal codigo As String, ByVal apellidos As String, ByVal nombres As String, ByVal dni As String, ByVal direccion As String, ByVal telefono As String, ByVal fechanacimiento As String, ByVal correo As String)
        Me.codigoodontologo = codigo
        Me.apellidos = apellidos
        Me.nombres = nombres
        Me.dni = dni
        Me.direccion = direccion
        Me.telefono = telefono
        Me.fechanacimiento = fechanacimiento
        Me.correoelectronico = correo
    End Sub
    Public Sub New(ByVal codigo As String)
        Me.codigoodontologo = codigo
    End Sub
    Public Sub New()

    End Sub
End Class
