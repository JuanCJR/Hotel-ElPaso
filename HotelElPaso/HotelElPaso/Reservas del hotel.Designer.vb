﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservas_del_hotel
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Reservas = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Realizar una reservacion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(157, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Eliminar una reservacion"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(302, 391)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Editar una reservacion"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(447, 391)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Actualizar reservaciones"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cantidad de reservaciones actuales:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(499, 183)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Reservas
        '
        Me.Reservas.FormattingEnabled = True
        Me.Reservas.Location = New System.Drawing.Point(22, 22)
        Me.Reservas.Name = "Reservas"
        Me.Reservas.Size = New System.Drawing.Size(274, 355)
        Me.Reservas.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cantidad de reservaciones disponibles:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(499, 236)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 8
        '
        'Reservas_del_hotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 426)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Reservas)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Reservas_del_hotel"
        Me.Text = "Reservas_del_hotel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Reservas As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
