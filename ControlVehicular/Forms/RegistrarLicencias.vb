Public Class RegistrarLicencias
    Dim licencia As New Licencia()
    Private Sub RegistrarLicencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtIdLicencia.Value = licencia.BuscarUltimoId() + 1
        Me.cbTipoLicencia.SelectedItem = "A"
        Me.dateExpedicion.Value = Date.Now
        Me.dateExpiracion.Value = Date.Now.AddYears(3)
    End Sub

    Private Sub poblarDatosLicencia(idLicencia As Integer)
        If Me.licencia.BuscarLicenciaById(idLicencia) Then
            Me.txtCurp.Text = Me.licencia.GetIdContribuyente()
            Me.cbTipoLicencia.SelectedItem = Me.licencia.GetTipo()
            Me.dateExpedicion.Value = Me.licencia.GetFechaExpedicion()
            Me.dateExpiracion.Value = Me.licencia.GetFechaExpiracion()
            If Me.licencia.GetEstadoDonador Then
                Me.chkSiDonador.Checked = True
                Me.chkNoDonador.Checked = False
            Else
                Me.chkSiDonador.Checked = False
                Me.chkNoDonador.Checked = True
            End If
            Me.txtContactoEmergencia.Text = Me.licencia.GetContactoEmergencia()
            Me.txtNumeroEmergencia.Text = Me.licencia.GetTelefonoEmergencia()
        Else
            limpiarDatos()
        End If
    End Sub

    Private Sub limpiarDatos()
        Me.licencia = New Licencia()

        Me.txtIdLicencia.Value = licencia.BuscarUltimoId() + 1
        Me.txtCurp.Text = ""
        Me.cbTipoLicencia.SelectedItem = "A"
        Me.dateExpedicion.Value = Date.Now
        Me.dateExpiracion.Value = Date.Now.AddYears(3)
        Me.chkSiDonador.Checked = True
        Me.chkNoDonador.Checked = False
        Me.txtContactoEmergencia.Text = ""
        Me.txtNumeroEmergencia.Text = ""
    End Sub

    Private Sub txtIdLicencia_ValueChanged(sender As Object, e As EventArgs) Handles txtIdLicencia.ValueChanged
        poblarDatosLicencia(Me.txtIdLicencia.Value)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim contribuyente As New Contribuyente()

        If Me.txtCurp.Text.Length <> 18 Then
            MsgBox("Insuficientes caracteres en la curp." + vbNewLine +
                   "Inserte los 18 caracteres correspondientes." + vbNewLine +
                   "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Me.txtContactoEmergencia.Text.Length = 0 And Me.txtNumeroEmergencia.Text.Length = 0 Then
            MsgBox("Por favor agrege informacion para el contacto de emergencia.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Me.txtIdLicencia.Value <> Me.licencia.BuscarUltimoId() + 1 Then
            MsgBox("No se esta permitido agregar ids de forma manual." + vbNewLine +
                   "Utilice el ultimo valor maximo disponible en el elemento.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If licencia.BuscarLicenciaById(Me.txtIdLicencia.Value) Then
            MsgBox("No se pudo registrar licencia." + vbNewLine + "id ya en uso.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not contribuyente.BuscarContribuyenteById(Me.txtCurp.Text) Then
            MsgBox("No se pudo registrar licencia." + vbNewLine + "Contribuyente no registrada en el sistema.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Me.licencia = New Licencia()
        Me.licencia.SetIdLicencia(Me.txtIdLicencia.Value)
        Me.licencia.SetIdContribuyente(Me.txtCurp.Text)
        Me.licencia.SetTipo(Me.cbTipoLicencia.SelectedItem)
        Me.licencia.SetFechaExpedicion(Me.dateExpedicion.Value)
        Me.licencia.SetFechaExpiracion(Me.dateExpiracion.Value)
        Me.licencia.SetDonadorOrganos(Me.chkSiDonador.Checked)
        Me.licencia.SetContactoEmergencia(Me.txtContactoEmergencia.Text)
        Me.licencia.SetTelefonoEmergencia(Me.txtNumeroEmergencia.Text)

        If Not Me.licencia.RegistrarLicencia() Then
            MsgBox("No se pudo registrar licencia." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        limpiarDatos()
        MsgBox("Licencia Registradas Exitosamente.", MsgBoxStyle.Information, "Correcto")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim contribuyente As New Contribuyente()

        If Me.txtCurp.Text.Length <> 18 Then
            MsgBox("Insuficientes caracteres en la curp." + vbNewLine +
                   "Inserte los 18 caracteres correspondientes." + vbNewLine +
                   "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Me.txtContactoEmergencia.Text.Length = 0 And Me.txtNumeroEmergencia.Text.Length = 0 Then
            MsgBox("Por favor agrege informacion para el contacto de emergencia.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not Me.licencia.BuscarLicenciaById(Me.txtIdLicencia.Value) Then
            MsgBox("No se pudo actualizar licencia." + vbNewLine + "No se encontro registro con ese ID.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not contribuyente.BuscarContribuyenteById(Me.txtCurp.Text) Then
            MsgBox("No se pudo registrar licencia." + vbNewLine + "Contribuyente no registrada en el sistema.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Me.licencia = New Licencia()
        Me.licencia.SetIdLicencia(Me.txtIdLicencia.Value)
        Me.licencia.SetIdContribuyente(Me.txtCurp.Text)
        Me.licencia.SetTipo(Me.cbTipoLicencia.SelectedItem)
        Me.licencia.SetFechaExpedicion(Me.dateExpedicion.Value)
        Me.licencia.SetFechaExpiracion(Me.dateExpiracion.Value)
        Me.licencia.SetDonadorOrganos(Me.chkSiDonador.Checked)
        Me.licencia.SetContactoEmergencia(Me.txtContactoEmergencia.Text)
        Me.licencia.SetTelefonoEmergencia(Me.txtNumeroEmergencia.Text)

        If Not Me.licencia.ActualizarLicencia() Then
            MsgBox("No se pudo actualizar licencia." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        MsgBox("Licencia Registrada Exitosamente.", MsgBoxStyle.Information, "Correcto")
        limpiarDatos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim placas As New Placas()
        If MsgBox("Desea eliminar registro?." + vbNewLine + "Por favor confirme.", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Not Me.licencia.BuscarLicenciaById(Me.txtIdLicencia.Value) Then
            MsgBox("No se pudo eliminar licencia." + vbNewLine + "No se encontro registro con ese ID.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If placas.BuscarPlacasByLicencia(Me.txtIdLicencia.Value).Rows.Count > 0 Then
            MsgBox("No se pudo eliminar placas." + vbNewLine + "Hay Multas Activas.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not Me.licencia.EliminarLicencia() Then
            MsgBox("No se pudo eliminar licencia." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        MsgBox("Licencia Eliminada Exitosamente.", MsgBoxStyle.Information, "Correcto")
        limpiarDatos()
    End Sub

    Private Sub chkSiDonador_Click(sender As Object, e As EventArgs) Handles chkSiDonador.Click
        If Me.chkSiDonador.Checked Then
            Me.chkNoDonador.Checked = False
        Else
            Me.chkSiDonador.Checked = True
        End If
    End Sub

    Private Sub chkNoDonador_Click(sender As Object, e As EventArgs) Handles chkNoDonador.Click
        If Me.chkNoDonador.Checked Then
            Me.chkSiDonador.Checked = False
        Else
            Me.chkNoDonador.Checked = True
        End If
    End Sub

End Class