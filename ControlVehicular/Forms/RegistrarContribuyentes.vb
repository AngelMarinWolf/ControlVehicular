Public Class RegistrarContribuyentes
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Pais.Click

    End Sub

    Private Sub Contribuyentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Estado_Click(sender As Object, e As EventArgs) Handles Estado.Click

    End Sub

    Private Sub edad_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles edad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Colonia1.SelectedIndexChanged

    End Sub
End Class