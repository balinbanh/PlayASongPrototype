Public Class WorkingArea
    Dim songNames() As String = {"babablacksheep", "littleMonkeys", "happy", "maryLittleLamb", "wheels"} 'full list of songs
    Dim songs As New Dictionary(Of String, String) 'songs, corresponding name of song image
    Dim playlistnames As New List(Of String) 'names of playlists
    Dim playlistsongs As New List(Of List(Of String)) 'list of song lists'


    Private Sub createPlaylist(ByVal playlistName As String)
        If playlistnames.Contains(playlistName) Then
            playlistnames.Add(playlistName)
        End If

    End Sub

    Private Sub removePlaylist(ByVal playlistname As String)
        If playlistnames.Contains(playlistname) Then
            playlistnames.Remove(playlistname)
        End If
    End Sub

    Private Sub addSong(ByVal playlistName As String, ByVal songName As String)
        If playlistnames.Contains(playlistName) And songNames.Contains(songName) Then
            playlistsongs(playlistnames.BinarySearch(playlistName)).Add(songName)
        End If
    End Sub

    Private Sub removeSong(ByVal playlistName As String, ByVal songName As String)
        If playlistnames.Contains(playlistName) And songNames.Contains(songName) Then
            playlistsongs(playlistnames.BinarySearch(playlistName)).Remove(songName)
        End If
    End Sub

    Private Sub WorkingArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        songs.Add("babablcksheep", "")
        songs.Add("littleMonkeys", "")
        songs.Add("happy", "")
        songs.Add("maryLittleLamb", "")
        songs.Add("wheels", "")
    End Sub
End Class