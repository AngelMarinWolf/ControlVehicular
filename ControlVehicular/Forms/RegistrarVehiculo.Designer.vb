<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarVehiculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarVehiculo))
        Me.lblNoFactura = New System.Windows.Forms.Label()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.lblFechaFactura = New System.Windows.Forms.Label()
        Me.txtNoFactura = New System.Windows.Forms.TextBox()
        Me.lblCurp = New System.Windows.Forms.Label()
        Me.txtIdContribuyente = New System.Windows.Forms.TextBox()
        Me.lblTipoVehiculo = New System.Windows.Forms.Label()
        Me.txtNoSerie = New System.Windows.Forms.TextBox()
        Me.lblNoSerie = New System.Windows.Forms.Label()
        Me.tblDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.txtImporte = New System.Windows.Forms.NumericUpDown()
        Me.dateFactura = New System.Windows.Forms.DateTimePicker()
        Me.tblCaracteristicas = New System.Windows.Forms.TableLayoutPanel()
        Me.cbTipoVehiculo = New System.Windows.Forms.ComboBox()
        Me.lblMarcaAuto = New System.Windows.Forms.Label()
        Me.cbMarcaAuto = New System.Windows.Forms.ComboBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblTipoCombustible = New System.Windows.Forms.Label()
        Me.cbCombustible = New System.Windows.Forms.ComboBox()
        Me.lblNoPasajeros = New System.Windows.Forms.Label()
        Me.txtNoPasajeros = New System.Windows.Forms.NumericUpDown()
        Me.lblUso = New System.Windows.Forms.Label()
        Me.cbUso = New System.Windows.Forms.ComboBox()
        Me.grpCaracteristicas = New System.Windows.Forms.GroupBox()
        Me.tblBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.tblDatos.SuspendLayout()
        CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblCaracteristicas.SuspendLayout()
        CType(Me.txtNoPasajeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCaracteristicas.SuspendLayout()
        Me.tblBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNoFactura
        '
        Me.lblNoFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoFactura.AutoSize = True
        Me.lblNoFactura.ForeColor = System.Drawing.Color.White
        Me.lblNoFactura.Location = New System.Drawing.Point(333, 5)
        Me.lblNoFactura.Name = "lblNoFactura"
        Me.lblNoFactura.Size = New System.Drawing.Size(93, 13)
        Me.lblNoFactura.TabIndex = 147
        Me.lblNoFactura.Text = "No. de Factura"
        '
        'lblImporte
        '
        Me.lblImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblImporte.AutoSize = True
        Me.lblImporte.ForeColor = System.Drawing.Color.White
        Me.lblImporte.Location = New System.Drawing.Point(333, 55)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(93, 13)
        Me.lblImporte.TabIndex = 145
        Me.lblImporte.Text = "Importe Factura"
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaFactura.AutoSize = True
        Me.lblFechaFactura.ForeColor = System.Drawing.Color.White
        Me.lblFechaFactura.Location = New System.Drawing.Point(333, 30)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(93, 13)
        Me.lblFechaFactura.TabIndex = 144
        Me.lblFechaFactura.Text = "Fecha de Factura"
        '
        'txtNoFactura
        '
        Me.txtNoFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoFactura.Location = New System.Drawing.Point(432, 3)
        Me.txtNoFactura.MaxLength = 45
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(225, 20)
        Me.txtNoFactura.TabIndex = 1
        '
        'lblCurp
        '
        Me.lblCurp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurp.AutoSize = True
        Me.lblCurp.ForeColor = System.Drawing.Color.White
        Me.lblCurp.Location = New System.Drawing.Point(3, 30)
        Me.lblCurp.Name = "lblCurp"
        Me.lblCurp.Size = New System.Drawing.Size(93, 13)
        Me.lblCurp.TabIndex = 133
        Me.lblCurp.Text = "CURP Propietario"
        '
        'txtIdContribuyente
        '
        Me.txtIdContribuyente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdContribuyente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdContribuyente.Location = New System.Drawing.Point(102, 27)
        Me.txtIdContribuyente.MaxLength = 18
        Me.txtIdContribuyente.Name = "txtIdContribuyente"
        Me.txtIdContribuyente.Size = New System.Drawing.Size(225, 20)
        Me.txtIdContribuyente.TabIndex = 2
        '
        'lblTipoVehiculo
        '
        Me.lblTipoVehiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoVehiculo.AutoSize = True
        Me.lblTipoVehiculo.ForeColor = System.Drawing.Color.White
        Me.lblTipoVehiculo.Location = New System.Drawing.Point(3, 5)
        Me.lblTipoVehiculo.Name = "lblTipoVehiculo"
        Me.lblTipoVehiculo.Size = New System.Drawing.Size(91, 13)
        Me.lblTipoVehiculo.TabIndex = 124
        Me.lblTipoVehiculo.Text = "Tipo Vehiculo"
        '
        'txtNoSerie
        '
        Me.txtNoSerie.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoSerie.Location = New System.Drawing.Point(102, 3)
        Me.txtNoSerie.MaxLength = 17
        Me.txtNoSerie.Name = "txtNoSerie"
        Me.txtNoSerie.Size = New System.Drawing.Size(225, 20)
        Me.txtNoSerie.TabIndex = 0
        '
        'lblNoSerie
        '
        Me.lblNoSerie.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoSerie.AutoSize = True
        Me.lblNoSerie.ForeColor = System.Drawing.Color.White
        Me.lblNoSerie.Location = New System.Drawing.Point(3, 5)
        Me.lblNoSerie.Name = "lblNoSerie"
        Me.lblNoSerie.Size = New System.Drawing.Size(93, 13)
        Me.lblNoSerie.TabIndex = 155
        Me.lblNoSerie.Text = "No.  de Serie"
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
        Me.tblDatos.Controls.Add(Me.txtNoSerie, 1, 0)
        Me.tblDatos.Controls.Add(Me.lblImporte, 2, 2)
        Me.tblDatos.Controls.Add(Me.lblNoSerie, 0, 0)
        Me.tblDatos.Controls.Add(Me.lblNoFactura, 2, 0)
        Me.tblDatos.Controls.Add(Me.txtNoFactura, 3, 0)
        Me.tblDatos.Controls.Add(Me.txtIdContribuyente, 1, 1)
        Me.tblDatos.Controls.Add(Me.lblCurp, 0, 1)
        Me.tblDatos.Controls.Add(Me.lblFechaFactura, 2, 1)
        Me.tblDatos.Controls.Add(Me.txtImporte, 3, 2)
        Me.tblDatos.Controls.Add(Me.dateFactura, 3, 1)
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
        'txtImporte
        '
        Me.txtImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporte.DecimalPlaces = 2
        Me.txtImporte.Location = New System.Drawing.Point(432, 52)
        Me.txtImporte.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(225, 20)
        Me.txtImporte.TabIndex = 4
        '
        'dateFactura
        '
        Me.dateFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateFactura.Location = New System.Drawing.Point(432, 27)
        Me.dateFactura.Name = "dateFactura"
        Me.dateFactura.Size = New System.Drawing.Size(225, 20)
        Me.dateFactura.TabIndex = 3
        '
        'tblCaracteristicas
        '
        Me.tblCaracteristicas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblCaracteristicas.ColumnCount = 4
        Me.tblCaracteristicas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblCaracteristicas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tblCaracteristicas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblCaracteristicas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tblCaracteristicas.Controls.Add(Me.cbTipoVehiculo, 1, 0)
        Me.tblCaracteristicas.Controls.Add(Me.lblMarcaAuto, 2, 0)
        Me.tblCaracteristicas.Controls.Add(Me.cbMarcaAuto, 3, 0)
        Me.tblCaracteristicas.Controls.Add(Me.lblColor, 0, 2)
        Me.tblCaracteristicas.Controls.Add(Me.txtColor, 1, 2)
        Me.tblCaracteristicas.Controls.Add(Me.lblTipoVehiculo, 0, 0)
        Me.tblCaracteristicas.Controls.Add(Me.lblTipoCombustible, 0, 1)
        Me.tblCaracteristicas.Controls.Add(Me.cbCombustible, 1, 1)
        Me.tblCaracteristicas.Controls.Add(Me.lblNoPasajeros, 2, 2)
        Me.tblCaracteristicas.Controls.Add(Me.txtNoPasajeros, 3, 2)
        Me.tblCaracteristicas.Controls.Add(Me.lblUso, 2, 1)
        Me.tblCaracteristicas.Controls.Add(Me.cbUso, 3, 1)
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
        'cbTipoVehiculo
        '
        Me.cbTipoVehiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipoVehiculo.FormattingEnabled = True
        Me.cbTipoVehiculo.Location = New System.Drawing.Point(100, 3)
        Me.cbTipoVehiculo.Name = "cbTipoVehiculo"
        Me.cbTipoVehiculo.Size = New System.Drawing.Size(220, 21)
        Me.cbTipoVehiculo.TabIndex = 5
        '
        'lblMarcaAuto
        '
        Me.lblMarcaAuto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMarcaAuto.AutoSize = True
        Me.lblMarcaAuto.ForeColor = System.Drawing.Color.White
        Me.lblMarcaAuto.Location = New System.Drawing.Point(326, 5)
        Me.lblMarcaAuto.Name = "lblMarcaAuto"
        Me.lblMarcaAuto.Size = New System.Drawing.Size(91, 13)
        Me.lblMarcaAuto.TabIndex = 135
        Me.lblMarcaAuto.Text = "Marca Auto"
        '
        'cbMarcaAuto
        '
        Me.cbMarcaAuto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMarcaAuto.FormattingEnabled = True
        Me.cbMarcaAuto.Location = New System.Drawing.Point(423, 3)
        Me.cbMarcaAuto.Name = "cbMarcaAuto"
        Me.cbMarcaAuto.Size = New System.Drawing.Size(222, 21)
        Me.cbMarcaAuto.TabIndex = 6
        '
        'lblColor
        '
        Me.lblColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblColor.AutoSize = True
        Me.lblColor.ForeColor = System.Drawing.Color.White
        Me.lblColor.Location = New System.Drawing.Point(3, 55)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(91, 13)
        Me.lblColor.TabIndex = 134
        Me.lblColor.Text = "Color"
        '
        'txtColor
        '
        Me.txtColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtColor.Location = New System.Drawing.Point(100, 52)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(220, 20)
        Me.txtColor.TabIndex = 9
        '
        'lblTipoCombustible
        '
        Me.lblTipoCombustible.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoCombustible.AutoSize = True
        Me.lblTipoCombustible.ForeColor = System.Drawing.Color.White
        Me.lblTipoCombustible.Location = New System.Drawing.Point(3, 30)
        Me.lblTipoCombustible.Name = "lblTipoCombustible"
        Me.lblTipoCombustible.Size = New System.Drawing.Size(91, 13)
        Me.lblTipoCombustible.TabIndex = 137
        Me.lblTipoCombustible.Text = "Tipo Combustible"
        '
        'cbCombustible
        '
        Me.cbCombustible.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCombustible.FormattingEnabled = True
        Me.cbCombustible.Items.AddRange(New Object() {"Gasolina", "Diesel", "Hibrido", "Electrico", "Alternativo", "Gas"})
        Me.cbCombustible.Location = New System.Drawing.Point(100, 27)
        Me.cbCombustible.Name = "cbCombustible"
        Me.cbCombustible.Size = New System.Drawing.Size(220, 21)
        Me.cbCombustible.TabIndex = 7
        '
        'lblNoPasajeros
        '
        Me.lblNoPasajeros.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoPasajeros.AutoSize = True
        Me.lblNoPasajeros.ForeColor = System.Drawing.Color.White
        Me.lblNoPasajeros.Location = New System.Drawing.Point(326, 55)
        Me.lblNoPasajeros.Name = "lblNoPasajeros"
        Me.lblNoPasajeros.Size = New System.Drawing.Size(91, 13)
        Me.lblNoPasajeros.TabIndex = 146
        Me.lblNoPasajeros.Text = "No. de Pasajeros"
        '
        'txtNoPasajeros
        '
        Me.txtNoPasajeros.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoPasajeros.Location = New System.Drawing.Point(423, 52)
        Me.txtNoPasajeros.Name = "txtNoPasajeros"
        Me.txtNoPasajeros.Size = New System.Drawing.Size(222, 20)
        Me.txtNoPasajeros.TabIndex = 10
        '
        'lblUso
        '
        Me.lblUso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUso.AutoSize = True
        Me.lblUso.ForeColor = System.Drawing.Color.White
        Me.lblUso.Location = New System.Drawing.Point(326, 30)
        Me.lblUso.Name = "lblUso"
        Me.lblUso.Size = New System.Drawing.Size(91, 13)
        Me.lblUso.TabIndex = 147
        Me.lblUso.Text = "Uso"
        '
        'cbUso
        '
        Me.cbUso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbUso.FormattingEnabled = True
        Me.cbUso.Items.AddRange(New Object() {"Particular", "Comercial", "Transporte"})
        Me.cbUso.Location = New System.Drawing.Point(423, 27)
        Me.cbUso.Name = "cbUso"
        Me.cbUso.Size = New System.Drawing.Size(222, 21)
        Me.cbUso.TabIndex = 8
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
        Me.btnAgregar.TabIndex = 11
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
        Me.btnEliminar.TabIndex = 13
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
        Me.btnModificar.TabIndex = 12
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'RegistrarVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 237)
        Me.Controls.Add(Me.tblBotones)
        Me.Controls.Add(Me.grpCaracteristicas)
        Me.Controls.Add(Me.tblDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrarVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Vehiculo"
        Me.tblDatos.ResumeLayout(False)
        Me.tblDatos.PerformLayout()
        CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblCaracteristicas.ResumeLayout(False)
        Me.tblCaracteristicas.PerformLayout()
        CType(Me.txtNoPasajeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCaracteristicas.ResumeLayout(False)
        Me.tblBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNoFactura As Label
    Friend WithEvents lblImporte As Label
    Friend WithEvents lblFechaFactura As Label
    Friend WithEvents txtNoFactura As TextBox
    Friend WithEvents lblCurp As Label
    Friend WithEvents txtIdContribuyente As TextBox
    Friend WithEvents lblTipoVehiculo As Label
    Friend WithEvents txtNoSerie As TextBox
    Friend WithEvents lblNoSerie As Label
    Friend WithEvents tblDatos As TableLayoutPanel
    Friend WithEvents txtImporte As NumericUpDown
    Friend WithEvents dateFactura As DateTimePicker
    Friend WithEvents tblCaracteristicas As TableLayoutPanel
    Friend WithEvents cbTipoVehiculo As ComboBox
    Friend WithEvents lblMarcaAuto As Label
    Friend WithEvents cbMarcaAuto As ComboBox
    Friend WithEvents lblTipoCombustible As Label
    Friend WithEvents cbCombustible As ComboBox
    Friend WithEvents lblColor As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtNoPasajeros As NumericUpDown
    Friend WithEvents lblNoPasajeros As Label
    Friend WithEvents grpCaracteristicas As GroupBox
    Friend WithEvents tblBotones As TableLayoutPanel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents lblUso As Label
    Friend WithEvents cbUso As ComboBox
End Class
