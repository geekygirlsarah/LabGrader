<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrader
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
        Me.lblDirectory = New System.Windows.Forms.Label()
        Me.grpGradingCriteria = New System.Windows.Forms.GroupBox()
        Me.chkCompilation = New System.Windows.Forms.CheckBox()
        Me.txtStyleNotes = New System.Windows.Forms.TextBox()
        Me.nudStyle = New System.Windows.Forms.NumericUpDown()
        Me.lblStyle = New System.Windows.Forms.Label()
        Me.txtDocumentationNotes = New System.Windows.Forms.TextBox()
        Me.nudDocumentation = New System.Windows.Forms.NumericUpDown()
        Me.lblDocumentation = New System.Windows.Forms.Label()
        Me.txtInputOutputNotes = New System.Windows.Forms.TextBox()
        Me.nudInput = New System.Windows.Forms.NumericUpDown()
        Me.lblInputOutput = New System.Windows.Forms.Label()
        Me.txtFunctionalCompositionNotes = New System.Windows.Forms.TextBox()
        Me.nudFunctional = New System.Windows.Forms.NumericUpDown()
        Me.lblFunctionalComposition = New System.Windows.Forms.Label()
        Me.txtAlgorithmNotes = New System.Windows.Forms.TextBox()
        Me.nudAlgorithm = New System.Windows.Forms.NumericUpDown()
        Me.lblAlgorithm = New System.Windows.Forms.Label()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.cboOutput = New System.Windows.Forms.ComboBox()
        Me.lblTotalPoints = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.grpGradingCriteria.SuspendLayout()
        CType(Me.nudStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDocumentation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFunctional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAlgorithm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDirectory
        '
        Me.lblDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirectory.Location = New System.Drawing.Point(16, 43)
        Me.lblDirectory.Name = "lblDirectory"
        Me.lblDirectory.Size = New System.Drawing.Size(317, 14)
        Me.lblDirectory.TabIndex = 0
        Me.lblDirectory.Text = "Directory: [dir]"
        '
        'grpGradingCriteria
        '
        Me.grpGradingCriteria.Controls.Add(Me.chkCompilation)
        Me.grpGradingCriteria.Controls.Add(Me.txtStyleNotes)
        Me.grpGradingCriteria.Controls.Add(Me.nudStyle)
        Me.grpGradingCriteria.Controls.Add(Me.lblStyle)
        Me.grpGradingCriteria.Controls.Add(Me.txtDocumentationNotes)
        Me.grpGradingCriteria.Controls.Add(Me.nudDocumentation)
        Me.grpGradingCriteria.Controls.Add(Me.lblDocumentation)
        Me.grpGradingCriteria.Controls.Add(Me.txtInputOutputNotes)
        Me.grpGradingCriteria.Controls.Add(Me.nudInput)
        Me.grpGradingCriteria.Controls.Add(Me.lblInputOutput)
        Me.grpGradingCriteria.Controls.Add(Me.txtFunctionalCompositionNotes)
        Me.grpGradingCriteria.Controls.Add(Me.nudFunctional)
        Me.grpGradingCriteria.Controls.Add(Me.lblFunctionalComposition)
        Me.grpGradingCriteria.Controls.Add(Me.txtAlgorithmNotes)
        Me.grpGradingCriteria.Controls.Add(Me.nudAlgorithm)
        Me.grpGradingCriteria.Controls.Add(Me.lblAlgorithm)
        Me.grpGradingCriteria.Location = New System.Drawing.Point(16, 64)
        Me.grpGradingCriteria.Name = "grpGradingCriteria"
        Me.grpGradingCriteria.Size = New System.Drawing.Size(317, 500)
        Me.grpGradingCriteria.TabIndex = 2
        Me.grpGradingCriteria.TabStop = False
        Me.grpGradingCriteria.Text = "Grading criteria"
        '
        'chkCompilation
        '
        Me.chkCompilation.AutoSize = True
        Me.chkCompilation.Checked = True
        Me.chkCompilation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCompilation.Location = New System.Drawing.Point(6, 19)
        Me.chkCompilation.Name = "chkCompilation"
        Me.chkCompilation.Size = New System.Drawing.Size(135, 17)
        Me.chkCompilation.TabIndex = 3
        Me.chkCompilation.Text = "&Compilation (10/10 pts)"
        Me.chkCompilation.UseVisualStyleBackColor = True
        '
        'txtStyleNotes
        '
        Me.txtStyleNotes.Location = New System.Drawing.Point(6, 431)
        Me.txtStyleNotes.Multiline = True
        Me.txtStyleNotes.Name = "txtStyleNotes"
        Me.txtStyleNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStyleNotes.Size = New System.Drawing.Size(302, 61)
        Me.txtStyleNotes.TabIndex = 18
        '
        'nudStyle
        '
        Me.nudStyle.Location = New System.Drawing.Point(260, 405)
        Me.nudStyle.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudStyle.Name = "nudStyle"
        Me.nudStyle.Size = New System.Drawing.Size(48, 20)
        Me.nudStyle.TabIndex = 17
        Me.nudStyle.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblStyle
        '
        Me.lblStyle.AutoSize = True
        Me.lblStyle.Location = New System.Drawing.Point(3, 407)
        Me.lblStyle.Name = "lblStyle"
        Me.lblStyle.Size = New System.Drawing.Size(179, 13)
        Me.lblStyle.TabIndex = 16
        Me.lblStyle.Text = "Programming &Style (out of 10 points):"
        '
        'txtDocumentationNotes
        '
        Me.txtDocumentationNotes.Location = New System.Drawing.Point(6, 339)
        Me.txtDocumentationNotes.Multiline = True
        Me.txtDocumentationNotes.Name = "txtDocumentationNotes"
        Me.txtDocumentationNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDocumentationNotes.Size = New System.Drawing.Size(302, 60)
        Me.txtDocumentationNotes.TabIndex = 15
        '
        'nudDocumentation
        '
        Me.nudDocumentation.Location = New System.Drawing.Point(260, 313)
        Me.nudDocumentation.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudDocumentation.Name = "nudDocumentation"
        Me.nudDocumentation.Size = New System.Drawing.Size(48, 20)
        Me.nudDocumentation.TabIndex = 14
        Me.nudDocumentation.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblDocumentation
        '
        Me.lblDocumentation.AutoSize = True
        Me.lblDocumentation.Location = New System.Drawing.Point(3, 315)
        Me.lblDocumentation.Name = "lblDocumentation"
        Me.lblDocumentation.Size = New System.Drawing.Size(164, 13)
        Me.lblDocumentation.TabIndex = 13
        Me.lblDocumentation.Text = "&Documentation (out of 10 points):"
        '
        'txtInputOutputNotes
        '
        Me.txtInputOutputNotes.Location = New System.Drawing.Point(6, 247)
        Me.txtInputOutputNotes.Multiline = True
        Me.txtInputOutputNotes.Name = "txtInputOutputNotes"
        Me.txtInputOutputNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInputOutputNotes.Size = New System.Drawing.Size(302, 60)
        Me.txtInputOutputNotes.TabIndex = 12
        '
        'nudInput
        '
        Me.nudInput.Location = New System.Drawing.Point(260, 221)
        Me.nudInput.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudInput.Name = "nudInput"
        Me.nudInput.Size = New System.Drawing.Size(48, 20)
        Me.nudInput.TabIndex = 11
        Me.nudInput.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblInputOutput
        '
        Me.lblInputOutput.AutoSize = True
        Me.lblInputOutput.Location = New System.Drawing.Point(6, 223)
        Me.lblInputOutput.Name = "lblInputOutput"
        Me.lblInputOutput.Size = New System.Drawing.Size(187, 13)
        Me.lblInputOutput.TabIndex = 10
        Me.lblInputOutput.Text = "&Proper Input/Output (out of 10 points):"
        '
        'txtFunctionalCompositionNotes
        '
        Me.txtFunctionalCompositionNotes.Location = New System.Drawing.Point(6, 155)
        Me.txtFunctionalCompositionNotes.Multiline = True
        Me.txtFunctionalCompositionNotes.Name = "txtFunctionalCompositionNotes"
        Me.txtFunctionalCompositionNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFunctionalCompositionNotes.Size = New System.Drawing.Size(302, 60)
        Me.txtFunctionalCompositionNotes.TabIndex = 9
        '
        'nudFunctional
        '
        Me.nudFunctional.Location = New System.Drawing.Point(260, 129)
        Me.nudFunctional.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudFunctional.Name = "nudFunctional"
        Me.nudFunctional.Size = New System.Drawing.Size(48, 20)
        Me.nudFunctional.TabIndex = 8
        Me.nudFunctional.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblFunctionalComposition
        '
        Me.lblFunctionalComposition.AutoSize = True
        Me.lblFunctionalComposition.Location = New System.Drawing.Point(6, 131)
        Me.lblFunctionalComposition.Name = "lblFunctionalComposition"
        Me.lblFunctionalComposition.Size = New System.Drawing.Size(251, 13)
        Me.lblFunctionalComposition.TabIndex = 7
        Me.lblFunctionalComposition.Text = "&Functional/Structural Composition (out of 10 points):"
        '
        'txtAlgorithmNotes
        '
        Me.txtAlgorithmNotes.Location = New System.Drawing.Point(6, 63)
        Me.txtAlgorithmNotes.Multiline = True
        Me.txtAlgorithmNotes.Name = "txtAlgorithmNotes"
        Me.txtAlgorithmNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlgorithmNotes.Size = New System.Drawing.Size(302, 60)
        Me.txtAlgorithmNotes.TabIndex = 6
        '
        'nudAlgorithm
        '
        Me.nudAlgorithm.Location = New System.Drawing.Point(260, 37)
        Me.nudAlgorithm.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudAlgorithm.Name = "nudAlgorithm"
        Me.nudAlgorithm.Size = New System.Drawing.Size(48, 20)
        Me.nudAlgorithm.TabIndex = 5
        Me.nudAlgorithm.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblAlgorithm
        '
        Me.lblAlgorithm.AutoSize = True
        Me.lblAlgorithm.Location = New System.Drawing.Point(3, 39)
        Me.lblAlgorithm.Name = "lblAlgorithm"
        Me.lblAlgorithm.Size = New System.Drawing.Size(135, 13)
        Me.lblAlgorithm.TabIndex = 4
        Me.lblAlgorithm.Text = "&Algorithm (out of 10 points):"
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.rtbOutput)
        Me.grpOutput.Controls.Add(Me.cboOutput)
        Me.grpOutput.Location = New System.Drawing.Point(339, 64)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(406, 500)
        Me.grpOutput.TabIndex = 19
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "C&ompilation and Output"
        '
        'rtbOutput
        '
        Me.rtbOutput.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbOutput.Location = New System.Drawing.Point(6, 44)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(394, 448)
        Me.rtbOutput.TabIndex = 21
        Me.rtbOutput.Text = ""
        '
        'cboOutput
        '
        Me.cboOutput.FormattingEnabled = True
        Me.cboOutput.Location = New System.Drawing.Point(6, 17)
        Me.cboOutput.Name = "cboOutput"
        Me.cboOutput.Size = New System.Drawing.Size(394, 21)
        Me.cboOutput.TabIndex = 20
        '
        'lblTotalPoints
        '
        Me.lblTotalPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPoints.Location = New System.Drawing.Point(336, 43)
        Me.lblTotalPoints.Name = "lblTotalPoints"
        Me.lblTotalPoints.Size = New System.Drawing.Size(409, 18)
        Me.lblTotalPoints.TabIndex = 1
        Me.lblTotalPoints.Text = "Points:  (60/60)"
        '
        'btnContinue
        '
        Me.btnContinue.AutoSize = True
        Me.btnContinue.Enabled = False
        Me.btnContinue.Location = New System.Drawing.Point(751, 64)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(113, 25)
        Me.btnContinue.TabIndex = 22
        Me.btnContinue.Text = "&Continue >"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(751, 95)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 25)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(751, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 25)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Copy All &Notes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(13, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(227, 17)
        Me.lblStatus.TabIndex = 25
        Me.lblStatus.Text = "Status: Copying shared files..."
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(751, 301)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(113, 25)
        Me.cmdReset.TabIndex = 26
        Me.cmdReset.Text = "&Reset Scores"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'frmGrader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(876, 587)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblTotalPoints)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpGradingCriteria)
        Me.Controls.Add(Me.lblDirectory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGrader"
        Me.Text = "Grading"
        Me.grpGradingCriteria.ResumeLayout(False)
        Me.grpGradingCriteria.PerformLayout()
        CType(Me.nudStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDocumentation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFunctional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAlgorithm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOutput.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDirectory As System.Windows.Forms.Label
    Friend WithEvents grpGradingCriteria As System.Windows.Forms.GroupBox
    Friend WithEvents txtStyleNotes As System.Windows.Forms.TextBox
    Friend WithEvents nudStyle As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblStyle As System.Windows.Forms.Label
    Friend WithEvents txtDocumentationNotes As System.Windows.Forms.TextBox
    Friend WithEvents nudDocumentation As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDocumentation As System.Windows.Forms.Label
    Friend WithEvents txtInputOutputNotes As System.Windows.Forms.TextBox
    Friend WithEvents nudInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblInputOutput As System.Windows.Forms.Label
    Friend WithEvents txtFunctionalCompositionNotes As System.Windows.Forms.TextBox
    Friend WithEvents nudFunctional As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblFunctionalComposition As System.Windows.Forms.Label
    Friend WithEvents txtAlgorithmNotes As System.Windows.Forms.TextBox
    Friend WithEvents nudAlgorithm As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblAlgorithm As System.Windows.Forms.Label
    Friend WithEvents chkCompilation As System.Windows.Forms.CheckBox
    Friend WithEvents grpOutput As System.Windows.Forms.GroupBox
    Friend WithEvents rtbOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents cboOutput As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotalPoints As System.Windows.Forms.Label
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmdReset As System.Windows.Forms.Button
End Class
