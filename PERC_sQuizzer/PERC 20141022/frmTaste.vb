Imports System
Imports System.IO

Public Class frmTaste
    Dim intPointer As Integer

    Private Sub btnTaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaste.Click
        If bwTimer.IsBusy Then
        Else
            Dim fs As New FileStream(frmMain.Taste, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "  " & trbTaste.Value)
            frmMain.pntLastTaste = New Point(CInt((trbTaste.Value * 5.27) + frmMain.xStart), frmMain.yStart)
            trbTaste.Value = 50
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

    Private Sub trbTaste_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles trbTaste.DragDrop
        trbTaste.Value = intPointer
    End Sub

    Private Sub trbTaste_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbTaste.MouseDown

        Dim d As Integer = Math.Round(((e.X + 17) / ((trbTaste.Size.Width - 34) / 100)) - 6)
        Select Case d
            Case Is < 0
                trbTaste.Value = 0
            Case Is > 100
                trbTaste.Value = 100
            Case Else
                trbTaste.Value = d
        End Select
        intPointer = trbTaste.Value
        'Label13.Text = CStr(CInt((intPointer * 5.27) + 400))
        'pbxPointer.Location() = New Point(CInt((intPointer * 5.27) + 373), 469)

    End Sub

    Private Sub trbTaste_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbTaste.MouseWheel
        trbTaste.Value = intPointer
    End Sub

    Private Sub trbTaste_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbTaste.Scroll
        trbTaste.Value = intPointer
    End Sub

    Private Sub frmTaste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        pbxPointer.Location() = frmMain.pntLastTaste
        KeyPreview = True
        bwTimer.RunWorkerAsync()
        lblCrave.Focus()

    End Sub

    Private Sub frmTaste_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
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
                Select Case trbTaste.Value
                    Case Is > 99
                        trbTaste.Value = 100
                    Case Else
                        trbTaste.Value = trbTaste.Value + 1
                End Select
                intPointer = trbTaste.Value
            Else

                'goes down
                If e.KeyChar = "1" Then
                    Select Case trbTaste.Value
                        Case Is < 1
                            trbTaste.Value = 0
                        Case Else
                            trbTaste.Value = trbTaste.Value - 1
                    End Select
                    intPointer = trbTaste.Value
                End If
            End If
        End If

        'enter
        If e.KeyChar = "8" Then
            If bwTimer.IsBusy Then
            Else
                Dim fs As New FileStream(frmMain.Taste, FileMode.Append, FileAccess.Write)
                Dim sr As New StreamWriter(fs)
                sr.WriteLine(Now & "  " & trbTaste.Value)
                'Label13.Text = Now & "  " & trbAnxious.Value
                frmMain.pntLastTaste = New Point(CInt((trbTaste.Value * 5.27) + frmMain.xStart), frmMain.yStart)
                trbTaste.Value = 50
                pbxPointer.Visible = False
                sr.Close()
                lblCrave.Focus()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub frmTaste_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
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