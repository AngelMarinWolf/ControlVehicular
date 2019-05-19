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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultasYContribuyentes))
        Me.NavBar = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabInformation = New System.Windows.Forms.TabControl()
        Me.TabContribuyentes = New System.Windows.Forms.TabPage()
        Me.grpOpciones = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.grpLocalidades = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbPaises = New System.Windows.Forms.ComboBox()
        Me.cbEstados = New System.Windows.Forms.ComboBox()
        Me.cbCiudades = New System.Windows.Forms.ComboBox()
        Me.cbColonias = New System.Windows.Forms.ComboBox()
        Me.grpFiltros = New System.Windows.Forms.GroupBox()
        Me.rbNoInfractores = New System.Windows.Forms.RadioButton()
        Me.rbInfractoresLibres = New System.Windows.Forms.RadioButton()
        Me.rbInfractoresPendientes = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.DataContribuyentes = New System.Windows.Forms.DataGridView()
        Me.tlSearchBar = New System.Windows.Forms.TableLayoutPanel()
        Me.cbTipoBusqueda = New System.Windows.Forms.ComboBox()
        Me.lblSearchType = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.TabMultas = New System.Windows.Forms.TabPage()
        Me.grpOpcionesMultas = New System.Windows.Forms.GroupBox()
        Me.tblOpcionesMultas = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregarMulta = New System.Windows.Forms.Button()
        Me.btnModificarMulta = New System.Windows.Forms.Button()
        Me.btnEliminarMultas = New System.Windows.Forms.Button()
        Me.grpFechas = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblInitDate = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.dateInit = New System.Windows.Forms.DateTimePicker()
        Me.dateEnd = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.rbMultasSinPagar = New System.Windows.Forms.RadioButton()
        Me.rbTodosMultas = New System.Windows.Forms.RadioButton()
        Me.rbMultasPagadas = New System.Windows.Forms.RadioButton()
        Me.DataMultas = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbTiposSearchMultas = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscarMultas = New System.Windows.Forms.Button()
        Me.txtSearchMultas = New System.Windows.Forms.TextBox()
        Me.TableLayoutMenuOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.PictVehicle = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictLicencia = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPlacas = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictMulta = New System.Windows.Forms.PictureBox()
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
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.NavBar.SuspendLayout()
        Me.TabInformation.SuspendLayout()
        Me.TabContribuyentes.SuspendLayout()
        Me.grpOpciones.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grpLocalidades.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpFiltros.SuspendLayout()
        CType(Me.DataContribuyentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlSearchBar.SuspendLayout()
        Me.TabMultas.SuspendLayout()
        Me.grpOpcionesMultas.SuspendLayout()
        Me.tblOpcionesMultas.SuspendLayout()
        Me.grpFechas.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.DataMultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutMenuOptions.SuspendLayout()
        CType(Me.PictVehicle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictMulta, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabContribuyentes.Controls.Add(Me.grpOpciones)
        Me.TabContribuyentes.Controls.Add(Me.grpLocalidades)
        Me.TabContribuyentes.Controls.Add(Me.grpFiltros)
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
        'grpOpciones
        '
        Me.grpOpciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOpciones.Controls.Add(Me.TableLayoutPanel2)
        Me.grpOpciones.Location = New System.Drawing.Point(648, 362)
        Me.grpOpciones.Name = "grpOpciones"
        Me.grpOpciones.Size = New System.Drawing.Size(104, 113)
        Me.grpOpciones.TabIndex = 4
        Me.grpOpciones.TabStop = False
        Me.grpOpciones.Text = "Opciones"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnAgregar, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnModificar, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnEliminar, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(92, 88)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(3, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(86, 23)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Location = New System.Drawing.Point(3, 32)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(86, 23)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.DarkRed
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(3, 61)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(86, 23)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'grpLocalidades
        '
        Me.grpLocalidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLocalidades.Controls.Add(Me.TableLayoutPanel1)
        Me.grpLocalidades.Location = New System.Drawing.Point(186, 362)
        Me.grpLocalidades.Name = "grpLocalidades"
        Me.grpLocalidades.Size = New System.Drawing.Size(456, 113)
        Me.grpLocalidades.TabIndex = 3
        Me.grpLocalidades.TabStop = False
        Me.grpLocalidades.Text = "Localidades"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbPaises, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbEstados, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbCiudades, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cbColonias, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(444, 88)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paises"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ciudades"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estados"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(225, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Colonias"
        '
        'cbPaises
        '
        Me.cbPaises.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPaises.FormattingEnabled = True
        Me.cbPaises.Location = New System.Drawing.Point(3, 19)
        Me.cbPaises.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.cbPaises.Name = "cbPaises"
        Me.cbPaises.Size = New System.Drawing.Size(216, 21)
        Me.cbPaises.TabIndex = 4
        '
        'cbEstados
        '
        Me.cbEstados.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEstados.FormattingEnabled = True
        Me.cbEstados.Location = New System.Drawing.Point(225, 19)
        Me.cbEstados.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.cbEstados.Name = "cbEstados"
        Me.cbEstados.Size = New System.Drawing.Size(216, 21)
        Me.cbEstados.TabIndex = 5
        '
        'cbCiudades
        '
        Me.cbCiudades.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCiudades.FormattingEnabled = True
        Me.cbCiudades.Location = New System.Drawing.Point(3, 63)
        Me.cbCiudades.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.cbCiudades.Name = "cbCiudades"
        Me.cbCiudades.Size = New System.Drawing.Size(216, 21)
        Me.cbCiudades.TabIndex = 6
        '
        'cbColonias
        '
        Me.cbColonias.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbColonias.FormattingEnabled = True
        Me.cbColonias.Location = New System.Drawing.Point(225, 63)
        Me.cbColonias.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.cbColonias.Name = "cbColonias"
        Me.cbColonias.Size = New System.Drawing.Size(216, 21)
        Me.cbColonias.TabIndex = 7
        '
        'grpFiltros
        '
        Me.grpFiltros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpFiltros.Controls.Add(Me.rbNoInfractores)
        Me.grpFiltros.Controls.Add(Me.rbInfractoresLibres)
        Me.grpFiltros.Controls.Add(Me.rbInfractoresPendientes)
        Me.grpFiltros.Controls.Add(Me.rbTodos)
        Me.grpFiltros.Location = New System.Drawing.Point(6, 362)
        Me.grpFiltros.Name = "grpFiltros"
        Me.grpFiltros.Size = New System.Drawing.Size(174, 113)
        Me.grpFiltros.TabIndex = 2
        Me.grpFiltros.TabStop = False
        Me.grpFiltros.Text = "Filtros"
        '
        'rbNoInfractores
        '
        Me.rbNoInfractores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbNoInfractores.AutoSize = True
        Me.rbNoInfractores.Location = New System.Drawing.Point(6, 88)
        Me.rbNoInfractores.Name = "rbNoInfractores"
        Me.rbNoInfractores.Size = New System.Drawing.Size(101, 17)
        Me.rbNoInfractores.TabIndex = 3
        Me.rbNoInfractores.Text = "Sin Infracciones"
        Me.rbNoInfractores.UseVisualStyleBackColor = True
        '
        'rbInfractoresLibres
        '
        Me.rbInfractoresLibres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbInfractoresLibres.AutoSize = True
        Me.rbInfractoresLibres.Location = New System.Drawing.Point(6, 65)
        Me.rbInfractoresLibres.Name = "rbInfractoresLibres"
        Me.rbInfractoresLibres.Size = New System.Drawing.Size(157, 17)
        Me.rbInfractoresLibres.TabIndex = 2
        Me.rbInfractoresLibres.Text = "Sin Infracciones Pendientes"
        Me.rbInfractoresLibres.UseVisualStyleBackColor = True
        '
        'rbInfractoresPendientes
        '
        Me.rbInfractoresPendientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbInfractoresPendientes.AutoSize = True
        Me.rbInfractoresPendientes.Location = New System.Drawing.Point(6, 42)
        Me.rbInfractoresPendientes.Name = "rbInfractoresPendientes"
        Me.rbInfractoresPendientes.Size = New System.Drawing.Size(131, 17)
        Me.rbInfractoresPendientes.TabIndex = 1
        Me.rbInfractoresPendientes.Text = "Infractores Pendientes"
        Me.rbInfractoresPendientes.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(6, 19)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbTodos.TabIndex = 0
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'DataContribuyentes
        '
        Me.DataContribuyentes.AllowUserToAddRows = False
        Me.DataContribuyentes.AllowUserToDeleteRows = False
        Me.DataContribuyentes.AllowUserToOrderColumns = True
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
        Me.DataContribuyentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
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
        Me.tlSearchBar.Controls.Add(Me.cbTipoBusqueda, 1, 0)
        Me.tlSearchBar.Controls.Add(Me.lblSearchType, 0, 0)
        Me.tlSearchBar.Controls.Add(Me.btnSearch, 2, 0)
        Me.tlSearchBar.Controls.Add(Me.txtSearch, 3, 0)
        Me.tlSearchBar.Location = New System.Drawing.Point(6, 6)
        Me.tlSearchBar.Name = "tlSearchBar"
        Me.tlSearchBar.RowCount = 1
        Me.tlSearchBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlSearchBar.Size = New System.Drawing.Size(746, 30)
        Me.tlSearchBar.TabIndex = 0
        '
        'cbTipoBusqueda
        '
        Me.cbTipoBusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipoBusqueda.FormattingEnabled = True
        Me.cbTipoBusqueda.Items.AddRange(New Object() {"Nombre", "CURP", "Apellido"})
        Me.cbTipoBusqueda.Location = New System.Drawing.Point(108, 4)
        Me.cbTipoBusqueda.Name = "cbTipoBusqueda"
        Me.cbTipoBusqueda.Size = New System.Drawing.Size(94, 21)
        Me.cbTipoBusqueda.TabIndex = 4
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
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(308, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(435, 20)
        Me.txtSearch.TabIndex = 3
        '
        'TabMultas
        '
        Me.TabMultas.Controls.Add(Me.grpOpcionesMultas)
        Me.TabMultas.Controls.Add(Me.grpFechas)
        Me.TabMultas.Controls.Add(Me.GroupBox1)
        Me.TabMultas.Controls.Add(Me.DataMultas)
        Me.TabMultas.Controls.Add(Me.TableLayoutPanel3)
        Me.TabMultas.Location = New System.Drawing.Point(4, 22)
        Me.TabMultas.Name = "TabMultas"
        Me.TabMultas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMultas.Size = New System.Drawing.Size(758, 481)
        Me.TabMultas.TabIndex = 1
        Me.TabMultas.Text = "Multas"
        Me.TabMultas.UseVisualStyleBackColor = True
        '
        'grpOpcionesMultas
        '
        Me.grpOpcionesMultas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOpcionesMultas.Controls.Add(Me.tblOpcionesMultas)
        Me.grpOpcionesMultas.Location = New System.Drawing.Point(648, 362)
        Me.grpOpcionesMultas.Name = "grpOpcionesMultas"
        Me.grpOpcionesMultas.Size = New System.Drawing.Size(104, 113)
        Me.grpOpcionesMultas.TabIndex = 5
        Me.grpOpcionesMultas.TabStop = False
        Me.grpOpcionesMultas.Text = "Opciones"
        '
        'tblOpcionesMultas
        '
        Me.tblOpcionesMultas.ColumnCount = 1
        Me.tblOpcionesMultas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblOpcionesMultas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblOpcionesMultas.Controls.Add(Me.btnAgregarMulta, 0, 0)
        Me.tblOpcionesMultas.Controls.Add(Me.btnModificarMulta, 0, 1)
        Me.tblOpcionesMultas.Controls.Add(Me.btnEliminarMultas, 0, 2)
        Me.tblOpcionesMultas.Location = New System.Drawing.Point(6, 19)
        Me.tblOpcionesMultas.Name = "tblOpcionesMultas"
        Me.tblOpcionesMultas.RowCount = 3
        Me.tblOpcionesMultas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblOpcionesMultas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblOpcionesMultas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblOpcionesMultas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblOpcionesMultas.Size = New System.Drawing.Size(92, 88)
        Me.tblOpcionesMultas.TabIndex = 0
        '
        'btnAgregarMulta
        '
        Me.btnAgregarMulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarMulta.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarMulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarMulta.Location = New System.Drawing.Point(3, 3)
        Me.btnAgregarMulta.Name = "btnAgregarMulta"
        Me.btnAgregarMulta.Size = New System.Drawing.Size(86, 23)
        Me.btnAgregarMulta.TabIndex = 0
        Me.btnAgregarMulta.Text = "Agregar"
        Me.btnAgregarMulta.UseVisualStyleBackColor = False
        '
        'btnModificarMulta
        '
        Me.btnModificarMulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificarMulta.BackColor = System.Drawing.Color.SteelBlue
        Me.btnModificarMulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarMulta.Location = New System.Drawing.Point(3, 32)
        Me.btnModificarMulta.Name = "btnModificarMulta"
        Me.btnModificarMulta.Size = New System.Drawing.Size(86, 23)
        Me.btnModificarMulta.TabIndex = 1
        Me.btnModificarMulta.Text = "Modificar"
        Me.btnModificarMulta.UseVisualStyleBackColor = False
        '
        'btnEliminarMultas
        '
        Me.btnEliminarMultas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarMultas.BackColor = System.Drawing.Color.DarkRed
        Me.btnEliminarMultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarMultas.Location = New System.Drawing.Point(3, 61)
        Me.btnEliminarMultas.Name = "btnEliminarMultas"
        Me.btnEliminarMultas.Size = New System.Drawing.Size(86, 23)
        Me.btnEliminarMultas.TabIndex = 2
        Me.btnEliminarMultas.Text = "Eliminar"
        Me.btnEliminarMultas.UseVisualStyleBackColor = False
        '
        'grpFechas
        '
        Me.grpFechas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpFechas.Controls.Add(Me.TableLayoutPanel4)
        Me.grpFechas.Location = New System.Drawing.Point(186, 362)
        Me.grpFechas.Name = "grpFechas"
        Me.grpFechas.Size = New System.Drawing.Size(250, 113)
        Me.grpFechas.TabIndex = 4
        Me.grpFechas.TabStop = False
        Me.grpFechas.Text = "Fechas de Emision"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblInitDate, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblEndDate, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.dateInit, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.dateEnd, 0, 3)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(238, 88)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'lblInitDate
        '
        Me.lblInitDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblInitDate.AutoSize = True
        Me.lblInitDate.Location = New System.Drawing.Point(3, 2)
        Me.lblInitDate.Name = "lblInitDate"
        Me.lblInitDate.Size = New System.Drawing.Size(65, 13)
        Me.lblInitDate.TabIndex = 0
        Me.lblInitDate.Text = "Fecha Inicio"
        '
        'lblEndDate
        '
        Me.lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(3, 45)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(93, 13)
        Me.lblEndDate.TabIndex = 1
        Me.lblEndDate.Text = "Fecha de Termino"
        '
        'dateInit
        '
        Me.dateInit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateInit.Location = New System.Drawing.Point(3, 20)
        Me.dateInit.Name = "dateInit"
        Me.dateInit.Size = New System.Drawing.Size(232, 20)
        Me.dateInit.TabIndex = 2
        '
        'dateEnd
        '
        Me.dateEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateEnd.Location = New System.Drawing.Point(3, 64)
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.Size = New System.Drawing.Size(232, 20)
        Me.dateEnd.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel6)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 362)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 113)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.rbMultasSinPagar, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.rbTodosMultas, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.rbMultasPagadas, 0, 1)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(162, 88)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'rbMultasSinPagar
        '
        Me.rbMultasSinPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbMultasSinPagar.AutoSize = True
        Me.rbMultasSinPagar.Location = New System.Drawing.Point(3, 64)
        Me.rbMultasSinPagar.Name = "rbMultasSinPagar"
        Me.rbMultasSinPagar.Size = New System.Drawing.Size(156, 17)
        Me.rbMultasSinPagar.TabIndex = 2
        Me.rbMultasSinPagar.Text = "Sin Pagar"
        Me.rbMultasSinPagar.UseVisualStyleBackColor = True
        '
        'rbTodosMultas
        '
        Me.rbTodosMultas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbTodosMultas.AutoSize = True
        Me.rbTodosMultas.Checked = True
        Me.rbTodosMultas.Location = New System.Drawing.Point(3, 6)
        Me.rbTodosMultas.Name = "rbTodosMultas"
        Me.rbTodosMultas.Size = New System.Drawing.Size(156, 17)
        Me.rbTodosMultas.TabIndex = 0
        Me.rbTodosMultas.TabStop = True
        Me.rbTodosMultas.Text = "Todos"
        Me.rbTodosMultas.UseVisualStyleBackColor = True
        '
        'rbMultasPagadas
        '
        Me.rbMultasPagadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbMultasPagadas.AutoSize = True
        Me.rbMultasPagadas.Location = New System.Drawing.Point(3, 35)
        Me.rbMultasPagadas.Name = "rbMultasPagadas"
        Me.rbMultasPagadas.Size = New System.Drawing.Size(156, 17)
        Me.rbMultasPagadas.TabIndex = 1
        Me.rbMultasPagadas.Text = "Pagadas"
        Me.rbMultasPagadas.UseVisualStyleBackColor = True
        '
        'DataMultas
        '
        Me.DataMultas.AllowUserToAddRows = False
        Me.DataMultas.AllowUserToDeleteRows = False
        Me.DataMultas.AllowUserToOrderColumns = True
        Me.DataMultas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataMultas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataMultas.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataMultas.Location = New System.Drawing.Point(6, 42)
        Me.DataMultas.Name = "DataMultas"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataMultas.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataMultas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataMultas.Size = New System.Drawing.Size(746, 314)
        Me.DataMultas.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.cbTiposSearchMultas, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnBuscarMultas, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtSearchMultas, 3, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(746, 30)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'cbTiposSearchMultas
        '
        Me.cbTiposSearchMultas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTiposSearchMultas.FormattingEnabled = True
        Me.cbTiposSearchMultas.Items.AddRange(New Object() {"Placas", "Licencia", "Curp"})
        Me.cbTiposSearchMultas.Location = New System.Drawing.Point(108, 4)
        Me.cbTiposSearchMultas.Name = "cbTiposSearchMultas"
        Me.cbTiposSearchMultas.Size = New System.Drawing.Size(94, 21)
        Me.cbTiposSearchMultas.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tipo de Busqueda:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBuscarMultas
        '
        Me.btnBuscarMultas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarMultas.Location = New System.Drawing.Point(208, 3)
        Me.btnBuscarMultas.Name = "btnBuscarMultas"
        Me.btnBuscarMultas.Size = New System.Drawing.Size(94, 23)
        Me.btnBuscarMultas.TabIndex = 1
        Me.btnBuscarMultas.Text = "Buscar"
        Me.btnBuscarMultas.UseVisualStyleBackColor = True
        '
        'txtSearchMultas
        '
        Me.txtSearchMultas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchMultas.Location = New System.Drawing.Point(308, 5)
        Me.txtSearchMultas.Name = "txtSearchMultas"
        Me.txtSearchMultas.Size = New System.Drawing.Size(435, 20)
        Me.txtSearchMultas.TabIndex = 3
        '
        'TableLayoutMenuOptions
        '
        Me.TableLayoutMenuOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutMenuOptions.ColumnCount = 2
        Me.TableLayoutMenuOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutMenuOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.Controls.Add(Me.PictVehicle, 1, 0)
        Me.TableLayoutMenuOptions.Controls.Add(Me.Button3, 0, 1)
        Me.TableLayoutMenuOptions.Controls.Add(Me.PictLicencia, 1, 1)
        Me.TableLayoutMenuOptions.Controls.Add(Me.PictureBox1, 1, 2)
        Me.TableLayoutMenuOptions.Controls.Add(Me.btnPlacas, 0, 2)
        Me.TableLayoutMenuOptions.Controls.Add(Me.Button5, 0, 4)
        Me.TableLayoutMenuOptions.Controls.Add(Me.Button2, 0, 0)
        Me.TableLayoutMenuOptions.Controls.Add(Me.PictMulta, 1, 4)
        Me.TableLayoutMenuOptions.Location = New System.Drawing.Point(784, 63)
        Me.TableLayoutMenuOptions.Name = "TableLayoutMenuOptions"
        Me.TableLayoutMenuOptions.RowCount = 5
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutMenuOptions.Size = New System.Drawing.Size(200, 475)
        Me.TableLayoutMenuOptions.TabIndex = 2
        '
        'PictVehicle
        '
        Me.PictVehicle.BackgroundImage = Global.ControlVehicular.My.Resources.Resources.car
        Me.PictVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictVehicle.Location = New System.Drawing.Point(173, 3)
        Me.PictVehicle.Name = "PictVehicle"
        Me.PictVehicle.Size = New System.Drawing.Size(24, 24)
        Me.PictVehicle.TabIndex = 9
        Me.PictVehicle.TabStop = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(3, 33)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(164, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Registrar Licencias"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictLicencia
        '
        Me.PictLicencia.BackgroundImage = Global.ControlVehicular.My.Resources.Resources.id_card
        Me.PictLicencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictLicencia.Location = New System.Drawing.Point(173, 33)
        Me.PictLicencia.Name = "PictLicencia"
        Me.PictLicencia.Size = New System.Drawing.Size(24, 24)
        Me.PictLicencia.TabIndex = 10
        Me.PictLicencia.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ControlVehicular.My.Resources.Resources.matricula
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(173, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnPlacas
        '
        Me.btnPlacas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPlacas.Location = New System.Drawing.Point(3, 63)
        Me.btnPlacas.Name = "btnPlacas"
        Me.btnPlacas.Size = New System.Drawing.Size(164, 23)
        Me.btnPlacas.TabIndex = 13
        Me.btnPlacas.Text = "Registrar Placas"
        Me.btnPlacas.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(3, 448)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(164, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Pago Multa"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Registrar Vehiculos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictMulta
        '
        Me.PictMulta.BackgroundImage = Global.ControlVehicular.My.Resources.Resources.receipt
        Me.PictMulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictMulta.Location = New System.Drawing.Point(173, 448)
        Me.PictMulta.Name = "PictMulta"
        Me.PictMulta.Size = New System.Drawing.Size(24, 24)
        Me.PictMulta.TabIndex = 11
        Me.PictMulta.TabStop = False
        '
        'Footer
        '
        Me.Footer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Footer.ColumnCount = 2
        Me.Footer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Footer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
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
        Me.StatusUser.Size = New System.Drawing.Size(754, 22)
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
        Me.StatusDate.Location = New System.Drawing.Point(754, 0)
        Me.StatusDate.Name = "StatusDate"
        Me.StatusDate.Size = New System.Drawing.Size(230, 22)
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
        Me.lblHoraData.Size = New System.Drawing.Size(60, 17)
        Me.lblHoraData.Text = "00:00 a.m."
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
        'Timer
        '
        Me.Timer.Enabled = True
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
        Me.grpOpciones.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.grpLocalidades.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.grpFiltros.ResumeLayout(False)
        Me.grpFiltros.PerformLayout()
        CType(Me.DataContribuyentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlSearchBar.ResumeLayout(False)
        Me.tlSearchBar.PerformLayout()
        Me.TabMultas.ResumeLayout(False)
        Me.grpOpcionesMultas.ResumeLayout(False)
        Me.tblOpcionesMultas.ResumeLayout(False)
        Me.grpFechas.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.DataMultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutMenuOptions.ResumeLayout(False)
        CType(Me.PictVehicle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictMulta, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutMenuOptions As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
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
    Friend WithEvents PictVehicle As PictureBox
    Friend WithEvents PictLicencia As PictureBox
    Friend WithEvents PictMulta As PictureBox
    Friend WithEvents tlSearchBar As TableLayoutPanel
    Friend WithEvents lblSearchType As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataContribuyentes As DataGridView
    Friend WithEvents grpFiltros As GroupBox
    Friend WithEvents rbInfractoresLibres As RadioButton
    Friend WithEvents rbInfractoresPendientes As RadioButton
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbNoInfractores As RadioButton
    Friend WithEvents grpLocalidades As GroupBox
    Friend WithEvents Header As FlowLayoutPanel
    Friend WithEvents btnPlacas As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer As Timer
    Friend WithEvents cbTipoBusqueda As ComboBox
    Friend WithEvents grpOpciones As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbPaises As ComboBox
    Friend WithEvents cbEstados As ComboBox
    Friend WithEvents cbCiudades As ComboBox
    Friend WithEvents cbColonias As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents TabMultas As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbMultasSinPagar As RadioButton
    Friend WithEvents rbMultasPagadas As RadioButton
    Friend WithEvents rbTodosMultas As RadioButton
    Friend WithEvents DataMultas As DataGridView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents cbTiposSearchMultas As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscarMultas As Button
    Friend WithEvents txtSearchMultas As TextBox
    Friend WithEvents grpOpcionesMultas As GroupBox
    Friend WithEvents tblOpcionesMultas As TableLayoutPanel
    Friend WithEvents btnAgregarMulta As Button
    Friend WithEvents btnModificarMulta As Button
    Friend WithEvents btnEliminarMultas As Button
    Friend WithEvents grpFechas As GroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblInitDate As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents dateInit As DateTimePicker
    Friend WithEvents dateEnd As DateTimePicker
End Class
