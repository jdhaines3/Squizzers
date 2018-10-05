Imports System
Imports System.IO
Imports System.Windows.Forms.Form

Public Class frmAnxious
    Dim intPointer As Integer

    Dim path, subj, cbx As String

    Private Sub frmAnxious_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim screen As Screen
        ' We want to display a form on screen 1
        Try
            screen = Screen.AllScreens(1)
        Catch ex As Exception
            screen = Screen.AllScreens(0)
        End Try

        ' Set the StartPosition to Manual otherwise the system will assign an automatic start position

        Me.StartPosition = FormStartPosition.Manual

        ' Set the form location so it appears at Location (100, 100) on the screen 1

        Me.Location = screen.Bounds.Location + New Point(0, 0)
        'end set screen

        KeyPreview = True
        lblCrave.Focus()

        'if first run, make pointer/arrow invisible, else make it visible and set the location
        If frmMain.pntLastAnxious.IsEmpty Then

            pbxPointer.Visible = False
        Else

            pbxPointer.Visible = True
            pbxPointer.Location() = frmMain.pntLastAnxious

        End If

        'make output path
        cbx = frmMain.cbxSess.SelectedItem
        subj = frmMain.txtSubj.Text
        path = "C:\x\" & subj & "\" & subj & cbx & "_Anxious.txt"


        lblCrave.Focus()
    End Sub

    'what to do on key press
    Private Sub frmAnxious_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult

        'if x pressed, close application (after message box check)
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then

                frmMain.cleanseEverything()

            Else
            End If

            'if 2 pressed, move slider right
        ElseIf e.KeyChar = "2" Then
            Select Case trbAnxious.Value
                Case Is > 99
                    trbAnxious.Value = 100
                Case Else
                    trbAnxious.Value = trbAnxious.Value + 1
            End Select
            intPointer = trbAnxious.Value

            'if 1 pressed, move slider left
        ElseIf e.KeyChar = "1" Then
            Select Case trbAnxious.Value
                Case Is < 1
                    trbAnxious.Value = 0
                Case Else
                    trbAnxious.Value = trbAnxious.Value - 1
            End Select
            intPointer = trbAnxious.Value

            'if 8 pressed, create new filestream and writer, output the time/date and trackbar value (separated by comma for csv format)
        ElseIf e.KeyChar = "8" Then

            Dim fs As New FileStream(path, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "," & trbAnxious.Value)
            'close filestream and streamwriter
            sr.Close()
            fs.Close()

            'set new point to be where the trackbar value was; don't mess with this unless you changed trackbar size
            frmMain.pntLastAnxious = New Point(CInt((trbAnxious.Value * 5.27) + frmMain.xStart), frmMain.yStart)

            'set pointer to true, make sure trackbar value stays where it was for next time the qstn asked
            pbxPointer.Visible = True
            trbAnxious.Value = trbAnxious.Value
            lblCrave.Focus()
            'hide and go to next form
            Me.Hide()

        End If
    End Sub

End Class