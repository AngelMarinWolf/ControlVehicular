Public Class Ciudad
    Private idEstado As Integer
    Private idCiudad As Integer
    Private nombre As String

    Public Sub New()

    End Sub

    Public Sub New(idEstado As Integer, idCiudad As Integer, nombre As String)
        Me.idEstado = idEstado
        Me.idCiudad = idCiudad
        Me.nombre = nombre
    End Sub

    Public Function GetIdEstado() As Integer
        Return Me.idEstado
    End Function

    Public Function GetIdCiudad() As Integer
        Return Me.idCiudad
    End Function

    Public Function GetNombreEstado() As String
        Return Me.nombre
    End Function

    Public Sub SetIdEstado(idEstado As Integer)
        Me.idEstado = idEstado
    End Sub

    Public Sub SetIdCiudad(idCiudad As Integer)
        Me.idCiudad = idCiudad
    End Sub

    Public Sub SetNombreEstado(nombre As String)
        Me.nombre = nombre
    End Sub

End Class
