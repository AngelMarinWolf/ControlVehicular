Public Class Colonia
    Private Const Tabla As String = "Colonia"

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

    Public Sub BuscarColoniaByNombre(nombre As String)
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idCiudad", "idColonia", "nombre"}
        Dim condiciones As String() = {"nombre=" & nombre}
        Dim result As DataTable

        result = database.Buscar(Tabla, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idCiudad")) And
               Not IsDBNull(result.Rows(0)("idColonia")) And
               Not IsDBNull(result.Rows(0)("nombre")) Then
                SetIdCiudad(CInt(result.Rows(0)("idCiudad")))
                SetIdColonia(CInt(result.Rows(0)("idColonia")))
                SetNombreEstado(CStr(result.Rows(0)("nombre")))
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Throw New Exception("Error: No se encontro ningun registro.")
        End If
    End Sub

    Public Sub BuscarColoniaById(idColonia As Integer)
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idCiudad", "idColonia", "nombre"}
        Dim condiciones As String() = {"idColonia=" & idColonia}
        Dim result As DataTable

        result = database.Buscar(Tabla, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idCiudad")) And
               Not IsDBNull(result.Rows(0)("idColonia")) And
               Not IsDBNull(result.Rows(0)("nombre")) Then
                SetIdCiudad(CInt(result.Rows(0)("idCiudad")))
                SetIdColonia(CInt(result.Rows(0)("idColonia")))
                SetNombreEstado(CStr(result.Rows(0)("nombre")))
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Throw New Exception("Error: No se encontro ningun registro.")
        End If
    End Sub
End Class
