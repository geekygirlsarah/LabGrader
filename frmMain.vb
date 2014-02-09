'<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
    'Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCodeDirectory = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSharedCode = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDiffFile = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.lstStatus = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Root directory with code to compile and grade:"
        '
        'btnCodeDirectory
        '
        Me.btnCodeDirectory.Location = New System.Drawing.Point(15, 25)
        Me.btnCodeDirectory.Name = "btnCodeDirectory"
        Me.btnCodeDirectory.Size = New System.Drawing.Size(521, 23)
        Me.btnCodeDirectory.TabIndex = 1
        Me.btnCodeDirectory.Text = "C:\..."
        Me.btnCodeDirectory.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Directory with shared code to add:"
        '
        'btnSharedCode
        '
        Me.btnSharedCode.Location = New System.Drawing.Point(15, 72)
        Me.btnSharedCode.Name = "btnSharedCode"
        Me.btnSharedCode.Size = New System.Drawing.Size(521, 23)
        Me.btnSharedCode.TabIndex = 3
        Me.btnSharedCode.Text = "C:\..."
        Me.btnSharedCode.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "File with output to compare" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Must share same output filename:"
        '
        'btnDiffFile
        '
        Me.btnDiffFile.Location = New System.Drawing.Point(15, 132)
        Me.btnDiffFile.Name = "btnDiffFile"
        Me.btnDiffFile.Size = New System.Drawing.Size(521, 23)
        Me.btnDiffFile.TabIndex = 5
        Me.btnDiffFile.Text = "C:\..."
        Me.btnDiffFile.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "File differences will appear in same directory as code"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(15, 269)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(166, 33)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "Start Grading"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'lstStatus
        '
        Me.lstStatus.FormattingEnabled = True
        Me.lstStatus.Location = New System.Drawing.Point(289, 181)
        Me.lstStatus.Name = "lstStatus"
        Me.lstStatus.Size = New System.Drawing.Size(247, 160)
        Me.lstStatus.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(243, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Status:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(15, 308)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(166, 33)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 353)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstStatus)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDiffFile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSharedCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCodeDirectory)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Lab Grader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCodeDirectory As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSharedCode As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDiffFile As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog

    Private Sub btnCodeDirectory_Click(sender As System.Object, e As System.EventArgs) Handles btnCodeDirectory.Click
        Dim flag As Boolean = True
        While flag
            FolderBrowserDialog.Description() = "Choose a directory containing the directories of the projects you wish to grade."
            FolderBrowserDialog.ShowNewFolderButton = False
            FolderBrowserDialog.SelectedPath() = codeDirectory
            If (FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                If (My.Computer.FileSystem.GetDirectories(FolderBrowserDialog.SelectedPath).Count < 1) Then
                    MsgBox("The chosen directory has no subdirectories. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error")
                    flag = True
                    Continue While
                End If
                codeDirectory = FolderBrowserDialog.SelectedPath
                btnCodeDirectory.Text = FolderBrowserDialog.SelectedPath
            End If
            flag = False
        End While
    End Sub

    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        codeDirectory = "d:\Users\Sarah\Dropbox\School\TA - CS 201 (Fall 2013)\Grading\lab02\0002"
        sharedDirectory = "d:\Users\Sarah\Dropbox\School\TA - CS 201 (Fall 2013)\Grading\lab02\output"
        diffFile = "d:\Users\Sarah\Dropbox\School\TA - CS 201 (Fall 2013)\Grading\lab02\output\output.txt"
        'codeDirectory = Application.StartupPath
        btnCodeDirectory.Text = codeDirectory

        'sharedDirectory = Application.StartupPath
        btnSharedCode.Text = sharedDirectory

        'diffFile = Application.StartupPath + "\output.txt"
        OpenFileDialog.InitialDirectory = Application.StartupPath
        btnDiffFile.Text = diffFile

        UpdateStatus("DEBUG MODE ON:")
        UpdateStatus("Turn off in frmMain_Load")


        UpdateStatus("Click on Start Grading to begin the process.")
    End Sub
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog

    Private Sub btnSharedCode_Click(sender As System.Object, e As System.EventArgs) Handles btnSharedCode.Click
        Dim flag As Boolean = True
        While flag
            FolderBrowserDialog.Description = "Choose a directory containing the code that's shared among all labs."
            FolderBrowserDialog.ShowNewFolderButton = False
            FolderBrowserDialog.SelectedPath = sharedDirectory
            If (FolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK) Then
                If (My.Computer.FileSystem.GetFiles(FolderBrowserDialog.SelectedPath).Count < 1) Then
                    MsgBox("The chosen directory has no files. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error")
                    flag = True
                    Continue While
                End If
                sharedDirectory = FolderBrowserDialog.SelectedPath
                btnSharedCode.Text = FolderBrowserDialog.SelectedPath
            End If
            flag = False
        End While
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        btnStart.Enabled = False
        btnCodeDirectory.Enabled = False
        btnDiffFile.Enabled = False
        btnExit.Enabled = False
        btnSharedCode.Enabled = False

        'StartGrading()
        frmGrader.ShowDialog(Me)

        btnStart.Enabled = True
        btnCodeDirectory.Enabled = True
        btnDiffFile.Enabled = True
        btnExit.Enabled = True
        btnSharedCode.Enabled = True

        btnExit.Focus()
    End Sub

    Private Sub btnDiffFile_Click(sender As System.Object, e As System.EventArgs) Handles btnDiffFile.Click
        'FolderBrowserDialog.Description = "Choose a directory containing the directories of the projects you wish to grade."
        'FolderBrowserDialog.ShowNewFolderButton = False
        'FolderBrowserDialog.SelectedPath = codeDirectory
        'If (FolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK) Then
        '    codeDirectory = FolderBrowserDialog.SelectedPath
        '    btnCodeDirectory.Text = FolderBrowserDialog.SelectedPath
        'End If

        OpenFileDialog.Title = "Open Output File..."
        OpenFileDialog.FileName = diffFile
        If (OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK) Then
            diffFile = OpenFileDialog.FileName
            btnDiffFile.Text = diffFile
        End If

    End Sub

    Friend WithEvents lstStatus As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnExit As System.Windows.Forms.Button

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
