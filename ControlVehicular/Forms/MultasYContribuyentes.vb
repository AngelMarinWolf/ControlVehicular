Public Class MultasYContribuyentes
    Private user As Empleado
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
        BuscarContribuyentes({""})
    End Sub

    Private Sub MenuToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.DropDownOpened
        MenuToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub MenuToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.DropDownClosed
        MenuToolStripMenuItem.ForeColor = Color.White
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Me.lblFechaData.Text = Date.Today.ToShortDateString
        Me.lblHoraData.Text = Date.Now.Hour & ":" & Date.Now.Minute
    End Sub

    Private Sub BuscarContribuyentes(condiciones As String())
        Dim database As Oracle = New Oracle()
        Dim columnas As String() = {"curp", "rfc", "nombre", "paterno", "materno", "edad", "sexo", "telefono", "email", "idDomicilio"}

        Me.contribuyentes = database.Buscar({"Contribuyentes"}, columnas, condiciones)
        Me.DataContribuyentes.DataSource = Me.contribuyentes

        For index = 0 To Me.contribuyentes.Columns.Count - 1
            Me.DataContribuyentes.Columns(index).Width = CInt(Me.DataContribuyentes.Width / Me.contribuyentes.Columns.Count)
        Next
    End Sub
End Class