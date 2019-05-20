Public Class RegistrarContribuyentes
    Private contribuyente As Contribuyente = New Contribuyente()
    Private domicilio As Domicilio = New Domicilio()

    Private pais As Pais = New Pais()
    Private estado As Estado = New Estado()
    Private ciudad As Ciudad = New Ciudad()
    Private colonia As Colonia = New Colonia()

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(curp As String)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        poblarDatosContribuyente(curp)
    End Sub

    Private Sub Contribuyentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub txtCurp_Leave(sender As Object, e As EventArgs) Handles txtCurp.Leave
        poblarDatosContribuyente(Me.txtCurp.Text)
    End Sub

    Private Sub poblarDatosContribuyente(idContribuyente As String)
        If contribuyente.BuscarContribuyenteById(idContribuyente) Then
            Me.txtCurp.Text = contribuyente.GetCurp()
            Me.txtRfc.Text = contribuyente.GetRfc()
            Me.txtEdad.Value = contribuyente.GetEdad()
            Me.txtNombre.Text = contribuyente.GetNombre()
            Me.txtPaterno.Text = contribuyente.GetPaterno()
            Me.txtMaterno.Text = contribuyente.GetMaterno()
            Me.txtEmail.Text = contribuyente.GetEmail()
            Me.txtTelefono.Text = contribuyente.GetTelefono()
            If contribuyente.GetSexo() = "M" Then
                Me.chkMasculino.Checked = True
                Me.chkFemenino.Checked = False
            Else
                Me.chkMasculino.Checked = False
                Me.chkFemenino.Checked = True
            End If
            If domicilio.BuscarDomicilioById(contribuyente.GetIdDomicilio()) Then
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
        Me.contribuyente = New Contribuyente()
        Me.domicilio = New Domicilio()

        Me.txtRfc.Text = ""
        Me.txtEdad.Value = 1
        Me.txtNombre.Text = ""
        Me.txtPaterno.Text = ""
        Me.txtMaterno.Text = ""
        Me.txtEmail.Text = ""
        Me.txtTelefono.Text = ""
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
        Dim tmpContribuyente As Contribuyente = New Contribuyente()

        If Me.txtCurp.Text.Length <> 18 Then
            MsgBox("Insuficientes caracteres en la curp." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If tmpContribuyente.BuscarContribuyenteById(Me.txtCurp.Text) Then
            MsgBox("No se pudo registrar empleado." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Me.contribuyente = New Contribuyente()
        Me.contribuyente.SetCurp(Me.txtCurp.Text)
        Me.contribuyente.SetRfc(Me.txtRfc.Text)
        Me.contribuyente.SetEdad(Me.txtEdad.Value)
        Me.contribuyente.SetNombre(Me.txtNombre.Text)
        Me.contribuyente.SetPaterno(Me.txtPaterno.Text)
        Me.contribuyente.SetMaterno(Me.txtMaterno.Text)
        Me.contribuyente.SetEmail(Me.txtEmail.Text)
        Me.contribuyente.SetTelefono(Me.txtTelefono.Text)
        Me.contribuyente.SetSexo(If(Me.chkMasculino.Checked, "M", "F"))
        Me.contribuyente.SetIdDomicilio(idDomicilio)

        Me.domicilio = New Domicilio()
        Me.domicilio.SetIdColonia(Me.cmbColonia.SelectedValue)
        Me.domicilio.SetIdDomicilio(idDomicilio)
        Me.domicilio.SetCalleDomicilio(Me.txtCalle.Text)
        Me.domicilio.SetNumeroDomicilio(Me.txtNumeroDomicilio.Text)

        If Not Me.domicilio.RegistrarDomicilio() Then
            MsgBox("No se pudo registrar contribuyente." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not Me.contribuyente.RegistrarContribuyente() Then
            MsgBox("No se pudo registrar contribuyente." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Me.domicilio.EliminarDomicilio()
            Exit Sub
        End If
        limpiarDatos()
        Me.txtCurp.Text = ""
        MsgBox("Empleado Registrado Exitosamente.", MsgBoxStyle.Information, "Correcto")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim tmpContribuyente As Contribuyente = New Contribuyente()

        If MsgBox("Desea eliminar registro?." + vbNewLine + "Por favor confirme.", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me.txtCurp.Text.Length <> 18 Then
            MsgBox("Insuficientes caracteres en la curp." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not tmpContribuyente.BuscarContribuyenteById(Me.txtCurp.Text) Then
            MsgBox("No se pudo eliminar contribuyente." + vbNewLine + "Empleado inexistente.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not Me.contribuyente.EliminarContribuyente Then
            MsgBox("No se pudo eliminar contribuyente." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not Me.domicilio.EliminarDomicilio Then
            MsgBox("No se pudo eliminar Domicilio." + vbNewLine + "Se requiere eliminacion manual." + vbNewLine + "Utilice ventana de mantenimiento para locaciones.", MsgBoxStyle.Critical, "Error")
        End If

        limpiarDatos()
        Me.txtCurp.Text = ""
        MsgBox("Contribuyente Eliminado Exitosamente.", MsgBoxStyle.Information, "Correcto")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim tmpContribuyente As Contribuyente = New Contribuyente()

        If Me.txtCurp.Text.Length <> 18 Then
            MsgBox("Insuficientes caracteres en la curp." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not tmpContribuyente.BuscarContribuyenteById(Me.txtCurp.Text) Then
            MsgBox("No se pudo actualizar contribuyente." + vbNewLine + "Empleado inexistente.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Me.contribuyente.SetCurp(Me.txtCurp.Text)
        Me.contribuyente.SetRfc(Me.txtRfc.Text)
        Me.contribuyente.SetEdad(Me.txtEdad.Value)
        Me.contribuyente.SetNombre(Me.txtNombre.Text)
        Me.contribuyente.SetPaterno(Me.txtPaterno.Text)
        Me.contribuyente.SetMaterno(Me.txtMaterno.Text)
        Me.contribuyente.SetEmail(Me.txtEmail.Text)
        Me.contribuyente.SetTelefono(Me.txtTelefono.Text)
        Me.contribuyente.SetSexo(If(Me.chkMasculino.Checked, "M", "F"))

        Me.domicilio.SetIdColonia(Me.cmbColonia.SelectedValue)
        Me.domicilio.SetCalleDomicilio(Me.txtCalle.Text)
        Me.domicilio.SetNumeroDomicilio(Me.txtNumeroDomicilio.Text)

        If Not Me.domicilio.ActualizarDomicilio() Then
            MsgBox("No se pudo registrar contribuyente." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not Me.contribuyente.ActualizarContribuyente() Then
            MsgBox("No se pudo registrar contribuyente." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Me.domicilio.EliminarDomicilio()
            Exit Sub
        End If

        limpiarDatos()
        Me.txtCurp.Text = ""
        MsgBox("Empleado Actualizado Exitosamente.", MsgBoxStyle.Information, "Correcto")
    End Sub
End Class