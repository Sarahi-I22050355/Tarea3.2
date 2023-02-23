Public Class Persona
    Public Property Nombre As String
    Public Property ApellidoPaterno As String
    Public Property ApellidoMaterno As String
    Public Property FechaNacimiento As DateTime
    Public Property CorreoElectronico As String
    Public Property Telefono As String

    Public ReadOnly Property Edad As Integer
        Get
            Return CInt(((DateTime.Now - FechaNacimiento).TotalDays / 365.25))
        End Get
    End Property

    Public Sub New(ByVal nombre As String, ByVal apellidoPaterno As String, ByVal apellidoMaterno As String, ByVal fechaNacimiento As DateTime, ByVal correoElectronico As String, ByVal telefono As String)
        Me.Nombre = nombre
        Me.ApellidoPaterno = apellidoPaterno
        Me.ApellidoMaterno = apellidoMaterno
        Me.FechaNacimiento = fechaNacimiento
        Me.CorreoElectronico = correoElectronico
        Me.Telefono = telefono
    End Sub
End Class

