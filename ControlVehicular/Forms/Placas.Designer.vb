<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Placas
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
        Me.DGVPlacas = New System.Windows.Forms.DataGridView()
        Me.Cancelar2 = New System.Windows.Forms.Button()
        Me.Borrar2 = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.lbPlaca = New System.Windows.Forms.Label()
        Me.lbPropietario = New System.Windows.Forms.Label()
        Me.lbVehiculo = New System.Windows.Forms.Label()
        Me.idPlaca = New System.Windows.Forms.TextBox()
        Me.idLicencia = New System.Windows.Forms.TextBox()
        Me.idVehiculo = New System.Windows.Forms.TextBox()
        CType(Me.DGVPlacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVPlacas
        '
        Me.DGVPlacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPlacas.Location = New System.Drawing.Point(12, 34)
        Me.DGVPlacas.Name = "DGVPlacas"
        Me.DGVPlacas.Size = New System.Drawing.Size(378, 318)
        Me.DGVPlacas.TabIndex = 93
        '
        'Cancelar2
        '
        Me.Cancelar2.Location = New System.Drawing.Point(693, 393)
        Me.Cancelar2.Name = "Cancelar2"
        Me.Cancelar2.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar2.TabIndex = 92
        Me.Cancelar2.Text = "Cancelar"
        Me.Cancelar2.UseVisualStyleBackColor = True
        '
        'Borrar2
        '
        Me.Borrar2.Location = New System.Drawing.Point(596, 393)
        Me.Borrar2.Name = "Borrar2"
        Me.Borrar2.Size = New System.Drawing.Size(75, 23)
        Me.Borrar2.TabIndex = 91
        Me.Borrar2.Text = "Borrar"
        Me.Borrar2.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(496, 393)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Agregar.TabIndex = 90
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'lbPlaca
        '
        Me.lbPlaca.AutoSize = True
        Me.lbPlaca.Location = New System.Drawing.Point(396, 51)
        Me.lbPlaca.Name = "lbPlaca"
        Me.lbPlaca.Size = New System.Drawing.Size(45, 13)
        Me.lbPlaca.TabIndex = 89
        Me.lbPlaca.Text = "N.Placa"
        '
        'lbPropietario
        '
        Me.lbPropietario.AutoSize = True
        Me.lbPropietario.Location = New System.Drawing.Point(610, 54)
        Me.lbPropietario.Name = "lbPropietario"
        Me.lbPropietario.Size = New System.Drawing.Size(57, 13)
        Me.lbPropietario.TabIndex = 88
        Me.lbPropietario.Text = "Propietario"
        '
        'lbVehiculo
        '
        Me.lbVehiculo.AutoSize = True
        Me.lbVehiculo.Location = New System.Drawing.Point(406, 130)
        Me.lbVehiculo.Name = "lbVehiculo"
        Me.lbVehiculo.Size = New System.Drawing.Size(48, 13)
        Me.lbVehiculo.TabIndex = 87
        Me.lbVehiculo.Text = "Vehiculo"
        '
        'idPlaca
        '
        Me.idPlaca.Location = New System.Drawing.Point(447, 48)
        Me.idPlaca.Name = "idPlaca"
        Me.idPlaca.Size = New System.Drawing.Size(134, 20)
        Me.idPlaca.TabIndex = 86
        '
        'idLicencia
        '
        Me.idLicencia.Location = New System.Drawing.Point(671, 51)
        Me.idLicencia.Name = "idLicencia"
        Me.idLicencia.Size = New System.Drawing.Size(117, 20)
        Me.idLicencia.TabIndex = 85
        '
        'idVehiculo
        '
        Me.idVehiculo.Location = New System.Drawing.Point(458, 127)
        Me.idVehiculo.Name = "idVehiculo"
        Me.idVehiculo.Size = New System.Drawing.Size(123, 20)
        Me.idVehiculo.TabIndex = 84
        '
        'Placas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DGVPlacas)
        Me.Controls.Add(Me.Cancelar2)
        Me.Controls.Add(Me.Borrar2)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.lbPlaca)
        Me.Controls.Add(Me.lbPropietario)
        Me.Controls.Add(Me.lbVehiculo)
        Me.Controls.Add(Me.idPlaca)
        Me.Controls.Add(Me.idLicencia)
        Me.Controls.Add(Me.idVehiculo)
        Me.Name = "Placas"
        Me.Text = "Placas"
        CType(Me.DGVPlacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents DGVPlacas As DataGridView
    Friend WithEvents Cancelar2 As Button
    Friend WithEvents Borrar2 As Button
    Friend WithEvents Agregar As Button
    Friend WithEvents lbPlaca As Label
    Friend WithEvents lbPropietario As Label
    Friend WithEvents lbVehiculo As Label
    Friend WithEvents idPlaca As TextBox
    Friend WithEvents idLicencia As TextBox
    Friend WithEvents idVehiculo As TextBox
End Class
