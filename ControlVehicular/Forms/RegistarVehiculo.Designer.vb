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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistarVehiculo))
        Me.lbFactura = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Factura = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.idpropietario = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SERIE = New System.Windows.Forms.TextBox()
        Me.serie1 = New System.Windows.Forms.Label()
        Me.tblDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tblCaracteristicas = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.grpCaracteristicas = New System.Windows.Forms.GroupBox()
        Me.tblBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.tblDatos.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblCaracteristicas.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCaracteristicas.SuspendLayout()
        Me.tblBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbFactura
        '
        Me.lbFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFactura.AutoSize = True
        Me.lbFactura.ForeColor = System.Drawing.Color.White
        Me.lbFactura.Location = New System.Drawing.Point(333, 5)
        Me.lbFactura.Name = "lbFactura"
        Me.lbFactura.Size = New System.Drawing.Size(93, 13)
        Me.lbFactura.TabIndex = 147
        Me.lbFactura.Text = "N.Factura"
        '
        'label4
        '
        Me.label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(333, 55)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(93, 13)
        Me.label4.TabIndex = 145
        Me.label4.Text = "Importe Factura"
        '
        'label3
        '
        Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(333, 30)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(93, 13)
        Me.label3.TabIndex = 144
        Me.label3.Text = "Fecha Factura"
        '
        'Factura
        '
        Me.Factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Factura.Location = New System.Drawing.Point(432, 3)
        Me.Factura.Name = "Factura"
        Me.Factura.Size = New System.Drawing.Size(225, 20)
        Me.Factura.TabIndex = 138
        '
        'label7
        '
        Me.label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label7.AutoSize = True
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(3, 30)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(93, 13)
        Me.label7.TabIndex = 133
        Me.label7.Text = "Propietario"
        '
        'idpropietario
        '
        Me.idpropietario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.idpropietario.Location = New System.Drawing.Point(102, 27)
        Me.idpropietario.Name = "idpropietario"
        Me.idpropietario.Size = New System.Drawing.Size(225, 20)
        Me.idpropietario.TabIndex = 128
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(3, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 13)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "Tipo Vehiculo"
        '
        'SERIE
        '
        Me.SERIE.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SERIE.Location = New System.Drawing.Point(102, 3)
        Me.SERIE.MaxLength = 8
        Me.SERIE.Name = "SERIE"
        Me.SERIE.Size = New System.Drawing.Size(225, 20)
        Me.SERIE.TabIndex = 154
        '
        'serie1
        '
        Me.serie1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.serie1.AutoSize = True
        Me.serie1.ForeColor = System.Drawing.Color.White
        Me.serie1.Location = New System.Drawing.Point(3, 5)
        Me.serie1.Name = "serie1"
        Me.serie1.Size = New System.Drawing.Size(93, 13)
        Me.serie1.TabIndex = 155
        Me.serie1.Text = "N.SerieAuto"
        '
        'tblDatos
        '
        Me.tblDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblDatos.ColumnCount = 4
        Me.tblDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tblDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tblDatos.Controls.Add(Me.SERIE, 1, 0)
        Me.tblDatos.Controls.Add(Me.label4, 2, 2)
        Me.tblDatos.Controls.Add(Me.serie1, 0, 0)
        Me.tblDatos.Controls.Add(Me.lbFactura, 2, 0)
        Me.tblDatos.Controls.Add(Me.Factura, 3, 0)
        Me.tblDatos.Controls.Add(Me.idpropietario, 1, 1)
        Me.tblDatos.Controls.Add(Me.label7, 0, 1)
        Me.tblDatos.Controls.Add(Me.label3, 2, 1)
        Me.tblDatos.Controls.Add(Me.NumericUpDown1, 3, 2)
        Me.tblDatos.Controls.Add(Me.DateTimePicker1, 3, 1)
        Me.tblDatos.Location = New System.Drawing.Point(12, 12)
        Me.tblDatos.Name = "tblDatos"
        Me.tblDatos.RowCount = 3
        Me.tblDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblDatos.Size = New System.Drawing.Size(660, 75)
        Me.tblDatos.TabIndex = 156
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.Location = New System.Drawing.Point(432, 52)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(225, 20)
        Me.NumericUpDown1.TabIndex = 156
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Location = New System.Drawing.Point(432, 27)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(225, 20)
        Me.DateTimePicker1.TabIndex = 157
        '
        'tblCaracteristicas
        '
        Me.tblCaracteristicas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblCaracteristicas.ColumnCount = 4
        Me.tblCaracteristicas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblCaracteristicas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tblCaracteristicas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblCaracteristicas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tblCaracteristicas.Controls.Add(Me.ComboBox2, 1, 0)
        Me.tblCaracteristicas.Controls.Add(Me.Label18, 2, 0)
        Me.tblCaracteristicas.Controls.Add(Me.ComboBox3, 3, 0)
        Me.tblCaracteristicas.Controls.Add(Me.Label19, 0, 0)
        Me.tblCaracteristicas.Controls.Add(Me.ComboBox4, 1, 1)
        Me.tblCaracteristicas.Controls.Add(Me.Label15, 2, 1)
        Me.tblCaracteristicas.Controls.Add(Me.Label13, 0, 1)
        Me.tblCaracteristicas.Controls.Add(Me.ComboBox1, 3, 1)
        Me.tblCaracteristicas.Controls.Add(Me.Label17, 0, 2)
        Me.tblCaracteristicas.Controls.Add(Me.TextBox4, 1, 2)
        Me.tblCaracteristicas.Controls.Add(Me.NumericUpDown2, 3, 2)
        Me.tblCaracteristicas.Controls.Add(Me.Label16, 2, 2)
        Me.tblCaracteristicas.Location = New System.Drawing.Point(6, 19)
        Me.tblCaracteristicas.Name = "tblCaracteristicas"
        Me.tblCaracteristicas.RowCount = 3
        Me.tblCaracteristicas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.tblCaracteristicas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblCaracteristicas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblCaracteristicas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblCaracteristicas.Size = New System.Drawing.Size(648, 75)
        Me.tblCaracteristicas.TabIndex = 157
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(100, 3)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(220, 21)
        Me.ComboBox2.TabIndex = 152
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(326, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 13)
        Me.Label18.TabIndex = 135
        Me.Label18.Text = "Marca Auto"
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(423, 3)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(222, 21)
        Me.ComboBox3.TabIndex = 151
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(3, 5)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 13)
        Me.Label19.TabIndex = 136
        Me.Label19.Text = "Tipo Auto"
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(100, 27)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(220, 21)
        Me.ComboBox4.TabIndex = 155
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(326, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 137
        Me.Label15.Text = "Tipo Combustible"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(423, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(222, 21)
        Me.ComboBox1.TabIndex = 153
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(3, 55)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 13)
        Me.Label17.TabIndex = 134
        Me.Label17.Text = "Color Auto"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(100, 52)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(220, 20)
        Me.TextBox4.TabIndex = 131
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown2.Location = New System.Drawing.Point(423, 52)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(222, 20)
        Me.NumericUpDown2.TabIndex = 154
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(326, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 13)
        Me.Label16.TabIndex = 146
        Me.Label16.Text = "Pasajeros"
        '
        'grpCaracteristicas
        '
        Me.grpCaracteristicas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCaracteristicas.Controls.Add(Me.tblCaracteristicas)
        Me.grpCaracteristicas.Location = New System.Drawing.Point(12, 93)
        Me.grpCaracteristicas.Name = "grpCaracteristicas"
        Me.grpCaracteristicas.Size = New System.Drawing.Size(660, 102)
        Me.grpCaracteristicas.TabIndex = 158
        Me.grpCaracteristicas.TabStop = False
        Me.grpCaracteristicas.Text = "Caracteristicas"
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
        Me.tblBotones.Location = New System.Drawing.Point(12, 201)
        Me.tblBotones.Name = "tblBotones"
        Me.tblBotones.RowCount = 1
        Me.tblBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblBotones.Size = New System.Drawing.Size(660, 25)
        Me.tblBotones.TabIndex = 159
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(41, 1)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(165, 23)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEliminar.Location = New System.Drawing.Point(453, 1)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(165, 23)
        Me.btnEliminar.TabIndex = 21
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Location = New System.Drawing.Point(247, 1)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(165, 23)
        Me.btnModificar.TabIndex = 20
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'RegistarVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 237)
        Me.Controls.Add(Me.tblBotones)
        Me.Controls.Add(Me.grpCaracteristicas)
        Me.Controls.Add(Me.tblDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistarVehiculo"
        Me.Text = "Registrar Vehiculo"
        Me.tblDatos.ResumeLayout(False)
        Me.tblDatos.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblCaracteristicas.ResumeLayout(False)
        Me.tblCaracteristicas.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCaracteristicas.ResumeLayout(False)
        Me.tblBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbFactura As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents Factura As TextBox
    Friend WithEvents label7 As Label
    Friend WithEvents idpropietario As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents SERIE As TextBox
    Friend WithEvents serie1 As Label
    Friend WithEvents tblDatos As TableLayoutPanel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents tblCaracteristicas As TableLayoutPanel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents grpCaracteristicas As GroupBox
    Friend WithEvents tblBotones As TableLayoutPanel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
End Class
