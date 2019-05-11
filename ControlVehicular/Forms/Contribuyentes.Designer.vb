<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contribuyentes
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
        Me.edad = New System.Windows.Forms.TextBox()
        Me.x7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.rfc = New System.Windows.Forms.TextBox()
        Me.x2 = New System.Windows.Forms.Label()
        Me.domicilio = New System.Windows.Forms.TextBox()
        Me.x11 = New System.Windows.Forms.Label()
        Me.Masculino = New System.Windows.Forms.CheckBox()
        Me.Sexo = New System.Windows.Forms.Label()
        Me.Femenino = New System.Windows.Forms.CheckBox()
        Me.correoElectronico = New System.Windows.Forms.TextBox()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.x9 = New System.Windows.Forms.Label()
        Me.curp = New System.Windows.Forms.TextBox()
        Me.paterno = New System.Windows.Forms.TextBox()
        Me.materno = New System.Windows.Forms.TextBox()
        Me.x8 = New System.Windows.Forms.Label()
        Me.x6 = New System.Windows.Forms.Label()
        Me.x5 = New System.Windows.Forms.Label()
        Me.x = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.x3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'edad
        '
        Me.edad.Location = New System.Drawing.Point(124, 137)
        Me.edad.Name = "edad"
        Me.edad.Size = New System.Drawing.Size(100, 20)
        Me.edad.TabIndex = 135
        '
        'x7
        '
        Me.x7.AutoSize = True
        Me.x7.Location = New System.Drawing.Point(76, 137)
        Me.x7.Name = "x7"
        Me.x7.Size = New System.Drawing.Size(32, 13)
        Me.x7.TabIndex = 134
        Me.x7.Text = "Edad"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(351, 137)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(439, 255)
        Me.DataGridView1.TabIndex = 133
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(248, 324)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 132
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(157, 324)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(75, 23)
        Me.Modificar.TabIndex = 131
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(72, 324)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Agregar.TabIndex = 130
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'rfc
        '
        Me.rfc.Location = New System.Drawing.Point(445, 60)
        Me.rfc.Name = "rfc"
        Me.rfc.Size = New System.Drawing.Size(142, 20)
        Me.rfc.TabIndex = 129
        '
        'x2
        '
        Me.x2.AutoSize = True
        Me.x2.Location = New System.Drawing.Point(416, 63)
        Me.x2.Name = "x2"
        Me.x2.Size = New System.Drawing.Size(24, 13)
        Me.x2.TabIndex = 128
        Me.x2.Text = "Rfc"
        '
        'domicilio
        '
        Me.domicilio.Location = New System.Drawing.Point(136, 211)
        Me.domicilio.Name = "domicilio"
        Me.domicilio.Size = New System.Drawing.Size(187, 20)
        Me.domicilio.TabIndex = 127
        '
        'x11
        '
        Me.x11.AutoSize = True
        Me.x11.Location = New System.Drawing.Point(71, 214)
        Me.x11.Name = "x11"
        Me.x11.Size = New System.Drawing.Size(49, 13)
        Me.x11.TabIndex = 126
        Me.x11.Text = "Domicilio"
        '
        'Masculino
        '
        Me.Masculino.AutoSize = True
        Me.Masculino.Location = New System.Drawing.Point(206, 245)
        Me.Masculino.Name = "Masculino"
        Me.Masculino.Size = New System.Drawing.Size(74, 17)
        Me.Masculino.TabIndex = 125
        Me.Masculino.Text = "Masculino"
        Me.Masculino.UseVisualStyleBackColor = True
        '
        'Sexo
        '
        Me.Sexo.AutoSize = True
        Me.Sexo.Location = New System.Drawing.Point(74, 246)
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Size = New System.Drawing.Size(31, 13)
        Me.Sexo.TabIndex = 124
        Me.Sexo.Text = "Sexo"
        '
        'Femenino
        '
        Me.Femenino.AutoSize = True
        Me.Femenino.Location = New System.Drawing.Point(128, 245)
        Me.Femenino.Name = "Femenino"
        Me.Femenino.Size = New System.Drawing.Size(72, 17)
        Me.Femenino.TabIndex = 123
        Me.Femenino.Text = "Femenino"
        Me.Femenino.UseVisualStyleBackColor = True
        '
        'correoElectronico
        '
        Me.correoElectronico.Location = New System.Drawing.Point(168, 273)
        Me.correoElectronico.Name = "correoElectronico"
        Me.correoElectronico.Size = New System.Drawing.Size(155, 20)
        Me.correoElectronico.TabIndex = 122
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(124, 174)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(199, 20)
        Me.telefono.TabIndex = 121
        '
        'x9
        '
        Me.x9.AutoSize = True
        Me.x9.Location = New System.Drawing.Point(69, 280)
        Me.x9.Name = "x9"
        Me.x9.Size = New System.Drawing.Size(93, 13)
        Me.x9.TabIndex = 120
        Me.x9.Text = "Correo electronico"
        '
        'curp
        '
        Me.curp.Location = New System.Drawing.Point(120, 59)
        Me.curp.Name = "curp"
        Me.curp.Size = New System.Drawing.Size(278, 20)
        Me.curp.TabIndex = 119
        '
        'paterno
        '
        Me.paterno.Location = New System.Drawing.Point(298, 92)
        Me.paterno.Name = "paterno"
        Me.paterno.Size = New System.Drawing.Size(100, 20)
        Me.paterno.TabIndex = 118
        '
        'materno
        '
        Me.materno.Location = New System.Drawing.Point(487, 92)
        Me.materno.Name = "materno"
        Me.materno.Size = New System.Drawing.Size(100, 20)
        Me.materno.TabIndex = 117
        '
        'x8
        '
        Me.x8.AutoSize = True
        Me.x8.Location = New System.Drawing.Point(69, 174)
        Me.x8.Name = "x8"
        Me.x8.Size = New System.Drawing.Size(49, 13)
        Me.x8.TabIndex = 116
        Me.x8.Text = "Telefono"
        '
        'x6
        '
        Me.x6.AutoSize = True
        Me.x6.Location = New System.Drawing.Point(418, 95)
        Me.x6.Name = "x6"
        Me.x6.Size = New System.Drawing.Size(46, 13)
        Me.x6.TabIndex = 115
        Me.x6.Text = "Materno"
        '
        'x5
        '
        Me.x5.AutoSize = True
        Me.x5.Location = New System.Drawing.Point(248, 92)
        Me.x5.Name = "x5"
        Me.x5.Size = New System.Drawing.Size(44, 13)
        Me.x5.TabIndex = 114
        Me.x5.Text = "Paterno"
        '
        'x
        '
        Me.x.AutoSize = True
        Me.x.Location = New System.Drawing.Point(72, 63)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(37, 13)
        Me.x.TabIndex = 113
        Me.x.Text = "CURP"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(120, 95)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(100, 20)
        Me.nombre.TabIndex = 112
        '
        'x3
        '
        Me.x3.AutoSize = True
        Me.x3.Location = New System.Drawing.Point(70, 98)
        Me.x3.Name = "x3"
        Me.x3.Size = New System.Drawing.Size(44, 13)
        Me.x3.TabIndex = 111
        Me.x3.Text = "Nombre"
        '
        'Contribuyentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 433)
        Me.Controls.Add(Me.edad)
        Me.Controls.Add(Me.x7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.rfc)
        Me.Controls.Add(Me.x2)
        Me.Controls.Add(Me.domicilio)
        Me.Controls.Add(Me.x11)
        Me.Controls.Add(Me.Masculino)
        Me.Controls.Add(Me.Sexo)
        Me.Controls.Add(Me.Femenino)
        Me.Controls.Add(Me.correoElectronico)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.x9)
        Me.Controls.Add(Me.curp)
        Me.Controls.Add(Me.paterno)
        Me.Controls.Add(Me.materno)
        Me.Controls.Add(Me.x8)
        Me.Controls.Add(Me.x6)
        Me.Controls.Add(Me.x5)
        Me.Controls.Add(Me.x)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.x3)
        Me.Name = "Contribuyentes"
        Me.Text = "Contribuyentes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents edad As TextBox
    Friend WithEvents x7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Eliminar As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents Agregar As Button
    Friend WithEvents rfc As TextBox
    Friend WithEvents x2 As Label
    Friend WithEvents domicilio As TextBox
    Friend WithEvents x11 As Label
    Friend WithEvents Masculino As CheckBox
    Friend WithEvents Sexo As Label
    Friend WithEvents Femenino As CheckBox
    Friend WithEvents correoElectronico As TextBox
    Friend WithEvents telefono As TextBox
    Friend WithEvents x9 As Label
    Friend WithEvents curp As TextBox
    Friend WithEvents paterno As TextBox
    Friend WithEvents materno As TextBox
    Friend WithEvents x8 As Label
    Friend WithEvents x6 As Label
    Friend WithEvents x5 As Label
    Friend WithEvents x As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents x3 As Label
End Class
