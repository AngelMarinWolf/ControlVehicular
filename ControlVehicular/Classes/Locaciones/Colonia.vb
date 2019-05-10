Public Class Colonia
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

End Class
