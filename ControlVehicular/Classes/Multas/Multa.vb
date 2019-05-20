Public Class Multa
    Private Const Tabla As String = "Multas"

    Private idMulta As Integer
    Private idPlacas As String
    Private fechaExpedicionMulta As Date
    Private fechaLiquidacionMulta As Date
    Private importe As Double
    Private descripcion As String

    Public Sub New()

    End Sub

    Public Sub New(idMulta As Integer,
                   idPlacas As String,
                   fechaExpedicionMulta As Date,
                   fechaLiquidacionMulta As Date,
                   importe As Double,
                   descripcion As String)
        Me.idMulta = idMulta
        Me.idPlacas = idPlacas
        Me.fechaExpedicionMulta = fechaExpedicionMulta
        Me.fechaLiquidacionMulta = fechaLiquidacionMulta
        Me.importe = importe
        Me.descripcion = descripcion
    End Sub

    Public Sub SetIdMulta(idMulta As Integer)
        Me.idMulta = idMulta
    End Sub

    Public Sub SetIdPlacas(idPlacas As String)
        Me.idPlacas = idPlacas
    End Sub

    Public Sub SetFechaExpedicion(fechaExpedicion As Date)
        Me.fechaExpedicionMulta = fechaExpedicion
    End Sub

    Public Sub SetFechaLiquidacion(fechaLiquidacion As Date)
        Me.fechaLiquidacionMulta = fechaLiquidacionMulta
    End Sub

    Public Sub SetImporte(importe As Double)
        Me.importe = importe
    End Sub

    Public Sub SetDescripcion(descripcion As String)
        Me.descripcion = descripcion
    End Sub

    Public Function GetIdMulta() As Integer
        Return Me.idMulta
    End Function

    Public Function GetIdPlacas() As String
        Return Me.idPlacas
    End Function

    Public Function GetFechaExpedicion() As Date
        Return Me.fechaExpedicionMulta
    End Function

    Public Function GetFechaLiquidacion() As Date
        Return Me.fechaLiquidacionMulta
    End Function

    Public Function GetImporte() As Double
        Return Me.importe
    End Function

    Public Function GetDescripcion() As String
        Return Me.descripcion
    End Function

    Public Function RegistrarMulta() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idMulta", "idPlacas", "fechaExpedicionMulta", "importe", "descripcion"}
        Dim valores As String() = {Me.idMulta, "'" & Me.idPlacas & "'", "TO_DATE('" & Me.fechaExpedicionMulta.ToString("yyyy/MM/dd HH:mm:ss") & "', 'yyyy/mm/dd hh24:mi:ss')",
                                   Me.importe, "'" & Me.descripcion & "'"}
        Dim result = database.Insertar(Tabla, columnas, valores)
        Return result
    End Function

    Public Function ActualizarMulta() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idPlacas", "fechaExpedicionMulta", "importe", "descripcion"}
        Dim valores As String() = {"'" & Me.idPlacas & "'", "TO_DATE('" & Me.fechaExpedicionMulta.ToString("yyyy/MM/dd HH:mm:ss") & "', 'yyyy/mm/dd hh24:mi:ss')",
                                   Me.importe, "'" & Me.descripcion & "'"}
        Dim condiciones As String() = {"idMulta=" & Me.idMulta}
        Dim result = database.Actualizar(Tabla, columnas, valores, condiciones)
        Return result
    End Function

    Public Function EliminarMulta() As Boolean
        Dim database As Oracle = New Oracle()
        Dim condiciones As String() = {"idMulta=" & Me.idMulta}
        Dim result = database.Eliminar(Tabla, condiciones)
        Return result
    End Function

    Public Function BuscarMultaById(idMulta As Integer) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idMulta", "idPlacas", "fechaExpedicionMulta", "fechaLiquidacionMulta", "importe", "descripcion"}
        Dim condiciones As String() = {"idMulta=" & idMulta}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idMulta")) And
               Not IsDBNull(result.Rows(0)("idPlacas")) And
               Not IsDBNull(result.Rows(0)("fechaExpedicionMulta")) And
               Not IsDBNull(result.Rows(0)("importe")) Then
                SetIdMulta(CInt(result.Rows(0)("idMulta")))
                SetIdPlacas(CStr(result.Rows(0)("idPlacas")))
                SetFechaExpedicion(CDate(result.Rows(0)("fechaExpedicionMulta")))
                SetFechaLiquidacion(If(Not IsDBNull(result.Rows(0)("fechaLiquidacionMulta")), CDate(result.Rows(0)("fechaLiquidacionMulta")), Nothing))
                SetImporte(CDbl(result.Rows(0)("importe")))
                SetDescripcion(CStr(result.Rows(0)("descripcion")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function

    Public Function BuscarMultas() As DataTable
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idMulta", "idPlacas", "fechaExpedicionMulta", "fechaLiquidacionMulta", "importe", "descripcion"}

        Return database.Buscar({Tabla}, columnas, {})
    End Function

    Public Function BuscarMultasByConditions(columnasExtra As String(), joins As String(), condiciones As String()) As DataTable
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {Tabla & ".idMulta", Tabla & ".idPlacas", Tabla & ".fechaExpedicionMulta", Tabla & ".fechaLiquidacionMulta",
                                    Tabla & ".importe", Tabla & ".descripcion"}

        Return database.Buscar({Tabla}, columnasExtra.Union(columnas).ToArray, joins, condiciones)
    End Function

    Public Function BuscarUltimoId() As Integer
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"Max(idMulta) AS idMulta"}

        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, {})
        If result.Rows.Count = 1 Then
            Return CInt(result.Rows(0)("idMulta"))
        Else
            Return 0
        End If
    End Function
End Class