Public Class OpcionesConexion
    Private Sub OpcionesConexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDataSource.Text = My.Settings.db_datasource
        txtUsername.Text = My.Settings.db_username
        txtPassword.Text = My.Settings.db_password
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        My.Settings.db_datasource = txtDataSource.Text
        My.Settings.db_username = txtUsername.Text
        My.Settings.db_password = txtPassword.Text
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class