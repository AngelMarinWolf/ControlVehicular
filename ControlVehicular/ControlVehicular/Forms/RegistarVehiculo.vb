
Public Class RegistarVehiculo
    Private Sub RegistarVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub importedefactura_KeyExpress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles importedefactura.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Pasajeros_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Pasajeros.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


End Class