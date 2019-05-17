Public Class RegistrarLocaciones

    Private pais As Pais = New Pais()
    Private estado As Estado = New Estado()
    Private ciudad As Ciudad = New Ciudad()
    Private colonia As Colonia = New Colonia()
    Private domicilio As Domicilio = New Domicilio()

    Private Sub RegistrarLocaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PoblarPaises()
    End Sub

    Private Sub PoblarPaises()
        Me.cbPaises.Enabled = False
        Me.cbEstados.Enabled = False
        Me.cbCiudades.Enabled = False
        Me.cbColonias.Enabled = False
        Me.txtNumero.Enabled = False
        Me.btnAgregar.Enabled = True

        Me.cbPaises.DataSource = Nothing
        Me.cbEstados.DataSource = Nothing
        Me.cbCiudades.DataSource = Nothing
        Me.cbColonias.DataSource = Nothing
        Me.txtID.Value = Me.pais.BuscarUltimoId() + 1
        Me.txtNombre.Text = ""
        Me.txtNumero.Text = ""

        Me.dataPaises.DataSource = Me.pais.BuscarPaises

        Me.dataPaises.Columns("idPais").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.dataPaises.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.dataPaises.Columns("idPais").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub PoblarEstados()
        Me.cbPaises.Enabled = True
        Me.cbEstados.Enabled = False
        Me.cbCiudades.Enabled = False
        Me.cbColonias.Enabled = False
        Me.txtNumero.Enabled = False
        Me.btnAgregar.Enabled = True

        Me.cbPaises.DataSource = Nothing
        Me.cbEstados.DataSource = Nothing
        Me.cbCiudades.DataSource = Nothing
        Me.cbColonias.DataSource = Nothing
        Me.txtID.Value = Me.estado.BuscarUltimoId() + 1
        Me.txtNombre.Text = ""
        Me.txtNumero.Text = ""

        Me.pais.PoblarComboPaises(Me.cbPaises)
        Me.dataEstados.DataSource = Me.estado.BuscarEstadosByPais(Me.cbPaises.SelectedValue)

        Me.dataEstados.Columns("idPais").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.dataEstados.Columns("idEstado").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.dataEstados.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.dataEstados.Columns("idPais").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dataEstados.Columns("idEstado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub PoblarCiudades()
        Me.cbPaises.Enabled = True
        Me.cbEstados.Enabled = True
        Me.cbCiudades.Enabled = False
        Me.cbColonias.Enabled = False
        Me.txtNumero.Enabled = False
        Me.btnAgregar.Enabled = True

        Me.cbPaises.DataSource = Nothing
        Me.cbEstados.DataSource = Nothing
        Me.cbCiudades.DataSource = Nothing
        Me.cbColonias.DataSource = Nothing
        Me.txtID.Value = Me.ciudad.BuscarUltimoId() + 1
        Me.txtNombre.Text = ""
        Me.txtNumero.Text = ""

        Me.pais.PoblarComboPaises(Me.cbPaises)
        Me.estado.PoblarComboEstados(Me.cbPaises.SelectedValue, Me.cbEstados)
        Me.dataCiudades.DataSource = Me.ciudad.BuscarCiudadesByEstado(Me.cbEstados.SelectedValue)

        Me.dataCiudades.Columns("idEstado").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.dataCiudades.Columns("idCiudad").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.dataCiudades.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.dataCiudades.Columns("idEstado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dataCiudades.Columns("idCiudad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub PoblarColonias()
        Me.cbPaises.Enabled = True
        Me.cbEstados.Enabled = True
        Me.cbCiudades.Enabled = True
        Me.cbColonias.Enabled = False
        Me.txtNumero.Enabled = False
        Me.btnAgregar.Enabled = True

        Me.cbPaises.DataSource = Nothing
        Me.cbEstados.DataSource = Nothing
        Me.cbCiudades.DataSource = Nothing
        Me.cbColonias.DataSource = Nothing
        Me.txtID.Value = Me.colonia.BuscarUltimoId() + 1
        Me.txtNombre.Text = ""
        Me.txtNumero.Text = ""

        Me.pais.PoblarComboPaises(Me.cbPaises)
        Me.estado.PoblarComboEstados(Me.cbPaises.SelectedValue, Me.cbEstados)
        Me.ciudad.PoblarComboCiudades(Me.cbEstados.SelectedValue, Me.cbCiudades)
        Me.dataColonias.DataSource = Me.colonia.BuscarColoniasByCiudad(Me.cbCiudades.SelectedValue)

        Me.dataColonias.Columns("idCiudad").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.dataColonias.Columns("idColonia").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.dataColonias.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.dataColonias.Columns("idCiudad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dataColonias.Columns("idColonia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub PoblarDomicilios()
        Me.cbPaises.Enabled = True
        Me.cbEstados.Enabled = True
        Me.cbCiudades.Enabled = True
        Me.cbColonias.Enabled = True
        Me.txtNumero.Enabled = True
        Me.btnAgregar.Enabled = False

        Me.cbPaises.DataSource = Nothing
        Me.cbEstados.DataSource = Nothing
        Me.cbCiudades.DataSource = Nothing
        Me.cbColonias.DataSource = Nothing
        Me.txtID.Value = Me.domicilio.BuscarUltimoId() + 1
        Me.txtNombre.Text = ""
        Me.txtNumero.Text = ""

        Me.pais.PoblarComboPaises(Me.cbPaises)
        Me.estado.PoblarComboEstados(Me.cbPaises.SelectedValue, Me.cbEstados)
        Me.ciudad.PoblarComboCiudades(Me.cbEstados.SelectedValue, Me.cbCiudades)
        Me.colonia.PoblarComboColonias(Me.cbCiudades.SelectedValue, Me.cbColonias)
        Me.dataDomicilios.DataSource = Me.domicilio.BuscarDomiciliosByColonia(Me.cbColonias.SelectedValue)

        Me.dataDomicilios.Columns("idColonia").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.dataDomicilios.Columns("idDomicilio").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.dataDomicilios.Columns("no_domicilio").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.dataDomicilios.Columns("calle").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.dataDomicilios.Columns("idColonia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dataDomicilios.Columns("idDomicilio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dataDomicilios.Columns("no_domicilio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub tcLocaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcLocaciones.SelectedIndexChanged
        Dim selectedTab = Me.tcLocaciones.SelectedTab.Name

        Select Case selectedTab
            Case "TabPaises"
                PoblarPaises()
            Case "TabEstados"
                PoblarEstados()
            Case "TabCiudades"
                PoblarCiudades()
            Case "TabColonias"
                PoblarColonias()
            Case "TabDomicilios"
                PoblarDomicilios()
            Case Else
        End Select
    End Sub

    Private Sub cbPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaises.SelectedIndexChanged
        If Me.tcLocaciones.SelectedTab.Name <> "TabEstados" Then
            Me.estado.PoblarComboEstados(Me.cbPaises.SelectedValue, Me.cbEstados)
        Else
            Me.dataEstados.DataSource = Me.estado.BuscarEstadosByPais(Me.cbPaises.SelectedValue)
        End If
    End Sub

    Private Sub cbEstados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstados.SelectedIndexChanged
        If Me.tcLocaciones.SelectedTab.Name <> "TabCiudades" Then
            Me.ciudad.PoblarComboCiudades(Me.cbEstados.SelectedValue, Me.cbCiudades)
        Else
            Me.dataCiudades.DataSource = Me.ciudad.BuscarCiudadesByEstado(Me.cbEstados.SelectedValue)
        End If
    End Sub

    Private Sub cbCiudades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCiudades.SelectedIndexChanged
        If Me.tcLocaciones.SelectedTab.Name <> "TabColonias" Then
            Me.colonia.PoblarComboColonias(Me.cbCiudades.SelectedValue, Me.cbColonias)
        Else
            Me.dataColonias.DataSource = Me.colonia.BuscarColoniasByCiudad(Me.cbCiudades.SelectedValue)
        End If
    End Sub

    Private Sub cbColonias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbColonias.SelectedIndexChanged
        If Me.tcLocaciones.SelectedTab.Name = "TabDomicilios" Then
            Me.dataDomicilios.DataSource = Me.domicilio.BuscarDomiciliosByColonia(Me.cbColonias.SelectedValue)
        End If
    End Sub

    Private Sub dataPaises_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataPaises.CellContentClick
        Dim row As Integer = Me.dataPaises.SelectedRows(0).Index

        If Me.pais.BuscarPaisById(CInt(Me.dataPaises.Rows(row).Cells("idPais").Value)) Then
            Me.txtID.Value = Me.pais.GetId()
            Me.txtNombre.Text = Me.pais.GetNombre()
        End If
    End Sub

    Private Sub dataEstados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataEstados.CellContentClick
        Dim row As Integer = Me.dataEstados.SelectedRows(0).Index

        If Me.estado.BuscarEstadoById(CInt(Me.dataEstados.Rows(row).Cells("idEstado").Value)) Then
            Me.txtID.Value = Me.estado.GetIdEstado()
            Me.txtNombre.Text = Me.estado.GetNombreEstado()
        End If
    End Sub

    Private Sub dataCiudades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataCiudades.CellContentClick
        Dim row As Integer = Me.dataCiudades.SelectedRows(0).Index

        If Me.ciudad.BuscarCiudadById(CInt(Me.dataCiudades.Rows(row).Cells("idCiudad").Value)) Then
            Me.txtID.Value = Me.ciudad.GetIdCiudad()
            Me.txtNombre.Text = Me.ciudad.GetNombreCiudad()
        End If
    End Sub

    Private Sub dataColonias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataColonias.CellContentClick
        Dim row As Integer = Me.dataColonias.SelectedRows(0).Index

        If Me.colonia.BuscarColoniaById(CInt(Me.dataColonias.Rows(row).Cells("idColonia").Value)) Then
            Me.txtID.Value = Me.colonia.GetIdColonia()
            Me.txtNombre.Text = Me.colonia.GetNombreColonia()
        End If
    End Sub

    Private Sub dataDomicilios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataDomicilios.CellContentClick
        Dim row As Integer = Me.dataDomicilios.SelectedRows(0).Index

        If Me.domicilio.BuscarDomicilioById(CInt(Me.dataDomicilios.Rows(row).Cells("idDomicilio").Value)) Then
            Me.txtID.Value = Me.domicilio.GetIdDomicilio()
            Me.txtNombre.Text = Me.domicilio.GetCalleDomicilio()
            Me.txtNumero.Text = Me.domicilio.GetNumeroDomicilio()
        End If
    End Sub

    Private Sub txtID_ValueChanged(sender As Object, e As EventArgs) Handles txtID.ValueChanged
        Dim selectedTab = Me.tcLocaciones.SelectedTab.Name

        Select Case selectedTab
            Case "TabPaises"
                If Me.pais.BuscarPaisById(Me.txtID.Value) Then
                    Me.txtID.Value = Me.pais.GetId()
                    Me.txtNombre.Text = Me.pais.GetNombre()
                Else
                    Me.txtID.Value = Me.pais.BuscarUltimoId() + 1
                    Me.txtNombre.Text = ""
                End If
            Case "TabEstados"
                If Me.estado.BuscarEstadoById(Me.txtID.Value) Then
                    Me.txtID.Value = Me.estado.GetIdEstado()
                    Me.txtNombre.Text = Me.estado.GetNombreEstado()
                Else
                    Me.txtID.Value = Me.estado.BuscarUltimoId() + 1
                    Me.txtNombre.Text = ""
                End If
            Case "TabCiudades"
                If Me.ciudad.BuscarCiudadById(Me.txtID.Value) Then
                    Me.txtID.Value = Me.ciudad.GetIdCiudad()
                    Me.txtNombre.Text = Me.ciudad.GetNombreCiudad()
                Else
                    Me.txtID.Value = Me.ciudad.BuscarUltimoId() + 1
                    Me.txtNombre.Text = ""
                End If
            Case "TabColonias"
                If Me.colonia.BuscarColoniaById(Me.txtID.Value) Then
                    Me.txtID.Value = Me.colonia.GetIdColonia()
                    Me.txtNombre.Text = Me.colonia.GetNombreColonia()
                Else
                    Me.txtID.Value = Me.colonia.BuscarUltimoId() + 1
                    Me.txtNombre.Text = ""
                End If
            Case "TabDomicilios"
                If Me.domicilio.BuscarDomicilioById(Me.txtID.Value) Then
                    Me.txtID.Value = Me.domicilio.GetIdDomicilio()
                    Me.txtNombre.Text = Me.domicilio.GetCalleDomicilio()
                    Me.txtNumero.Text = Me.domicilio.GetNumeroDomicilio()
                Else
                    Me.txtID.Value = Me.domicilio.BuscarUltimoId() + 1
                    Me.txtNombre.Text = ""
                End If
            Case Else
        End Select
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim selectedTab = Me.tcLocaciones.SelectedTab.Name

        Select Case selectedTab
            Case "TabPaises"
                Me.pais = New Pais()
                If Not Me.pais.BuscarPaisById(Me.txtID.Value) Then
                    Me.pais.SetId(Me.txtID.Value)
                    Me.pais.SetNombre(Me.txtNombre.Text)
                    Me.pais.RegistrarPais()
                Else
                    MsgBox("No se pudo registrar Pais." + vbNewLine + "Id ya en uso.", MsgBoxStyle.Critical, "Error")
                End If
                PoblarPaises()
            Case "TabEstados"
                Me.estado = New Estado()
                If Not Me.estado.BuscarEstadoById(Me.txtID.Value) Then
                    Me.estado.SetIdPais(Me.cbPaises.SelectedValue)
                    Me.estado.SetIdEstado(Me.txtID.Value)
                    Me.estado.SetNombreEstado(Me.txtNombre.Text)
                    Me.estado.RegistrarEstado()
                Else
                    MsgBox("No se pudo registrar Estado." + vbNewLine + "Id ya en uso.", MsgBoxStyle.Critical, "Error")
                End If
                PoblarEstados()
            Case "TabCiudades"
                Me.ciudad = New Ciudad()
                If Not Me.ciudad.BuscarCiudadById(Me.txtID.Value) Then
                    Me.ciudad.SetIdEstado(Me.cbEstados.SelectedValue)
                    Me.ciudad.SetIdCiudad(Me.txtID.Value)
                    Me.ciudad.SetNombreCiudad(Me.txtNombre.Text)
                    Me.ciudad.RegistrarCiudad()
                Else
                    MsgBox("No se pudo registrar Ciudad." + vbNewLine + "Id ya en uso.", MsgBoxStyle.Critical, "Error")
                End If
                PoblarCiudades()
            Case "TabColonias"
                Me.colonia = New Colonia()
                If Not Me.colonia.BuscarColoniaById(Me.txtID.Value) Then
                    Me.colonia.SetIdCiudad(Me.cbCiudades.SelectedValue)
                    Me.colonia.SetIdColonia(Me.txtID.Value)
                    Me.colonia.SetNombreColonia(Me.txtNombre.Text)
                    Me.colonia.RegistrarColonia()
                Else
                    MsgBox("No se pudo registrar Colonia." + vbNewLine + "Id ya en uso.", MsgBoxStyle.Critical, "Error")
                End If
                PoblarColonias()
            Case Else
        End Select
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim selectedTab = Me.tcLocaciones.SelectedTab.Name

        Select Case selectedTab
            Case "TabPaises"
                Me.pais = New Pais()
                If Me.pais.BuscarPaisById(Me.txtID.Value) Then
                    Me.pais.SetNombre(Me.txtNombre.Text)
                    Me.pais.ActualizarPais()
                Else
                    MsgBox("No se pudo actualizar Pais." + vbNewLine + "Id inexistente.", MsgBoxStyle.Critical, "Error")
                End If
                PoblarPaises()
            Case "TabEstados"
                Me.estado = New Estado()
                If Me.estado.BuscarEstadoById(Me.txtID.Value) Then
                    Me.estado.SetNombreEstado(Me.txtNombre.Text)
                    Me.estado.ActualizarEstado()
                Else
                    MsgBox("No se pudo actualizar Estado." + vbNewLine + "Id inexistente.", MsgBoxStyle.Critical, "Error")
                End If
                PoblarEstados()
            Case "TabCiudades"
                Me.ciudad = New Ciudad()
                If Me.ciudad.BuscarCiudadById(Me.txtID.Value) Then
                    Me.ciudad.SetNombreCiudad(Me.txtNombre.Text)
                    Me.ciudad.ActualizarCiudad()
                Else
                    MsgBox("No se pudo actualizar Ciudad." + vbNewLine + "Id inexistente.", MsgBoxStyle.Critical, "Error")
                End If
                PoblarCiudades()
            Case "TabColonias"
                Me.colonia = New Colonia()
                If Not Me.colonia.BuscarColoniaById(Me.txtID.Value) Then
                    Me.colonia.SetNombreColonia(Me.txtNombre.Text)
                    Me.colonia.ActualizarColonia()
                Else
                    MsgBox("No se pudo actualizar Colonia." + vbNewLine + "Id inexistente.", MsgBoxStyle.Critical, "Error")
                End If
                PoblarColonias()
            Case "TabDomicilios"
                Me.domicilio = New Domicilio()
                If Me.domicilio.BuscarDomicilioById(Me.txtID.Value) Then
                    Me.domicilio.SetCalleDomicilio(Me.txtNombre.Text)
                    Me.domicilio.SetNumeroDomicilio(Me.txtNumero.Text)
                    Me.domicilio.ActualizarDomicilio()
                Else
                    MsgBox("No se pudo actualizar Domicilio." + vbNewLine + "Id inexistente.", MsgBoxStyle.Critical, "Error")
                End If
                PoblarDomicilios()
            Case Else
        End Select
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim selectedTab = Me.tcLocaciones.SelectedTab.Name

        Select Case selectedTab
            Case "TabPaises"
                Me.pais = New Pais()
                If Me.pais.BuscarPaisById(Me.txtID.Value) And Me.estado.BuscarEstadosByPais(Me.pais.GetId()).Rows.Count = 0 Then
                    Me.pais.EliminarPais()
                Else
                    MsgBox("No se pudo eliminar Pais." + vbNewLine + "Id inexistente o existen dependencias.", MsgBoxStyle.Critical, "Error")
                End If
                PoblarPaises()
            Case "TabEstados"
                Me.estado = New Estado()
                If Me.estado.BuscarEstadoById(Me.txtID.Value) And Me.ciudad.BuscarCiudadesByEstado(Me.estado.GetIdEstado()).Rows.Count = 0 Then
                    Me.estado.EliminarEstado()
                Else
                    MsgBox("No se pudo eliminar Estado." + vbNewLine + "Id inexistente o existen dependencias.", MsgBoxStyle.Critical, "Error")
                End If
                PoblarEstados()
            Case "TabCiudades"
                Me.ciudad = New Ciudad()
                If Me.ciudad.BuscarCiudadById(Me.txtID.Value) And Me.colonia.BuscarColoniasByCiudad(Me.ciudad.GetIdCiudad()).Rows.Count = 0 Then
                    Me.ciudad.EliminarCiudad()
                Else
                    MsgBox("No se pudo eliminar Ciudad." + vbNewLine + "Id inexistente o existen dependencias.", MsgBoxStyle.Critical, "Error")
                End If
                PoblarCiudades()
            Case "TabColonias"
                Me.colonia = New Colonia()
                If Not Me.colonia.BuscarColoniaById(Me.txtID.Value) And Me.domicilio.BuscarDomiciliosByColonia(Me.colonia.GetIdColonia()).Rows.Count = 0 Then
                    Me.colonia.EliminarColonia()
                Else
                    MsgBox("No se pudo eliminar Colonia." + vbNewLine + "Id inexistente o existen dependencias.", MsgBoxStyle.Critical, "Error")
                End If
                PoblarColonias()
            Case "TabDomicilios"
                Me.domicilio = New Domicilio()
                If Me.domicilio.BuscarDomicilioById(Me.txtID.Value) Then
                    Me.domicilio.EliminarDomicilio()
                Else
                    MsgBox("No se pudo eliminar Domicilio." + vbNewLine + "Id inexistente.", MsgBoxStyle.Critical, "Error")
                End If
                PoblarDomicilios()
            Case Else
        End Select
    End Sub
End Class