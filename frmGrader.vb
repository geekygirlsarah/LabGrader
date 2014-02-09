Public Class frmGrader

    Dim TotalPoints As UInteger = 60

    Private Sub chkCompilation_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCompilation.CheckedChanged
        UpdatePoints()
    End Sub

    ' Calculate the total points and update the label
    Private Sub UpdatePoints()
        TotalPoints = 0

        If chkCompilation.Checked = True Then
            TotalPoints = 10
        End If

        TotalPoints += nudAlgorithm.Value
        TotalPoints += nudDocumentation.Value
        TotalPoints += nudFunctional.Value
        TotalPoints += nudInput.Value
        TotalPoints += nudStyle.Value

        lblTotalPoints.Text = "Points:  (" + CStr(TotalPoints) + "/60)"

    End Sub

    Private Sub nudAlgorithm_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudAlgorithm.ValueChanged
        UpdatePoints()
    End Sub

    Private Sub nudFunctional_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudFunctional.ValueChanged
        UpdatePoints()
    End Sub

    Private Sub nudInput_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudInput.ValueChanged
        UpdatePoints()
    End Sub

    Private Sub nudDocumentation_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudDocumentation.ValueChanged
        UpdatePoints()
    End Sub

    Private Sub nudStyle_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudStyle.ValueChanged
        UpdatePoints()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmGrader_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboOutput.Items.Clear()
        cboOutput.Items.Add("Build output")
        cboOutput.Items.Add("Program output")
        cboOutput.Items.Add("[filename]")
        cboOutput.SelectedIndex = 0
    End Sub

    'Private Sub cboOutput_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboOutput.SelectedIndexChanged
    '    If cboOutput.SelectedIndex = 0 Then
    '        rtbOutput.Text = "Build output"
    '    ElseIf cboOutput.SelectedIndex = 1 Then
    '        rtbOutput.Text = "Program output"
    '    Else
    '        rtbOutput.Text = "[filename]"
    '    End If
    'End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim strClipboard As String = ""
        Dim nl As String = Environment.NewLine

        strClipboard += "*** Errors from auto-grading program below: ***" + nl

        ' Insert Errors from Autograder
        If rtbOutput.Text = "" Then
            strClipboard += "None."
        Else
            strClipboard += rtbOutput.Text()
        End If

        ' Add this back in later when it actually works
        'strClipboard += nl + nl
        'strClipboard += "*** Instructor notes below: ***" + nl

        ' Insert Errors from Autograder
        'strClipboard += "None."

        strClipboard += nl + nl
        strClipboard += "*** Grading criteria: ***" + nl
        strClipboard += "Algorithm: " + CStr(nudAlgorithm.Value) + "/10" + nl
        strClipboard += txtAlgorithmNotes.Text + nl

        strClipboard += nl + "Functional/Structural Composition: " + CStr(nudFunctional.Value) + "/10" + nl
        strClipboard += txtFunctionalCompositionNotes.Text + nl

        strClipboard += nl + "Proper Input/Output: " + CStr(nudInput.Value) + "/10" + nl
        strClipboard += txtInputOutputNotes.Text + nl

        strClipboard += nl + "Documentation: " + CStr(nudDocumentation.Value) + "/10" + nl
        strClipboard += txtDocumentationNotes.Text + nl

        strClipboard += nl + "Programming Style: " + CStr(nudStyle.Value) + "/10" + nl
        strClipboard += txtStyleNotes.Text + nl

        strClipboard += nl + "Compilation: " + CStr(-(CInt(chkCompilation.Checked)) * 10) + "/10" + nl + nl

        strClipboard += "*** Total score: " + CStr(TotalPoints) + " / 60 ***" + nl

        Clipboard.SetText(strClipboard)
        MsgBox("Notes copied to clipboard", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Lab Grader")
    End Sub

    Private Sub cmdReset_Click(sender As System.Object, e As System.EventArgs) Handles cmdReset.Click
        chkCompilation.Checked = True
        nudAlgorithm.Value = 10
        nudDocumentation.Value = 10
        nudFunctional.Value = 10
        nudInput.Value = 10
        nudStyle.Value = 10
        TotalPoints = 60

        rtbOutput.Text = ""
        txtAlgorithmNotes.Text = ""
        txtDocumentationNotes.Text = ""
        txtFunctionalCompositionNotes.Text = ""
        txtInputOutputNotes.Text = ""
        txtStyleNotes.Text = ""
    End Sub
End Class