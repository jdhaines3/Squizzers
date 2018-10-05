Imports System
Imports System.IO
Imports System.Windows.Forms.Form

Public Class frmPerfect
    Dim intPointer As Integer

    Private Sub btnPerfect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerfect.Click
        If bwTimer.IsBusy Then
        Else
            Dim fs As New FileStream(frmMain.Perfect, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "  " & trbPerfect.Value)
            'Label13.Text = Now & "  " & trbFour.Value
            frmMain.pntLastPerfect = New Point(CInt((trbPerfect.Value * 5.27) + frmMain.xStart), frmMain.yStart)
            trbPerfect.Value = 50
            pbxPointer.Visible = False
            sr.Close()
            lblCrave.Focus()
            Me.Hide()
        End If
    End Sub
    Private Sub bwTimer_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwTimer.DoWork

        Dim timeOut As DateTime = Now.AddMilliseconds(500)
        Do
            Application.DoEvents()
        Loop Until Now > timeOut

    End Sub

    Private Sub trbPerfect_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles trbPerfect.DragDrop
        trbPerfect.Value = intPointer
    End Sub

    Private Sub trbPerfect_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbPerfect.MouseDown

        Dim d As Integer = Math.Round(((e.X + 17) / ((trbPerfect.Size.Width - 34) / 100)) - 6)
        Select Case d
            Case Is < 0
                trbPerfect.Value = 0
            Case Is > 100
                trbPerfect.Value = 100
            Case Else
                trbPerfect.Value = d
        End Select
        intPointer = trbPerfect.Value
        'pbxPointer.Location() = New Point(CInt((intPointer * 5.27) + 373), 469)

    End Sub

    Private Sub trbPerfect_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbPerfect.MouseWheel
        trbPerfect.Value = intPointer
    End Sub

    Private Sub trbPerfect_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbPerfect.Scroll
        trbPerfect.Value = intPointer
    End Sub

    Private Sub frmPerfect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        pbxPointer.Location() = frmMain.pntLastPerfect
        KeyPreview = True
        bwTimer.RunWorkerAsync()
        lblCrave.Focus()

    End Sub

    Private Sub frmPerfect_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then
                End
            Else
            End If
        Else
            If e.KeyChar = "2" Then
                Select Case trbPerfect.Value
                    Case Is > 99
                        trbPerfect.Value = 100
                    Case Else
                        trbPerfect.Value = trbPerfect.Value + 1
                End Select
                intPointer = trbPerfect.Value
            Else
                If e.KeyChar = "1" Then
                    Select Case trbPerfect.Value
                        Case Is < 1
                            trbPerfect.Value = 0
                        Case Else
                            trbPerfect.Value = trbPerfect.Value - 1
                    End Select
                    intPointer = trbPerfect.Value
                End If
            End If
        End If
        If e.KeyChar = "8" Then
            If bwTimer.IsBusy Then
            Else
                Dim fs As New FileStream(frmMain.Perfect, FileMode.Append, FileAccess.Write)
                Dim sr As New StreamWriter(fs)
                sr.WriteLine(Now & "  " & trbPerfect.Value)
                'Label13.Text = Now & "  " & trbAnxious.Value
                frmMain.pntLastPerfect = New Point(CInt((trbPerfect.Value * 5.27) + frmMain.xStart), frmMain.yStart)
                trbPerfect.Value = 50
                pbxPointer.Visible = False
                sr.Close()
                lblCrave.Focus()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub frmPerfect_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
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