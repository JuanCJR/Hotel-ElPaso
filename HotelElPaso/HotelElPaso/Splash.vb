Public Class Splash

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)

        If ProgressBar1.Value = 100 Then
            Login.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub
End Class