<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAboutEquation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then DisposeShapeContainer(ShapeContainer1)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Protected Sub DisposeShapeContainer(ByVal ashapecontainer As Microsoft.VisualBasic.PowerPacks.ShapeContainer)
        If ashapecontainer IsNot Nothing Then
            If ashapecontainer.Shapes IsNot Nothing Then
                Dim tshapes As New Generic.List(Of Microsoft.VisualBasic.PowerPacks.Shape)
                For Each tshape As Microsoft.VisualBasic.PowerPacks.Shape In ashapecontainer.Shapes
                    tshapes.Add(tshape)
                Next
                ashapecontainer.Shapes.Clear()
                ashapecontainer.Shapes.Dispose()
                For Each tshape As Microsoft.VisualBasic.PowerPacks.Shape In tshapes
                    tshape.Dispose()
                Next
            End If
            ashapecontainer.Dispose()
        End If
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAboutEquation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnPrintDescription = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Location = New System.Drawing.Point(323, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "About Quadratic Equations"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnClose.Location = New System.Drawing.Point(802, 420)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 33)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Done"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.BulletIndent = 1
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.txtDescription.Location = New System.Drawing.Point(30, 91)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(859, 280)
        Me.txtDescription.TabIndex = 3
        Me.txtDescription.Text = ""
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Teal
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 19
        Me.LineShape1.X2 = 906
        Me.LineShape1.Y1 = 83
        Me.LineShape1.Y2 = 83
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(925, 491)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Teal
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 19
        Me.LineShape2.X2 = 906
        Me.LineShape2.Y1 = 394
        Me.LineShape2.Y2 = 394
        '
        'btnPrintDescription
        '
        Me.btnPrintDescription.BackColor = System.Drawing.Color.White
        Me.btnPrintDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintDescription.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintDescription.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnPrintDescription.Location = New System.Drawing.Point(695, 420)
        Me.btnPrintDescription.Name = "btnPrintDescription"
        Me.btnPrintDescription.Size = New System.Drawing.Size(87, 33)
        Me.btnPrintDescription.TabIndex = 5
        Me.btnPrintDescription.Text = "Print"
        Me.btnPrintDescription.UseVisualStyleBackColor = False
        '
        'frmAboutEquation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(925, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrintDescription)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.MaximizeBox = False
        Me.Name = "frmAboutEquation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About the Quadratic Equations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnPrintDescription As System.Windows.Forms.Button
End Class
