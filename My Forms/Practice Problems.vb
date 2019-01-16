Imports System.IO

Public Class frmPracticeProblems

    'Global variables
    Dim A, B, C, ansRoot1, ansRoot2, doubrand As Double
    Dim objEnumerations As New MyEnumerations
    Public StoreProbs As New ArrayList
    Dim Rand As New Random
    Dim mydigits As Integer = Nothing
    Dim sumnumber As Integer = 1
    Dim virtualtextbox As New RichTextBox
    Public Shared PProbs As Integer = 25
    Public Shared ShowAnsbtn As Boolean = True
    Public Shared savedata As Boolean = False

    'Button Click events
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        listSums.Items.Clear()
        StoreProbs.Clear()
        UseWaitCursor = True
        pBarSums.Visible = True
        pBarSums.Value = 0
        pBarSums.Maximum = PProbs
        GenerateMath()
        UseWaitCursor = False
        pBarSums.Visible = False
        sumnumber = 1
        ShowAnsList()
        listSums.SelectedIndex = 0
        txtRoot1.Focus()
    End Sub
    Private Sub btnCreateList_Click(sender As Object, e As EventArgs) Handles btnCreateList.Click
        frmCreateList.ShowDialog()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If (txtRoot1.Text = Nothing Or txtRoot2.Text = Nothing) = False Then
            Try
                If ((txtRoot1.Text = ansRoot1 Or txtRoot1.Text = ansRoot2) And (txtRoot2.Text = ansRoot2 Or txtRoot2.Text = ansRoot1)) And (ansRoot1 = ansRoot2) Then
                    MsgBox("Your answers are correct")
                ElseIf ((txtRoot1.Text = ansRoot1 Or txtRoot1.Text = ansRoot2) And (txtRoot2.Text = ansRoot2 Or txtRoot2.Text = ansRoot1)) And (ansRoot1 <> ansRoot2) Then
                    If (txtRoot1.Text = ansRoot1 Or txtRoot1.Text = ansRoot2) And (txtRoot2.Text <> ansRoot1 And txtRoot2.Text <> ansRoot2) Then
                        MsgBox("Root 1 is correct, try again for the second root")
                    ElseIf (txtRoot2.Text = ansRoot2 Or txtRoot2.Text = ansRoot1) And (txtRoot1.Text <> ansRoot1 And txtRoot1.Text <> ansRoot2) Then
                        MsgBox("Root 2 is correct, try again for the first root")
                    ElseIf (txtRoot1.Text = ansRoot1 Or txtRoot1.Text = ansRoot2) And (txtRoot2.Text = ansRoot2 Or txtRoot2.Text = ansRoot1) And (txtRoot1.Text <> txtRoot2.Text) Then
                        MsgBox("Your answers are correct", MsgBoxStyle.Information, "Note")
                    Else
                        MsgBox("You have provided a duplicate root")
                    End If
                ElseIf (txtRoot1.Text = ansRoot1 Or txtRoot1.Text = ansRoot2) And (txtRoot2.Text <> ansRoot1 And txtRoot2.Text <> ansRoot2) Then
                    MsgBox("Root 1 is correct, try again for the second root")
                ElseIf (txtRoot2.Text = ansRoot2 Or txtRoot2.Text = ansRoot1) And (txtRoot1.Text <> ansRoot1 And txtRoot1.Text <> ansRoot2) Then
                    MsgBox("Root 2 is correct, try again for the first root")
                Else
                    MsgBox("Both your answers are incorrect please try again")
                End If
            Catch ex As InvalidCastException
                MsgBox("There is an error in your input, please check your values", MsgBoxStyle.Exclamation, "Error")
            End Try
        Else
            MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub btnSaveSums_Click(sender As Object, e As EventArgs) Handles btnSaveSums.Click
        diaSaveTest.InitialDirectory = Main.savedTests
        objEnumerations.SaveList(diaSaveTest, StoreProbs)
    End Sub
    Private Sub btnLoadSums_Click(sender As Object, e As EventArgs) Handles btnLoadSums.Click
        objEnumerations.LoadTest(diaOpenTest, listSums, StoreProbs)
        If listSums.Items.Count > 0 Then
            ShowAnsList()
        Else
            HideAnsList()
        End If
    End Sub
    Private Sub btnPrintSums_Click(sender As Object, e As EventArgs) Handles btnPrintSums.Click
        If listSums.Items.Count <> 0 Then
            objEnumerations.PrintMath(StoreProbs, virtualtextbox)
        Else
            MsgBox("You cannot print an empty list", MsgBoxStyle.Information, "Note")
        End If
    End Sub
    Private Sub btnShowAnswers_Click(sender As Object, e As EventArgs) Handles btnShowAnswers.Click
        MessageBox.Show("Roots of x:" & Environment.NewLine & "x = " & ansRoot1.ToString & " or " & ansRoot2.ToString, "Roots of x", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btnViewTests_Click(sender As Object, e As EventArgs) Handles btnViewTests.Click
        Process.Start(Main.savedTests)
    End Sub


    'TextBox Leave Validations
    Private Sub txtRoot1_Leave(sender As Object, e As EventArgs) Handles txtRoot1.Leave
        If txtRoot1.Text = "Complex" Then
        Else
            If txtRoot1.Text <> Nothing And IsNumeric(txtRoot1.Text) = False Then
                MsgBox("Please enter a numeric value")
                txtRoot1.Focus()
                txtRoot1.SelectAll()
            End If
        End If
    End Sub
    Private Sub txtRoot2_Leave(sender As Object, e As EventArgs) Handles txtRoot2.Leave
        If txtRoot2.Text = "Complex" Then
        Else
            If txtRoot2.Text <> Nothing And IsNumeric(txtRoot2.Text) = False Then
                MsgBox("Please enter a numeric value")
                txtRoot2.Focus()
                txtRoot2.SelectAll()
            End If
        End If
    End Sub

    'Selection of Different index events
    Private Sub comboDifficulty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboDifficulty.SelectedIndexChanged
        If comboDifficulty.SelectedIndex <> -1 Then
            btnGenerate.Enabled = True
        Else
            btnGenerate.Enabled = False
        End If
    End Sub
    Private Sub listSums_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listSums.SelectedIndexChanged
        If listSums.SelectedIndex <> -1 Then
            ShowAnsList()
            btnConfirm.Enabled = True
            btnShowAnswers.Enabled = True
            Dim itemstring As String
            itemstring = StoreProbs.Item(listSums.SelectedIndex)
            Dim roots = itemstring.Split(":")
            ansRoot1 = roots(0)
            ansRoot2 = roots(1)
        Else
            btnConfirm.Enabled = False
            btnShowAnswers.Enabled = False
        End If
    End Sub

    'Sub to generate math
    Private Sub GenerateMath()
        For Math = 1 To PProbs
            Dim root1 As Double = Nothing
            Dim root2 As Double = Nothing
            Dim storeProb As String = Nothing
            Dim item As String = Nothing
            objEnumerations.Randomize(A, B, C, comboDifficulty.SelectedIndex, Rand, mydigits)
            objEnumerations.CalcQuadratic(A, B, C, root1, root2)
            objEnumerations.ProduceEquation(A, B, C, item)
            listSums.Items.Add(sumnumber.ToString & ".  " & item)
            storeProb = String.Format("{0:n2}", root1) & ":" & String.Format("{0:n2}", root2) & ":" & item
            StoreProbs.Add(storeProb)
            pBarSums.Value = sumnumber
            sumnumber += 1
        Next Math
        Me.BringToFront()
    End Sub

    'Sub to show answer section
    Public Sub ShowAnsList()
        lblRoot1.Visible = True
        lblRoot2.Visible = True
        txtRoot1.Visible = True
        txtRoot2.Visible = True
        lbl2dp.Visible = True
        btnConfirm.Visible = True
        If ShowAnsbtn = True Then
            btnShowAnswers.Visible = True
        End If
    End Sub

    'Sub to hide answer list
    Private Sub HideAnsList()
        lblRoot1.Visible = False
        lblRoot2.Visible = False
        txtRoot1.Visible = False
        txtRoot2.Visible = False
        lbl2dp.Visible = False
        btnConfirm.Visible = False
        btnShowAnswers.Visible = False
    End Sub

    'When form is closing
    Private Sub frmPracticeProblems_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim msg = "Do you want to finish the sums later?"
        Dim caption = "Note"
        Dim buttons = MessageBoxButtons.YesNoCancel
        Dim icon = MessageBoxIcon.Question
        Dim Dialog = MessageBox.Show(msg, caption, buttons, icon)

        If Dialog = Windows.Forms.DialogResult.Yes Then
            If savedata = True Then
                Dim settingspath = Nothing
                If Main.currentuser <> frmCalculator.adminusername Then
                    settingspath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Main.currentdir & "\resumePracs.txt"
                Else
                    settingspath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\resumePracs.txt"
                End If
                objEnumerations.Savestuff(settingspath, StoreProbs)
            End If
            Me.Visible = False
        ElseIf Dialog = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
            Me.BringToFront()
        Else
            If savedata = True Then
                Try
                    Dim settingspath = Nothing
                    If Main.currentuser <> frmCalculator.adminusername Then
                        settingspath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Main.currentdir & "\resumePracs.txt"
                    Else
                        settingspath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\resumePracs.txt"
                    End If
                    File.WriteAllText(settingspath, Nothing)
                Catch ex As Exception
                    MsgBox("An error has occurred" & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Error")
                End Try
            End If
            frmCreateList.Dispose()
            Me.Dispose()
        End If
    End Sub

    'Load event
    Private Sub frmPracticeProblems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RectangleShape1.SendToBack()
        Dim settingspath = Nothing
        If savedata = True Then
            If Main.currentuser <> frmCalculator.adminusername Then
                settingspath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Main.currentdir & "\resumePracs.txt"
            Else
                settingspath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\resumePracs.txt"
            End If
            objEnumerations.LoadStuffLbox(settingspath, StoreProbs, listSums)
        Else
            If File.Exists(settingspath) Then
                File.Delete(settingspath)
            End If
        End If
    End Sub
End Class