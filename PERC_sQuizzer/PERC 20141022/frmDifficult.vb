Imports System
Imports System.IO
Imports System.Windows.Forms.Form

Public Class frmDifficult
    Dim intPointer As Integer

    Private Sub btnDifficult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDifficult.Click
        If bwTimer.IsBusy Then
        Else
            Dim fs As New FileStream(frmMain.Difficult, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "  " & trbDifficult.Value)
            'Label13.Text = Now & "  " & trbStim.Value
            frmMain.pntLastDifficult = New Point(CInt((trbDifficult.Value * 5.27) + frmMain.xStart), frmMain.yStart)
            trbDifficult.Value = 50
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

    Private Sub trbOne_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles trbDifficult.DragDrop
        trbDifficult.Value = intPointer
    End Sub

    Private Sub trbDifficult_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbDifficult.MouseDown

        Dim d As Integer = Math.Round(((e.X + 17) / ((trbDifficult.Size.Width - 34) / 100)) - 6)
        Select Case d
            Case Is < 0
                trbDifficult.Value = 0
            Case Is > 100
                trbDifficult.Value = 100
            Case Else
                trbDifficult.Value = d
        End Select
        intPointer = trbDifficult.Value
        'pbxPointer.Location() = New Point(CInt((intPointer * 5.27) + 373), 469)

    End Sub

    Private Sub trbDifficult_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbDifficult.MouseWheel
        trbDifficult.Value = intPointer
    End Sub

    Private Sub trbDifficult_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbDifficult.Scroll
        trbDifficult.Value = intPointer
    End Sub

    Private Sub frmDifficult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        pbxPointer.Location() = frmMain.pntLastDifficult
        KeyPreview = True
        bwTimer.RunWorkerAsync()
        lblCrave.Focus()

    End Sub

    Private Sub frmDifficult_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then
                End
            Else
            End If
        Else
            If e.KeyChar = "2" Then
                Select Case trbDifficult.Value
                    Case Is > 99
                        trbDifficult.Value = 100
                    Case Else
                        trbDifficult.Value = trbDifficult.Value + 1
                End Select
                intPointer = trbDifficult.Value
            Else
                If e.KeyChar = "1" Then
                    Select Case trbDifficult.Value
                        Case Is < 1
                            trbDifficult.Value = 0
                        Case Else
                            trbDifficult.Value = trbDifficult.Value - 1
                    End Select
                    intPointer = trbDifficult.Value
                End If
            End If
        End If
        If e.KeyChar = "8" Then
            If bwTimer.IsBusy Then
            Else
                Dim fs As New FileStream(frmMain.Difficult, FileMode.Append, FileAccess.Write)
                Dim sr As New StreamWriter(fs)
                sr.WriteLine(Now & "  " & trbDifficult.Value)
                'Label13.Text = Now & "  " & trbAnxious.Value
                frmMain.pntLastDifficult = New Point(CInt((trbDifficult.Value * 5.27) + frmMain.xStart), frmMain.yStart)
                trbDifficult.Value = 50
                pbxPointer.Visible = False
                sr.Close()
                lblCrave.Focus()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub frmDifficult_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
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