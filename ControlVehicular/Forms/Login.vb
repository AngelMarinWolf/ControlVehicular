Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonConfirm_Click(sender As Object, e As EventArgs) Handles ButtonConfirm.Click
        MultasYContribuyentes.Show()
        Me.Close()
    End Sub
End Class
