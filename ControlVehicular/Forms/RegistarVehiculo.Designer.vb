<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistarVehiculo
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
        Me.color = New System.Windows.Forms.TextBox()
        Me.idpropietario = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Particular = New System.Windows.Forms.CheckBox()
        Me.Comercial = New System.Windows.Forms.CheckBox()
        Me.Marca = New System.Windows.Forms.ComboBox()
        Me.tipovehiculo = New System.Windows.Forms.ComboBox()
        Me.combustible = New System.Windows.Forms.ComboBox()
        Me.SERIE = New System.Windows.Forms.TextBox()
        Me.serie1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'idPlacasve
        '
        Me.idPlacasve.Location = New System.Drawing.Point(407, 36)
        Me.idPlacasve.MaxLength = 7
        Me.idPlacasve.Name = "idPlacasve"
        Me.idPlacasve.Size = New System.Drawing.Size(84, 20)
        Me.idPlacasve.TabIndex = 149
        '
        'lbPlacas
        '
        Me.lbPlacas.AutoSize = True
        Me.lbPlacas.Location = New System.Drawing.Point(355, 39)
        Me.lbPlacas.Name = "lbPlacas"
        Me.lbPlacas.Size = New System.Drawing.Size(39, 13)
        Me.lbPlacas.TabIndex = 148
        Me.lbPlacas.Text = "Placas"
        '
        'lbFactura
        '
        Me.lbFactura.AutoSize = True
        Me.lbFactura.Location = New System.Drawing.Point(355, 125)
        Me.lbFactura.Name = "lbFactura"
        Me.lbFactura.Size = New System.Drawing.Size(54, 13)
        Me.lbFactura.TabIndex = 147
        Me.lbFactura.Text = "N.Factura"
        '
        'lbPasajeros
        '
        Me.lbPasajeros.AutoSize = True
        Me.lbPasajeros.Location = New System.Drawing.Point(355, 82)
        Me.lbPasajeros.Name = "lbPasajeros"
        Me.lbPasajeros.Size = New System.Drawing.Size(53, 13)
        Me.lbPasajeros.TabIndex = 146
        Me.lbPasajeros.Text = "Pasajeros"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(346, 214)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(81, 13)
        Me.label4.TabIndex = 145
        Me.label4.Text = "Importe Factura"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(346, 165)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(76, 13)
        Me.label3.TabIndex = 144
        Me.label3.Text = "Fecha Factura"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(353, 287)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(54, 13)
        Me.label2.TabIndex = 143
        Me.label2.Text = "Empleado"
        '
        'fechaFactura
        '
        Me.fechaFactura.Location = New System.Drawing.Point(407, 181)
        Me.fechaFactura.Name = "fechaFactura"
        Me.fechaFactura.Size = New System.Drawing.Size(144, 20)
        Me.fechaFactura.TabIndex = 142
        '
        'importedefactura
        '
        Me.importedefactura.Location = New System.Drawing.Point(407, 230)
        Me.importedefactura.MaxLength = 8
        Me.importedefactura.Name = "importedefactura"
        Me.importedefactura.Size = New System.Drawing.Size(144, 20)
        Me.importedefactura.TabIndex = 141
        '
        'idempleado
        '
        Me.idempleado.Location = New System.Drawing.Point(407, 280)
        Me.idempleado.Name = "idempleado"
        Me.idempleado.Size = New System.Drawing.Size(144, 20)
        Me.idempleado.TabIndex = 140
        '
        'Pasajeros
        '
        Me.Pasajeros.Location = New System.Drawing.Point(407, 79)
        Me.Pasajeros.Name = "Pasajeros"
        Me.Pasajeros.Size = New System.Drawing.Size(144, 20)
        Me.Pasajeros.TabIndex = 139
        '
        'Factura
        '
        Me.Factura.Location = New System.Drawing.Point(407, 122)
        Me.Factura.Name = "Factura"
        Me.Factura.Size = New System.Drawing.Size(144, 20)
        Me.Factura.TabIndex = 138
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(64, 228)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(88, 13)
        Me.label11.TabIndex = 137
        Me.label11.Text = "Tipo Combustible"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(83, 100)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(53, 13)
        Me.label10.TabIndex = 136
        Me.label10.Text = "Tipo Auto"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(74, 143)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(62, 13)
        Me.label9.TabIndex = 135
        Me.label9.Text = "Marca Auto"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(74, 194)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(56, 13)
        Me.label6.TabIndex = 134
        Me.label6.Text = "Color Auto"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(83, 57)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(57, 13)
        Me.label7.TabIndex = 133
        Me.label7.Text = "Propietario"
        '
        'color
        '
        Me.color.Location = New System.Drawing.Point(136, 187)
        Me.color.Name = "color"
        Me.color.Size = New System.Drawing.Size(144, 20)
        Me.color.TabIndex = 131
        '
        'idpropietario
        '
        Me.idpropietario.Location = New System.Drawing.Point(146, 57)
        Me.idpropietario.Name = "idpropietario"
        Me.idpropietario.Size = New System.Drawing.Size(144, 20)
        Me.idpropietario.TabIndex = 128
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(380, 331)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 26)
        Me.button1.TabIndex = 127
        Me.button1.Text = "Borrar"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(282, 333)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Agregar.TabIndex = 126
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(485, 331)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 125
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(80, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "Tipo Vehiculo"
        '
        'Particular
        '
        Me.Particular.AutoSize = True
        Me.Particular.Location = New System.Drawing.Point(236, 280)
        Me.Particular.Name = "Particular"
        Me.Particular.Size = New System.Drawing.Size(70, 17)
        Me.Particular.TabIndex = 123
        Me.Particular.Text = "Particular"
        Me.Particular.UseVisualStyleBackColor = True
        '
        'Comercial
        '
        Me.Comercial.AutoSize = True
        Me.Comercial.Location = New System.Drawing.Point(158, 280)
        Me.Comercial.Name = "Comercial"
        Me.Comercial.Size = New System.Drawing.Size(72, 17)
        Me.Comercial.TabIndex = 122
        Me.Comercial.Text = "Comercial"
        Me.Comercial.UseVisualStyleBackColor = True
        '
        'Marca
        '
        Me.Marca.FormattingEnabled = True
        Me.Marca.Location = New System.Drawing.Point(142, 143)
        Me.Marca.Name = "Marca"
        Me.Marca.Size = New System.Drawing.Size(121, 21)
        Me.Marca.TabIndex = 151
        '
        'tipovehiculo
        '
        Me.tipovehiculo.FormattingEnabled = True
        Me.tipovehiculo.Location = New System.Drawing.Point(142, 100)
        Me.tipovehiculo.Name = "tipovehiculo"
        Me.tipovehiculo.Size = New System.Drawing.Size(121, 21)
        Me.tipovehiculo.TabIndex = 152
        '
        'combustible
        '
        Me.combustible.FormattingEnabled = True
        Me.combustible.Location = New System.Drawing.Point(158, 225)
        Me.combustible.Name = "combustible"
        Me.combustible.Size = New System.Drawing.Size(121, 21)
        Me.combustible.TabIndex = 153
        '
        'SERIE
        '
        Me.SERIE.Location = New System.Drawing.Point(142, 21)
        Me.SERIE.MaxLength = 8
        Me.SERIE.Name = "SERIE"
        Me.SERIE.Size = New System.Drawing.Size(144, 20)
        Me.SERIE.TabIndex = 154
        '
        'serie1
        '
        Me.serie1.AutoSize = True
        Me.serie1.Location = New System.Drawing.Point(72, 24)
        Me.serie1.Name = "serie1"
        Me.serie1.Size = New System.Drawing.Size(64, 13)
        Me.serie1.TabIndex = 155
        Me.serie1.Text = "N.SerieAuto"
        '
        'RegistarVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 375)
        Me.Controls.Add(Me.serie1)
        Me.Controls.Add(Me.SERIE)
        Me.Controls.Add(Me.combustible)
        Me.Controls.Add(Me.tipovehiculo)
        Me.Controls.Add(Me.Marca)
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
        Me.Controls.Add(Me.color)
        Me.Controls.Add(Me.idpropietario)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Particular)
        Me.Controls.Add(Me.Comercial)
        Me.Name = "RegistarVehiculo"
        Me.Text = "Vehiculo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents color As TextBox
    Friend WithEvents idpropietario As TextBox
    Friend WithEvents button1 As Button
    Friend WithEvents Agregar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Particular As CheckBox
    Friend WithEvents Comercial As CheckBox
    Friend WithEvents Marca As ComboBox
    Friend WithEvents tipovehiculo As ComboBox
    Friend WithEvents combustible As ComboBox
    Friend WithEvents SERIE As TextBox
    Friend WithEvents serie1 As Label
End Class
