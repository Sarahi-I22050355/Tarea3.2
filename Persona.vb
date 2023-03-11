Public Class Persona
    Private nombre As String
    Private apellidoPaterno As String
    Private apellidoMaterno As String
    Private fechaNacimiento As DateTime
    Public Property Nombre_ As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value.ToUpper()
        End Set
    End Property
    Public Property ApellidoPaterno_ As String
        Get
            Return apellidoPaterno
        End Get
        Set(value As String)
            apellidoPaterno = value.ToUpper()
        End Set
    End Property
    Public Property ApellidoMaterno_ As String
        Get
            Return apellidoMaterno
        End Get
        Set(value As String)
            apellidoMaterno = value.ToUpper()
        End Set
    End Property
    Public Property FechaNacimiento_ As DateTime
        Get
            Return fechaNacimiento
        End Get
        Set(value As DateTime)
            fechaNacimiento = value
        End Set
    End Property
    Public ReadOnly Property Edad As Integer
        Get
            Return CInt((DateTime.Now - FechaNacimiento_).TotalDays / 365.25)
        End Get
    End Property
    Public Sub New()
        nombre = String.Empty
        apellidoPaterno = String.Empty
        apellidoMaterno = String.Empty
        fechaNacimiento = Nothing
    End Sub
    Public Sub New(ByVal nombre As String, ByVal apellidoPaterno As String, ByVal apellidoMaterno As String, ByVal fechaNacimiento As DateTime)
        Me.Nombre_ = nombre
        Me.ApellidoPaterno_ = apellidoPaterno
        Me.ApellidoMaterno_ = apellidoMaterno
        Me.FechaNacimiento_ = fechaNacimiento
    End Sub
    Public Overrides Function ToString() As String
        Return nombre & " " & apellidoPaterno & " " & apellidoMaterno & " " & fechaNacimiento.ToString("dd/MM/yyyy") & " " & Edad
    End Function
End Class

