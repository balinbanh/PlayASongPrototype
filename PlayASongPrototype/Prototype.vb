Public Class MainForm
    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles LoginScreen.Load
        Dim showTimer As New Timer
        Dim counter As Integer = 0
        showTimer.Interval = 500
        showTimer.Enabled = True
        AddHandler showTimer.Tick, Sub()
                                       counter += 1
                                       If counter > 1 Then
                                           showTimer.Enabled = False
                                           LoginScreen.Visible = False
                                       End If
                                   End Sub

    End Sub



    Private Sub displayPanel_Load(sender As Object, e As EventArgs) Handles DisplayPanel1.Load
        Me.DisplayPanel1.setCategoryScreen()
    End Sub
End Class

