Imports System.Net
Imports System.IO
Imports System

Public Class waveinstaller
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim playip As String = TextBox1.Text.Trim() ' Trim any whitespace
        Dim ftpPath As String = $"ftp://{playip}/dev_hdd0/boot_plugins.txt"
        Dim winUser As String = Environment.UserName
        Dim userPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "boot_plugins.txt")

        ' Validate the IP address format
        If Not Uri.IsWellFormedUriString(ftpPath, UriKind.Absolute) Then
            MessageBox.Show("Invalid IP address or URL format.")
            Return
        End If

        Dim checkForPS3 As FtpWebRequest = DirectCast(WebRequest.Create(ftpPath), FtpWebRequest)
        checkForPS3.Method = WebRequestMethods.Ftp.DownloadFile
        checkForPS3.Credentials = New NetworkCredential("anonymous", "") ' Add actual credentials if needed
        checkForPS3.Timeout = 10000
        checkForPS3.ReadWriteTimeout = 10000
        checkForPS3.KeepAlive = False
        checkForPS3.UseBinary = True
        checkForPS3.UsePassive = True

        Try
            Using response As FtpWebResponse = DirectCast(checkForPS3.GetResponse(), FtpWebResponse)
                Using responseStream As Stream = response.GetResponseStream()
                    Using fileStream As New FileStream(userPath, FileMode.Create)
                        responseStream.CopyTo(fileStream)
                    End Using
                End Using
                If response.StatusCode = FtpStatusCode.ClosingData Then
                    MessageBox.Show(playip + " is a real PS3! You can continue with your wave applying now!")
                Else
                    MessageBox.Show(playip + " is not a real PS3. Perhaps you don't have webman MOD, or HEN is not enabled?")
                End If
            End Using
        Catch ex As WebException
            Dim response As FtpWebResponse = DirectCast(ex.Response, FtpWebResponse)
            MessageBox.Show("Error code: " & response.StatusCode.ToString() & vbCrLf & "Error message: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://connie.nekoweb.org/lineschive")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim playip As String = TextBox1.Text.Trim() ' Trim any whitespace
        Dim ftpPath As String = $"ftp://{playip}/dev_blind/vsh/resource/qgl/lines.qrc"
        Dim winUser As String = Environment.UserName
        Dim userPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "lines.qrc")

        ' Validate the IP address format
        If Not Uri.IsWellFormedUriString(ftpPath, UriKind.Absolute) Then
            MessageBox.Show("Invalid IP address or URL format.")
            Return
        End If

        Dim checkForPS3 As FtpWebRequest = DirectCast(WebRequest.Create(ftpPath), FtpWebRequest)
        checkForPS3.Method = WebRequestMethods.Ftp.DownloadFile
        checkForPS3.Credentials = New NetworkCredential("anonymous", "") ' Add actual credentials if needed
        checkForPS3.Timeout = 10000
        checkForPS3.ReadWriteTimeout = 10000
        checkForPS3.KeepAlive = False
        checkForPS3.UseBinary = True
        checkForPS3.UsePassive = True

        Try
            Using response As FtpWebResponse = DirectCast(checkForPS3.GetResponse(), FtpWebResponse)
                Using responseStream As Stream = response.GetResponseStream()
                    Using fileStream As New FileStream(userPath, FileMode.Create)
                        responseStream.CopyTo(fileStream)
                    End Using
                End Using
                If response.StatusCode = FtpStatusCode.ClosingData Then
                    MessageBox.Show("Successfully backed up the current lines.qrc on the system to the documents folder.")
                Else
                    MessageBox.Show(playip + ": Failed to back up")
                End If
            End Using
        Catch ex As WebException
            Dim response As FtpWebResponse = DirectCast(ex.Response, FtpWebResponse)
            MessageBox.Show("Error code: " & response.StatusCode.ToString() & vbCrLf & "Error message: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "PS3 Wave (*.qrc*)|*.qrc*"
        openFileDialog.Title = "Select a wave"

        ' Show the file dialog and check if a file was selected
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim filePath As String = openFileDialog.FileName
            Dim playip As String = TextBox1.Text.Trim() ' Trim any whitespace
            Dim ftpPath As String = $"ftp://{playip}/dev_blind/vsh/resource/qgl/lines.qrc"

            ' Validate the constructed FTP URL
            If Not Uri.IsWellFormedUriString(ftpPath, UriKind.Absolute) Then
                MessageBox.Show("Invalid IP address or URL format.")
                Return
            End If

            ' Prepare the FTP request to upload the file
            Dim uploadFileRequest As FtpWebRequest = DirectCast(WebRequest.Create(ftpPath), FtpWebRequest)
            uploadFileRequest.Method = WebRequestMethods.Ftp.UploadFile
            uploadFileRequest.Credentials = New NetworkCredential("anonymous", "") ' Add actual credentials if needed
            uploadFileRequest.Timeout = 10000
            uploadFileRequest.ReadWriteTimeout = 10000
            uploadFileRequest.KeepAlive = False
            uploadFileRequest.UseBinary = True
            uploadFileRequest.UsePassive = True

            Try
                ' Read the file data into a byte array
                Dim fileContents() As Byte = File.ReadAllBytes(filePath)

                ' Upload the file to the FTP server
                uploadFileRequest.ContentLength = fileContents.Length
                Using requestStream As Stream = uploadFileRequest.GetRequestStream()
                    requestStream.Write(fileContents, 0, fileContents.Length)
                End Using

                ' Confirm the upload
                Using response As FtpWebResponse = DirectCast(uploadFileRequest.GetResponse(), FtpWebResponse)
                    MessageBox.Show("Wave installed successfully! Your PS3 will reboot by opening your browser with the relevant webman MOD command.")
                    WebmanConnect()
                End Using
            Catch ex As WebException
                Dim response As FtpWebResponse = DirectCast(ex.Response, FtpWebResponse)
                MessageBox.Show("Error code: " & response.StatusCode.ToString() & vbCrLf & "Error message: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub


    Public Sub WebmanConnect()
        Try
            Dim playip As String = TextBox1.Text.Trim()
            Dim command As String = "restart.ps3"
            Dim request As WebRequest = WebRequest.Create("http://" & playip & "/restart.ps3")
            Dim response As WebResponse = request.GetResponse()

            Using dataStream As Stream = response.GetResponseStream()
                Dim read As New StreamReader(dataStream)
                read.ReadToEnd()
            End Using

            response.Close()
        Catch ex As WebException
            MessageBox.Show(ex, "Unable to handle webMAN commands. Error Message: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex, "Unable to handle webMAN commands. Error Message: " & ex.Message)
        End Try
    End Sub
End Class