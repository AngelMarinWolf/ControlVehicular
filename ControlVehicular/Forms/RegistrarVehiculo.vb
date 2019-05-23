
Public Class RegistrarVehiculo
    Dim empleado As New Empleado
    Dim vehiculo As New Padron

    Public Sub New(idEmpleado As String)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.empleado.BuscarEmpleadoById(idEmpleado)
    End Sub

    Private Sub RegistarVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dateFactura.Value = Date.Now
        Me.cbCombustible.SelectedItem = "Gasolina"
        Me.cbUso.SelectedItem = "Particular"
        Me.vehiculo.PoblarComboMarcas(Me.cbMarcaAuto)
        Me.vehiculo.PoblarComboTipos(Me.cbTipoVehiculo)
    End Sub

    Private Sub txtNoSerie_TextChanged(sender As Object, e As EventArgs) Handles txtNoSerie.TextChanged
        poblarDatosVehiculo(Me.txtNoSerie.Text)
    End Sub

    Private Sub poblarDatosVehiculo(noSerie As String)
        If vehiculo.BuscarVehiculoById(noSerie) Then
            Me.txtNoFactura.Text = Me.vehiculo.GetNoFactura()
            Me.txtIdContribuyente.Text = Me.vehiculo.GetIdContribuyente()
            Me.dateFactura.Value = Me.vehiculo.GetFechaFactura()
            Me.txtImporte.Value = Me.vehiculo.GetImporteFactura()
            Me.cbTipoVehiculo.SelectedValue = Me.vehiculo.GetIdTipo()
            Me.cbMarcaAuto.SelectedValue = Me.vehiculo.GetIdMarca()
            Me.cbCombustible.SelectedItem = Me.vehiculo.GetCombustible()
            Me.txtColor.Text = Me.vehiculo.GetColor()
            Me.txtNoPasajeros.Value = Me.vehiculo.GetPasajeros()
            Me.cbUso.SelectedItem = Me.vehiculo.GetImplementacion()
        Else
            'limpiarDatos()
        End If
    End Sub

    Private Sub limpiarDatos()
        Me.vehiculo = New Padron()

        Me.txtNoFactura.Text = ""
        Me.txtIdContribuyente.Text = ""
        Me.dateFactura.Value = Date.Now
        Me.txtImporte.Value = 0
        Me.cbTipoVehiculo.SelectedValue = 1
        Me.cbMarcaAuto.SelectedValue = 1
        Me.cbCombustible.SelectedItem = "Gasolina"
        Me.txtColor.Text = ""
        Me.txtNoPasajeros.Value = 0
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim contribuyente As New Contribuyente()

        If Me.txtNoSerie.Text.Length < 17 Then
            MsgBox("Insuficientes caracteres en el No. de Serie." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If vehiculo.BuscarVehiculoById(Me.txtNoSerie.Text) Then
            MsgBox("No se pudo registrar vehiculo." + vbNewLine + "id ya en uso.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not contribuyente.BuscarContribuyenteById(Me.txtIdContribuyente.Text) Then
            MsgBox("No se pudo registrar vehiculo." + vbNewLine + "Contribuyente no registrado en el sistema.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Me.vehiculo = New Padron()
        Me.vehiculo.SetNoSerie(Me.txtNoSerie.Text)
        Me.vehiculo.SetNoFactura(Me.txtNoFactura.Text)
        Me.vehiculo.SetIdContribuyente(Me.txtIdContribuyente.Text)
        Me.vehiculo.SetFechaFactura(Me.dateFactura.Value)
        Me.vehiculo.SetImporteFactura(Me.txtImporte.Value)
        Me.vehiculo.SetIdTipo(Me.cbTipoVehiculo.SelectedValue)
        Me.vehiculo.SetIdMarca(Me.cbMarcaAuto.SelectedValue)
        Me.vehiculo.SetCombustible(Me.cbCombustible.SelectedItem)
        Me.vehiculo.SetImplementacion(Me.cbUso.SelectedItem)
        Me.vehiculo.SetColor(Me.txtColor.Text)
        Me.vehiculo.SetPasajeros(Me.txtNoPasajeros.Value)
        Me.vehiculo.SetIdEmpleado(Me.empleado.GetCurp)

        If Not Me.vehiculo.RegistrarVehiculo() Then
            MsgBox("No se pudo registrar multa." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        limpiarDatos()
        MsgBox("Vehiculo Registrado Exitosamente.", MsgBoxStyle.Information, "Correcto")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim contribuyente As New Contribuyente()

        If Me.txtNoSerie.Text.Length < 17 Then
            MsgBox("Insuficientes caracteres en la placa." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not vehiculo.BuscarVehiculoById(Me.txtNoSerie.Text) Then
            MsgBox("No se pudo actualizar vehiculo." + vbNewLine + "No se encontro registro con ese ID.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not contribuyente.BuscarContribuyenteById(Me.txtIdContribuyente.Text) Then
            MsgBox("No se pudo actualizar vehiculo." + vbNewLine + "Contribuyente no encontrado.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Me.vehiculo = New Padron()
        Me.vehiculo.SetNoSerie(Me.txtNoSerie.Text)
        Me.vehiculo.SetNoFactura(Me.txtNoFactura.Text)
        Me.vehiculo.SetIdContribuyente(Me.txtIdContribuyente.Text)
        Me.vehiculo.SetFechaFactura(Me.dateFactura.Value)
        Me.vehiculo.SetImporteFactura(Me.txtImporte.Value)
        Me.vehiculo.SetIdTipo(Me.cbTipoVehiculo.SelectedValue)
        Me.vehiculo.SetIdMarca(Me.cbMarcaAuto.SelectedValue)
        Me.vehiculo.SetCombustible(Me.cbCombustible.SelectedItem)
        Me.vehiculo.SetImplementacion(Me.cbUso.SelectedItem)
        Me.vehiculo.SetColor(Me.txtColor.Text)
        Me.vehiculo.SetPasajeros(Me.txtNoPasajeros.Value)
        Me.vehiculo.SetIdEmpleado(Me.empleado.GetCurp)

        If Not Me.vehiculo.ActualizarVehiculo() Then
            MsgBox("No se pudo actualizar Vehiculo." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        MsgBox("Vehiculo Registrado Exitosamente.", MsgBoxStyle.Information, "Correcto")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim placas As New Placas()
        If MsgBox("Desea eliminar registro?." + vbNewLine + "Por favor confirme.", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me.txtNoSerie.Text.Length < 17 Then
            MsgBox("Insuficientes caracteres en la placa." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not vehiculo.BuscarVehiculoById(Me.txtNoSerie.Text) Then
            MsgBox("No se pudo eliminar vehiculo." + vbNewLine + "No se encontro registro con ese ID.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If placas.BuscarPlacasByVehiculo(Me.txtNoSerie.Text).Rows.Count > 0 Then
            MsgBox("No se pudo eliminar vehiculo." + vbNewLine + "Hay placas Activas.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not Me.vehiculo.EliminarVehiculo() Then
            MsgBox("No se pudo eliminar Vehiculo." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        MsgBox("Vehiculo Eliminado Exitosamente.", MsgBoxStyle.Information, "Correcto")
    End Sub

End Class