Public Class frmCreateList

    'Global variables
    Dim objEnumerations As New MyEnumerations
    Dim MathArrayList As New ArrayList
    Dim equation As String
    Dim virtualtextbox As New RichTextBox

    'Load event
    Private Sub frmCreateList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtA.Focus()
    End Sub

    'Button Click events
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtA.Text <> Nothing And txtB.Text <> Nothing And txtC.Text <> Nothing Then
            Try
                Dim root1 As Double
                Dim root2 As Double
                objEnumerations.CalcQuadratic(txtA.Text, txtB.Text, txtC.Text, root1, root2)
                objEnumerations.ProduceEquation(txtA.Text, txtB.Text, txtC.Text, equation)
                MathArrayList.Add(String.Format("{0:n2}", root1) & ":" & String.Format("{0:n2}", root2) & ":" & equation)
                listSums.Items.Add(equation)
            Catch ex As Exception
                MsgBox("Invalid input, please check your values", MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        diaSaveList.InitialDirectory = Main.savedTests
        objEnumerations.SaveList(diaSaveList, MathArrayList)
    End Sub
    Private Sub btnPractice_Click(sender As Object, e As EventArgs) Handles btnPractice.Click
        If listSums.Items.Count > 0 Then
            frmPracticeProblems.StoreProbs.Clear()
            frmPracticeProblems.listSums.Items.Clear()
            frmPracticeProblems.StoreProbs.AddRange(MathArrayList)
            frmPracticeProblems.listSums.Items.AddRange(listSums.Items)
            frmPracticeProblems.ShowAnsList()
            Me.Visible = False
        Else
            MessageBox.Show("Please enter some problems for you to practice", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If listSums.SelectedIndex <> -1 Then
            MathArrayList.RemoveAt(listSums.SelectedIndex)
            listSums.Items.RemoveAt(listSums.SelectedIndex)
        Else
            MessageBox.Show("Please select an item to remove", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Select Case MessageBox.Show("Do you want to discard your changes?", "Note", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                Me.Dispose()
            Case Windows.Forms.DialogResult.No
                Me.Close()
            Case Else
                Me.BringToFront()
        End Select
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If listSums.Items.Count <> 0 Then
            objEnumerations.PrintMath(MathArrayList, virtualtextbox)
        Else
            MsgBox("You cannot print an empty list", MsgBoxStyle.Information, "Note")
        End If
    End Sub


    'Text Leave events
    Private Sub txtA_Leave(sender As Object, e As EventArgs) Handles txtA.Leave
        If objEnumerations.ValTextInput(txtA.Text, txtB.Text, txtC.Text) = 1 Then
            txtA.Focus()
            txtA.SelectAll()
        End If
    End Sub
    Private Sub txtB_Leave(sender As Object, e As EventArgs) Handles txtB.Leave
        If objEnumerations.ValTextInput(txtB.Text, txtA.Text, txtC.Text) = 1 Then
            txtB.Focus()
            txtB.SelectAll()
        End If
    End Sub
    Private Sub txtC_Leave(sender As Object, e As EventArgs) Handles txtC.Leave
        If objEnumerations.ValTextInput(txtC.Text, txtA.Text, txtB.Text) = 1 Then
            txtC.Focus()
            txtC.SelectAll()
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class