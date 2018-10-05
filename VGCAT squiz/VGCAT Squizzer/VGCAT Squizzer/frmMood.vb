Imports System
Imports System.IO
Imports System.Windows.Forms.Form

Public Class frmMood
    Dim intPointer As Integer

    Private Sub btnMood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMood.Click
        If bwTimer.IsBusy Then
        Else
            Dim fs As New FileStream(frmMain.Mood, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "  " & trbMood.Value)
            frmMain.pntLastMood = New Point(CInt((trbMood.Value * 5.27) + frmMain.xStart), frmMain.yStart)
            frmMain.ChangeDegree = trbMood.Value
            trbMood.Value = trbMood.Value
            pbxPointer.Visible = True
            sr.Close()
            lblMood.Focus()
            LabelHappy.Focus()
            Me.Hide()
        End If
    End Sub

    Private Sub bwTimer_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwTimer.DoWork

        Dim timeOut As DateTime = Now.AddMilliseconds(500)
        Do
            Application.DoEvents()
        Loop Until Now > timeOut
    End Sub


    Private Sub trbMood_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles trbMood.DragDrop
        trbMood.Value = intPointer
    End Sub

    Private Sub trbMood_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbMood.MouseDown

        Dim d As Integer = Math.Round(((e.X + 17) / ((trbMood.Size.Width - 34) / 100)) - 6)
         Select d
            Case Is < 0
                trbMood.Value = 0
            Case Is > 100
                trbMood.Value = 100
            Case Else
                trbMood.Value = d
        End Select
        intPointer = trbMood.Value
        'pbxPointer.Location() = New Point(CInt((intPointer * 5.27) + 373), 469)
    End Sub

    Private Sub trbMood_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbMood.MouseWheel
        trbMood.Value = intPointer
    End Sub

    Private Sub trbMood_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbMood.Scroll
        trbMood.Value = intPointer
    End Sub

    Private Sub frmMood_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        pbxPointer.Location() = frmMain.pntLastMood
        KeyPreview = True
        bwTimer.RunWorkerAsync()
        lblMood.Focus()
    End Sub

    Private Sub frmMood_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then
                End
            Else
            End If
        Else

            'goes up
            If e.KeyChar = "2" Then
                Select Case trbMood.Value
                    Case Is > 99
                        trbMood.Value = 100
                    Case Else
                        trbMood.Value = trbMood.Value + 1
                End Select
                intPointer = trbMood.Value
            Else

                'goes down
                If e.KeyChar = "1" Then
                    Select Case trbMood.Value
                        Case Is < 1
                            trbMood.Value = 0
                        Case Else
                            trbMood.Value = trbMood.Value - 1
                    End Select
                    intPointer = trbMood.Value
                End If
            End If
        End If

        'enter
        If e.KeyChar = "8" Then
            If bwTimer.IsBusy Then
            Else
                Dim fs As New FileStream(frmMain.Mood, FileMode.Append, FileAccess.Write)
                Dim sr As New StreamWriter(fs)
                sr.WriteLine(Now & "  " & trbMood.Value)
                'Label13.Text = Now & "  " & trbAnxious.Value
                frmMain.pntLastMood = New Point(CInt((trbMood.Value * 5.27) + frmMain.xStart), frmMain.yStart)
                pbxPointer.Location() = frmMain.pntLastMood
                frmMain.ChangeDegree = trbMood.Value
                trbMood.Value = trbMood.Value
                pbxPointer.Visible = True
                sr.Close()
                lblMood.Focus()
                LabelHappy.Focus()
                Me.Hide()
            End If
        End If
    End Sub




    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub lblMood_Click(sender As Object, e As EventArgs)
    End Sub
End Class