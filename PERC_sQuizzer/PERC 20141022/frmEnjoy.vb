Imports System
Imports System.IO
Imports System.Windows.Forms.Form

Public Class frmEnjoy
    Dim intPointer As Integer

    Private Sub btnEnjoy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnjoy.Click
        If bwTimer.IsBusy Then
        Else
            Dim fs As New FileStream(frmMain.Enjoy, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "  " & trbEnjoy.Value)
            'Label13.Text = Now & "  " & trbEnjoy.Value
            frmMain.pntLastEnjoy = New Point(CInt((trbEnjoy.Value * 5.27) + frmMain.xStart), frmMain.yStart)
            trbEnjoy.Value = trbEnjoy.Value
            pbxPointer.Visible = True
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

    Private Sub trbOne_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles trbEnjoy.DragDrop
        trbEnjoy.Value = intPointer
    End Sub

    Private Sub trbEnjoy_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbEnjoy.MouseDown

        Dim d As Integer = Math.Round(((e.X + 17) / ((trbEnjoy.Size.Width - 34) / 100)) - 6)
        Select Case d
            Case Is < 0
                trbEnjoy.Value = 0
            Case Is > 100
                trbEnjoy.Value = 100
            Case Else
                trbEnjoy.Value = d
        End Select
        intPointer = trbEnjoy.Value
        'pbxPointer.Location() = New Point(CInt((intPointer * 5.27) + 373), 469)

    End Sub

    Private Sub trbEnjoy_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbEnjoy.MouseWheel
        trbEnjoy.Value = intPointer
    End Sub

    Private Sub trbEnjoy_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbEnjoy.Scroll
        trbEnjoy.Value = intPointer
    End Sub

    Private Sub frmEnjoy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        pbxPointer.Location() = frmMain.pntLastEnjoy
        KeyPreview = True
        bwTimer.RunWorkerAsync()
        lblCrave.Focus()

    End Sub

    Private Sub frmEnjoy_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then
                End
            Else
            End If
        Else
            If e.KeyChar = "2" Then
                Select Case trbEnjoy.Value
                    Case Is > 99
                        trbEnjoy.Value = 100
                    Case Else
                        trbEnjoy.Value = trbEnjoy.Value + 1
                End Select
                intPointer = trbEnjoy.Value
            Else
                If e.KeyChar = "1" Then
                    Select Case trbEnjoy.Value
                        Case Is < 1
                            trbEnjoy.Value = 0
                        Case Else
                            trbEnjoy.Value = trbEnjoy.Value - 1
                    End Select
                    intPointer = trbEnjoy.Value
                End If
            End If
        End If
        If e.KeyChar = "8" Then
            If bwTimer.IsBusy Then
            Else
                Dim fs As New FileStream(frmMain.Enjoy, FileMode.Append, FileAccess.Write)
                Dim sr As New StreamWriter(fs)
                sr.WriteLine(Now & "  " & trbEnjoy.Value)
                'Label13.Text = Now & "  " & trbEnjoy.Value
                frmMain.pntLastEnjoy = New Point(CInt((trbEnjoy.Value * 5.27) + frmMain.xStart), frmMain.yStart)
                'trbEnjoy.Value = trbEnjoy.Value
                pbxPointer.Visible = True
                sr.Close()
                lblCrave.Focus()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub frmEnjoy_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
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