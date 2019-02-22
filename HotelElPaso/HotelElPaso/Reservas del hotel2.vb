Public Class Reservas_del_hotel2
    Private Property Sql As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("El campo ID no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            TextBox1.Select()
        ElseIf TextBox2.Text = "" Then
            MsgBox("El campo nombre no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            TextBox2.Select()
        ElseIf TextBox3.Text = "" Then
            MsgBox("El campo apellido no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            TextBox3.Select()
        ElseIf TextBox4.Text = "" Then
            MsgBox("El campo CI no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            TextBox4.Select()
        ElseIf TextBox5.Text = "" Then
            MsgBox("El campo correo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            TextBox5.Select()
        ElseIf TextBox6.Text = "" Then
            MsgBox("El campo tlf no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            TextBox6.Select()
        ElseIf TextBox7.Text = "" Then
            MsgBox("El campo direccion no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            TextBox7.Select()
        ElseIf TextBox8.Text = "" Then
            MsgBox("El campo tipo de habitacion no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
        Else
            Dim id As Integer
            Dim nombre As String = ""
            Dim apellido As String = ""
            Dim ci As String = ""
            Dim correo As String = ""
            Dim tlf As String = ""
            Dim direccion As String = ""
            Dim tipohab As String = ""
            Dim sql As String = ""

            id = TextBox1.Text
            nombre = TextBox2.Text
            apellido = TextBox3.Text
            ci = TextBox4.Text
            correo = TextBox5.Text
            tlf = TextBox6.Text
            direccion = TextBox7.Text
            tipohab = TextBox8.Text

            'indicar el tipo de entrada del comando sql'
            cmd.CommandType = CommandType.Text

            'enlazar el comando con la conexion a la base de datos'
            cmd.Connection = conexion

            'definimos la consulta sql para insertar'
            sql = "INSERT INTO registros VALUES (" & id & ",'" & nombre & "','" & apellido & "','" & ci & "','" & correo
            sql = sql & "','" & tlf & "','" & direccion & "','" & tipohab & "')"

            cmd.CommandText = sql
            Try
                'Se utiliza el executenonquery para las inserciones'
                cmd.ExecuteNonQuery()
                MsgBox("Registro insertado correctamente")
            Catch ex As Exception
                'mandar mensaje en caso de que hayan id duplicados'
                If ex.ToString.Contains("Duplicate entry") Then
                    MsgBox("El registro ya existe")
                Else
                    MsgBox(ex.ToString)
                End If

            End Try
        End If
    End Sub

    Private Sub Reservas_del_hotel2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
    End Sub
End Class