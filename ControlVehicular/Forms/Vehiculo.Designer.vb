<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehiculo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGVVehiculo = New System.Windows.Forms.DataGridView()
        Me.idPlacasve = New System.Windows.Forms.TextBox()
        Me.lbPlacas = New System.Windows.Forms.Label()
        Me.lbFactura = New System.Windows.Forms.Label()
        Me.lbPasajeros = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.fechaFactura = New System.Windows.Forms.TextBox()
        Me.importedefactura = New System.Windows.Forms.TextBox()
        Me.idempleado = New System.Windows.Forms.TextBox()
        Me.Pasajeros = New System.Windows.Forms.TextBox()
        Me.Factura = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.combustible = New System.Windows.Forms.TextBox()
        Me.color = New System.Windows.Forms.TextBox()
        Me.marca = New System.Windows.Forms.TextBox()
        Me.tipovehiculo = New System.Windows.Forms.TextBox()
        Me.idpropietario = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Particular = New System.Windows.Forms.CheckBox()
        Me.Comercial = New System.Windows.Forms.CheckBox()
        CType(Me.DGVVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVVehiculo
        '
        Me.DGVVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVehiculo.Location = New System.Drawing.Point(21, 53)
        Me.DGVVehiculo.Name = "DGVVehiculo"
        Me.DGVVehiculo.Size = New System.Drawing.Size(442, 323)
        Me.DGVVehiculo.TabIndex = 150
        '
        'idPlacasve
        '
        Me.idPlacasve.Location = New System.Drawing.Point(775, 50)
        Me.idPlacasve.Name = "idPlacasve"
        Me.idPlacasve.Size = New System.Drawing.Size(84, 20)
        Me.idPlacasve.TabIndex = 149
        '
        'lbPlacas
        '
        Me.lbPlacas.AutoSize = True
        Me.lbPlacas.Location = New System.Drawing.Point(723, 53)
        Me.lbPlacas.Name = "lbPlacas"
        Me.lbPlacas.Size = New System.Drawing.Size(39, 13)
        Me.lbPlacas.TabIndex = 148
        Me.lbPlacas.Text = "Placas"
        '
        'lbFactura
        '
        Me.lbFactura.AutoSize = True
        Me.lbFactura.Location = New System.Drawing.Point(723, 139)
        Me.lbFactura.Name = "lbFactura"
        Me.lbFactura.Size = New System.Drawing.Size(54, 13)
        Me.lbFactura.TabIndex = 147
        Me.lbFactura.Text = "N.Factura"
        '
        'lbPasajeros
        '
        Me.lbPasajeros.AutoSize = True
        Me.lbPasajeros.Location = New System.Drawing.Point(723, 96)
        Me.lbPasajeros.Name = "lbPasajeros"
        Me.lbPasajeros.Size = New System.Drawing.Size(53, 13)
        Me.lbPasajeros.TabIndex = 146
        Me.lbPasajeros.Text = "Pasajeros"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(714, 228)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(81, 13)
        Me.label4.TabIndex = 145
        Me.label4.Text = "Importe Factura"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(714, 179)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(76, 13)
        Me.label3.TabIndex = 144
        Me.label3.Text = "Fecha Factura"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(721, 301)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(54, 13)
        Me.label2.TabIndex = 143
        Me.label2.Text = "Empleado"
        '
        'fechaFactura
        '
        Me.fechaFactura.Location = New System.Drawing.Point(775, 194)
        Me.fechaFactura.Name = "fechaFactura"
        Me.fechaFactura.Size = New System.Drawing.Size(144, 20)
        Me.fechaFactura.TabIndex = 142
        '
        'importedefactura
        '
        Me.importedefactura.Location = New System.Drawing.Point(775, 244)
        Me.importedefactura.Name = "importedefactura"
        Me.importedefactura.Size = New System.Drawing.Size(144, 20)
        Me.importedefactura.TabIndex = 141
        '
        'idempleado
        '
        Me.idempleado.Location = New System.Drawing.Point(775, 294)
        Me.idempleado.Name = "idempleado"
        Me.idempleado.Size = New System.Drawing.Size(144, 20)
        Me.idempleado.TabIndex = 140
        '
        'Pasajeros
        '
        Me.Pasajeros.Location = New System.Drawing.Point(775, 93)
        Me.Pasajeros.Name = "Pasajeros"
        Me.Pasajeros.Size = New System.Drawing.Size(144, 20)
        Me.Pasajeros.TabIndex = 139
        '
        'Factura
        '
        Me.Factura.Location = New System.Drawing.Point(775, 136)
        Me.Factura.Name = "Factura"
        Me.Factura.Size = New System.Drawing.Size(144, 20)
        Me.Factura.TabIndex = 138
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(484, 264)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(88, 13)
        Me.label11.TabIndex = 137
        Me.label11.Text = "Tipo Combustible"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(496, 112)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(53, 13)
        Me.label10.TabIndex = 136
        Me.label10.Text = "Tipo Auto"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(484, 165)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(62, 13)
        Me.label9.TabIndex = 135
        Me.label9.Text = "Marca Auto"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(489, 221)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(56, 13)
        Me.label6.TabIndex = 134
        Me.label6.Text = "Color Auto"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(489, 70)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(57, 13)
        Me.label7.TabIndex = 133
        Me.label7.Text = "Propietario"
        '
        'combustible
        '
        Me.combustible.Location = New System.Drawing.Point(552, 280)
        Me.combustible.Name = "combustible"
        Me.combustible.Size = New System.Drawing.Size(144, 20)
        Me.combustible.TabIndex = 132
        '
        'color
        '
        Me.color.Location = New System.Drawing.Point(552, 218)
        Me.color.Name = "color"
        Me.color.Size = New System.Drawing.Size(144, 20)
        Me.color.TabIndex = 131
        '
        'marca
        '
        Me.marca.Location = New System.Drawing.Point(552, 162)
        Me.marca.Name = "marca"
        Me.marca.Size = New System.Drawing.Size(144, 20)
        Me.marca.TabIndex = 130
        '
        'tipovehiculo
        '
        Me.tipovehiculo.Location = New System.Drawing.Point(552, 105)
        Me.tipovehiculo.Name = "tipovehiculo"
        Me.tipovehiculo.Size = New System.Drawing.Size(144, 20)
        Me.tipovehiculo.TabIndex = 129
        '
        'idpropietario
        '
        Me.idpropietario.Location = New System.Drawing.Point(552, 63)
        Me.idpropietario.Name = "idpropietario"
        Me.idpropietario.Size = New System.Drawing.Size(144, 20)
        Me.idpropietario.TabIndex = 128
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(644, 385)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 26)
        Me.button1.TabIndex = 127
        Me.button1.Text = "Borrar"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(539, 385)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Agregar.TabIndex = 126
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(738, 385)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 125
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(726, 339)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "Tipo Vehiculo"
        '
        'Particular
        '
        Me.Particular.AutoSize = True
        Me.Particular.Location = New System.Drawing.Point(882, 339)
        Me.Particular.Name = "Particular"
        Me.Particular.Size = New System.Drawing.Size(70, 17)
        Me.Particular.TabIndex = 123
        Me.Particular.Text = "Particular"
        Me.Particular.UseVisualStyleBackColor = True
        '
        'Comercial
        '
        Me.Comercial.AutoSize = True
        Me.Comercial.Location = New System.Drawing.Point(804, 339)
        Me.Comercial.Name = "Comercial"
        Me.Comercial.Size = New System.Drawing.Size(72, 17)
        Me.Comercial.TabIndex = 122
        Me.Comercial.Text = "Comercial"
        Me.Comercial.UseVisualStyleBackColor = True
        '
        'Vehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 450)
        Me.Controls.Add(Me.DGVVehiculo)
        Me.Controls.Add(Me.idPlacasve)
        Me.Controls.Add(Me.lbPlacas)
        Me.Controls.Add(Me.lbFactura)
        Me.Controls.Add(Me.lbPasajeros)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.fechaFactura)
        Me.Controls.Add(Me.importedefactura)
        Me.Controls.Add(Me.idempleado)
        Me.Controls.Add(Me.Pasajeros)
        Me.Controls.Add(Me.Factura)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.combustible)
        Me.Controls.Add(Me.color)
        Me.Controls.Add(Me.marca)
        Me.Controls.Add(Me.tipovehiculo)
        Me.Controls.Add(Me.idpropietario)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Particular)
        Me.Controls.Add(Me.Comercial)
        Me.Name = "Vehiculo"
        Me.Text = "Vehiculo"
        CType(Me.DGVVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents DGVVehiculo As DataGridView
    Friend WithEvents idPlacasve As TextBox
    Friend WithEvents lbPlacas As Label
    Friend WithEvents lbFactura As Label
    Friend WithEvents lbPasajeros As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents fechaFactura As TextBox
    Friend WithEvents importedefactura As TextBox
    Friend WithEvents idempleado As TextBox
    Friend WithEvents Pasajeros As TextBox
    Friend WithEvents Factura As TextBox
    Friend WithEvents label11 As Label
    Friend WithEvents label10 As Label
    Friend WithEvents label9 As Label
    Friend WithEvents label6 As Label
    Friend WithEvents label7 As Label
    Friend WithEvents combustible As TextBox
    Friend WithEvents color As TextBox
    Friend WithEvents marca As TextBox
    Friend WithEvents tipovehiculo As TextBox
    Friend WithEvents idpropietario As TextBox
    Friend WithEvents button1 As Button
    Friend WithEvents Agregar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Particular As CheckBox
    Friend WithEvents Comercial As CheckBox
End Class
