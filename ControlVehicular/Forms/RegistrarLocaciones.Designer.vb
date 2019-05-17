<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarLocaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarLocaciones))
        Me.tblBody = New System.Windows.Forms.TableLayoutPanel()
        Me.tblOpciones = New System.Windows.Forms.TableLayoutPanel()
        Me.cbPaises = New System.Windows.Forms.ComboBox()
        Me.cbEstados = New System.Windows.Forms.ComboBox()
        Me.cbCiudades = New System.Windows.Forms.ComboBox()
        Me.cbColonias = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.tcLocaciones = New System.Windows.Forms.TabControl()
        Me.TabPaises = New System.Windows.Forms.TabPage()
        Me.dataPaises = New System.Windows.Forms.DataGridView()
        Me.TabEstados = New System.Windows.Forms.TabPage()
        Me.dataEstados = New System.Windows.Forms.DataGridView()
        Me.TabCiudades = New System.Windows.Forms.TabPage()
        Me.dataCiudades = New System.Windows.Forms.DataGridView()
        Me.TabColonias = New System.Windows.Forms.TabPage()
        Me.dataColonias = New System.Windows.Forms.DataGridView()
        Me.TabDomicilios = New System.Windows.Forms.TabPage()
        Me.dataDomicilios = New System.Windows.Forms.DataGridView()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.NumericUpDown()
        Me.tblBody.SuspendLayout()
        Me.tblOpciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tcLocaciones.SuspendLayout()
        Me.TabPaises.SuspendLayout()
        CType(Me.dataPaises, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEstados.SuspendLayout()
        CType(Me.dataEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCiudades.SuspendLayout()
        CType(Me.dataCiudades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabColonias.SuspendLayout()
        CType(Me.dataColonias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDomicilios.SuspendLayout()
        CType(Me.dataDomicilios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblBody
        '
        Me.tblBody.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblBody.ColumnCount = 2
        Me.tblBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tblBody.Controls.Add(Me.tblOpciones, 0, 0)
        Me.tblBody.Controls.Add(Me.tcLocaciones, 1, 0)
        Me.tblBody.Location = New System.Drawing.Point(12, 12)
        Me.tblBody.Name = "tblBody"
        Me.tblBody.RowCount = 1
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblBody.Size = New System.Drawing.Size(960, 325)
        Me.tblBody.TabIndex = 0
        '
        'tblOpciones
        '
        Me.tblOpciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblOpciones.ColumnCount = 1
        Me.tblOpciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblOpciones.Controls.Add(Me.cbPaises, 0, 0)
        Me.tblOpciones.Controls.Add(Me.cbEstados, 0, 1)
        Me.tblOpciones.Controls.Add(Me.cbCiudades, 0, 2)
        Me.tblOpciones.Controls.Add(Me.cbColonias, 0, 3)
        Me.tblOpciones.Controls.Add(Me.GroupBox1, 0, 4)
        Me.tblOpciones.Controls.Add(Me.btnAgregar, 0, 5)
        Me.tblOpciones.Controls.Add(Me.btnActualizar, 0, 6)
        Me.tblOpciones.Controls.Add(Me.btnEliminar, 0, 7)
        Me.tblOpciones.Location = New System.Drawing.Point(3, 3)
        Me.tblOpciones.Name = "tblOpciones"
        Me.tblOpciones.RowCount = 8
        Me.tblOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblOpciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblOpciones.Size = New System.Drawing.Size(186, 319)
        Me.tblOpciones.TabIndex = 1
        '
        'cbPaises
        '
        Me.cbPaises.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPaises.FormattingEnabled = True
        Me.cbPaises.Location = New System.Drawing.Point(0, 0)
        Me.cbPaises.Margin = New System.Windows.Forms.Padding(0)
        Me.cbPaises.Name = "cbPaises"
        Me.cbPaises.Size = New System.Drawing.Size(186, 21)
        Me.cbPaises.TabIndex = 0
        '
        'cbEstados
        '
        Me.cbEstados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEstados.FormattingEnabled = True
        Me.cbEstados.Location = New System.Drawing.Point(0, 25)
        Me.cbEstados.Margin = New System.Windows.Forms.Padding(0)
        Me.cbEstados.Name = "cbEstados"
        Me.cbEstados.Size = New System.Drawing.Size(186, 21)
        Me.cbEstados.TabIndex = 1
        '
        'cbCiudades
        '
        Me.cbCiudades.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCiudades.FormattingEnabled = True
        Me.cbCiudades.Location = New System.Drawing.Point(0, 50)
        Me.cbCiudades.Margin = New System.Windows.Forms.Padding(0)
        Me.cbCiudades.Name = "cbCiudades"
        Me.cbCiudades.Size = New System.Drawing.Size(186, 21)
        Me.cbCiudades.TabIndex = 2
        '
        'cbColonias
        '
        Me.cbColonias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbColonias.FormattingEnabled = True
        Me.cbColonias.Location = New System.Drawing.Point(0, 75)
        Me.cbColonias.Margin = New System.Windows.Forms.Padding(0)
        Me.cbColonias.Name = "cbColonias"
        Me.cbColonias.Size = New System.Drawing.Size(186, 21)
        Me.cbColonias.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.lblNumero)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 138)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNombre.Location = New System.Drawing.Point(6, 57)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNumero.Location = New System.Drawing.Point(6, 96)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(44, 13)
        Me.lblNumero.TabIndex = 2
        Me.lblNumero.Text = "Numero"
        '
        'txtNumero
        '
        Me.txtNumero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumero.Location = New System.Drawing.Point(6, 112)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(168, 20)
        Me.txtNumero.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(6, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtNombre.TabIndex = 5
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(0, 244)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(186, 23)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(0, 269)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(186, 23)
        Me.btnActualizar.TabIndex = 8
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Location = New System.Drawing.Point(0, 294)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(186, 23)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'tcLocaciones
        '
        Me.tcLocaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcLocaciones.Controls.Add(Me.TabPaises)
        Me.tcLocaciones.Controls.Add(Me.TabEstados)
        Me.tcLocaciones.Controls.Add(Me.TabCiudades)
        Me.tcLocaciones.Controls.Add(Me.TabColonias)
        Me.tcLocaciones.Controls.Add(Me.TabDomicilios)
        Me.tcLocaciones.Location = New System.Drawing.Point(195, 3)
        Me.tcLocaciones.Name = "tcLocaciones"
        Me.tcLocaciones.SelectedIndex = 0
        Me.tcLocaciones.Size = New System.Drawing.Size(762, 319)
        Me.tcLocaciones.TabIndex = 0
        '
        'TabPaises
        '
        Me.TabPaises.Controls.Add(Me.dataPaises)
        Me.TabPaises.Location = New System.Drawing.Point(4, 22)
        Me.TabPaises.Name = "TabPaises"
        Me.TabPaises.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPaises.Size = New System.Drawing.Size(754, 293)
        Me.TabPaises.TabIndex = 0
        Me.TabPaises.Text = "Paises"
        Me.TabPaises.UseVisualStyleBackColor = True
        '
        'dataPaises
        '
        Me.dataPaises.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataPaises.Location = New System.Drawing.Point(6, 6)
        Me.dataPaises.MultiSelect = False
        Me.dataPaises.Name = "dataPaises"
        Me.dataPaises.ReadOnly = True
        Me.dataPaises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataPaises.Size = New System.Drawing.Size(742, 281)
        Me.dataPaises.TabIndex = 0
        '
        'TabEstados
        '
        Me.TabEstados.Controls.Add(Me.dataEstados)
        Me.TabEstados.Location = New System.Drawing.Point(4, 22)
        Me.TabEstados.Name = "TabEstados"
        Me.TabEstados.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEstados.Size = New System.Drawing.Size(754, 248)
        Me.TabEstados.TabIndex = 1
        Me.TabEstados.Text = "Estados"
        Me.TabEstados.UseVisualStyleBackColor = True
        '
        'dataEstados
        '
        Me.dataEstados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataEstados.Location = New System.Drawing.Point(6, 6)
        Me.dataEstados.MultiSelect = False
        Me.dataEstados.Name = "dataEstados"
        Me.dataEstados.ReadOnly = True
        Me.dataEstados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dataEstados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataEstados.Size = New System.Drawing.Size(742, 236)
        Me.dataEstados.TabIndex = 0
        '
        'TabCiudades
        '
        Me.TabCiudades.Controls.Add(Me.dataCiudades)
        Me.TabCiudades.Location = New System.Drawing.Point(4, 22)
        Me.TabCiudades.Name = "TabCiudades"
        Me.TabCiudades.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCiudades.Size = New System.Drawing.Size(754, 248)
        Me.TabCiudades.TabIndex = 2
        Me.TabCiudades.Text = "Ciudades"
        Me.TabCiudades.UseVisualStyleBackColor = True
        '
        'dataCiudades
        '
        Me.dataCiudades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataCiudades.Location = New System.Drawing.Point(6, 6)
        Me.dataCiudades.MultiSelect = False
        Me.dataCiudades.Name = "dataCiudades"
        Me.dataCiudades.ReadOnly = True
        Me.dataCiudades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataCiudades.Size = New System.Drawing.Size(742, 236)
        Me.dataCiudades.TabIndex = 0
        '
        'TabColonias
        '
        Me.TabColonias.Controls.Add(Me.dataColonias)
        Me.TabColonias.Location = New System.Drawing.Point(4, 22)
        Me.TabColonias.Name = "TabColonias"
        Me.TabColonias.Padding = New System.Windows.Forms.Padding(3)
        Me.TabColonias.Size = New System.Drawing.Size(754, 248)
        Me.TabColonias.TabIndex = 3
        Me.TabColonias.Text = "Colonias"
        Me.TabColonias.UseVisualStyleBackColor = True
        '
        'dataColonias
        '
        Me.dataColonias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataColonias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataColonias.Location = New System.Drawing.Point(6, 6)
        Me.dataColonias.MultiSelect = False
        Me.dataColonias.Name = "dataColonias"
        Me.dataColonias.ReadOnly = True
        Me.dataColonias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataColonias.Size = New System.Drawing.Size(742, 236)
        Me.dataColonias.TabIndex = 0
        '
        'TabDomicilios
        '
        Me.TabDomicilios.Controls.Add(Me.dataDomicilios)
        Me.TabDomicilios.Location = New System.Drawing.Point(4, 22)
        Me.TabDomicilios.Name = "TabDomicilios"
        Me.TabDomicilios.Size = New System.Drawing.Size(754, 248)
        Me.TabDomicilios.TabIndex = 4
        Me.TabDomicilios.Text = "Domicilios"
        Me.TabDomicilios.UseVisualStyleBackColor = True
        '
        'dataDomicilios
        '
        Me.dataDomicilios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataDomicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataDomicilios.Location = New System.Drawing.Point(6, 6)
        Me.dataDomicilios.MultiSelect = False
        Me.dataDomicilios.Name = "dataDomicilios"
        Me.dataDomicilios.ReadOnly = True
        Me.dataDomicilios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataDomicilios.Size = New System.Drawing.Size(742, 236)
        Me.dataDomicilios.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblID.Location = New System.Drawing.Point(6, 18)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 34)
        Me.txtID.Maximum = New Decimal(New Integer() {-2147483648, 0, 0, 0})
        Me.txtID.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(168, 20)
        Me.txtID.TabIndex = 1
        Me.txtID.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'RegistrarLocaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 351)
        Me.Controls.Add(Me.tblBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrarLocaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Locaciones"
        Me.tblBody.ResumeLayout(False)
        Me.tblOpciones.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tcLocaciones.ResumeLayout(False)
        Me.TabPaises.ResumeLayout(False)
        CType(Me.dataPaises, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEstados.ResumeLayout(False)
        CType(Me.dataEstados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCiudades.ResumeLayout(False)
        CType(Me.dataCiudades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabColonias.ResumeLayout(False)
        CType(Me.dataColonias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDomicilios.ResumeLayout(False)
        CType(Me.dataDomicilios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblBody As TableLayoutPanel
    Friend WithEvents tblOpciones As TableLayoutPanel
    Friend WithEvents cbPaises As ComboBox
    Friend WithEvents cbEstados As ComboBox
    Friend WithEvents cbCiudades As ComboBox
    Friend WithEvents cbColonias As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents tcLocaciones As TabControl
    Friend WithEvents TabPaises As TabPage
    Friend WithEvents TabEstados As TabPage
    Friend WithEvents TabCiudades As TabPage
    Friend WithEvents TabColonias As TabPage
    Friend WithEvents TabDomicilios As TabPage
    Friend WithEvents dataPaises As DataGridView
    Friend WithEvents dataEstados As DataGridView
    Friend WithEvents dataCiudades As DataGridView
    Friend WithEvents dataColonias As DataGridView
    Friend WithEvents dataDomicilios As DataGridView
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As NumericUpDown
End Class
