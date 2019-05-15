Public Class Placas
    Private Const Tabla As String = "PlacasVehiculos"

    Private idPlacas As String
    Private idLicencia As Integer
    Private idVehiculo As String

    Public Sub New()

    End Sub

    Public Sub New(idPlacas As String, idLicencia As Integer, idVehiculo As String)
        Me.idPlacas = idPlacas
        Me.idLicencia = idLicencia
        Me.idVehiculo = idVehiculo
    End Sub

    Public Sub SetIdPlacas(idPlacas As String)
        If idPlacas.Length < 10 Then
            Me.idPlacas = idPlacas
        Else
            Throw New Exception("Error: Numero de placas demaciado extenso.")
        End If
    End Sub

    Public Sub SetIdLicencia(idLicencia As Integer)
        Me.idLicencia = idLicencia
    End Sub

    Public Sub SetIdVehiculo(idVehiculo As String)
        If idVehiculo.Length < 18 Then
            Me.idVehiculo = idVehiculo
        Else
            Throw New Exception("Error: Numero de placas demaciado extenso.")
        End If
    End Sub

    Public Function GetIdPlacas() As String
        Return Me.idPlacas
    End Function

    Public Function GetIdLicencia() As Integer
        Return Me.idLicencia
    End Function

    Public Function GetIdVehiculo() As String
        Return Me.idVehiculo
    End Function

    Public Function RegistrarPlacas() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idPlacas", "idLicencia", "idVehiculo"}
        Dim valores As String() = {Me.idPlacas, Me.idLicencia, Me.idVehiculo}
        Dim result = database.Insertar(Tabla, columnas, valores)
        Return result
    End Function

    Public Function ActualizarPlacas() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idLicencia", "idVehiculo"}
        Dim valores As String() = {Me.idLicencia, Me.idVehiculo}
        Dim condiciones As String() = {"idPlacas=" & Me.idPlacas}
        Dim result = database.Actualizar(Tabla, columnas, valores, condiciones)
        Return result
    End Function

    Public Function EliminarPlacas() As Boolean
        Dim database As Oracle = New Oracle()
        Dim condiciones As String() = {"idPlacas=" & Me.idPlacas}
        Dim result = database.Eliminar(Tabla, condiciones)
        Return result
    End Function

    Public Function BuscarPlacasById(idPlacas As Integer) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idPlacas", "idLicencia", "idVehiculo"}
        Dim condiciones As String() = {"idPlacas=" & idPlacas}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idPlacas")) And
               Not IsDBNull(result.Rows(0)("idLicencia")) And
               Not IsDBNull(result.Rows(0)("idVehiculo")) Then
                SetIdPlacas(CStr(result.Rows(0)("idPlacas")))
                SetIdLicencia(CInt(result.Rows(0)("idLicencia")))
                SetIdVehiculo(CStr(result.Rows(0)("idVehiculo")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function
End Class