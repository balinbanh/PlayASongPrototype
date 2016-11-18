Public Class MusicPlayer

    Dim pause As Boolean

    'All these need to be global or passed to this


    Dim songNames As New List(Of String)
    Dim songImages As New List(Of String)
    Dim playlistNames As New List(Of String)
    Dim playlistImages As New List(Of String)
    Dim playlists As New Dictionary(Of String, List(Of String))

    Private selectedCategory As String
    Private currentPosition As Integer


    Private Sub MusicPlayer_Load(sender As Object, e As EventArgs) Handles Me.Load

        If currentPosition = Not 0 Then
            PreviousSongPic.Image = My.Resources.musicImages.ResourceManager.GetObject(playlistImages(currentPosition - 1))
        End If

        If currentPosition = Not songNames.Capacity Then
            PreviousSongPic.Image = My.Resources.musicImages.ResourceManager.GetObject(playlistImages(currentPosition + 1))
        End If







    End Sub


    Private Sub PlayPauseButton_Click(sender As Object, e As EventArgs) Handles PlayPauseButton.Click

        If pause Then

            PlayPauseButton.Image = My.Resources.mediaImages.playbutton


        Else

            PlayPauseButton.Image = My.Resources.mediaImages.pausebutton

        End If





    End Sub


End Class
