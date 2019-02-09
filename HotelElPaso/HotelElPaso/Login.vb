Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles iniciar.Click
        Dim usuario As String
        Dim clave As Integer
        Dim tipo_usu As String
        usuario = TextBox1.Text
        clave = TextBox2.Text
        tipo_usu = ComboBox1.Text
        'Consulta Sql para el inicio de sesion'
        Dim consulta As String = "select * from usuarios where nombre='" & usuario & "' and clave =" & clave & " and tipo_usu ='" & tipo_usu & "';"

        'llama procedmiento que Realiza conexion a mysql' 
        Conectar()

        'Procedimientos para ejecutar consulta'
        Dim sqlcmd As New MySqlCommand(consulta, conexion)
        Dim dr As MySqlDataReader
        dr = sqlcmd.ExecuteReader

        'Validador de ejecucion de la consulta'
        If dr.Read() = True Then
            If tipo_usu = "EMPLEADO" Then
                Hotel_El_paso_inicio.Show()
                Hotel_El_paso_inicio.AdministracionToolStripMenuItem.Available = False
                Me.Hide()
                MsgBox("Bienvenido usuario")
                conexion.Close()

            ElseIf tipo_usu = "ADMIN" Then
                Hotel_El_paso_inicio.Show()
                MsgBox("Bienvenido administrador")
                Me.Hide()
                conexion.Close()
            End If

        Else
            MsgBox("Los datos ingresados son incorrectos, intente nuevamente")

            conexion.Close()

        End If
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
