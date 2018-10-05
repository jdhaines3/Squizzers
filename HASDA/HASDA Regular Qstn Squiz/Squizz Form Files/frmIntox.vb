Imports System
Imports System.IO

'==========================================='
'-----Check frmAnxious for all comments-----'
'==========================================='


Public Class frmIntox
    Dim intPointer As Integer

    Dim path, subj, cbx As String


    Private Sub frmIntox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set the screen to extended monitor
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

        If frmMain.pntLastIntox.IsEmpty Then

            pbxPointer.Visible = False
        Else

            pbxPointer.Visible = True
            pbxPointer.Location() = frmMain.pntLastIntox

        End If

        KeyPreview = True

        lblCrave.Focus()

        cbx = frmMain.cbxSess.SelectedItem
        subj = frmMain.txtSubj.Text
        path = "C:\x\" & subj & "\" & subj & cbx & "_Intox.txt"

    End Sub

    Private Sub frmIntox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then

                frmMain.cleanseEverything()

            Else
            End If
        ElseIf e.KeyChar = "2" Then
            Select Case trbIntox.Value
                Case Is > 99
                    trbIntox.Value = 100
                Case Else
                    trbIntox.Value = trbIntox.Value + 1
            End Select
            intPointer = trbIntox.Value
        ElseIf e.KeyChar = "1" Then
            Select Case trbIntox.Value
                Case Is < 1
                    trbIntox.Value = 0
                Case Else
                    trbIntox.Value = trbIntox.Value - 1
            End Select
            intPointer = trbIntox.Value
        ElseIf e.KeyChar = "8" Then

            Dim fs As New FileStream(path, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "," & trbIntox.Value)
            sr.Close()
            fs.Close()

            frmMain.pntLastIntox = New Point(CInt((trbIntox.Value * 5.27) + frmMain.xStart), frmMain.yStart)
            trbIntox.Value = trbIntox.Value
            pbxPointer.Visible = True
            lblCrave.Focus()
            Me.Hide()

        End If
    End Sub


End Class