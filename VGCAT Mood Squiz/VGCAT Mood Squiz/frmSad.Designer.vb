<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSad
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
        Me.trbSad = New System.Windows.Forms.TrackBar()
        Me.btnSad = New System.Windows.Forms.Button()
        Me.lblSad = New System.Windows.Forms.Label()
        Me.bwTimer = New System.ComponentModel.BackgroundWorker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelSad2 = New System.Windows.Forms.Label()
        CType(Me.trbSad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trbSad
        '
        Me.trbSad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.trbSad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trbSad.LargeChange = 1
        Me.trbSad.Location = New System.Drawing.Point(74, 221)
        Me.trbSad.Maximum = 100
        Me.trbSad.Name = "trbSad"
        Me.trbSad.RightToLeftLayout = True
        Me.trbSad.Size = New System.Drawing.Size(553, 45)
        Me.trbSad.TabIndex = 0
        Me.trbSad.Value = 50
        '
        'btnSad
        '
        Me.btnSad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSad.Location = New System.Drawing.Point(157, 337)
        Me.btnSad.Name = "btnSad"
        Me.btnSad.Size = New System.Drawing.Size(385, 51)
        Me.btnSad.TabIndex = 13
        Me.btnSad.Text = "Next Question"
        Me.btnSad.UseVisualStyleBackColor = True
        '
        'lblSad
        '
        Me.lblSad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSad.Font = New System.Drawing.Font("Arial Black", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSad.Location = New System.Drawing.Point(23, 40)
        Me.lblSad.Name = "lblSad"
        Me.lblSad.Size = New System.Drawing.Size(662, 164)
        Me.lblSad.TabIndex = 37
        Me.lblSad.Text = "How  SAD do you feel right now?"
        Me.lblSad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bwTimer
        '
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
        'LabelSad2
        '
        Me.LabelSad2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelSad2.Font = New System.Drawing.Font("Arial Black", 24.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSad2.Location = New System.Drawing.Point(142, 87)
        Me.LabelSad2.Name = "LabelSad2"
        Me.LabelSad2.Size = New System.Drawing.Size(104, 71)
        Me.LabelSad2.TabIndex = 57
        Me.LabelSad2.Text = "SAD"
        Me.LabelSad2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSad
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.LabelSad2)
        Me.Controls.Add(Me.lblSad)
        Me.Controls.Add(Me.btnSad)
        Me.Controls.Add(Me.trbSad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.KeyPreview = True
        Me.Name = "frmSad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.trbSad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents trbSad As System.Windows.Forms.TrackBar
    Friend WithEvents btnSad As System.Windows.Forms.Button
    Friend WithEvents lblSad As System.Windows.Forms.Label
    Friend WithEvents bwTimer As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabelSad2 As System.Windows.Forms.Label
End Class
