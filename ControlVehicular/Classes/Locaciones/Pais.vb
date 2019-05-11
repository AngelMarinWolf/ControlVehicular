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
        Dim columnas As String() = {"nombre"}
        Dim valores As String() = {Me.nombre}
        Dim result = database.Insertar(Tabla, columnas, valores)
        Return result
    End Function

    Public Function ActualizarPais() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"nombre"}
        Dim valores As String() = {Me.nombre}
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

    Public Sub BuscarPaisByNombre(nombre As String)
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idPais", "nombre"}
        Dim condiciones As String() = {"nombre=" & nombre}
        Dim result As DataTable

        result = database.Buscar(Tabla, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idPais")) And Not IsDBNull(result.Rows(0)("nombre")) Then
                SetId(CInt(result.Rows(0)("idPais")))
                SetNombre(CStr(result.Rows(0)("nombre")))
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Throw New Exception("Error: No se encontro ningun registro.")
        End If
    End Sub

    Public Sub BuscarPaisById(idPais As Integer)
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idPais", "nombre"}
        Dim condiciones As String() = {"idPais=" & idPais}
        Dim result As DataTable

        result = database.Buscar(Tabla, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idPais")) And Not IsDBNull(result.Rows(0)("nombre")) Then
                SetId(CInt(result.Rows(0)("idPais")))
                SetNombre(CStr(result.Rows(0)("nombre")))
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Throw New Exception("Error: No se encontro ningun registro.")
        End If
    End Sub
End Class
