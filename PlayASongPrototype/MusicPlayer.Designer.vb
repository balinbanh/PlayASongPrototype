<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MusicPlayer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Movie = New System.Windows.Forms.PictureBox()
        Me.NextSongPic = New System.Windows.Forms.PictureBox()
        Me.PreviousSongPic = New System.Windows.Forms.PictureBox()
        Me.PlayPauseButton = New System.Windows.Forms.PictureBox()
        CType(Me.Movie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextSongPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviousSongPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayPauseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Movie
        '
        Me.Movie.Location = New System.Drawing.Point(82, 52)
        Me.Movie.Name = "Movie"
        Me.Movie.Size = New System.Drawing.Size(809, 370)
        Me.Movie.TabIndex = 0
        Me.Movie.TabStop = False
        '
        'NextSongPic
        '
        Me.NextSongPic.Location = New System.Drawing.Point(735, 526)
        Me.NextSongPic.Name = "NextSongPic"
        Me.NextSongPic.Size = New System.Drawing.Size(100, 50)
        Me.NextSongPic.TabIndex = 1
        Me.NextSongPic.TabStop = False
        '
        'PreviousSongPic
        '
        Me.PreviousSongPic.Location = New System.Drawing.Point(98, 526)
        Me.PreviousSongPic.Name = "PreviousSongPic"
        Me.PreviousSongPic.Size = New System.Drawing.Size(100, 50)
        Me.PreviousSongPic.TabIndex = 2
        Me.PreviousSongPic.TabStop = False
        '
        'PlayPauseButton
        '
        Me.PlayPauseButton.Image = Global.PlayASongPrototype.My.Resources.mediaImages.pausebutton
        Me.PlayPauseButton.InitialImage = Global.PlayASongPrototype.My.Resources.mediaImages.pausebutton
        Me.PlayPauseButton.Location = New System.Drawing.Point(335, 428)
        Me.PlayPauseButton.Name = "PlayPauseButton"
        Me.PlayPauseButton.Size = New System.Drawing.Size(260, 246)
        Me.PlayPauseButton.TabIndex = 3
        Me.PlayPauseButton.TabStop = False
        '
        'MusicPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PlayPauseButton)
        Me.Controls.Add(Me.PreviousSongPic)
        Me.Controls.Add(Me.NextSongPic)
        Me.Controls.Add(Me.Movie)
        Me.Name = "MusicPlayer"
        Me.Size = New System.Drawing.Size(1024, 768)
        CType(Me.Movie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextSongPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviousSongPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayPauseButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Movie As PictureBox
    Friend WithEvents NextSongPic As PictureBox
    Friend WithEvents PreviousSongPic As PictureBox
    Friend WithEvents PlayPauseButton As PictureBox
End Class
