Imports System.IO
Public Class Serial_Key_Verifier

    'Global variables
    Dim count As Integer = 0
    Dim time As Date
    Dim trTime As Date
    Dim rand As New Random

    'Load event
    Private Sub Serial_Key_Verifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\mite.txt") Then
            Try
                time = Main.decrypt(File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\mite.txt"))
            Catch
                time = DateAdd(DateInterval.Hour, 1, Now)
            End Try
        End If
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Tmite.txt") Then
            Try
                trTime = Main.decrypt(File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Tmite.txt"))
            Catch ex As Exception
                btnTrial.Enabled = False
                lblTrial.Visible = True
            End Try
        Else
            trTime = DateAdd(DateInterval.Hour, 72, Now)
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Tmite.txt", Encrypt(trTime))
        End If
        If Now > trTime Then
            btnTrial.Enabled = False
            lblTrial.Visible = True
        End If
        Timer1.Start()
    End Sub
    'TextChanged event
    Private Sub txtKey_TextChanged(sender As Object, e As EventArgs) Handles txtKey.TextChanged
        If txtKey.TextLength = 10 Then
            If txtKey.Text = "Pa$$wordGG" Then
                Dim objenums As New MyEnumerations
                Dim myname As String = My.Computer.Name.ToString
                File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & "gimly.gim", objenums.AuthEncrypt(myname, rand))
                File.SetAttributes(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & "gimly.gim", FileAttributes.System Or FileAttributes.Hidden)
                File.Delete(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & "mite.txt")
                File.Delete(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Tmite.txt")
                MessageBox.Show("Application successfully registered", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmCalculator.trial = False
                frmSetAccount.ShowDialog()
                Me.Dispose()
            Else
                MessageBox.Show("You have entered an invalid serial key", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtKey.Focus()
                txtKey.SelectAll()
                count += 1
                If count = 3 Then
                    Dim enctime = Encrypt(DateAdd(DateInterval.Minute, 5, Now))
                    File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & "mite.txt", enctime)
                    MessageBox.Show("You have taken the maximum number attempts. Try again after 5 minutes", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
        End If
    End Sub
    'Tick event
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Now < time Then
            txtKey.Visible = False
            Label1.Text = "Please wait " & DateDiff(DateInterval.Second, Now, time).ToString & " second(s)"
            Label1.Location = New System.Drawing.Point(0, 100)
        Else
            Timer1.Stop()
            Label1.Text = "Please enter the serial key"
            Label1.Location = New System.Drawing.Point(0, 60)
            txtKey.Visible = True
            txtKey.Focus()
        End If
    End Sub
    'Button click event
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    'Encrypt
    Private Function Encrypt(ByVal name As String)
        Dim trimmedName = name.Trim()
        Dim codename As String = Nothing
        For Each character In trimmedName
            codename &= Microsoft.VisualBasic.AscW(character) & ":"
        Next
        Return codename.Substring(0, codename.Count - 1)
    End Function
    'Trial
    Private Sub btnTrial_Click(sender As Object, e As EventArgs) Handles btnTrial.Click
        Dim diff = DateDiff(DateInterval.Day, Now, trTime)
        MsgBox("You are running the trial version now. After " & diff & " day(s) you will be required to enter the serial key to continue using the application.", MsgBoxStyle.Information, "Quadratic Equation Calculator")
        frmCalculator.trial = True
        frmCalculator.Show()
        Me.Close()
    End Sub
End Class