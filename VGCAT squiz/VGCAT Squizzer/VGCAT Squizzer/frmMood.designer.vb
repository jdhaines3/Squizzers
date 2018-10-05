<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMood
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMood))
        Me.trbMood = New System.Windows.Forms.TrackBar()
        Me.btnMood = New System.Windows.Forms.Button()
        Me.lblMood = New System.Windows.Forms.Label()
        Me.bwTimer = New System.ComponentModel.BackgroundWorker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbxPointer = New System.Windows.Forms.PictureBox()
        Me.LabelHappy = New System.Windows.Forms.Label()
        CType(Me.trbMood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trbMood
        '
        Me.trbMood.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.trbMood.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trbMood.LargeChange = 1
        Me.trbMood.Location = New System.Drawing.Point(74, 221)
        Me.trbMood.Maximum = 100
        Me.trbMood.Name = "trbMood"
        Me.trbMood.RightToLeftLayout = True
        Me.trbMood.Size = New System.Drawing.Size(553, 45)
        Me.trbMood.TabIndex = 0
        Me.trbMood.Value = 50
        '
        'btnMood
        '
        Me.btnMood.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMood.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMood.Location = New System.Drawing.Point(157, 337)
        Me.btnMood.Name = "btnMood"
        Me.btnMood.Size = New System.Drawing.Size(385, 51)
        Me.btnMood.TabIndex = 1
        Me.btnMood.Text = "Next Question"
        Me.btnMood.UseVisualStyleBackColor = True
        '
        'lblMood
        '
        Me.lblMood.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMood.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMood.Location = New System.Drawing.Point(73, 52)
        Me.lblMood.Name = "lblMood"
        Me.lblMood.Size = New System.Drawing.Size(555, 123)
        Me.lblMood.TabIndex = 37
        Me.lblMood.Text = "How  HAPPY do you feel right now?"
        Me.lblMood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bwTimer
        '
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(306, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 19)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Somewhat"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(343, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "|"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 45)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Not At All"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(560, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 61)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Extremely"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(73, 220)
        Me.Label11.MinimumSize = New System.Drawing.Size(555, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(555, 47)
        Me.Label11.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 23)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "|"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(608, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 23)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "|"
        '
        'pbxPointer
        '
        Me.pbxPointer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxPointer.Image = CType(resources.GetObject("pbxPointer.Image"), System.Drawing.Image)
        Me.pbxPointer.Location = New System.Drawing.Point(82, 199)
        Me.pbxPointer.Name = "pbxPointer"
        Me.pbxPointer.Size = New System.Drawing.Size(11, 21)
        Me.pbxPointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPointer.TabIndex = 54
        Me.pbxPointer.TabStop = False
        Me.pbxPointer.Visible = False
        '
        'LabelHappy
        '
        Me.LabelHappy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelHappy.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHappy.Location = New System.Drawing.Point(213, 57)
        Me.LabelHappy.Name = "LabelHappy"
        Me.LabelHappy.Size = New System.Drawing.Size(155, 63)
        Me.LabelHappy.TabIndex = 55
        Me.LabelHappy.Text = "HAPPY"
        Me.LabelHappy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMood
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.LabelHappy)
        Me.Controls.Add(Me.pbxPointer)
        Me.Controls.Add(Me.lblMood)
        Me.Controls.Add(Me.btnMood)
        Me.Controls.Add(Me.trbMood)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.KeyPreview = True
        Me.Name = "frmMood"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mood"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.trbMood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents trbMood As System.Windows.Forms.TrackBar
    Friend WithEvents btnMood As System.Windows.Forms.Button
    Friend WithEvents lblMood As System.Windows.Forms.Label
    Friend WithEvents bwTimer As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pbxPointer As System.Windows.Forms.PictureBox
    Friend WithEvents LabelHappy As System.Windows.Forms.Label
End Class
