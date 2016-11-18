<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class songScreen
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
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.topLeftPictureBox = New System.Windows.Forms.PictureBox()
        Me.topRightPictureBox = New System.Windows.Forms.PictureBox()
        Me.botLeftPictureBox = New System.Windows.Forms.PictureBox()
        Me.botRightPictureBox = New System.Windows.Forms.PictureBox()
        Me.topLeftLabel = New System.Windows.Forms.Label()
        Me.topRightLabel = New System.Windows.Forms.Label()
        Me.botRightLabel = New System.Windows.Forms.Label()
        Me.botLeftLabel = New System.Windows.Forms.Label()
        CType(Me.topLeftPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.topRightPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.botLeftPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.botRightPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryLabel
        '
        Me.CategoryLabel.AutoSize = True
        Me.CategoryLabel.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryLabel.Location = New System.Drawing.Point(399, 72)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(226, 90)
        Me.CategoryLabel.TabIndex = 0
        Me.CategoryLabel.Text = "Label1"
        '
        'topLeftPictureBox
        '
        Me.topLeftPictureBox.Location = New System.Drawing.Point(212, 219)
        Me.topLeftPictureBox.Name = "topLeftPictureBox"
        Me.topLeftPictureBox.Size = New System.Drawing.Size(193, 163)
        Me.topLeftPictureBox.TabIndex = 1
        Me.topLeftPictureBox.TabStop = False
        '
        'topRightPictureBox
        '
        Me.topRightPictureBox.Location = New System.Drawing.Point(620, 219)
        Me.topRightPictureBox.Name = "topRightPictureBox"
        Me.topRightPictureBox.Size = New System.Drawing.Size(193, 163)
        Me.topRightPictureBox.TabIndex = 2
        Me.topRightPictureBox.TabStop = False
        '
        'botLeftPictureBox
        '
        Me.botLeftPictureBox.Location = New System.Drawing.Point(212, 523)
        Me.botLeftPictureBox.Name = "botLeftPictureBox"
        Me.botLeftPictureBox.Size = New System.Drawing.Size(193, 163)
        Me.botLeftPictureBox.TabIndex = 3
        Me.botLeftPictureBox.TabStop = False
        '
        'botRightPictureBox
        '
        Me.botRightPictureBox.Location = New System.Drawing.Point(620, 523)
        Me.botRightPictureBox.Name = "botRightPictureBox"
        Me.botRightPictureBox.Size = New System.Drawing.Size(193, 163)
        Me.botRightPictureBox.TabIndex = 4
        Me.botRightPictureBox.TabStop = False
        '
        'topLeftLabel
        '
        Me.topLeftLabel.AutoSize = True
        Me.topLeftLabel.Location = New System.Drawing.Point(285, 404)
        Me.topLeftLabel.Name = "topLeftLabel"
        Me.topLeftLabel.Size = New System.Drawing.Size(39, 13)
        Me.topLeftLabel.TabIndex = 5
        Me.topLeftLabel.Text = "Label1"
        '
        'topRightLabel
        '
        Me.topRightLabel.AutoSize = True
        Me.topRightLabel.Location = New System.Drawing.Point(695, 404)
        Me.topRightLabel.Name = "topRightLabel"
        Me.topRightLabel.Size = New System.Drawing.Size(39, 13)
        Me.topRightLabel.TabIndex = 6
        Me.topRightLabel.Text = "Label1"
        '
        'botRightLabel
        '
        Me.botRightLabel.AutoSize = True
        Me.botRightLabel.Location = New System.Drawing.Point(695, 706)
        Me.botRightLabel.Name = "botRightLabel"
        Me.botRightLabel.Size = New System.Drawing.Size(39, 13)
        Me.botRightLabel.TabIndex = 7
        Me.botRightLabel.Text = "Label1"
        '
        'botLeftLabel
        '
        Me.botLeftLabel.AutoSize = True
        Me.botLeftLabel.Location = New System.Drawing.Point(285, 706)
        Me.botLeftLabel.Name = "botLeftLabel"
        Me.botLeftLabel.Size = New System.Drawing.Size(39, 13)
        Me.botLeftLabel.TabIndex = 8
        Me.botLeftLabel.Text = "Label1"
        '
        'songScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.botLeftLabel)
        Me.Controls.Add(Me.botRightLabel)
        Me.Controls.Add(Me.topRightLabel)
        Me.Controls.Add(Me.topLeftLabel)
        Me.Controls.Add(Me.botRightPictureBox)
        Me.Controls.Add(Me.botLeftPictureBox)
        Me.Controls.Add(Me.topRightPictureBox)
        Me.Controls.Add(Me.topLeftPictureBox)
        Me.Controls.Add(Me.CategoryLabel)
        Me.Name = "songScreen"
        Me.Size = New System.Drawing.Size(1024, 768)
        CType(Me.topLeftPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.topRightPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.botLeftPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.botRightPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CategoryLabel As Label
    Friend WithEvents topLeftPictureBox As PictureBox
    Friend WithEvents topRightPictureBox As PictureBox
    Friend WithEvents botLeftPictureBox As PictureBox
    Friend WithEvents botRightPictureBox As PictureBox
    Friend WithEvents topLeftLabel As Label
    Friend WithEvents topRightLabel As Label
    Friend WithEvents botRightLabel As Label
    Friend WithEvents botLeftLabel As Label
End Class
