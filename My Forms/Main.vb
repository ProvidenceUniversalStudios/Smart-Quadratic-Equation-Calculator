Imports System.IO
Public Class Main

    Public Shared mainFolder As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Quadratic Equation Calculator"
    Public Shared settingsFolder As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
    Public Shared currentuser As String = Nothing
    Public Shared savedRecalls As String = mainFolder & "\Recall Lists"
    Public Shared savedTests As String = mainFolder & "\Tests and Printouts"
    Public Shared currentdir As String = Nothing
    Dim objenums As New MyEnumerations
    Dim adminuserdetails
    Dim adminusername As String = Nothing
    Dim y As Integer = 0
    Dim x As Integer = 0
    Dim xcoordinate As Integer = -17
    Dim ycoordinate As Integer = -43

    'Button Click event
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If My.Computer.Clock.LocalTime.DayOfWeek.ToString = "Friday" Then
            If Now.TimeOfDay.ToString < Sabbath.SabbathHour Then
                evaluatefiles()
            Else
                Me.Visible = False
                Sabbath.Show()
            End If
        ElseIf My.Computer.Clock.LocalTime.DayOfWeek.ToString = "Saturday" Then
            If Now.TimeOfDay.ToString > Sabbath.SabbathHour Then
                evaluatefiles()
            Else
                Me.Visible = False
                Sabbath.Show()
            End If
        Else
            evaluatefiles()
        End If
    End Sub
    'Sub to evaluate files
    Private Sub evaluatefiles()
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "/" & "gimly.gim") Then
            Dim objenums As New MyEnumerations
            Dim decname As String = objenums.decrypt(File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "/" & "gimly.gim"))
            If decname = My.Computer.Name.ToString Then
                If CheckOptions.checkPass = True Or CheckOptions.checkusers = True Then
                    frmLogin.Show()
                    Me.Close()
                Else
                    frmCalculator.Show()
                    Main.currentuser = adminusername
                    Me.Close()
                End If
            Else
                File.SetAttributes(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "/" & "gimly.gim", FileAttributes.Normal)
                File.Delete(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "/" & "gimly.gim")
                Serial_Key_Verifier.Show()
                Me.Close()
            End If
        Else
            Serial_Key_Verifier.Show()
            Me.Close()
        End If
    End Sub
    'Load event
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BringToFront()
        tmrMainLabel.Start()
        Label3.Text = "ax" & ChrW(&HB2) & " + bx + c = 0"
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\kj50.plkin") Then
            adminuserdetails = File.ReadAllLines(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\kj50.plkin")
            adminusername = objenums.decrypt(adminuserdetails(0))
        End If
        DirectoryandSettInit()
    End Sub
    'Decrypt
    Public Shared Function decrypt(ByVal codename As String)
        Dim name As String = Nothing
        Try
            Dim charcollection = codename.Split(":")
            For Each item In charcollection
                name &= Microsoft.VisualBasic.ChrW(item)
            Next
        Catch ex As Exception
            MessageBox.Show("An error occurred. Please contact Providence Universal for support")
            name = Nothing
        End Try
        Return name
    End Function
    'Directory initialisation
    Private Sub DirectoryandSettInit()
        If Directory.Exists(mainFolder) = False Then
            Directory.CreateDirectory(mainFolder)
        End If
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\vital.txt") Then
            Dim objcheckoptions As New CheckOptions
            objcheckoptions.getSettings()
            objcheckoptions.applysettings()
        End If
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If frmCalculator.Visible = False And frmLogin.Visible = False And Serial_Key_Verifier.Visible = False Then
            Application.Exit()
        End If
    End Sub

    Private Sub tmrMainLabel_Tick(sender As Object, e As EventArgs) Handles tmrMainLabel.Tick
        If objenums.slideanimation(y, 50, ycoordinate, True) = 0 Then
            Label1.Location = New Point(151, ycoordinate)
        Else
            y = 0
            ycoordinate = 382
            tmrMainLabel.Stop()
            Panel2.Visible = True
            tmrPanel.Start()
        End If
    End Sub

    Private Sub tmrPanel_Tick(sender As Object, e As EventArgs) Handles tmrPanel.Tick
        If objenums.slideanimation(-10000, 113, ycoordinate, False) = 0 Then
            Panel1.Location = New Point(0, ycoordinate)
        Else
            tmrPanel.Stop()
        End If
    End Sub

    Private Sub tmrDelay_Tick(sender As Object, e As EventArgs) Handles tmrDelay.Tick

    End Sub

End Class