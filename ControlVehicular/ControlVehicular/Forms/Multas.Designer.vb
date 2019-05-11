<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multas
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
        Me.Placas = New System.Windows.Forms.Label()
        Me.idPlacas = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Importe = New System.Windows.Forms.TextBox()
        Me.MontoPagar = New System.Windows.Forms.Label()
        Me.EstatusMulta = New System.Windows.Forms.Label()
        Me.Retribuido = New System.Windows.Forms.TextBox()
        Me.Descripcion = New System.Windows.Forms.TextBox()
        Me.idMulta = New System.Windows.Forms.TextBox()
        Me.MotivoInfraccionar = New System.Windows.Forms.Label()
        Me.Folio = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Paterno = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Materno3 = New System.Windows.Forms.TextBox()
        Me.Materno2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Placas
        '
        Me.Placas.AutoSize = True
        Me.Placas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Placas.Location = New System.Drawing.Point(20, 114)
        Me.Placas.Name = "Placas"
        Me.Placas.Size = New System.Drawing.Size(39, 13)
        Me.Placas.TabIndex = 125
        Me.Placas.Text = "Placas"
        '
        'idPlacas
        '
        Me.idPlacas.Location = New System.Drawing.Point(113, 107)
        Me.idPlacas.Name = "idPlacas"
        Me.idPlacas.Size = New System.Drawing.Size(132, 20)
        Me.idPlacas.TabIndex = 124
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 216)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(716, 125)
        Me.DataGridView1.TabIndex = 120
        '
        'Eliminar
        '
        Me.Eliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Eliminar.Location = New System.Drawing.Point(674, 359)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 119
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Modificar.Location = New System.Drawing.Point(575, 359)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(75, 23)
        Me.Modificar.TabIndex = 118
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Agregar.Location = New System.Drawing.Point(484, 359)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Agregar.TabIndex = 117
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Importe
        '
        Me.Importe.Location = New System.Drawing.Point(113, 141)
        Me.Importe.Name = "Importe"
        Me.Importe.Size = New System.Drawing.Size(132, 20)
        Me.Importe.TabIndex = 116
        '
        'MontoPagar
        '
        Me.MontoPagar.AutoSize = True
        Me.MontoPagar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MontoPagar.Location = New System.Drawing.Point(18, 148)
        Me.MontoPagar.Name = "MontoPagar"
        Me.MontoPagar.Size = New System.Drawing.Size(76, 13)
        Me.MontoPagar.TabIndex = 115
        Me.MontoPagar.Text = "Monto a pagar"
        '
        'EstatusMulta
        '
        Me.EstatusMulta.AutoSize = True
        Me.EstatusMulta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.EstatusMulta.Location = New System.Drawing.Point(18, 179)
        Me.EstatusMulta.Name = "EstatusMulta"
        Me.EstatusMulta.Size = New System.Drawing.Size(85, 13)
        Me.EstatusMulta.TabIndex = 114
        Me.EstatusMulta.Text = "Estatus de multa"
        '
        'Retribuido
        '
        Me.Retribuido.Location = New System.Drawing.Point(113, 172)
        Me.Retribuido.Name = "Retribuido"
        Me.Retribuido.Size = New System.Drawing.Size(132, 20)
        Me.Retribuido.TabIndex = 113
        '
        'Descripcion
        '
        Me.Descripcion.Location = New System.Drawing.Point(390, 114)
        Me.Descripcion.Multiline = True
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(371, 86)
        Me.Descripcion.TabIndex = 112
        '
        'idMulta
        '
        Me.idMulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.idMulta.Location = New System.Drawing.Point(113, 44)
        Me.idMulta.Name = "idMulta"
        Me.idMulta.Size = New System.Drawing.Size(132, 20)
        Me.idMulta.TabIndex = 111
        '
        'MotivoInfraccionar
        '
        Me.MotivoInfraccionar.AutoSize = True
        Me.MotivoInfraccionar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MotivoInfraccionar.Location = New System.Drawing.Point(270, 117)
        Me.MotivoInfraccionar.Name = "MotivoInfraccionar"
        Me.MotivoInfraccionar.Size = New System.Drawing.Size(114, 13)
        Me.MotivoInfraccionar.TabIndex = 110
        Me.MotivoInfraccionar.Text = "Motivo de la infraccion"
        '
        'Folio
        '
        Me.Folio.AutoSize = True
        Me.Folio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Folio.Location = New System.Drawing.Point(20, 47)
        Me.Folio.Name = "Folio"
        Me.Folio.Size = New System.Drawing.Size(29, 13)
        Me.Folio.TabIndex = 109
        Me.Folio.Text = "Folio"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Fecha.Location = New System.Drawing.Point(8, 82)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(92, 13)
        Me.Fecha.TabIndex = 108
        Me.Fecha.Text = "Fecha Expedición"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(449, 12)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(90, 20)
        Me.TextBox3.TabIndex = 107
        '
        'Paterno
        '
        Me.Paterno.AutoSize = True
        Me.Paterno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Paterno.Location = New System.Drawing.Point(399, 15)
        Me.Paterno.Name = "Paterno"
        Me.Paterno.Size = New System.Drawing.Size(44, 13)
        Me.Paterno.TabIndex = 106
        Me.Paterno.Text = "Paterno"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(290, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(94, 20)
        Me.TextBox1.TabIndex = 105
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Nombre.Location = New System.Drawing.Point(240, 15)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Nombre.TabIndex = 104
        Me.Nombre.Text = "Nombre"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(106, 79)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(212, 20)
        Me.DateTimePicker1.TabIndex = 126
        '
        'Materno3
        '
        Me.Materno3.Location = New System.Drawing.Point(609, 15)
        Me.Materno3.Name = "Materno3"
        Me.Materno3.Size = New System.Drawing.Size(90, 20)
        Me.Materno3.TabIndex = 127
        '
        'Materno2
        '
        Me.Materno2.AutoSize = True
        Me.Materno2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Materno2.Location = New System.Drawing.Point(557, 18)
        Me.Materno2.Name = "Materno2"
        Me.Materno2.Size = New System.Drawing.Size(46, 13)
        Me.Materno2.TabIndex = 128
        Me.Materno2.Text = "Materno"
        '
        'Multas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 394)
        Me.Controls.Add(Me.Materno2)
        Me.Controls.Add(Me.Materno3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Placas)
        Me.Controls.Add(Me.idPlacas)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.Importe)
        Me.Controls.Add(Me.MontoPagar)
        Me.Controls.Add(Me.EstatusMulta)
        Me.Controls.Add(Me.Retribuido)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.idMulta)
        Me.Controls.Add(Me.MotivoInfraccionar)
        Me.Controls.Add(Me.Folio)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Paterno)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Nombre)
        Me.Name = "Multas"
        Me.Text = "Multas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Placas As Label
    Friend WithEvents idPlacas As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Eliminar As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents Agregar As Button
    Friend WithEvents Importe As TextBox
    Friend WithEvents MontoPagar As Label
    Friend WithEvents EstatusMulta As Label
    Friend WithEvents Retribuido As TextBox
    Friend WithEvents Descripcion As TextBox
    Friend WithEvents idMulta As TextBox
    Friend WithEvents MotivoInfraccionar As Label
    Friend WithEvents Folio As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Paterno As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Nombre As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Materno3 As TextBox
    Friend WithEvents Materno2 As Label
End Class
