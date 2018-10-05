Imports System.IO
Imports System.Data
Imports Microsoft.VisualBasic


Public Class frmMain

    '----Declare all variables----'

    'Creation of forms
    Public clsNeed As New frmNeed
    Public clsEnjoy As New frmEnjoy
    Public clsCrave As New frmCrave
    Public clsDrinks As New frmDrinks
    Public clsRelax As New frmRelax
    Public clsAnxious As New frmAnxious
    Public clsIntox As New frmIntox
    Public clsStim As New frmStim
    Public clsTired As New frmTired
    Public clsDislike As New frmDislike
    Public clsThanks As New frmThanks
    Public clsBlank As New frmBlank


    Private formArray As New ArrayList()
    Private indxArray(10) As Integer


    'Getting screen dimensions
    Public ScrHeight As Integer
    Public ScrWidth As Integer

    'Form input variables
    Private m_Anxious As String
    Private m_Enjoy As String
    Private m_Intox As String
    Private m_Relax As String
    Private m_Stim As String
    Private m_Tired As String
    Private m_Crave As String
    Private m_Drinks As String
    Private m_Dislike As String
    Private m_Need As String


    'Position of arrow on slides
    Private m_pntLastAnxious As Point
    Private m_pntLastEnjoy As Point
    Private m_pntLastIntox As Point
    Private m_pntLastRelax As Point
    Private m_pntLastStim As Point
    Private m_pntLastTired As Point
    Private m_pntLastCrave As Point
    Private m_pntLastNeed As Point
    Private m_pntLastDislike As Point

    'help in moving arrow to value
    Private m_ChangeDegree As Integer
    Private m_xStart As Integer
    Private m_yStart As Integer

    'properties with variables
    Public Property pntLastAnxious() As Point
        Get
            Return m_pntLastAnxious
        End Get
        Set(ByVal value As Point)
            m_pntLastAnxious = value
        End Set
    End Property

    Public Property pntLastEnjoy() As Point
        Get
            Return m_pntLastEnjoy
        End Get
        Set(ByVal value As Point)
            m_pntLastEnjoy = value
        End Set
    End Property
    Public Property pntLastIntox() As Point
        Get
            Return m_pntLastIntox
        End Get
        Set(ByVal value As Point)
            m_pntLastIntox = value
        End Set
    End Property
    Public Property pntLastRelax() As Point
        Get
            Return m_pntLastRelax
        End Get
        Set(ByVal value As Point)
            m_pntLastRelax = value
        End Set
    End Property
    Public Property pntLastStim() As Point
        Get
            Return m_pntLastStim
        End Get
        Set(ByVal value As Point)
            m_pntLastStim = value
        End Set
    End Property
    Public Property pntLastTired() As Point
        Get
            Return m_pntLastTired
        End Get
        Set(ByVal value As Point)
            m_pntLastTired = value
        End Set
    End Property

    Public Property pntLastNeed() As Point
        Get
            Return m_pntLastNeed
        End Get
        Set(ByVal value As Point)
            m_pntLastNeed = value
        End Set
    End Property

    Public Property pntLastDislike() As Point
        Get
            Return m_pntLastDislike
        End Get
        Set(ByVal value As Point)
            m_pntLastDislike = value
        End Set
    End Property
    Public Property pntLastCrave() As Point
        Get
            Return m_pntLastCrave
        End Get
        Set(ByVal value As Point)
            m_pntLastCrave = value
        End Set
    End Property

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


    'fill the array list with each class/form

    Private Sub fillArrays()

        formArray.Add(clsAnxious)
        formArray.Add(clsCrave)
        formArray.Add(clsDislike)
        formArray.Add(clsDrinks)
        formArray.Add(clsEnjoy)
        formArray.Add(clsIntox)
        formArray.Add(clsNeed)
        formArray.Add(clsRelax)
        formArray.Add(clsStim)
        formArray.Add(clsTired)

        Dim i As Integer

        For i = 0 To 9
            indxArray(i) = i
        Next

    End Sub

    'Sets window size
    Public Sub setWin()

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

    End Sub

    'loads this form
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

        yStart = (ScrHeight / 2) + 40
        xStart = ((ScrWidth - 533) / 2) + 2

    End Sub

    'describes what buttons on main form do
    'makes sure no boxes empty, if so, error popup

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        If txtSubj.Text = "" Or cbxSess.SelectedItem = "" Or cbxTech.SelectedItem = "" Then

            myMsgBox("Please fill in all fields.", MsgBoxStyle.OkOnly, "ERROR")
        Else
            'if not, makes sure there exists a directory for them
            'if no directory, create one
            If My.Computer.FileSystem.DirectoryExists("C:\x\") Then

                If My.Computer.FileSystem.DirectoryExists("C:\x\" & txtSubj.Text & "\") Then

                    'if directory already has files in it, overwrite command pop-up
                    If My.Computer.FileSystem.FileExists("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Anxious.txt") Then

                        Select Case myMsgBox("Files exist for this Subject and Session, would you like to overwrite?", MsgBoxStyle.YesNo, "ERROR")

                            'if yes, do squizzer, if no, go back to main menu
                            Case "YES"


                                RunSquizzer()


                            Case "NO"

                        End Select

                    Else

                        RunSquizzer()

                    End If

                Else

                    My.Computer.FileSystem.CreateDirectory("C:\x\" & txtSubj.Text & "\")
                    RunSquizzer()

                End If

            Else

                Try

                    My.Computer.FileSystem.CreateDirectory("C:\x\")
                    My.Computer.FileSystem.CreateDirectory("C:\x\" & txtSubj.Text & "\")
                    RunSquizzer()

                Catch ex As Exception

                    'if cant make directory in C drive, try E drive. Might make it cancel out and tell person to get admin access, because this may not work either
                    My.Computer.FileSystem.CreateDirectory("E:\x\")
                    My.Computer.FileSystem.CreateDirectory("E:\x\" & txtSubj.Text & "\")
                    RunSquizzer()
                End Try

            End If

        End If

    End Sub

    'creation of message box used in main
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

    'Squizzer Function
    Private Sub RunSquizzer()

        'closes Main, sets window for new form, runs fillarray

        Me.Hide()
        setWin()
        fillArrays()

        '------For testing purposes only------'
        '-------------------------------------'
        'Try

        '    Do

        '        clsAnxious.ShowDialog(Me)
        '        clsThanks.ShowDialog(Me)
        '        clsBlank.ShowDialog(Me)

        '    Loop

        'Catch ex As Exception

        '    cleanseEverything()

        'End Try


        Do

            'start squiz loop

            Dim index, rndNum, temp, i As Integer
            Dim rndm As Random = New Random()

            'for each index in form Array, shuffle with random index in array
            For index = 0 To 9

                rndNum = rndm.Next(0, 10)
                While rndNum = index
                    rndNum = rndm.Next(0, 10)
                End While
                temp = indxArray(rndNum)
                indxArray(rndNum) = indxArray(index)
                indxArray(index) = temp

            Next

            'iterate through array of forms and show
            For i = 0 To 9

                Dim objIndex As Integer
                objIndex = indxArray(i)

                Try

                    formArray(objIndex).ShowDialog(Me)

                Catch ex As Exception

                    Exit Do

                End Try


            Next

            'show thanks and technician screen
            Try

                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)

            Catch ex As Exception

                Exit Do

            End Try

        Loop

        cleanseEverything()

    End Sub

    'if cancel is clicked, close
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        cleanseEverything()

    End Sub

    'dispose of classes and forms, shut application.  can be (and is) called in all forms
    Public Sub cleanseEverything()

        clsAnxious.Dispose()
        clsCrave.Dispose()
        clsDislike.Dispose()
        clsDrinks.Dispose()
        clsEnjoy.Dispose()
        clsIntox.Dispose()
        clsNeed.Dispose()
        clsRelax.Dispose()
        clsStim.Dispose()
        clsTired.Dispose()
        clsBlank.Dispose()
        clsThanks.Dispose()

        frmAnxious.Dispose()
        frmCrave.Dispose()
        frmDislike.Dispose()
        frmDrinks.Dispose()
        frmEnjoy.Dispose()
        frmIntox.Dispose()
        frmNeed.Dispose()
        frmRelax.Dispose()
        frmStim.Dispose()
        frmTired.Dispose()
        frmBlank.Dispose()
        frmThanks.Dispose()

        GC.Collect()

        Me.Close()
        Application.Exit()

    End Sub
End Class
