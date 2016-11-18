Public Class songScreen
    Dim position = 0
    Dim songlist As New List(Of String)
    Private Sub init()

        Dim playlistnum = 0
        For i As Integer = 0 To LoginScreen.playlistnames.Count()
            If LoginScreen.playlistnames(i) = "Animals" Then
                playlistnum = i
                Exit For
            End If
        Next

        songlist = LoginScreen.playlistsongs(playlistnum)
        Dim temp = LoginScreen.songs(songlist(position))
        'topLeftPictureBox.Image = My.Resources.ResourceManager.GetObject(temp)
        topLeftLabel.Text = temp
        topRightPictureBox.Image = My.Resources.ResourceManager.GetObject(LoginScreen.songs(songlist(position + 1)))
        botLeftPictureBox.Image = My.Resources.ResourceManager.GetObject(LoginScreen.songs(songlist(position + 2)))
        botRightPictureBox.Image = My.Resources.ResourceManager.GetObject(LoginScreen.songs(songlist(position + 3)))
    End Sub

    Private Sub songScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.init()
    End Sub
End Class
