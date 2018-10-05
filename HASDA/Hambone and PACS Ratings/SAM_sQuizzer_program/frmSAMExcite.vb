Imports System
Imports System.IO

Public Class frmSAMExcite
    Dim intPointer As Integer

    Dim path, cbx, subID As String


    Private Sub frmSAMExcite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        lblSAMExcite.Focus()

        cbx = frmMain.cbxSess.SelectedItem
        subID = frmMain.txtSubj.Text
        path = "C:\x\" & subID & "\" & subID & cbx & "_SAMExcite.txt"


    End Sub

    Private Sub frmSAMExcite_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then

                frmMain.cleanseEverything()

            Else
            End If
        Else

            'goes up
            If e.KeyChar = "2" Then
                Select Case trbSAMExcite.Value
                    Case Is > 7
                        trbSAMExcite.Value = 8
                    Case Else
                        trbSAMExcite.Value = trbSAMExcite.Value + 1
                End Select
                intPointer = trbSAMExcite.Value
            Else

                'goes down
                If e.KeyChar = "1" Then
                    Select Case trbSAMExcite.Value
                        Case Is < 1
                            trbSAMExcite.Value = 0
                        Case Else
                            trbSAMExcite.Value = trbSAMExcite.Value - 1
                    End Select
                    intPointer = trbSAMExcite.Value
                End If
            End If
        End If

        'enter
        If e.KeyChar = "8" Then


            Dim fs As New FileStream(path, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "," & trbSAMExcite.Value)
            sr.Close()
            fs.Close()

            trbSAMExcite.Value = 4
            lblSAMExcite.Focus()
            Me.Hide()


        End If
    End Sub


End Class


