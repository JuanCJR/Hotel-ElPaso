Imports MySql.Data.MySqlClient

Public Class Registro_de_empleados

    Private Sub Registro_de_empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'me conecto a la base de datos'
        Conectar()
        'llamo al sub llenagrid'
        llenagrid()
    End Sub
    'creo el sub para llenar datagridview1'
    Private Sub llenagrid()
        'creamos dataset'
        Dim ds As New DataSet
        'creamos datatable'
        Dim dt As New DataTable
        'creamos consulta sql'
        Dim strsql As String = "Select cod_usu, nombre, apellido, CI, correo, tlf, direccion, cargo, salario_bsf from empleados"
        'creamos un adaptador mysql que necesita la consulta sql y la conexion a la base de datos'
        Dim adp As New MySqlDataAdapter(strsql, conexion)
        'creamos una tabla de nombre tabla'
        ds.Tables.Add("tabla")
        'el data llena la tabla de nombre "tabla" con la informacion que tiene el adaptador'
        adp.Fill(ds.Tables("tabla"))
        'decirle al datagrid que tome los valores de la consulta sql'
        Me.DataGridView1.DataSource = ds.Tables("tabla")
        Me.DataGridView1.Columns(0).HeaderText = " Codigo de Usuario"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Registro_de_empleados2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            llenagrid()
        Else
            'llamamos a la funcion'
            Me.DataGridView1.DataSource = ConsultaBuscar("Empleados", "cod_usu", TextBox1.Text).Tables("Tabla")
            Try
                Me.DataGridView1.Rows(1).ToString()
            Catch ex As Exception
                ex.ToString.Contains("fuera del intervalo")
                MsgBox("El registro que intenta buscar no existe")

                MsgBox(ex.ToString)


            End Try
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Editar_empleado.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Borrar_empleado.Show()
    End Sub
End Class