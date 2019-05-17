Public Class Ciudad
    Private Const Tabla As String = "Ciudades"

    Private idEstado As Integer
    Private idCiudad As Integer
    Private nombre As String

    Public Sub New()

    End Sub

    Public Sub New(idEstado As Integer, idCiudad As Integer, nombre As String)
        Me.idEstado = idEstado
        Me.idCiudad = idCiudad
        Me.nombre = nombre
    End Sub

    Public Function GetIdEstado() As Integer
        Return Me.idEstado
    End Function

    Public Function GetIdCiudad() As Integer
        Return Me.idCiudad
    End Function

    Public Function GetNombreCiudad() As String
        Return Me.nombre
    End Function

    Public Sub SetIdEstado(idEstado As Integer)
        Me.idEstado = idEstado
    End Sub

    Public Sub SetIdCiudad(idCiudad As Integer)
        Me.idCiudad = idCiudad
    End Sub

    Public Sub SetNombreCiudad(nombre As String)
        Me.nombre = nombre
    End Sub

    Public Function RegistrarCiudad() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"nombre", "idEstado", "idCiudad"}
        Dim valores As String() = {"'" & Me.nombre & "'", Me.idEstado, BuscarUltimoId() + 1}
        Dim result = database.Insertar(Tabla, columnas, valores)
        Return result
    End Function

    Public Function ActualizarCiudad() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"nombre", "idEstado"}
        Dim valores As String() = {"'" & Me.nombre & "'", Me.idEstado}
        Dim condiciones As String() = {"idCiudad=" & Me.idCiudad}
        Dim result = database.Actualizar(Tabla, columnas, valores, condiciones)
        Return result
    End Function

    Public Function EliminarCiudad() As Boolean
        Dim database As Oracle = New Oracle()
        Dim condiciones As String() = {"idCiudad=" & Me.idCiudad}
        Dim result = database.Eliminar(Tabla, condiciones)
        Return result
    End Function

    Public Function BuscarCiudadByNombre(nombre As String) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idCiudad", "idEstado", "nombre"}
        Dim condiciones As String() = {"nombre=" & "'" & nombre & "'"}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)
        result.DefaultView.Sort = "idCiudad ASC"

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idCiudad")) And
               Not IsDBNull(result.Rows(0)("idEstado")) And
               Not IsDBNull(result.Rows(0)("nombre")) Then
                SetIdCiudad(CInt(result.Rows(0)("idCiudad")))
                SetIdEstado(CInt(result.Rows(0)("idEstado")))
                SetNombreCiudad(CStr(result.Rows(0)("nombre")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function

    Public Function BuscarCiudadById(idCiudad As Integer) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idCiudad", "idEstado", "nombre"}
        Dim condiciones As String() = {"idCiudad=" & idCiudad}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)
        result.DefaultView.Sort = "idCiudad ASC"

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idCiudad")) And
               Not IsDBNull(result.Rows(0)("idEstado")) And
               Not IsDBNull(result.Rows(0)("nombre")) Then
                SetIdCiudad(CInt(result.Rows(0)("idCiudad")))
                SetIdEstado(CInt(result.Rows(0)("idEstado")))
                SetNombreCiudad(CStr(result.Rows(0)("nombre")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function

    Public Function BuscarCiudadesByEstado(idEstado As Integer) As DataTable
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idCiudad", "idEstado", "nombre"}
        Dim condiciones As String() = {"idEstado=" & idEstado}
        Dim result As DataTable = database.Buscar({Tabla}, columnas, condiciones)
        result.DefaultView.Sort = "idCiudad ASC"

        Return result
    End Function

    Public Sub PoblarComboCiudades(idEstado As Integer, cbCiudades As ComboBox)
        cbCiudades.DisplayMember = "Value"
        cbCiudades.ValueMember = "Key"
        Dim ciudades As DataTable = BuscarCiudadesByEstado(idEstado)
        ciudades.DefaultView.Sort = "idCiudad ASC"
        ciudades = ciudades.DefaultView.ToTable()

        If ciudades.Rows.Count > 0 Then
            Dim ciudadesDictionary As New Dictionary(Of Integer, String)
            For index = 0 To ciudades.Rows.Count - 1
                ciudadesDictionary.Add(ciudades.Rows(index)("idCiudad"), ciudades.Rows(index)("nombre"))
            Next
            cbCiudades.DataSource = New BindingSource(ciudadesDictionary, Nothing)
        Else
            cbCiudades.DataSource = Nothing
        End If
    End Sub

    Public Function BuscarUltimoId() As Integer
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"Max(idCiudad) AS idCiudad"}

        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, {})
        If result.Rows.Count = 1 Then
            Return CInt(result.Rows(0)("idCiudad"))
        Else
            Return 0
        End If
    End Function
End Class
