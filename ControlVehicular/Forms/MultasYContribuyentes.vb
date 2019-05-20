Public Class MultasYContribuyentes
    Private user As Empleado
    Private contribuyente As Contribuyente = New Contribuyente()
    Private multa As Multa = New Multa()

    Private pais As Pais = New Pais()
    Private estado As Estado = New Estado()
    Private ciudad As Ciudad = New Ciudad()
    Private colonia As Colonia = New Colonia()

    Private rowContribuyente As Integer
    Private rowMulta As Integer

    Public Sub New(user As Empleado)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.user = user
    End Sub

    Private Sub MultasYContribuyentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblUserData.Text = user.GetNombre & " " & user.GetPaterno
        Me.lblFechaData.Text = Date.Now.ToShortDateString
        Me.lblHoraData.Text = Date.Now.Hour & ":" & Date.Now.Minute
        Me.cbTipoBusqueda.SelectedItem = "CURP"
        Me.cbTiposSearchMultas.SelectedItem = "Placas"
        Me.pais.PoblarComboPaises(Me.cbPaises)
        Me.dateInit.Value = Date.Now.AddMonths(-7)
        Me.dateEnd.Value = Date.Now

        buscarContribuyentes()
        buscarMultas()
    End Sub

    Public Sub buscarContribuyentes()
        ' Condiciones de consulta para mostrar contribuyentes por localidad
        Dim joins As String() = {"INNER JOIN Domicilios ON Contribuyentes.idDomicilio=Domicilios.idDomicilio"}
        Dim condiciones As String() = {"Domicilios.idColonia=" & If(Me.cbColonias.SelectedValue = Nothing, 0, Me.cbColonias.SelectedValue)}

        ' Generacion de condiciones para buscar contribuyentes por estado de sus multas
        If Me.rbInfractoresPendientes.Checked Then
            joins = joins.Union({"INNER JOIN Licencias ON Licencias.idContribuyente=Contribuyentes.curp",
                                 "INNER JOIN PlacasVehiculos ON PlacasVehiculos.idLicencia=Licencias.idLicencia",
                                 "INNER JOIN Multas ON Multas.idPlacas=PlacasVehiculos.idPlacas"}).ToArray
            condiciones = condiciones.Union({"Multas.fechaLiquidacionMulta IS NULL"}).ToArray
        ElseIf Me.rbInfractoresLibres.Checked Then
            joins = joins.Union({"INNER JOIN Licencias ON Licencias.idContribuyente=Contribuyentes.curp",
                                 "INNER JOIN PlacasVehiculos ON PlacasVehiculos.idLicencia=Licencias.idLicencia",
                                 "INNER JOIN Multas ON Multas.idPlacas=PlacasVehiculos.idPlacas"}).ToArray
            condiciones = condiciones.Union({"NOT Multas.fechaLiquidacionMulta IS NULL"}).ToArray
        ElseIf Me.rbNoInfractores.Checked Then
            joins = joins.Union({"INNER JOIN Licencias ON Licencias.idContribuyente=Contribuyentes.curp",
                                 "INNER JOIN PlacasVehiculos ON PlacasVehiculos.idLicencia=Licencias.idLicencia",
                                 "LEFT JOIN Multas ON Multas.idPlacas=PlacasVehiculos.idPlacas"}).ToArray
            condiciones = condiciones.Union({"Multas.idPlacas IS NULL"}).ToArray
        End If

        'Esta linea ejecuta la consulta con la informacion de arriba e inserta los datos dentro del datagrid
        Me.DataContribuyentes.DataSource = Me.contribuyente.BuscarContribuyentesByConditions(joins, condiciones)

        'Este ciclo es usado unicamente para ajustar el tamaño de las celdas 
        If Me.DataContribuyentes.Rows.Count > 0 Then
            Me.DataContribuyentes.Columns.Remove("idDomicilio")

            Dim noColumnas = Me.contribuyente.BuscarContribuyentes.Columns.Count - 1
            For index = 0 To noColumnas - 1
                Me.DataContribuyentes.Columns(index).Width = CInt(Me.DataContribuyentes.Width / noColumnas)
            Next
        End If
    End Sub

    Public Sub buscarMultas()
        Dim columnas As String() = {"Contribuyentes.curp", "Contribuyentes.nombre", "Contribuyentes.paterno", "Licencias.idLicencia"}
        Dim joins As String() = {"INNER JOIN PlacasVehiculos ON PlacasVehiculos.idPlacas=Multas.idPlacas",
                                 "INNER JOIN Licencias ON Licencias.idLicencia=PlacasVehiculos.idLicencia",
                                 "INNER JOIN Contribuyentes ON Licencias.idContribuyente=Contribuyentes.curp"}
        Dim condiciones As String() = {"Multas.fechaExpedicionMulta > TO_DATE('" & Me.dateInit.Value.ToString("yyyy/MM/dd HH:mm:ss") & "', 'yyyy/mm/dd hh24:mi:ss')",
                                       "Multas.fechaExpedicionMulta < TO_DATE('" & Me.dateEnd.Value.ToString("yyyy/MM/dd HH:mm:ss") & "', 'yyyy/mm/dd hh24:mi:ss')"}

        If Me.rbMultasPagadas.Checked Then
            condiciones = condiciones.Union({"NOT Multas.fechaLiquidacionMulta IS NULL"}).ToArray
        End If
        If Me.rbMultasSinPagar.Checked Then
            condiciones = condiciones.Union({"Multas.fechaLiquidacionMulta IS NULL"}).ToArray
        End If
        Me.DataMultas.DataSource = Me.multa.BuscarMultasByConditions(columnas, joins, condiciones)

        If Me.DataMultas.Rows.Count > 0 Then
            Dim noColumnas = Me.multa.BuscarMultasByConditions(columnas, joins, condiciones).Columns.Count
            For index = 0 To noColumnas - 1
                Me.DataMultas.Columns(index).Width = CInt(Me.DataMultas.Width / noColumnas)
            Next
        End If
    End Sub

    Private Sub MenuToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.DropDownOpened
        MenuToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub MenuToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.DropDownClosed
        MenuToolStripMenuItem.ForeColor = Color.White
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Me.lblFechaData.Text = Date.Now.ToShortDateString
        Me.lblHoraData.Text = Date.Now.Hour & ":" & Date.Now.Minute
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        RegistrarEmpleados.Show()
    End Sub

    Private Sub LocalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalidadesToolStripMenuItem.Click
        RegistrarLocaciones.Show()
    End Sub

    Private Sub cbPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaises.SelectedIndexChanged
        Me.estado.PoblarComboEstados(Me.cbPaises.SelectedValue, Me.cbEstados)
    End Sub

    Private Sub cbEstados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstados.SelectedIndexChanged
        Me.ciudad.PoblarComboCiudades(Me.cbEstados.SelectedValue, Me.cbCiudades)
    End Sub

    Private Sub cbCiudades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCiudades.SelectedIndexChanged
        Me.colonia.PoblarComboColonias(Me.cbCiudades.SelectedValue, cbColonias)
    End Sub

    Private Sub cbColonias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbColonias.SelectedIndexChanged
        buscarContribuyentes()
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        buscarContribuyentes()
    End Sub

    Private Sub rbInfractoresPendientes_CheckedChanged(sender As Object, e As EventArgs) Handles rbInfractoresPendientes.CheckedChanged
        buscarContribuyentes()
    End Sub

    Private Sub rbInfractoresLibres_CheckedChanged(sender As Object, e As EventArgs) Handles rbInfractoresLibres.CheckedChanged
        buscarContribuyentes()
    End Sub

    Private Sub rbNoInfractores_CheckedChanged(sender As Object, e As EventArgs) Handles rbNoInfractores.CheckedChanged
        buscarContribuyentes()
    End Sub

    Private Sub buscarContribuyenteBySearchBar()
        Dim condiciones As String()

        Select Case Me.cbTipoBusqueda.SelectedItem
            Case "CURP"
                condiciones = {"curp LIKE '%" & Me.txtSearch.Text & "%'"}
            Case "Nombre"
                condiciones = {"nombre LIKE '%" & Me.txtSearch.Text & "%'"}
            Case "Apellido"
                condiciones = {"paterno LIKE '%" & Me.txtSearch.Text & "%' OR materno LIKE '%" & Me.txtSearch.Text & "%'"}
            Case Else
                condiciones = {}
        End Select

        Me.DataContribuyentes.DataSource = Me.contribuyente.BuscarContribuyentesByConditions({}, condiciones)

        'Este ciclo es usado unicamente para ajustar el tamaño de las celdas 
        If Me.DataContribuyentes.Rows.Count > 0 Then
            Me.DataContribuyentes.Columns.Remove("idDomicilio")

            Dim noColumnas = Me.contribuyente.BuscarContribuyentes.Columns.Count - 1
            For index = 0 To noColumnas - 1
                Me.DataContribuyentes.Columns(index).Width = CInt(Me.DataContribuyentes.Width / noColumnas)
            Next
        End If
    End Sub

    Private Sub buscarMultasBySearchBar()
        Dim columnas As String() = {"Contribuyentes.curp", "Contribuyentes.nombre", "Contribuyentes.paterno", "Licencias.idLicencia"}
        Dim joins As String() = {"INNER JOIN PlacasVehiculos ON PlacasVehiculos.idPlacas=Multas.idPlacas",
                                 "INNER JOIN Licencias ON Licencias.idLicencia=PlacasVehiculos.idLicencia",
                                 "INNER JOIN Contribuyentes ON Licencias.idContribuyente=Contribuyentes.curp"}
        Dim condiciones As String()

        Select Case Me.cbTiposSearchMultas.SelectedItem
            Case "Placas"
                condiciones = {"PlacasVehiculos.idPlacas LIKE '%" & Me.txtSearchMultas.Text & "%'"}
            Case "Licencia"
                condiciones = {"Licencias.idLicencia LIKE '%" & Me.txtSearchMultas.Text & "%'"}
            Case "Curp"
                condiciones = {"Contribuyentes.curp LIKE '%" & Me.txtSearchMultas.Text & "%'"}
            Case Else
                condiciones = {}
        End Select

        Me.DataMultas.DataSource = Me.multa.BuscarMultasByConditions(columnas, joins, condiciones)

        Dim noColumnas = Me.multa.BuscarMultasByConditions(columnas, joins, condiciones).Columns.Count
        For index = 0 To noColumnas - 1
            Me.DataMultas.Columns(index).Width = CInt(Me.DataMultas.Width / noColumnas)
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        buscarContribuyenteBySearchBar()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            buscarContribuyenteBySearchBar()
        End If
    End Sub

    Private Sub rbTodosMultas_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodosMultas.CheckedChanged
        buscarMultas()
    End Sub

    Private Sub rbMultasPagadas_CheckedChanged(sender As Object, e As EventArgs) Handles rbMultasPagadas.CheckedChanged
        buscarMultas()
    End Sub

    Private Sub rbMultasSinPagar_CheckedChanged(sender As Object, e As EventArgs) Handles rbMultasSinPagar.CheckedChanged
        buscarMultas()
    End Sub

    Private Sub dateInit_ValueChanged(sender As Object, e As EventArgs) Handles dateInit.ValueChanged
        buscarMultas()
    End Sub

    Private Sub dateEnd_ValueChanged(sender As Object, e As EventArgs) Handles dateEnd.ValueChanged
        buscarMultas()
    End Sub

    Private Sub btnBuscarMultas_Click(sender As Object, e As EventArgs) Handles btnBuscarMultas.Click
        buscarMultasBySearchBar()
    End Sub

    Private Sub btnBuscarMultas_KeyDown(sender As Object, e As KeyEventArgs) Handles btnBuscarMultas.KeyDown
        If e.KeyCode = Keys.Enter Then
            buscarMultasBySearchBar()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        RegistrarContribuyentes.Show()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Me.rowContribuyente >= 0 And Me.rowContribuyente < Me.DataContribuyentes.Rows.Count Then
            Dim contribuyentesForm = New RegistrarContribuyentes(Me.DataContribuyentes.Rows(rowContribuyente).Cells("curp").Value)
            contribuyentesForm.Show()
        Else
            MsgBox("Seleccione un registro primero.", MsgBoxStyle.MsgBoxHelp)
        End If
    End Sub

    Private Sub DataContribuyentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataContribuyentes.CellContentClick
        Me.rowContribuyente = Me.DataContribuyentes.SelectedCells(0).RowIndex
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim tmpContribuyente As Contribuyente = New Contribuyente()
        Dim tmpDomicilio As Domicilio = New Domicilio()

        If Not Me.rowContribuyente >= 0 And Not Me.rowContribuyente < Me.DataContribuyentes.Rows.Count Then
            MsgBox("Seleccione un registro primero.", MsgBoxStyle.MsgBoxHelp)
            Exit Sub
        End If

        If MsgBox("Desea eliminar registro?." + vbNewLine + "Por favor confirme.", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me.DataContribuyentes.Rows(rowContribuyente).Cells("curp").Value.Length <> 18 Then
            MsgBox("Insuficientes caracteres en la curp." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not tmpContribuyente.BuscarContribuyenteById(Me.DataContribuyentes.Rows(rowContribuyente).Cells("curp").Value) Then
            MsgBox("No se pudo eliminar contribuyente." + vbNewLine + "Contribuyente inexistente.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        tmpDomicilio.BuscarDomicilioById(tmpContribuyente.GetIdDomicilio)

        If Not tmpContribuyente.EliminarContribuyente Then
            MsgBox("No se pudo eliminar contribuyente." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Not tmpDomicilio.EliminarDomicilio Then
            MsgBox("No se pudo eliminar Domicilio." + vbNewLine + "Se requiere eliminacion manual." + vbNewLine + "Utilice ventana de mantenimiento para locaciones.", MsgBoxStyle.Critical, "Error")
        End If

        MsgBox("Contribuyente Eliminado Exitosamente.", MsgBoxStyle.Information, "Correcto")
        buscarContribuyentes()
    End Sub

    Private Sub btnAgregarMulta_Click(sender As Object, e As EventArgs) Handles btnAgregarMulta.Click
        RegistrarMultas.Show()
    End Sub

    Private Sub btnModificarMulta_Click(sender As Object, e As EventArgs) Handles btnModificarMulta.Click
        If Me.rowMulta >= 0 And Me.rowMulta < Me.DataMultas.Rows.Count Then
            Dim multasForm = New RegistrarMultas(Me.DataMultas.Rows(rowMulta).Cells("idMulta").Value)
            multasForm.Show()
        Else
            MsgBox("Seleccione un registro primero.", MsgBoxStyle.MsgBoxHelp)
        End If
    End Sub

    Private Sub btnEliminarMultas_Click(sender As Object, e As EventArgs) Handles btnEliminarMultas.Click
        Dim tmpMulta As Multa = New Multa()

        If Not Me.rowMulta >= 0 And Not Me.rowMulta < Me.DataMultas.Rows.Count Then
            MsgBox("Seleccione un registro primero.", MsgBoxStyle.MsgBoxHelp)
            Exit Sub
        End If

        If MsgBox("Desea eliminar registro?." + vbNewLine + "No se deben eliminar multas de esta forma. (metodo solo para uso academico)", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Not tmpMulta.BuscarMultaById(Me.DataMultas.Rows(rowMulta).Cells("idMulta").Value) Then
            MsgBox("No se pudo eliminar multa." + vbNewLine + "Multa inexistente.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        tmpMulta.BuscarMultaById(Me.DataMultas.Rows(rowMulta).Cells("idMulta").Value)

        If Not tmpMulta.EliminarMulta Then
            MsgBox("No se pudo eliminar multa." + vbNewLine + "compruebe sus datos.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        MsgBox("Multa Eliminada Exitosamente.", MsgBoxStyle.Information, "Correcto")
        buscarMultas()
    End Sub

    Private Sub DataMultas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataMultas.CellContentClick
        Me.rowMulta = Me.DataMultas.SelectedCells(0).RowIndex
    End Sub

    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        If Me.rowMulta >= 0 And Me.rowMulta < Me.DataMultas.Rows.Count Then
            Dim multasForm = New RegistrarMultas(Me.DataMultas.Rows(rowMulta).Cells("idMulta").Value)
            multasForm.Show()
        Else
            MsgBox("Seleccione un registro primero.", MsgBoxStyle.MsgBoxHelp)
        End If
    End Sub

    Private Sub btnVehiculos_Click(sender As Object, e As EventArgs) Handles btnVehiculos.Click
        Dim formVehiculo As New RegistrarVehiculo(Me.user.GetCurp)
        formVehiculo.Show()
    End Sub

    Private Sub btnLicencias_Click(sender As Object, e As EventArgs) Handles btnLicencias.Click
        RegistrarLicencias.Show()
    End Sub

    Private Sub btnPlacas_Click(sender As Object, e As EventArgs) Handles btnPlacas.Click
        RegistrarPlacas.Show()
    End Sub
End Class