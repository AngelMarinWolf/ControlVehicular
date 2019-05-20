<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarPlacas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarPlacas))
        Me.lbPlaca = New System.Windows.Forms.Label()
        Me.lbPropietario = New System.Windows.Forms.Label()
        Me.lbVehiculo = New System.Windows.Forms.Label()
        Me.txtIdPlacas = New System.Windows.Forms.TextBox()
        Me.txtIdVehiculo = New System.Windows.Forms.TextBox()
        Me.tblLocalidades = New System.Windows.Forms.TableLayoutPanel()
        Me.txtIdLicencia = New System.Windows.Forms.NumericUpDown()
        Me.tblBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.tblLocalidades.SuspendLayout()
        CType(Me.txtIdLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbPlaca
        '
        Me.lbPlaca.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbPlaca.AutoSize = True
        Me.lbPlaca.ForeColor = System.Drawing.Color.White
        Me.lbPlaca.Location = New System.Drawing.Point(3, 6)
        Me.lbPlaca.Name = "lbPlaca"
        Me.lbPlaca.Size = New System.Drawing.Size(91, 13)
        Me.lbPlaca.TabIndex = 89
        Me.lbPlaca.Text = "No de Placa"
        '
        'lbPropietario
        '
        Me.lbPropietario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbPropietario.AutoSize = True
        Me.lbPropietario.ForeColor = System.Drawing.Color.White
        Me.lbPropietario.Location = New System.Drawing.Point(3, 31)
        Me.lbPropietario.Name = "lbPropietario"
        Me.lbPropietario.Size = New System.Drawing.Size(91, 13)
        Me.lbPropietario.TabIndex = 88
        Me.lbPropietario.Text = "No de Licencia"
        '
        'lbVehiculo
        '
        Me.lbVehiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbVehiculo.AutoSize = True
        Me.lbVehiculo.ForeColor = System.Drawing.Color.White
        Me.lbVehiculo.Location = New System.Drawing.Point(3, 56)
        Me.lbVehiculo.Name = "lbVehiculo"
        Me.lbVehiculo.Size = New System.Drawing.Size(91, 13)
        Me.lbVehiculo.TabIndex = 87
        Me.lbVehiculo.Text = "No de Serie"
        '
        'txtIdPlacas
        '
        Me.txtIdPlacas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdPlacas.Location = New System.Drawing.Point(100, 3)
        Me.txtIdPlacas.MaxLength = 7
        Me.txtIdPlacas.Name = "txtIdPlacas"
        Me.txtIdPlacas.Size = New System.Drawing.Size(222, 20)
        Me.txtIdPlacas.TabIndex = 3
        '
        'txtIdVehiculo
        '
        Me.txtIdVehiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdVehiculo.Location = New System.Drawing.Point(100, 53)
        Me.txtIdVehiculo.MaxLength = 18
        Me.txtIdVehiculo.Name = "txtIdVehiculo"
        Me.txtIdVehiculo.Size = New System.Drawing.Size(222, 20)
        Me.txtIdVehiculo.TabIndex = 5
        '
        'tblLocalidades
        '
        Me.tblLocalidades.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblLocalidades.ColumnCount = 2
        Me.tblLocalidades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblLocalidades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tblLocalidades.Controls.Add(Me.lbVehiculo, 0, 2)
        Me.tblLocalidades.Controls.Add(Me.lbPropietario, 0, 1)
        Me.tblLocalidades.Controls.Add(Me.txtIdVehiculo, 1, 2)
        Me.tblLocalidades.Controls.Add(Me.lbPlaca, 0, 0)
        Me.tblLocalidades.Controls.Add(Me.txtIdPlacas, 1, 0)
        Me.tblLocalidades.Controls.Add(Me.txtIdLicencia, 1, 1)
        Me.tblLocalidades.Location = New System.Drawing.Point(12, 12)
        Me.tblLocalidades.Name = "tblLocalidades"
        Me.tblLocalidades.RowCount = 3
        Me.tblLocalidades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblLocalidades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblLocalidades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblLocalidades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblLocalidades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblLocalidades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblLocalidades.Size = New System.Drawing.Size(325, 75)
        Me.tblLocalidades.TabIndex = 93
        '
        'txtIdLicencia
        '
        Me.txtIdLicencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdLicencia.Location = New System.Drawing.Point(100, 28)
        Me.txtIdLicencia.Name = "txtIdLicencia"
        Me.txtIdLicencia.Size = New System.Drawing.Size(222, 20)
        Me.txtIdLicencia.TabIndex = 4
        '
        'tblBotones
        '
        Me.tblBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblBotones.ColumnCount = 7
        Me.tblBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.tblBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.tblBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.tblBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.tblBotones.Controls.Add(Me.btnAgregar, 1, 0)
        Me.tblBotones.Controls.Add(Me.btnEliminar, 5, 0)
        Me.tblBotones.Controls.Add(Me.btnModificar, 3, 0)
        Me.tblBotones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tblBotones.Location = New System.Drawing.Point(12, 93)
        Me.tblBotones.Name = "tblBotones"
        Me.tblBotones.RowCount = 1
        Me.tblBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblBotones.Size = New System.Drawing.Size(325, 25)
        Me.tblBotones.TabIndex = 160
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(20, 1)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(81, 23)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEliminar.Location = New System.Drawing.Point(222, 1)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(81, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Location = New System.Drawing.Point(121, 1)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(81, 23)
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'RegistrarPlacas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(349, 135)
        Me.Controls.Add(Me.tblBotones)
        Me.Controls.Add(Me.tblLocalidades)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrarPlacas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Placas"
        Me.tblLocalidades.ResumeLayout(False)
        Me.tblLocalidades.PerformLayout()
        CType(Me.txtIdLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbPlaca As Label
    Friend WithEvents lbPropietario As Label
    Friend WithEvents lbVehiculo As Label
    Friend WithEvents txtIdPlacas As TextBox
    Friend WithEvents txtIdVehiculo As TextBox
    Friend WithEvents tblLocalidades As TableLayoutPanel
    Friend WithEvents tblBotones As TableLayoutPanel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtIdLicencia As NumericUpDown
End Class
