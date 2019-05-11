<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroMultas
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
        Me.DGVMulta = New System.Windows.Forms.DataGridView()
        Me.labfechaLiquidcion = New System.Windows.Forms.Label()
        Me.fechaLiquidacionMuta = New System.Windows.Forms.TextBox()
        Me.Materno1 = New System.Windows.Forms.Label()
        Me.Materno = New System.Windows.Forms.TextBox()
        Me.Paterno1 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.TienLicencia = New System.Windows.Forms.Label()
        Me.Motivo = New System.Windows.Forms.Label()
        Me.EstatusMul = New System.Windows.Forms.Label()
        Me.MotoPagar = New System.Windows.Forms.Label()
        Me.Placas1 = New System.Windows.Forms.Label()
        Me.NOMBRE2 = New System.Windows.Forms.Label()
        Me.labFechaExpedicion = New System.Windows.Forms.Label()
        Me.Folio = New System.Windows.Forms.Label()
        Me.No = New System.Windows.Forms.CheckBox()
        Me.Si = New System.Windows.Forms.CheckBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Estatus = New System.Windows.Forms.TextBox()
        Me.importe = New System.Windows.Forms.TextBox()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.idPlacas = New System.Windows.Forms.TextBox()
        Me.Paterno = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.fechaExpedicion = New System.Windows.Forms.TextBox()
        Me.idMulta = New System.Windows.Forms.TextBox()
        CType(Me.DGVMulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVMulta
        '
        Me.DGVMulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMulta.Location = New System.Drawing.Point(6, 58)
        Me.DGVMulta.Name = "DGVMulta"
        Me.DGVMulta.Size = New System.Drawing.Size(466, 298)
        Me.DGVMulta.TabIndex = 130
        '
        'labfechaLiquidcion
        '
        Me.labfechaLiquidcion.AutoSize = True
        Me.labfechaLiquidcion.Location = New System.Drawing.Point(701, 339)
        Me.labfechaLiquidcion.Name = "labfechaLiquidcion"
        Me.labfechaLiquidcion.Size = New System.Drawing.Size(94, 13)
        Me.labfechaLiquidcion.TabIndex = 129
        Me.labfechaLiquidcion.Text = "Fecha Liquidacion"
        '
        'fechaLiquidacionMuta
        '
        Me.fechaLiquidacionMuta.Location = New System.Drawing.Point(801, 336)
        Me.fechaLiquidacionMuta.Name = "fechaLiquidacionMuta"
        Me.fechaLiquidacionMuta.Size = New System.Drawing.Size(103, 20)
        Me.fechaLiquidacionMuta.TabIndex = 128
        '
        'Materno1
        '
        Me.Materno1.AutoSize = True
        Me.Materno1.Location = New System.Drawing.Point(647, 151)
        Me.Materno1.Name = "Materno1"
        Me.Materno1.Size = New System.Drawing.Size(46, 13)
        Me.Materno1.TabIndex = 127
        Me.Materno1.Text = "Materno"
        '
        'Materno
        '
        Me.Materno.Location = New System.Drawing.Point(697, 148)
        Me.Materno.Name = "Materno"
        Me.Materno.Size = New System.Drawing.Size(103, 20)
        Me.Materno.TabIndex = 126
        '
        'Paterno1
        '
        Me.Paterno1.AutoSize = True
        Me.Paterno1.Location = New System.Drawing.Point(652, 109)
        Me.Paterno1.Name = "Paterno1"
        Me.Paterno1.Size = New System.Drawing.Size(44, 13)
        Me.Paterno1.TabIndex = 125
        Me.Paterno1.Text = "Paterno"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(845, 384)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 124
        Me.button2.Text = "Cancelar"
        Me.button2.UseVisualStyleBackColor = True
        '
        'TienLicencia
        '
        Me.TienLicencia.AutoSize = True
        Me.TienLicencia.Location = New System.Drawing.Point(718, 282)
        Me.TienLicencia.Name = "TienLicencia"
        Me.TienLicencia.Size = New System.Drawing.Size(77, 13)
        Me.TienLicencia.TabIndex = 123
        Me.TienLicencia.Text = "Tiene Licencia"
        '
        'Motivo
        '
        Me.Motivo.AutoSize = True
        Me.Motivo.Location = New System.Drawing.Point(478, 231)
        Me.Motivo.Name = "Motivo"
        Me.Motivo.Size = New System.Drawing.Size(68, 13)
        Me.Motivo.TabIndex = 122
        Me.Motivo.Text = "Motivo.Multa"
        '
        'EstatusMul
        '
        Me.EstatusMul.AutoSize = True
        Me.EstatusMul.Location = New System.Drawing.Point(502, 328)
        Me.EstatusMul.Name = "EstatusMul"
        Me.EstatusMul.Size = New System.Drawing.Size(42, 13)
        Me.EstatusMul.TabIndex = 121
        Me.EstatusMul.Text = "Estatus"
        '
        'MotoPagar
        '
        Me.MotoPagar.AutoSize = True
        Me.MotoPagar.Location = New System.Drawing.Point(484, 281)
        Me.MotoPagar.Name = "MotoPagar"
        Me.MotoPagar.Size = New System.Drawing.Size(77, 13)
        Me.MotoPagar.TabIndex = 120
        Me.MotoPagar.Text = "Monto a Pagar"
        '
        'Placas1
        '
        Me.Placas1.AutoSize = True
        Me.Placas1.Location = New System.Drawing.Point(478, 188)
        Me.Placas1.Name = "Placas1"
        Me.Placas1.Size = New System.Drawing.Size(83, 13)
        Me.Placas1.TabIndex = 119
        Me.Placas1.Text = "Placas Vehiculo"
        '
        'NOMBRE2
        '
        Me.NOMBRE2.AutoSize = True
        Me.NOMBRE2.Location = New System.Drawing.Point(493, 109)
        Me.NOMBRE2.Name = "NOMBRE2"
        Me.NOMBRE2.Size = New System.Drawing.Size(44, 13)
        Me.NOMBRE2.TabIndex = 118
        Me.NOMBRE2.Text = "Nombre"
        '
        'labFechaExpedicion
        '
        Me.labFechaExpedicion.AutoSize = True
        Me.labFechaExpedicion.Location = New System.Drawing.Point(661, 58)
        Me.labFechaExpedicion.Name = "labFechaExpedicion"
        Me.labFechaExpedicion.Size = New System.Drawing.Size(92, 13)
        Me.labFechaExpedicion.TabIndex = 117
        Me.labFechaExpedicion.Text = "Fecha Expedicion"
        '
        'Folio
        '
        Me.Folio.AutoSize = True
        Me.Folio.Location = New System.Drawing.Point(499, 58)
        Me.Folio.Name = "Folio"
        Me.Folio.Size = New System.Drawing.Size(29, 13)
        Me.Folio.TabIndex = 116
        Me.Folio.Text = "Folio"
        '
        'No
        '
        Me.No.AutoSize = True
        Me.No.Location = New System.Drawing.Point(845, 282)
        Me.No.Name = "No"
        Me.No.Size = New System.Drawing.Size(40, 17)
        Me.No.TabIndex = 115
        Me.No.Text = "No"
        Me.No.UseVisualStyleBackColor = True
        '
        'Si
        '
        Me.Si.AutoSize = True
        Me.Si.Location = New System.Drawing.Point(801, 282)
        Me.Si.Name = "Si"
        Me.Si.Size = New System.Drawing.Size(35, 17)
        Me.Si.TabIndex = 114
        Me.Si.Text = "Si"
        Me.Si.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(747, 384)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 113
        Me.button1.Text = "Borrar"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(655, 384)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Agregar.TabIndex = 112
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Estatus
        '
        Me.Estatus.Location = New System.Drawing.Point(560, 325)
        Me.Estatus.Name = "Estatus"
        Me.Estatus.Size = New System.Drawing.Size(103, 20)
        Me.Estatus.TabIndex = 111
        '
        'importe
        '
        Me.importe.Location = New System.Drawing.Point(560, 278)
        Me.importe.Name = "importe"
        Me.importe.Size = New System.Drawing.Size(103, 20)
        Me.importe.TabIndex = 110
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(560, 228)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(243, 20)
        Me.descripcion.TabIndex = 109
        '
        'idPlacas
        '
        Me.idPlacas.Location = New System.Drawing.Point(572, 181)
        Me.idPlacas.Name = "idPlacas"
        Me.idPlacas.Size = New System.Drawing.Size(103, 20)
        Me.idPlacas.TabIndex = 108
        '
        'Paterno
        '
        Me.Paterno.Location = New System.Drawing.Point(695, 106)
        Me.Paterno.Name = "Paterno"
        Me.Paterno.Size = New System.Drawing.Size(103, 20)
        Me.Paterno.TabIndex = 107
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(543, 106)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(103, 20)
        Me.Nombre.TabIndex = 106
        '
        'fechaExpedicion
        '
        Me.fechaExpedicion.Location = New System.Drawing.Point(759, 55)
        Me.fechaExpedicion.Name = "fechaExpedicion"
        Me.fechaExpedicion.Size = New System.Drawing.Size(103, 20)
        Me.fechaExpedicion.TabIndex = 105
        '
        'idMulta
        '
        Me.idMulta.Location = New System.Drawing.Point(543, 54)
        Me.idMulta.Name = "idMulta"
        Me.idMulta.Size = New System.Drawing.Size(103, 20)
        Me.idMulta.TabIndex = 104
        '
        'RegistroMultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 450)
        Me.Controls.Add(Me.DGVMulta)
        Me.Controls.Add(Me.labfechaLiquidcion)
        Me.Controls.Add(Me.fechaLiquidacionMuta)
        Me.Controls.Add(Me.Materno1)
        Me.Controls.Add(Me.Materno)
        Me.Controls.Add(Me.Paterno1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.TienLicencia)
        Me.Controls.Add(Me.Motivo)
        Me.Controls.Add(Me.EstatusMul)
        Me.Controls.Add(Me.MotoPagar)
        Me.Controls.Add(Me.Placas1)
        Me.Controls.Add(Me.NOMBRE2)
        Me.Controls.Add(Me.labFechaExpedicion)
        Me.Controls.Add(Me.Folio)
        Me.Controls.Add(Me.No)
        Me.Controls.Add(Me.Si)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.Estatus)
        Me.Controls.Add(Me.importe)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.idPlacas)
        Me.Controls.Add(Me.Paterno)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.fechaExpedicion)
        Me.Controls.Add(Me.idMulta)
        Me.Name = "RegistroMultas"
        Me.Text = "RegistroMultas"
        CType(Me.DGVMulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents DGVMulta As DataGridView
    Friend WithEvents labfechaLiquidcion As Label
    Friend WithEvents fechaLiquidacionMuta As TextBox
    Friend WithEvents Materno1 As Label
    Friend WithEvents Materno As TextBox
    Friend WithEvents Paterno1 As Label
    Friend WithEvents button2 As Button
    Friend WithEvents TienLicencia As Label
    Friend WithEvents Motivo As Label
    Friend WithEvents EstatusMul As Label
    Friend WithEvents MotoPagar As Label
    Friend WithEvents Placas1 As Label
    Friend WithEvents NOMBRE2 As Label
    Friend WithEvents labFechaExpedicion As Label
    Friend WithEvents Folio As Label
    Friend WithEvents No As CheckBox
    Friend WithEvents Si As CheckBox
    Friend WithEvents button1 As Button
    Friend WithEvents Agregar As Button
    Friend WithEvents Estatus As TextBox
    Friend WithEvents importe As TextBox
    Friend WithEvents descripcion As TextBox
    Friend WithEvents idPlacas As TextBox
    Friend WithEvents Paterno As TextBox
    Friend WithEvents Nombre As TextBox
    Friend WithEvents fechaExpedicion As TextBox
    Friend WithEvents idMulta As TextBox
End Class
