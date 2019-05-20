<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarMultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarMultas))
        Me.lblPlacas = New System.Windows.Forms.Label()
        Me.txtIdPlacas = New System.Windows.Forms.TextBox()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblFolio = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.dateExpedicion = New System.Windows.Forms.DateTimePicker()
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.tblBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.grpDescripcion = New System.Windows.Forms.GroupBox()
        Me.txtIdMulta = New System.Windows.Forms.NumericUpDown()
        Me.txtImporte = New System.Windows.Forms.NumericUpDown()
        Me.tblHeader.SuspendLayout()
        Me.tblBotones.SuspendLayout()
        Me.grpDescripcion.SuspendLayout()
        CType(Me.txtIdMulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPlacas
        '
        Me.lblPlacas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPlacas.AutoSize = True
        Me.lblPlacas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPlacas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPlacas.Location = New System.Drawing.Point(307, 10)
        Me.lblPlacas.Name = "lblPlacas"
        Me.lblPlacas.Size = New System.Drawing.Size(85, 13)
        Me.lblPlacas.TabIndex = 125
        Me.lblPlacas.Text = "Placas"
        '
        'txtIdPlacas
        '
        Me.txtIdPlacas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdPlacas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdPlacas.Location = New System.Drawing.Point(398, 7)
        Me.txtIdPlacas.MaxLength = 8
        Me.txtIdPlacas.Name = "txtIdPlacas"
        Me.txtIdPlacas.Size = New System.Drawing.Size(209, 20)
        Me.txtIdPlacas.TabIndex = 124
        '
        'lblImporte
        '
        Me.lblImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblImporte.AutoSize = True
        Me.lblImporte.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblImporte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblImporte.Location = New System.Drawing.Point(3, 44)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(85, 13)
        Me.lblImporte.TabIndex = 115
        Me.lblImporte.Text = "Monto a pagar"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.Location = New System.Drawing.Point(6, 18)
        Me.txtDescripcion.MaxLength = 400
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(598, 121)
        Me.txtDescripcion.TabIndex = 112
        '
        'lblFolio
        '
        Me.lblFolio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFolio.AutoSize = True
        Me.lblFolio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblFolio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFolio.Location = New System.Drawing.Point(3, 10)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(85, 13)
        Me.lblFolio.TabIndex = 109
        Me.lblFolio.Text = "Folio"
        '
        'Fecha
        '
        Me.Fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fecha.AutoSize = True
        Me.Fecha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Fecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Fecha.Location = New System.Drawing.Point(307, 38)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(85, 26)
        Me.Fecha.TabIndex = 108
        Me.Fecha.Text = "Fecha Expedición"
        '
        'dateExpedicion
        '
        Me.dateExpedicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateExpedicion.CustomFormat = ""
        Me.dateExpedicion.Location = New System.Drawing.Point(398, 41)
        Me.dateExpedicion.Name = "dateExpedicion"
        Me.dateExpedicion.Size = New System.Drawing.Size(209, 20)
        Me.dateExpedicion.TabIndex = 126
        Me.dateExpedicion.Value = New Date(2019, 5, 19, 17, 14, 47, 0)
        '
        'tblHeader
        '
        Me.tblHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblHeader.ColumnCount = 4
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tblHeader.Controls.Add(Me.lblFolio, 0, 0)
        Me.tblHeader.Controls.Add(Me.dateExpedicion, 3, 1)
        Me.tblHeader.Controls.Add(Me.lblPlacas, 2, 0)
        Me.tblHeader.Controls.Add(Me.txtIdPlacas, 3, 0)
        Me.tblHeader.Controls.Add(Me.lblImporte, 0, 1)
        Me.tblHeader.Controls.Add(Me.Fecha, 2, 1)
        Me.tblHeader.Controls.Add(Me.txtIdMulta, 1, 0)
        Me.tblHeader.Controls.Add(Me.txtImporte, 1, 1)
        Me.tblHeader.Location = New System.Drawing.Point(12, 12)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblHeader.Size = New System.Drawing.Size(610, 68)
        Me.tblHeader.TabIndex = 127
        '
        'tblBotones
        '
        Me.tblBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblBotones.ColumnCount = 5
        Me.tblBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.tblBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.tblBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.tblBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.tblBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.tblBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblBotones.Controls.Add(Me.btnAgregar, 1, 0)
        Me.tblBotones.Controls.Add(Me.btnModificar, 3, 0)
        Me.tblBotones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tblBotones.Location = New System.Drawing.Point(12, 237)
        Me.tblBotones.Name = "tblBotones"
        Me.tblBotones.RowCount = 1
        Me.tblBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblBotones.Size = New System.Drawing.Size(610, 25)
        Me.tblBotones.TabIndex = 128
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(55, 1)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(221, 23)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Location = New System.Drawing.Point(331, 1)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(221, 23)
        Me.btnModificar.TabIndex = 20
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'grpDescripcion
        '
        Me.grpDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDescripcion.Controls.Add(Me.txtDescripcion)
        Me.grpDescripcion.Location = New System.Drawing.Point(12, 86)
        Me.grpDescripcion.Name = "grpDescripcion"
        Me.grpDescripcion.Size = New System.Drawing.Size(610, 145)
        Me.grpDescripcion.TabIndex = 129
        Me.grpDescripcion.TabStop = False
        Me.grpDescripcion.Text = "Motivo de la Infraccion"
        '
        'txtIdMulta
        '
        Me.txtIdMulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdMulta.Location = New System.Drawing.Point(94, 7)
        Me.txtIdMulta.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.txtIdMulta.Name = "txtIdMulta"
        Me.txtIdMulta.Size = New System.Drawing.Size(207, 20)
        Me.txtIdMulta.TabIndex = 127
        '
        'txtImporte
        '
        Me.txtImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporte.DecimalPlaces = 2
        Me.txtImporte.Location = New System.Drawing.Point(94, 41)
        Me.txtImporte.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(207, 20)
        Me.txtImporte.TabIndex = 128
        '
        'RegistrarMultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 274)
        Me.Controls.Add(Me.grpDescripcion)
        Me.Controls.Add(Me.tblBotones)
        Me.Controls.Add(Me.tblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrarMultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Multas"
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        Me.tblBotones.ResumeLayout(False)
        Me.grpDescripcion.ResumeLayout(False)
        Me.grpDescripcion.PerformLayout()
        CType(Me.txtIdMulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPlacas As Label
    Friend WithEvents txtIdPlacas As TextBox
    Friend WithEvents lblImporte As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblFolio As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents dateExpedicion As DateTimePicker
    Friend WithEvents tblHeader As TableLayoutPanel
    Friend WithEvents tblBotones As TableLayoutPanel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents grpDescripcion As GroupBox
    Friend WithEvents txtIdMulta As NumericUpDown
    Friend WithEvents txtImporte As NumericUpDown
End Class
