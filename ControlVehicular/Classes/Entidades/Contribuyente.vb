Public Class Contribuyente
    Private Const Tabla As String = "Contribuyentes"

    Private curp As String
    Private rfc As String
    Private nombre As String
    Private paterno As String
    Private materno As String
    Private edad As Integer
    Private sexo As Char
    Private telefono As String
    Private email As String
    Private idDomicilio As Integer

    Public Sub New()

    End Sub

    Public Sub New(curp As String,
                   rfc As String,
                   nombre As String,
                   paterno As String,
                   materno As String,
                   edad As Integer,
                   sexo As Char,
                   telefono As String,
                   email As String,
                   idDomicilio As Integer)
        Me.curp = curp
        Me.rfc = rfc
        Me.nombre = nombre
        Me.paterno = paterno
        Me.materno = materno
        Me.edad = edad
        Me.sexo = sexo
        Me.telefono = telefono
        Me.email = email
        Me.idDomicilio = idDomicilio
    End Sub

    Public Sub SetCurp(curp As String)
        If curp.Length = 18 Then
            Me.curp = curp
        Else
            Throw New Exception("Error: La curp no contiene la cantidad de caracteres especifica.")
        End If
    End Sub

    Public Sub SetRfc(rfc As String)
        If rfc.Length = 12 Or rfc.Length = 13 Then
            Me.rfc = rfc
        Else
            Throw New Exception("Error: El rfc no contiene la cantidad de caracteres especifica.")
        End If
    End Sub

    Public Sub SetNombre(nombre As String)
        Me.nombre = nombre
    End Sub

    Public Sub SetPaterno(paterno As String)
        Me.paterno = paterno
    End Sub

    Public Sub SetMaterno(materno As String)
        Me.materno = materno
    End Sub

    Public Sub SetEdad(edad As Integer)
        Me.edad = edad
    End Sub

    Public Sub SetSexo(sexo As Char)
        Me.sexo = sexo
    End Sub

    Public Sub SetTelefono(telefono As String)
        If telefono.Length < 13 Then
            Me.telefono = telefono
        Else
            Throw New Exception("Error: Numero de telefono demaciado extenso.")
        End If
    End Sub

    Public Sub SetEmail(email As String)
        Me.email = email
    End Sub

    Public Sub SetIdDomicilio(idDomicilio As Integer)
        Me.idDomicilio = idDomicilio
    End Sub

    Public Function GetCurp() As String
        Return Me.curp
    End Function

    Public Function GetRfc() As String
        Return Me.rfc
    End Function

    Public Function GetNombre() As String
        Return Me.nombre
    End Function

    Public Function GetPaterno() As String
        Return Me.paterno
    End Function

    Public Function GetMaterno() As String
        Return Me.materno
    End Function

    Public Function GetEdad() As Integer
        Return Me.edad
    End Function

    Public Function GetSexo() As Char
        Return Me.sexo
    End Function

    Public Function GetTelefono() As String
        Return Me.telefono
    End Function

    Public Function GetEmail() As String
        Return Me.email
    End Function

    Public Function GetIdDomicilio() As Integer
        Return Me.idDomicilio
    End Function

    Public Function RegistrarContribuyente() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"curp", "rfc", "nombre", "paterno", "materno", "edad", "sexo", "telefono", "email", "idDomicilio"}
        Dim valores As String() = {"'" & Me.curp & "'", "'" & Me.rfc & "'", "'" & Me.nombre & "'", "'" & Me.paterno & "'", "'" & Me.materno & "'",
                                  Me.edad, "'" & Me.sexo & "'", "'" & Me.telefono & "'", "'" & Me.email & "'", "'" & Me.idDomicilio & "'"}
        Dim result = database.Insertar(Tabla, columnas, valores)
        Return result
    End Function

    Public Function ActualizarContribuyente() As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"rfc", "nombre", "paterno", "materno", "edad", "sexo", "telefono", "email", "idDomicilio"}
        Dim valores As String() = {"'" & Me.rfc & "'", "'" & Me.nombre & "'", "'" & Me.paterno & "'", "'" & Me.materno & "'",
                                  Me.edad, "'" & Me.sexo & "'", "'" & Me.telefono & "'", "'" & Me.email & "'", "'" & Me.idDomicilio & "'"}
        Dim condiciones As String() = {"curp='" & Me.curp & "'"}
        Dim result = database.Actualizar(Tabla, columnas, valores, condiciones)
        Return result
    End Function

    Public Function EliminarContribuyente() As Boolean
        Dim database As Oracle = New Oracle()
        Dim condiciones As String() = {"curp='" & Me.curp & "'"}
        Dim result = database.Eliminar(Tabla, condiciones)
        Return result
    End Function

    Public Function BuscarContribuyenteByNombre(nombre As String) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"curp", "rfc", "nombre", "paterno", "materno", "edad", "sexo", "telefono", "email", "idDomicilio"}
        Dim condiciones As String() = {"nombre='" & nombre & "'"}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("curp")) And
               Not IsDBNull(result.Rows(0)("rfc")) And
               Not IsDBNull(result.Rows(0)("nombre")) And
               Not IsDBNull(result.Rows(0)("paterno")) And
               Not IsDBNull(result.Rows(0)("materno")) And
               Not IsDBNull(result.Rows(0)("idDomicilio")) Then
                SetCurp(CStr(result.Rows(0)("curp")))
                SetRfc(CStr(result.Rows(0)("rfc")))
                SetNombre(CStr(result.Rows(0)("nombre")))
                SetPaterno(CStr(result.Rows(0)("paterno")))
                SetMaterno(CStr(result.Rows(0)("materno")))
                SetEdad(If(Not IsDBNull(result.Rows(0)("edad")), CInt(result.Rows(0)("edad")), 0))
                SetSexo(If(Not IsDBNull(result.Rows(0)("sexo")), CChar(result.Rows(0)("sexo")), ""))
                SetTelefono(If(Not IsDBNull(result.Rows(0)("telefono")), CStr(result.Rows(0)("telefono")), ""))
                SetEmail(If(Not IsDBNull(result.Rows(0)("email")), CStr(result.Rows(0)("email")), ""))
                SetIdDomicilio(CInt(result.Rows(0)("idDomicilio")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function

    Public Function BuscarContribuyenteByApellido(paterno As String) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"curp", "rfc", "nombre", "paterno", "materno", "edad", "sexo", "telefono", "email", "idDomicilio"}
        Dim condiciones As String() = {"paterno='" & paterno & "'"}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("curp")) And
               Not IsDBNull(result.Rows(0)("rfc")) And
               Not IsDBNull(result.Rows(0)("nombre")) And
               Not IsDBNull(result.Rows(0)("paterno")) And
               Not IsDBNull(result.Rows(0)("materno")) And
               Not IsDBNull(result.Rows(0)("idDomicilio")) Then
                SetCurp(CStr(result.Rows(0)("curp")))
                SetRfc(CStr(result.Rows(0)("rfc")))
                SetNombre(CStr(result.Rows(0)("nombre")))
                SetPaterno(CStr(result.Rows(0)("paterno")))
                SetMaterno(CStr(result.Rows(0)("materno")))
                SetEdad(If(Not IsDBNull(result.Rows(0)("edad")), CInt(result.Rows(0)("edad")), 0))
                SetSexo(If(Not IsDBNull(result.Rows(0)("sexo")), CChar(result.Rows(0)("sexo")), ""))
                SetTelefono(If(Not IsDBNull(result.Rows(0)("telefono")), CInt(result.Rows(0)("telefono")), ""))
                SetEmail(If(Not IsDBNull(result.Rows(0)("email")), CStr(result.Rows(0)("email")), ""))
                SetIdDomicilio(CInt(result.Rows(0)("idDomicilio")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function

    Public Function BuscarContribuyenteById(curp As String) As Boolean
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"curp", "rfc", "nombre", "paterno", "materno", "edad", "sexo", "telefono", "email", "idDomicilio"}
        Dim condiciones As String() = {"curp='" & curp & "'"}
        Dim result As DataTable

        result = database.Buscar({Tabla}, columnas, condiciones)

        If result.Rows.Count = 1 Then
            If Not IsDBNull(result.Rows(0)("curp")) And
               Not IsDBNull(result.Rows(0)("rfc")) And
               Not IsDBNull(result.Rows(0)("nombre")) And
               Not IsDBNull(result.Rows(0)("paterno")) And
               Not IsDBNull(result.Rows(0)("materno")) And
               Not IsDBNull(result.Rows(0)("idDomicilio")) Then
                SetCurp(CStr(result.Rows(0)("curp")))
                SetRfc(CStr(result.Rows(0)("rfc")))
                SetNombre(CStr(result.Rows(0)("nombre")))
                SetPaterno(CStr(result.Rows(0)("paterno")))
                SetMaterno(CStr(result.Rows(0)("materno")))
                SetEdad(If(Not IsDBNull(result.Rows(0)("edad")), CInt(result.Rows(0)("edad")), 0))
                SetSexo(If(Not IsDBNull(result.Rows(0)("sexo")), CChar(result.Rows(0)("sexo")), ""))
                SetTelefono(If(Not IsDBNull(result.Rows(0)("telefono")), CStr(result.Rows(0)("telefono")), ""))
                SetEmail(If(Not IsDBNull(result.Rows(0)("email")), CStr(result.Rows(0)("email")), ""))
                SetIdDomicilio(CInt(result.Rows(0)("idDomicilio")))
                Return True
            Else
                Throw New Exception("Error: Columna con valores vacios.")
            End If
        Else
            Return False
        End If
    End Function

    Public Function BuscarContribuyentes() As DataTable
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"curp", "rfc", "nombre", "paterno", "materno", "edad", "sexo", "telefono", "email", "idDomicilio"}

        Return database.Buscar({Tabla}, columnas, {})
    End Function

    Public Function BuscarContribuyentesByConditions(joins As String(), condiciones As String()) As DataTable
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {Tabla & ".curp", Tabla & ".rfc", Tabla & ".nombre", Tabla & ".paterno", Tabla & ".materno", Tabla & ".edad",
                                    Tabla & ".sexo", Tabla & ".telefono", Tabla & ".email", Tabla & ".idDomicilio"}

        Return database.Buscar({Tabla}, columnas, joins, condiciones)
    End Function
End Class