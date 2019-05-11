Public Class Licencia
    Private Const Tabla As String = "Licencias"

    Private idLicencia As Integer
    Private idContribuyente As String
    Private tipoLicencia As String
    Private fechaExpedicion As Date
    Private fechaExpiracion As Date
    Private donadorOrganos As Boolean
    Private contactoEmergencia As String
    Private telefonoEmergencia As String

    Public Sub New()

    End Sub

    Public Sub New(idLicencia As Integer,
                   idContribuyente As String,
                   tipoLicencia As String,
                   fechaExpedicion As Date,
                   fechaExpiracion As Date,
                   donadorOrganos As Boolean,
                   contactoEmergencia As String,
                   telefonoEmergencia As String)
        Me.idLicencia = idLicencia
        Me.idContribuyente = idContribuyente
        Me.tipoLicencia = tipoLicencia
        Me.fechaExpedicion = fechaExpedicion
        Me.fechaExpiracion = fechaExpiracion
        Me.donadorOrganos = donadorOrganos
        Me.contactoEmergencia = contactoEmergencia
        Me.telefonoEmergencia = telefonoEmergencia
    End Sub

    Public Sub SetIdLicencia(idLicencia As Integer)
        Me.idLicencia = idLicencia
    End Sub

    Public Sub SetIdContribuyente(idContribuyente As String)
        Me.idContribuyente = idContribuyente
    End Sub

    Public Sub SetTipo(tipoLicencia As String)
        Me.tipoLicencia = tipoLicencia
    End Sub

    Public Sub SetFechaExpedicion(fechaExpedicion As Date)
        Me.fechaExpedicion = fechaExpedicion
    End Sub

    Public Sub SetFechaExpiracion(fechaExpiracion As Date)
        Me.fechaExpiracion = fechaExpiracion
    End Sub

    Public Sub SetDonadorOrganos(donadorOrganos As Boolean)
        Me.donadorOrganos = donadorOrganos
    End Sub

    Public Sub SetContactoEmergencia(contacoEmergencia As String)
        Me.contactoEmergencia = contactoEmergencia
    End Sub

    Public Sub SetTelefonoEmergencia(telefonoEmergencia As String)
        If telefonoEmergencia.Length < 13 Then
            Me.telefonoEmergencia = telefonoEmergencia
        Else
            Throw New Exception("Error: Numero de telefono demaciado extenso.")
        End If
    End Sub

    Public Function GetIdLicencia() As Integer
        Return Me.idLicencia
    End Function

    Public Function GetIdContribuyente() As String
        Return Me.idContribuyente
    End Function

    Public Function GetTipo() As String
        Return Me.tipoLicencia
    End Function

    Public Function GetFechaExpedicion() As Date
        Return Me.fechaExpedicion
    End Function

    Public Function GetFechaExpiracion() As Date
        Return Me.fechaExpiracion
    End Function

    Public Function GetEstadoDonador() As Boolean
        Return Me.donadorOrganos
    End Function

    Public Function GetContactoEmergencia() As String
        Return Me.contactoEmergencia
    End Function

    Public Function GetTelefonoEmergencia() As String
        Return Me.telefonoEmergencia
    End Function

    Public Function RegistrarLicencia() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idLicencia", "idContribuyente", "tipoLicencia", "fechaExpedicion", "fechaExpiracion", "donadorOrganos", "contactoEmergencia", "telefonoEmergencia"}
        Dim valores As String() = {Me.idLicencia, Me.idContribuyente, Me.tipoLicencia, Me.fechaExpedicion, Me.fechaExpiracion, If(Me.donadorOrganos, "S", "N"), Me.contactoEmergencia, Me.telefonoEmergencia}
        Dim result = database.Insertar(Tabla, columnas, valores)
        Return result
    End Function

    Public Function ActualizarLicencia() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idContribuyente", "tipoLicencia", "fechaExpedicion", "fechaExpiracion", "donadorOrganos", "contactoEmergencia", "telefonoEmergencia"}
        Dim valores As String() = {Me.idContribuyente, Me.tipoLicencia, Me.fechaExpedicion, Me.fechaExpiracion, If(Me.donadorOrganos, "S", "N"), Me.contactoEmergencia, Me.telefonoEmergencia}
        Dim condiciones As String() = {"idLicencia=" & Me.idLicencia}
        Dim result = database.Actualizar(Tabla, columnas, valores, condiciones)
        Return result
    End Function

    Public Function EliminarLicencia() As Boolean
        Dim database As Oracle = New Oracle()
        Dim condiciones As String() = {"idLicencia=" & Me.idLicencia}
        Dim result = database.Eliminar(Tabla, condiciones)
        Return result
    End Function

    Public Function BuscarLicenciaById(idLicencia As Integer) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"idLicencia", "idContribuyente", "tipoLicencia", "fechaExpedicion", "fechaExpiracion", "donadorOrganos", "contactoEmergencia", "telefonoEmergencia"}
        Dim condiciones As String() = {"idLicencia=" & idLicencia}
        Dim result As DataTable

        result = database.Buscar(Tabla, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("idLicencia")) And
               Not IsDBNull(result.Rows(0)("idContribuyente")) And
               Not IsDBNull(result.Rows(0)("tipoLicencia")) And
               Not IsDBNull(result.Rows(0)("fechaExpedicion")) And
               Not IsDBNull(result.Rows(0)("fechaExpiracion")) And
               Not IsDBNull(result.Rows(0)("donadorOrganos")) And
               Not IsDBNull(result.Rows(0)("contactoEmergencia")) And
               Not IsDBNull(result.Rows(0)("telefonoEmergencia")) Then
                SetIdLicencia(CInt(result.Rows(0)("idLicencia")))
                SetIdContribuyente(CStr(result.Rows(0)("idContribuyente")))
                SetTipo(CStr(result.Rows(0)("tipoLicencia")))
                SetFechaExpedicion(CDate(result.Rows(0)("fechaExpedicion")))
                SetFechaExpiracion(CDate(result.Rows(0)("fechaExpiracion")))
                SetDonadorOrganos(If(CChar(result.Rows(0)("donadorOrganos")) = "S", True, False))
                SetContactoEmergencia(CStr(result.Rows(0)("contactoEmergencia")))
                SetTelefonoEmergencia(CStr(result.Rows(0)("telefonoEmergencia")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function
End Class