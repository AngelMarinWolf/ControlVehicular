Public Class Login
    Dim user As Empleado

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user = New Empleado()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub ButtonConfirm_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim result As Boolean
        result = user.BuscarEmpleadoByUsername(Me.txtUser.Text)
        If result Then
            If user.GetPassword = Me.txtPassword.Text Then
                Dim form As MultasYContribuyentes
                form = New MultasYContribuyentes(Me.user)
                form.Show()
                Me.Close()
            Else
                MsgBox("Usuario y/o Contraseña invalidos" + vbNewLine + "Intentelo de nuevo", MsgBoxStyle.Critical, "Error")
                Me.txtUser.Text = ""
                Me.txtPassword.Text = ""
            End If
        Else
            MsgBox("Usuario y/o Contraseña invalidos" + vbNewLine + "Intentelo de nuevo", MsgBoxStyle.Critical, "Error")
            Me.txtUser.Text = ""
            Me.txtPassword.Text = ""
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim result As Boolean
            result = user.BuscarEmpleadoByUsername(Me.txtUser.Text)
            If result Then
                If user.GetPassword = Me.txtPassword.Text Then
                    Dim form As MultasYContribuyentes
                    form = New MultasYContribuyentes(Me.user)
                    form.Show()
                    Me.Close()
                Else
                    MsgBox("Usuario y/o Contraseña invalidos" + vbNewLine + "Intentelo de nuevo", MsgBoxStyle.Critical, "Error")
                    Me.txtUser.Text = ""
                    Me.txtPassword.Text = ""
                End If
            Else
                MsgBox("Usuario y/o Contraseña invalidos" + vbNewLine + "Intentelo de nuevo", MsgBoxStyle.Critical, "Error")
                Me.txtUser.Text = ""
                Me.txtPassword.Text = ""
            End If
        End If
    End Sub

    Private Sub LinkOptions_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkOptions.LinkClicked
        OpcionesConexion.Show()
    End Sub
End Class
