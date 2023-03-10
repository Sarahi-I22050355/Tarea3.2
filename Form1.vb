Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class Form1
    Dim contactos As Contacto()
    Dim indice As Integer = 0
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub ActualizarTabla()
        dataGridViewPersonas.Rows.Clear()
        For i As Integer = 0 To indice - 1
            Dim celdas() As String = contactos(i).ToString().Split(" "c)
            dataGridViewPersonas.Rows.Add(celdas(0), celdas(1), celdas(2), celdas(3), celdas(4), celdas(5), celdas(6))
        Next
    End Sub
    ''' <summary>
    ''' validacion para el correo
    ''' </summary>
    ''' <param name="email"></param>
    ''' <returns></returns>
    Public Shared Function Valido(ByVal email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then Return False

        Try
            Return Regex.IsMatch(email, "^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))
        Catch __unusedRegexMatchTimeoutException1__ As RegexMatchTimeoutException
            Return False
        End Try
    End Function

    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        Dim numMaxPersonas As Integer
        Dim esNumero As Boolean = Integer.TryParse(nudNumPersonas.Text, numMaxPersonas)

        If Not esNumero Then
            MessageBox.Show("Por favor ingrese un número válido de personas a almacenar.")
            Return
        End If

        Dim numPersonas As Integer = Nothing

        If Integer.TryParse(nudNumPersonas.Text, numPersonas) AndAlso numPersonas > 0 Then
            Me.indice = numPersonas
            contactos = New Contacto(numMaxPersonas - 1) {}
            indice = 0
            buttonAgregar.Enabled = True
            buttonAceptar.Enabled = False
            nudNumPersonas.Enabled = False
            textBoxNombre.Enabled = True
            textBoxApellidoPaterno.Enabled = True
            textBoxApellidoMaterno.Enabled = True
            dtpFechaNacimiento.Enabled = True
            textBoxCorreoElectronico.Enabled = True
        Else
            MessageBox.Show("Por favor, ingrese un número de personas válido mayor a cero.")
        End If

    End Sub

    Private Sub buttonAgregar_Click(sender As Object, e As EventArgs) Handles buttonAgregar.Click
        Dim nombre As String = textBoxNombre.Text.Trim().ToUpper()
        Dim apellidoPaterno As String = textBoxApellidoPaterno.Text.Trim().ToUpper()
        Dim apellidoMaterno As String = textBoxApellidoMaterno.Text.Trim().ToUpper()

        If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(apellidoPaterno) OrElse String.IsNullOrEmpty(apellidoMaterno) Then
            MessageBox.Show("Por favor, ingrese los datos completos de la persona.")
            Return
        End If
        Dim telefono As String = textBoxTelefono.Text.Trim()

        If String.IsNullOrEmpty(telefono) OrElse telefono.Length < 10 Then
            MessageBox.Show("Por favor, ingrese un número de teléfono válido.")
            Return
        End If

        If Not Valido(textBoxCorreoElectronico.Text) Then
            MessageBox.Show("El correo electrónico ingresado no es válido, por favor inténtalo nuevamente.")
            Return
        End If

        If indice = contactos.Length Then
            MessageBox.Show("No se pueden agregar más personas, se ha alcanzado el límite de almacenamiento.")
            Return
        End If
        Dim fechaNacimiento As Date = dtpFechaNacimiento.Value
        Dim correo As String = textBoxCorreoElectronico.Text
        Dim nuevoContacto As Contacto = New Contacto(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, correo, telefono)
        contactos(indice) = nuevoContacto
        indice += 1
        ActualizarTabla()
        textBoxNombre.Clear()
        textBoxApellidoPaterno.Clear()
        textBoxApellidoMaterno.Clear()
        textBoxCorreoElectronico.Clear()
        textBoxTelefono.Clear()
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        contactos = New Contacto(indice - 1) {}
        dataGridViewPersonas.Rows.Clear()
        buttonAceptar.Enabled = True
        nudNumPersonas.Value = 0
        nudNumPersonas.Enabled = True
        textBoxNombre.Clear()
        textBoxApellidoPaterno.Clear()
        textBoxApellidoMaterno.Clear()
        textBoxCorreoElectronico.Clear()
        textBoxTelefono.Clear()
    End Sub
End Class
