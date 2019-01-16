<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Serial_Key_Verifier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Serial_Key_Verifier))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTrial = New System.Windows.Forms.Button()
        Me.lblTrial = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter the serial key"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKey
        '
        Me.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKey.Location = New System.Drawing.Point(143, 118)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(182, 25)
        Me.txtKey.TabIndex = 1
        Me.txtKey.UseSystemPasswordChar = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cambria", 11.0!)
        Me.Button1.Location = New System.Drawing.Point(376, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTrial
        '
        Me.btnTrial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrial.Font = New System.Drawing.Font("Cambria", 11.0!)
        Me.btnTrial.Location = New System.Drawing.Point(265, 16)
        Me.btnTrial.Name = "btnTrial"
        Me.btnTrial.Size = New System.Drawing.Size(98, 29)
        Me.btnTrial.TabIndex = 3
        Me.btnTrial.Text = "Trial"
        Me.btnTrial.UseVisualStyleBackColor = True
        '
        'lblTrial
        '
        Me.lblTrial.AutoSize = True
        Me.lblTrial.Font = New System.Drawing.Font("Cambria", 8.0!)
        Me.lblTrial.Location = New System.Drawing.Point(321, 173)
        Me.lblTrial.Name = "lblTrial"
        Me.lblTrial.Size = New System.Drawing.Size(121, 12)
        Me.lblTrial.TabIndex = 4
        Me.lblTrial.Text = "*Trial period has expired"
        Me.lblTrial.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnTrial)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 195)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 57)
        Me.Panel1.TabIndex = 5
        '
        'Serial_Key_Verifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(461, 252)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTrial)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Serial_Key_Verifier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serial Key Verifier"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnTrial As System.Windows.Forms.Button
    Friend WithEvents lblTrial As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
