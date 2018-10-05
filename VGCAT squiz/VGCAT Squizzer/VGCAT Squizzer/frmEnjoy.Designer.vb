<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnjoy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnjoy))
        Me.trbEnjoy = New System.Windows.Forms.TrackBar()
        Me.btnEnjoy = New System.Windows.Forms.Button()
        Me.lblEnjoy = New System.Windows.Forms.Label()
        Me.pbxPointer = New System.Windows.Forms.PictureBox()
        Me.bwTimer = New System.ComponentModel.BackgroundWorker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.trbEnjoy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trbEnjoy
        '
        Me.trbEnjoy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.trbEnjoy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trbEnjoy.LargeChange = 1
        Me.trbEnjoy.Location = New System.Drawing.Point(74, 221)
        Me.trbEnjoy.Maximum = 100
        Me.trbEnjoy.Name = "trbEnjoy"
        Me.trbEnjoy.RightToLeftLayout = True
        Me.trbEnjoy.Size = New System.Drawing.Size(553, 45)
        Me.trbEnjoy.TabIndex = 0
        Me.trbEnjoy.Value = 50
        '
        'btnEnjoy
        '
        Me.btnEnjoy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEnjoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnjoy.Location = New System.Drawing.Point(157, 337)
        Me.btnEnjoy.Name = "btnEnjoy"
        Me.btnEnjoy.Size = New System.Drawing.Size(385, 51)
        Me.btnEnjoy.TabIndex = 1
        Me.btnEnjoy.Text = "Next Question"
        Me.btnEnjoy.UseVisualStyleBackColor = True
        '
        'lblEnjoy
        '
        Me.lblEnjoy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEnjoy.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnjoy.Location = New System.Drawing.Point(73, 53)
        Me.lblEnjoy.Name = "lblEnjoy"
        Me.lblEnjoy.Size = New System.Drawing.Size(555, 123)
        Me.lblEnjoy.TabIndex = 37
        Me.lblEnjoy.Text = "      How much did you       enjoy the game?"
        Me.lblEnjoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxPointer
        '
        Me.pbxPointer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxPointer.Image = CType(resources.GetObject("pbxPointer.Image"), System.Drawing.Image)
        Me.pbxPointer.Location = New System.Drawing.Point(82, 199)
        Me.pbxPointer.Name = "pbxPointer"
        Me.pbxPointer.Size = New System.Drawing.Size(11, 21)
        Me.pbxPointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPointer.TabIndex = 38
        Me.pbxPointer.TabStop = False
        Me.pbxPointer.Visible = False
        '
        'bwTimer
        '
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(304, 276)
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
        Me.Label3.Location = New System.Drawing.Point(343, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "|"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 265)
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
        Me.Label7.Location = New System.Drawing.Point(561, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 61)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Very Much"
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
        Me.Label1.Location = New System.Drawing.Point(80, 257)
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
        Me.Label2.Location = New System.Drawing.Point(608, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 23)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "|"
        '
        'frmEnjoy
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.pbxPointer)
        Me.Controls.Add(Me.lblEnjoy)
        Me.Controls.Add(Me.btnEnjoy)
        Me.Controls.Add(Me.trbEnjoy)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.KeyPreview = True
        Me.Name = "frmEnjoy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enjoy"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.trbEnjoy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents trbEnjoy As System.Windows.Forms.TrackBar
    Friend WithEvents btnEnjoy As System.Windows.Forms.Button
    Friend WithEvents lblEnjoy As System.Windows.Forms.Label
    Friend WithEvents pbxPointer As System.Windows.Forms.PictureBox
    Friend WithEvents bwTimer As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
