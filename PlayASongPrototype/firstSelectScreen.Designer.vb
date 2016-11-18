<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class firstSelectScreen
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
        Me.Categories = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AllSongsLabel = New System.Windows.Forms.Label()
        Me.FavouritesLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlaylistLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Categories
        '
        Me.Categories.AutoSize = True
        Me.Categories.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Categories.ForeColor = System.Drawing.Color.DarkRed
        Me.Categories.Location = New System.Drawing.Point(330, 25)
        Me.Categories.Name = "Categories"
        Me.Categories.Size = New System.Drawing.Size(364, 90)
        Me.Categories.TabIndex = 0
        Me.Categories.Text = "Categories"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.PlayASongPrototype.My.Resources.playlistImages.addPlaylist
        Me.PictureBox4.Location = New System.Drawing.Point(644, 470)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(167, 158)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PlayASongPrototype.My.Resources.playlistImages.giraffe
        Me.PictureBox3.Location = New System.Drawing.Point(214, 470)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(167, 158)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PlayASongPrototype.My.Resources.playlistImages.favourite
        Me.PictureBox2.Location = New System.Drawing.Point(644, 175)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(167, 158)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PlayASongPrototype.My.Resources.playlistImages.allSongs
        Me.PictureBox1.Location = New System.Drawing.Point(214, 175)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'AllSongsLabel
        '
        Me.AllSongsLabel.AutoSize = True
        Me.AllSongsLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllSongsLabel.Location = New System.Drawing.Point(206, 342)
        Me.AllSongsLabel.Name = "AllSongsLabel"
        Me.AllSongsLabel.Size = New System.Drawing.Size(181, 44)
        Me.AllSongsLabel.TabIndex = 5
        Me.AllSongsLabel.Text = "All Songs"
        '
        'FavouritesLabel
        '
        Me.FavouritesLabel.AutoSize = True
        Me.FavouritesLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FavouritesLabel.Location = New System.Drawing.Point(636, 342)
        Me.FavouritesLabel.Name = "FavouritesLabel"
        Me.FavouritesLabel.Size = New System.Drawing.Size(202, 44)
        Me.FavouritesLabel.TabIndex = 6
        Me.FavouritesLabel.Text = "Favourites"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 631)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 44)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Animals"
        '
        'PlaylistLabel
        '
        Me.PlaylistLabel.AutoSize = True
        Me.PlaylistLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaylistLabel.Location = New System.Drawing.Point(619, 631)
        Me.PlaylistLabel.Name = "PlaylistLabel"
        Me.PlaylistLabel.Size = New System.Drawing.Size(222, 44)
        Me.PlaylistLabel.TabIndex = 8
        Me.PlaylistLabel.Text = "Add Playlist"
        '
        'firstSelectScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PlaylistLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FavouritesLabel)
        Me.Controls.Add(Me.AllSongsLabel)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Categories)
        Me.Name = "firstSelectScreen"
        Me.Size = New System.Drawing.Size(1024, 768)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Categories As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents AllSongsLabel As Label
    Friend WithEvents FavouritesLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PlaylistLabel As Label
End Class
