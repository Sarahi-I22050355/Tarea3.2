<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.buttonAceptar = New System.Windows.Forms.Button()
        Me.buttonAgregar = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.textBoxNumPersonas = New System.Windows.Forms.TextBox()
        Me.textBoxNombre = New System.Windows.Forms.TextBox()
        Me.textBoxApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.textBoxApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.textBoxFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.textBoxCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.textBoxTelefono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dataGridViewPersonas = New System.Windows.Forms.DataGridView()
        CType(Me.dataGridViewPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Location = New System.Drawing.Point(74, 28)
        Me.buttonAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(66, 25)
        Me.buttonAceptar.TabIndex = 0
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'buttonAgregar
        '
        Me.buttonAgregar.Location = New System.Drawing.Point(204, 71)
        Me.buttonAgregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(66, 26)
        Me.buttonAgregar.TabIndex = 1
        Me.buttonAgregar.Text = "Agregar"
        Me.buttonAgregar.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(204, 124)
        Me.Limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(66, 26)
        Me.Limpiar.TabIndex = 2
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'textBoxNumPersonas
        '
        Me.textBoxNumPersonas.Location = New System.Drawing.Point(13, 28)
        Me.textBoxNumPersonas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxNumPersonas.Name = "textBoxNumPersonas"
        Me.textBoxNumPersonas.Size = New System.Drawing.Size(55, 25)
        Me.textBoxNumPersonas.TabIndex = 3
        '
        'textBoxNombre
        '
        Me.textBoxNombre.Location = New System.Drawing.Point(11, 71)
        Me.textBoxNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxNombre.Name = "textBoxNombre"
        Me.textBoxNombre.Size = New System.Drawing.Size(178, 25)
        Me.textBoxNombre.TabIndex = 4
        '
        'textBoxApellidoPaterno
        '
        Me.textBoxApellidoPaterno.Location = New System.Drawing.Point(11, 124)
        Me.textBoxApellidoPaterno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxApellidoPaterno.Name = "textBoxApellidoPaterno"
        Me.textBoxApellidoPaterno.Size = New System.Drawing.Size(177, 25)
        Me.textBoxApellidoPaterno.TabIndex = 5
        '
        'textBoxApellidoMaterno
        '
        Me.textBoxApellidoMaterno.Location = New System.Drawing.Point(11, 183)
        Me.textBoxApellidoMaterno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxApellidoMaterno.Name = "textBoxApellidoMaterno"
        Me.textBoxApellidoMaterno.Size = New System.Drawing.Size(177, 25)
        Me.textBoxApellidoMaterno.TabIndex = 6
        '
        'textBoxFechaNacimiento
        '
        Me.textBoxFechaNacimiento.Location = New System.Drawing.Point(12, 245)
        Me.textBoxFechaNacimiento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxFechaNacimiento.Name = "textBoxFechaNacimiento"
        Me.textBoxFechaNacimiento.Size = New System.Drawing.Size(177, 25)
        Me.textBoxFechaNacimiento.TabIndex = 7
        '
        'textBoxCorreoElectronico
        '
        Me.textBoxCorreoElectronico.Location = New System.Drawing.Point(11, 301)
        Me.textBoxCorreoElectronico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxCorreoElectronico.Name = "textBoxCorreoElectronico"
        Me.textBoxCorreoElectronico.Size = New System.Drawing.Size(177, 25)
        Me.textBoxCorreoElectronico.TabIndex = 8
        '
        'textBoxTelefono
        '
        Me.textBoxTelefono.Location = New System.Drawing.Point(11, 358)
        Me.textBoxTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxTelefono.Name = "textBoxTelefono"
        Me.textBoxTelefono.Size = New System.Drawing.Size(177, 25)
        Me.textBoxTelefono.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Por favor ingresa el numero de personas a almacenar."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Apellido Paterno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Apellido Materno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Fecha de nacimiento (DD/MM/AAAA)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Correo electronico"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Telefono"
        '
        'dataGridViewPersonas
        '
        Me.dataGridViewPersonas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridViewPersonas.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dataGridViewPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridViewPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewPersonas.Location = New System.Drawing.Point(288, 38)
        Me.dataGridViewPersonas.Name = "dataGridViewPersonas"
        Me.dataGridViewPersonas.RowTemplate.Height = 29
        Me.dataGridViewPersonas.Size = New System.Drawing.Size(412, 333)
        Me.dataGridViewPersonas.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 431)
        Me.Controls.Add(Me.dataGridViewPersonas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textBoxTelefono)
        Me.Controls.Add(Me.textBoxCorreoElectronico)
        Me.Controls.Add(Me.textBoxFechaNacimiento)
        Me.Controls.Add(Me.textBoxApellidoMaterno)
        Me.Controls.Add(Me.textBoxApellidoPaterno)
        Me.Controls.Add(Me.textBoxNombre)
        Me.Controls.Add(Me.textBoxNumPersonas)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.buttonAgregar)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Por favor ingresa los datos solicitados."
        CType(Me.dataGridViewPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonAceptar As Button
    Friend WithEvents buttonAgregar As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents textBoxNumPersonas As TextBox
    Friend WithEvents textBoxNombre As TextBox
    Friend WithEvents textBoxApellidoPaterno As TextBox
    Friend WithEvents textBoxApellidoMaterno As TextBox
    Friend WithEvents textBoxFechaNacimiento As TextBox
    Friend WithEvents textBoxCorreoElectronico As TextBox
    Friend WithEvents textBoxTelefono As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dataGridViewPersonas As DataGridView
End Class
