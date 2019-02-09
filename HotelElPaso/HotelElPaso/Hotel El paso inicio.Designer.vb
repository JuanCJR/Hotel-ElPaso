<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hotel_El_paso_inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiCuentaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreMiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.InformacionToolStripMenuItem, Me.AdministracionToolStripMenuItem, Me.RealizarReservaToolStripMenuItem, Me.MiCuentaToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'InformacionToolStripMenuItem
        '
        Me.InformacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.InformacionToolStripMenuItem.Name = "InformacionToolStripMenuItem"
        Me.InformacionToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.InformacionToolStripMenuItem.Text = "Informacion"
        '
        'AdministracionToolStripMenuItem
        '
        Me.AdministracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem})
        Me.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        Me.AdministracionToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministracionToolStripMenuItem.Text = "Administracion"
        '
        'RealizarReservaToolStripMenuItem
        '
        Me.RealizarReservaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.RealizarReservaToolStripMenuItem.Name = "RealizarReservaToolStripMenuItem"
        Me.RealizarReservaToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.RealizarReservaToolStripMenuItem.Text = "Realizar reserva"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'MiCuentaToolStripMenuItem
        '
        Me.MiCuentaToolStripMenuItem.Name = "MiCuentaToolStripMenuItem"
        Me.MiCuentaToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.MiCuentaToolStripMenuItem.Text = "Mi cuenta"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'MiCuentaToolStripMenuItem1
        '
        Me.MiCuentaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreMiToolStripMenuItem})
        Me.MiCuentaToolStripMenuItem1.Name = "MiCuentaToolStripMenuItem1"
        Me.MiCuentaToolStripMenuItem1.Size = New System.Drawing.Size(72, 20)
        Me.MiCuentaToolStripMenuItem1.Text = "Mi cuenta"
        '
        'SobreMiToolStripMenuItem
        '
        Me.SobreMiToolStripMenuItem.Name = "SobreMiToolStripMenuItem"
        Me.SobreMiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SobreMiToolStripMenuItem.Text = "Sobre mi"
        '
        'Hotel_El_paso_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Hotel_El_paso_inicio"
        Me.Text = "Hotel_El_paso_inicio"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarReservaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiCuentaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreMiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
