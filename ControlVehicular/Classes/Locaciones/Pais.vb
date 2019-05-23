Public Class Pais
    Private Const Tabla As String = "Paises"
    Private idPais As Integer
    Private nombre As String

    Public Sub New()

    End Sub

    Public Sub New(idPais As Integer, nombre As String)
        Me.idPais = idPais
        Me.nombre = nombre
    End Sub

    Public Function GetId() As Integer
        Return Me.idPais
    End Function

    Public Function GetNombre() As String
        Return Me.nombre
    End Function

    Public Sub SetId(idPais As Integer)
        Me.idPais = idPais
    End Sub

    Public Sub SetNombre(nombre As String)
        Me.nombre = nombre
    End Sub

    Public Function RegistrarPais() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idPais", "nombre"}
        Dim valores As String() = {BuscarUltimoId() + 1, "'" & Me.nombre & "'"}
        Dim result = database.Insertar(Tabla, columnas, valores)
        Return result
    End Function

    Public Function ActualizarPais() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"nombre"}
        Dim valores As String() = {"'" & Me.nombre & "'"}
        Dim condiciones As String() = {"idPais=" & Me.idPais}
        Dim result = database.Actualizar(Tabla, columnas, valores, condiciones)
        Return result
    End Function

    Public Function EliminarPais() As Boolean
        Dim database As Oracle = New Oracle()
        Dim condiciones As String() = {"idPais=" & Me.idPais}
        Dim result = database.Eliminar(Tabla, condiciones)
        Return result
    End Function

    Public Function BuscarPaisByNombre(nombre As String) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idPais", "nombre"}
        Dim condiciones As String() = {"nombre=" & "'" & nombre & "'"}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)
        result.DefaultView.Sort = "idPais ASC"

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idPais")) And
               Not IsDBNull(result.Rows(0)("nombre")) Then
                SetId(CInt(result.Rows(0)("idPais")))
                SetNombre(CStr(result.Rows(0)("nombre")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function

    Public Function BuscarPaisById(idPais As Integer) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idPais", "nombre"}
        Dim condiciones As String() = {"idPais=" & idPais}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)
        result.DefaultView.Sort = "idPais ASC"

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idPais")) And
               Not IsDBNull(result.Rows(0)("nombre")) Then
                SetId(CInt(result.Rows(0)("idPais")))
                SetNombre(CStr(result.Rows(0)("nombre")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function

    Public Function BuscarPaises() As DataTable
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idPais", "nombre"}
        Dim result As DataTable = database.Buscar({Tabla}, columnas, {})
        result.DefaultView.Sort = "idPais ASC"

        Return result
    End Function

    Public Sub PoblarComboPaises(cbPaises As ComboBox)
        cbPaises.DisplayMember = "Value"
        cbPaises.ValueMember = "Key"
        Dim paises As DataTable = BuscarPaises()
        paises.DefaultView.Sort = "idPais ASC"
        paises = paises.DefaultView.ToTable()

        If paises.Rows.Count > 0 Then
            Dim paisesDictionary As New Dictionary(Of Integer, String)
            For index = 0 To paises.Rows.Count - 1
                paisesDictionary.Add(paises.Rows(index)("idPais"), paises.Rows(index)("nombre"))
            Next
            cbPaises.DataSource = New BindingSource(paisesDictionary, Nothing)
        Else
            cbPaises.DataSource = Nothing
        End If
    End Sub

    Public Function BuscarUltimoId() As Integer
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"Max(idPais) AS idPais"}

        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, {})
        If result.Rows.Count = 1 And Not IsDBNull(result.Rows(0)("idPais")) Then
            Return CInt(result.Rows(0)("idPais"))
        Else
            Return 0
        End If
    End Function
End Class
