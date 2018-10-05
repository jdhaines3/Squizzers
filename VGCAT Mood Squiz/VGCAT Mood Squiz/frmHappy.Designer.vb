<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHappy
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
        Me.trbHappy = New System.Windows.Forms.TrackBar()
        Me.btnHappy = New System.Windows.Forms.Button()
        Me.lblHappy = New System.Windows.Forms.Label()
        Me.bwTimer = New System.ComponentModel.BackgroundWorker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelHappy2 = New System.Windows.Forms.Label()
        CType(Me.trbHappy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trbHappy
        '
        Me.trbHappy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.trbHappy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trbHappy.LargeChange = 1
        Me.trbHappy.Location = New System.Drawing.Point(74, 221)
        Me.trbHappy.Maximum = 100
        Me.trbHappy.Name = "trbHappy"
        Me.trbHappy.RightToLeftLayout = True
        Me.trbHappy.Size = New System.Drawing.Size(553, 45)
        Me.trbHappy.TabIndex = 0
        Me.trbHappy.Value = 50
        '
        'btnHappy
        '
        Me.btnHappy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHappy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHappy.Location = New System.Drawing.Point(157, 337)
        Me.btnHappy.Name = "btnHappy"
        Me.btnHappy.Size = New System.Drawing.Size(385, 51)
        Me.btnHappy.TabIndex = 13
        Me.btnHappy.Text = "Next Question"
        Me.btnHappy.UseVisualStyleBackColor = True
        '
        'lblHappy
        '
        Me.lblHappy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHappy.Font = New System.Drawing.Font("Arial Black", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHappy.Location = New System.Drawing.Point(23, 40)
        Me.lblHappy.Name = "lblHappy"
        Me.lblHappy.Size = New System.Drawing.Size(662, 164)
        Me.lblHappy.TabIndex = 37
        Me.lblHappy.Text = "How  HAPPY do you feel right now?"
        Me.lblHappy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'LabelHappy2
        '
        Me.LabelHappy2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelHappy2.Font = New System.Drawing.Font("Arial Black", 24.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHappy2.Location = New System.Drawing.Point(120, 87)
        Me.LabelHappy2.Name = "LabelHappy2"
        Me.LabelHappy2.Size = New System.Drawing.Size(150, 71)
        Me.LabelHappy2.TabIndex = 57
        Me.LabelHappy2.Text = "HAPPY"
        Me.LabelHappy2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHappy
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.LabelHappy2)
        Me.Controls.Add(Me.lblHappy)
        Me.Controls.Add(Me.btnHappy)
        Me.Controls.Add(Me.trbHappy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.KeyPreview = True
        Me.Name = "frmHappy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Happy"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.trbHappy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents trbHappy As System.Windows.Forms.TrackBar
    Friend WithEvents btnHappy As System.Windows.Forms.Button
    Friend WithEvents lblHappy As System.Windows.Forms.Label
    Friend WithEvents bwTimer As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabelHappy2 As System.Windows.Forms.Label
End Class

