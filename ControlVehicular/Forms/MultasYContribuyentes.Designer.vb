<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultasYContribuyentes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultasYContribuyentes))
        Me.NavBar = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabInformation = New System.Windows.Forms.TabControl()
        Me.TabContribuyentes = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.DataContribuyentes = New System.Windows.Forms.DataGridView()
        Me.tlSearchBar = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSearchType = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbSearchType = New System.Windows.Forms.ComboBox()
        Me.txbSearch = New System.Windows.Forms.TextBox()
        Me.TabMultas = New System.Windows.Forms.TabPage()
        Me.TableLayoutMenuOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictContribuyente = New System.Windows.Forms.PictureBox()
        Me.PictVehicle = New System.Windows.Forms.PictureBox()
        Me.PictLicencia = New System.Windows.Forms.PictureBox()
        Me.PictMulta = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictPago = New System.Windows.Forms.PictureBox()
        Me.btnPlacas = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Footer = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusUser = New System.Windows.Forms.StatusStrip()
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUserData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusDate = New System.Windows.Forms.StatusStrip()
        Me.lblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFechaData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSeparatorFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblHoraData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutMenuTitle = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Header = New System.Windows.Forms.FlowLayoutPanel()
        Me.NavBar.SuspendLayout()
        Me.TabInformation.SuspendLayout()
        Me.TabContribuyentes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataContribuyentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlSearchBar.SuspendLayout()
        Me.TableLayoutMenuOptions.SuspendLayout()
        CType(Me.PictContribuyente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictVehicle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictMulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Footer.SuspendLayout()
        Me.StatusUser.SuspendLayout()
        Me.StatusDate.SuspendLayout()
        Me.TableLayoutMenuTitle.SuspendLayout()
        Me.Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'NavBar
        '
        Me.NavBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NavBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.NavBar.Dock = System.Windows.Forms.DockStyle.None
        Me.NavBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.NavBar.Location = New System.Drawing.Point(0, 0)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.Size = New System.Drawing.Size(130, 24)
        Me.NavBar.TabIndex = 0
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.LocalidadesToolStripMenuItem})
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.MenuToolStripMenuItem.Text = "Opciones"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'LocalidadesToolStripMenuItem
        '
        Me.LocalidadesToolStripMenuItem.Name = "LocalidadesToolStripMenuItem"
        Me.LocalidadesToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.LocalidadesToolStripMenuItem.Text = "Localidades"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualToolStripMenuItem})
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'TabInformation
        '
        Me.TabInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabInformation.Controls.Add(Me.TabContribuyentes)
        Me.TabInformation.Controls.Add(Me.TabMultas)
        Me.TabInformation.Location = New System.Drawing.Point(12, 31)
        Me.TabInformation.Name = "TabInformation"
        Me.TabInformation.SelectedIndex = 0
        Me.TabInformation.Size = New System.Drawing.Size(766, 507)
        Me.TabInformation.TabIndex = 1
        '
        'TabContribuyentes
        '
        Me.TabContribuyentes.Controls.Add(Me.GroupBox2)
        Me.TabContribuyentes.Controls.Add(Me.GroupBox1)
        Me.TabContribuyentes.Controls.Add(Me.DataContribuyentes)
        Me.TabContribuyentes.Controls.Add(Me.tlSearchBar)
        Me.TabContribuyentes.Location = New System.Drawing.Point(4, 22)
        Me.TabContribuyentes.Name = "TabContribuyentes"
        Me.TabContribuyentes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabContribuyentes.Size = New System.Drawing.Size(758, 481)
        Me.TabContribuyentes.TabIndex = 0
        Me.TabContribuyentes.Text = "Contribuyentes"
        Me.TabContribuyentes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Location = New System.Drawing.Point(186, 362)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 113)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Periodo"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(6, 85)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 3
        Me.DateTimePicker2.Value = New Date(2019, 5, 2, 23, 32, 9, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha de Corte"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha de Inicio"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 362)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 113)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'RadioButton4
        '
        Me.RadioButton4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 88)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(101, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Sin Infracciones"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 65)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(157, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Sin Infracciones Pendientes"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(131, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Infractores Pendientes"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Todos"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'DataContribuyentes
        '
        Me.DataContribuyentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataContribuyentes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataContribuyentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataContribuyentes.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataContribuyentes.Location = New System.Drawing.Point(6, 42)
        Me.DataContribuyentes.Name = "DataContribuyentes"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataContribuyentes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataContribuyentes.Size = New System.Drawing.Size(746, 314)
        Me.DataContribuyentes.TabIndex = 1
        '
        'tlSearchBar
        '
        Me.tlSearchBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlSearchBar.ColumnCount = 4
        Me.tlSearchBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.tlSearchBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlSearchBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlSearchBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlSearchBar.Controls.Add(Me.lblSearchType, 0, 0)
        Me.tlSearchBar.Controls.Add(Me.btnSearch, 2, 0)
        Me.tlSearchBar.Controls.Add(Me.cbSearchType, 1, 0)
        Me.tlSearchBar.Controls.Add(Me.txbSearch, 3, 0)
        Me.tlSearchBar.Location = New System.Drawing.Point(6, 6)
        Me.tlSearchBar.Name = "tlSearchBar"
        Me.tlSearchBar.RowCount = 1
        Me.tlSearchBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlSearchBar.Size = New System.Drawing.Size(746, 30)
        Me.tlSearchBar.TabIndex = 0
        '
        'lblSearchType
        '
        Me.lblSearchType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSearchType.AutoSize = True
        Me.lblSearchType.Location = New System.Drawing.Point(3, 8)
        Me.lblSearchType.Name = "lblSearchType"
        Me.lblSearchType.Size = New System.Drawing.Size(99, 13)
        Me.lblSearchType.TabIndex = 0
        Me.lblSearchType.Text = "Tipo de Busqueda:"
        Me.lblSearchType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(208, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(94, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Buscar"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbSearchType
        '
        Me.cbSearchType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSearchType.FormattingEnabled = True
        Me.cbSearchType.Items.AddRange(New Object() {"Nombre", "Licencia", "Matricula"})
        Me.cbSearchType.Location = New System.Drawing.Point(108, 4)
        Me.cbSearchType.Name = "cbSearchType"
        Me.cbSearchType.Size = New System.Drawing.Size(94, 21)
        Me.cbSearchType.TabIndex = 2
        '
        'txbSearch
        '
        Me.txbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbSearch.Location = New System.Drawing.Point(308, 5)
        Me.txbSearch.Name = "txbSearch"
        Me.txbSearch.Size = New System.Drawing.Size(435, 20)
        Me.txbSearch.TabIndex = 3
        '
        'TabMultas
        '
        Me.TabMultas.Location = New System.Drawing.Point(4, 22)
        Me.TabMultas.Name = "TabMultas"
        Me.TabMultas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMultas.Size = New System.Drawing.Size(758, 481)
        Me.TabMultas.TabIndex = 1
        Me.TabMultas.Text = "Multas"
        Me.TabMultas.UseVisualStyleBackColor = True
        '
        'TableLayoutMenuOptions
        '
        Me.TableLayoutMenuOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutMenuOptions.ColumnCount = 2
        Me.TableLayoutMenuOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutMenuOptions.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutMenuOptions.Controls.Add(Me.Button2, 1, 1)
        Me.TableLayoutMenuOptions.Controls.Add(Me.Button4, 1, 3)
        Me.TableLayoutMenuOptions.Controls.Add(Me.Button3, 1, 2)
        Me.TableLayoutMenuOptions.Controls.Add(Me.PictContribuyente, 0, 0)
        Me.TableLayoutMenuOptions.Controls.Add(Me.PictVehicle, 0, 1)
        Me.TableLayoutMenuOptions.Controls.Add(Me.PictLicencia, 0, 2)
        Me.TableLayoutMenuOptions.Controls.Add(Me.PictMulta, 0, 3)
        Me.TableLayoutMenuOptions.Controls.Add(Me.Button5, 1, 6)
        Me.TableLayoutMenuOptions.Controls.Add(Me.PictPago, 0, 6)
        Me.TableLayoutMenuOptions.Controls.Add(Me.btnPlacas, 1, 4)
        Me.TableLayoutMenuOptions.Controls.Add(Me.PictureBox1, 0, 4)
        Me.TableLayoutMenuOptions.Location = New System.Drawing.Point(784, 63)
        Me.TableLayoutMenuOptions.Name = "TableLayoutMenuOptions"
        Me.TableLayoutMenuOptions.RowCount = 7
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.Size = New System.Drawing.Size(200, 475)
        Me.TableLayoutMenuOptions.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(33, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Registrar Contribuyente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(33, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Registrar Vehiculos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(33, 93)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(164, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Registrar Multa"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(33, 63)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(164, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Registrar Licencias"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictContribuyente
        '
        Me.PictContribuyente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictContribuyente.BackgroundImage = Global.ControlVehicular.My.Resources.Resources.user
        Me.PictContribuyente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictContribuyente.Location = New System.Drawing.Point(3, 3)
        Me.PictContribuyente.Name = "PictContribuyente"
        Me.PictContribuyente.Size = New System.Drawing.Size(24, 24)
        Me.PictContribuyente.TabIndex = 8
        Me.PictContribuyente.TabStop = False
        '
        'PictVehicle
        '
        Me.PictVehicle.BackgroundImage = Global.ControlVehicular.My.Resources.Resources.car
        Me.PictVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictVehicle.Location = New System.Drawing.Point(3, 33)
        Me.PictVehicle.Name = "PictVehicle"
        Me.PictVehicle.Size = New System.Drawing.Size(24, 24)
        Me.PictVehicle.TabIndex = 9
        Me.PictVehicle.TabStop = False
        '
        'PictLicencia
        '
        Me.PictLicencia.BackgroundImage = Global.ControlVehicular.My.Resources.Resources.id_card
        Me.PictLicencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictLicencia.Location = New System.Drawing.Point(3, 63)
        Me.PictLicencia.Name = "PictLicencia"
        Me.PictLicencia.Size = New System.Drawing.Size(24, 24)
        Me.PictLicencia.TabIndex = 10
        Me.PictLicencia.TabStop = False
        '
        'PictMulta
        '
        Me.PictMulta.BackgroundImage = Global.ControlVehicular.My.Resources.Resources.receipt
        Me.PictMulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictMulta.Location = New System.Drawing.Point(3, 93)
        Me.PictMulta.Name = "PictMulta"
        Me.PictMulta.Size = New System.Drawing.Size(24, 24)
        Me.PictMulta.TabIndex = 11
        Me.PictMulta.TabStop = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(33, 448)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(164, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Pago Multa"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictPago
        '
        Me.PictPago.BackgroundImage = Global.ControlVehicular.My.Resources.Resources.purse
        Me.PictPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictPago.Location = New System.Drawing.Point(3, 448)
        Me.PictPago.Name = "PictPago"
        Me.PictPago.Size = New System.Drawing.Size(24, 24)
        Me.PictPago.TabIndex = 12
        Me.PictPago.TabStop = False
        '
        'btnPlacas
        '
        Me.btnPlacas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPlacas.Location = New System.Drawing.Point(33, 123)
        Me.btnPlacas.Name = "btnPlacas"
        Me.btnPlacas.Size = New System.Drawing.Size(164, 23)
        Me.btnPlacas.TabIndex = 13
        Me.btnPlacas.Text = "Registrar Placas"
        Me.btnPlacas.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ControlVehicular.My.Resources.Resources.matricula
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 123)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Footer
        '
        Me.Footer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Footer.ColumnCount = 2
        Me.Footer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Footer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.Footer.Controls.Add(Me.StatusUser, 0, 0)
        Me.Footer.Controls.Add(Me.StatusDate, 1, 0)
        Me.Footer.Location = New System.Drawing.Point(0, 541)
        Me.Footer.Name = "Footer"
        Me.Footer.RowCount = 1
        Me.Footer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Footer.Size = New System.Drawing.Size(984, 20)
        Me.Footer.TabIndex = 8
        '
        'StatusUser
        '
        Me.StatusUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.StatusUser.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUser, Me.lblUserData})
        Me.StatusUser.Location = New System.Drawing.Point(0, 0)
        Me.StatusUser.Name = "StatusUser"
        Me.StatusUser.Size = New System.Drawing.Size(784, 22)
        Me.StatusUser.TabIndex = 0
        Me.StatusUser.Text = "StatusStrip1"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(55, 17)
        Me.lblUser.Text = "Usuario: "
        '
        'lblUserData
        '
        Me.lblUserData.ForeColor = System.Drawing.Color.White
        Me.lblUserData.Name = "lblUserData"
        Me.lblUserData.Size = New System.Drawing.Size(87, 17)
        Me.lblUserData.Text = "****************"
        '
        'StatusDate
        '
        Me.StatusDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.StatusDate.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusDate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFecha, Me.lblFechaData, Me.lblSeparatorFecha, Me.lblHora, Me.lblHoraData})
        Me.StatusDate.Location = New System.Drawing.Point(784, 0)
        Me.StatusDate.Name = "StatusDate"
        Me.StatusDate.Size = New System.Drawing.Size(200, 22)
        Me.StatusDate.TabIndex = 1
        Me.StatusDate.Text = "Fecha"
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(42, 17)
        Me.lblFecha.Text = "Fecha:"
        '
        'lblFechaData
        '
        Me.lblFechaData.ForeColor = System.Drawing.Color.White
        Me.lblFechaData.Name = "lblFechaData"
        Me.lblFechaData.Size = New System.Drawing.Size(53, 17)
        Me.lblFechaData.Text = "00/00/00"
        '
        'lblSeparatorFecha
        '
        Me.lblSeparatorFecha.ForeColor = System.Drawing.Color.White
        Me.lblSeparatorFecha.Name = "lblSeparatorFecha"
        Me.lblSeparatorFecha.Size = New System.Drawing.Size(10, 17)
        Me.lblSeparatorFecha.Text = "|"
        '
        'lblHora
        '
        Me.lblHora.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(40, 17)
        Me.lblHora.Text = "Hora: "
        '
        'lblHoraData
        '
        Me.lblHoraData.ForeColor = System.Drawing.Color.White
        Me.lblHoraData.Name = "lblHoraData"
        Me.lblHoraData.Size = New System.Drawing.Size(34, 17)
        Me.lblHoraData.Text = "00:00"
        '
        'TableLayoutMenuTitle
        '
        Me.TableLayoutMenuTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutMenuTitle.ColumnCount = 1
        Me.TableLayoutMenuTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutMenuTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutMenuTitle.Controls.Add(Me.lblMenu, 0, 0)
        Me.TableLayoutMenuTitle.Location = New System.Drawing.Point(784, 31)
        Me.TableLayoutMenuTitle.Name = "TableLayoutMenuTitle"
        Me.TableLayoutMenuTitle.RowCount = 1
        Me.TableLayoutMenuTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutMenuTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutMenuTitle.Size = New System.Drawing.Size(200, 26)
        Me.TableLayoutMenuTitle.TabIndex = 9
        '
        'lblMenu
        '
        Me.lblMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Brush Script MT", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMenu.Location = New System.Drawing.Point(3, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(194, 26)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Menu"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Header
        '
        Me.Header.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Header.Controls.Add(Me.NavBar)
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(984, 25)
        Me.Header.TabIndex = 4
        '
        'MultasYContribuyentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.TableLayoutMenuTitle)
        Me.Controls.Add(Me.Footer)
        Me.Controls.Add(Me.TableLayoutMenuOptions)
        Me.Controls.Add(Me.TabInformation)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.NavBar
        Me.Name = "MultasYContribuyentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multas y Contribuyentes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.NavBar.ResumeLayout(False)
        Me.NavBar.PerformLayout()
        Me.TabInformation.ResumeLayout(False)
        Me.TabContribuyentes.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataContribuyentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlSearchBar.ResumeLayout(False)
        Me.tlSearchBar.PerformLayout()
        Me.TableLayoutMenuOptions.ResumeLayout(False)
        CType(Me.PictContribuyente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictVehicle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictMulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Footer.ResumeLayout(False)
        Me.Footer.PerformLayout()
        Me.StatusUser.ResumeLayout(False)
        Me.StatusUser.PerformLayout()
        Me.StatusDate.ResumeLayout(False)
        Me.StatusDate.PerformLayout()
        Me.TableLayoutMenuTitle.ResumeLayout(False)
        Me.TableLayoutMenuTitle.PerformLayout()
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavBar As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabInformation As TabControl
    Friend WithEvents TabContribuyentes As TabPage
    Friend WithEvents TabMultas As TabPage
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutMenuOptions As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Footer As TableLayoutPanel
    Friend WithEvents StatusUser As StatusStrip
    Friend WithEvents lblUser As ToolStripStatusLabel
    Friend WithEvents lblUserData As ToolStripStatusLabel
    Friend WithEvents StatusDate As StatusStrip
    Friend WithEvents lblFecha As ToolStripStatusLabel
    Friend WithEvents lblFechaData As ToolStripStatusLabel
    Friend WithEvents lblSeparatorFecha As ToolStripStatusLabel
    Friend WithEvents lblHora As ToolStripStatusLabel
    Friend WithEvents lblHoraData As ToolStripStatusLabel
    Friend WithEvents TableLayoutMenuTitle As TableLayoutPanel
    Friend WithEvents lblMenu As Label
    Friend WithEvents PictContribuyente As PictureBox
    Friend WithEvents PictVehicle As PictureBox
    Friend WithEvents PictLicencia As PictureBox
    Friend WithEvents PictMulta As PictureBox
    Friend WithEvents PictPago As PictureBox
    Friend WithEvents tlSearchBar As TableLayoutPanel
    Friend WithEvents lblSearchType As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents cbSearchType As ComboBox
    Friend WithEvents txbSearch As TextBox
    Friend WithEvents DataContribuyentes As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Header As FlowLayoutPanel
    Friend WithEvents btnPlacas As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
