Imports System.IO

Public Class frmSetAccount
    Dim objenums As New MyEnumerations
    Dim rand As New Random
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text.Trim <> Nothing And txtPassword.Text.Trim <> Nothing And txtConfPass.Text.Trim <> Nothing Then
            If txtConfPass.Text = txtPassword.Text Then
                Validateinfo()
            Else
                MsgBox("The passwords are not matching", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Please fill in all fields", MsgBoxStyle.Exclamation)
            If txtPassword.Text = Nothing Then
                txtPassword.Focus()
            ElseIf txtUsername.Text = Nothing Then
                txtUsername.Focus()
            Else
                txtConfPass.Focus()
            End If
        End If
    End Sub
    'Sub to check login data
    Private Sub Validateinfo()
        Dim username As String = Nothing
        Dim password As String = Nothing
        username = txtUsername.Text
        password = txtPassword.Text
        Dim encUser As String = objenums.AuthEncrypt(username, rand)
        Dim encPass As String = objenums.AuthEncrypt(password, rand)
        File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\kj50.plkin", encUser & vbCrLf & encPass)
        MsgBox("Your account data has been successfully saved", MsgBoxStyle.Information)
        Main.currentuser = username
        frmCalculator.Checktrial()
        frmCalculator.Show()
        Me.Dispose()
    End Sub

    Private Sub frmSetAccount_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\kj50.plkin") = False Then
            e.Cancel = True
            MsgBox("You cannot exit without submitting your account details", MsgBoxStyle.Exclamation)
            Me.BringToFront()
        Else
            frmCalculator.Show()
        End If
    End Sub
End Class