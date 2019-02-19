Imports MySql.Data.MySqlClient
Public Class Empleados

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'me conecto a la base de datos'
        Conectar()

        ' Llamo al sub llenaGrid'
        llenaGrid()







    End Sub

    'Creo sub para llenar datagridview
    Private Sub llenaGrid()
        'Creamos Data Set'
        Dim ds As New DataSet
        'Creamos Data Table'
        Dim dt As New DataTable

        'Creamos consulta SQL'
        Dim strSQL As String = "Select * from empleados"

        'Creamos adaptador mysql que necesita la consulta sql y la conexion a la base de datos'
        Dim adp As New MySqlDataAdapter(strSQL, conexion)

        'Creamos una tabla de nombre "Tabla"
        ds.Tables.Add("Tabla")

        'el data adapter  llena  la tabla de nombre "Tabla" con la informacion que tiene el adaptador'
        adp.Fill(ds.Tables("Tabla"))

        'Decirle al datagrid que tome los valores de la consulta sql'

        Me.DataGridView1.DataSource = ds.Tables("Tabla")
        ' Me.DataGridView1.Columns(0).HeaderText = "Codigo de Usuario"


    End Sub

    'Private Sub Buscar(ByRef codigo As Integer)
    '    'Creamos Data Set'
    '    Dim ds As New DataSet
    '    'Creamos Data Table'
    '    Dim dt As New DataTable

    '    'Creamos consulta SQL'
    '    Dim strSQL As String = "Select * from empleados where cod_usu=" & codigo

    '    'Creamos adaptador mysql que necesita la consulta sql y la conexion a la base de datos'
    '    Dim adp As New MySqlDataAdapter(strSQL, conexion)

    '    'Creamos una tabla de nombre "Tabla"
    '    ds.Tables.Add("Tabla")

    '    'el data adapter  llena  la tabla de nombre "Tabla" con la informacion que tiene el adaptador'
    '    adp.Fill(ds.Tables("Tabla"))

    '    'Decirle al datagrid que tome los valores de la consulta sql'

    '    Me.DataGridView1.DataSource = ds.Tables("Tabla")
    '    Me.DataGridView1.Columns(0).HeaderText = " Codigo de Usuario"

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            llenaGrid()

        Else

            'llamamos a la funcion'
            Me.DataGridView1.DataSource = ConsultaBuscar("Empleados", "cod_usu", TextBox1.Text).Tables("Tabla")

            Try

                Me.DataGridView1.Rows(1).ToString()

            Catch ex As Exception
                If ex.ToString.Contains("fuera del intervalo") Then
                    MsgBox("El registro no existe")
                    llenaGrid()

                Else
                    MsgBox(ex.ToString)


                End If
            End Try

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EditarEmpleados.MdiParent = Hotel_El_paso_inicio
        EditarEmpleados.Show()
    End Sub
End Class