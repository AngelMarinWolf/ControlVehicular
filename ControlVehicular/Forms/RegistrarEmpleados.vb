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

    Private Sub txtCurp_Leave(sender As Object, e As EventArgs) Handles txtCurp.Leave
        poblarDatosEmpleado(Me.txtCurp.Text)
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
        Dim row As Integer = Me.dataEmpleados.SelectedCells(0).RowIndex
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

        If Not tmpEmpleado.BuscarEmpleadoById(Me.txtCurp.Text) Then
            If Me.domicilio.RegistrarDomicilio() And Me.empleado.RegistrarEmpleado() Then
                MsgBox("Empleado Registrado Exitosamente.", MsgBoxStyle.Information, "Correcto")
            Else
                MsgBox("No se pudo registar empleado." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("No se pudo registar empleado." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
        End If

        Me.dataEmpleados.DataSource = empleado.BuscarEmpleados()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim tmpEmpleado As Empleado = New Empleado()

        If tmpEmpleado.BuscarEmpleadoById(Me.txtCurp.Text) Then
            If Me.empleado.EliminarEmpleado And Me.domicilio.EliminarDomicilio Then
                MsgBox("Empleado Eliminado Exitosamente.", MsgBoxStyle.Information, "Correcto")
            Else
                MsgBox("No se pudo eliminar empleado." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("No se pudo eliminar empleado." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
        End If

        Me.dataEmpleados.DataSource = empleado.BuscarEmpleados()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim tmpEmpleado As Empleado = New Empleado()

        If Me.txtCurp.Text.Length = 18 Then
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

            If tmpEmpleado.BuscarEmpleadoById(Me.txtCurp.Text) Then
                If Me.domicilio.ActualizarDomicilio() And Me.empleado.ActualizarEmpleado() Then
                    MsgBox("Empleado Actualizado Exitosamente.", MsgBoxStyle.Information, "Correcto")
                Else
                    MsgBox("No se pudo actualizar informacion del empleado." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("No se pudo actualizar informacion del empleado." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("No se pudo actualizar informacion del empleado." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
        End If


        Me.dataEmpleados.DataSource = empleado.BuscarEmpleados()
    End Sub
End Class