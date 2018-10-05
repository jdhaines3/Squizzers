<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFrustration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFrustration))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bwTimer = New System.ComponentModel.BackgroundWorker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.trbFrustration = New System.Windows.Forms.TrackBar()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnFrustration = New System.Windows.Forms.Button()
        Me.pbxPointer = New System.Windows.Forms.PictureBox()
        Me.LblStim = New System.Windows.Forms.Label()
        Me.lblFrust = New System.Windows.Forms.Label()
        CType(Me.trbFrustration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 45)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Not At All"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(568, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 45)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Extremely"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bwTimer
        '
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(304, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 19)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Somewhat"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "|"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 23)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "|"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(606, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 23)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "|"
        '
        'trbFrustration
        '
        Me.trbFrustration.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.trbFrustration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trbFrustration.LargeChange = 1
        Me.trbFrustration.Location = New System.Drawing.Point(74, 221)
        Me.trbFrustration.Maximum = 100
        Me.trbFrustration.Name = "trbFrustration"
        Me.trbFrustration.RightToLeftLayout = True
        Me.trbFrustration.Size = New System.Drawing.Size(553, 45)
        Me.trbFrustration.TabIndex = 58
        Me.trbFrustration.Value = 50
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(73, 219)
        Me.Label11.MinimumSize = New System.Drawing.Size(555, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(555, 50)
        Me.Label11.TabIndex = 59
        '
        'btnFrustration
        '
        Me.btnFrustration.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFrustration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrustration.Location = New System.Drawing.Point(153, 342)
        Me.btnFrustration.Name = "btnFrustration"
        Me.btnFrustration.Size = New System.Drawing.Size(385, 51)
        Me.btnFrustration.TabIndex = 60
        Me.btnFrustration.Text = "Next Question"
        Me.btnFrustration.UseVisualStyleBackColor = True
        '
        'pbxPointer
        '
        Me.pbxPointer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxPointer.Image = CType(resources.GetObject("pbxPointer.Image"), System.Drawing.Image)
        Me.pbxPointer.Location = New System.Drawing.Point(82, 192)
        Me.pbxPointer.Name = "pbxPointer"
        Me.pbxPointer.Size = New System.Drawing.Size(13, 23)
        Me.pbxPointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPointer.TabIndex = 61
        Me.pbxPointer.TabStop = False
        Me.pbxPointer.Visible = False
        '
        'LblStim
        '
        Me.LblStim.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblStim.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStim.Location = New System.Drawing.Point(73, 41)
        Me.LblStim.Name = "LblStim"
        Me.LblStim.Size = New System.Drawing.Size(555, 168)
        Me.LblStim.TabIndex = 65
        Me.LblStim.Text = "How  FRUSTRATED do you feel right now?"
        Me.LblStim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFrust
        '
        Me.lblFrust.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFrust.Font = New System.Drawing.Font("Arial Black", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrust.Location = New System.Drawing.Point(201, 72)
        Me.lblFrust.Name = "lblFrust"
        Me.lblFrust.Size = New System.Drawing.Size(263, 63)
        Me.lblFrust.TabIndex = 66
        Me.lblFrust.Text = "FRUSTRATED"
        Me.lblFrust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFrustration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.lblFrust)
        Me.Controls.Add(Me.pbxPointer)
        Me.Controls.Add(Me.LblStim)
        Me.Controls.Add(Me.btnFrustration)
        Me.Controls.Add(Me.trbFrustration)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmFrustration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Crave"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.trbFrustration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bwTimer As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents trbFrustration As System.Windows.Forms.TrackBar
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnFrustration As System.Windows.Forms.Button
    Friend WithEvents pbxPointer As System.Windows.Forms.PictureBox
    Friend WithEvents LblStim As System.Windows.Forms.Label
    Friend WithEvents lblFrust As System.Windows.Forms.Label
End Class
