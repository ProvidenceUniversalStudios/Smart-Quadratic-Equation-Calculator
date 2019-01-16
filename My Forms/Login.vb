Imports System.IO
Public Class frmLogin
    Dim objenums As New MyEnumerations
    Dim details As Object
    Dim decUser As String = Nothing
    Dim decPass As String = Nothing
    Dim filelist As ArrayList

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adminuser = File.ReadAllLines(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\kj50.plkin")
        Dim adminname = objenums.decrypt(adminuser(0))
        Dim adminpass = objenums.decrypt(adminuser(1))
        If txtUsername.Text.Trim.ToLower = adminname.ToLower Then
                If txtPassword.Text.Trim.ToLower = adminpass.ToLower Then
                    MsgBox("Login successful", MsgBoxStyle.Information, "Note")
                    Dim newops As New CheckOptions
                    newops.getSettings()
                    newops.applysettings()
                    Main.currentuser = adminname
                    frmCalculator.Show()
                    Me.Close()
                Else
                    MsgBox("Invalid details, please check your username and password", MsgBoxStyle.Exclamation, "Invalid Details")
                    txtPassword.Focus()
                    txtPassword.SelectAll()
                End If
        ElseIf txtPassword.Text.Trim <> Nothing And txtUsername.Text.Trim <> Nothing Then
            If CheckOptions.checkusers = True Then
                If Directory.GetDirectories(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData).Count = 0 Then
                    MsgBox("Invalid details, please check your username and password", MsgBoxStyle.Exclamation, "Invalid Details")
                    Exit Sub
                End If
                For Each item In Directory.GetDirectories(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData)
                    Try
                        Dim indexes = item.Count()
                        Do
                            indexes -= 1
                            If item.Chars(indexes) = "\" Then
                                item = item.Substring(indexes + 1)
                                Exit Do
                            End If
                        Loop
                        Dim dirname As String
                        dirname = objenums.decrypt(item).ToLower
                        If dirname = txtUsername.Text.Trim.ToLower Then
                            details = File.ReadAllLines(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & item & "\kj50.plkin")
                            decUser = objenums.decrypt(details(0))
                            decPass = objenums.decrypt(details(1)).ToLower
                            If txtUsername.Text.ToLower = decUser.ToLower And txtPassword.Text.ToLower = decPass Then
                                MsgBox("Login successful", MsgBoxStyle.Information, "Note")
                                Main.currentuser = decUser
                                Main.currentdir = item
                                Dim newops As New CheckOptions
                                newops.getSettings()
                                newops.applysettings()
                                frmCalculator.Show()
                                Me.Close()
                                Exit Sub
                            Else
                                MsgBox("Invalid details, please check your username and password", MsgBoxStyle.Exclamation, "Incorrect details")
                                txtPassword.Focus()
                                txtPassword.SelectAll()
                            End If
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MsgBox("Invalid details, please check your username and password", MsgBoxStyle.Exclamation, "Incorrect details")
                        txtPassword.Focus()
                        txtPassword.SelectAll()
                        Exit Sub
                    End Try
                Next
                MsgBox("Invalid details, please check your username and password", MsgBoxStyle.Exclamation, "Incorrect details")
            Else
                MsgBox("Invalid details, please check your username and password", MsgBoxStyle.Exclamation, "Incorrect details")
            End If
            ElseIf txtPassword.Text.Trim = Nothing Or txtUsername.Text.Trim = Nothing Then
                MsgBox("Please fill in all fields", MsgBoxStyle.Exclamation, "Error")
                If txtUsername.Text = Nothing Then
                    txtUsername.Focus()
                Else
                    txtPassword.Focus()
                End If
            Else
                MsgBox("Invalid details, please check your username and password", MsgBoxStyle.Exclamation, "Incorrect details")
                txtPassword.Focus()
                txtPassword.SelectAll()
            End If
    End Sub
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            details = File.ReadAllLines(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\kj50.plkin")
            decUser = objenums.decrypt(details(0))
            decPass = objenums.decrypt(details(1)).ToLower
        Catch ex As Exception
            MsgBox("Failed to load your login details, it may have been that the process was priorly disturbed. If problem persists please contact Providence Universal Studios.", MsgBoxStyle.Information, "Error")
            Me.Close()
        End Try
        If CheckOptions.checkusers = True Then
            linkNewUser.Visible = True
        End If
    End Sub
    Private Sub linkNewUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkNewUser.LinkClicked
        frmCreateNewUser.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main.Show()
        Me.Close()
    End Sub
    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If frmCalculator.Visible = True Or frmCreateNewUser.Visible = True Then
        Else
            Main.Show()
        End If
    End Sub
End Class