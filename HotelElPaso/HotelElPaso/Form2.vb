Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim consulta As String = "select cod_usu AS Codigo_Usuario, Nombre, Clave, tipo_usu as Tipo_Usuario from usuarios"

        DataGridView1.DataSource = SQLSEL(consulta)














    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class