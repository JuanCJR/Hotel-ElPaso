Imports MySql.Data.MySqlClient
Public Class Reservaciones_reali

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Reservaciones_reali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim strsql As String = "Select cod_usu, nombre, apellido, CI, correo, tlf, direccion, tipohab from registros"
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
End Class