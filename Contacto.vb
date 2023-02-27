Friend Class Contacto
    Inherits Persona

    Private telefono As String
    Private correo As String

    Public Property Telefono_ As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value.Replace(" ", "").Replace("-", "")
        End Set
    End Property
    Public Property Correo_ As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property
    Public Sub New()
        MyBase.New()
        Telefono_ = String.Empty
        Correo_ = String.Empty
    End Sub
    Public Sub New(ByVal nombre As String, apellidoPaterno As String, ByVal fechaNacimiento As DateTime, ByVal telefono As String, ByVal correo As String)
        MyBase.New(nombre, fechaNacimiento)
        Me.Telefono_ = telefono
        Me.Correo_ = correo
    End Sub
    Public Sub New(nombre As String, apellidoPaterno As String, apellidoMaterno As String, fechaNacimiento As Date, correo As String, telefono As String)
        MyBase.New(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, correo, telefono)
    End Sub
End Class