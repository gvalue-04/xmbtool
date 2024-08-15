Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles WavetoolButton.Click
        Dim waveinst As New waveinstaller()
        waveinst.ShowDialog()
    End Sub
End Class
