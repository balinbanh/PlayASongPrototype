Public Class displayPanel

    Dim songNames As New List(Of String)
    Dim songImages As New List(Of String)
    Dim playlistNames As New List(Of String)
    Dim playlistImages As New List(Of String)
    Dim playlists As New Dictionary(Of String, List(Of String))

    Private selectedCategory As String
    Private currentPosition As Integer = 0

    Private Sub displayPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        songNames.Add("babablacksheep")
        songNames.Add("happy")
        songNames.Add("littleMonkeys")
        songNames.Add("maryLittleLamb")
        songNames.Add("wheels")
        songImages.Add("babablacksheep")
        songImages.Add("happy")
        songImages.Add("littleMonkeys")
        songImages.Add("maryLittleLamb")
        songImages.Add("wheels")

        playlistNames.Add("Favourites")
        playlistNames.Add("Animals")
        playlistImages.Add("Favourite")
        playlistImages.Add("giraffe")

        Dim animalslist = New List(Of String) From {
            "babablacksheep", "maryLittleLamb"
        }
        playlists.Add("Animals", animalslist)
    End Sub

    Public Sub setCategoryScreen()
        Me.Label1.Text = "Categories"
        Me.topLeft.Image = My.Resources.playlistImages.allSongs
        Me.topRight.Image = My.Resources.playlistImages.favourite
        Me.bottomLeft.Image = My.Resources.playlistImages.giraffe
        Me.bottomRight.Image = My.Resources.playlistImages.addPlaylist

        Me.topLeftLabel.Text = "All Songs"
        Me.topRightLabel.Text = playlistNames(0)
        Me.bottomLeftLabel.Text = playlistNames(1)
        Me.bottomRightLabel.Text = "Add Playlist"
    End Sub

    Public Sub setSongSelect()
        Label1.Text = selectedCategory
        Dim currentPlaylist As List(Of String) = playlists.Item(selectedCategory)
        Dim currentloc As Integer = 0

        Try
            topLeft.Visible = True
            Me.topLeft.Image = My.Resources.musicImages.ResourceManager.GetObject(currentPlaylist(currentloc))
            topLeftLabel.Visible = True
            topLeftLabel.Text = currentPlaylist(currentloc)
        Catch ex As Exception
            topLeft.Visible = False
            topLeftLabel.Visible = False
        End Try
        Try
            topRight.Visible = True
            Me.topRight.Image = My.Resources.musicImages.ResourceManager.GetObject(currentPlaylist(currentloc + 1))
            topRightLabel.Text = currentPlaylist(currentloc + 1)
            topRightLabel.Visible = True
        Catch ex As Exception
            topRight.Visible = False
            topRightLabel.Visible = False
        End Try
        Try
            bottomLeft.Visible = True
            Me.bottomLeft.Image = My.Resources.musicImages.ResourceManager.GetObject(currentPlaylist(currentloc + 2))
            bottomLeftLabel.Text = currentPlaylist(currentloc + 1)
            bottomLeftLabel.Visible = True
        Catch ex As Exception
            bottomLeft.Visible = False
            bottomLeftLabel.Visible = False
        End Try
        Try
            bottomRight.Visible = True
            Me.bottomRight.Image = My.Resources.musicImages.ResourceManager.GetObject(currentPlaylist(currentloc + 3))
            bottomRightLabel.Text = currentPlaylist(currentloc + 1)
            bottomRightLabel.Visible = True
        Catch ex As Exception
            bottomRight.Visible = False
            bottomRightLabel.Visible = False
        End Try

        Me.Visible = True
    End Sub

    Private Sub topLeft_Click(sender As Object, e As EventArgs) Handles topLeft.Click
        Me.Visible = False
        selectedCategory = topLeftLabel.Text
        setSongSelect()
    End Sub

    Private Sub bottomLeft_Click(sender As Object, e As EventArgs) Handles bottomLeft.Click
        Me.Visible = False
        selectedCategory = bottomLeftLabel.Text
        setSongSelect()
    End Sub
End Class
