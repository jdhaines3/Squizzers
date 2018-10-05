Imports System.IO
Imports System.Data
Imports Microsoft.VisualBasic


Public Class frmMain

    'for GPRA questions
    Public clsMood As New frmMood
    Public clsEnjoy As New frmEnjoy
    Public clsFrustration As New frmFrustration
    Public clsAlert As New frmAlert
    Private m_Mood As String
    Private m_Enjoy As String
    Private m_Frustration As String
    Private m_Alert As String
    Private m_pntLastMood As Point
    Private m_pntLastEnjoy As Point
    Private m_pntLastFrustration As Point
    Private m_pntLastAlert As Point
    Public clsThanks As New frmThanks
    Public clsBlank As New frmBlank
    Public ScrHeight As Integer
    Public ScrWidth As Integer
    Dim go As New System.Threading.Thread(AddressOf clock)


    Private m_ChangeDegree As Integer
    Private m_xStart As Integer
    Private m_yStart As Integer


    'for GPRA questions
    Public Property pntLastMood() As Point
        Get
            Return m_pntLastMood
        End Get
        Set(ByVal value As Point)
            m_pntLastMood = value
        End Set
    End Property
    Public Property pntLastAlert() As Point
        Get
            Return m_pntLastAlert
        End Get
        Set(ByVal value As Point)
            m_pntLastAlert = value
        End Set
    End Property
    Public Property pntLastFrustration() As Point
        Get
            Return m_pntLastFrustration
        End Get
        Set(ByVal value As Point)
            m_pntLastFrustration = value
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
    Public Property Mood() As String
        Get
            Return m_Mood
        End Get
        Set(ByVal value As String)
            m_Mood = value
        End Set
    End Property

    Public Property Enjoy() As String
        Get
            Return m_Enjoy
        End Get
        Set(ByVal value As String)
            m_Enjoy = value
        End Set
    End Property
    Public Property Frustration() As String
        Get
            Return m_Frustration
        End Get
        Set(ByVal value As String)
            m_Frustration = value
        End Set
    End Property
    Public Property Alert() As String
        Get
            Return m_Alert
        End Get
        Set(ByVal value As String)
            m_Alert = value
        End Set
    End Property

    Public Property ChangeDegree() As Integer
        Get
            Return m_ChangeDegree
        End Get
        Set(ByVal value As Integer)
            m_ChangeDegree = value
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


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        go.Priority = Threading.ThreadPriority.Lowest
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
        go.Start()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        If txtSubj.Text = "" Then
            myMsgBox("Please fill in all fields.", MsgBoxStyle.OkOnly, "ERROR")
        Else

            If cbxSess.SelectedItem = "" Then
                myMsgBox("Please fill in all fields.", MsgBoxStyle.OkOnly, "ERROR")
            Else

                If cbxTech.SelectedItem = "" Then
                    myMsgBox("Please fill in all fields.", MsgBoxStyle.OkOnly, "ERROR")
                Else

                    If My.Computer.FileSystem.DirectoryExists("C:\x\") Then

                        If My.Computer.FileSystem.DirectoryExists("C:\x\" & txtSubj.Text & "\") Then
                            If My.Computer.FileSystem.FileExists("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Enjoy.txt") Then
                                Select Case myMsgBox("Files exist for this Subject and Session, would you like to overwrite?", MsgBoxStyle.YesNo, "ERROR")
                                    Case "YES"
                                        Select Case myMsgBox("ARE YOU SURE?", MsgBoxStyle.YesNo, "SURE?")
                                            Case "YES"
                                                Practice()
                                            Case "NO"
                                        End Select
                                    Case "NO"

                                End Select

                            Else
                                Practice()
                            End If
                        Else

                            My.Computer.FileSystem.CreateDirectory("C:\x\" & txtSubj.Text & "\")
                            Practice()
                        End If

                    Else
                        Try
                            My.Computer.FileSystem.CreateDirectory("C:\x\")
                            My.Computer.FileSystem.CreateDirectory("C:\x\" & txtSubj.Text & "\")
                            Practice()

                        Catch ex As Exception
                            My.Computer.FileSystem.CreateDirectory("E:\x\")
                            My.Computer.FileSystem.CreateDirectory("E:\x\" & txtSubj.Text & "\")
                            Practice()
                        End Try


                    End If

                End If

            End If

        End If

    End Sub

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

    Private Sub Practice()
        go.Abort()
        Me.Hide()
        setWin()

        'for GPRA question
        Dim fsEnjoy As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Enjoy.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim srEnjoy As New StreamWriter(fsEnjoy)
        Enjoy = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Enjoy.txt"
        srEnjoy.Close()

        Dim fsMood As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Happy.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim srMood As New StreamWriter(fsMood)
        Mood = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Happy.txt"
        srMood.Close()

        Dim fsAlert As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Alert.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim srAlert As New StreamWriter(fsAlert)
        Alert = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Alert.txt"
        srAlert.Close()

        Dim fsFrustration As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Frustration.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim srFrustration As New StreamWriter(fsFrustration)
        Frustration = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Frustration.txt"
        srFrustration.Close()




        Dim x As Integer
        x = 0
        Do
            If x = 0 Then                 'Practice Block        'Does x=0 ever run??? jmh

                'previous questions not used in this version
               
                clsEnjoy.ShowDialog(Me)
                clsMood.ShowDialog(Me)
                clsAlert.ShowDialog(Me)
                clsFrustration.ShowDialog(Me)
                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)




                x += 1


            ElseIf x = 1 Then             'before priming


               
                clsEnjoy.ShowDialog(Me)
                clsMood.ShowDialog(Me)
                clsAlert.ShowDialog(Me)
                clsFrustration.ShowDialog(Me)
                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)


                x += 1

            ElseIf x = 2 Then             'after priming


                clsEnjoy.ShowDialog(Me)
                clsMood.ShowDialog(Me)
                clsAlert.ShowDialog(Me)
                clsFrustration.ShowDialog(Me)
                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)


                x += 1

            ElseIf x = 3 Then             'end of session
              
                clsEnjoy.ShowDialog(Me)
                clsMood.ShowDialog(Me)
                clsAlert.ShowDialog(Me)
                clsFrustration.ShowDialog(Me)
                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)


                x += 1


            Else

               
                clsEnjoy.ShowDialog(Me)
                clsMood.ShowDialog(Me)
                clsAlert.ShowDialog(Me)
                clsFrustration.ShowDialog(Me)
                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)

                x += 1
                x = 0      'to force back to start
            End If

        Loop
    End Sub

    'Private Sub Quizzer()


    'Do


    '        clsEnjoy.ShowDialog(Me)
    '       clsMood.ShowDialog(Me)
    '      clsThanks.ShowDialog(Me)
    '     clsBlank.ShowDialog(Me)


    '    Loop
    'End Sub

    Private Sub clock()
        CheckForIllegalCrossThreadCalls() = False
        Do
            Label2.Text = Now
            Threading.Thread.Sleep(1000)
        Loop
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub cbxTech_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTech.SelectedIndexChanged

    End Sub
End Class
