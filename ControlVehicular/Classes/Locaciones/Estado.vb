Public Class Estado
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
End Class
