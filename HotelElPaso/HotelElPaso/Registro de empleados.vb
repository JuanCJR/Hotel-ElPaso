Imports MySql.Data.MySqlClient
Public Class Registro_de_empleados


    Private Sub Registro_de_empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("El campo ID no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            TextBox1.Select()
        Else
            Dim ID As Integer
            Dim nombre As String = ""
            Dim apellido As String = ""
            Dim ci As String = ""
            Dim correo As String = ""
            Dim tlf As String = ""
            Dim direccion As String = ""
            Dim cargo As String = ""
            Dim salario As Integer
            Dim sql As String = ""


            ID = TextBox1.Text
            nombre = TextBox2.Text
            apellido = TextBox3.Text
            ci = TextBox4.Text
            correo = TextBox5.Text
            tlf = TextBox6.Text
            direccion = TextBox7.Text
            cargo = TextBox8.Text
            salario = TextBox9.Text

            'Indicar tipo de entrada del comando sql
            cmd.CommandType = CommandType.Text

            'enlazar el comando con la conexion a la base de datos
            cmd.Connection = conexion

            'Definimos la consulta sql para insertar
            sql = "INSERT INTO EMPLEADOS VALUES (" & ID & ",'" & nombre & "','" & apellido & "','" & ci & "','" & correo
            sql = sql & "','" & tlf & "','" & direccion & "','" & cargo & "'," & salario & ")"
            MsgBox(sql)

            cmd.CommandText = sql

            Try
                'Se utuliza el executenonquery para las inserciones

                cmd.ExecuteNonQuery()
                MsgBox("Registro insertado correctamente")
            Catch ex As Exception
                'mandar mensaje en caso de que hayan ID duplicados
                If ex.ToString.Contains("Duplicate entry") Then
                    MsgBox("El registro ya existe")
                Else
                    MsgBox(ex.ToString)


                End If
            End Try

        End If


    End Sub
End Class