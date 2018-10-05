Imports System
Imports System.IO
Imports System.Windows.Forms.Form

Public Class frmSad
    Dim intPointer As Integer

   

    Private Sub bwTimer_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwTimer.DoWork

        Dim timeOut As DateTime = Now.AddMilliseconds(500)
        Do
            Application.DoEvents()
        Loop Until Now > timeOut

    End Sub


    Private Sub frmSad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set the screen to extended monitor
        Dim screen As Screen
        ' We want to display a form on screen 1
        Try
            screen = screen.AllScreens(1)
        Catch ex As Exception
            screen = screen.AllScreens(0)
        End Try

        ' Set the StartPosition to Manual otherwise the system will assign an automatic start position

        Me.StartPosition = FormStartPosition.Manual

        ' Set the form location so it appears at Location (100, 100) on the screen 1

        Me.Location = screen.Bounds.Location + New Point(0, 0)
        'end set screen
        'pbxPointer.Location() = frmMain.pntLastSad
        KeyPreview = True
        bwTimer.RunWorkerAsync()
        trbSad.Focus()

    End Sub

    Private Sub frmSad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then
                'if dispose needed, place here
                End
            Else
            End If
        Else
            If e.KeyChar = "2" Then
                Select Case trbSad.Value
                    Case Is > 99
                        trbSad.Value = 100
                    Case Else
                        trbSad.Value = trbSad.Value + 1
                End Select
                intPointer = trbSad.Value
            Else
                If e.KeyChar = "1" Then
                    Select Case trbSad.Value
                        Case Is < 1
                            trbSad.Value = 0
                        Case Else
                            trbSad.Value = trbSad.Value - 1
                    End Select
                    intPointer = trbSad.Value
                End If
            End If
        End If
        If e.KeyChar = "8" Then
            If bwTimer.IsBusy Then
            Else
                Dim fs As New FileStream(frmMain.Mood, FileMode.Append, FileAccess.Write)
                Dim sr As New StreamWriter(fs)
                sr.WriteLine(Now & " " & "Sad" & "  " & trbSad.Value)

              
                trbSad.Value = 50
                sr.Close()
                lblSad.Focus()
                LabelSad2.Focus()
                Me.Hide()
            End If
        End If
    End Sub
End Class
