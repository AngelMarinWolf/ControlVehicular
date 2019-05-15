Public Class Colonia
    Private Const Tabla As String = "Colonias"

    Private idColonia As Integer
    Private idCiudad As Integer
    Private nombre As String

    Public Sub New()

    End Sub

    Public Sub New(idColonia As Integer, idCiudad As Integer, nombre As String)
        Me.idColonia = idColonia
        Me.idCiudad = idCiudad
        Me.nombre = nombre
    End Sub

    Public Function GetIdColonia() As Integer
        Return Me.idColonia
    End Function

    Public Function GetIdCiudad() As Integer
        Return Me.idCiudad
    End Function

    Public Function GetNombreEstado() As String
        Return Me.nombre
    End Function

    Public Sub SetIdColonia(idColonia As Integer)
        Me.idColonia = idColonia
    End Sub

    Public Sub SetIdCiudad(idCiudad As Integer)
        Me.idCiudad = idCiudad
    End Sub

    Public Sub SetNombreEstado(nombre As String)
        Me.nombre = nombre
    End Sub

    Public Function RegistrarColonia() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"nombre", "idCiudad"}
        Dim valores As String() = {Me.nombre, Me.idCiudad}
        Dim result = database.Insertar(Tabla, columnas, valores)
        Return result
    End Function

    Public Function ActualizarColonia() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"nombre", "idCiudad"}
        Dim valores As String() = {Me.nombre, Me.idCiudad}
        Dim condiciones As String() = {"idColonia=" & Me.idColonia}
        Dim result = database.Actualizar(Tabla, columnas, valores, condiciones)
        Return result
    End Function

    Public Function EliminarColonia() As Boolean
        Dim database As Oracle = New Oracle()
        Dim condiciones As String() = {"idColonia=" & Me.idColonia}
        Dim result = database.Eliminar(Tabla, condiciones)
        Return result
    End Function

    Public Function BuscarColoniaByNombre(nombre As String) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idCiudad", "idColonia", "nombre"}
        Dim condiciones As String() = {"nombre=" & nombre}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idCiudad")) And
               Not IsDBNull(result.Rows(0)("idColonia")) And
               Not IsDBNull(result.Rows(0)("nombre")) Then
                SetIdCiudad(CInt(result.Rows(0)("idCiudad")))
                SetIdColonia(CInt(result.Rows(0)("idColonia")))
                SetNombreEstado(CStr(result.Rows(0)("nombre")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function

    Public Function BuscarColoniaById(idColonia As Integer) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idCiudad", "idColonia", "nombre"}
        Dim condiciones As String() = {"idColonia=" & idColonia}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idCiudad")) And
               Not IsDBNull(result.Rows(0)("idColonia")) And
               Not IsDBNull(result.Rows(0)("nombre")) Then
                SetIdCiudad(CInt(result.Rows(0)("idCiudad")))
                SetIdColonia(CInt(result.Rows(0)("idColonia")))
                SetNombreEstado(CStr(result.Rows(0)("nombre")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function

    Public Function BuscarColoniasByCiudad(idCiudad As Integer) As DataTable
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idCiudad", "idColonia", "nombre"}
        Dim condiciones As String() = {"idCiudad=" & idCiudad}

        Return database.Buscar({Tabla}, columnas, condiciones)
    End Function

    Public Sub PoblarComboColonias(idEstado As Integer, cbColonias As ComboBox)
        cbColonias.DisplayMember = "Value"
        cbColonias.ValueMember = "Key"
        Dim ciudades As DataTable = BuscarColoniasByCiudad(idEstado)
        If ciudades.Rows.Count > 0 Then
            Dim coloniasDictionary As New Dictionary(Of Integer, String)
            For index = 0 To ciudades.Rows.Count - 1
                coloniasDictionary.Add(ciudades.Rows(index)("idColonia"), ciudades.Rows(index)("nombre"))
            Next
            cbColonias.DataSource = New BindingSource(coloniasDictionary, Nothing)
        Else
            cbColonias.DataSource = Nothing
        End If
    End Sub
End Class
