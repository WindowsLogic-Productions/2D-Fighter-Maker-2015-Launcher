Public Class News

    Private Sub News_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Launcher.Timer1.Enabled = False
        Launcher.Label1.Text = "Initialising paused..."
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Launcher.Timer1.Enabled = True
        Launcher.Label1.Text = "Initialising required resources..."
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class