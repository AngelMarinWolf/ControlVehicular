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
        Me.Placas = New System.Windows.Forms.Label()
        Me.idPlacas = New System.Windows.Forms.TextBox()
        Me.Importe = New System.Windows.Forms.TextBox()
        Me.MontoPagar = New System.Windows.Forms.Label()
        Me.txtDescricion = New System.Windows.Forms.TextBox()
        Me.idMulta = New System.Windows.Forms.TextBox()
        Me.Folio = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.tblBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tblHeader.SuspendLayout()
        Me.tblBotones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Placas
        '
        Me.Placas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Placas.AutoSize = True
        Me.Placas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Placas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Placas.Location = New System.Drawing.Point(307, 10)
        Me.Placas.Name = "Placas"
        Me.Placas.Size = New System.Drawing.Size(85, 13)
        Me.Placas.TabIndex = 125
        Me.Placas.Text = "Placas"
        '
        'idPlacas
        '
        Me.idPlacas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.idPlacas.Location = New System.Drawing.Point(398, 7)
        Me.idPlacas.Name = "idPlacas"
        Me.idPlacas.Size = New System.Drawing.Size(209, 20)
        Me.idPlacas.TabIndex = 124
        '
        'Importe
        '
        Me.Importe.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Importe.Location = New System.Drawing.Point(94, 41)
        Me.Importe.Name = "Importe"
        Me.Importe.Size = New System.Drawing.Size(207, 20)
        Me.Importe.TabIndex = 116
        '
        'MontoPagar
        '
        Me.MontoPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MontoPagar.AutoSize = True
        Me.MontoPagar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MontoPagar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MontoPagar.Location = New System.Drawing.Point(3, 44)
        Me.MontoPagar.Name = "MontoPagar"
        Me.MontoPagar.Size = New System.Drawing.Size(85, 13)
        Me.MontoPagar.TabIndex = 115
        Me.MontoPagar.Text = "Monto a pagar"
        '
        'txtDescricion
        '
        Me.txtDescricion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricion.Location = New System.Drawing.Point(6, 18)
        Me.txtDescricion.Multiline = True
        Me.txtDescricion.Name = "txtDescricion"
        Me.txtDescricion.Size = New System.Drawing.Size(598, 121)
        Me.txtDescricion.TabIndex = 112
        '
        'idMulta
        '
        Me.idMulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.idMulta.Location = New System.Drawing.Point(94, 7)
        Me.idMulta.Name = "idMulta"
        Me.idMulta.Size = New System.Drawing.Size(207, 20)
        Me.idMulta.TabIndex = 111
        '
        'Folio
        '
        Me.Folio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Folio.AutoSize = True
        Me.Folio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Folio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Folio.Location = New System.Drawing.Point(3, 10)
        Me.Folio.Name = "Folio"
        Me.Folio.Size = New System.Drawing.Size(85, 13)
        Me.Folio.TabIndex = 109
        Me.Folio.Text = "Folio"
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Location = New System.Drawing.Point(398, 41)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(209, 20)
        Me.DateTimePicker1.TabIndex = 126
        Me.DateTimePicker1.Value = New Date(2019, 5, 19, 17, 14, 47, 0)
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
        Me.tblHeader.Controls.Add(Me.Folio, 0, 0)
        Me.tblHeader.Controls.Add(Me.DateTimePicker1, 3, 1)
        Me.tblHeader.Controls.Add(Me.Placas, 2, 0)
        Me.tblHeader.Controls.Add(Me.idPlacas, 3, 0)
        Me.tblHeader.Controls.Add(Me.idMulta, 1, 0)
        Me.tblHeader.Controls.Add(Me.MontoPagar, 0, 1)
        Me.tblHeader.Controls.Add(Me.Importe, 1, 1)
        Me.tblHeader.Controls.Add(Me.Fecha, 2, 1)
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
        Me.btnAgregar.Location = New System.Drawing.Point(38, 1)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(152, 23)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEliminar.Location = New System.Drawing.Point(418, 1)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(152, 23)
        Me.btnEliminar.TabIndex = 21
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Location = New System.Drawing.Point(228, 1)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(152, 23)
        Me.btnModificar.TabIndex = 20
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtDescricion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 145)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Motivo de la Infraccion"
        '
        'RegistrarMultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 274)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tblBotones)
        Me.Controls.Add(Me.tblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrarMultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multas"
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        Me.tblBotones.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Placas As Label
    Friend WithEvents idPlacas As TextBox
    Friend WithEvents Importe As TextBox
    Friend WithEvents MontoPagar As Label
    Friend WithEvents txtDescricion As TextBox
    Friend WithEvents idMulta As TextBox
    Friend WithEvents Folio As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents tblHeader As TableLayoutPanel
    Friend WithEvents tblBotones As TableLayoutPanel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
