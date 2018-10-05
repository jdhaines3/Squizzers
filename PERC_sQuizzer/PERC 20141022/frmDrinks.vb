Imports System
Imports System.IO

Public Class frmDrinks

    Private Sub btnDrinks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrinks.Click
        If bwTimer.IsBusy Then
        Else
            Dim fs As New FileStream(frmMain.Drinks, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "  " & Number.Text)
            'Label13.Text = Now & "  " & trbHigh.Value
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

    Private Sub frmDrinks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        KeyPreview = True
        bwTimer.RunWorkerAsync()
        lblCrave.Focus()

    End Sub
    Private Sub frmDrinks_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit GPRA Quizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit GRPA Quizzer?")
            If response = MsgBoxResult.Yes Then
                End
            Else
            End If
        End If

        If e.KeyChar = " " Then
        End If

        If e.KeyChar = "2" Then
            Select Case Number.Text
                Case Is > 99.5
                    Number.Text = 100
                Case Else
                    Number.Text = Number.Text + 0.5
            End Select
        Else
            If e.KeyChar = "1" Then
                Select Case Number.Text
                    Case Is <= 0

                    Case Else
                        Number.Text = Number.Text - 0.5
                End Select
            End If
        End If
        If e.KeyChar = "8" Then
            If bwTimer.IsBusy Then
            Else
                Dim fs As New FileStream(frmMain.Drinks, FileMode.Append, FileAccess.Write)
                Dim sr As New StreamWriter(fs)
                sr.WriteLine(Now & "  " & Number.Text)
                'Label13.Text = Now & "  " & trbAnxious.Value
                sr.Close()
                lblCrave.Focus()
                Me.Hide()
            End If
        End If


    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        If (Number.Text <= 0) Then
        Else
            Number.Text = Number.Text - 0.5
        End If
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        If (Number.Text >= 99) Then
        Else
            Number.Text = Number.Text + 0.5
        End If
    End Sub
    Private Sub frmDrinks_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
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