Imports System
Imports System.IO
Imports System.Windows.Forms.Form

Public Class frmChange
    Dim intPointer As Integer

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click

        If bwTimer.IsBusy Then
        Else
            Dim fs As New FileStream(frmMain.Change, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "  " & trbChange.Value)
            'Label13.Text = Now & "  " & trbHigh.Value
            frmMain.pntLastChange = New Point(CInt((trbChange.Value * 5.27) + frmMain.xStart), frmMain.yStart)
            frmMain.ChangeDegree = trbChange.Value
            trbChange.Value = 50
            pbxPointer.Visible = False
            sr.Close()
            lblStim.Focus()
            Me.Hide()
        End If
    End Sub

    Private Sub bwTimer_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwTimer.DoWork

        Dim timeOut As DateTime = Now.AddMilliseconds(500)
        Do
            Application.DoEvents()
        Loop Until Now > timeOut

    End Sub

    Private Sub trbChange_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles trbChange.DragDrop, trbChange.DragDrop
        trbChange.Value = intPointer
    End Sub

    Private Sub trbChange_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbChange.MouseDown

        Dim d As Integer = Math.Round(((e.X + 17) / ((trbChange.Size.Width - 34) / 100)) - 6)
        Select Case d
            Case Is < 0
                trbChange.Value = 0
            Case Is > 100
                trbChange.Value = 100
            Case Else
                trbChange.Value = d
        End Select
        intPointer = trbChange.Value
        'pbxPointer.Location() = New Point(CInt((intPointer * 5.27) + 373), 469)

    End Sub

    Private Sub trbChange_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbChange.MouseWheel
        trbChange.Value = intPointer
    End Sub

    Private Sub trbChange_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbChange.Scroll
        trbChange.Value = intPointer
    End Sub

    Private Sub frmChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        pbxPointer.Location() = frmMain.pntLastChange
        KeyPreview = True
        bwTimer.RunWorkerAsync()
        trbChange.Focus()

    End Sub

    Private Sub frmChange_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then
                End
            Else
            End If
        Else
            If e.KeyChar = "2" Then
                Select Case trbChange.Value
                    Case Is > 99
                        trbChange.Value = 100
                    Case Else
                        trbChange.Value = trbChange.Value + 1
                End Select
                intPointer = trbChange.Value
            Else
                If e.KeyChar = "1" Then
                    Select Case trbChange.Value
                        Case Is < 1
                            trbChange.Value = 0
                        Case Else
                            trbChange.Value = trbChange.Value - 1
                    End Select
                    intPointer = trbChange.Value
                End If
            End If
        End If
        If e.KeyChar = "8" Then
            If bwTimer.IsBusy Then
            Else
                Dim fs As New FileStream(frmMain.Change, FileMode.Append, FileAccess.Write)
                Dim sr As New StreamWriter(fs)
                sr.WriteLine(Now & "  " & trbChange.Value)
                'Label13.Text = Now & "  " & trbChange.Value

                frmMain.pntLastChange = New Point(CInt((trbChange.Value * 5.27) + frmMain.xStart), frmMain.yStart)
                frmMain.ChangeDegree = trbChange.Value
                trbChange.Value = 50
                pbxPointer.Visible = False
                sr.Close()
                lblStim.Focus()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub frmChange_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'Dim LocalMousePosition As Point
        'Dim myScreens() As Screen = Screen.AllScreens
        'Dim objPoint As Point = PointToScreen(New Point(0, 0))

        'If (myScreens.Length = 2) Then
        'LocalMousePosition = PointToClient(Cursor.Position)
        'If LocalMousePosition.X() < 1285 Then
        'objPoint.X += 0
        'objPoint.Y += LocalMousePosition.Y()
        'Cursor.Position = objPoint
        '    Else
        'end if
        'End If

    End Sub

End Class