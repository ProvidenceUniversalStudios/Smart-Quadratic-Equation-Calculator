Imports System.IO
Public Class frmCreateNewUser
    Dim objenums As New MyEnumerations
    Dim rand As New Random
    Dim adminuserdetails = File.ReadAllLines(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\kj50.plkin")
    Dim adminusername = objenums.decrypt(adminuserdetails(0)).ToLower
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text.Trim <> Nothing And txtPassword.Text.Trim <> Nothing And txtConfPass.Text.Trim <> Nothing Then
            If Directory.GetDirectories(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData).Count = 0 Then
                If txtUsername.Text.Trim.ToLower = adminusername Then
                    MsgBox("The username you have provided is currently in use", MsgBoxStyle.Exclamation)
                    txtUsername.Focus()
                    txtUsername.SelectAll()
                Else
                    validateinfo()
                End If
                Exit Sub
            End If
            For Each item In Directory.GetDirectories(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData)
                Dim indexes = item.Count()
                Do
                    indexes -= 1
                    If item.Chars(indexes) = "\" Then
                        item = item.Substring(indexes + 1)
                        Exit Do
                    End If
                Loop
                Try
                    Dim dirname = objenums.decrypt(item).ToLower
                    If dirname = txtUsername.Text.Trim.ToLower Or txtUsername.Text.Trim.ToLower = adminusername Then
                        MsgBox("The username you have provided is currently in use", MsgBoxStyle.Exclamation)
                        txtUsername.Focus()
                        txtUsername.SelectAll()
                        Exit For
                    Else
                        If txtConfPass.Text = txtPassword.Text Then
                            Main.currentuser = item
                            validateinfo()
                            Exit For
                        Else
                            MsgBox("The passwords are not matching", MsgBoxStyle.Exclamation)
                            txtConfPass.Clear()
                            txtPassword.Focus()
                            txtPassword.SelectAll()
                            Exit For
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
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
    Private Sub validateinfo()
        Dim username As String = Nothing
        Dim password As String = Nothing
        username = txtUsername.Text
        password = txtPassword.Text
        Try
            Dim encUser As String = objenums.AuthEncrypt(txtUsername.Text.Trim, rand)
            Dim encPass As String = objenums.AuthEncrypt(password, rand)
            Dim userdirectory = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & encUser
            Directory.CreateDirectory(userdirectory)
            Directory.CreateDirectory(userdirectory & "\Recall Lists")
            Directory.CreateDirectory(userdirectory & "\Saved Tests")
            Main.currentuser = txtUsername.Text.Trim
            Main.currentdir = encUser
            File.WriteAllText(userdirectory & "\kj50.plkin", encUser & vbCrLf & encPass)
            MsgBox("Your account data has been successfully saved", MsgBoxStyle.Information)
            Dim myops As New CheckOptions
            myops.applysettings()
            frmCalculator.Checktrial()
            frmCalculator.Show()
            frmLogin.Dispose()
            Me.Dispose()
        Catch ex As ArgumentException
            MsgBox("Please Check your details", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        frmLogin.Show()
        Me.Dispose()
    End Sub
End Class