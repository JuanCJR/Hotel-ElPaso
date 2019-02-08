Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Consulta Sql para el inicio de sesion'
        Dim consulta As String = "select nombre from usuarios"


        'llama procedmiento que Realiza conexion a mysql' 
        Conectar()

        'Procedimientos para ejecutar consulta'
        Dim sqlcmd As New MySqlCommand(consulta, conexion)
        Dim dr As MySqlDataReader
        dr = sqlcmd.ExecuteReader

        'Validador de ejecucion de la consulta'
        If dr.Read() = True Then

            Label1.Text = "Conexion establecida"
            conexion.Close()

        End If

    End Sub
End Class
