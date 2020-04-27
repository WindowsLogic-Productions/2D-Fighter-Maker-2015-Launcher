Public Class Updater

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Updater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Downloading updates, please do not exit any open 2D Fighter Maker 2015 windows.", MsgBoxStyle.Exclamation, "Updates")
        WebBrowser1.Navigate("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/FMXV/2D%20Fighter%20Maker%202015%20Setup.exe")

    End Sub
End Class