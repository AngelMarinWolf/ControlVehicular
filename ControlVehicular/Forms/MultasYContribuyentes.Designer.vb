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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultasYContribuyentes))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabInformation = New System.Windows.Forms.TabControl()
        Me.TabContribuyentes = New System.Windows.Forms.TabPage()
        Me.TabMultas = New System.Windows.Forms.TabPage()
        Me.TableLayoutMenuOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TabInformation.SuspendLayout()
        Me.TableLayoutMenuOptions.SuspendLayout()
        Me.Footer.SuspendLayout()
        Me.StatusUser.SuspendLayout()
        Me.StatusDate.SuspendLayout()
        Me.TableLayoutMenuTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.TabInformation.Location = New System.Drawing.Point(12, 27)
        Me.TabInformation.Name = "TabInformation"
        Me.TabInformation.SelectedIndex = 0
        Me.TabInformation.Size = New System.Drawing.Size(766, 511)
        Me.TabInformation.TabIndex = 1
        '
        'TabContribuyentes
        '
        Me.TabContribuyentes.Location = New System.Drawing.Point(4, 22)
        Me.TabContribuyentes.Name = "TabContribuyentes"
        Me.TabContribuyentes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabContribuyentes.Size = New System.Drawing.Size(758, 485)
        Me.TabContribuyentes.TabIndex = 0
        Me.TabContribuyentes.Text = "Contribuyentes"
        Me.TabContribuyentes.UseVisualStyleBackColor = True
        '
        'TabMultas
        '
        Me.TabMultas.Location = New System.Drawing.Point(4, 22)
        Me.TabMultas.Name = "TabMultas"
        Me.TabMultas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMultas.Size = New System.Drawing.Size(758, 485)
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
        Me.TableLayoutMenuOptions.Controls.Add(Me.Button5, 1, 4)
        Me.TableLayoutMenuOptions.Controls.Add(Me.Button2, 1, 1)
        Me.TableLayoutMenuOptions.Controls.Add(Me.Button4, 1, 3)
        Me.TableLayoutMenuOptions.Controls.Add(Me.Button3, 1, 2)
        Me.TableLayoutMenuOptions.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutMenuOptions.Location = New System.Drawing.Point(784, 63)
        Me.TableLayoutMenuOptions.Name = "TableLayoutMenuOptions"
        Me.TableLayoutMenuOptions.RowCount = 6
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
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
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(33, 123)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(164, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Pago Multa"
        Me.Button5.UseVisualStyleBackColor = True
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
        Me.TableLayoutMenuTitle.Location = New System.Drawing.Point(784, 27)
        Me.TableLayoutMenuTitle.Name = "TableLayoutMenuTitle"
        Me.TableLayoutMenuTitle.RowCount = 1
        Me.TableLayoutMenuTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutMenuTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutMenuTitle.Size = New System.Drawing.Size(200, 30)
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
        Me.lblMenu.Size = New System.Drawing.Size(194, 29)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Menu"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.ControlVehicular.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'MultasYContribuyentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.TableLayoutMenuTitle)
        Me.Controls.Add(Me.Footer)
        Me.Controls.Add(Me.TableLayoutMenuOptions)
        Me.Controls.Add(Me.TabInformation)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MultasYContribuyentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multas y Contribuyentes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabInformation.ResumeLayout(False)
        Me.TableLayoutMenuOptions.ResumeLayout(False)
        Me.Footer.ResumeLayout(False)
        Me.Footer.PerformLayout()
        Me.StatusUser.ResumeLayout(False)
        Me.StatusUser.PerformLayout()
        Me.StatusDate.ResumeLayout(False)
        Me.StatusDate.PerformLayout()
        Me.TableLayoutMenuTitle.ResumeLayout(False)
        Me.TableLayoutMenuTitle.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
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
    Friend WithEvents PictureBox1 As PictureBox
End Class
