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
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
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
        Me.TableUserPassword.Controls.Add(Me.lblUser, 1, 0)
        Me.TableUserPassword.Controls.Add(Me.lblContraseña, 1, 1)
        Me.TableUserPassword.Controls.Add(Me.txtUser, 2, 0)
        Me.TableUserPassword.Controls.Add(Me.txtPassword, 2, 1)
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
        'lblUser
        '
        Me.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(416, 7)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(66, 16)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Usuario:"
        '
        'lblContraseña
        '
        Me.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(391, 37)
        Me.lblContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(91, 16)
        Me.lblContraseña.TabIndex = 1
        Me.lblContraseña.Text = "Contraseña:"
        '
        'txtUser
        '
        Me.txtUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUser.BackColor = System.Drawing.SystemColors.Window
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Location = New System.Drawing.Point(490, 4)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(235, 22)
        Me.txtUser.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Location = New System.Drawing.Point(490, 34)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(235, 22)
        Me.txtPassword.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancelar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAceptar, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(486, 60)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(243, 29)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(124, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(116, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAceptar.Location = New System.Drawing.Point(3, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(115, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Brush Script MT", 60.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 3)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(968, 98)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Control Vehicular"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutTitle
        '
        Me.TableLayoutTitle.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutTitle.ColumnCount = 1
        Me.TableLayoutTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutTitle.Controls.Add(Me.lblTitle, 0, 0)
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
        Me.LinkOptions.TabIndex = 5
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
    Friend WithEvents lblUser As Label
    Friend WithEvents lblContraseña As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents TableLayoutTitle As TableLayoutPanel
    Friend WithEvents LinkOptions As LinkLabel
End Class
