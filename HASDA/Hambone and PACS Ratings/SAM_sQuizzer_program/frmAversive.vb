Imports System
Imports System.IO
Imports System.Windows.Forms.Form

Public Class frmAversive
    Dim intPointer As Integer

    Dim subID, cbx, path As String


    Private Sub frmAversive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        lblAversive.Focus()

        cbx = frmMain.cbxSess.SelectedItem
        subID = frmMain.txtSubj.Text
        path = "C:\x\" & subID & "\" & subID & cbx & "_Aversive.txt"

    End Sub

    Private Sub frmAversive_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then

                frmMain.cleanseEverything()

            Else
            End If
        Else
            If e.KeyChar = "2" Then
                Select Case trbAversive.Value
                    Case Is > 99
                        trbAversive.Value = 100
                    Case Else
                        trbAversive.Value = trbAversive.Value + 1
                End Select
                intPointer = trbAversive.Value
            Else
                If e.KeyChar = "1" Then
                    Select Case trbAversive.Value
                        Case Is < 1
                            trbAversive.Value = 0
                        Case Else
                            trbAversive.Value = trbAversive.Value - 1
                    End Select
                    intPointer = trbAversive.Value
                End If
            End If
        End If
        If e.KeyChar = "8" Then

            Dim fs As New FileStream(path, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "," & trbAversive.Value)
            sr.Close()
            fs.Close()

            lblAversive.Focus()
            trbAversive.Value = 50
            Me.Hide()

        End If
    End Sub



End Class
