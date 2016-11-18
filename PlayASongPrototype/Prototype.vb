Public Class MainForm
    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles LoginScreen.Load
        Dim showTimer As New Timer
        Dim counter As Integer = 0
        showTimer.Interval = 1000
        showTimer.Enabled = True
        AddHandler showTimer.Tick, Sub()
                                       counter += 1
                                       If counter > 3 Then
                                           showTimer.Enabled = False
                                           LoginScreen.Visible = False
                                       End If
                                   End Sub

    End Sub
End Class
