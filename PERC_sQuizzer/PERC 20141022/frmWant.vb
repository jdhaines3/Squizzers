Imports System
Imports System.IO
Imports System.Windows.Forms.Form

Public Class frmWant
    Dim intPointer As Integer

    Private Sub btnWant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWant.Click
        If bwTimer.IsBusy Then
        Else
            Dim fs As New FileStream(frmMain.Want, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "  " & trbWant.Value)
            frmMain.pntLastWant = New Point(CInt((trbWant.Value * 5.27) + frmMain.xStart), frmMain.yStart)
            trbWant.Value = 50
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


    Private Sub trbWant_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles trbWant.DragDrop
        trbWant.Value = intPointer
    End Sub

    Private Sub trbWant_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbWant.MouseDown

        Dim d As Integer = Math.Round(((e.X + 17) / ((trbWant.Size.Width - 34) / 100)) - 6)
        Select Case d
            Case Is < 0
                trbWant.Value = 0
            Case Is > 100
                trbWant.Value = 100
            Case Else
                trbWant.Value = d
        End Select
        intPointer = trbWant.Value
        'pbxPointer.Location() = New Point(CInt((intPointer * 5.27) + 373), 469)
    End Sub

    Private Sub trbWant_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbWant.MouseWheel
        trbWant.Value = intPointer
    End Sub

    Private Sub trbWant_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbWant.Scroll
        trbWant.Value = intPointer
    End Sub

    Private Sub frmWant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        pbxPointer.Location() = frmMain.pntLastWant
        KeyPreview = True
        bwTimer.RunWorkerAsync()
        lblCrave.Focus()
    End Sub

    Private Sub frmWant_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
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
                Select Case trbWant.Value
                    Case Is > 99
                        trbWant.Value = 100
                    Case Else
                        trbWant.Value = trbWant.Value + 1
                End Select
                intPointer = trbWant.Value
            Else

                'goes down
                If e.KeyChar = "1" Then
                    Select Case trbWant.Value
                        Case Is < 1
                            trbWant.Value = 0
                        Case Else
                            trbWant.Value = trbWant.Value - 1
                    End Select
                    intPointer = trbWant.Value
                End If
            End If
        End If

        'enter
        If e.KeyChar = "8" Then
            If bwTimer.IsBusy Then
            Else
                Dim fs As New FileStream(frmMain.Want, FileMode.Append, FileAccess.Write)
                Dim sr As New StreamWriter(fs)
                sr.WriteLine(Now & "  " & trbWant.Value)
                'Label13.Text = Now & "  " & trbWant.Value
                frmMain.pntLastWant = New Point(CInt((trbWant.Value * 5.27) + frmMain.xStart), frmMain.yStart)
                trbWant.Value = 50
                pbxPointer.Visible = False
                sr.Close()
                lblCrave.Focus()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub frmWant_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

    End Sub


    Private Sub frmWant_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        'Dim LocalMousePosition As Point
        'Dim myScreens() As Screen = Screen.AllScreens
        'Dim objPoint As Point = PointToScreen(New Point(0, 0))

        'If (myScreens.Length = 2) Then
        'LocalMousePosition = PointToClient(Cursor.Position)
        'objPoint.X += 0
        'objPoint.Y += LocalMousePosition.Y()
        'Cursor.Position = objPoint
        '    Else

        'End If
    End Sub
End Class