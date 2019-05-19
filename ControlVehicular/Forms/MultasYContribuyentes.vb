Public Class MultasYContribuyentes
    Private user As Empleado
    Private contribuyente As Contribuyente = New Contribuyente()

    Private pais As Pais = New Pais()
    Private estado As Estado = New Estado()
    Private ciudad As Ciudad = New Ciudad()
    Private colonia As Colonia = New Colonia()

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
        Me.pais.PoblarComboPaises(Me.cbPaises)

        buscarContribuyentes()
    End Sub

    Private Sub buscarContribuyentes()
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        buscarContribuyenteBySearchBar()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            buscarContribuyenteBySearchBar()
        End If
    End Sub
End Class