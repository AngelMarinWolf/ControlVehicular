Public Class Padron
    Private Const Tabla As String = "PadronVehicular"

    Private noSerie As String
    Private noFactura As String
    Private fechaFactura As Date
    Private importeFactura As Double
    Private implementacion As String
    Private color As String
    Private combustible As String
    Private pasajeros As Integer
    Private idTipo As Integer
    Private idMarca As Integer
    Private idContribuyente As String
    Private idEmpleado As String

    Public Sub New()

    End Sub

    Public Sub New(noSerie As String,
                   noFactura As String,
                   fechaFactura As Date,
                   importeFactura As Double,
                   implementacion As String,
                   color As String,
                   combustible As String,
                   pasajeros As Integer,
                   idTipo As Integer,
                   idMarca As Integer,
                   idContribuyente As String,
                   idEmpleado As String)
        Me.noSerie = noSerie
        Me.noFactura = noFactura
        Me.fechaFactura = fechaFactura
        Me.importeFactura = importeFactura
        Me.implementacion = implementacion
        Me.color = color
        Me.combustible = combustible
        Me.pasajeros = pasajeros
        Me.idTipo = idTipo
        Me.idMarca = idMarca
        Me.idContribuyente = idContribuyente
        Me.idEmpleado = idEmpleado
    End Sub

    Public Sub SetNoSerie(noSerie As String)
        If noSerie.Length < 18 Then
            Me.noSerie = noSerie
        Else
            Throw New Exception("Error: Numero de serie demasiado extenso.")
        End If
    End Sub

    Public Sub SetNoFactura(noFactura As String)
        Me.noFactura = noFactura
    End Sub

    Public Sub SetFechaFactura(fechaFactura As Date)
        Me.fechaFactura = fechaFactura
    End Sub

    Public Sub SetImporteFactura(importeFactura As Double)
        Me.importeFactura = importeFactura
    End Sub

    Public Sub SetImplementacion(implementacion As String)
        Me.implementacion = implementacion
    End Sub

    Public Sub SetColor(color As String)
        Me.color = color
    End Sub

    Public Sub SetCombustible(combustible As String)
        Me.combustible = combustible
    End Sub

    Public Sub SetPasajeros(pasajeros As Integer)
        Me.pasajeros = pasajeros
    End Sub

    Public Sub SetIdTipo(idtipo As Integer)
        Me.idTipo = idtipo
    End Sub

    Public Sub SetIdMarca(idMarca As Integer)
        Me.idMarca = idMarca
    End Sub

    Public Sub SetIdContribuyente(idContribuyente As String)
        If idContribuyente.Length = 18 Then
            Me.idContribuyente = idContribuyente
        Else
            Throw New Exception("Error: La curp no contiene la cantidad de caracteres especifica.")
        End If
    End Sub

    Public Sub SetIdEmpleado(idEmpleado As String)
        If idEmpleado.Length = 18 Then
            Me.idEmpleado = idEmpleado
        Else
            Throw New Exception("Error: La curp no contiene la cantidad de caracteres especifica.")
        End If
    End Sub

    Public Function GetNoSerie() As String
        Return Me.noSerie
    End Function

    Public Function GetNoFactura() As String
        Return Me.noFactura
    End Function

    Public Function GetFechaFactura() As Date
        Return Me.fechaFactura
    End Function

    Public Function GetImporteFactura() As Double
        Return Me.importeFactura
    End Function

    Public Function GetImplementacion() As String
        Return Me.implementacion
    End Function

    Public Function GetColor() As String
        Return Me.color
    End Function

    Public Function GetCombustible() As String
        Return Me.combustible
    End Function

    Public Function GetPasajeros() As Integer
        Return Me.pasajeros
    End Function

    Public Function GetIdTipo() As Integer
        Return Me.idTipo
    End Function

    Public Function GetIdMarca() As Integer
        Return Me.idMarca
    End Function

    Public Function GetIdContribuyente() As String
        Return Me.idContribuyente
    End Function

    Public Function GetIdEmpleado() As String
        Return Me.idEmpleado
    End Function

    Public Function RegistrarVehiculo() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"noSerie", "noFactura", "fechaFactura", "importeFactura", "implementacion", "color",
                                    "combustible", "pasajeros", "idTipo", "idMarca", "idContribuyente", "idEmpleado"}
        Dim valores As String() = {Me.noSerie, Me.noFactura, Me.fechaFactura, Me.importeFactura, Me.implementacion, Me.color,
                                   Me.combustible, Me.pasajeros, Me.idTipo, Me.idMarca, Me.idContribuyente, Me.idEmpleado}
        Dim result = database.Insertar(Tabla, columnas, valores)
        Return result
    End Function

    Public Function ActualizarVehiculo() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"noFactura", "fechaFactura", "importeFactura", "implementacion", "color",
                                    "combustible", "pasajeros", "idTipo", "idMarca", "idContribuyente", "idEmpleado"}
        Dim valores As String() = {Me.noFactura, Me.fechaFactura, Me.importeFactura, Me.implementacion, Me.color,
                                   Me.combustible, Me.pasajeros, Me.idTipo, Me.idMarca, Me.idContribuyente, Me.idEmpleado}
        Dim condiciones As String() = {"noSerie=" & Me.noSerie}
        Dim result = database.Actualizar(Tabla, columnas, valores, condiciones)
        Return result
    End Function

    Public Function EliminarVehiculo() As Boolean
        Dim database As Oracle = New Oracle()
        Dim condiciones As String() = {"noSerie=" & Me.noSerie}
        Dim result = database.Eliminar(Tabla, condiciones)
        Return result
    End Function

    Public Function BuscarVehiculoById(noSerie As String) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"noSerie", "noFactura", "fechaFactura", "importeFactura", "implementacion", "color",
                                    "combustible", "pasajeros", "idTipo", "idMarca", "idContribuyente", "idEmpleado"}
        Dim condiciones As String() = {"noSerie=" & noSerie}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("noSerie")) And
               Not IsDBNull(result.Rows(0)("noFactura")) And
               Not IsDBNull(result.Rows(0)("fechaFactura")) And
               Not IsDBNull(result.Rows(0)("importeFactura")) And
               Not IsDBNull(result.Rows(0)("implementacion")) And
               Not IsDBNull(result.Rows(0)("color")) And
               Not IsDBNull(result.Rows(0)("combustible")) And
               Not IsDBNull(result.Rows(0)("pasajeros")) And
               Not IsDBNull(result.Rows(0)("idTipo")) And
               Not IsDBNull(result.Rows(0)("idMarca")) And
               Not IsDBNull(result.Rows(0)("idContribuyente")) And
               Not IsDBNull(result.Rows(0)("idEmpleado")) Then
                SetNoSerie(CStr(result.Rows(0)("noSerie")))
                SetNoFactura(CStr(result.Rows(0)("noFactura")))
                SetFechaFactura(CDate(result.Rows(0)("fechaFactura")))
                SetImporteFactura(CDbl(result.Rows(0)("importeFactura")))
                SetImplementacion(CStr(result.Rows(0)("implementacion")))
                SetColor(CStr(result.Rows(0)("color")))
                SetCombustible(CStr(result.Rows(0)("combustible")))
                SetPasajeros(CInt(result.Rows(0)("pasajeros")))
                SetIdTipo(CInt(result.Rows(0)("idTipo")))
                SetIdMarca(CInt(result.Rows(0)("idMarca")))
                SetIdContribuyente(CStr(result.Rows(0)("idContribuyente")))
                SetIdEmpleado(CStr(result.Rows(0)("idEmpleado")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function
End Class