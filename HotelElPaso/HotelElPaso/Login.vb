Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles iniciar.Click
        Dim usuario As String
        Dim clave As String
        Dim tipo_usu As String
        usuario = TextBox1.Text
        clave = TextBox2.Text
        tipo_usu = ComboBox1.Text
       

        'Validador de ejecucion de la consulta'
        If usuario = "" Or clave = "" Then
            MsgBox("Por favor ingrese los datos faltantes")
        ElseIf tipo_usu = "" Then
            MsgBox("Seleccione un tipo de trabajador")
        Else
            'Consulta Sql para el inicio de sesion'
            Dim consulta As String = "select * from usuarios where nombre='" & usuario & "' and clave =" & clave & " and tipo_usu ='" & tipo_usu & "';"

            'llama procedmiento que Realiza conexion a mysql' 
            Conectar()

            'Procedimientos para ejecutar consulta'
            Dim sqlcmd As New MySqlCommand(consulta, conexion)
            Dim dr As MySqlDataReader
            dr = sqlcmd.ExecuteReader

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
                MsgBox("Datos incorrectos intente nuevamente")

                conexion.Close()
            End If

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

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            MsgBox("ingrese un dato numerico")
        End If
    End Sub
End Class
