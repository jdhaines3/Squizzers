Imports System
Imports System.IO

'==========================================='
'-----Check frmAnxious for all comments-----'
'==========================================='


Public Class frmDrinks

    Dim path, cbx, subj As String


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

        lblCrave.Focus()

        cbx = frmMain.cbxSess.SelectedItem
        subj = frmMain.txtSubj.Text
        path = "C:\x\" & subj & "\" & subj & cbx & "_Drinks.txt"


    End Sub
    Private Sub frmDrinks_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit GPRA Quizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit GRPA Quizzer?")
            If response = MsgBoxResult.Yes Then

                frmMain.cleanseEverything()

            Else
            End If
        ElseIf e.KeyChar = "2" Then
            Select Case Number.Text
                Case Is > 99.5
                    Number.Text = 100
                Case Else
                    Number.Text = Number.Text + 0.5
            End Select
        ElseIf e.KeyChar = "1" Then
            Select Case Number.Text
                Case Is <= 0

                Case Else
                    Number.Text = Number.Text - 0.5
            End Select
        ElseIf e.KeyChar = "8" Then

            Dim fs As New FileStream(path, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "," & Number.Text)
            sr.Close()
            fs.Close()

            lblCrave.Focus()
            Me.Hide()

        End If

    End Sub

End Class