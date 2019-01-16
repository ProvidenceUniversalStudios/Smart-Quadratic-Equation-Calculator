' Splash Screen Info
Public NotInheritable Class Quad_Splash

    'Global Variable
    Dim transparency As Double
    Dim xCoordinate As Integer = 1
    Dim x As Integer = 0
    Dim objenums As New MyEnumerations

    Private Sub Quad_Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tmrTransparency.Start()
        tmrTextAnimation.Start()
        Panel1.Visible = True
    End Sub

    'Transparency Animation
    Private Sub tmrTransparency_Tick(sender As Object, e As EventArgs) 
        transparency += 0.019
        Opacity = transparency
        If Opacity >= 1 Then
            tmrTransparency.Stop()
            transparency = 0
        End If
    End Sub
    'Text Animation
    Private Sub tmrTextAnimation_Tick(sender As Object, e As EventArgs) Handles tmrTextAnimation.Tick

        If objenums.slideanimation(x, 26, xCoordinate) = 0 Then
            Panel1.Location = New System.Drawing.Point(xCoordinate, 43)
        Else
            tmrTextAnimation.Stop()
        End If
    End Sub
End Class
