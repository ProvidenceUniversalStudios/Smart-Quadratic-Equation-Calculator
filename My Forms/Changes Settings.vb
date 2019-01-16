Imports System.IO
Public Class frmChange

    Dim username, oldpassword, newpassword, confirmnew As String
    Dim objEnums As New MyEnumerations
    Dim rand As New Random
    Dim kj50 As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\kj50.plkin"

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        username = txtUsername.Text.Trim
        newpassword = txtNewPass.Text.Trim
        confirmnew = txtConfirmNew.Text.Trim
        If username <> Nothing And oldpassword <> Nothing And newpassword <> Nothing And confirmnew <> Nothing Then
            If txtOldPassword.Text.ToLower = oldpassword.ToLower Then
                If txtNewPass.Text = txtConfirmNew.Text Then
                    File.WriteAllText(kj50, objEnums.AuthEncrypt(username, rand) & vbCrLf & objEnums.AuthEncrypt(newpassword, rand))
                    MsgBox("Your account details have been updated", MsgBoxStyle.Information)
                    frmCalculator.Checktrial()
                    Me.Dispose()
                Else
                    MsgBox("The passwords are not matching, please check your input.", MsgBoxStyle.Exclamation, "Note")
                End If
            Else
                MsgBox("The old password you entered is incorrect", MsgBoxStyle.Exclamation, "Note")
            End If
        Else
            MsgBox("Please fill in all fields", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub frmChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim myData = File.ReadAllLines(kj50)
            username = objEnums.decrypt(myData(0))
            oldpassword = objEnums.decrypt(myData(1))
            txtUsername.Text = username
        Catch ex As Exception
            MsgBox("A fatal error occurred, please contact Providence Universal Studios if error persists", MsgBoxStyle.Exclamation)
            Me.Dispose()
        End Try
    End Sub
    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub
End Class