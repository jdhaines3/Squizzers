Imports System
Imports System.IO
Imports System.Windows.Forms.Form

Public Class frmAnxious
    Dim intPointer As Integer

    Private Sub btnAnxious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnxious.Click
        If bwTimer.IsBusy Then
        Else
            Dim fs As New FileStream(frmMain.Anxious, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "  " & trbAnxious.Value)
            frmMain.pntLastAnxious = New Point(CInt((trbAnxious.Value * 5.27) + frmMain.xStart), frmMain.yStart)
            trbAnxious.Value = trbAnxious.Value
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


    Private Sub trbAnxious_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles trbAnxious.DragDrop
        trbAnxious.Value = intPointer
    End Sub

    Private Sub trbAnxious_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbAnxious.MouseDown

        Dim d As Integer = Math.Round(((e.X + 17) / ((trbAnxious.Size.Width - 34) / 100)) - 6)
        Select Case d
            Case Is < 0
                trbAnxious.Value = 0
            Case Is > 100
                trbAnxious.Value = 100
            Case Else
                trbAnxious.Value = d
        End Select
        intPointer = trbAnxious.Value
        'pbxPointer.Location() = New Point(CInt((intPointer * 5.27) + 373), 469)
    End Sub

    Private Sub trbAnxious_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trbAnxious.MouseWheel
        trbAnxious.Value = intPointer
    End Sub

    Private Sub trbAnxious_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbAnxious.Scroll
        trbAnxious.Value = intPointer
    End Sub

    Private Sub frmAnxious_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbxPointer.Location() = frmMain.pntLastAnxious
        KeyPreview = True
        bwTimer.RunWorkerAsync()
        lblCrave.Focus()
    End Sub

    Private Sub frmAnxious_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
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
                Select Case trbAnxious.Value
                    Case Is > 99
                        trbAnxious.Value = 100
                    Case Else
                        trbAnxious.Value = trbAnxious.Value + 1
                End Select
                intPointer = trbAnxious.Value
            Else

                'goes down
                If e.KeyChar = "1" Then
                    Select Case trbAnxious.Value
                        Case Is < 1
                            trbAnxious.Value = 0
                        Case Else
                            trbAnxious.Value = trbAnxious.Value - 1
                    End Select
                    intPointer = trbAnxious.Value
                End If
            End If
        End If

        'enter
        If e.KeyChar = "8" Then
            If bwTimer.IsBusy Then
            Else
                Dim fs As New FileStream(frmMain.Anxious, FileMode.Append, FileAccess.Write)
                Dim sr As New StreamWriter(fs)
                sr.WriteLine(Now & "  " & trbAnxious.Value)
                'Label13.Text = Now & "  " & trbAnxious.Value
                frmMain.pntLastAnxious = New Point(CInt((trbAnxious.Value * 5.27) + frmMain.xStart), frmMain.yStart)
                trbAnxious.Value = trbAnxious.Value
                pbxPointer.Visible = True
                sr.Close()
                lblCrave.Focus()
                Me.Hide()
            End If
        End If
    End Sub




    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class