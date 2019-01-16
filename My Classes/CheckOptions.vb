Imports System.IO
Imports Quadratic_Equation_Calculator.frmCalculator
Imports Quadratic_Equation_Calculator.frmPracticeProblems

Public Class CheckOptions

    'Global variables
    Public Shared decimalplaces As Integer
    Public Shared PracticePs As Integer
    Public Shared theme As Boolean
    Public Shared ShowAns As Boolean
    Public Shared resumeCalc As Boolean
    Public Shared resumePrac As Boolean
    Public Shared checkDP As Boolean
    Public Shared printAns As Boolean
    Public Shared checkPass As Boolean
    Public Shared checkusers As Boolean

    Sub New()
        decimalplaces = 3
        PracticePs = 25
        theme = 0
        ShowAns = True
        resumeCalc = 0
        resumePrac = 0
        checkDP = 0
        printAns = True
        checkPass = False
        checkusers = False
    End Sub
    Public Sub getSettings()
        Dim settingspath As String = Nothing
        If Main.currentuser = frmCalculator.adminusername Then
            settingspath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\vital.txt"
        Else
            settingspath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Main.currentdir & "\vital.txt"
        End If
        If File.Exists(settingspath) Then
            Try
                Dim objenums As New MyEnumerations
                Dim loadedsettings As String = File.ReadAllText(settingspath)
                Dim sensiblesettings As String = objenums.decrypt(loadedsettings)
                Dim settingsArray = sensiblesettings.Split(":")
                decimalplaces = settingsArray(0)
                PracticePs = settingsArray(1)
                resumeCalc = settingsArray(2)
                resumePrac = settingsArray(3)
                ShowAns = settingsArray(4)
                theme = settingsArray(5)
                checkDP = settingsArray(6)
                printAns = settingsArray(7)
                checkPass = settingsArray(8)
                checkusers = settingsArray(9)
            Catch ex As Exception
                MsgBox("Failed to load settings", MsgBoxStyle.Exclamation, "Note")
            End Try
        End If
    End Sub
    Public Sub applysettings()
        'Theme
        If theme = True Then
            frmCalculator.TransparencyKey = System.Drawing.Color.FromArgb(0, 64, 64)
        Else
            frmCalculator.TransparencyKey = Nothing
        End If

        'Decimal places
        If checkDP = True Then
            Dim decimalformat As String = Nothing
            For number = 1 To decimalplaces
                decimalformat += "0"
            Next
            If myDP = "#0." Then
                myDP = "#0"
            Else
                myDP = "#0." & decimalformat
            End If
        Else
            myDP = Nothing
        End If

        'Resume Calculator
        frmCalculator.savedata = resumeCalc
        '-----------------------------------------------------------------------------

        'Number of Practice Problems
        PProbs = PracticePs

        'Show Ans button
        ShowAnsbtn = ShowAns

        'Resume Problems
        frmPracticeProblems.savedata = resumePrac

        'Print answers
        'printAns = printAns

        'Check for multiple user access
        Options.chkMulUsers.Checked = checkusers

        '-----------------------------------------------------------------------------
        Dim LoadedOptions As New Options
        Options.chkDP.Checked = checkDP
        Options.numDecimalPs.Value = decimalplaces
        Options.chkResumeCalculator.Checked = resumeCalc
        If theme = True Then
            Options.radioTransparent.Checked = True
        Else
            Options.radioSolid.Checked = True
        End If
        Options.numPracticePs.Value = PracticePs
        Options.chkShowAns.Checked = ShowAns
        Options.chkResumePractice.Checked = resumePrac
        Options.chkPrintAns.Checked = printAns
        Options.chkPassword.Checked = checkPass
        Options.chkMulUsers.Checked = checkusers
    End Sub
End Class
