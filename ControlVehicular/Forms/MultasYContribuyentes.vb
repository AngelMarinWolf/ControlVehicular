Public Class MultasYContribuyentes
    Private Sub MultasYContribuyentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.DropDownOpened
        Console.WriteLine("Open")
        MenuToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub MenuToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.DropDownClosed
        Console.WriteLine("Close")
        MenuToolStripMenuItem.ForeColor = Color.White
    End Sub
End Class