Public Class Domicilio
    Private Const Tabla As String = "Domicilios"

    Private idColonia As Integer
    Private idDomicilio As Integer
    Private calle As String
    Private numero As String

    Public Sub New()

    End Sub

    Public Sub New(idColonia As Integer, idDomicilio As Integer, calle As String, numero As String)
        Me.idColonia = idColonia
        Me.idDomicilio = idDomicilio
        Me.calle = calle
        Me.numero = numero
    End Sub

    Public Function GetIdColonia() As Integer
        Return Me.idColonia
    End Function

    Public Function GetIdDomicilio() As Integer
        Return Me.idDomicilio
    End Function

    Public Function GetCalleDomicilio() As String
        Return Me.calle
    End Function

    Public Function GetNumeroDomicilio() As String
        Return Me.numero
    End Function

    Public Sub SetIdColonia(idColonia As Integer)
        Me.idColonia = idColonia
    End Sub

    Public Sub SetIdDomicilio(idDomicilio As Integer)
        Me.idDomicilio = idDomicilio
    End Sub

    Public Sub SetCalleDomicilio(calle As String)
        Me.calle = calle
    End Sub

    Public Sub SetNumeroDomicilio(numero As String)
        Me.numero = numero
    End Sub

    Public Function RegistrarDomicilio() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idDomicilio", "calle", "No_domicilio", "idColonia"}
        Dim valores As String() = {Me.idDomicilio, "'" & Me.calle & "'", "'" & Me.numero & "'", Me.idColonia}
        Dim result = database.Insertar(Tabla, columnas, valores)
        Return result
    End Function

    Public Function ActualizarDomicilio() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"calle", "No_domicilio", "idColonia"}
        Dim valores As String() = {"'" & Me.calle & "'", "'" & Me.numero & "'", Me.idColonia}
        Dim condiciones As String() = {"idDomicilio=" & Me.idDomicilio}
        Dim result = database.Actualizar(Tabla, columnas, valores, condiciones)
        Return result
    End Function

    Public Function EliminarDomicilio() As Boolean
        Dim database As Oracle = New Oracle()
        Dim condiciones As String() = {"idDomicilio=" & Me.idDomicilio}
        Dim result = database.Eliminar(Tabla, condiciones)
        Return result
    End Function

    Public Function BuscarDomicilioById(idDomicilio As Integer) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idDomicilio", "idColonia", "calle", "No_domicilio"}
        Dim condiciones As String() = {"idDomicilio=" & idDomicilio}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idDomicilio")) And
               Not IsDBNull(result.Rows(0)("idColonia")) And
               Not IsDBNull(result.Rows(0)("calle")) And
               Not IsDBNull(result.Rows(0)("No_domicilio")) Then
                SetIdDomicilio(CInt(result.Rows(0)("idDomicilio")))
                SetIdColonia(CInt(result.Rows(0)("idColonia")))
                SetCalleDomicilio(CStr(result.Rows(0)("calle")))
                SetNumeroDomicilio(CStr(result.Rows(0)("No_domicilio")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function

    Public Function BuscarUltimoId() As Integer
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"Max(idDomicilio) AS idDomicilio"}

        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, {})
        If result.Rows.Count = 1 Then
            Return CInt(result.Rows(0)("idDomicilio"))
        Else
            Return 0
        End If
    End Function
End Class