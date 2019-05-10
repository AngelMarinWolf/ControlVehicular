<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Multas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Multas))
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Importe = New System.Windows.Forms.TextBox()
        Me.MontoPagar = New System.Windows.Forms.Label()
        Me.EstatusMulta = New System.Windows.Forms.Label()
        Me.Retribuido = New System.Windows.Forms.TextBox()
        Me.Descripcion = New System.Windows.Forms.TextBox()
        Me.idMulta = New System.Windows.Forms.TextBox()
        Me.MotivoInfraccionar = New System.Windows.Forms.Label()
        Me.Folio = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Paterno = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FechaExpedicionMulta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FechaLiquidacionMulta = New System.Windows.Forms.TextBox()
        Me.Placas = New System.Windows.Forms.Label()
        Me.idPlacas = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agregar
        '
        resources.ApplyResources(Me.Agregar, "Agregar")
        Me.Agregar.Name = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Importe
        '
        resources.ApplyResources(Me.Importe, "Importe")
        Me.Importe.Name = "Importe"
        '
        'MontoPagar
        '
        resources.ApplyResources(Me.MontoPagar, "MontoPagar")
        Me.MontoPagar.Name = "MontoPagar"
        '
        'EstatusMulta
        '
        resources.ApplyResources(Me.EstatusMulta, "EstatusMulta")
        Me.EstatusMulta.Name = "EstatusMulta"
        '
        'Retribuido
        '
        resources.ApplyResources(Me.Retribuido, "Retribuido")
        Me.Retribuido.Name = "Retribuido"
        '
        'Descripcion
        '
        resources.ApplyResources(Me.Descripcion, "Descripcion")
        Me.Descripcion.Name = "Descripcion"
        '
        'idMulta
        '
        resources.ApplyResources(Me.idMulta, "idMulta")
        Me.idMulta.Name = "idMulta"
        '
        'MotivoInfraccionar
        '
        resources.ApplyResources(Me.MotivoInfraccionar, "MotivoInfraccionar")
        Me.MotivoInfraccionar.Name = "MotivoInfraccionar"
        '
        'Folio
        '
        resources.ApplyResources(Me.Folio, "Folio")
        Me.Folio.Name = "Folio"
        '
        'Fecha
        '
        resources.ApplyResources(Me.Fecha, "Fecha")
        Me.Fecha.Name = "Fecha"
        '
        'TextBox3
        '
        resources.ApplyResources(Me.TextBox3, "TextBox3")
        Me.TextBox3.Name = "TextBox3"
        '
        'Paterno
        '
        resources.ApplyResources(Me.Paterno, "Paterno")
        Me.Paterno.Name = "Paterno"
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'Nombre
        '
        resources.ApplyResources(Me.Nombre, "Nombre")
        Me.Nombre.Name = "Nombre"
        '
        'Modificar
        '
        resources.ApplyResources(Me.Modificar, "Modificar")
        Me.Modificar.Name = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        resources.ApplyResources(Me.Eliminar, "Eliminar")
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        '
        'FechaExpedicionMulta
        '
        resources.ApplyResources(Me.FechaExpedicionMulta, "FechaExpedicionMulta")
        Me.FechaExpedicionMulta.Name = "FechaExpedicionMulta"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'FechaLiquidacionMulta
        '
        resources.ApplyResources(Me.FechaLiquidacionMulta, "FechaLiquidacionMulta")
        Me.FechaLiquidacionMulta.Name = "FechaLiquidacionMulta"
        '
        'Placas
        '
        resources.ApplyResources(Me.Placas, "Placas")
        Me.Placas.Name = "Placas"
        '
        'idPlacas
        '
        resources.ApplyResources(Me.idPlacas, "idPlacas")
        Me.idPlacas.Name = "idPlacas"
        '
        'Multas
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Placas)
        Me.Controls.Add(Me.idPlacas)
        Me.Controls.Add(Me.FechaLiquidacionMulta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FechaExpedicionMulta)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.Importe)
        Me.Controls.Add(Me.MontoPagar)
        Me.Controls.Add(Me.EstatusMulta)
        Me.Controls.Add(Me.Retribuido)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.idMulta)
        Me.Controls.Add(Me.MotivoInfraccionar)
        Me.Controls.Add(Me.Folio)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Paterno)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Nombre)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Multas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Agregar As Button
    Friend WithEvents Importe As TextBox
    Friend WithEvents MontoPagar As Label
    Friend WithEvents EstatusMulta As Label
    Friend WithEvents Retribuido As TextBox
    Friend WithEvents Descripcion As TextBox
    Friend WithEvents idMulta As TextBox
    Friend WithEvents MotivoInfraccionar As Label
    Friend WithEvents Folio As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Paterno As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Nombre As Label
    Friend WithEvents Modificar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FechaExpedicionMulta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FechaLiquidacionMulta As TextBox
    Friend WithEvents Placas As Label
    Friend WithEvents idPlacas As TextBox
End Class
