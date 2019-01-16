<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPracticeProblems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then disposeshapecontainer(ShapeContainer1)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPracticeProblems))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.diaOpenTest = New System.Windows.Forms.OpenFileDialog()
        Me.diaSaveTest = New System.Windows.Forms.SaveFileDialog()
        Me.listSums = New System.Windows.Forms.ListBox()
        Me.lblTips = New System.Windows.Forms.Label()
        Me.comboDifficulty = New System.Windows.Forms.ComboBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtRoot1 = New System.Windows.Forms.TextBox()
        Me.txtRoot2 = New System.Windows.Forms.TextBox()
        Me.lblRoot1 = New System.Windows.Forms.Label()
        Me.lblRoot2 = New System.Windows.Forms.Label()
        Me.lbl2dp = New System.Windows.Forms.Label()
        Me.btnLoadSums = New System.Windows.Forms.Button()
        Me.btnSaveSums = New System.Windows.Forms.Button()
        Me.btnPrintSums = New System.Windows.Forms.Button()
        Me.lblSelectSum = New System.Windows.Forms.Label()
        Me.btnShowAnswers = New System.Windows.Forms.Button()
        Me.btnCreateList = New System.Windows.Forms.Button()
        Me.pBarSums = New System.Windows.Forms.ProgressBar()
        Me.btnViewTests = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(41, 39)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(238, 34)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Practice Problems"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.LineShape1, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1004, 551)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 344)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.RectangleShape1.Size = New System.Drawing.Size(1003, 206)
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 24
        Me.LineShape1.X2 = 966
        Me.LineShape1.Y1 = 91
        Me.LineShape1.Y2 = 91
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.White
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 30
        Me.LineShape5.X2 = 961
        Me.LineShape5.Y1 = 487
        Me.LineShape5.Y2 = 487
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.White
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 522
        Me.LineShape4.X2 = 963
        Me.LineShape4.Y1 = 360
        Me.LineShape4.Y2 = 360
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.White
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 520
        Me.LineShape3.X2 = 966
        Me.LineShape3.Y1 = 231
        Me.LineShape3.Y2 = 231
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 509
        Me.LineShape2.X2 = 509
        Me.LineShape2.Y1 = 91
        Me.LineShape2.Y2 = 486
        '
        'diaOpenTest
        '
        Me.diaOpenTest.Filter = "G Math Files|*.ggmath"
        Me.diaOpenTest.Title = "Choose G Math File to Load"
        '
        'diaSaveTest
        '
        Me.diaSaveTest.DefaultExt = "ggmath"
        Me.diaSaveTest.Filter = "G Math Files|*.ggmath"
        Me.diaSaveTest.Title = "Choose Save Location"
        '
        'listSums
        '
        Me.listSums.AllowDrop = True
        Me.listSums.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.listSums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listSums.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.listSums.ForeColor = System.Drawing.Color.White
        Me.listSums.FormattingEnabled = True
        Me.listSums.ItemHeight = 23
        Me.listSums.Location = New System.Drawing.Point(47, 137)
        Me.listSums.Name = "listSums"
        Me.listSums.Size = New System.Drawing.Size(410, 301)
        Me.listSums.TabIndex = 2
        '
        'lblTips
        '
        Me.lblTips.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTips.Location = New System.Drawing.Point(534, 102)
        Me.lblTips.Name = "lblTips"
        Me.lblTips.Size = New System.Drawing.Size(354, 119)
        Me.lblTips.TabIndex = 3
        Me.lblTips.Text = resources.GetString("lblTips.Text")
        '
        'comboDifficulty
        '
        Me.comboDifficulty.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comboDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboDifficulty.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.comboDifficulty.ForeColor = System.Drawing.Color.White
        Me.comboDifficulty.FormattingEnabled = True
        Me.comboDifficulty.Items.AddRange(New Object() {"Beginner", "Intermediate", "Mathematician"})
        Me.comboDifficulty.Location = New System.Drawing.Point(539, 249)
        Me.comboDifficulty.MaxDropDownItems = 4
        Me.comboDifficulty.Name = "comboDifficulty"
        Me.comboDifficulty.Size = New System.Drawing.Size(289, 23)
        Me.comboDifficulty.TabIndex = 4
        Me.comboDifficulty.Text = "Select Difficulty level"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.btnConfirm.Location = New System.Drawing.Point(815, 402)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(64, 23)
        Me.btnConfirm.TabIndex = 5
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        Me.btnConfirm.Visible = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.btnClose.Location = New System.Drawing.Point(902, 507)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnGenerate
        '
        Me.btnGenerate.Enabled = False
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.btnGenerate.Location = New System.Drawing.Point(850, 250)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(103, 23)
        Me.btnGenerate.TabIndex = 7
        Me.btnGenerate.Text = "Generate Math"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'txtRoot1
        '
        Me.txtRoot1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRoot1.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoot1.Location = New System.Drawing.Point(585, 409)
        Me.txtRoot1.Name = "txtRoot1"
        Me.txtRoot1.Size = New System.Drawing.Size(100, 15)
        Me.txtRoot1.TabIndex = 8
        Me.txtRoot1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRoot1.Visible = False
        '
        'txtRoot2
        '
        Me.txtRoot2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRoot2.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoot2.Location = New System.Drawing.Point(701, 409)
        Me.txtRoot2.Name = "txtRoot2"
        Me.txtRoot2.Size = New System.Drawing.Size(100, 15)
        Me.txtRoot2.TabIndex = 9
        Me.txtRoot2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRoot2.Visible = False
        '
        'lblRoot1
        '
        Me.lblRoot1.AutoSize = True
        Me.lblRoot1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblRoot1.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.lblRoot1.Location = New System.Drawing.Point(591, 391)
        Me.lblRoot1.Name = "lblRoot1"
        Me.lblRoot1.Size = New System.Drawing.Size(40, 14)
        Me.lblRoot1.TabIndex = 10
        Me.lblRoot1.Text = "Root 1"
        Me.lblRoot1.Visible = False
        '
        'lblRoot2
        '
        Me.lblRoot2.AutoSize = True
        Me.lblRoot2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblRoot2.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.lblRoot2.Location = New System.Drawing.Point(707, 391)
        Me.lblRoot2.Name = "lblRoot2"
        Me.lblRoot2.Size = New System.Drawing.Size(40, 14)
        Me.lblRoot2.TabIndex = 11
        Me.lblRoot2.Text = "Root 2"
        Me.lblRoot2.Visible = False
        '
        'lbl2dp
        '
        Me.lbl2dp.AutoSize = True
        Me.lbl2dp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lbl2dp.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.lbl2dp.Location = New System.Drawing.Point(686, 440)
        Me.lbl2dp.Name = "lbl2dp"
        Me.lbl2dp.Size = New System.Drawing.Size(263, 12)
        Me.lbl2dp.TabIndex = 12
        Me.lbl2dp.Text = "*Note: Where a root is a decimal value, round off to 2 d.p"
        Me.lbl2dp.Visible = False
        '
        'btnLoadSums
        '
        Me.btnLoadSums.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLoadSums.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadSums.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.btnLoadSums.Location = New System.Drawing.Point(711, 310)
        Me.btnLoadSums.Name = "btnLoadSums"
        Me.btnLoadSums.Size = New System.Drawing.Size(81, 23)
        Me.btnLoadSums.TabIndex = 13
        Me.btnLoadSums.Text = "Load Sums"
        Me.btnLoadSums.UseVisualStyleBackColor = False
        '
        'btnSaveSums
        '
        Me.btnSaveSums.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSaveSums.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSums.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.btnSaveSums.Location = New System.Drawing.Point(624, 310)
        Me.btnSaveSums.Name = "btnSaveSums"
        Me.btnSaveSums.Size = New System.Drawing.Size(81, 23)
        Me.btnSaveSums.TabIndex = 14
        Me.btnSaveSums.Text = "Save Sums"
        Me.btnSaveSums.UseVisualStyleBackColor = False
        '
        'btnPrintSums
        '
        Me.btnPrintSums.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPrintSums.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintSums.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.btnPrintSums.Location = New System.Drawing.Point(798, 309)
        Me.btnPrintSums.Name = "btnPrintSums"
        Me.btnPrintSums.Size = New System.Drawing.Size(81, 23)
        Me.btnPrintSums.TabIndex = 15
        Me.btnPrintSums.Text = "Print Sums"
        Me.btnPrintSums.UseVisualStyleBackColor = False
        '
        'lblSelectSum
        '
        Me.lblSelectSum.AutoSize = True
        Me.lblSelectSum.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.lblSelectSum.Location = New System.Drawing.Point(55, 111)
        Me.lblSelectSum.Name = "lblSelectSum"
        Me.lblSelectSum.Size = New System.Drawing.Size(149, 19)
        Me.lblSelectSum.TabIndex = 16
        Me.lblSelectSum.Text = "Select your Problem"
        '
        'btnShowAnswers
        '
        Me.btnShowAnswers.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnShowAnswers.Enabled = False
        Me.btnShowAnswers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAnswers.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.btnShowAnswers.Location = New System.Drawing.Point(885, 402)
        Me.btnShowAnswers.Name = "btnShowAnswers"
        Me.btnShowAnswers.Size = New System.Drawing.Size(68, 23)
        Me.btnShowAnswers.TabIndex = 17
        Me.btnShowAnswers.Text = "Show Ans"
        Me.btnShowAnswers.UseVisualStyleBackColor = False
        Me.btnShowAnswers.Visible = False
        '
        'btnCreateList
        '
        Me.btnCreateList.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCreateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateList.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.btnCreateList.Location = New System.Drawing.Point(537, 309)
        Me.btnCreateList.Name = "btnCreateList"
        Me.btnCreateList.Size = New System.Drawing.Size(81, 24)
        Me.btnCreateList.TabIndex = 18
        Me.btnCreateList.Text = "Create List"
        Me.btnCreateList.UseVisualStyleBackColor = False
        '
        'pBarSums
        '
        Me.pBarSums.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pBarSums.Location = New System.Drawing.Point(47, 451)
        Me.pBarSums.Name = "pBarSums"
        Me.pBarSums.Size = New System.Drawing.Size(410, 10)
        Me.pBarSums.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pBarSums.TabIndex = 19
        Me.pBarSums.Visible = False
        '
        'btnViewTests
        '
        Me.btnViewTests.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnViewTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewTests.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.btnViewTests.Location = New System.Drawing.Point(885, 309)
        Me.btnViewTests.Name = "btnViewTests"
        Me.btnViewTests.Size = New System.Drawing.Size(81, 23)
        Me.btnViewTests.TabIndex = 20
        Me.btnViewTests.Text = "View Tests"
        Me.btnViewTests.UseVisualStyleBackColor = False
        '
        'frmPracticeProblems
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 551)
        Me.Controls.Add(Me.btnViewTests)
        Me.Controls.Add(Me.pBarSums)
        Me.Controls.Add(Me.btnCreateList)
        Me.Controls.Add(Me.btnShowAnswers)
        Me.Controls.Add(Me.lblSelectSum)
        Me.Controls.Add(Me.btnPrintSums)
        Me.Controls.Add(Me.btnSaveSums)
        Me.Controls.Add(Me.btnLoadSums)
        Me.Controls.Add(Me.lbl2dp)
        Me.Controls.Add(Me.lblRoot2)
        Me.Controls.Add(Me.lblRoot1)
        Me.Controls.Add(Me.txtRoot2)
        Me.Controls.Add(Me.txtRoot1)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.comboDifficulty)
        Me.Controls.Add(Me.lblTips)
        Me.Controls.Add(Me.listSums)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.MaximizeBox = False
        Me.Name = "frmPracticeProblems"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Practice Problems"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents diaOpenTest As System.Windows.Forms.OpenFileDialog
    Friend WithEvents diaSaveTest As System.Windows.Forms.SaveFileDialog
    Friend WithEvents listSums As System.Windows.Forms.ListBox
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblTips As System.Windows.Forms.Label
    Friend WithEvents comboDifficulty As System.Windows.Forms.ComboBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents txtRoot1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRoot2 As System.Windows.Forms.TextBox
    Friend WithEvents lblRoot1 As System.Windows.Forms.Label
    Friend WithEvents lblRoot2 As System.Windows.Forms.Label
    Friend WithEvents lbl2dp As System.Windows.Forms.Label
    Friend WithEvents btnLoadSums As System.Windows.Forms.Button
    Friend WithEvents btnSaveSums As System.Windows.Forms.Button
    Friend WithEvents btnPrintSums As System.Windows.Forms.Button
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblSelectSum As System.Windows.Forms.Label
    Friend WithEvents btnShowAnswers As System.Windows.Forms.Button
    Friend WithEvents btnCreateList As System.Windows.Forms.Button
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents pBarSums As System.Windows.Forms.ProgressBar
    Friend WithEvents btnViewTests As System.Windows.Forms.Button
End Class
