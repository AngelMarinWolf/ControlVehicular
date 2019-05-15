Public Class Estado
    Private Const Tabla As String = "Estados"

    Private idEstado As Integer
    Private idPais As Integer
    Private nombre As String

    Public Sub New()

    End Sub

    Public Sub New(idEstado As Integer, idPais As Integer, nombre As String)
        Me.idEstado = idEstado
        Me.idPais = idPais
        Me.nombre = nombre
    End Sub

    Public Function GetIdEstado() As Integer
        Return Me.idEstado
    End Function

    Public Function GetIdPais() As Integer
        Return Me.idPais
    End Function

    Public Function GetNombreEstado() As String
        Return Me.nombre
    End Function

    Public Sub SetIdEstado(idEstado As Integer)
        Me.idEstado = idEstado
    End Sub

    Public Sub SetIdPais(idPais As Integer)
        Me.idPais = idPais
    End Sub

    Public Sub SetNombreEstado(nombre As String)
        Me.nombre = nombre
    End Sub

    Public Function RegistrarEstado() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"nombre", "idPais"}
        Dim valores As String() = {Me.nombre, Me.idPais}
        Dim result = database.Insertar(Tabla, columnas, valores)
        Return result
    End Function

    Public Function ActualizarEstado() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"nombre", "idPais"}
        Dim valores As String() = {Me.nombre, Me.idPais}
        Dim condiciones As String() = {"idEstado=" & Me.idEstado}
        Dim result = database.Actualizar(Tabla, columnas, valores, condiciones)
        Return result
    End Function

    Public Function EliminarEstado() As Boolean
        Dim database As Oracle = New Oracle()
        Dim condiciones As String() = {"idEstado=" & Me.idEstado}
        Dim result = database.Eliminar(Tabla, condiciones)
        Return result
    End Function

    Public Function BuscarEstadoByNombre(nombre As String) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idPais", "idEstado", "nombre"}
        Dim condiciones As String() = {"nombre=" & nombre}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idPais")) And
               Not IsDBNull(result.Rows(0)("idEstado")) And
               Not IsDBNull(result.Rows(0)("nombre")) Then
                SetIdPais(CInt(result.Rows(0)("idPais")))
                SetIdEstado(CInt(result.Rows(0)("idEstado")))
                SetNombreEstado(CStr(result.Rows(0)("nombre")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function

    Public Function BuscarEstadoById(idEstado As Integer) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idPais", "idEstado", "nombre"}
        Dim condiciones As String() = {"idEstado=" & idEstado}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idPais")) And
               Not IsDBNull(result.Rows(0)("idEstado")) And
               Not IsDBNull(result.Rows(0)("nombre")) Then
                SetIdPais(CInt(result.Rows(0)("idPais")))
                SetIdEstado(CInt(result.Rows(0)("idEstado")))
                SetNombreEstado(CStr(result.Rows(0)("nombre")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function

    Public Function BuscarEstadosByPais(idPais As Integer) As DataTable
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idPais", "idEstado", "nombre"}
        Dim condiciones As String() = {"idPais=" & idPais}

        Return database.Buscar({Tabla}, columnas, condiciones)
    End Function

    Public Sub PoblarComboEstados(idPais As Integer, cbEstados As ComboBox)
        cbEstados.DisplayMember = "Value"
        cbEstados.ValueMember = "Key"
        Dim estados As DataTable = BuscarEstadosByPais(idPais)
        If estados.Rows.Count > 0 Then
            Dim estadosDictionary As New Dictionary(Of Integer, String)
            For index = 0 To estados.Rows.Count - 1
                estadosDictionary.Add(estados.Rows(index)("idEstado"), estados.Rows(index)("nombre"))
            Next
            cbEstados.DataSource = New BindingSource(estadosDictionary, Nothing)
        Else
            cbEstados.DataSource = Nothing
        End If
    End Sub
End Class
