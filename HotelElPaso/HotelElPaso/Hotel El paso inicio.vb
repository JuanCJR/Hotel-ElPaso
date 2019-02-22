Imports System.Windows.Forms

Public Class Hotel_El_paso_inicio

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub





    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Empleados.MdiParent = Me
        Empleados.Show()
    End Sub

    Private Sub AdministracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministracionToolStripMenuItem.Click

    End Sub

    Private Sub IniciarNuevaReservaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarNuevaReservaToolStripMenuItem.Click
        Reservas_del_hotel.MdiParent = Me
        Reservas_del_hotel.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Acerca_de.MdiParent = Me
        Acerca_de.Show()
    End Sub

    Private Sub RegistroDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeEmpleadosToolStripMenuItem.Click
        Registro_de_empleados.MdiParent = Me
        Registro_de_empleados.Show()
    End Sub

    Private Sub ReservacionesRealizadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservacionesRealizadasToolStripMenuItem.Click
        Reservaciones_reali.MdiParent = Me
        Reservaciones_reali.Show()
    End Sub

    Private Sub SobreMiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreMiToolStripMenuItem.Click
        Sobre_mi.MdiParent = Me
        Sobre_mi.Show()
    End Sub

    Private Sub Hotel_El_paso_inicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim x As MsgBoxResult
        x = MsgBox("¿Desea salir del programa?", 4 + 32)
        If x = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ToolTip_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip.Popup

    End Sub

    Private Sub ToolStripStatusLabel_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel.Click

    End Sub
End Class
