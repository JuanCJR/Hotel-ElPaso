Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles iniciar.Click

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ingresar.Click
        Dim consulta As String = "select nombre, clave from usuarios where nombre='" & TextBox1.Text & "' and clave = '" & TextBox2.Text & "'"
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim x As MsgBoxResult
        x = MsgBox("¿Desea salir del programa?", 4 + 32)
        If x = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
