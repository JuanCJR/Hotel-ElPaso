Imports MySql.Data.MySqlClient
Public Class Editar_reservacion

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Conectar()
        Try
            Dim dr As MySqlDataReader = reader("registros", "cod_usu", TextBox1.Text)


            TextBox1.Text = dr(0).ToString
            TextBox2.Text = dr(1).ToString
            TextBox3.Text = dr(2).ToString
            TextBox4.Text = dr(3).ToString
            TextBox5.Text = dr(4).ToString
            TextBox6.Text = dr(5).ToString
            TextBox7.Text = dr(6).ToString
            TextBox8.Text = dr(7).ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("El id no esta registrado")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        MsgBox(Me.DataGridView1.Columns(0).ToString())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql1 As String

        sql1 = "UPDATE REGISTROS  SET NOMBRE ='" & TextBox2.Text & "',APELLIDO ='" & TextBox3.Text & "',"
        sql1 = sql1 + "CI='" & TextBox4.Text & "' ,CORREO ='" & TextBox5.Text & "',tlf ='" & TextBox6.Text & "', DIRECCION = '" & TextBox7.Text & "',"
        sql1 = sql1 + "TIPOHAB ='" & TextBox8.Text & "' WHERE COD_USU = '" & TextBox1.Text & " ')"

        MsgBox(sql1)


        Try
            'Se utuliza el executenonquery para la actualizacion
            consultaEditar("registros", sql1).ExecuteNonQuery()

            MsgBox("Registro insertado correctamente")
        Catch ex As Exception
            'mandar mensaje en caso de que hayan ID duplicados
            If ex.ToString.Contains("Duplicate entry") Then
                MsgBox("El registro ya existe")
            Else
                MsgBox(ex.ToString)


            End If
        End Try

    End Sub

    Private Sub Editar_reservacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
        TextBox1.Text = 1
        Me.DataGridView1.DataSource = ConsultaSelect("registros").Tables("Tabla")

        Dim dr As MySqlDataReader = reader("registros", "cod_usu", TextBox1.Text)

        TextBox1.Text = dr(0).ToString
        TextBox2.Text = dr(1).ToString
        TextBox3.Text = dr(2).ToString
        TextBox4.Text = dr(3).ToString
        TextBox5.Text = dr(4).ToString
        TextBox6.Text = dr(5).ToString
        TextBox7.Text = dr(6).ToString
        TextBox8.Text = dr(7).ToString
    End Sub
End Class