Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles WavetoolButton.Click
        Dim waveinst As New waveinstaller()
        waveinst.ShowDialog()
    End Sub

    Private Sub VisutoolButton_Click(sender As Object, e As EventArgs) Handles VisutoolButton.Click
        Dim coldinst As New ColdbootCustomizer()
        coldinst.ShowDialog()
    End Sub
End Class
