<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlert))
        Me.trbAlert = New System.Windows.Forms.TrackBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAlert = New System.Windows.Forms.Button()
        Me.lblAlert = New System.Windows.Forms.Label()
        Me.bwTimer = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pbxPointer = New System.Windows.Forms.PictureBox()
        Me.LabelAlert2 = New System.Windows.Forms.Label()
        CType(Me.trbAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trbAlert
        '
        Me.trbAlert.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.trbAlert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trbAlert.LargeChange = 1
        Me.trbAlert.Location = New System.Drawing.Point(74, 221)
        Me.trbAlert.Maximum = 100
        Me.trbAlert.Name = "trbAlert"
        Me.trbAlert.RightToLeftLayout = True
        Me.trbAlert.Size = New System.Drawing.Size(553, 45)
        Me.trbAlert.TabIndex = 0
        Me.trbAlert.Value = 50
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(302, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 21)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Somewhat"
        '
        'btnAlert
        '
        Me.btnAlert.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlert.Location = New System.Drawing.Point(157, 337)
        Me.btnAlert.Name = "btnAlert"
        Me.btnAlert.Size = New System.Drawing.Size(385, 51)
        Me.btnAlert.TabIndex = 13
        Me.btnAlert.Text = "Next Question"
        Me.btnAlert.UseVisualStyleBackColor = True
        '
        'lblAlert
        '
        Me.lblAlert.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAlert.Font = New System.Drawing.Font("Arial Black", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlert.Location = New System.Drawing.Point(23, 40)
        Me.lblAlert.Name = "lblAlert"
        Me.lblAlert.Size = New System.Drawing.Size(662, 164)
        Me.lblAlert.TabIndex = 37
        Me.lblAlert.Text = "How  ALERT do you feel right now?"
        Me.lblAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bwTimer
        '
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(343, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 23)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "|"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(566, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 45)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Extremely"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 45)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Not At All"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(73, 220)
        Me.Label5.MinimumSize = New System.Drawing.Size(555, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(555, 47)
        Me.Label5.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(607, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 23)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "|"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(80, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 23)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "|"
        '
        'pbxPointer
        '
        Me.pbxPointer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxPointer.Image = CType(resources.GetObject("pbxPointer.Image"), System.Drawing.Image)
        Me.pbxPointer.Location = New System.Drawing.Point(81, 198)
        Me.pbxPointer.Name = "pbxPointer"
        Me.pbxPointer.Size = New System.Drawing.Size(13, 22)
        Me.pbxPointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPointer.TabIndex = 56
        Me.pbxPointer.TabStop = False
        Me.pbxPointer.Visible = False
        '
        'LabelAlert2
        '
        Me.LabelAlert2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelAlert2.Font = New System.Drawing.Font("Arial Black", 24.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlert2.Location = New System.Drawing.Point(117, 87)
        Me.LabelAlert2.Name = "LabelAlert2"
        Me.LabelAlert2.Size = New System.Drawing.Size(150, 71)
        Me.LabelAlert2.TabIndex = 57
        Me.LabelAlert2.Text = "ALERT"
        Me.LabelAlert2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAlert
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.LabelAlert2)
        Me.Controls.Add(Me.pbxPointer)
        Me.Controls.Add(Me.lblAlert)
        Me.Controls.Add(Me.btnAlert)
        Me.Controls.Add(Me.trbAlert)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.KeyPreview = True
        Me.Name = "frmAlert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alert"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.trbAlert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents trbAlert As System.Windows.Forms.TrackBar
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAlert As System.Windows.Forms.Button
    Friend WithEvents lblAlert As System.Windows.Forms.Label
    Friend WithEvents bwTimer As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pbxPointer As System.Windows.Forms.PictureBox
    Friend WithEvents LabelAlert2 As System.Windows.Forms.Label
End Class
