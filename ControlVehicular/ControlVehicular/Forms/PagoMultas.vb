Public Class PagoMultas
    Private Sub importe_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles importe.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub idPlacas_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idPlacas.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

    End Sub
End Class