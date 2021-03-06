Imports System
Imports System.IO
Imports System.Windows.Forms.Form

'==========================================='
'-----Check frmAnxious for all comments-----'
'==========================================='


Public Class frmDislike
    Dim intPointer As Integer

    Dim path, subj, cbx As String


    Private Sub frmDislike_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        If frmMain.pntLastDislike.IsEmpty Then

            pbxPointer.Visible = False
        Else

            pbxPointer.Visible = True
            pbxPointer.Location() = frmMain.pntLastDislike

        End If

        KeyPreview = True

        lblCrave.Focus()

        cbx = frmMain.cbxSess.SelectedItem
        subj = frmMain.txtSubj.Text
        path = "C:\x\" & subj & "\" & subj & cbx & "_Dislike.txt"

    End Sub

    Private Sub frmDislike_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then

                frmMain.cleanseEverything()

            Else
            End If
        ElseIf e.KeyChar = "2" Then
            Select Case trbDislike.Value
                Case Is > 99
                    trbDislike.Value = 100
                Case Else
                    trbDislike.Value = trbDislike.Value + 1
            End Select
            intPointer = trbDislike.Value
        ElseIf e.KeyChar = "1" Then
            Select Case trbDislike.Value
                Case Is < 1
                    trbDislike.Value = 0
                Case Else
                    trbDislike.Value = trbDislike.Value - 1
            End Select
            intPointer = trbDislike.Value
        ElseIf e.KeyChar = "8" Then

            Dim fs As New FileStream(path, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "," & trbDislike.Value)
            sr.Close()
            fs.Close()

            frmMain.pntLastDislike = New Point(CInt((trbDislike.Value * 5.27) + frmMain.xStart), frmMain.yStart)
            trbDislike.Value = trbDislike.Value
            pbxPointer.Visible = True
            lblCrave.Focus()
            Me.Hide()

        End If
    End Sub


End Class