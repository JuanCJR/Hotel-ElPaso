Imports MySql.Data.MySqlClient

Public Class Borrar_empleado

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Conectar()
        Try
            Dim dr As MySqlDataReader = reader("Empleados", "cod_usu", TextBox1.Text)

            TextBox1.Text = dr(0).ToString
            TextBox2.Text = dr(1).ToString
            TextBox3.Text = dr(2).ToString
            TextBox4.Text = dr(3).ToString
            TextBox5.Text = dr(4).ToString
            TextBox6.Text = dr(5).ToString
            TextBox7.Text = dr(6).ToString
            TextBox8.Text = dr(7).ToString
            TextBox9.Text = dr(8).ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("El id no esta registrado")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String

        sql = "DELETE FROM EMPLEADOS WHERE COD_USU ='" & TextBox1.Text & "'"

        MsgBox(sql)


        Try
            'Se utuliza el executenonquery para la actualizacion
            consultaEditar("Empleados", sql).ExecuteNonQuery()

            MsgBox("Registro borrado correctamente")
        Catch ex As Exception
            'mandar mensaje en caso de que hayan ID duplicados
            If ex.ToString.Contains("Duplicate entry") Then
                MsgBox("El registro no existe")
            Else
                MsgBox(ex.ToString)


            End If
        End Try

    End Sub


    Private Sub Borrar_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
        TextBox1.Text = 1
        Me.DataGridView1.DataSource = ConsultaSelect("Empleados").Tables("Tabla")

        Dim dr As MySqlDataReader = reader("Empleados", "cod_usu", TextBox1.Text)

        TextBox1.Text = dr(0).ToString
        TextBox2.Text = dr(1).ToString
        TextBox3.Text = dr(2).ToString
        TextBox4.Text = dr(3).ToString
        TextBox5.Text = dr(4).ToString
        TextBox6.Text = dr(5).ToString
        TextBox7.Text = dr(6).ToString
        TextBox8.Text = dr(7).ToString
        TextBox9.Text = dr(8).ToString
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        MsgBox(Me.DataGridView1.Columns(0).ToString())
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub
End Class