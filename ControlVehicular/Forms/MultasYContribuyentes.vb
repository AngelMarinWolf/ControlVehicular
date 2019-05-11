Public Class MultasYContribuyentes
    Private Sub MultasYContribuyentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.DropDownOpened
        MenuToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub MenuToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.DropDownClosed
        MenuToolStripMenuItem.ForeColor = Color.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class