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
        Me.idPlaca = New System.Windows.Forms.TextBox()
        Me.idVehiculo = New System.Windows.Forms.TextBox()
        Me.tblLocalidades = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.cmbCiudad = New System.Windows.Forms.ComboBox()
        Me.tblBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtIdLicencia = New System.Windows.Forms.NumericUpDown()
        Me.tblLocalidades.SuspendLayout()
        Me.tblBotones.SuspendLayout()
        CType(Me.txtIdLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbPlaca
        '
        Me.lbPlaca.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbPlaca.AutoSize = True
        Me.lbPlaca.ForeColor = System.Drawing.Color.White
        Me.lbPlaca.Location = New System.Drawing.Point(3, 88)
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
        Me.lbPropietario.Location = New System.Drawing.Point(3, 115)
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
        Me.lbVehiculo.Location = New System.Drawing.Point(3, 143)
        Me.lbVehiculo.Name = "lbVehiculo"
        Me.lbVehiculo.Size = New System.Drawing.Size(91, 13)
        Me.lbVehiculo.TabIndex = 87
        Me.lbVehiculo.Text = "No de Serie"
        '
        'idPlaca
        '
        Me.idPlaca.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.idPlaca.Location = New System.Drawing.Point(100, 84)
        Me.idPlaca.MaxLength = 7
        Me.idPlaca.Name = "idPlaca"
        Me.idPlaca.Size = New System.Drawing.Size(222, 20)
        Me.idPlaca.TabIndex = 3
        '
        'idVehiculo
        '
        Me.idVehiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.idVehiculo.Location = New System.Drawing.Point(100, 139)
        Me.idVehiculo.Name = "idVehiculo"
        Me.idVehiculo.Size = New System.Drawing.Size(222, 20)
        Me.idVehiculo.TabIndex = 5
        '
        'tblLocalidades
        '
        Me.tblLocalidades.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblLocalidades.ColumnCount = 2
        Me.tblLocalidades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblLocalidades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tblLocalidades.Controls.Add(Me.lblPais, 0, 0)
        Me.tblLocalidades.Controls.Add(Me.cmbPais, 1, 0)
        Me.tblLocalidades.Controls.Add(Me.cmbCiudad, 1, 2)
        Me.tblLocalidades.Controls.Add(Me.lblCiudad, 0, 2)
        Me.tblLocalidades.Controls.Add(Me.lbVehiculo, 0, 5)
        Me.tblLocalidades.Controls.Add(Me.lbPropietario, 0, 4)
        Me.tblLocalidades.Controls.Add(Me.idVehiculo, 1, 5)
        Me.tblLocalidades.Controls.Add(Me.lbPlaca, 0, 3)
        Me.tblLocalidades.Controls.Add(Me.lblEstado, 0, 1)
        Me.tblLocalidades.Controls.Add(Me.cmbEstado, 1, 1)
        Me.tblLocalidades.Controls.Add(Me.idPlaca, 1, 3)
        Me.tblLocalidades.Controls.Add(Me.txtIdLicencia, 1, 4)
        Me.tblLocalidades.Location = New System.Drawing.Point(12, 12)
        Me.tblLocalidades.Name = "tblLocalidades"
        Me.tblLocalidades.RowCount = 6
        Me.tblLocalidades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblLocalidades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblLocalidades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblLocalidades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblLocalidades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblLocalidades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblLocalidades.Size = New System.Drawing.Size(325, 164)
        Me.tblLocalidades.TabIndex = 93
        '
        'lblPais
        '
        Me.lblPais.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPais.AutoSize = True
        Me.lblPais.ForeColor = System.Drawing.Color.White
        Me.lblPais.Location = New System.Drawing.Point(3, 7)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(91, 13)
        Me.lblPais.TabIndex = 158
        Me.lblPais.Text = "Pais:"
        '
        'cmbEstado
        '
        Me.cmbEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(100, 30)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(222, 21)
        Me.cmbEstado.TabIndex = 1
        '
        'cmbPais
        '
        Me.cmbPais.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(100, 3)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(222, 21)
        Me.cmbPais.TabIndex = 0
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.AutoSize = True
        Me.lblEstado.ForeColor = System.Drawing.Color.White
        Me.lblEstado.Location = New System.Drawing.Point(3, 34)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(91, 13)
        Me.lblEstado.TabIndex = 157
        Me.lblEstado.Text = "Estado:"
        '
        'lblCiudad
        '
        Me.lblCiudad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.ForeColor = System.Drawing.Color.White
        Me.lblCiudad.Location = New System.Drawing.Point(3, 61)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(91, 13)
        Me.lblCiudad.TabIndex = 159
        Me.lblCiudad.Text = "Ciudad:"
        '
        'cmbCiudad
        '
        Me.cmbCiudad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(100, 57)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(222, 21)
        Me.cmbCiudad.TabIndex = 2
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
        Me.tblBotones.Location = New System.Drawing.Point(12, 182)
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
        'txtIdLicencia
        '
        Me.txtIdLicencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdLicencia.Location = New System.Drawing.Point(100, 111)
        Me.txtIdLicencia.Name = "txtIdLicencia"
        Me.txtIdLicencia.Size = New System.Drawing.Size(222, 20)
        Me.txtIdLicencia.TabIndex = 4
        '
        'RegistrarPlacas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(349, 219)
        Me.Controls.Add(Me.tblBotones)
        Me.Controls.Add(Me.tblLocalidades)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrarPlacas"
        Me.Text = "Placas"
        Me.tblLocalidades.ResumeLayout(False)
        Me.tblLocalidades.PerformLayout()
        Me.tblBotones.ResumeLayout(False)
        CType(Me.txtIdLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbPlaca As Label
    Friend WithEvents lbPropietario As Label
    Friend WithEvents lbVehiculo As Label
    Friend WithEvents idPlaca As TextBox
    Friend WithEvents idVehiculo As TextBox
    Friend WithEvents tblLocalidades As TableLayoutPanel
    Friend WithEvents lblPais As Label
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents cmbCiudad As ComboBox
    Friend WithEvents lblCiudad As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents tblBotones As TableLayoutPanel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtIdLicencia As NumericUpDown
End Class
