<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TableUserPassword = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.LabelContraseña = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonConfirm = New System.Windows.Forms.Button()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.TableLayoutTitle = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkOptions = New System.Windows.Forms.LinkLabel()
        Me.TableUserPassword.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableUserPassword
        '
        Me.TableUserPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableUserPassword.BackColor = System.Drawing.Color.Transparent
        Me.TableUserPassword.ColumnCount = 4
        Me.TableUserPassword.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableUserPassword.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableUserPassword.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableUserPassword.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableUserPassword.Controls.Add(Me.LabelUser, 1, 0)
        Me.TableUserPassword.Controls.Add(Me.LabelContraseña, 1, 1)
        Me.TableUserPassword.Controls.Add(Me.TextBox1, 2, 0)
        Me.TableUserPassword.Controls.Add(Me.TextBox2, 2, 1)
        Me.TableUserPassword.Controls.Add(Me.TableLayoutPanel1, 2, 2)
        Me.TableUserPassword.Location = New System.Drawing.Point(13, 119)
        Me.TableUserPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TableUserPassword.Name = "TableUserPassword"
        Me.TableUserPassword.RowCount = 3
        Me.TableUserPassword.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableUserPassword.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableUserPassword.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableUserPassword.Size = New System.Drawing.Size(974, 90)
        Me.TableUserPassword.TabIndex = 0
        '
        'LabelUser
        '
        Me.LabelUser.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelUser.AutoSize = True
        Me.LabelUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.Location = New System.Drawing.Point(416, 7)
        Me.LabelUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(66, 16)
        Me.LabelUser.TabIndex = 0
        Me.LabelUser.Text = "Usuario:"
        '
        'LabelContraseña
        '
        Me.LabelContraseña.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelContraseña.AutoSize = True
        Me.LabelContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContraseña.Location = New System.Drawing.Point(391, 37)
        Me.LabelContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelContraseña.Name = "LabelContraseña"
        Me.LabelContraseña.Size = New System.Drawing.Size(91, 16)
        Me.LabelContraseña.TabIndex = 1
        Me.LabelContraseña.Text = "Contraseña:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(490, 4)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(235, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(490, 34)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox2.Size = New System.Drawing.Size(235, 22)
        Me.TextBox2.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonCancel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonConfirm, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(486, 60)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(243, 29)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.Location = New System.Drawing.Point(124, 3)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(116, 23)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonConfirm
        '
        Me.ButtonConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonConfirm.Location = New System.Drawing.Point(3, 3)
        Me.ButtonConfirm.Name = "ButtonConfirm"
        Me.ButtonConfirm.Size = New System.Drawing.Size(115, 23)
        Me.ButtonConfirm.TabIndex = 4
        Me.ButtonConfirm.Text = "Aceptar"
        Me.ButtonConfirm.UseVisualStyleBackColor = True
        '
        'LabelTitle
        '
        Me.LabelTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Brush Script MT", 60.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(3, 3)
        Me.LabelTitle.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(968, 98)
        Me.LabelTitle.TabIndex = 1
        Me.LabelTitle.Text = "Control Vehicular"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutTitle
        '
        Me.TableLayoutTitle.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutTitle.ColumnCount = 1
        Me.TableLayoutTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutTitle.Controls.Add(Me.LabelTitle, 0, 0)
        Me.TableLayoutTitle.Location = New System.Drawing.Point(13, 12)
        Me.TableLayoutTitle.Name = "TableLayoutTitle"
        Me.TableLayoutTitle.RowCount = 1
        Me.TableLayoutTitle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.TableLayoutTitle.Size = New System.Drawing.Size(974, 100)
        Me.TableLayoutTitle.TabIndex = 2
        '
        'LinkOptions
        '
        Me.LinkOptions.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.LinkOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkOptions.AutoSize = True
        Me.LinkOptions.BackColor = System.Drawing.Color.Transparent
        Me.LinkOptions.LinkColor = System.Drawing.Color.White
        Me.LinkOptions.Location = New System.Drawing.Point(912, 575)
        Me.LinkOptions.Name = "LinkOptions"
        Me.LinkOptions.Size = New System.Drawing.Size(75, 16)
        Me.LinkOptions.TabIndex = 6
        Me.LinkOptions.TabStop = True
        Me.LinkOptions.Text = "Opciones..."
        Me.LinkOptions.VisitedLinkColor = System.Drawing.Color.White
        '
        'Login
        '
        Me.AccessibleDescription = "Pantalla de Inicio de Session"
        Me.AccessibleName = "Login"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ControlVehicular.My.Resources.Resources.MustangWallpaper
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.LinkOptions)
        Me.Controls.Add(Me.TableLayoutTitle)
        Me.Controls.Add(Me.TableUserPassword)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Session"
        Me.TableUserPassword.ResumeLayout(False)
        Me.TableUserPassword.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutTitle.ResumeLayout(False)
        Me.TableLayoutTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableUserPassword As TableLayoutPanel
    Friend WithEvents LabelUser As Label
    Friend WithEvents LabelContraseña As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonConfirm As Button
    Friend WithEvents LabelTitle As Label
    Friend WithEvents TableLayoutTitle As TableLayoutPanel
    Friend WithEvents LinkOptions As LinkLabel
End Class
