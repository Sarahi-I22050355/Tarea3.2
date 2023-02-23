Imports System.Globalization

Public Class Form1

    Private personas As Persona()
    Public indice As Integer = 0
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Function ValidarCorreoElectronico(ByVal correoElectronico As String) As Boolean
        Return correoElectronico.Contains("@") AndAlso correoElectronico.Contains(".")
    End Function
    Private Function CalcularEdad(ByVal fechaNacimiento As DateTime) As Integer
        Dim edad As Integer = DateTime.Today.Year - fechaNacimiento.Year

        If DateTime.Today.Month < fechaNacimiento.Month OrElse (DateTime.Today.Month = fechaNacimiento.Month AndAlso DateTime.Today.Day < fechaNacimiento.Day) Then
            edad -= 1
        End If

        Return edad
    End Function
    Private Sub ActualizarTabla()
        For i As Integer = 0 To indice - 1
            Dim persona As Persona = personas(i)
            dataGridViewPersonas.Rows.Add(persona.Nombre, persona.ApellidoPaterno, persona.ApellidoMaterno, persona.FechaNacimiento.ToString("dd/MM/yyyy"), persona.Edad, persona.CorreoElectronico, persona.Telefono)
        Next
    End Sub
    Private Sub LimpiarCampos()
        textBoxNombre.Text = ""
        textBoxApellidoPaterno.Text = ""
        textBoxApellidoMaterno.Text = ""
        textBoxFechaNacimiento.Text = ""
        textBoxCorreoElectronico.Text = ""
        textBoxTelefono.Text = ""
    End Sub

    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        dataGridViewPersonas.ColumnCount = 7
        dataGridViewPersonas.Columns(0).Name = "Nombre"
        dataGridViewPersonas.Columns(1).Name = "Apellido Paterno"
        dataGridViewPersonas.Columns(2).Name = "Apellido Materno"
        dataGridViewPersonas.Columns(3).Name = "Fecha de Nacimiento"
        dataGridViewPersonas.Columns(4).Name = "Edad"
        dataGridViewPersonas.Columns(5).Name = "Correo Electrónico"
        dataGridViewPersonas.Columns(6).Name = "Telefono"
        Dim numMaxPersonas As Integer
        Dim esNumero = Integer.TryParse(textBoxNumPersonas.Text, numMaxPersonas)
        If Not esNumero Then
            MessageBox.Show("Por favor ingrese un número válido de personas a almacenar.")
            Return
        End If


        Dim numPersonas As Integer
        If Integer.TryParse(textBoxNumPersonas.Text, numPersonas) AndAlso numPersonas > 0 Then
            Me.indice = numPersonas
            personas = New Persona(numMaxPersonas - 1) {}
            indice = 0
            buttonAgregar.Enabled = True
            buttonAceptar.Enabled = False
            textBoxNumPersonas.Enabled = False
            textBoxNombre.Enabled = True
            textBoxApellidoPaterno.Enabled = True
            textBoxApellidoMaterno.Enabled = True
            textBoxFechaNacimiento.Enabled = True
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
        telefono = telefono.Replace(" ", "").Replace("-", "").Replace(".", "")
        If String.IsNullOrEmpty(telefono) OrElse telefono.Length < 10 Then
            MessageBox.Show("Por favor, ingrese un número de teléfono válido.")
            Return
        End If

        Dim fechaNacimiento As Date
        If Not Date.TryParseExact(textBoxFechaNacimiento.Text.Trim(), "dd/MM/yyyy", Nothing, DateTimeStyles.None, fechaNacimiento) Then
            MessageBox.Show("Por favor, ingrese una fecha de nacimiento válida en el formato dd/mm/yyyy.")
            Return
        End If
        Dim edad As Integer = CalcularEdad(fechaNacimiento)

        Dim correoElectronico As String = textBoxCorreoElectronico.Text.Trim()
        If Not ValidarCorreoElectronico(correoElectronico) Then
            MessageBox.Show("Por favor, ingrese una dirección de correo electrónico válida.")
            Return
        End If

        If indice >= personas.Length Then
            MessageBox.Show("No se pueden agregar más personas, se ha alcanzado el límite de almacenamiento.")
            Return
        End If

        Dim persona As Persona = New Persona(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, correoElectronico, telefono)
        personas(indice) = persona
        indice += 1

        ActualizarTabla()
        LimpiarCampos()
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        personas = New Persona(indice - 1) {}

        dataGridViewPersonas.Rows.Clear()

        textBoxNombre.Clear()
        textBoxApellidoPaterno.Clear()
        textBoxApellidoMaterno.Clear()
        textBoxFechaNacimiento.Clear()
        textBoxCorreoElectronico.Clear()
        textBoxTelefono.Clear()
        textBoxNumPersonas.Clear()
        buttonAceptar.Enabled = True
        textBoxNumPersonas.Enabled = True
    End Sub
End Class
