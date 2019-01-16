Public Class frmAboutEquation

    'Loading the Rich Text File with the Quadratic Equation info

    Private Sub frmAboutEquation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDescription.Rtf = My.Resources.Quadratic_Equations
    End Sub

    'Closing the Form

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrintDescription_Click(sender As Object, e As EventArgs) Handles btnPrintDescription.Click
        txtDescription.SaveFile(Main.savedTests & "\" & "About Quadratic Equations.rtf")
        Process.Start(Main.savedTests & "\" & "About Quadratic Equations.rtf")
    End Sub
End Class