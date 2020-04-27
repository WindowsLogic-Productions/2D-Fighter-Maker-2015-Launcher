Public Class About

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Launcher.Timer1.Enabled = True
        Launcher.Label1.Text = "Initialising required resources..."
        Me.Close()
    End Sub

    Private Sub About_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Launcher.Timer1.Enabled = False
        Launcher.Label1.Text = "Initialising paused..."
    End Sub
End Class