Imports MySql.Data.MySqlClient
Module ConexionMySql


    'Creacion de objecto MysqlConnection para manejar conexion a mysql'
    Public conexion As New MySqlConnection
    'Creacion de objeto MySqlCommand para ejecutar comandos sql'
    Public cmd As New MySqlCommand
    Public dr2 As MySqlDataReader

    Public Sub Conectar()

        'Trata de realizar conexion a base de datos'
        Try
            conexion.Close()
            conexion.ConnectionString = "server=localhost;user=root;password=;database=ejemplo; port=3306"

            conexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Function ConsultaBuscar(ByRef Tabla As String, ByRef nom_c As String, ByRef Codigo As Integer) As DataSet
        'creamos dataset'
        Dim ds As New DataSet

        'Creamos data table'
        Dim dt As New DataTable

        'creamos consulta sql'
        Dim strSQL As String = "Select * from " & Tabla & " where " & nom_c & "=" & Codigo

        'creamos adaptador mysql que necesita la consulta sql y la conexion a la base de datos' 
        Dim adp As New MySqlDataAdapter(strSQL, conexion)

        'creamos una tabla de nombre tabla'
        ds.Tables.Add("Tabla")

        'el data adapter llena la tabla de nombre "tabla" con la informacion que tiene el adaptador'
        adp.Fill(ds.Tables("Tabla"))

        Return ds
    End Function

    'funcion para editar datos en mysql que tiene como datos de entrada:'
    'nombre de la tabla(tabla)'
    'nombre del campo a actualizar'
    'nuevo valor del campo a actualizar'
    'nombre del campo llave primaria de la tabla'
    'valor del campo llave primaria'
    'esta funcion retorna como MySqlCommand para utilizarse posteriormente'

    Public Function consultaEditar(ByRef tabla As String, campo1 As String, ByRef newval As String, ByRef codigo As String, codval As String) As MySqlCommand
        Dim Comando As MySqlCommand
        Dim sql As String = ""

        'indicar tipo de entrada del comando sql'
        Comando.CommandType = CommandType.Text

        'enlazar el comando con la conexion a la base de datos'
        Comando.Connection = conexion

        'Definimos la consulta sql para actualizar o editar'
        sql = "UPDATE " & tabla & " SET " & campo1 & "=" & newval & " WHERE " & codigo & "=" & codval
        Comando.CommandText = sql
        Return Comando

    End Function

    Public Function reader(ByRef tabla As String) As MySqlDataReader
        Conectar()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "Select * from " & tabla
        Try
            dr2 = cmd.ExecuteReader
            dr2.read()

        Catch ex As Exception
            MsgBox(ex.ToString)


        End Try
        Return dr2
    End Function

    Public Function ConsultaSelect(ByRef tabla) As DataSet
        'creamos data set' 
        Dim ds2 As New DataSet
        'creamos data table'
        Dim dt2 As New DataTable

        'creamos consulta SQL'
        Dim strSQL2 As String = "Select * from " & tabla

        'Creamos adaptador mysql que necesita la consulta sql y la conexion a la base de datos' 
        Dim adp As New MySqlDataAdapter(strSQL2, conexion)

        'creamos una tabla de nombre "tabla"'
        ds2.Tables.Add("tabla")

        'el data adapter llena la tabla de nombre "tabla" con la informacion que tiene el adaptador'
        adp.Fill(ds2.Tables("tabla"))
        Return ds2

    End Function

End Module
