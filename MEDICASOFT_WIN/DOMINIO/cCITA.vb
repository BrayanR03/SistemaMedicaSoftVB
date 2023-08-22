Public Class cCITA

    Private idCita As Integer
    Private montototal As Double
    Private horario As cHORARIOATENCION
    Private paciente As CPACIENTE

    Public Property CitaID() As Integer
        Get
            Return idCita
        End Get
        Set(value As Integer)
            Me.idCita = value
        End Set
    End Property

    Public Property MontoCita() As Double
        Get
            Return montototal
        End Get
        Set(value As Double)
            Me.montototal = value
        End Set
    End Property

    Public Property oHorario() As cHORARIOATENCION
        Get
            Return horario
        End Get
        Set(value As cHORARIOATENCION)
            Me.horario = value
        End Set
    End Property

    Public Property oPaciente() As CPACIENTE
        Get
            Return paciente
        End Get
        Set(value As CPACIENTE)
            Me.paciente = value
        End Set
    End Property

    Public Sub New(ByVal idcita As Integer, ByVal monto As Double, ByVal horario As cHORARIOATENCION, ByVal paciente As CPACIENTE)
        Me.idCita = idcita
        Me.montototal = monto
        Me.horario = horario
        Me.paciente = paciente

    End Sub

    Public Function MontoValido() As Boolean
        Return montototal = 20
    End Function

    Public Function PermitirNuevaCita(totalcitas As Integer) As Boolean
        Return totalcitas < 7
    End Function
End Class
