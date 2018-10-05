Imports System
Imports System.IO
Imports System.Windows.Forms.Form

Public Class frmTired
    Dim intPointer As Integer

    Private Sub btnTired_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTired.Click
        If bwTimer.IsBusy Then
        Else
            Dim fs As New FileStream(frmMain.Tired, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "  " & trbTired.Value)
            'Label13.Text = Now & "  " & trbStim.Value
            frmMain.pntLastTired = New Point(CInt((trbTired.Value * 5.27) + frmMain.xStart), frmMain.yStart)
            trbTired.Value = trbTired.Value
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

    Private Sub trbOne_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles trbTired.DragDrop
        trbTired.Value = intPointer
    End Sub

    Private Sub trbTired_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbTired.MouseDown

        Dim d As Integer = Math.Round(((e.X + 17) / ((trbTired.Size.Width - 34) / 100)) - 6)
        Select Case d
            Case Is < 0
                trbTired.Value = 0
            Case Is > 100
                trbTired.Value = 100
            Case Else
                trbTired.Value = d
        End Select
        intPointer = trbTired.Value
        'pbxPointer.Location() = New Point(CInt((intPointer * 5.27) + 373), 469)

    End Sub

    Private Sub trbTired_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbTired.MouseWheel
        trbTired.Value = intPointer
    End Sub

    Private Sub trbTired_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbTired.Scroll
        trbTired.Value = intPointer
    End Sub

    Private Sub frmTired_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        pbxPointer.Location() = frmMain.pntLastTired
        KeyPreview = True
        bwTimer.RunWorkerAsync()
        lblCrave.Focus()

    End Sub

    Private Sub frmTired_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then
                End
            Else
            End If
        Else
            If e.KeyChar = "2" Then
                Select Case trbTired.Value
                    Case Is > 99
                        trbTired.Value = 100
                    Case Else
                        trbTired.Value = trbTired.Value + 1
                End Select
                intPointer = trbTired.Value
            Else
                If e.KeyChar = "1" Then
                    Select Case trbTired.Value
                        Case Is < 1
                            trbTired.Value = 0
                        Case Else
                            trbTired.Value = trbTired.Value - 1
                    End Select
                    intPointer = trbTired.Value
                End If
            End If
        End If
        If e.KeyChar = "8" Then
            If bwTimer.IsBusy Then
            Else
                Dim fs As New FileStream(frmMain.Tired, FileMode.Append, FileAccess.Write)
                Dim sr As New StreamWriter(fs)
                sr.WriteLine(Now & "  " & trbTired.Value)
                'Label13.Text = Now & "  " & trbTired.Value
                frmMain.pntLastTired = New Point(CInt((trbTired.Value * 5.27) + frmMain.xStart), frmMain.yStart)
                trbTired.Value = trbTired.Value
                pbxPointer.Visible = True
                sr.Close()
                lblCrave.Focus()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub frmTired_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
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