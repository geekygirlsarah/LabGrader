Imports System.IO

Module Functions
    Public codeDirectory As String
    Public sharedDirectory As String
    Public diffFile As String
    Dim directories(numDirs) As String
    Dim dirCount As Integer
    Dim fileCount As Integer
    Dim numDirs As Integer
    Dim numFiles As Integer
    Dim compileFile As String = "C:\Program Files (x86)\Microsoft Visual Studio 10.0\VC\bin\cl.exe"
    Dim compileArgs As String = "/I " + Chr(34) + "C:\Program Files (x86)\Microsoft Visual Studio 10.0\VC\include" + Chr(34) +
                                " /EHsc *.cpp /link /LIBPATH:" + Chr(34) +
                                "C:\Program Files (x86)\Microsoft Visual Studio 10.0\VC\lib" + Chr(34) +
                                " /LIBPATH:" + Chr(34) + "C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Lib" + Chr(34)


    Public Sub UpdateStatus(Msg As String)
        frmMain.lstStatus.Items.Add(Msg)
        frmMain.lstStatus.SelectedIndex = frmMain.lstStatus.Items.Count - 1
    End Sub


    Public Sub StartPreparing()

        '***********************************************************************
        '* Find/store all lab directories
        '***********************************************************************

        numDirs = My.Computer.FileSystem.GetDirectories(codeDirectory).Count
        If (numDirs < 1) Then
            MsgBox("The code directory contains no subdirectories.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        dirCount = 0

        UpdateStatus("Found " + CStr(numDirs) + " directories to grade.")

        For Each foundDirectory As String In My.Computer.FileSystem.GetDirectories(codeDirectory)
            directories(dirCount) = foundDirectory
            dirCount = dirCount + 1
        Next


        '***********************************************************************
        '* Find/store all files in shared directory
        '***********************************************************************

        numFiles = My.Computer.FileSystem.GetFiles(sharedDirectory).Count
        If (numFiles < 1) Then
            MsgBox("The shared directory contains no files.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        fileCount = 0

        UpdateStatus("Found " + CStr(numFiles) + " shared files to add.")

        Dim sharedFiles(numFiles) As String
        Dim sharedFileName(numFiles) As String

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(sharedDirectory)
            sharedFiles(fileCount) = foundFile
            fileCount = fileCount + 1
        Next
        fileCount = 0
        For Each foundFileDir As String In My.Computer.FileSystem.GetFiles(sharedDirectory)
            sharedFileName(fileCount) = My.Computer.FileSystem.GetName(foundFileDir)
            fileCount = fileCount + 1
        Next

        '***********************************************************************
        '* Copy shared files to lab directories
        '***********************************************************************

        ' Copy all files from shared to each lab directory
        For i As Integer = 0 To dirCount - 1
            UpdateStatus("Copying files to " + directories(i))
            For j As Integer = 0 To fileCount - 1
                My.Computer.FileSystem.CopyFile(sharedFiles(j), directories(i) + "\" + sharedFileName(j), True)
                'MsgBox("My.Computer.FileSystem.CopyFile(" + sharedFiles(j) + ", " + directories(i) + "\" + sharedFileName(j) + ")")

            Next
        Next
    End Sub

    Public Sub StartGrading()
        '***********************************************************************
        '* Compile labs in all directories
        '***********************************************************************

        For i As Integer = 0 To dirCount - 1
            UpdateStatus("Compiling " + directories(i))

            '    'Shell(, AppWinStyle.NormalNoFocus, True)
            '        Dim theProcess As New Diagnostics.Process
            '    theProcess.StartInfo.WorkingDirectory = directories(i)
            '    theProcess.StartInfo.FileName = compileFile
            '    theProcess.StartInfo.Arguments = compileArgs
            '    theProcess.StartInfo.UseShellExecute = False
            '    theProcess.StartInfo.RedirectStandardOutput = True
            '    theProcess.Start()
            '    theProcess.WaitForExit()
            '    Dim theOutput = theProcess.StandardOutput.ReadToEnd()

            Dim start_info As New ProcessStartInfo()
            start_info.UseShellExecute = False
            start_info.CreateNoWindow = True
            start_info.RedirectStandardOutput = True
            start_info.RedirectStandardError = True
            start_info.WorkingDirectory = directories(i)
            start_info.FileName = compileFile
            start_info.Arguments = compileArgs

            ' Make the process and set its start information.
            Dim proc As New Process()
            proc.StartInfo = start_info

            ' Start the process.
            proc.Start()

            ' Attach to stdout and stderr.
            Dim std_out As StreamReader = proc.StandardOutput()
            Dim std_err As StreamReader = proc.StandardError()

            ' Display the results.
            'frmMain.txtOutput.Text += std_out.ReadToEnd()
            'frmMain.txtOutput.Text += std_err.ReadToEnd()

            ' Clean up.
            std_out.Close()
            std_err.Close()
            proc.Close()


            '    MsgBox("Done (" + CStr(theProcess.ExitCode) + "): " + Chr(34) + theOutput + Chr(34))

        Next
        'MsgBox(compileFile)
        'MsgBox(compileArgs)


        '***********************************************************************
        '* Run each lab
        '***********************************************************************

        '***********************************************************************
        '* Run diff/fc on each output
        '***********************************************************************



    End Sub

End Module
