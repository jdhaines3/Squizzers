Imports System
Imports System.IO

Public Class frmPacsQ2

    Dim subID, path, cbx As String


    Private Sub frmPacsQ2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set the screen to extended monitor
        Dim screen As Screen
        ' We want to display a form on screen 1
        Try
            screen = Screen.AllScreens(1)
        Catch ex As Exception
            screen = Screen.AllScreens(0)
        End Try

        ' Set the StartPosition to Manual otherwise the system will assign an automatic start position

        Me.StartPosition = FormStartPosition.Manual

        ' Set the form location so it appears at Location (100, 100) on the screen 1

        Me.Location = screen.Bounds.Location + New Point(0, 0)
        'end set screen
        KeyPreview = True

        lblCrave.Focus()

        cbx = frmMain.cbxSess.SelectedItem
        subID = frmMain.txtSubj.Text
        path = "C:\x\" & subID & "\" & subID & cbx & "_PACS.txt"

    End Sub
    Private Sub frmPacsQ2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit GPRA Quizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit GRPA Quizzer?")
            If response = MsgBoxResult.Yes Then

                frmMain.cleanseEverything()

            Else
            End If
        ElseIf e.KeyChar = "2" Then
            Select Case Number.Text
                Case Is >= 6
                    Number.Text = 6
                Case Else
                    Number.Text = Number.Text + 1
            End Select
        ElseIf e.KeyChar = "1" Then
            Select Case Number.Text
                Case Is <= 0
                    Number.Text = 0
                Case Else
                    Number.Text = Number.Text - 1
            End Select
        ElseIf e.KeyChar = "8" Then

            Dim fs As New FileStream(path, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & ",PacsQ2," & Number.Text)
            sr.Close()
            fs.Close()
            lblCrave.Focus()
            Me.Hide()

        End If


    End Sub



End Class