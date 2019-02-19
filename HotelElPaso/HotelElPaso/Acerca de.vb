Public Class Acerca_de

    Private Sub Acerca_de_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "Hotel el paso"
        TextBox2.Text = "Version 1.0.0"
        TextBox3.Text = "Copyright © 2019"
        TextBox5.Text = "Programa de uso practico para la gestion de reservaciones de un hotel utilizando una base de datos de almacenamiento con el fin de facilitar la navegacion del usuario"
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class