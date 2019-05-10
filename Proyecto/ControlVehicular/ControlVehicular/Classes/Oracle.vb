Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public Class Oracle
    'En esta clase definimos el método constructor en el cual se establece 
    'la conexión a la base de datos Oracle XE.
    'Variable de instancia del tipo conexion Oracle
    Private cnx As OracleConnection

    'Variables para la creacion de la cadena de conexion
    Private db_datasource As String = "Data Source="
    Private db_username As String = "User Id="
    Private db_password As String = "Password="

    'Metodo para establecer la conexión a la BD
    Public Sub New()
        ' Inicializar variables de conexion
        db_datasource = db_datasource & My.Settings.db_datasource & ";"
        db_username = db_username & My.Settings.db_username & ";"
        db_password = db_password & My.Settings.db_password & ";"

        ' Con esta cadena preparamos la conexión a Oracle con el Usuario  y contraseña dueño de las tablas 
        cnx = New OracleConnection(db_datasource & db_username & db_password)

        If cnx.State <> ConnectionState.Open Then
            Try
                cnx.Open() 'Abrir la base de datos en caso de que la conexión sea exitosa
            Catch ex As Exception
                Throw New Exception("No se puedo conectar a la Base de Datos, contacte al D.B.A.", ex)
            End Try
        End If
    End Sub



    'METODOS PARA ACCESO A DATOS
    'Método para efectuar consultas a base de datos recibiendo el string del DML
    Public Function objetoDataAdapter(ByVal sqlcmd As String) As DataTable

        Dim DA As OracleDataAdapter
        'Dim DA As OleDbConnection
        Dim DT As DataTable
        Try
            DA = New OracleDataAdapter(sqlcmd, cnx)
            'DA = New OleDbConnection(sqlcmd, cnx)

            DT = New DataTable
            DA.Fill(DT)
            Return DT 'retorna el conjunto de dato
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
            'Finally
        End Try
        DT.Dispose()

    End Function

    'Método que ejecuta un comando insert, update o delete a base de datos
    Public Sub objetoCommand(ByVal strcmd As String)
        Dim sqlcmd As New OracleCommand(strcmd, cnx)

        Try
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
        End Try
    End Sub

    'Método para efectuar lecturas y generar recordset de datos
    Function objetoDataReader(ByVal strcmd As String) As OracleDataReader
        Dim sqlcmd As New OracleCommand(strcmd, cnx)
        Dim resultadoSQL As OracleDataReader = sqlcmd.ExecuteReader()
        Try
            Return resultadoSQL
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
        End Try
    End Function

    'Método que ejecuta una función de grupo a la base de datos
    Public Function objetoScalar(ByVal strcmd As String) As Object
        Dim sqlcmd As New OracleCommand(strcmd, cnx)
        Try
            objetoScalar = sqlcmd.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
        End Try
    End Function
End Class