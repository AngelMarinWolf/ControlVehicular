Public Class Pais
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

    End Function

    Public Function ActualizarPais() As Boolean

    End Function

    Public Function EliminarPais() As Boolean

    End Function

    Public Sub BuscarPais(nombre As String)

    End Sub
End Class
