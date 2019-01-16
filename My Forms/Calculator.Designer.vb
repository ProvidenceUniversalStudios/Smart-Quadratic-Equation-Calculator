<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then DisposeShapeContainer(ShapeContainer2) : DisposeShapeContainer(ShapeContainer4)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalculator))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblroots = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblHey = New System.Windows.Forms.Label()
        Me.linkActivate = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lneRoot = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.panelBtns = New System.Windows.Forms.Panel()
        Me.btnAboutQuad = New System.Windows.Forms.Button()
        Me.btnPracticeProbs = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.listSums = New System.Windows.Forms.ListView()
        Me.hdrEquation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdrRoots = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdrFactors = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnLoadList = New System.Windows.Forms.Button()
        Me.btnSaveList = New System.Windows.Forms.Button()
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.diaSaveList = New System.Windows.Forms.SaveFileDialog()
        Me.diaLoadList = New System.Windows.Forms.OpenFileDialog()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblequation = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.panelBtns.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(52, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(551, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quadratic Equation Calculator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Font = New System.Drawing.Font("Cambria Math", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(-2, -19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(651, 54)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Roots of x:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Visible = False
        '
        'lblroots
        '
        Me.lblroots.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblroots.AutoEllipsis = True
        Me.lblroots.Font = New System.Drawing.Font("Cambria Math", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroots.ForeColor = System.Drawing.Color.Teal
        Me.lblroots.Location = New System.Drawing.Point(165, 80)
        Me.lblroots.Name = "lblroots"
        Me.lblroots.Size = New System.Drawing.Size(648, 66)
        Me.lblroots.TabIndex = 8
        Me.lblroots.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblroots.Visible = False
        '
        'lblClose
        '
        Me.lblClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.Teal
        Me.lblClose.Location = New System.Drawing.Point(623, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(30, 23)
        Me.lblClose.TabIndex = 12
        Me.lblClose.Text = "X"
        Me.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAbout
        '
        Me.lblAbout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.ForeColor = System.Drawing.Color.Teal
        Me.lblAbout.Location = New System.Drawing.Point(595, 0)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(30, 23)
        Me.lblAbout.TabIndex = 13
        Me.lblAbout.Text = "?"
        Me.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(653, 79)
        Me.Panel1.TabIndex = 14
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel7.Controls.Add(Me.lblClose)
        Me.Panel7.Controls.Add(Me.lblHey)
        Me.Panel7.Controls.Add(Me.lblAbout)
        Me.Panel7.Location = New System.Drawing.Point(0, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(653, 23)
        Me.Panel7.TabIndex = 16
        '
        'lblHey
        '
        Me.lblHey.AutoSize = True
        Me.lblHey.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblHey.ForeColor = System.Drawing.Color.Teal
        Me.lblHey.Location = New System.Drawing.Point(3, 5)
        Me.lblHey.Name = "lblHey"
        Me.lblHey.Size = New System.Drawing.Size(68, 16)
        Me.lblHey.TabIndex = 15
        Me.lblHey.Text = "Hey there"
        Me.lblHey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblHey.Visible = False
        '
        'linkActivate
        '
        Me.linkActivate.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.linkActivate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.linkActivate.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkActivate.ForeColor = System.Drawing.Color.Teal
        Me.linkActivate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkActivate.LinkColor = System.Drawing.Color.Teal
        Me.linkActivate.Location = New System.Drawing.Point(459, 28)
        Me.linkActivate.Name = "linkActivate"
        Me.linkActivate.Size = New System.Drawing.Size(191, 39)
        Me.linkActivate.TabIndex = 13
        Me.linkActivate.TabStop = True
        Me.linkActivate.Text = "* You are currently running the trial version. To access full functionality, Clic" & _
    "k Here to activate the application."
        Me.linkActivate.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.lblFactors)
        Me.Panel2.Controls.Add(Me.lblroots)
        Me.Panel2.Location = New System.Drawing.Point(-164, 338)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(817, 320)
        Me.Panel2.TabIndex = 15
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.ShapeContainer4)
        Me.Panel6.Location = New System.Drawing.Point(165, 14)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(648, 60)
        Me.Panel6.TabIndex = 15
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lneRoot})
        Me.ShapeContainer4.Size = New System.Drawing.Size(648, 60)
        Me.ShapeContainer4.TabIndex = 8
        Me.ShapeContainer4.TabStop = False
        '
        'lneRoot
        '
        Me.lneRoot.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lneRoot.BorderColor = System.Drawing.Color.Teal
        Me.lneRoot.Name = "lneRoot"
        Me.lneRoot.Visible = False
        Me.lneRoot.X1 = 27
        Me.lneRoot.X2 = 623
        Me.lneRoot.Y1 = 39
        Me.lneRoot.Y2 = 39
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.panelBtns)
        Me.Panel5.Controls.Add(Me.linkActivate)
        Me.Panel5.Location = New System.Drawing.Point(163, 224)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(654, 96)
        Me.Panel5.TabIndex = 14
        '
        'panelBtns
        '
        Me.panelBtns.Controls.Add(Me.btnAboutQuad)
        Me.panelBtns.Controls.Add(Me.btnPracticeProbs)
        Me.panelBtns.Controls.Add(Me.btnOptions)
        Me.panelBtns.Controls.Add(Me.btncalculate)
        Me.panelBtns.Location = New System.Drawing.Point(17, 22)
        Me.panelBtns.Name = "panelBtns"
        Me.panelBtns.Size = New System.Drawing.Size(436, 62)
        Me.panelBtns.TabIndex = 14
        '
        'btnAboutQuad
        '
        Me.btnAboutQuad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAboutQuad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutQuad.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.btnAboutQuad.ForeColor = System.Drawing.Color.Teal
        Me.btnAboutQuad.Location = New System.Drawing.Point(121, 12)
        Me.btnAboutQuad.Name = "btnAboutQuad"
        Me.btnAboutQuad.Size = New System.Drawing.Size(100, 39)
        Me.btnAboutQuad.TabIndex = 11
        Me.btnAboutQuad.Text = "Information"
        Me.btnAboutQuad.UseVisualStyleBackColor = True
        '
        'btnPracticeProbs
        '
        Me.btnPracticeProbs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPracticeProbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPracticeProbs.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.btnPracticeProbs.ForeColor = System.Drawing.Color.Teal
        Me.btnPracticeProbs.Location = New System.Drawing.Point(227, 12)
        Me.btnPracticeProbs.Name = "btnPracticeProbs"
        Me.btnPracticeProbs.Size = New System.Drawing.Size(109, 39)
        Me.btnPracticeProbs.TabIndex = 10
        Me.btnPracticeProbs.Text = "Practice Probs"
        Me.btnPracticeProbs.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.btnOptions.ForeColor = System.Drawing.Color.Teal
        Me.btnOptions.Location = New System.Drawing.Point(12, 12)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(103, 39)
        Me.btnOptions.TabIndex = 12
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btncalculate
        '
        Me.btncalculate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncalculate.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.btncalculate.ForeColor = System.Drawing.Color.Teal
        Me.btncalculate.Location = New System.Drawing.Point(342, 12)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(82, 39)
        Me.btncalculate.TabIndex = 9
        Me.btncalculate.Text = "Calculate"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'lblFactors
        '
        Me.lblFactors.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFactors.AutoEllipsis = True
        Me.lblFactors.Font = New System.Drawing.Font("Cambria Math", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactors.ForeColor = System.Drawing.Color.Teal
        Me.lblFactors.Location = New System.Drawing.Point(165, 145)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(649, 76)
        Me.lblFactors.TabIndex = 13
        Me.lblFactors.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblFactors.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(667, -5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(331, 38)
        Me.Panel3.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 15.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(220, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Recall List"
        '
        'listSums
        '
        Me.listSums.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.listSums.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listSums.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.hdrEquation, Me.hdrRoots, Me.hdrFactors})
        Me.listSums.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.listSums.FullRowSelect = True
        Me.listSums.GridLines = True
        Me.listSums.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listSums.Location = New System.Drawing.Point(667, 34)
        Me.listSums.MultiSelect = False
        Me.listSums.Name = "listSums"
        Me.listSums.ShowItemToolTips = True
        Me.listSums.Size = New System.Drawing.Size(331, 549)
        Me.listSums.TabIndex = 21
        Me.listSums.UseCompatibleStateImageBehavior = False
        Me.listSums.View = System.Windows.Forms.View.Details
        '
        'hdrEquation
        '
        Me.hdrEquation.Text = "Equation"
        Me.hdrEquation.Width = 116
        '
        'hdrRoots
        '
        Me.hdrRoots.Text = "Roots"
        Me.hdrRoots.Width = 116
        '
        'hdrFactors
        '
        Me.hdrFactors.Text = "Factors"
        Me.hdrFactors.Width = 116
        '
        'btnLoadList
        '
        Me.btnLoadList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLoadList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadList.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.btnLoadList.Location = New System.Drawing.Point(691, 603)
        Me.btnLoadList.Name = "btnLoadList"
        Me.btnLoadList.Size = New System.Drawing.Size(89, 36)
        Me.btnLoadList.TabIndex = 22
        Me.btnLoadList.Text = "Load List"
        Me.btnLoadList.UseVisualStyleBackColor = True
        '
        'btnSaveList
        '
        Me.btnSaveList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSaveList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveList.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.btnSaveList.Location = New System.Drawing.Point(788, 603)
        Me.btnSaveList.Name = "btnSaveList"
        Me.btnSaveList.Size = New System.Drawing.Size(89, 36)
        Me.btnSaveList.TabIndex = 23
        Me.btnSaveList.Text = "Save List"
        Me.btnSaveList.UseVisualStyleBackColor = True
        '
        'btnClearList
        '
        Me.btnClearList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearList.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.btnClearList.Location = New System.Drawing.Point(884, 603)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(89, 36)
        Me.btnClearList.TabIndex = 24
        Me.btnClearList.Text = "Clear List"
        Me.btnClearList.UseVisualStyleBackColor = True
        '
        'diaSaveList
        '
        Me.diaSaveList.DefaultExt = "rodney"
        Me.diaSaveList.Filter = "Rodney Files|*.rodney"
        Me.diaSaveList.Title = "Save Recall List"
        '
        'diaLoadList
        '
        Me.diaLoadList.DefaultExt = "rodney"
        Me.diaLoadList.Filter = "Rodney Files|*.rodney"
        Me.diaLoadList.Title = "Load Recall List"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.lblequation)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtC)
        Me.Panel4.Controls.Add(Me.txtB)
        Me.Panel4.Controls.Add(Me.txtA)
        Me.Panel4.Location = New System.Drawing.Point(0, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(653, 211)
        Me.Panel4.TabIndex = 0
        '
        'lblequation
        '
        Me.lblequation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblequation.Font = New System.Drawing.Font("Cambria Math", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblequation.Location = New System.Drawing.Point(3, 95)
        Me.lblequation.Name = "lblequation"
        Me.lblequation.Size = New System.Drawing.Size(649, 104)
        Me.lblequation.TabIndex = 90
        Me.lblequation.Text = "Enter your values above"
        Me.lblequation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.Font = New System.Drawing.Font("Cambria Math", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(476, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 48)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "c"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.Font = New System.Drawing.Font("Cambria Math", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(274, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 48)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "b"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Font = New System.Drawing.Font("Cambria Math", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 48)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "a"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtC
        '
        Me.txtC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtC.Location = New System.Drawing.Point(476, 63)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(100, 29)
        Me.txtC.TabIndex = 2
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtB
        '
        Me.txtB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtB.Location = New System.Drawing.Point(274, 63)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 29)
        Me.txtB.TabIndex = 1
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtA
        '
        Me.txtA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtA.Location = New System.Drawing.Point(62, 63)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 29)
        Me.txtA.TabIndex = 0
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1, Me.RectangleShape4})
        Me.ShapeContainer2.Size = New System.Drawing.Size(998, 658)
        Me.ShapeContainer2.TabIndex = 19
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RectangleShape2.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(-1, 324)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(654, 23)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 65)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(653, 23)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RectangleShape4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RectangleShape4.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RectangleShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape4.Location = New System.Drawing.Point(653, 0)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(13, 657)
        '
        'frmCalculator
        '
        Me.AcceptButton = Me.btncalculate
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(998, 658)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnClearList)
        Me.Controls.Add(Me.btnSaveList)
        Me.Controls.Add(Me.btnLoadList)
        Me.Controls.Add(Me.listSums)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quadratic Equation Calculator"
        Me.TransparencyKey = System.Drawing.Color.Navy
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.panelBtns.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblroots As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents listSums As System.Windows.Forms.ListView
    Friend WithEvents hdrEquation As System.Windows.Forms.ColumnHeader
    Friend WithEvents hdrRoots As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnLoadList As System.Windows.Forms.Button
    Friend WithEvents btnSaveList As System.Windows.Forms.Button
    Friend WithEvents btnClearList As System.Windows.Forms.Button
    Friend WithEvents diaSaveList As System.Windows.Forms.SaveFileDialog
    Friend WithEvents diaLoadList As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblequation As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents lblFactors As System.Windows.Forms.Label
    Friend WithEvents hdrFactors As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnAboutQuad As System.Windows.Forms.Button
    Friend WithEvents btncalculate As System.Windows.Forms.Button
    Friend WithEvents btnPracticeProbs As System.Windows.Forms.Button
    Friend WithEvents linkActivate As System.Windows.Forms.LinkLabel
    Friend WithEvents lblHey As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer4 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lneRoot As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents panelBtns As System.Windows.Forms.Panel
End Class
