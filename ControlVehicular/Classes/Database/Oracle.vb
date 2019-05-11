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
    End Sub

    Private Sub AbrirConexion()
        If cnx.State <> ConnectionState.Open Then
            Try
                cnx.Open() 'Abrir la base de datos en caso de que la conexión sea exitosa
            Catch ex As Exception
                Throw New Exception("No se puedo conectar a la Base de Datos, contacte al D.B.A.", ex)
            End Try
        End If
    End Sub

    Private Sub CerrarConexion()
        If cnx.State <> ConnectionState.Closed Then
            Try
                cnx.Close()
            Catch ex As Exception
                Throw New Exception("Error: " & ex.Message)
            End Try
        End If
    End Sub

    ' Metodo de insercion que retorna un valor booleano cuando la insercion se realizo de forma correcta.
    Public Function Insertar(tabla As String, columnas As String(), valores As String()) As Boolean
        AbrirConexion()
        If columnas.Length <> valores.Length Then
            CerrarConexion()
            Throw New Exception("Error: Columnas y Valores no corresponden.")
        End If
        Dim queryStr = "INSERT INTO " & tabla & " (" & String.Join(",", columnas) & ") " &
                       "VALUES " & "(" & String.Join(",", valores) & ")"
        Dim sqlcmd As New OracleCommand(queryStr, cnx)

        Dim rows As Integer

        Try
            rows = sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
            CerrarConexion()
        End Try

        If rows > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Metodo de eliminacion que retorna un valor booleano cuando el registro fue eliminado correctamente.
    Public Function Eliminar(tabla As String, condiciones As String()) As Boolean
        AbrirConexion()
        Dim queryStr As String = "DELETE FROM " & tabla & " WHERE " & String.Join(",", condiciones)
        Dim sqlcmd As New OracleCommand(queryStr, cnx)

        Dim rows As Integer

        Try
            rows = sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            CerrarConexion()
        End Try

        If rows > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Metodo que permite actualizar una tabla y retorna un valor booleano en caso de que la ejecucion sea correcta
    Public Function Actualizar(tabla As String, columnas As String(), valores As String(), condiciones As String()) As Boolean
        AbrirConexion()
        Dim valuesStr(columnas.Length) As String
        If columnas.Length <> valores.Length Then
            CerrarConexion()
            Throw New Exception("Error: Columnas y Valores no corresponden.")
        Else
            For index = 0 To columnas.Length - 1
                valuesStr(index) = columnas(index) & "=" & valores(index)
            Next
        End If

        Dim queryStr As String = "UPDATE " & tabla & " SET " & String.Join(",", valuesStr) & " WHERE " & String.Join(",", condiciones)
        Dim sqlcmd As New OracleCommand(queryStr, cnx)

        Dim rows As Integer

        Try
            rows = sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            CerrarConexion()
        End Try

        If rows > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Metodo que ejecuta una consulta sobre la base de datos y retorna los valore dentro de un objeto DataTable
    Public Function Buscar(tabla As String, columnas As String(), condiciones As String()) As DataTable
        AbrirConexion()
        Dim dataAdapter As OracleDataAdapter
        Dim dataTable As DataTable

        Dim queryStr As String = "SELECT " & String.Join(",", columnas) & " FROM " & tabla
        If condiciones.Length > 0 Then
            queryStr += " WHERE " & String.Join(",", condiciones)
        End If

        Try
            dataAdapter = New OracleDataAdapter(queryStr, cnx)
            dataTable = New DataTable
            dataAdapter.Fill(dataTable)
            dataAdapter.Dispose()
            CerrarConexion()
            Return dataTable 'retorna el conjunto de dato
        Catch ex As Exception
            CerrarConexion()
            Throw New Exception("Error: " & ex.Message)
            'Finally
        Finally
            CerrarConexion()
        End Try
    End Function

    '
    Public Function ObjetoDataAdapter(ByVal sqlcmd As String) As DataTable
        AbrirConexion()
        Dim dataAdapter As OracleDataAdapter
        Dim dataTable As DataTable

        Try
            dataAdapter = New OracleDataAdapter(sqlcmd, cnx)
            dataTable = New DataTable
            dataAdapter.Fill(dataTable)
            dataAdapter.Dispose()
            CerrarConexion()
            Return dataTable 'retorna el conjunto de dato
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Function

    'Método que ejecuta un comando insert, update o delete a base de datos
    Public Sub ObjetoCommand(ByVal strcmd As String)
        AbrirConexion()
        Dim sqlcmd As New OracleCommand(strcmd, cnx)

        Try
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub

    'Método para efectuar lecturas y generar recordset de datos
    Function objetoDataReader(ByVal strcmd As String) As OracleDataReader
        AbrirConexion()
        Dim sqlcmd As New OracleCommand(strcmd, cnx)
        Dim resultadoSQL As OracleDataReader = sqlcmd.ExecuteReader()
        Try
            Return resultadoSQL
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Function

    'Método que ejecuta una función de grupo a la base de datos
    Public Function objetoScalar(ByVal strcmd As String) As Object
        AbrirConexion()
        Dim sqlcmd As New OracleCommand(strcmd, cnx)
        Try
            objetoScalar = sqlcmd.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Function
End Class