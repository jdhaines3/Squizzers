Imports System
Imports System.IO
Imports System.Windows.Forms.Form

'==========================================='
'-----Check frmAnxious for all comments-----'
'==========================================='


Public Class frmCrave
    Dim intPointer As Integer

    Dim path, subj, cbx As String

    '' SEE frmAnxious for Mouse-use code as opposed to keyboard input


    Private Sub frmCrave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        If frmMain.pntLastCrave.IsEmpty Then

            pbxPointer.Visible = False
        Else

            pbxPointer.Visible = True
            pbxPointer.Location() = frmMain.pntLastCrave

        End If

        KeyPreview = True

        lblStim.Focus()

        cbx = frmMain.cbxSess.SelectedItem
        subj = frmMain.txtSubj.Text
        path = "C:\x\" & subj & "\" & subj & cbx & "_Crave.txt"

    End Sub

    Private Sub frmCrave_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim response As MsgBoxResult
        If e.KeyChar = "x" Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then

                frmMain.cleanseEverything()

            Else
            End If
        ElseIf e.KeyChar = "2" Then
            Select Case trbCrave.Value
                Case Is > 99
                    trbCrave.Value = 100
                Case Else
                    trbCrave.Value = trbCrave.Value + 1
            End Select
            intPointer = trbCrave.Value
        ElseIf e.KeyChar = "1" Then
            Select Case trbCrave.Value
                Case Is < 1
                    trbCrave.Value = 0
                Case Else
                    trbCrave.Value = trbCrave.Value - 1
            End Select
            intPointer = trbCrave.Value
        ElseIf e.KeyChar = "8" Then

            Dim fs As New FileStream(path, FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(fs)
            sr.WriteLine(Now & "," & trbCrave.Value)
            sr.Close()
            fs.Close()

            frmMain.pntLastCrave = New Point(CInt((trbCrave.Value * 5.27) + frmMain.xStart), frmMain.yStart)
            lblStim.Focus()
            trbCrave.Value = trbCrave.Value
            pbxPointer.Visible = True
            Me.Hide()

        End If
    End Sub

End Class
