Imports System
Imports System.IO
Imports System.Windows.Forms.Form

Public Class frmFrustration
    Dim intPointer As Integer

    Private Sub btnFrustration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrustration.Click
        'KAW 8.4.2010
        'quick naming fix from Frustration.txt to Frustrated.txt to accomodate new mod of sQuizzer by SOC
        'eventually this should be completely renamed to frmFrustrated from frmFrustration but do to time it was not done here

        If bwTimer.IsBusy Then
        Else
            Dim fs As New FileStream(frmMain.Frustration, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "  " & trbFrustration.Value)
            frmMain.pntLastFrustration = New Point(CInt((trbFrustration.Value * 5.27) + frmMain.xStart), frmMain.yStart)
            trbFrustration.Value = trbFrustration.Value
            pbxPointer.Visible = True
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

    Private Sub trbFrustration_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles trbFrustration.DragDrop
        trbFrustration.Value = intPointer
    End Sub

    Private Sub trbFrustration_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbFrustration.MouseDown

        Dim d As Integer = Math.Round(((e.X + 17) / ((trbFrustration.Size.Width - 34) / 100)) - 6)
        Select Case d
            Case Is < 0
                trbFrustration.Value = 0
            Case Is > 100
                trbFrustration.Value = 100
            Case Else
                trbFrustration.Value = d
        End Select
        intPointer = trbFrustration.Value
        'pbxPointer.Location() = New Point(CInt((intPointer * 5.27) + 373), 469)
    End Sub

    Private Sub trbFrustration_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbFrustration.MouseWheel
        trbFrustration.Value = intPointer
    End Sub

    Private Sub trbFrustration_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbFrustration.Scroll
        trbFrustration.Value = intPointer
    End Sub

    Private Sub frmFrustration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        pbxPointer.Location() = frmMain.pntLastFrustration
        KeyPreview = True
        bwTimer.RunWorkerAsync()
        'If frmMain.ChangeDegree = 50 Then
        'lblChangeDegree.Text = "not change"
        'ElseIf frmMain.ChangeDegree > 50 Then
        'If frmMain.ChangeDegree < 75 Then
        'lblChangeDegree.Text = "slightly increase"
        'ElseIf frmMain.ChangeDegree < 95 Then
        'lblChangeDegree.Text = "moderately increase"
        'Else : lblChangeDegree.Text = "significantly increase"
        'End If
        'ElseIf frmMain.ChangeDegree < 50 Then
        'If frmMain.ChangeDegree > 25 Then
        'lblChangeDegree.Text = "slightly decrease"
        'ElseIf frmMain.ChangeDegree > 5 Then
        'lblChangeDegree.Text = "moderately decrease"
        'Else : lblChangeDegree.Text = "significantly decrease"
        'End If
        'Else : lblChangeDegree.Text = "error"
        'End If

        LblStim.Focus()

    End Sub

    Private Sub frmFrustration_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then
                End
            Else
            End If
        Else
            If e.KeyChar = "2" Then
                Select Case trbFrustration.Value
                    Case Is > 99
                        trbFrustration.Value = 100
                    Case Else
                        trbFrustration.Value = trbFrustration.Value + 1
                End Select
                intPointer = trbFrustration.Value
            Else
                If e.KeyChar = "1" Then
                    Select Case trbFrustration.Value
                        Case Is < 1
                            trbFrustration.Value = 0
                        Case Else
                            trbFrustration.Value = trbFrustration.Value - 1
                    End Select
                    intPointer = trbFrustration.Value
                End If
            End If
        End If
        If e.KeyChar = "8" Then
            If bwTimer.IsBusy Then
            Else
                Dim fs As New FileStream(frmMain.Frustration, FileMode.Append, FileAccess.Write)
                Dim sr As New StreamWriter(fs)
                sr.WriteLine(Now & "  " & trbFrustration.Value)
                'Label13.Text = Now & "  " & trbCrave.Value
                frmMain.pntLastFrustration = New Point(CInt((trbFrustration.Value * 5.27) + frmMain.xStart), frmMain.yStart)
                sr.Close()
                lblStim.Focus()
                trbFrustration.Value = trbFrustration.Value
                pbxPointer.Visible = True
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub frmFrustration_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
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
