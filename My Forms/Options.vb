Imports System.IO
Public Class Options
    Dim rand As New Random

    Private Sub RestoreDefaults()

    End Sub
    Private Sub chkDP_CheckedChanged(sender As Object, e As EventArgs) Handles chkDP.CheckedChanged
        If chkDP.Checked = True Then
            numDecimalPs.Enabled = True
        Else
            numDecimalPs.Enabled = False
        End If
    End Sub
    Private Sub saveChanges()
        Dim myoptions As New CheckOptions
        CheckOptions.checkDP = chkDP.Checked
        If numDecimalPs.Enabled = True Then
            CheckOptions.decimalplaces = numDecimalPs.Value
        End If
        CheckOptions.resumeCalc = chkResumeCalculator.Checked
        If radioTransparent.Checked = True Then
            CheckOptions.theme = True
        End If
        CheckOptions.PracticePs = numPracticePs.Value
        CheckOptions.ShowAns = chkShowAns.Checked
        CheckOptions.resumePrac = chkResumePractice.Checked
        CheckOptions.printAns = chkPrintAns.Checked
        CheckOptions.checkPass = chkPassword.Checked
        CheckOptions.checkusers = chkMulUsers.Checked
        Dim objenums As New MyEnumerations
        Dim newSettings As String = objenums.AuthEncrypt(CheckOptions.decimalplaces & ":" & CheckOptions.PracticePs & ":" & CheckOptions.resumeCalc & ":" & CheckOptions.resumePrac & ":" & CheckOptions.ShowAns & ":" & CheckOptions.theme & ":" & CheckOptions.checkDP & ":" & CheckOptions.printAns & ":" & CheckOptions.checkPass & ":" & CheckOptions.checkusers, rand)
        Try
            Dim settingspath = Nothing
            If Main.currentuser = frmCalculator.adminusername Then
                settingspath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\vital.txt"
            Else
                settingspath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Main.currentdir & "\vital.txt"
            End If
            File.WriteAllText(settingspath, newSettings)
        Catch ex As Exception
            MsgBox("An error occurred while saving your settings. If error persists please contact Providence Universal Studios", MsgBoxStyle.Exclamation, "Error")
        End Try
        myoptions.applysettings()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        saveChanges()
        Me.Close()
    End Sub
    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmChange.ShowDialog()
    End Sub

    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        Dim msg As String = "Are you sure you want to delete your account?"
        Dim title As String = "Note"
        Dim icon = MessageBoxIcon.Question
        Dim button = MessageBoxButtons.YesNo
        Dim response = MessageBox.Show(msg, title, button, icon)
        Try
            If response = MsgBoxResult.Yes Then
                Dim path = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Main.currentdir
                For Each lev1file In Directory.GetFiles(path)
                    For Each folder In Directory.GetDirectories(path)
                        For Each lev2file In Directory.GetFiles(folder)
                            File.Delete(lev2file)
                        Next
                        Directory.Delete(folder)
                    Next
                    File.Delete(lev1file)
                Next
                Directory.Delete(path)
            End If
            MsgBox("Your account has been successfully deleted", MsgBoxStyle.Information, "Note")
        Catch ex As Exception
            MsgBox("An error occurred while trying to delete account. If error persists please contact Providence Universal Studios", MsgBoxStyle.Exclamation, "Error")
        End Try
        frmCalculator.Dispose()
        Main.currentdir = Nothing
        Main.currentuser = Nothing
        frmCalculator.adminusername = Nothing
        Dim objchecops As New CheckOptions
        objchecops.applysettings()
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btynLogout_Click(sender As Object, e As EventArgs) Handles btynLogout.Click
        Me.saveChanges()
        frmCalculator.SaveOpData()
        frmCalculator.Dispose()
        Main.currentdir = Nothing
        Main.currentuser = Nothing
        frmCalculator.adminusername = Nothing
        Dim objchecops As New CheckOptions
        objchecops.applysettings()
        Main.Show()
        Me.Close()
    End Sub
End Class