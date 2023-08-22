Public Class CPACIENTE
    Private codigopaciente As String
    Private apellidos As String
    Private nombres As String
    Private dni As String
    Private direccion As String
    Private telefono As String
    Private fechanacimiento As String
    Private correoelectronico As String

    Public Property Codigo() As String

        Get
            Return codigopaciente
        End Get
        Set(ByVal codigopaciente As String)
            Me.codigopaciente = codigopaciente
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return apellidos
        End Get
        Set(ByVal apellidos As String)
            Me.apellidos = apellidos
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return nombres
        End Get
        Set(ByVal nombres As String)
            Me.nombres = nombres
        End Set
    End Property

    Public Property DniPaciente() As String
        Get
            Return dni
        End Get
        Set(ByVal dni As String)
            Me.dni = dni
        End Set
    End Property

    Public Property DireccionPaciente() As String
        Get
            Return direccion
        End Get
        Set(ByVal direccion As String)
            Me.direccion = direccion
        End Set
    End Property

    Public Property TelefonoPaciente() As String
        Get
            Return telefono
        End Get
        Set(ByVal telefono As String)
            Me.telefono = telefono
        End Set
    End Property

    Public Property FechaNacimientoPaciente() As String
        Get
            Return fechanacimiento
        End Get
        Set(ByVal fechanacimiento As String)
            Me.fechanacimiento = fechanacimiento
        End Set
    End Property

    Public Property Correo() As String
        Get
            Return correoelectronico
        End Get
        Set(ByVal correoelectronico As String)
            Me.correoelectronico = correoelectronico
        End Set
    End Property

    Public Sub New(ByVal codigopaciente As String, ByVal apellidos As String, ByVal nombres As String, ByVal dni As String, ByVal direccion As String, ByVal telefono As String, ByVal fechanacimiento As String, ByVal correoelectronico As String)

        Me.codigopaciente = codigopaciente
        Me.apellidos = apellidos
        Me.nombres = nombres
        Me.dni = dni
        Me.direccion = direccion
        Me.telefono = telefono
        Me.fechanacimiento = fechanacimiento
        Me.correoelectronico = correoelectronico
    End Sub
    Public Sub New()

    End Sub
    Public Sub New(ByVal codigo As String)
        Me.codigopaciente = codigo
    End Sub


    'REGLAS DE NEGOCIO'

    Public Function TieneEdadValida() As Boolean
        Dim AñoActual As Integer
        AñoActual = Date.Now.Year
        Dim añoString As String = Mid(fechanacimiento, 1, 4)
        Dim edad As Integer = AñoActual - Int(añoString)
        Return edad >= 7
    End Function

End Class
