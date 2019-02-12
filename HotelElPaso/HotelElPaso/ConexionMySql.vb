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

End Module
