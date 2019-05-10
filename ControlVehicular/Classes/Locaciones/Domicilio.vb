Public Class Domicilio
    Private idColonia As Integer
    Private idDomicilio As Integer
    Private calle As String
    Private numero As String

    Public Sub New()

    End Sub

    Public Sub New(idColonia As Integer, idDomicilio As Integer, calle As String)
        Me.idColonia = idColonia
        Me.idDomicilio = idDomicilio
        Me.calle = calle
    End Sub

    Public Function GetIdColonia() As Integer
        Return Me.idColonia
    End Function

    Public Function GetIdDomicilio() As Integer
        Return Me.idDomicilio
    End Function

    Public Function GetCalleEstado() As String
        Return Me.calle
    End Function

    Public Function GetNumeroEstado() As String
        Return Me.numero
    End Function

    Public Sub SetIdColonia(idColonia As Integer)
        Me.idColonia = idColonia
    End Sub

    Public Sub SetIdDomicilio(idDomicilio As Integer)
        Me.idDomicilio = idDomicilio
    End Sub

    Public Sub SetCalleEstado(calle As String)
        Me.calle = calle
    End Sub

    Public Sub SetNumeroEstado(numero As String)
        Me.numero = numero
    End Sub
End Class