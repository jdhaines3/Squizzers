Imports System
Imports System.IO
Imports System.Windows.Forms.Form

Public Class frmStim
    Dim intPointer As Integer

    Private Sub btnStim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStim.Click
        If bwTimer.IsBusy Then
        Else
            Dim fs As New FileStream(frmMain.Stim, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "  " & trbStim.Value)
            'Label13.Text = Now & "  " & trbStim.Value
            frmMain.pntLastStim = New Point(CInt((trbStim.Value * 5.27) + frmMain.xStart), frmMain.yStart)
            trbStim.Value = trbStim.Value
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

    Private Sub trbOne_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles trbStim.DragDrop
        trbStim.Value = intPointer
    End Sub

    Private Sub trbStim_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbStim.MouseDown

        Dim d As Integer = Math.Round(((e.X + 17) / ((trbStim.Size.Width - 34) / 100)) - 6)
        Select Case d
            Case Is < 0
                trbStim.Value = 0
            Case Is > 100
                trbStim.Value = 100
            Case Else
                trbStim.Value = d
        End Select
        intPointer = trbStim.Value
        'pbxPointer.Location() = New Point(CInt((intPointer * 5.27) + 373), 469)

    End Sub

    Private Sub trbStim_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbStim.MouseWheel
        trbStim.Value = intPointer
    End Sub

    Private Sub trbStim_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbStim.Scroll
        trbStim.Value = intPointer
    End Sub

    Private Sub frmStim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        pbxPointer.Location() = frmMain.pntLastStim
        KeyPreview = True
        bwTimer.RunWorkerAsync()
        lblCrave.Focus()

    End Sub

    Private Sub frmStim_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then
                End
            Else
            End If
        Else
            If e.KeyChar = "2" Then
                Select Case trbStim.Value
                    Case Is > 99
                        trbStim.Value = 100
                    Case Else
                        trbStim.Value = trbStim.Value + 1
                End Select
                intPointer = trbStim.Value
            Else
                If e.KeyChar = "1" Then
                    Select Case trbStim.Value
                        Case Is < 1
                            trbStim.Value = 0
                        Case Else
                            trbStim.Value = trbStim.Value - 1
                    End Select
                    intPointer = trbStim.Value
                End If
            End If
        End If
        If e.KeyChar = "8" Then
            If bwTimer.IsBusy Then
            Else
                Dim fs As New FileStream(frmMain.Stim, FileMode.Append, FileAccess.Write)
                Dim sr As New StreamWriter(fs)
                sr.WriteLine(Now & "  " & trbStim.Value)
                'Label13.Text = Now & "  " & trbStim.Value
                frmMain.pntLastStim = New Point(CInt((trbStim.Value * 5.27) + frmMain.xStart), frmMain.yStart)
                trbStim.Value = trbStim.Value
                pbxPointer.Visible = True
                sr.Close()
                lblCrave.Focus()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub frmStim_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
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