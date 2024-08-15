Public Class WebmanConnect
    Try
    Dim request As WebRequest = WebRequest.Create("http://" & playip & "/" & Command())
    Dim response As WebResponse = request.GetResponse()

    Using dataStream As Stream = response.GetResponseStream()
    Dim read As New StreamReader(dataStream)
            read.ReadToEnd()
        End Using

        response.Close()
    Catch ex As WebException
        Program.Log.Error(ex, "Unable to handle webMAN commands. Error Message: " & ex.Message)
    Catch ex As Exception
        Program.Log.Error(ex, "Unable to handle webMAN commands. Error Message: " & ex.Message)
    End Try
End Class
