<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnxious
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnxious))
        Me.trbAnxious = New System.Windows.Forms.TrackBar
        Me.btnAnxious = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblCrave = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pbxPointer = New System.Windows.Forms.PictureBox
        Me.bwTimer = New System.ComponentModel.BackgroundWorker
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.trbAnxious, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trbAnxious
        '
        Me.trbAnxious.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.trbAnxious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trbAnxious.LargeChange = 1
        Me.trbAnxious.Location = New System.Drawing.Point(74, 221)
        Me.trbAnxious.Maximum = 100
        Me.trbAnxious.Name = "trbAnxious"
        Me.trbAnxious.RightToLeftLayout = True
        Me.trbAnxious.Size = New System.Drawing.Size(553, 45)
        Me.trbAnxious.TabIndex = 0
        '
        'btnAnxious
        '
        Me.btnAnxious.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAnxious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnxious.Location = New System.Drawing.Point(157, 337)
        Me.btnAnxious.Name = "btnAnxious"
        Me.btnAnxious.Size = New System.Drawing.Size(385, 51)
        Me.btnAnxious.TabIndex = 1
        Me.btnAnxious.Text = "Next Question"
        Me.btnAnxious.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "|"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "|"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(477, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "|"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(573, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 45)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "MOST EVER"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 45)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "NOT AT ALL"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCrave
        '
        Me.lblCrave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCrave.Font = New System.Drawing.Font("Arial Black", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrave.Location = New System.Drawing.Point(73, 41)
        Me.lblCrave.Name = "lblCrave"
        Me.lblCrave.Size = New System.Drawing.Size(555, 154)
        Me.lblCrave.TabIndex = 38
        Me.lblCrave.Text = "            How ANXIOUS                    (tense, jittery, nervous)         do I" & _
            " feel right now?"
        Me.lblCrave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(456, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 19)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "noticeably"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(317, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 19)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "somewhat"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(177, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "slightly"
        '
        'pbxPointer
        '
        Me.pbxPointer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxPointer.Image = CType(resources.GetObject("pbxPointer.Image"), System.Drawing.Image)
        Me.pbxPointer.Location = New System.Drawing.Point(81, 198)
        Me.pbxPointer.Name = "pbxPointer"
        Me.pbxPointer.Size = New System.Drawing.Size(13, 23)
        Me.pbxPointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPointer.TabIndex = 47
        Me.pbxPointer.TabStop = False
        Me.pbxPointer.Visible = False
        '
        'bwTimer
        '
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(73, 220)
        Me.Label11.MinimumSize = New System.Drawing.Size(555, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(555, 50)
        Me.Label11.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 23)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "|"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(608, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 23)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "|"
        '
        'frmAnxious
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.trbAnxious)
        Me.Controls.Add(Me.pbxPointer)
        Me.Controls.Add(Me.lblCrave)
        Me.Controls.Add(Me.btnAnxious)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.KeyPreview = True
        Me.Name = "frmAnxious"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Anxious"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.trbAnxious, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents trbAnxious As System.Windows.Forms.TrackBar
    Friend WithEvents btnAnxious As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCrave As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pbxPointer As System.Windows.Forms.PictureBox
    Friend WithEvents bwTimer As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
