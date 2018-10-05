Public Class frmBlank
    Public Sub setWin()

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

    End Sub
    Private Sub frmBlank_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim response As MsgBoxResult
        If e.Control And e.KeyCode = Keys.N Then
            Me.Hide()
        End If

        If e.Control And e.KeyCode = Keys.R Then
            response = MsgBox("Reset pntLast arrows?", MsgBoxStyle.YesNo, "Reset?")
            If response = MsgBoxResult.Yes Then
                frmMain.pntLastWant = New Point(0, 0)
                frmMain.clsDrinks.Number.Text = 0
                frmMain.pntLastNeed = New Point(0, 0)
                frmMain.pntLastPerfect = New Point(0, 0)
                frmMain.pntLastTaste = New Point(0, 0)
                frmMain.pntLastNow = New Point(0, 0)
                frmMain.pntLastChance = New Point(0, 0)
                frmMain.pntLastDifficult = New Point(0, 0)
                frmMain.ChangeDegree = New Integer()
                frmCrave.lblChangeDegree.Text = ""

            Else
            End If
        End If

        If e.Control And e.KeyCode = Keys.X Then
            response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
            If response = MsgBoxResult.Yes Then
                End
            Else

            End If
        End If

    End Sub


    Private Sub frmBlank_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objPoint As Point = PointToScreen(New Point(0, 0))
        objPoint.X += 0
        objPoint.Y += 0
        Cursor.Position = objPoint
        KeyPreview = True
        Dim screen As Screen

        ' We want to display a form on screen 0 (Primary)
        screen = screen.AllScreens(0)
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = screen.Bounds.Location + New Point(0, 0)

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Dim response As MsgBoxResult
        response = MsgBox("Reset pntLast arrows?", MsgBoxStyle.YesNo, "Reset?")
        If response = MsgBoxResult.Yes Then
            frmMain.pntLastWant = New Point(0, 0)
            frmMain.clsDrinks.Number.Text = 0
            frmMain.pntLastNeed = New Point(0, 0)
            frmMain.pntLastPerfect = New Point(0, 0)
            frmMain.pntLastTaste = New Point(0, 0)
            frmMain.pntLastNow = New Point(0, 0)
            frmMain.pntLastChance = New Point(0, 0)
            frmMain.pntLastDifficult = New Point(0, 0)
            frmMain.pntLastCrave = New Point(0, 0)
            frmMain.ChangeDegree = New Integer()
            frmCrave.lblChangeDegree.Text = ""

        Else
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim response As MsgBoxResult
        response = MsgBox("You are about to exit sQuizzer. Are you sure?", MsgBoxStyle.YesNo, "Quit sQuizzer?")
        If response = MsgBoxResult.Yes Then
            End
        Else
        End If
    End Sub


End Class