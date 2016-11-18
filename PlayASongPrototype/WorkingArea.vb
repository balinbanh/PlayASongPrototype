Public Class WorkingArea
    Public Shared songNames() As String = {"babablacksheep", "littleMonkeys", "happy", "maryLittleLamb", "wheels"} 'full list of songs
    Public Shared songs As New Dictionary(Of String, String) 'songs, corresponding name of song image
    Public Shared playlistnames As New List(Of String) 'names of playlists
    Public Shared playlistsongs As New List(Of List(Of String)) 'list of song lists'


    Private Sub createPlaylist(ByVal playlistName As String, ByVal playlistImage As String)
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
        songs.Add("babablacksheep", "blacksheep")
        songs.Add("littleMonkeys", "monkeys")
        songs.Add("happy", "happy")
        songs.Add("maryLittleLamb", "littlelamb")
        songs.Add("wheels", "bus")
        playlistnames.Add("Favourites")
    End Sub
End Class