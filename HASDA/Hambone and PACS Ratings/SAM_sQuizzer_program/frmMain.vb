Imports System.IO
Imports System.Data
Imports Microsoft.VisualBasic


Public Class frmMain

    'list out all forms as instances of that form
    Public clsAversive As New frmAversive
    Public clsSAMHappy As New frmSAMHappy
    Public clsSAMExcite As New frmSAMExcite
    Public clsThanks As New frmThanks
    Public clsBlank As New frmBlank
    Public clsPacsQ1 As New frmPacsQ1
    Public clsPacsQ2 As New frmPacsQ2
    Public clsPacsQ3 As New frmPacsQ3
    Public clsPacsQ4 As New frmPacsQ4
    Public clsPacsQ5 As New frmPacsQ5

    'for detecting screen size
    Public ScrHeight As Integer
    Public ScrWidth As Integer


    'for pointer...not used in this program
    Private m_xStart As Integer
    Private m_yStart As Integer

    Public Property xStart() As Integer
        Get
            Return m_xStart
        End Get
        Set(ByVal value As Integer)
            m_xStart = value
        End Set
    End Property

    Public Property yStart() As Integer
        Get
            Return m_yStart
        End Get
        Set(ByVal value As Integer)
            m_yStart = value
        End Set
    End Property


    'sets window size

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


    'loads the form
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'find screen resolution
        'variables to use ScrHeight ScrWidth
        Dim myScreens() As Screen = Screen.AllScreens
        If (myScreens.Length = 2) Then
            ScrHeight = myScreens(1).WorkingArea.Height
            ScrWidth = myScreens(1).WorkingArea.Width
        Else

            ScrHeight = Screen.PrimaryScreen.WorkingArea.Height
            ScrWidth = Screen.PrimaryScreen.WorkingArea.Width
        End If

        yStart = (ScrHeight / 2) - 15
        xStart = ((ScrWidth - 533) / 2) - 2

    End Sub

    'this happens when submit button is clicked
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        'checks if any fields blank, if so, error message box
        If txtSubj.Text = "" Or cbxSess.SelectedItem = "" Or cbxTech.SelectedItem = "" Then
            myMsgBox("Please fill in all fields.", MsgBoxStyle.OkOnly, "ERROR")
        Else
            'if not, check to ensure directory exists
            If My.Computer.FileSystem.DirectoryExists("C:\x\") Then

                If My.Computer.FileSystem.DirectoryExists("C:\x\" & txtSubj.Text & "\") Then

                    'if subject folder does exist and has files in it for that session, check if want to overwrite
                    If My.Computer.FileSystem.FileExists("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_SAMHappy.txt") Then

                        Select Case myMsgBox("Files exist for this Subject and Session, would you like to overwrite?", MsgBoxStyle.YesNo, "ERROR")
                            Case "YES"
                                Squizzer()
                            Case "NO"
                        End Select
                        'if folder exists but no files, run 
                    Else
                        Squizzer()
                    End If

                Else

                    'if directory doesn't exist, create then run
                    My.Computer.FileSystem.CreateDirectory("C:\x\" & txtSubj.Text & "\")
                    Squizzer()

                End If

            Else
                'if x directory doesn't even exist, try creating directories on C drive, if fails, try E drive, then run
                'may make catch block give error... no error clause if E isnt writable either
                Try

                    My.Computer.FileSystem.CreateDirectory("C:\x\")
                    My.Computer.FileSystem.CreateDirectory("C:\x\" & txtSubj.Text & "\")
                    Squizzer()

                Catch ex As Exception

                    My.Computer.FileSystem.CreateDirectory("E:\x\")
                    My.Computer.FileSystem.CreateDirectory("E:\x\" & txtSubj.Text & "\")
                    Squizzer()

                End Try
            End If
        End If
    End Sub

    'Message box functions
    Public Shared Function myMsgBox(ByVal Prompt As Object, ByVal Buttons As MsgBoxStyle, ByVal Title As Object) As String

        Dim response As MsgBoxResult

        response = MsgBox(Prompt, Buttons, Title)

        If response = MsgBoxResult.Yes Then
            Return "YES"
        ElseIf response = MsgBoxResult.Ok Then
            Return "OK"
        ElseIf response = MsgBoxResult.No Then
            Return "NO"
        Else
            Return Nothing
        End If

    End Function

    'Squizzer Run Function
    Private Sub Squizzer()

        'hides main and sets window 
        Me.Hide()
        setWin()
        '---------------------'

        'checks for the selected session, if it is a restart, start counter (st) set to 1 to skip PACS
        'Else, runs with PACS at start
        Dim st As Integer


        If cbxSess.SelectedItem = "Restart" Then
            st = 1
        Else
            st = 0
        End If

        'Loops until exit by user
        Do
            If st = 0 Then

                Try

                    clsPacsQ1.ShowDialog(Me)
                    clsPacsQ2.ShowDialog(Me)
                    clsPacsQ3.ShowDialog(Me)
                    clsPacsQ4.ShowDialog(Me)
                    clsPacsQ5.ShowDialog(Me)
                    clsThanks.ShowDialog(Me)
                    clsBlank.ShowDialog(Me)

                Catch ex As Exception

                    Exit Do


                End Try

                st += 1

            ElseIf st >= 1 Then

                Try
                    clsSAMHappy.ShowDialog(Me)
                    clsSAMExcite.ShowDialog(Me)
                    clsAversive.ShowDialog(Me)
                    clsThanks.ShowDialog(Me)
                    clsBlank.ShowDialog(Me)

                Catch ex As Exception

                    Exit Do


                End Try

            Else

                Exit Do

            End If

        Loop

        cleanseEverything()

    End Sub

    Public Sub cleanseEverything()


        clsAversive.Dispose()
        clsSAMHappy.Dispose()
        clsSAMExcite.Dispose()
        clsThanks.Dispose()
        clsBlank.Dispose()
        clsPacsQ1.Dispose()
        clsPacsQ2.Dispose()
        clsPacsQ3.Dispose()
        clsPacsQ4.Dispose()
        clsPacsQ5.Dispose()

        frmPacsQ1.Dispose()
        frmPacsQ2.Dispose()
        frmPacsQ3.Dispose()
        frmPacsQ4.Dispose()
        frmPacsQ5.Dispose()

        frmSAMExcite.Dispose()
        frmSAMHappy.Dispose()
        frmAversive.Dispose()
        frmBlank.Dispose()
        frmThanks.Dispose()

        GC.Collect()

        Me.Dispose()
        Application.Exit()


    End Sub
    'if cancel, close
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        cleanseEverything()

    End Sub

End Class
