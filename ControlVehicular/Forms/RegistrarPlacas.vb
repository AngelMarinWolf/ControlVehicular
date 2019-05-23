Public Class RegistrarPlacas
    Dim placas As New Placas()

    Private Sub RegistrarPlacas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub idPlaca_TextChanged(sender As Object, e As EventArgs) Handles txtIdPlacas.TextChanged
        poblarDatosPlacas(Me.txtIdPlacas.Text)
    End Sub

    Private Sub poblarDatosPlacas(idPlacas As String)
        If Me.placas.BuscarPlacasById(idPlacas) Then
            Me.txtIdPlacas.Text = Me.placas.GetIdPlacas()
            Me.txtIdLicencia.Value = Me.placas.GetIdLicencia()
            Me.cbNoSerie.SelectedValue = Me.placas.GetIdVehiculo()
        Else
            limpiarDatos()
        End If
    End Sub

    Private Sub limpiarDatos()
        Me.placas = New Placas()

        Me.txtIdLicencia.Value = 0
        Me.cbNoSerie.SelectedItem = ""
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim licencia As New Licencia()
        Dim vehiculo As New Padron()

        If Me.txtIdPlacas.Text.Length < 7 Then
            MsgBox("Insuficientes caracteres para el numero de Placas." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If placas.BuscarPlacasById(Me.txtIdPlacas.Text) Then
            MsgBox("No se pudo registrar placas." + vbNewLine + "id ya en uso.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not licencia.BuscarLicenciaById(Me.txtIdLicencia.Value) Then
            MsgBox("No se pudo registrar placas." + vbNewLine + "Licencia no registrada en el sistema.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Me.placas = New Placas()
        Me.placas.SetIdPlacas(Me.txtIdPlacas.Text)
        Me.placas.SetIdLicencia(Me.txtIdLicencia.Value)
        Me.placas.SetIdVehiculo(Me.cbNoSerie.SelectedValue)

        If Not Me.placas.RegistrarPlacas() Then
            MsgBox("No se pudo registrar placa." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        limpiarDatos()
        MsgBox("Nuevas Placas Registradas Exitosamente.", MsgBoxStyle.Information, "Correcto")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim licencia As New Licencia()
        Dim vehiculo As New Padron()

        If Me.txtIdPlacas.Text.Length < 7 Then
            MsgBox("Insuficientes caracteres para el numero de Placas." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not Me.placas.BuscarPlacasById(Me.txtIdPlacas.Text) Then
            MsgBox("No se pudo actualizar placas." + vbNewLine + "No se encontro registro con ese ID.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not licencia.BuscarLicenciaById(Me.txtIdLicencia.Value) Then
            MsgBox("No se pudo registrar placas." + vbNewLine + "Licencia no registrada en el sistema.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Me.placas = New Placas()
        Me.placas.SetIdPlacas(Me.txtIdPlacas.Text)
        Me.placas.SetIdLicencia(Me.txtIdLicencia.Value)
        Me.placas.SetIdVehiculo(Me.cbNoSerie.SelectedValue)

        If Not Me.placas.ActualizarPlacas() Then
            MsgBox("No se pudo actualizar placas." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        MsgBox("Vehiculo Registrado Exitosamente.", MsgBoxStyle.Information, "Correcto")
        limpiarDatos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim multa As New Multa()
        If MsgBox("Desea eliminar registro?." + vbNewLine + "Por favor confirme.", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me.txtIdPlacas.Text.Length < 7 Then
            MsgBox("Insuficientes caracteres para el numero de Placas." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not Me.placas.BuscarPlacasById(Me.txtIdPlacas.Text) Then
            MsgBox("No se pudo actualizar placas." + vbNewLine + "No se encontro registro con ese ID.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If multa.BuscarMultasByPlacas(Me.txtIdPlacas.Text).Rows.Count > 0 Then
            MsgBox("No se pudo eliminar placas." + vbNewLine + "Hay Multas Activas.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not Me.placas.EliminarPlacas() Then
            MsgBox("No se pudo eliminar Placas." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        MsgBox("Placas Eliminadas Exitosamente.", MsgBoxStyle.Information, "Correcto")
        limpiarDatos()
    End Sub

    Private Sub txtIdLicencia_ValueChanged(sender As Object, e As EventArgs) Handles txtIdLicencia.ValueChanged
        Dim padron As New Padron()
        padron.PoblarComboNoSerieByLicencia(Me.cbNoSerie, Me.txtIdLicencia.Value)
    End Sub
End Class