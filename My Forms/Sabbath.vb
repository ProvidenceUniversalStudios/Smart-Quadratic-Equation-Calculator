Imports System.IO
Public Class Sabbath
    Public Const SabbathHour As Date = #6:00:00 PM#
    Public sabbathEnd As Date = Now.Year.ToString & "/" & Now.Month.ToString & "/" & (Now.Day.ToString).ToString & " " & "6:00 : 00 PM"
    Public aftsabbathtime As Date = DateAdd(DateInterval.Day, 1, sabbathEnd)

    'When form loads
    Private Sub Sabbath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    'CLosing the form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    'Sub to evaluate time
    Private Sub evaluateTime()
        If My.Computer.Clock.LocalTime.DayOfWeek.ToString = "Friday" Then
            If Now < SabbathHour Then
                Timer1.Stop()
                Main.Show()
                Me.Close()
            Else
                Label1.Text = "It's Sabbath time, please wait " & DateDiff(DateInterval.Hour, Now, aftSabbathTime) & " more hour(s)"
            End If
        ElseIf My.Computer.Clock.LocalTime.DayOfWeek.ToString = "Saturday" Then
            If Now.TimeOfDay.ToString > SabbathHour Then
                Timer1.Stop()
                Main.Show()
                Me.Close()
            Else
                If DateDiff(DateInterval.Minute, Now, sabbathEnd) < 61 Then
                    Label1.Text = "It's Sabbath time, please wait " & DateDiff(DateInterval.Minute, Now, sabbathEnd) & " more minute(s)"
                Else
                    Label1.Text = "It's Sabbath time, please wait " & DateDiff(DateInterval.Hour, Now, sabbathEnd) & " more hour(s)"
                End If
            End If
        End If
    End Sub
    'Tick event
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        evaluateTime()
    End Sub
End Class