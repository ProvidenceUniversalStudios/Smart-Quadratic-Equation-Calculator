Imports System.IO

Public Class frmCalculator

    'Global Variables
    Dim objMyEnumClass As New MyEnumerations
    Dim equation As String
    Dim MathArraylist As New ArrayList
    Public Shared myDP As String = Nothing
    Public Shared savedata As Boolean = False
    Public Shared trial As Boolean = False
    Public Shared adminuserfile = Nothing
    Public Shared adminusername = Nothing

    'TextBox Left Events
    Private Sub txtA_Leave(sender As Object, e As EventArgs) Handles txtA.Leave
        If txtA.Text <> Nothing Then
            If IsNumeric(txtA.Text) Then
                If txtA.Text = 0 Then
                    MessageBox.Show("The coefficient of " & "x" & Chr(&HB2) & " cannot be zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtA.Focus()
                    txtA.SelectAll()
                Else
                    If objMyEnumClass.ValTextInput(txtA.Text, txtB.Text, txtC.Text, equation) = 1 Then
                        txtA.Focus()
                        txtA.SelectAll()
                    ElseIf objMyEnumClass.ValTextInput(txtA.Text, txtB.Text, txtC.Text, equation) = 2 Then
                        objMyEnumClass.ProduceEquation(txtA.Text, txtB.Text, txtC.Text, lblequation.Text)
                    ElseIf objMyEnumClass.ValTextInput(txtA.Text, txtB.Text, txtC.Text, equation) = 0 Then
                        lblequation.Text = "Enter your values above"
                    End If
                End If
            Else
                MessageBox.Show("Please enter a numeric value only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtA.Focus()
                txtA.SelectAll()
            End If
        Else
            lblequation.Text = "Enter your values above"
        End If
    End Sub
    Private Sub txtB_Leave(sender As Object, e As EventArgs) Handles txtB.Leave
        lblequation.Text = equation
        If objMyEnumClass.ValTextInput(txtB.Text, txtA.Text, txtC.Text, equation) = 1 Then
            txtB.Focus()
            txtB.SelectAll()
        Else
            If objMyEnumClass.ValTextInput(txtB.Text, txtA.Text, txtC.Text, equation) = 2 Then
                objMyEnumClass.ProduceEquation(txtA.Text, txtB.Text, txtC.Text, lblequation.Text)
            End If
        End If
    End Sub
    Private Sub txtC_Leave(sender As Object, e As EventArgs) Handles txtC.Leave
        lblequation.Text = equation
        If objMyEnumClass.ValTextInput(txtC.Text, txtA.Text, txtB.Text, equation) = 1 Then
            txtC.Focus()
            txtC.SelectAll()
        Else
            If objMyEnumClass.ValTextInput(txtC.Text, txtA.Text, txtB.Text, equation) = 2 Then
                objMyEnumClass.ProduceEquation(txtA.Text, txtB.Text, txtC.Text, lblequation.Text)
            End If
        End If
    End Sub

    'Button Click Events
    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        lblFactors.Visible = False
        If (txtA.Text = "" Or txtB.Text = "" Or txtC.Text = "") = False Then
            If txtA.Text = 0 Then
                MsgBox("The coefficient of " & "x" & Chr(&HB2) & " cannot be zero", MsgBoxStyle.Exclamation, "Note")
            Else
                Try 'In case ProduceEquation() is not called
                    objMyEnumClass.ProduceEquation(txtA.Text, txtB.Text, txtC.Text, lblequation.Text)
                Catch ex As Exception
                End Try
                Dim root1 As Double
                Dim root2 As Double
                Dim resultstring As String = Nothing
                Try
                    objMyEnumClass.CalcQuadratic(txtA.Text, txtB.Text, txtC.Text, root1, root2, resultstring)
                    If Double.IsNaN(root1) Or Double.IsNaN(root2) Then
                        lblroots.Text = "Two complex conjugate roots"
                    ElseIf (root1 = root2) And (Double.IsNaN(root1) = False Or Double.IsNaN(root2) = False) Then
                        lblroots.Text = "x = " & root1 & " twice"
                    Else
                        lblroots.Text = "x = " & Format(root1, myDP) & " or " & Format(root2, myDP)
                    End If
                    Label5.Text = "Roots of x:"
                    If resultstring <> Nothing Then
                        Label5.Text = "Roots of x and the factors:"
                        lblroots.Location = New System.Drawing.Point(165, 68)
                        If trial = True Then
                            lblFactors.Visible = False
                            lblroots.Location = New System.Drawing.Point(164, 107)
                        Else
                            lblFactors.Text = resultstring
                            lblFactors.Visible = True
                        End If
                    Else
                        lblroots.Location = New System.Drawing.Point(164, 107)
                    End If
                    Label5.Visible = True
                    lneRoot.Visible = True
                    lblroots.Visible = True
                    If trial = False Then
                        objMyEnumClass.StoreMathDisplayinListView(listSums, lblequation.Text, lblroots.Text, MathArraylist, resultstring)
                    End If
                Catch ex As InvalidCastException
                    MessageBox.Show("There is an error in your input, please check your values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As ArgumentNullException
                    MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
        Else
            MsgBox("Please fill in all fields", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        listSums.Items.Clear()
        MathArraylist.Clear()
        lneRoot.Visible = False
        Label5.Visible = False
        lblroots.Visible = False
        lblFactors.Visible = False
        lblequation.Text = "Enter your values above"
        lblroots.Text = Nothing
        lblFactors.Text = Nothing
    End Sub
    Private Sub listSums_Click(sender As Object, e As EventArgs) Handles listSums.Click
        lblequation.Text = listSums.SelectedItems.Item(0).Text
        lblroots.Text = listSums.SelectedItems.Item(0).SubItems(1).Text
        lblFactors.Text = listSums.SelectedItems.Item(0).SubItems(2).Text
        If lblFactors.Text <> Nothing Then
            Label5.Text = "Roots and factors of x:"
            lblroots.Location = New Point(165, 68)
            lblFactors.Visible = True
        Else
            Label5.Text = "Roots of x:"
            lblFactors.Visible = False
            lblroots.Location = New Point(164, 107)
        End If
        lneRoot.Visible = True
        Label5.Visible = True
        lblroots.Visible = True
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
    End Sub
    Private Sub lblclose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        lblClose.BackColor = Color.DarkRed
        Me.Close()
    End Sub
    Private Sub btnAboutQuad_Click(sender As Object, e As EventArgs) Handles btnAboutQuad.Click
        frmAboutEquation.ShowDialog()
    End Sub
    Private Sub btnSaveList_Click(sender As Object, e As EventArgs) Handles btnSaveList.Click
        diaSaveList.InitialDirectory = Main.savedRecalls
        objMyEnumClass.SaveList(diaSaveList, MathArraylist)
    End Sub
    Private Sub btnLoadList_Click(sender As Object, e As EventArgs) Handles btnLoadList.Click
        objMyEnumClass.LoadList(diaLoadList, listSums, MathArraylist)
    End Sub
    Private Sub lblAbout_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
        frmAbout.ShowDialog()
    End Sub
    Private Sub btnPracticeProbs_Click(sender As Object, e As EventArgs) Handles btnPracticeProbs.Click
        frmPracticeProblems.ShowDialog()
    End Sub
    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Options.ShowDialog()
    End Sub
    Private Sub linkActivate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkActivate.LinkClicked
        Serial_Key_Verifier.Show()
    End Sub


    'Animations
    Private Sub lblClose_MouseDown(sender As Object, e As MouseEventArgs) Handles lblClose.MouseDown
        lblClose.BackColor = Color.DarkRed
        lblClose.ForeColor = Color.White
    End Sub
    Private Sub lblClose_mouseenter(sender As Object, e As EventArgs) Handles lblClose.MouseEnter
        lblClose.BackColor = Color.LightGray
    End Sub
    Private Sub lblClose_MouseLeave(sender As Object, e As EventArgs) Handles lblClose.MouseLeave
        lblClose.BackColor = Color.Transparent
        lblClose.ForeColor = Color.Teal
    End Sub
    Private Sub lblAbout_MouseDown(sender As Object, e As MouseEventArgs) Handles lblAbout.MouseDown
        lblAbout.BackColor = Color.DarkSlateGray
        lblAbout.ForeColor = Color.White
    End Sub
    Private Sub lblAbout_MouseEnter(sender As Object, e As EventArgs) Handles lblAbout.MouseEnter
        lblAbout.BackColor = Color.LightGray
    End Sub
    Private Sub lblAbout_MouseLeave(sender As Object, e As EventArgs) Handles lblAbout.MouseLeave
        lblAbout.BackColor = Color.Transparent
        lblAbout.ForeColor = Color.Teal
    End Sub

    'Closing main form Event
    Private Sub me_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Dim msg As String = "Exit the Application?"
        Dim title As String = "Note"
        Dim icon = MessageBoxIcon.Question
        Dim button = MessageBoxButtons.YesNo
        Dim response = MessageBox.Show(msg, title, button, icon)
        If response = MsgBoxResult.Yes Then
            SaveOpData()
            Application.Exit()
        Else
            e.Cancel = True
            Me.BringToFront()
        End If
    End Sub

    'Load event
    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Checktrial()
    End Sub
    Public Shared Sub SaveOpData()
        If savedata = True Then
            Dim settingspath = Nothing
            If Main.currentuser = frmCalculator.adminusername Then
                settingspath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\resumeCalc.txt"
            Else
                settingspath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Main.currentdir & "\resumeCalc.txt"
            End If
            frmCalculator.objMyEnumClass.Savestuff(settingspath, frmCalculator.MathArraylist)
        End If
        If frmPracticeProblems.savedata = True Then
            Dim pracpath = Nothing
            If Main.currentuser <> frmCalculator.adminusername Then
                pracpath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Main.currentdir & "\resumePracs.txt"
            Else
                pracpath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\resumePracs.txt"
            End If
            frmCalculator.objMyEnumClass.Savestuff(pracpath, frmPracticeProblems.StoreProbs)
        End If
    End Sub
    'Evaluate app
    Public Shared Sub Checktrial()
        If trial = True Then
            frmCalculator.btnOptions.Enabled = False
            frmCalculator.btnPracticeProbs.Enabled = False
            frmCalculator.listSums.Enabled = False
            frmCalculator.btnClearList.Enabled = False
            frmCalculator.btnLoadList.Enabled = False
            frmCalculator.btnSaveList.Enabled = False
            frmCalculator.btnAboutQuad.Enabled = False
            frmCalculator.linkActivate.Visible = True
            frmCalculator.Text = "Quadratic Equation Calculator (Trial)"
            Exit Sub
        Else
            Try
                adminuserfile = File.ReadAllLines(Main.settingsFolder & "\kj50.plkin")
                adminusername = frmCalculator.objMyEnumClass.decrypt(adminuserfile(0))
            Catch ex As Exception
                MsgBox("There has been an error loading your account details. Please re-enter your Universal Acoount details", MsgBoxStyle.Exclamation)
                frmSetAccount.ShowDialog()
                Exit Sub
            End Try
            frmCalculator.btnOptions.Enabled = Not False
            frmCalculator.btnPracticeProbs.Enabled = Not False
            frmCalculator.listSums.Enabled = Not False
            frmCalculator.btnClearList.Enabled = Not False
            frmCalculator.btnLoadList.Enabled = Not False
            frmCalculator.btnSaveList.Enabled = Not False
            frmCalculator.btnAboutQuad.Enabled = Not False
            frmCalculator.panelBtns.Location = New System.Drawing.Point(95, 15)
            frmCalculator.linkActivate.Visible = Not True
            frmCalculator.Text = "Quadratic Equation Calculator (Activated)"
            frmCalculator.lblHey.Visible = True
            If Main.currentuser = Nothing Then
                Main.currentuser = adminusername
            End If
            frmCalculator.lblHey.Text = "Hey there, " & Main.currentuser
            If adminusername <> Nothing Then
                If adminusername <> Main.currentuser Then
                    Options.chkMulUsers.Visible = False
                    Options.chkPassword.Visible = False
                    Options.Button1.Visible = False
                Else
                    Options.btnDeleteAccount.Visible = False
                End If
            End If
        End If
        Dim settingspath = Nothing
        If Main.currentuser <> frmCalculator.adminusername Then
            settingspath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Main.currentdir & "\resumeCalc.txt"
        Else
            settingspath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\resumeCalc.txt"
        End If
        If savedata = True Then
            frmCalculator.objMyEnumClass.LoadStuffLView(settingspath, frmCalculator.MathArraylist, frmCalculator.listSums)
        Else
            If File.Exists(settingspath) Then
                File.Delete(settingspath)
            End If
        End If
    End Sub

    Private Sub frmCalculator_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
        End If
    End Sub
End Class