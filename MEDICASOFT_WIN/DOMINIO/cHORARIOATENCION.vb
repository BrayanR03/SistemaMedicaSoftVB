Imports System.Runtime.InteropServices.WindowsRuntime

Public Class cHORARIOATENCION

    Private codigohorario As String
    Private estado As String
    Private fecha As String
    Private horainicio As String
    Private horafinal As String
    Private odontologo As cODONTOLOGO

    Public Sub New(ByVal codhorario As String)
        Me.codigohorario = codhorario
    End Sub
    Public Property Codigo() As String
        Get
            Return codigohorario
        End Get
        Set(ByVal codigo As String)
            Me.codigohorario = codigo
        End Set
    End Property

    Public Property EstadoHorario() As String
        Get
            Return estado
        End Get
        Set(ByVal estado As String)
            Me.estado = estado
        End Set
    End Property

    Public Property FechaHorario() As String
        Get
            Return fecha
        End Get
        Set(ByVal fecha As String)
            Me.fecha = fecha
        End Set
    End Property

    Public Property InicioHorario() As String
        Get
            Return horainicio
        End Get
        Set(ByVal horainicio As String)
            Me.horainicio = horainicio
        End Set
    End Property

    Public Property FinalHorario() As String
        Get
            Return horafinal
        End Get
        Set(ByVal horafinal As String)
            Me.horafinal = horafinal
        End Set
    End Property

    Public Property OdontologoCodigo() As cODONTOLOGO
        Get
            Return odontologo
        End Get
        Set(ByVal odontologo As cODONTOLOGO)
            Me.odontologo = odontologo
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(codigohorario As String, estado As String, fecha As String, horainicio As String, horafinal As String, odontologo As cODONTOLOGO)

        Me.codigohorario = codigohorario
        Me.estado = estado
        Me.fecha = fecha
        Me.horainicio = horainicio
        Me.horafinal = horafinal
        Me.odontologo = odontologo
    End Sub


    'REGLAS DE NEGOCIO'

    Public Function TieneHoraValida() As Boolean
        Return horainicio = "09:00" Or horafinal = "09:59" Or
               horainicio = "10:00" Or horafinal = "10:59" Or
               horainicio = "11:00" Or horafinal = "11:59" Or
               horainicio = "14:00" Or horafinal = "14:59" Or
               horainicio = "15:00" Or horafinal = "15:59" Or
               horainicio = "16:00" Or horafinal = "16:59" Or
               horainicio = "17:00" Or horafinal = "17:59" Or
               horainicio = "18:00" Or horafinal = "18:59"
    End Function

    Public Function RegistrosFechasYHoraValidos(fechabase As String, horainiciobase As String) As Boolean
        Return fecha = fechabase And horainicio IsNot horainiciobase
    End Function
End Class
