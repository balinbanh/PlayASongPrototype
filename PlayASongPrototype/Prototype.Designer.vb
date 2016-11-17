<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 986)
        Me.Controls.Add(Me.LoginScreen)
        Me.Name = "Main"
        Me.Text = "PlayASong"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginScreen As LoginScreen
End Class
