<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then disposeshapecontainer(ShapeContainer1)
            If disposing AndAlso components IsNot Nothing Then
                'LineShape1.Dispose() : LineShape2.Dispose() : LineShape3.Dispose() : RectangleShape1.Dispose() : ShapeContainer1.Dispose()
                components.Dispose()
            End If
        Finally
            'LineShape1.Dispose() : LineShape2.Dispose() : LineShape3.Dispose() : RectangleShape1.Dispose() : ShapeContainer1.Dispose()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.numDecimalPs = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkDP = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radioSolid = New System.Windows.Forms.RadioButton()
        Me.radioTransparent = New System.Windows.Forms.RadioButton()
        Me.chkResumeCalculator = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numPracticePs = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkShowAns = New System.Windows.Forms.CheckBox()
        Me.chkResumePractice = New System.Windows.Forms.CheckBox()
        Me.btnDiscard = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkPrintAns = New System.Windows.Forms.CheckBox()
        Me.chkPassword = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkMulUsers = New System.Windows.Forms.CheckBox()
        Me.btnDeleteAccount = New System.Windows.Forms.Button()
        Me.btynLogout = New System.Windows.Forms.Button()
        CType(Me.numDecimalPs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPracticePs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Options"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.RectangleShape1, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(542, 347)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.White
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.SelectionColor = System.Drawing.Color.White
        Me.LineShape3.X1 = 19
        Me.LineShape3.X2 = 509
        Me.LineShape3.Y1 = 245
        Me.LineShape3.Y2 = 245
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 276)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.RectangleShape1.Size = New System.Drawing.Size(541, 73)
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.SelectionColor = System.Drawing.Color.White
        Me.LineShape2.X1 = 17
        Me.LineShape2.X2 = 509
        Me.LineShape2.Y1 = 95
        Me.LineShape2.Y2 = 95
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.SelectionColor = System.Drawing.Color.White
        Me.LineShape1.X1 = 17
        Me.LineShape1.X2 = 511
        Me.LineShape1.Y1 = 55
        Me.LineShape1.Y2 = 55
        '
        'numDecimalPs
        '
        Me.numDecimalPs.BackColor = System.Drawing.Color.White
        Me.numDecimalPs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numDecimalPs.Enabled = False
        Me.numDecimalPs.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.numDecimalPs.Location = New System.Drawing.Point(145, 110)
        Me.numDecimalPs.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numDecimalPs.Name = "numDecimalPs"
        Me.numDecimalPs.Size = New System.Drawing.Size(59, 16)
        Me.numDecimalPs.TabIndex = 2
        Me.numDecimalPs.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(23, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Calculator"
        '
        'chkDP
        '
        Me.chkDP.AutoSize = True
        Me.chkDP.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.chkDP.Location = New System.Drawing.Point(27, 110)
        Me.chkDP.Name = "chkDP"
        Me.chkDP.Size = New System.Drawing.Size(92, 16)
        Me.chkDP.TabIndex = 5
        Me.chkDP.Text = "Decimal Places"
        Me.chkDP.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(24, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Theme :"
        '
        'radioSolid
        '
        Me.radioSolid.AutoSize = True
        Me.radioSolid.Checked = True
        Me.radioSolid.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.radioSolid.Location = New System.Drawing.Point(84, 198)
        Me.radioSolid.Name = "radioSolid"
        Me.radioSolid.Size = New System.Drawing.Size(46, 16)
        Me.radioSolid.TabIndex = 7
        Me.radioSolid.TabStop = True
        Me.radioSolid.Text = "Solid"
        Me.radioSolid.UseVisualStyleBackColor = True
        '
        'radioTransparent
        '
        Me.radioTransparent.AutoSize = True
        Me.radioTransparent.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.radioTransparent.Location = New System.Drawing.Point(138, 198)
        Me.radioTransparent.Name = "radioTransparent"
        Me.radioTransparent.Size = New System.Drawing.Size(82, 16)
        Me.radioTransparent.TabIndex = 8
        Me.radioTransparent.Text = "Transparent"
        Me.radioTransparent.UseVisualStyleBackColor = True
        '
        'chkResumeCalculator
        '
        Me.chkResumeCalculator.AutoSize = True
        Me.chkResumeCalculator.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.chkResumeCalculator.Location = New System.Drawing.Point(26, 132)
        Me.chkResumeCalculator.Name = "chkResumeCalculator"
        Me.chkResumeCalculator.Size = New System.Drawing.Size(104, 16)
        Me.chkResumeCalculator.TabIndex = 9
        Me.chkResumeCalculator.Text = "Resume after exit"
        Me.chkResumeCalculator.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(389, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Practice Problems"
        '
        'numPracticePs
        '
        Me.numPracticePs.BackColor = System.Drawing.Color.White
        Me.numPracticePs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numPracticePs.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.numPracticePs.Location = New System.Drawing.Point(451, 110)
        Me.numPracticePs.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numPracticePs.Name = "numPracticePs"
        Me.numPracticePs.Size = New System.Drawing.Size(59, 16)
        Me.numPracticePs.TabIndex = 11
        Me.numPracticePs.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(297, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 12)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Number of Practice Problems :"
        '
        'chkShowAns
        '
        Me.chkShowAns.AutoSize = True
        Me.chkShowAns.Checked = True
        Me.chkShowAns.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowAns.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.chkShowAns.Location = New System.Drawing.Point(300, 140)
        Me.chkShowAns.Name = "chkShowAns"
        Me.chkShowAns.Size = New System.Drawing.Size(159, 16)
        Me.chkShowAns.TabIndex = 13
        Me.chkShowAns.Text = "Enable show answers button"
        Me.chkShowAns.UseVisualStyleBackColor = True
        '
        'chkResumePractice
        '
        Me.chkResumePractice.AutoSize = True
        Me.chkResumePractice.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.chkResumePractice.Location = New System.Drawing.Point(300, 165)
        Me.chkResumePractice.Name = "chkResumePractice"
        Me.chkResumePractice.Size = New System.Drawing.Size(104, 16)
        Me.chkResumePractice.TabIndex = 14
        Me.chkResumePractice.Text = "Resume after exit"
        Me.chkResumePractice.UseVisualStyleBackColor = True
        '
        'btnDiscard
        '
        Me.btnDiscard.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiscard.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.btnDiscard.Location = New System.Drawing.Point(370, 300)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.Size = New System.Drawing.Size(75, 25)
        Me.btnDiscard.TabIndex = 15
        Me.btnDiscard.Text = "Discard"
        Me.btnDiscard.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.btnSave.Location = New System.Drawing.Point(451, 300)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'chkPrintAns
        '
        Me.chkPrintAns.AutoSize = True
        Me.chkPrintAns.Checked = True
        Me.chkPrintAns.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintAns.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.chkPrintAns.Location = New System.Drawing.Point(300, 188)
        Me.chkPrintAns.Name = "chkPrintAns"
        Me.chkPrintAns.Size = New System.Drawing.Size(92, 16)
        Me.chkPrintAns.TabIndex = 17
        Me.chkPrintAns.Text = "Print Answers"
        Me.chkPrintAns.UseVisualStyleBackColor = True
        '
        'chkPassword
        '
        Me.chkPassword.AutoSize = True
        Me.chkPassword.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.chkPassword.Location = New System.Drawing.Point(27, 154)
        Me.chkPassword.Name = "chkPassword"
        Me.chkPassword.Size = New System.Drawing.Size(143, 16)
        Me.chkPassword.TabIndex = 18
        Me.chkPassword.Text = "Password Authentication"
        Me.chkPassword.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(218, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 25)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Change Account Settings"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'chkMulUsers
        '
        Me.chkMulUsers.AutoSize = True
        Me.chkMulUsers.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.chkMulUsers.Location = New System.Drawing.Point(27, 176)
        Me.chkMulUsers.Name = "chkMulUsers"
        Me.chkMulUsers.Size = New System.Drawing.Size(125, 16)
        Me.chkMulUsers.TabIndex = 20
        Me.chkMulUsers.Text = "Enable Multiple Users"
        Me.chkMulUsers.UseVisualStyleBackColor = True
        '
        'btnDeleteAccount
        '
        Me.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAccount.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.btnDeleteAccount.Location = New System.Drawing.Point(112, 300)
        Me.btnDeleteAccount.Name = "btnDeleteAccount"
        Me.btnDeleteAccount.Size = New System.Drawing.Size(100, 25)
        Me.btnDeleteAccount.TabIndex = 21
        Me.btnDeleteAccount.Text = "Delete Acount"
        Me.btnDeleteAccount.UseVisualStyleBackColor = False
        '
        'btynLogout
        '
        Me.btynLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btynLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btynLogout.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.btynLogout.Location = New System.Drawing.Point(17, 300)
        Me.btynLogout.Name = "btynLogout"
        Me.btynLogout.Size = New System.Drawing.Size(89, 25)
        Me.btynLogout.TabIndex = 22
        Me.btynLogout.Text = "Logout"
        Me.btynLogout.UseVisualStyleBackColor = False
        '
        'Options
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(542, 347)
        Me.Controls.Add(Me.btynLogout)
        Me.Controls.Add(Me.btnDeleteAccount)
        Me.Controls.Add(Me.chkMulUsers)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkPassword)
        Me.Controls.Add(Me.chkPrintAns)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDiscard)
        Me.Controls.Add(Me.chkResumePractice)
        Me.Controls.Add(Me.chkShowAns)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numPracticePs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkResumeCalculator)
        Me.Controls.Add(Me.radioTransparent)
        Me.Controls.Add(Me.radioSolid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkDP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numDecimalPs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Options"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        CType(Me.numDecimalPs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPracticePs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents numDecimalPs As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkDP As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents radioSolid As System.Windows.Forms.RadioButton
    Friend WithEvents radioTransparent As System.Windows.Forms.RadioButton
    Friend WithEvents chkResumeCalculator As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents numPracticePs As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkShowAns As System.Windows.Forms.CheckBox
    Friend WithEvents chkResumePractice As System.Windows.Forms.CheckBox
    Friend WithEvents btnDiscard As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents chkPrintAns As System.Windows.Forms.CheckBox
    Friend WithEvents chkPassword As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkMulUsers As System.Windows.Forms.CheckBox
    Friend WithEvents btnDeleteAccount As System.Windows.Forms.Button
    Friend WithEvents btynLogout As System.Windows.Forms.Button
End Class
