<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarLicencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarLicencias))
        Me.lblIdLicencia = New System.Windows.Forms.Label()
        Me.lblCurp = New System.Windows.Forms.Label()
        Me.lblTipoLicencia = New System.Windows.Forms.Label()
        Me.lblDateExpedicion = New System.Windows.Forms.Label()
        Me.lblDateExpiracion = New System.Windows.Forms.Label()
        Me.lblDonador = New System.Windows.Forms.Label()
        Me.lblContactoEmergencia = New System.Windows.Forms.Label()
        Me.lblTelefonoEmergencia = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtIdLicencia = New System.Windows.Forms.NumericUpDown()
        Me.txtCurp = New System.Windows.Forms.TextBox()
        Me.dateExpedicion = New System.Windows.Forms.DateTimePicker()
        Me.dateExpiracion = New System.Windows.Forms.DateTimePicker()
        Me.chkSiDonador = New System.Windows.Forms.CheckBox()
        Me.chkNoDonador = New System.Windows.Forms.CheckBox()
        Me.txtContactoEmergencia = New System.Windows.Forms.TextBox()
        Me.txtNumeroEmergencia = New System.Windows.Forms.TextBox()
        Me.tblBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.tblDonador = New System.Windows.Forms.TableLayoutPanel()
        Me.cbTipoLicencia = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txtIdLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblBotones.SuspendLayout()
        Me.tblDonador.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIdLicencia
        '
        Me.lblIdLicencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIdLicencia.AutoSize = True
        Me.lblIdLicencia.ForeColor = System.Drawing.Color.White
        Me.lblIdLicencia.Location = New System.Drawing.Point(3, 5)
        Me.lblIdLicencia.Name = "lblIdLicencia"
        Me.lblIdLicencia.Size = New System.Drawing.Size(126, 13)
        Me.lblIdLicencia.TabIndex = 0
        Me.lblIdLicencia.Text = "idLicencia"
        '
        'lblCurp
        '
        Me.lblCurp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurp.AutoSize = True
        Me.lblCurp.ForeColor = System.Drawing.Color.White
        Me.lblCurp.Location = New System.Drawing.Point(3, 30)
        Me.lblCurp.Name = "lblCurp"
        Me.lblCurp.Size = New System.Drawing.Size(126, 13)
        Me.lblCurp.TabIndex = 1
        Me.lblCurp.Text = "CURP"
        '
        'lblTipoLicencia
        '
        Me.lblTipoLicencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoLicencia.AutoSize = True
        Me.lblTipoLicencia.ForeColor = System.Drawing.Color.White
        Me.lblTipoLicencia.Location = New System.Drawing.Point(3, 55)
        Me.lblTipoLicencia.Name = "lblTipoLicencia"
        Me.lblTipoLicencia.Size = New System.Drawing.Size(126, 13)
        Me.lblTipoLicencia.TabIndex = 2
        Me.lblTipoLicencia.Text = "Tipo de Licencia"
        '
        'lblDateExpedicion
        '
        Me.lblDateExpedicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateExpedicion.AutoSize = True
        Me.lblDateExpedicion.ForeColor = System.Drawing.Color.White
        Me.lblDateExpedicion.Location = New System.Drawing.Point(3, 80)
        Me.lblDateExpedicion.Name = "lblDateExpedicion"
        Me.lblDateExpedicion.Size = New System.Drawing.Size(126, 13)
        Me.lblDateExpedicion.TabIndex = 3
        Me.lblDateExpedicion.Text = "Fecha de Expedicion"
        '
        'lblDateExpiracion
        '
        Me.lblDateExpiracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateExpiracion.AutoSize = True
        Me.lblDateExpiracion.ForeColor = System.Drawing.Color.White
        Me.lblDateExpiracion.Location = New System.Drawing.Point(3, 105)
        Me.lblDateExpiracion.Name = "lblDateExpiracion"
        Me.lblDateExpiracion.Size = New System.Drawing.Size(126, 13)
        Me.lblDateExpiracion.TabIndex = 4
        Me.lblDateExpiracion.Text = "Fecha de Expiracion"
        '
        'lblDonador
        '
        Me.lblDonador.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDonador.AutoSize = True
        Me.lblDonador.ForeColor = System.Drawing.Color.White
        Me.lblDonador.Location = New System.Drawing.Point(3, 130)
        Me.lblDonador.Name = "lblDonador"
        Me.lblDonador.Size = New System.Drawing.Size(126, 13)
        Me.lblDonador.TabIndex = 5
        Me.lblDonador.Text = "Donador de Organos"
        '
        'lblContactoEmergencia
        '
        Me.lblContactoEmergencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblContactoEmergencia.AutoSize = True
        Me.lblContactoEmergencia.ForeColor = System.Drawing.Color.White
        Me.lblContactoEmergencia.Location = New System.Drawing.Point(3, 155)
        Me.lblContactoEmergencia.Name = "lblContactoEmergencia"
        Me.lblContactoEmergencia.Size = New System.Drawing.Size(126, 13)
        Me.lblContactoEmergencia.TabIndex = 6
        Me.lblContactoEmergencia.Text = "Contacto de Emergencia"
        '
        'lblTelefonoEmergencia
        '
        Me.lblTelefonoEmergencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTelefonoEmergencia.AutoSize = True
        Me.lblTelefonoEmergencia.ForeColor = System.Drawing.Color.White
        Me.lblTelefonoEmergencia.Location = New System.Drawing.Point(3, 180)
        Me.lblTelefonoEmergencia.Name = "lblTelefonoEmergencia"
        Me.lblTelefonoEmergencia.Size = New System.Drawing.Size(126, 13)
        Me.lblTelefonoEmergencia.TabIndex = 7
        Me.lblTelefonoEmergencia.Text = "Telefono de Emergencia"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblIdLicencia, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTelefonoEmergencia, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCurp, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblContactoEmergencia, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTipoLicencia, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDonador, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDateExpedicion, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDateExpiracion, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtIdLicencia, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCurp, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dateExpedicion, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.dateExpiracion, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtContactoEmergencia, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNumeroEmergencia, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tblDonador, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cbTipoLicencia, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(440, 200)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'txtIdLicencia
        '
        Me.txtIdLicencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdLicencia.Location = New System.Drawing.Point(135, 3)
        Me.txtIdLicencia.Name = "txtIdLicencia"
        Me.txtIdLicencia.Size = New System.Drawing.Size(302, 20)
        Me.txtIdLicencia.TabIndex = 8
        '
        'txtCurp
        '
        Me.txtCurp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCurp.Location = New System.Drawing.Point(135, 27)
        Me.txtCurp.MaxLength = 18
        Me.txtCurp.Name = "txtCurp"
        Me.txtCurp.Size = New System.Drawing.Size(302, 20)
        Me.txtCurp.TabIndex = 9
        '
        'dateExpedicion
        '
        Me.dateExpedicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateExpedicion.Location = New System.Drawing.Point(135, 77)
        Me.dateExpedicion.Name = "dateExpedicion"
        Me.dateExpedicion.Size = New System.Drawing.Size(302, 20)
        Me.dateExpedicion.TabIndex = 11
        '
        'dateExpiracion
        '
        Me.dateExpiracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateExpiracion.Location = New System.Drawing.Point(135, 102)
        Me.dateExpiracion.Name = "dateExpiracion"
        Me.dateExpiracion.Size = New System.Drawing.Size(302, 20)
        Me.dateExpiracion.TabIndex = 12
        '
        'chkSiDonador
        '
        Me.chkSiDonador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.chkSiDonador.AutoSize = True
        Me.chkSiDonador.ForeColor = System.Drawing.Color.White
        Me.chkSiDonador.Location = New System.Drawing.Point(59, 3)
        Me.chkSiDonador.Name = "chkSiDonador"
        Me.chkSiDonador.Size = New System.Drawing.Size(35, 19)
        Me.chkSiDonador.TabIndex = 0
        Me.chkSiDonador.Text = "Si"
        Me.chkSiDonador.UseVisualStyleBackColor = True
        '
        'chkNoDonador
        '
        Me.chkNoDonador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.chkNoDonador.AutoSize = True
        Me.chkNoDonador.ForeColor = System.Drawing.Color.White
        Me.chkNoDonador.Location = New System.Drawing.Point(211, 3)
        Me.chkNoDonador.Name = "chkNoDonador"
        Me.chkNoDonador.Size = New System.Drawing.Size(40, 19)
        Me.chkNoDonador.TabIndex = 1
        Me.chkNoDonador.Text = "No"
        Me.chkNoDonador.UseVisualStyleBackColor = True
        '
        'txtContactoEmergencia
        '
        Me.txtContactoEmergencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContactoEmergencia.Location = New System.Drawing.Point(135, 152)
        Me.txtContactoEmergencia.Name = "txtContactoEmergencia"
        Me.txtContactoEmergencia.Size = New System.Drawing.Size(302, 20)
        Me.txtContactoEmergencia.TabIndex = 14
        '
        'txtNumeroEmergencia
        '
        Me.txtNumeroEmergencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroEmergencia.Location = New System.Drawing.Point(135, 177)
        Me.txtNumeroEmergencia.Name = "txtNumeroEmergencia"
        Me.txtNumeroEmergencia.Size = New System.Drawing.Size(302, 20)
        Me.txtNumeroEmergencia.TabIndex = 15
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
        Me.tblBotones.Location = New System.Drawing.Point(12, 218)
        Me.tblBotones.Name = "tblBotones"
        Me.tblBotones.RowCount = 1
        Me.tblBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblBotones.Size = New System.Drawing.Size(440, 25)
        Me.tblBotones.TabIndex = 9
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(27, 1)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(110, 23)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEliminar.Location = New System.Drawing.Point(301, 1)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(110, 23)
        Me.btnEliminar.TabIndex = 21
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Location = New System.Drawing.Point(164, 1)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(110, 23)
        Me.btnModificar.TabIndex = 20
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'tblDonador
        '
        Me.tblDonador.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblDonador.ColumnCount = 2
        Me.tblDonador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDonador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDonador.Controls.Add(Me.chkSiDonador, 0, 0)
        Me.tblDonador.Controls.Add(Me.chkNoDonador, 1, 0)
        Me.tblDonador.Location = New System.Drawing.Point(132, 124)
        Me.tblDonador.Margin = New System.Windows.Forms.Padding(0)
        Me.tblDonador.Name = "tblDonador"
        Me.tblDonador.RowCount = 1
        Me.tblDonador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDonador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblDonador.Size = New System.Drawing.Size(308, 25)
        Me.tblDonador.TabIndex = 16
        '
        'cbTipoLicencia
        '
        Me.cbTipoLicencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipoLicencia.FormattingEnabled = True
        Me.cbTipoLicencia.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "B", "C", "D", "E", "F"})
        Me.cbTipoLicencia.Location = New System.Drawing.Point(135, 52)
        Me.cbTipoLicencia.Name = "cbTipoLicencia"
        Me.cbTipoLicencia.Size = New System.Drawing.Size(302, 21)
        Me.cbTipoLicencia.TabIndex = 10
        '
        'RegistrarLicencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(464, 258)
        Me.Controls.Add(Me.tblBotones)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrarLicencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarLicencias"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txtIdLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblBotones.ResumeLayout(False)
        Me.tblDonador.ResumeLayout(False)
        Me.tblDonador.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblIdLicencia As Label
    Friend WithEvents lblCurp As Label
    Friend WithEvents lblTipoLicencia As Label
    Friend WithEvents lblDateExpedicion As Label
    Friend WithEvents lblDateExpiracion As Label
    Friend WithEvents lblDonador As Label
    Friend WithEvents lblContactoEmergencia As Label
    Friend WithEvents lblTelefonoEmergencia As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtIdLicencia As NumericUpDown
    Friend WithEvents txtCurp As TextBox
    Friend WithEvents dateExpedicion As DateTimePicker
    Friend WithEvents dateExpiracion As DateTimePicker
    Friend WithEvents chkSiDonador As CheckBox
    Friend WithEvents chkNoDonador As CheckBox
    Friend WithEvents txtContactoEmergencia As TextBox
    Friend WithEvents txtNumeroEmergencia As TextBox
    Friend WithEvents tblDonador As TableLayoutPanel
    Friend WithEvents tblBotones As TableLayoutPanel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents cbTipoLicencia As ComboBox
End Class
