Imports MySql.Data.MySqlClient
Module ConexionMySql


    'Creacion de objecto MysqlConneciont para manejar conexion a mysql'
    Public conexion As New MySqlConnection
    'Creacion deobjeto MySqlCommand para ejecutar comandos sql
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



    Public Function Consultar(ByRef SQLC As String) As MySqlDataReader


        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text



        cmd.CommandText = SQLC



        Try
            dr2 = cmd.ExecuteReader
            'dr2.Read()

            'If dr2.HasRows Then
            'While dr2.Read()
            'MsgBox(dr2(0).ToString + " " + dr2(1).ToString + " " + dr2(3).ToString)
            '
            'End While
            'Else
            'MsgBox("No Existen registros para la consulta")

            'End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return dr2
    End Function



    Public Function ConsultaBuscar(ByRef Tabla As String, ByRef nom_c As String, ByRef Codigo As Integer) As DataSet
        Conectar()
        'Creamos Data Set'
        Dim ds As New DataSet

        'Creamos Data Table'
        Dim dt As New DataTable

        'Creamos consulta SQL'
        Dim strSQL As String = "Select * from " & Tabla & " where " & nom_c & "=" & Codigo

        'Creamos adaptador mysql que necesita la consulta sql y la conexion a la base de datos'
        Dim adp As New MySqlDataAdapter(strSQL, conexion)

        'Creamos una tabla de nombre "Tabla"
        ds.Tables.Add("Tabla")

        'el data adapter  llena  la tabla de nombre "Tabla" con la informacion que tiene el adaptador'
        adp.Fill(ds.Tables("Tabla"))


        Return ds

    End Function

    Public Function ConsultaSelect(ByRef Tabla) As DataSet
        Conectar()
        'Creamos Data Set'
        Dim ds2 As New DataSet
        'Creamos Data Table'
        Dim dt2 As New DataTable

        'Creamos consulta SQL'
        Dim strSQL2 As String = "Select * from " & Tabla

        'Creamos adaptador mysql que necesita la consulta sql y la conexion a la base de datos'
        Dim adp As New MySqlDataAdapter(strSQL2, conexion)

        'Creamos una tabla de nombre "Tabla"
        ds2.Tables.Add("Tabla")

        'el data adapter  llena  la tabla de nombre "Tabla" con la informacion que tiene el adaptador'
        adp.Fill(ds2.Tables("Tabla"))

        Return ds2



    End Function


    'Funcion para editar datos en mysql que tiene como datos de entrada: 
    '
    'Nombre de la tabla(tabla) 
    'Nombre del campo a actualizar
    'Nuevo valor del campo a actualizar
    'Nombre del campo llave primaria de la tabla
    'Valor del campo llave primaria
    'Esta funcion retorna como MySqlCommand para utilizarse posteriormente
    Public Function consultaEditar(ByRef tabla As String, sql As String) As MySqlCommand
        Conectar()
        Dim Comando As New MySqlCommand

        'Indicar tipo de entrada del comando sql
        Comando.CommandType = CommandType.Text

        'enlazar el comando con la conexion a la base de datos
        Comando.Connection = conexion


        Comando.CommandText = sql


        Return Comando

    End Function

    Public Function reader(ByRef tabla As String, ByRef codigo As String, ByRef codigo_val As String) As MySqlDataReader
        Conectar()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text



        cmd.CommandText = "Select * from " & tabla & " where " & codigo & "=" & codigo_val


        Try
            dr2 = cmd.ExecuteReader
            dr2.Read()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return dr2

    End Function


End Module
