<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntox))
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnIntox = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.trbIntox = New System.Windows.Forms.TrackBar
        Me.pbxPointer = New System.Windows.Forms.PictureBox
        Me.lblCrave = New System.Windows.Forms.Label
        Me.bwTimer = New System.ComponentModel.BackgroundWorker
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.trbIntox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 45)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "NOT AT ALL"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(569, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 30)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "MOST EVER"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnIntox
        '
        Me.btnIntox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIntox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntox.Location = New System.Drawing.Point(158, 338)
        Me.btnIntox.Name = "btnIntox"
        Me.btnIntox.Size = New System.Drawing.Size(385, 51)
        Me.btnIntox.TabIndex = 30
        Me.btnIntox.Text = "Next Question"
        Me.btnIntox.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(455, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 19)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "noticeably"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(306, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 19)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "somewhat"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "slightly"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(477, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 23)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "|"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "|"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "|"
        '
        'trbIntox
        '
        Me.trbIntox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.trbIntox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trbIntox.LargeChange = 1
        Me.trbIntox.Location = New System.Drawing.Point(75, 222)
        Me.trbIntox.Maximum = 100
        Me.trbIntox.Name = "trbIntox"
        Me.trbIntox.RightToLeftLayout = True
        Me.trbIntox.Size = New System.Drawing.Size(553, 45)
        Me.trbIntox.TabIndex = 18
        '
        'pbxPointer
        '
        Me.pbxPointer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxPointer.Image = CType(resources.GetObject("pbxPointer.Image"), System.Drawing.Image)
        Me.pbxPointer.Location = New System.Drawing.Point(84, 201)
        Me.pbxPointer.Name = "pbxPointer"
        Me.pbxPointer.Size = New System.Drawing.Size(11, 21)
        Me.pbxPointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPointer.TabIndex = 33
        Me.pbxPointer.TabStop = False
        Me.pbxPointer.Visible = False
        '
        'lblCrave
        '
        Me.lblCrave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCrave.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrave.Location = New System.Drawing.Point(74, 9)
        Me.lblCrave.Name = "lblCrave"
        Me.lblCrave.Size = New System.Drawing.Size(555, 189)
        Me.lblCrave.TabIndex = 35
        Me.lblCrave.Text = "How INTOXICATED  (feeling effects of alcohol) do I feel right now?"
        Me.lblCrave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bwTimer
        '
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(74, 221)
        Me.Label11.MinimumSize = New System.Drawing.Size(555, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(555, 47)
        Me.Label11.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(608, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 23)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "|"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(81, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 23)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "|"
        '
        'frmIntox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(702, 402)
        Me.Controls.Add(Me.trbIntox)
        Me.Controls.Add(Me.lblCrave)
        Me.Controls.Add(Me.pbxPointer)
        Me.Controls.Add(Me.btnIntox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmIntox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Intox"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.trbIntox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnIntox As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents trbIntox As System.Windows.Forms.TrackBar
    Friend WithEvents pbxPointer As System.Windows.Forms.PictureBox
    Friend WithEvents lblCrave As System.Windows.Forms.Label
    Friend WithEvents bwTimer As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
