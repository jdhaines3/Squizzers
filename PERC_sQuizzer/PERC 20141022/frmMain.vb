Imports System.IO
Imports System.Data
Imports Microsoft.VisualBasic


Public Class frmMain

    'for GPRA questions
    Public clsFrustration As New frmFrustration
    Public clsAnxious As New frmAnxious
    Public clsChange As New frmChange
    Public clsEnjoy As New frmEnjoy
    Public clsIntox As New frmIntox
    Public clsRelax As New frmRelax
    Public clsStim As New frmStim
    Public clsTired As New frmTired
    Private m_Anxious As String
    Private m_Change As String
    Private m_Frustration As String
    Private m_Enjoy As String
    Private m_Intox As String
    Private m_Relax As String
    Private m_Stim As String
    Private m_Tired As String
    Private m_pntLastAnxious As Point
    Private m_pntLastChange As Point
    Private m_pntLastFrustration As Point
    Private m_pntLastEnjoy As Point
    Private m_pntLastIntox As Point
    Private m_pntLastRelax As Point
    Private m_pntLastStim As Point
    Private m_pntLastTired As Point




    Public clsCrave As New frmCrave
    Public clsDrinks As New frmDrinks
    Public clsChance As New frmChance
    Public clsTaste As New frmTaste
    Public clsNow As New frmNow
    Public clsThanks As New frmThanks
    Public clsDifficult As New frmDifficult
    Public clsWant As New frmWant
    Public clsNeed As New frmNeed
    Public clsPerfect As New frmPerfect
    Public clsBlank As New frmBlank
    Public ScrHeight As Integer
    Public ScrWidth As Integer
    Dim go As New System.Threading.Thread(AddressOf clock)

    Private m_Crave As String
    Private m_Drinks As String
    Private m_Taste As String
    Private m_Now As String
    Private m_Chance As String
    Private m_Difficult As String
    Private m_Want As String
    Private m_Need As String
    Private m_Perfect As String
    Private m_ChangeDegree As Integer
    Private m_xStart As Integer
    Private m_yStart As Integer

    Private m_pntLastCrave As Point
    Private m_pntLastWant As Point
    Private m_pntLastNeed As Point
    Private m_pntLastPerfect As Point
    Private m_pntLastTaste As Point
    Private m_pntLastNow As Point
    Private m_pntLastChance As Point
    Private m_pntLastDifficult As Point


    'for GPRA questions
    Public Property pntLastAnxious() As Point
        Get
            Return m_pntLastAnxious
        End Get
        Set(ByVal value As Point)
            m_pntLastAnxious = value
        End Set
    End Property
    Public Property pntLastChange() As Point
        Get
            Return m_pntLastChange
        End Get
        Set(ByVal value As Point)
            m_pntLastChange = value
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
    Public Property Anxious() As String
        Get
            Return m_Anxious
        End Get
        Set(ByVal value As String)
            m_Anxious = value
        End Set
    End Property

    Public Property Change() As String
        Get
            Return m_Change
        End Get
        Set(ByVal value As String)
            m_Change = value
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
    Public Property Enjoy() As String
        Get
            Return m_Enjoy
        End Get
        Set(ByVal value As String)
            m_Enjoy = value
        End Set
    End Property
    Public Property Intox() As String
        Get
            Return m_Intox
        End Get
        Set(ByVal value As String)
            m_Intox = value
        End Set
    End Property
    Public Property Relax() As String
        Get
            Return m_Relax
        End Get
        Set(ByVal value As String)
            m_Relax = value
        End Set
    End Property
    Public Property Stim() As String
        Get
            Return m_Stim
        End Get
        Set(ByVal value As String)
            m_Stim = value
        End Set
    End Property
    Public Property Tired() As String
        Get
            Return m_Tired
        End Get
        Set(ByVal value As String)
            m_Tired = value
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

    Public Property ChangeDegree() As Integer
        Get
            Return m_ChangeDegree
        End Get
        Set(ByVal value As Integer)
            m_ChangeDegree = value
        End Set
    End Property

    Public Property pntLastWant() As Point
        Get
            Return m_pntLastWant
        End Get
        Set(ByVal value As Point)
            m_pntLastWant = value
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

    Public Property pntLastPerfect() As Point
        Get
            Return m_pntLastPerfect
        End Get
        Set(ByVal value As Point)
            m_pntLastPerfect = value
        End Set
    End Property

    Public Property pntLastTaste() As Point
        Get
            Return m_pntLastTaste
        End Get
        Set(ByVal value As Point)
            m_pntLastTaste = value
        End Set
    End Property

    Public Property pntLastNow() As Point
        Get
            Return m_pntLastNow
        End Get
        Set(ByVal value As Point)
            m_pntLastNow = value
        End Set
    End Property

    Public Property pntLastChance() As Point
        Get
            Return m_pntLastChance
        End Get
        Set(ByVal value As Point)
            m_pntLastChance = value
        End Set
    End Property

    Public Property pntLastDifficult() As Point
        Get
            Return m_pntLastDifficult
        End Get
        Set(ByVal value As Point)
            m_pntLastDifficult = value
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

    Public Property Drinks() As String
        Get
            Return m_Drinks
        End Get
        Set(ByVal value As String)
            m_Drinks = value
        End Set
    End Property

    Public Property crave() As String
        Get
            Return m_Crave
        End Get
        Set(ByVal value As String)
            m_Crave = value
        End Set
    End Property

    Public Property Taste() As String
        Get
            Return m_Taste
        End Get
        Set(ByVal value As String)
            m_Taste = value
        End Set
    End Property

    Public Property Now() As String
        Get
            Return m_Now
        End Get
        Set(ByVal value As String)
            m_Now = value
        End Set
    End Property

    Public Property Chance() As String
        Get
            Return m_Chance
        End Get
        Set(ByVal value As String)
            m_Chance = value
        End Set
    End Property

    Public Property Difficult() As String
        Get
            Return m_Difficult
        End Get
        Set(ByVal value As String)
            m_Difficult = value
        End Set
    End Property

    Public Property Want() As String
        Get
            Return m_Want
        End Get
        Set(ByVal value As String)
            m_Want = value
        End Set
    End Property

    Public Property Need() As String
        Get
            Return m_Need
        End Get
        Set(ByVal value As String)
            m_Need = value
        End Set
    End Property

    Public Property Perfect() As String
        Get
            Return m_Perfect
        End Get
        Set(ByVal value As String)
            m_Perfect = value
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
                            If My.Computer.FileSystem.FileExists("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_High.txt") Then
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
        Dim fsDrinks As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Drinks.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim srDrinks As New StreamWriter(fsDrinks)
        Drinks = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Drinks.txt"
        srDrinks.Close()

        'flagged. not currently used. KAW 4.9.2011
        'Dim fsTaste As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Taste.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        'Dim srTaste As New StreamWriter(fsTaste)
        'Taste = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Taste.txt"
        'srTaste.Close()

        'flagged. not currently used. KAW 4.9.2011
        'Dim fsNow As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Now.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        'Dim srNow As New StreamWriter(fsNow)
        'Now = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Now.txt"
        'srNow.Close()

        'flagged. not currently used. KAW 4.9.2011
        'Dim fsChance As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Chance.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        'Dim srChance As New StreamWriter(fsChance)
        'Chance = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Chance.txt"
        'srChance.Close()

        'Dim fsDifficult As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Difficult.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        'Dim srDifficult As New StreamWriter(fsDifficult)
        'Difficult = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Difficult.txt"
        'srDifficult.Close()

        'Dim fsWant As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Want.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        'Dim srWant As New StreamWriter(fsWant)
        'Want = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Want.txt"
        'srWant.Close()

        'Dim fsNeed As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Need.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        'Dim srNeed As New StreamWriter(fsNeed)
        'Need = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Need.txt"
        'srNeed.Close()

        'Dim fsPerfect As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Perfect.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        'Dim srPerfect As New StreamWriter(fsPerfect)
        'Perfect = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Perfect.txt"
        'srPerfect.Close()

        'Dim fsCrave As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Crave.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        'Dim srCrave As New StreamWriter(fsCrave)
        'crave = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Crave.txt"
        'srCrave.Close()


        'for GPRA question
        Dim fsAnxious As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Anxious.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim srAnxious As New StreamWriter(fsAnxious)
        Anxious = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Anxious.txt"
        srAnxious.Close()

        'flagged. not currently used. KAW 4.9.2011
        'Dim fsChange As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Change.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        'Dim srChange As New StreamWriter(fsChange)
        'Change = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Change.txt"
        'srChange.Close()

        'Dim fsFrustration As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Frustration.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        'Dim srFrustration As New StreamWriter(fsFrustration)
        'Frustration = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Frustration.txt"
        'srFrustration.Close()

        Dim fsEnjoy As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Enjoy.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim srEnjoy As New StreamWriter(fsEnjoy)
        Enjoy = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Enjoy.txt"
        srEnjoy.Close()

        Dim fsIntox As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Intox.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim srIntox As New StreamWriter(fsIntox)
        Intox = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Intox.txt"
        srIntox.Close()

        Dim fsRelax As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Relax.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim srRelax As New StreamWriter(fsRelax)
        Relax = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Relax.txt"
        srRelax.Close()

        Dim fsStim As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Stim.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim srStim As New StreamWriter(fsStim)
        Stim = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Stim.txt"
        srStim.Close()

        Dim fsTired As New FileStream("C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Tired.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim srTired As New StreamWriter(fsTired)
        Tired = "C:\x\" & txtSubj.Text & "\" & txtSubj.Text & cbxSess.SelectedItem & "_Tired.txt"
        srTired.Close()



        Dim x As Integer
        x = 0
        Do
            If x = 0 Then                 'Practice Block        'Does x=0 ever run??? jmh

                'previous questions not used in this version
                'clsChange.ShowDialog(Me)
                'clsTaste.ShowDialog(Me)
                'clsNow.ShowDialog(Me)
                'clsChance.ShowDialog(Me)


                'clsWant.ShowDialog(Me)
                'clsDifficult.ShowDialog(Me)
                'clsNeed.ShowDialog(Me)
                clsEnjoy.ShowDialog(Me)
                'clsPerfect.ShowDialog(Me)
                'clsCrave.ShowDialog(Me)

                clsDrinks.ShowDialog(Me)

                clsRelax.ShowDialog(Me)
                'clsFrustration.ShowDialog(Me)
                clsAnxious.ShowDialog(Me)
                clsIntox.ShowDialog(Me)
                clsStim.ShowDialog(Me)
                clsTired.ShowDialog(Me)

                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)




                x += 1


            ElseIf x = 1 Then             'before priming

                'clsNeed.ShowDialog(Me)
                'clsCrave.ShowDialog(Me)
                'clsWant.ShowDialog(Me)
                'clsDifficult.ShowDialog(Me)
                'clsPerfect.ShowDialog(Me)



                clsDrinks.ShowDialog(Me)
                clsIntox.ShowDialog(Me)
                clsStim.ShowDialog(Me)
                clsTired.ShowDialog(Me)
                clsRelax.ShowDialog(Me)
                clsEnjoy.ShowDialog(Me)
                clsAnxious.ShowDialog(Me)
                'clsIntox.ShowDialog(Me)
                'clsFrustration.ShowDialog(Me)

                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)


                x += 1

            ElseIf x = 2 Then             'after priming
                'clsCrave.ShowDialog(Me)

                'clsDifficult.ShowDialog(Me)
                'clsPerfect.ShowDialog(Me)
                'clsNeed.ShowDialog(Me)
                'clsWant.ShowDialog(Me)

                clsAnxious.ShowDialog(Me)
                clsDrinks.ShowDialog(Me)

                clsIntox.ShowDialog(Me)
                'clsFrustration.ShowDialog(Me)
                clsStim.ShowDialog(Me)

                clsTired.ShowDialog(Me)
                clsRelax.ShowDialog(Me)

                clsEnjoy.ShowDialog(Me)
                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)

                x += 1

            ElseIf x = 3 Then             'end of session
                'clsPerfect.ShowDialog(Me)
                clsTired.ShowDialog(Me)
                clsAnxious.ShowDialog(Me)
                'clsNeed.ShowDialog(Me)
                'clsWant.ShowDialog(Me)
                'clsCrave.ShowDialog(Me)
                'clsDifficult.ShowDialog(Me)

                clsRelax.ShowDialog(Me)
                clsDrinks.ShowDialog(Me)
                clsIntox.ShowDialog(Me)
                clsStim.ShowDialog(Me)
                'clsFrustration.ShowDialog(Me)

                clsEnjoy.ShowDialog(Me)


                'clsIntox.ShowDialog(Me)

                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)

                x += 1

            ElseIf x = 4 Then             'extra

                'clsDifficult.ShowDialog(Me)
                'clsCrave.ShowDialog(Me)
                'clsPerfect.ShowDialog(Me)
                'clsWant.ShowDialog(Me)
                'clsNeed.ShowDialog(Me)
                clsStim.ShowDialog(Me)
                clsAnxious.ShowDialog(Me)
                clsEnjoy.ShowDialog(Me)


                clsDrinks.ShowDialog(Me)

                clsRelax.ShowDialog(Me)
                'clsIntox.ShowDialog(Me)

                'clsFrustration.ShowDialog(Me)

                clsTired.ShowDialog(Me)
                clsIntox.ShowDialog(Me)
                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)


                x += 1

            ElseIf x = 5 Then             'extra


                clsRelax.ShowDialog(Me)
                clsTired.ShowDialog(Me)
                clsIntox.ShowDialog(Me)
                clsEnjoy.ShowDialog(Me)
                'clsWant.ShowDialog(Me)
                'clsNeed.ShowDialog(Me)
                'clsDifficult.ShowDialog(Me)
                'clsPerfect.ShowDialog(Me)
                'clsCrave.ShowDialog(Me)

                clsAnxious.ShowDialog(Me)
                clsDrinks.ShowDialog(Me)


                'clsFrustration.ShowDialog(Me)

                'clsIntox.ShowDialog(Me)
                clsStim.ShowDialog(Me)


                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)


                x += 1

            ElseIf x = 6 Then

                clsIntox.ShowDialog(Me)
                clsAnxious.ShowDialog(Me)
                'clsWant.ShowDialog(Me)
                'clsDifficult.ShowDialog(Me)
                'clsNeed.ShowDialog(Me)
                clsRelax.ShowDialog(Me)
                'clsFrustration.ShowDialog(Me)

                'clsIntox.ShowDialog(Me)
                clsEnjoy.ShowDialog(Me)
                clsStim.ShowDialog(Me)
                'clsPerfect.ShowDialog(Me)
                'clsCrave.ShowDialog(Me)

                clsTired.ShowDialog(Me)
                clsDrinks.ShowDialog(Me)





                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)


                x += 1

            ElseIf x = 7 Then

                'clsWant.ShowDialog(Me)
                'clsDifficult.ShowDialog(Me)
                'clsNeed.ShowDialog(Me)
                clsEnjoy.ShowDialog(Me)
                'clsPerfect.ShowDialog(Me)
                'clsCrave.ShowDialog(Me)
                clsIntox.ShowDialog(Me)
                clsAnxious.ShowDialog(Me)
                clsStim.ShowDialog(Me)
                clsDrinks.ShowDialog(Me)

                clsRelax.ShowDialog(Me)
                'clsFrustration.ShowDialog(Me)

                'clsIntox.ShowDialog(Me)

                clsTired.ShowDialog(Me)

                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)



                x += 1

            Else

                'clsWant.ShowDialog(Me)
                'clsDifficult.ShowDialog(Me)
                'clsNeed.ShowDialog(Me)
                clsDrinks.ShowDialog(Me)
                clsAnxious.ShowDialog(Me)
                clsEnjoy.ShowDialog(Me)
                'clsPerfect.ShowDialog(Me)
                'clsCrave.ShowDialog(Me)




                clsRelax.ShowDialog(Me)
                'clsFrustration.ShowDialog(Me)

                clsIntox.ShowDialog(Me)
                clsStim.ShowDialog(Me)
                clsTired.ShowDialog(Me)

                clsThanks.ShowDialog(Me)
                clsBlank.ShowDialog(Me)


                x += 1
                x = 0      'to force back to start
            End If

        Loop
    End Sub

    Private Sub Quizzer()


        Do

            'clsWant.ShowDialog(Me)
            'clsDifficult.ShowDialog(Me)
            'clsNeed.ShowDialog(Me)
            clsEnjoy.ShowDialog(Me)
            'clsPerfect.ShowDialog(Me)
            'clsCrave.ShowDialog(Me)

            clsIntox.ShowDialog(Me)
            clsDrinks.ShowDialog(Me)

            clsRelax.ShowDialog(Me)
            'clsFrustration.ShowDialog(Me)
            clsAnxious.ShowDialog(Me)
            'clsIntox.ShowDialog(Me)
            clsStim.ShowDialog(Me)
            clsTired.ShowDialog(Me)

            clsThanks.ShowDialog(Me)
            clsBlank.ShowDialog(Me)

        Loop
    End Sub

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
