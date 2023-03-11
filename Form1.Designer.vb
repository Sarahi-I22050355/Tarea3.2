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
        Me.textBoxNombre = New System.Windows.Forms.TextBox()
        Me.textBoxApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.textBoxApellidoMaterno = New System.Windows.Forms.TextBox()
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
        Me.nudNumPersonas = New System.Windows.Forms.NumericUpDown()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGridViewPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Location = New System.Drawing.Point(195, 33)
        Me.buttonAceptar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(85, 28)
        Me.buttonAceptar.TabIndex = 2
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'buttonAgregar
        '
        Me.buttonAgregar.Location = New System.Drawing.Point(244, 364)
        Me.buttonAgregar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(85, 29)
        Me.buttonAgregar.TabIndex = 9
        Me.buttonAgregar.Text = "Agregar"
        Me.buttonAgregar.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(28, 364)
        Me.Limpiar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(85, 29)
        Me.Limpiar.TabIndex = 11
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'textBoxNombre
        '
        Me.textBoxNombre.Location = New System.Drawing.Point(165, 90)
        Me.textBoxNombre.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.textBoxNombre.Name = "textBoxNombre"
        Me.textBoxNombre.Size = New System.Drawing.Size(163, 27)
        Me.textBoxNombre.TabIndex = 3
        '
        'textBoxApellidoPaterno
        '
        Me.textBoxApellidoPaterno.Location = New System.Drawing.Point(166, 137)
        Me.textBoxApellidoPaterno.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.textBoxApellidoPaterno.Name = "textBoxApellidoPaterno"
        Me.textBoxApellidoPaterno.Size = New System.Drawing.Size(163, 27)
        Me.textBoxApellidoPaterno.TabIndex = 4
        '
        'textBoxApellidoMaterno
        '
        Me.textBoxApellidoMaterno.Location = New System.Drawing.Point(165, 184)
        Me.textBoxApellidoMaterno.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.textBoxApellidoMaterno.Name = "textBoxApellidoMaterno"
        Me.textBoxApellidoMaterno.Size = New System.Drawing.Size(163, 27)
        Me.textBoxApellidoMaterno.TabIndex = 5
        '
        'textBoxCorreoElectronico
        '
        Me.textBoxCorreoElectronico.Location = New System.Drawing.Point(166, 274)
        Me.textBoxCorreoElectronico.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.textBoxCorreoElectronico.Name = "textBoxCorreoElectronico"
        Me.textBoxCorreoElectronico.Size = New System.Drawing.Size(163, 27)
        Me.textBoxCorreoElectronico.TabIndex = 7
        '
        'textBoxTelefono
        '
        Me.textBoxTelefono.Location = New System.Drawing.Point(166, 316)
        Me.textBoxTelefono.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.textBoxTelefono.Name = "textBoxTelefono"
        Me.textBoxTelefono.Size = New System.Drawing.Size(163, 27)
        Me.textBoxTelefono.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Por favor ingresa el numero de personas a almacenar."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 192)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Apellido Materno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 241)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Fecha de nacimiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 277)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Correo Electronico:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(83, 324)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Telefono:"
        '
        'dataGridViewPersonas
        '
        Me.dataGridViewPersonas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridViewPersonas.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dataGridViewPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridViewPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewPersonas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column7, Me.Column6, Me.Column5})
        Me.dataGridViewPersonas.Location = New System.Drawing.Point(337, 34)
        Me.dataGridViewPersonas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dataGridViewPersonas.Name = "dataGridViewPersonas"
        Me.dataGridViewPersonas.RowTemplate.Height = 29
        Me.dataGridViewPersonas.Size = New System.Drawing.Size(443, 372)
        Me.dataGridViewPersonas.TabIndex = 10
        '
        'nudNumPersonas
        '
        Me.nudNumPersonas.Location = New System.Drawing.Point(113, 34)
        Me.nudNumPersonas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nudNumPersonas.Name = "nudNumPersonas"
        Me.nudNumPersonas.Size = New System.Drawing.Size(65, 27)
        Me.nudNumPersonas.TabIndex = 18
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(166, 233)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(162, 27)
        Me.dtpFechaNacimiento.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Apellido Paterno"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Apellido Materno"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fecha de Nacimiento"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Edad"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Correo Electronico"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Telefono"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 427)
        Me.Controls.Add(Me.dtpFechaNacimiento)
        Me.Controls.Add(Me.nudNumPersonas)
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
        Me.Controls.Add(Me.textBoxApellidoMaterno)
        Me.Controls.Add(Me.textBoxApellidoPaterno)
        Me.Controls.Add(Me.textBoxNombre)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.buttonAgregar)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "Form1"
        Me.Text = "Por favor ingresa los datos solicitados."
        CType(Me.dataGridViewPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonAceptar As Button
    Friend WithEvents buttonAgregar As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents textBoxNombre As TextBox
    Friend WithEvents textBoxApellidoPaterno As TextBox
    Friend WithEvents textBoxApellidoMaterno As TextBox
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
    Friend WithEvents nudNumPersonas As NumericUpDown
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
