<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.LoginScreen = New PlayASongPrototype.LoginScreen()
        Me.DisplayPanel1 = New PlayASongPrototype.displayPanel()
        Me.SuspendLayout()
        '
        'LoginScreen
        '
        Me.LoginScreen.BackColor = System.Drawing.Color.Transparent
        Me.LoginScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoginScreen.Location = New System.Drawing.Point(-7, -31)
        Me.LoginScreen.Name = "LoginScreen"
        Me.LoginScreen.Size = New System.Drawing.Size(1280, 1024)
        Me.LoginScreen.TabIndex = 0
        '
        'DisplayPanel1
        '
        Me.DisplayPanel1.Location = New System.Drawing.Point(89, 12)
        Me.DisplayPanel1.Name = "DisplayPanel1"
        Me.DisplayPanel1.Size = New System.Drawing.Size(1024, 768)
        Me.DisplayPanel1.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 986)
        Me.Controls.Add(Me.LoginScreen)
        Me.Controls.Add(Me.DisplayPanel1)
        Me.Name = "MainForm"
        Me.Text = "PlayASong"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginScreen As LoginScreen
    Friend WithEvents DisplayPanel1 As displayPanel
    'Friend WithEvents SongScreen1 As songScreen
End Class
