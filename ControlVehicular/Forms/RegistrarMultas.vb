Public Class RegistrarMultas
    Dim multa As Multa = New Multa()

    Public Sub New()
        InitializeComponent()
        poblarDatosMulta(multa.BuscarUltimoId() + 1)
    End Sub

    Public Sub New(idMulta As Integer)
        InitializeComponent()
        poblarDatosMulta(idMulta)
    End Sub

    Private Sub RegistrarMultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub poblarDatosMulta(idMulta As Integer)
        Me.multa = New Multa()

        If multa.BuscarMultaById(idMulta) Then
            Me.txtIdMulta.Value = multa.GetIdMulta()
            Me.txtIdPlacas.Text = multa.GetIdPlacas()
            Me.txtImporte.Value = multa.GetImporte()
            Me.dateExpedicion.Value = multa.GetFechaExpedicion()
            Me.txtDescripcion.Text = multa.GetDescripcion()
        Else
            limpiarDatos()
        End If
    End Sub

    Private Sub limpiarDatos()
        Me.multa = New Multa()

        Me.txtIdMulta.Value = multa.BuscarUltimoId() + 1
        Me.txtIdPlacas.Text = ""
        Me.txtImporte.Value = 0.00
        Me.dateExpedicion.Value = Date.Now
        Me.txtDescripcion.Text = ""
    End Sub

    Private Sub txtIdMulta_ValueChanged(sender As Object, e As EventArgs) Handles txtIdMulta.ValueChanged
        poblarDatosMulta(Me.txtIdMulta.Value)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim placas As Placas = New Placas()

        If Me.txtIdPlacas.Text.Length < 6 Then
            MsgBox("Insuficientes caracteres en la placa." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If multa.BuscarMultaById(Me.txtIdMulta.Value) Then
            MsgBox("No se pudo registrar multa." + vbNewLine + "id ya en uso.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not placas.BuscarPlacasById(Me.txtIdPlacas.Text) Then
            MsgBox("No se pudo registrar multa." + vbNewLine + "Placas no encontradas.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Me.multa = New Multa()
        Me.multa.SetIdMulta(Me.txtIdMulta.Value)
        Me.multa.SetIdPlacas(Me.txtIdPlacas.Text)
        Me.multa.SetImporte(Me.txtImporte.Value)
        Me.multa.SetFechaExpedicion(Me.dateExpedicion.Value)
        Me.multa.SetDescripcion(Me.txtDescripcion.Text)

        If Not Me.multa.RegistrarMulta() Then
            MsgBox("No se pudo registrar multa." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        limpiarDatos()
        MsgBox("Multa Registrada Exitosamente.", MsgBoxStyle.Information, "Correcto")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim placas As Placas = New Placas()

        If Me.txtIdPlacas.Text.Length < 6 Then
            MsgBox("Insuficientes caracteres en la placa." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not multa.BuscarMultaById(Me.txtIdMulta.Value) Then
            MsgBox("No se pudo registrar multa." + vbNewLine + "No se encontro registro con ese ID.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not placas.BuscarPlacasById(Me.txtIdPlacas.Text) Then
            MsgBox("No se pudo registrar multa." + vbNewLine + "Placas no encontradas.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Me.multa = New Multa()
        Me.multa.SetIdMulta(Me.txtIdMulta.Value)
        Me.multa.SetIdPlacas(Me.txtIdPlacas.Text)
        Me.multa.SetImporte(Me.txtImporte.Value)
        Me.multa.SetFechaExpedicion(Me.dateExpedicion.Value)
        Me.multa.SetDescripcion(Me.txtDescripcion.Text)

        If Not Me.multa.ActualizarMulta() Then
            MsgBox("No se pudo actualizar multa." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        MsgBox("Multa Registrada Exitosamente.", MsgBoxStyle.Information, "Correcto")
        Me.Close()
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Dim placas As Placas = New Placas()

        If Me.txtIdPlacas.Text.Length < 6 Then
            MsgBox("Insuficientes caracteres en la placa." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not multa.BuscarMultaById(Me.txtIdMulta.Value) Then
            MsgBox("No se pudo registrar multa." + vbNewLine + "No se encontro registro con ese ID.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not placas.BuscarPlacasById(Me.txtIdPlacas.Text) Then
            MsgBox("No se pudo registrar multa." + vbNewLine + "Placas no encontradas.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Me.multa = New Multa()
        Me.multa.SetIdMulta(Me.txtIdMulta.Value)
        Me.multa.SetIdPlacas(Me.txtIdPlacas.Text)
        Me.multa.SetImporte(Me.txtImporte.Value)
        Me.multa.SetFechaExpedicion(Me.dateExpedicion.Value)
        Me.multa.SetFechaLiquidacion(Date.Now.Date)
        Me.multa.SetDescripcion(Me.txtDescripcion.Text)

        If Not Me.multa.ActualizarMulta() Then
            MsgBox("No se pudo actualizar multa." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        MsgBox("Multa Pagada Exitosamente.", MsgBoxStyle.Information, "Correcto")
        Me.Close()
    End Sub
End Class