<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class displayPanel
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.topLeft = New System.Windows.Forms.PictureBox()
        Me.topRight = New System.Windows.Forms.PictureBox()
        Me.bottomRight = New System.Windows.Forms.PictureBox()
        Me.bottomLeft = New System.Windows.Forms.PictureBox()
        Me.topLeftLabel = New System.Windows.Forms.Label()
        Me.topRightLabel = New System.Windows.Forms.Label()
        Me.bottomLeftLabel = New System.Windows.Forms.Label()
        Me.bottomRightLabel = New System.Windows.Forms.Label()
        CType(Me.topLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.topRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bottomRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bottomLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(343, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 135)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'topLeft
        '
        Me.topLeft.Location = New System.Drawing.Point(169, 257)
        Me.topLeft.Name = "topLeft"
        Me.topLeft.Size = New System.Drawing.Size(200, 150)
        Me.topLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.topLeft.TabIndex = 1
        Me.topLeft.TabStop = False
        '
        'topRight
        '
        Me.topRight.Location = New System.Drawing.Point(656, 257)
        Me.topRight.Name = "topRight"
        Me.topRight.Size = New System.Drawing.Size(200, 150)
        Me.topRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.topRight.TabIndex = 2
        Me.topRight.TabStop = False
        '
        'bottomRight
        '
        Me.bottomRight.Location = New System.Drawing.Point(656, 517)
        Me.bottomRight.Name = "bottomRight"
        Me.bottomRight.Size = New System.Drawing.Size(200, 150)
        Me.bottomRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bottomRight.TabIndex = 4
        Me.bottomRight.TabStop = False
        '
        'bottomLeft
        '
        Me.bottomLeft.Location = New System.Drawing.Point(169, 517)
        Me.bottomLeft.Name = "bottomLeft"
        Me.bottomLeft.Size = New System.Drawing.Size(200, 150)
        Me.bottomLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bottomLeft.TabIndex = 3
        Me.bottomLeft.TabStop = False
        '
        'topLeftLabel
        '
        Me.topLeftLabel.AutoSize = True
        Me.topLeftLabel.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topLeftLabel.ForeColor = System.Drawing.Color.Black
        Me.topLeftLabel.Location = New System.Drawing.Point(210, 410)
        Me.topLeftLabel.Name = "topLeftLabel"
        Me.topLeftLabel.Size = New System.Drawing.Size(120, 45)
        Me.topLeftLabel.TabIndex = 5
        Me.topLeftLabel.Text = "Label2"
        '
        'topRightLabel
        '
        Me.topRightLabel.AutoSize = True
        Me.topRightLabel.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topRightLabel.ForeColor = System.Drawing.Color.Black
        Me.topRightLabel.Location = New System.Drawing.Point(697, 410)
        Me.topRightLabel.Name = "topRightLabel"
        Me.topRightLabel.Size = New System.Drawing.Size(120, 45)
        Me.topRightLabel.TabIndex = 6
        Me.topRightLabel.Text = "Label3"
        '
        'bottomLeftLabel
        '
        Me.bottomLeftLabel.AutoSize = True
        Me.bottomLeftLabel.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bottomLeftLabel.ForeColor = System.Drawing.Color.Black
        Me.bottomLeftLabel.Location = New System.Drawing.Point(200, 670)
        Me.bottomLeftLabel.Name = "bottomLeftLabel"
        Me.bottomLeftLabel.Size = New System.Drawing.Size(120, 45)
        Me.bottomLeftLabel.TabIndex = 7
        Me.bottomLeftLabel.Text = "Label4"
        '
        'bottomRightLabel
        '
        Me.bottomRightLabel.AutoSize = True
        Me.bottomRightLabel.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bottomRightLabel.ForeColor = System.Drawing.Color.Black
        Me.bottomRightLabel.Location = New System.Drawing.Point(686, 670)
        Me.bottomRightLabel.Name = "bottomRightLabel"
        Me.bottomRightLabel.Size = New System.Drawing.Size(120, 45)
        Me.bottomRightLabel.TabIndex = 8
        Me.bottomRightLabel.Text = "Label5"
        '
        'displayPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.bottomRightLabel)
        Me.Controls.Add(Me.bottomLeftLabel)
        Me.Controls.Add(Me.topRightLabel)
        Me.Controls.Add(Me.topLeftLabel)
        Me.Controls.Add(Me.bottomRight)
        Me.Controls.Add(Me.bottomLeft)
        Me.Controls.Add(Me.topRight)
        Me.Controls.Add(Me.topLeft)
        Me.Controls.Add(Me.Label1)
        Me.Name = "displayPanel"
        Me.Size = New System.Drawing.Size(1024, 768)
        CType(Me.topLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.topRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bottomRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bottomLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents topLeft As PictureBox
    Friend WithEvents topRight As PictureBox
    Friend WithEvents bottomRight As PictureBox
    Friend WithEvents bottomLeft As PictureBox
    Friend WithEvents topLeftLabel As Label
    Friend WithEvents topRightLabel As Label
    Friend WithEvents bottomLeftLabel As Label
    Friend WithEvents bottomRightLabel As Label
End Class
