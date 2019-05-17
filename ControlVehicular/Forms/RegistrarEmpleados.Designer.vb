<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarEmpleados))
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.lblRfc = New System.Windows.Forms.Label()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.lblMaterno = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtCurp = New System.Windows.Forms.TextBox()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblPaterno = New System.Windows.Forms.Label()
        Me.lblCurp = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.dataEmpleados = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbCiudad = New System.Windows.Forms.ComboBox()
        Me.cmbColonia = New System.Windows.Forms.ComboBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtEdad = New System.Windows.Forms.NumericUpDown()
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.tblApellidos = New System.Windows.Forms.TableLayoutPanel()
        Me.tblNombre = New System.Windows.Forms.TableLayoutPanel()
        Me.tblCurp = New System.Windows.Forms.TableLayoutPanel()
        Me.tblBody = New System.Windows.Forms.TableLayoutPanel()
        Me.tblFlow = New System.Windows.Forms.FlowLayoutPanel()
        Me.tblContacto = New System.Windows.Forms.TableLayoutPanel()
        Me.tblSubBody = New System.Windows.Forms.TableLayoutPanel()
        Me.grpAccess = New System.Windows.Forms.GroupBox()
        Me.tblAccess = New System.Windows.Forms.TableLayoutPanel()
        Me.txtUsernamer = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.grpSexo = New System.Windows.Forms.GroupBox()
        Me.tblSexos = New System.Windows.Forms.TableLayoutPanel()
        Me.chkMasculino = New System.Windows.Forms.CheckBox()
        Me.chkFemenino = New System.Windows.Forms.CheckBox()
        Me.grpDomicilio = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNumeroDomicilio = New System.Windows.Forms.Label()
        Me.txtNumeroDomicilio = New System.Windows.Forms.TextBox()
        Me.tblLocalidades = New System.Windows.Forms.TableLayoutPanel()
        Me.tblBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.tblGridEmpleados = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.dataEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txtEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblHeader.SuspendLayout()
        Me.tblApellidos.SuspendLayout()
        Me.tblNombre.SuspendLayout()
        Me.tblCurp.SuspendLayout()
        Me.tblBody.SuspendLayout()
        Me.tblFlow.SuspendLayout()
        Me.tblContacto.SuspendLayout()
        Me.tblSubBody.SuspendLayout()
        Me.grpAccess.SuspendLayout()
        Me.tblAccess.SuspendLayout()
        Me.grpSexo.SuspendLayout()
        Me.tblSexos.SuspendLayout()
        Me.grpDomicilio.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tblLocalidades.SuspendLayout()
        Me.tblBotones.SuspendLayout()
        Me.tblGridEmpleados.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTelefono
        '
        Me.lblTelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(244, 6)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(54, 13)
        Me.lblTelefono.TabIndex = 149
        Me.lblTelefono.Text = "Telefono:"
        '
        'txtRfc
        '
        Me.txtRfc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRfc.Location = New System.Drawing.Point(63, 3)
        Me.txtRfc.MaxLength = 13
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(283, 20)
        Me.txtRfc.TabIndex = 2
        '
        'lblRfc
        '
        Me.lblRfc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRfc.AutoSize = True
        Me.lblRfc.Location = New System.Drawing.Point(3, 6)
        Me.lblRfc.Name = "lblRfc"
        Me.lblRfc.Size = New System.Drawing.Size(54, 13)
        Me.lblRfc.TabIndex = 145
        Me.lblRfc.Text = "RFC:"
        '
        'txtMaterno
        '
        Me.txtMaterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaterno.Location = New System.Drawing.Point(304, 3)
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(176, 20)
        Me.txtMaterno.TabIndex = 6
        '
        'lblMaterno
        '
        Me.lblMaterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMaterno.AutoSize = True
        Me.lblMaterno.Location = New System.Drawing.Point(244, 6)
        Me.lblMaterno.Name = "lblMaterno"
        Me.lblMaterno.Size = New System.Drawing.Size(54, 13)
        Me.lblMaterno.TabIndex = 143
        Me.lblMaterno.Text = "Materno:"
        '
        'txtCalle
        '
        Me.txtCalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCalle.Location = New System.Drawing.Point(72, 3)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(249, 20)
        Me.txtCalle.TabIndex = 17
        '
        'lblCalle
        '
        Me.lblCalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(3, 6)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(63, 13)
        Me.lblCalle.TabIndex = 141
        Me.lblCalle.Text = "Calle:"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(63, 3)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(175, 20)
        Me.txtEmail.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(3, 6)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(54, 13)
        Me.lblEmail.TabIndex = 135
        Me.lblEmail.Text = "Email:"
        '
        'txtCurp
        '
        Me.txtCurp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCurp.Location = New System.Drawing.Point(63, 3)
        Me.txtCurp.MaxLength = 18
        Me.txtCurp.Name = "txtCurp"
        Me.txtCurp.Size = New System.Drawing.Size(417, 20)
        Me.txtCurp.TabIndex = 1
        '
        'txtPaterno
        '
        Me.txtPaterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPaterno.Location = New System.Drawing.Point(63, 3)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(175, 20)
        Me.txtPaterno.TabIndex = 5
        '
        'lblEdad
        '
        Me.lblEdad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(352, 6)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(54, 13)
        Me.lblEdad.TabIndex = 132
        Me.lblEdad.Text = "Edad:"
        '
        'lblPaterno
        '
        Me.lblPaterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPaterno.AutoSize = True
        Me.lblPaterno.Location = New System.Drawing.Point(3, 6)
        Me.lblPaterno.Name = "lblPaterno"
        Me.lblPaterno.Size = New System.Drawing.Size(54, 13)
        Me.lblPaterno.TabIndex = 131
        Me.lblPaterno.Text = "Paterno:"
        '
        'lblCurp
        '
        Me.lblCurp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurp.AutoSize = True
        Me.lblCurp.Location = New System.Drawing.Point(3, 6)
        Me.lblCurp.Name = "lblCurp"
        Me.lblCurp.Size = New System.Drawing.Size(54, 13)
        Me.lblCurp.TabIndex = 0
        Me.lblCurp.Text = "CURP:"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(63, 3)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(417, 20)
        Me.txtNombre.TabIndex = 4
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(3, 6)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(54, 13)
        Me.lblNombre.TabIndex = 128
        Me.lblNombre.Text = "Nombre:"
        '
        'dataEmpleados
        '
        Me.dataEmpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataEmpleados.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dataEmpleados.Location = New System.Drawing.Point(3, 3)
        Me.dataEmpleados.MultiSelect = False
        Me.dataEmpleados.Name = "dataEmpleados"
        Me.dataEmpleados.ReadOnly = True
        Me.dataEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataEmpleados.Size = New System.Drawing.Size(477, 258)
        Me.dataEmpleados.TabIndex = 127
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEliminar.Location = New System.Drawing.Point(325, 1)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(119, 23)
        Me.btnEliminar.TabIndex = 21
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Location = New System.Drawing.Point(177, 1)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(119, 23)
        Me.btnModificar.TabIndex = 20
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(29, 1)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(119, 23)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblColonia
        '
        Me.lblColonia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(234, 31)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(63, 13)
        Me.lblColonia.TabIndex = 160
        Me.lblColonia.Text = "Colonia:"
        '
        'lblCiudad
        '
        Me.lblCiudad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Location = New System.Drawing.Point(3, 31)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(63, 13)
        Me.lblCiudad.TabIndex = 159
        Me.lblCiudad.Text = "Ciudad:"
        '
        'lblPais
        '
        Me.lblPais.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(3, 6)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(63, 13)
        Me.lblPais.TabIndex = 158
        Me.lblPais.Text = "Pais:"
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(234, 6)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(63, 13)
        Me.lblEstado.TabIndex = 157
        Me.lblEstado.Text = "Estado:"
        '
        'cmbEstado
        '
        Me.cmbEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(303, 3)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(159, 21)
        Me.cmbEstado.TabIndex = 14
        '
        'cmbCiudad
        '
        Me.cmbCiudad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(72, 28)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(156, 21)
        Me.cmbCiudad.TabIndex = 15
        '
        'cmbColonia
        '
        Me.cmbColonia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbColonia.FormattingEnabled = True
        Me.cmbColonia.Location = New System.Drawing.Point(303, 28)
        Me.cmbColonia.Name = "cmbColonia"
        Me.cmbColonia.Size = New System.Drawing.Size(159, 21)
        Me.cmbColonia.TabIndex = 16
        '
        'cmbPais
        '
        Me.cmbPais.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(72, 3)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(156, 21)
        Me.cmbPais.TabIndex = 13
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(304, 3)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(176, 20)
        Me.txtTelefono.TabIndex = 8
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtEdad, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRfc, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRfc, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEdad, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(483, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(483, 25)
        Me.TableLayoutPanel1.TabIndex = 161
        '
        'txtEdad
        '
        Me.txtEdad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEdad.Location = New System.Drawing.Point(412, 3)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(68, 20)
        Me.txtEdad.TabIndex = 3
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.Transparent
        Me.tblHeader.ColumnCount = 2
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.Controls.Add(Me.tblApellidos, 1, 1)
        Me.tblHeader.Controls.Add(Me.tblNombre, 0, 1)
        Me.tblHeader.Controls.Add(Me.tblCurp, 0, 0)
        Me.tblHeader.Controls.Add(Me.TableLayoutPanel1, 1, 0)
        Me.tblHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tblHeader.Location = New System.Drawing.Point(9, 9)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.Size = New System.Drawing.Size(966, 50)
        Me.tblHeader.TabIndex = 0
        '
        'tblApellidos
        '
        Me.tblApellidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblApellidos.ColumnCount = 4
        Me.tblApellidos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblApellidos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.tblApellidos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblApellidos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.tblApellidos.Controls.Add(Me.txtPaterno, 1, 0)
        Me.tblApellidos.Controls.Add(Me.lblPaterno, 0, 0)
        Me.tblApellidos.Controls.Add(Me.txtMaterno, 3, 0)
        Me.tblApellidos.Controls.Add(Me.lblMaterno, 2, 0)
        Me.tblApellidos.Location = New System.Drawing.Point(483, 25)
        Me.tblApellidos.Margin = New System.Windows.Forms.Padding(0)
        Me.tblApellidos.Name = "tblApellidos"
        Me.tblApellidos.RowCount = 1
        Me.tblApellidos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblApellidos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tblApellidos.Size = New System.Drawing.Size(483, 25)
        Me.tblApellidos.TabIndex = 0
        '
        'tblNombre
        '
        Me.tblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblNombre.ColumnCount = 2
        Me.tblNombre.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblNombre.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.5!))
        Me.tblNombre.Controls.Add(Me.lblNombre, 0, 0)
        Me.tblNombre.Controls.Add(Me.txtNombre, 1, 0)
        Me.tblNombre.Location = New System.Drawing.Point(0, 25)
        Me.tblNombre.Margin = New System.Windows.Forms.Padding(0)
        Me.tblNombre.Name = "tblNombre"
        Me.tblNombre.RowCount = 1
        Me.tblNombre.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblNombre.Size = New System.Drawing.Size(483, 25)
        Me.tblNombre.TabIndex = 0
        '
        'tblCurp
        '
        Me.tblCurp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblCurp.ColumnCount = 2
        Me.tblCurp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblCurp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.5!))
        Me.tblCurp.Controls.Add(Me.txtCurp, 1, 0)
        Me.tblCurp.Controls.Add(Me.lblCurp, 0, 0)
        Me.tblCurp.Location = New System.Drawing.Point(0, 0)
        Me.tblCurp.Margin = New System.Windows.Forms.Padding(0)
        Me.tblCurp.Name = "tblCurp"
        Me.tblCurp.RowCount = 1
        Me.tblCurp.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblCurp.Size = New System.Drawing.Size(483, 25)
        Me.tblCurp.TabIndex = 0
        '
        'tblBody
        '
        Me.tblBody.ColumnCount = 2
        Me.tblBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblBody.Controls.Add(Me.tblFlow, 0, 0)
        Me.tblBody.Controls.Add(Me.tblGridEmpleados, 1, 0)
        Me.tblBody.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tblBody.Location = New System.Drawing.Point(9, 63)
        Me.tblBody.Name = "tblBody"
        Me.tblBody.RowCount = 1
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblBody.Size = New System.Drawing.Size(966, 265)
        Me.tblBody.TabIndex = 0
        '
        'tblFlow
        '
        Me.tblFlow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblFlow.Controls.Add(Me.tblContacto)
        Me.tblFlow.Controls.Add(Me.tblSubBody)
        Me.tblFlow.Controls.Add(Me.grpDomicilio)
        Me.tblFlow.Controls.Add(Me.tblBotones)
        Me.tblFlow.Location = New System.Drawing.Point(0, 0)
        Me.tblFlow.Margin = New System.Windows.Forms.Padding(0)
        Me.tblFlow.Name = "tblFlow"
        Me.tblFlow.Size = New System.Drawing.Size(483, 265)
        Me.tblFlow.TabIndex = 0
        '
        'tblContacto
        '
        Me.tblContacto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblContacto.ColumnCount = 4
        Me.tblContacto.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblContacto.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.tblContacto.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblContacto.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.tblContacto.Controls.Add(Me.lblTelefono, 2, 0)
        Me.tblContacto.Controls.Add(Me.txtTelefono, 3, 0)
        Me.tblContacto.Controls.Add(Me.txtEmail, 1, 0)
        Me.tblContacto.Controls.Add(Me.lblEmail, 0, 0)
        Me.tblContacto.Location = New System.Drawing.Point(0, 0)
        Me.tblContacto.Margin = New System.Windows.Forms.Padding(0)
        Me.tblContacto.Name = "tblContacto"
        Me.tblContacto.RowCount = 1
        Me.tblContacto.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblContacto.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tblContacto.Size = New System.Drawing.Size(483, 25)
        Me.tblContacto.TabIndex = 0
        '
        'tblSubBody
        '
        Me.tblSubBody.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblSubBody.ColumnCount = 2
        Me.tblSubBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblSubBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblSubBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblSubBody.Controls.Add(Me.grpAccess, 0, 0)
        Me.tblSubBody.Controls.Add(Me.grpSexo, 1, 0)
        Me.tblSubBody.Location = New System.Drawing.Point(0, 25)
        Me.tblSubBody.Margin = New System.Windows.Forms.Padding(0)
        Me.tblSubBody.Name = "tblSubBody"
        Me.tblSubBody.RowCount = 1
        Me.tblSubBody.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSubBody.Size = New System.Drawing.Size(483, 90)
        Me.tblSubBody.TabIndex = 0
        '
        'grpAccess
        '
        Me.grpAccess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAccess.Controls.Add(Me.tblAccess)
        Me.grpAccess.Location = New System.Drawing.Point(3, 3)
        Me.grpAccess.Name = "grpAccess"
        Me.grpAccess.Size = New System.Drawing.Size(235, 80)
        Me.grpAccess.TabIndex = 0
        Me.grpAccess.TabStop = False
        Me.grpAccess.Text = "Accesos"
        '
        'tblAccess
        '
        Me.tblAccess.ColumnCount = 2
        Me.tblAccess.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblAccess.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tblAccess.Controls.Add(Me.txtUsernamer, 1, 0)
        Me.tblAccess.Controls.Add(Me.txtPassword, 1, 1)
        Me.tblAccess.Controls.Add(Me.lblUsername, 0, 0)
        Me.tblAccess.Controls.Add(Me.lblPassword, 0, 1)
        Me.tblAccess.Location = New System.Drawing.Point(6, 19)
        Me.tblAccess.Name = "tblAccess"
        Me.tblAccess.RowCount = 2
        Me.tblAccess.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblAccess.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblAccess.Size = New System.Drawing.Size(223, 50)
        Me.tblAccess.TabIndex = 0
        '
        'txtUsernamer
        '
        Me.txtUsernamer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsernamer.Location = New System.Drawing.Point(69, 3)
        Me.txtUsernamer.Name = "txtUsernamer"
        Me.txtUsernamer.Size = New System.Drawing.Size(151, 20)
        Me.txtUsernamer.TabIndex = 9
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.Location = New System.Drawing.Point(69, 28)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(151, 20)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(3, 6)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(60, 13)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(3, 31)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(60, 13)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password:"
        '
        'grpSexo
        '
        Me.grpSexo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSexo.Controls.Add(Me.tblSexos)
        Me.grpSexo.Location = New System.Drawing.Point(244, 3)
        Me.grpSexo.Name = "grpSexo"
        Me.grpSexo.Size = New System.Drawing.Size(236, 80)
        Me.grpSexo.TabIndex = 0
        Me.grpSexo.TabStop = False
        Me.grpSexo.Text = "Sexo"
        '
        'tblSexos
        '
        Me.tblSexos.ColumnCount = 2
        Me.tblSexos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblSexos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblSexos.Controls.Add(Me.chkMasculino, 0, 0)
        Me.tblSexos.Controls.Add(Me.chkFemenino, 1, 0)
        Me.tblSexos.Location = New System.Drawing.Point(6, 19)
        Me.tblSexos.Name = "tblSexos"
        Me.tblSexos.RowCount = 1
        Me.tblSexos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSexos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tblSexos.Size = New System.Drawing.Size(224, 50)
        Me.tblSexos.TabIndex = 0
        '
        'chkMasculino
        '
        Me.chkMasculino.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMasculino.AutoSize = True
        Me.chkMasculino.Location = New System.Drawing.Point(3, 16)
        Me.chkMasculino.Name = "chkMasculino"
        Me.chkMasculino.Size = New System.Drawing.Size(106, 17)
        Me.chkMasculino.TabIndex = 11
        Me.chkMasculino.Text = "Masculino"
        Me.chkMasculino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkMasculino.UseVisualStyleBackColor = True
        '
        'chkFemenino
        '
        Me.chkFemenino.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFemenino.AutoSize = True
        Me.chkFemenino.Location = New System.Drawing.Point(115, 16)
        Me.chkFemenino.Name = "chkFemenino"
        Me.chkFemenino.Size = New System.Drawing.Size(106, 17)
        Me.chkFemenino.TabIndex = 12
        Me.chkFemenino.Text = "Femenino"
        Me.chkFemenino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkFemenino.UseVisualStyleBackColor = True
        '
        'grpDomicilio
        '
        Me.grpDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpDomicilio.Controls.Add(Me.TableLayoutPanel2)
        Me.grpDomicilio.Controls.Add(Me.tblLocalidades)
        Me.grpDomicilio.Location = New System.Drawing.Point(3, 118)
        Me.grpDomicilio.Name = "grpDomicilio"
        Me.grpDomicilio.Size = New System.Drawing.Size(477, 108)
        Me.grpDomicilio.TabIndex = 0
        Me.grpDomicilio.TabStop = False
        Me.grpDomicilio.Text = "Domicilio"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtCalle, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCalle, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblNumeroDomicilio, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNumeroDomicilio, 3, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 75)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(465, 25)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lblNumeroDomicilio
        '
        Me.lblNumeroDomicilio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroDomicilio.AutoSize = True
        Me.lblNumeroDomicilio.Location = New System.Drawing.Point(327, 6)
        Me.lblNumeroDomicilio.Name = "lblNumeroDomicilio"
        Me.lblNumeroDomicilio.Size = New System.Drawing.Size(63, 13)
        Me.lblNumeroDomicilio.TabIndex = 143
        Me.lblNumeroDomicilio.Text = "Numero:"
        '
        'txtNumeroDomicilio
        '
        Me.txtNumeroDomicilio.Location = New System.Drawing.Point(396, 3)
        Me.txtNumeroDomicilio.Name = "txtNumeroDomicilio"
        Me.txtNumeroDomicilio.Size = New System.Drawing.Size(66, 20)
        Me.txtNumeroDomicilio.TabIndex = 18
        '
        'tblLocalidades
        '
        Me.tblLocalidades.ColumnCount = 4
        Me.tblLocalidades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblLocalidades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tblLocalidades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblLocalidades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tblLocalidades.Controls.Add(Me.lblPais, 0, 0)
        Me.tblLocalidades.Controls.Add(Me.lblCiudad, 0, 1)
        Me.tblLocalidades.Controls.Add(Me.cmbCiudad, 1, 1)
        Me.tblLocalidades.Controls.Add(Me.cmbEstado, 3, 0)
        Me.tblLocalidades.Controls.Add(Me.cmbPais, 1, 0)
        Me.tblLocalidades.Controls.Add(Me.cmbColonia, 3, 1)
        Me.tblLocalidades.Controls.Add(Me.lblColonia, 2, 1)
        Me.tblLocalidades.Controls.Add(Me.lblEstado, 2, 0)
        Me.tblLocalidades.Location = New System.Drawing.Point(6, 19)
        Me.tblLocalidades.Name = "tblLocalidades"
        Me.tblLocalidades.RowCount = 2
        Me.tblLocalidades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblLocalidades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblLocalidades.Size = New System.Drawing.Size(465, 50)
        Me.tblLocalidades.TabIndex = 0
        '
        'tblBotones
        '
        Me.tblBotones.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.tblBotones.Location = New System.Drawing.Point(3, 232)
        Me.tblBotones.Name = "tblBotones"
        Me.tblBotones.RowCount = 1
        Me.tblBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblBotones.Size = New System.Drawing.Size(477, 25)
        Me.tblBotones.TabIndex = 0
        '
        'tblGridEmpleados
        '
        Me.tblGridEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblGridEmpleados.Controls.Add(Me.dataEmpleados)
        Me.tblGridEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tblGridEmpleados.Location = New System.Drawing.Point(483, 0)
        Me.tblGridEmpleados.Margin = New System.Windows.Forms.Padding(0)
        Me.tblGridEmpleados.Name = "tblGridEmpleados"
        Me.tblGridEmpleados.Size = New System.Drawing.Size(483, 265)
        Me.tblGridEmpleados.TabIndex = 0
        '
        'RegistrarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 336)
        Me.Controls.Add(Me.tblBody)
        Me.Controls.Add(Me.tblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrarEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Empleados"
        CType(Me.dataEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txtEdad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblHeader.ResumeLayout(False)
        Me.tblApellidos.ResumeLayout(False)
        Me.tblApellidos.PerformLayout()
        Me.tblNombre.ResumeLayout(False)
        Me.tblNombre.PerformLayout()
        Me.tblCurp.ResumeLayout(False)
        Me.tblCurp.PerformLayout()
        Me.tblBody.ResumeLayout(False)
        Me.tblFlow.ResumeLayout(False)
        Me.tblContacto.ResumeLayout(False)
        Me.tblContacto.PerformLayout()
        Me.tblSubBody.ResumeLayout(False)
        Me.grpAccess.ResumeLayout(False)
        Me.tblAccess.ResumeLayout(False)
        Me.tblAccess.PerformLayout()
        Me.grpSexo.ResumeLayout(False)
        Me.tblSexos.ResumeLayout(False)
        Me.tblSexos.PerformLayout()
        Me.grpDomicilio.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.tblLocalidades.ResumeLayout(False)
        Me.tblLocalidades.PerformLayout()
        Me.tblBotones.ResumeLayout(False)
        Me.tblGridEmpleados.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtRfc As TextBox
    Friend WithEvents lblRfc As Label
    Friend WithEvents txtMaterno As TextBox
    Friend WithEvents lblMaterno As Label
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents lblCalle As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtCurp As TextBox
    Friend WithEvents txtPaterno As TextBox
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblPaterno As Label
    Friend WithEvents lblCurp As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents dataEmpleados As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblColonia As Label
    Friend WithEvents lblCiudad As Label
    Friend WithEvents lblPais As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbCiudad As ComboBox
    Friend WithEvents cmbColonia As ComboBox
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tblCurp As TableLayoutPanel
    Friend WithEvents tblHeader As TableLayoutPanel
    Friend WithEvents tblApellidos As TableLayoutPanel
    Friend WithEvents tblNombre As TableLayoutPanel
    Friend WithEvents txtEdad As NumericUpDown
    Friend WithEvents tblBody As TableLayoutPanel
    Friend WithEvents tblContacto As TableLayoutPanel
    Friend WithEvents tblFlow As FlowLayoutPanel
    Friend WithEvents tblSubBody As TableLayoutPanel
    Friend WithEvents grpAccess As GroupBox
    Friend WithEvents tblAccess As TableLayoutPanel
    Friend WithEvents txtUsernamer As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents grpSexo As GroupBox
    Friend WithEvents tblSexos As TableLayoutPanel
    Friend WithEvents chkMasculino As CheckBox
    Friend WithEvents chkFemenino As CheckBox
    Friend WithEvents grpDomicilio As GroupBox
    Friend WithEvents tblLocalidades As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblNumeroDomicilio As Label
    Friend WithEvents txtNumeroDomicilio As TextBox
    Friend WithEvents tblBotones As TableLayoutPanel
    Friend WithEvents tblGridEmpleados As FlowLayoutPanel
End Class
