Public Class WorkingArea
    Dim songNames() As String = {"babablacksheep", "littleMonkeys", "happy", "maryLittleLamb", "wheels"}
    Dim songs As New Dictionary(Of String, String)
    Dim playlistnames() As String
    Dim playlistsongs(,) As String


    Private Sub WorkingArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        songs.Add("babablcksheep", "")
        songs.Add("littleMonkeys", "")
        songs.Add("happy", "")
        songs.Add("maryLittleLamb", "")
        songs.Add("wheels", "")
    End Sub
End Class