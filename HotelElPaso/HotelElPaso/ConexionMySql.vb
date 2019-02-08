Imports MySql.Data.MySqlClient
Module ConexionMySql


    'Creacion de objecto MysqlConneciont para manejar conexion a mysql'
    Public conexion As New MySqlConnection

    Public Sub Conectar()

        'Trata de realizar conexion a base de datos'
        Try
            conexion.Close()
            conexion.ConnectionString = "server=localhost;user=root;password=;database=ejemplo; port=3307"

            conexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

End Module
