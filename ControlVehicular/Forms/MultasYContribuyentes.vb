Public Class MultasYContribuyentes
    Private user As Empleado
    Private contribuyente As Contribuyente = New Contribuyente()
    Private contribuyentes As DataTable

    Public Sub New(user As Empleado)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.user = user
    End Sub

    Private Sub MultasYContribuyentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblUserData.Text = user.GetNombre & " " & user.GetPaterno
        Me.lblFechaData.Text = Date.Today.ToShortDateString
        Me.lblHoraData.Text = Date.Now.Hour & ":" & Date.Now.Minute
        Me.DataContribuyentes.DataSource = Me.contribuyente.BuscarContribuyentes()

        Dim noColumnas = Me.contribuyente.BuscarContribuyentes.Columns.Count
        For index = 0 To noColumnas - 1
            Me.DataContribuyentes.Columns(index).Width = CInt(Me.DataContribuyentes.Width / noColumnas)
        Next
    End Sub

    Private Sub MenuToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.DropDownOpened
        MenuToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub MenuToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.DropDownClosed
        MenuToolStripMenuItem.ForeColor = Color.White
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Me.lblFechaData.Text = Date.Now.ToShortDateString
        Me.lblHoraData.Text = Date.Now.ToShortTimeString
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        RegistrarEmpleados.Show()
    End Sub

    Private Sub LocalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalidadesToolStripMenuItem.Click
        RegistrarLocaciones.Show()
    End Sub
End Class