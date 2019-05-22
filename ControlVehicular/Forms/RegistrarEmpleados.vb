Public Class RegistrarEmpleados
    Private empleado As Empleado = New Empleado()
    Private domicilio As Domicilio = New Domicilio()

    Private pais As Pais = New Pais()
    Private estado As Estado = New Estado()
    Private ciudad As Ciudad = New Ciudad()
    Private colonia As Colonia = New Colonia()

    Private Sub RegistrarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dataEmpleados.DataSource = empleado.BuscarEmpleados()
        Me.pais.PoblarComboPaises(Me.cmbPais)
    End Sub

    Private Sub chkFemenino_Click(sender As Object, e As EventArgs) Handles chkFemenino.Click
        If Me.chkFemenino.Checked Then
            Me.chkMasculino.Checked = False
        Else
            Me.chkMasculino.Checked = True
        End If
    End Sub

    Private Sub chkMasculino_Click(sender As Object, e As EventArgs) Handles chkMasculino.Click
        If Me.chkMasculino.Checked Then
            Me.chkFemenino.Checked = False
        Else
            Me.chkFemenino.Checked = True
        End If
    End Sub

    Private Sub cmbPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPais.SelectedIndexChanged
        Me.estado.PoblarComboEstados(Me.cmbPais.SelectedValue, cmbEstado)
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged
        Me.ciudad.PoblarComboCiudades(Me.cmbEstado.SelectedValue, cmbCiudad)
    End Sub

    Private Sub cmbCiudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCiudad.SelectedIndexChanged
        Me.colonia.PoblarComboColonias(Me.cmbCiudad.SelectedValue, cmbColonia)
    End Sub

    Private Sub dataEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataEmpleados.CellContentClick
        Dim row As Integer = Me.dataEmpleados.SelectedRows(0).Index
        poblarDatosEmpleado(Me.dataEmpleados.Rows(row).Cells("curp").Value)
    End Sub

    Private Sub poblarDatosEmpleado(idEmpleado As String)
        If empleado.BuscarEmpleadoById(idEmpleado) Then
            Me.txtCurp.Text = empleado.GetCurp()
            Me.txtRfc.Text = empleado.GetRfc()
            Me.txtEdad.Value = empleado.GetEdad()
            Me.txtNombre.Text = empleado.GetNombre()
            Me.txtPaterno.Text = empleado.GetPaterno()
            Me.txtMaterno.Text = empleado.GetMaterno()
            Me.txtEmail.Text = empleado.GetEmail()
            Me.txtTelefono.Text = empleado.GetTelefono()
            Me.txtUsernamer.Text = empleado.GetUsername()
            Me.txtPassword.Text = empleado.GetPassword()
            If empleado.GetSexo() = "M" Then
                Me.chkMasculino.Checked = True
                Me.chkFemenino.Checked = False
            Else
                Me.chkMasculino.Checked = False
                Me.chkFemenino.Checked = True
            End If
            If domicilio.BuscarDomicilioById(empleado.GetIdDomicilio()) Then
                Me.txtCalle.Text = domicilio.GetCalleDomicilio()
                Me.txtNumeroDomicilio.Text = domicilio.GetNumeroDomicilio()
                Me.colonia.BuscarColoniaById(Me.domicilio.GetIdColonia)
                Me.ciudad.BuscarCiudadById(Me.colonia.GetIdCiudad)
                Me.estado.BuscarEstadoById(Me.ciudad.GetIdEstado)
                Me.pais.BuscarPaisById(Me.estado.GetIdPais)
                Me.cmbPais.SelectedValue = Me.pais.GetId
                Me.cmbEstado.SelectedValue = Me.estado.GetIdEstado
                Me.cmbCiudad.SelectedValue = Me.ciudad.GetIdCiudad
                Me.cmbColonia.SelectedValue = Me.colonia.GetIdColonia
            End If
        Else
            limpiarDatos()
        End If
    End Sub

    Private Sub limpiarDatos()
        Me.empleado = New Empleado()
        Me.domicilio = New Domicilio()

        Me.txtRfc.Text = ""
        Me.txtEdad.Value = 1
        Me.txtNombre.Text = ""
        Me.txtPaterno.Text = ""
        Me.txtMaterno.Text = ""
        Me.txtEmail.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtUsernamer.Text = ""
        Me.txtPassword.Text = ""
        Me.chkMasculino.Checked = False
        Me.chkFemenino.Checked = False
        Me.txtCalle.Text = ""
        Me.txtNumeroDomicilio.Text = ""
        Me.cmbPais.SelectedValue = 1
        Me.cmbEstado.SelectedValue = 1
        Me.cmbCiudad.SelectedValue = 1
        Me.cmbColonia.SelectedValue = 1
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim idDomicilio As Integer = Me.domicilio.BuscarUltimoId + 1
        Dim tmpEmpleado As Empleado = New Empleado()

        If Me.txtCurp.Text.Length <> 18 Then
            MsgBox("Insuficientes caracteres en la curp." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Me.txtRfc.Text.Length < 12 Then
            MsgBox("Insuficientes caracteres en el RFC." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If tmpEmpleado.BuscarEmpleadoByUsername(Me.txtUsernamer.Text) Then
            MsgBox("Nombre de usuario no disponible." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If tmpEmpleado.BuscarEmpleadoById(Me.txtCurp.Text) Then
            MsgBox("No se pudo registrar empleado." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Me.empleado = New Empleado()
        Me.empleado.SetCurp(Me.txtCurp.Text)
        Me.empleado.SetRfc(Me.txtRfc.Text)
        Me.empleado.SetEdad(Me.txtEdad.Value)
        Me.empleado.SetNombre(Me.txtNombre.Text)
        Me.empleado.SetPaterno(Me.txtPaterno.Text)
        Me.empleado.SetMaterno(Me.txtMaterno.Text)
        Me.empleado.SetEmail(Me.txtEmail.Text)
        Me.empleado.SetTelefono(Me.txtTelefono.Text)
        Me.empleado.SetUsername(Me.txtUsernamer.Text)
        Me.empleado.SetPassword(Me.txtPassword.Text)
        Me.empleado.SetSexo(If(Me.chkMasculino.Checked, "M", "F"))
        Me.empleado.SetIdDomicilio(idDomicilio)

        Me.domicilio = New Domicilio()
        Me.domicilio.SetIdColonia(Me.cmbColonia.SelectedValue)
        Me.domicilio.SetIdDomicilio(idDomicilio)
        Me.domicilio.SetCalleDomicilio(Me.txtCalle.Text)
        Me.domicilio.SetNumeroDomicilio(Me.txtNumeroDomicilio.Text)

        If Not Me.domicilio.RegistrarDomicilio() Then
            MsgBox("No se pudo registrar empleado." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not Me.empleado.RegistrarEmpleado() Then
            MsgBox("No se pudo registrar empleado." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Me.domicilio.EliminarDomicilio()
            Exit Sub
        End If
        limpiarDatos()
        Me.txtCurp.Text = ""
        Me.dataEmpleados.DataSource = empleado.BuscarEmpleados()
        MsgBox("Empleado Registrado Exitosamente.", MsgBoxStyle.Information, "Correcto")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim tmpEmpleado As Empleado = New Empleado()
        Dim vehiculo As New Padron()

        If MsgBox("Desea eliminar registro?." + vbNewLine + "Por favor confirme.", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me.txtCurp.Text.Length <> 18 Then
            MsgBox("Insuficientes caracteres en la curp." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If vehiculo.BuscarPadronByEmpleado(Me.txtCurp.Text).Rows.Count > 0 Then
            MsgBox("No se pudo eliminar contribuyente." + vbNewLine + "Hay padrones registrados con el usuario.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not tmpEmpleado.BuscarEmpleadoById(Me.txtCurp.Text) Then
            MsgBox("No se pudo eliminar empleado." + vbNewLine + "Empleado inexistente.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not Me.empleado.EliminarEmpleado Then
            MsgBox("No se pudo eliminar empleado." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not Me.domicilio.EliminarDomicilio Then
            MsgBox("No se pudo eliminar Domicilio." + vbNewLine + "Se requiere eliminacion manual." + vbNewLine + "Utilice ventana de mantenimiento para locaciones.", MsgBoxStyle.Critical, "Error")
        End If

        limpiarDatos()
        Me.txtCurp.Text = ""
        Me.dataEmpleados.DataSource = empleado.BuscarEmpleados()
        MsgBox("Empleado Eliminado Exitosamente.", MsgBoxStyle.Information, "Correcto")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim tmpEmpleado As Empleado = New Empleado()

        If Me.txtCurp.Text.Length <> 18 Then
            MsgBox("Insuficientes caracteres en la curp." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Me.txtRfc.Text.Length < 12 Then
            MsgBox("Insuficientes caracteres en el RFC." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not tmpEmpleado.BuscarEmpleadoById(Me.txtCurp.Text) Then
            MsgBox("No se pudo actualizar empleado." + vbNewLine + "Empleado inexistente.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If tmpEmpleado.BuscarEmpleadoByUsername(Me.txtUsernamer.Text) And tmpEmpleado.GetCurp <> Me.txtCurp.Text Then
            MsgBox("Nombre de usuario no disponible." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Me.empleado.SetCurp(Me.txtCurp.Text)
        Me.empleado.SetRfc(Me.txtRfc.Text)
        Me.empleado.SetEdad(Me.txtEdad.Value)
        Me.empleado.SetNombre(Me.txtNombre.Text)
        Me.empleado.SetPaterno(Me.txtPaterno.Text)
        Me.empleado.SetMaterno(Me.txtMaterno.Text)
        Me.empleado.SetEmail(Me.txtEmail.Text)
        Me.empleado.SetTelefono(Me.txtTelefono.Text)
        Me.empleado.SetUsername(Me.txtUsernamer.Text)
        Me.empleado.SetPassword(Me.txtPassword.Text)
        Me.empleado.SetSexo(If(Me.chkMasculino.Checked, "M", "F"))

        Me.domicilio.SetIdColonia(Me.cmbColonia.SelectedValue)
        Me.domicilio.SetCalleDomicilio(Me.txtCalle.Text)
        Me.domicilio.SetNumeroDomicilio(Me.txtNumeroDomicilio.Text)

        If Not Me.domicilio.ActualizarDomicilio() Or Not Me.empleado.ActualizarEmpleado() Then
            MsgBox("No se pudo actualizar informacion del empleado." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        limpiarDatos()
        Me.txtCurp.Text = ""
        Me.dataEmpleados.DataSource = empleado.BuscarEmpleados()
        MsgBox("Empleado Actualizado Exitosamente.", MsgBoxStyle.Information, "Correcto")
    End Sub

    Private Sub txtCurp_TextChanged(sender As Object, e As EventArgs) Handles txtCurp.TextChanged
        poblarDatosEmpleado(Me.txtCurp.Text)
    End Sub
End Class