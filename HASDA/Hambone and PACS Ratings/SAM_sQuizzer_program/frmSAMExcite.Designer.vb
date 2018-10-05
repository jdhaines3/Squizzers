<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSAMExcite
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.trbSAMExcite = New System.Windows.Forms.TrackBar()
        Me.lblSAMExcite = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SAMExcite = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.trbSAMExcite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAMExcite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(888, 540)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 19)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Calm"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(344, 539)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Stimulated"
        '
        'trbSAMExcite
        '
        Me.trbSAMExcite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.trbSAMExcite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trbSAMExcite.LargeChange = 1
        Me.trbSAMExcite.Location = New System.Drawing.Point(373, 478)
        Me.trbSAMExcite.Maximum = 8
        Me.trbSAMExcite.Name = "trbSAMExcite"
        Me.trbSAMExcite.RightToLeftLayout = True
        Me.trbSAMExcite.Size = New System.Drawing.Size(553, 45)
        Me.trbSAMExcite.TabIndex = 18
        Me.trbSAMExcite.Value = 4
        '
        'lblSAMExcite
        '
        Me.lblSAMExcite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSAMExcite.Font = New System.Drawing.Font("Arial Black", 28.0!)
        Me.lblSAMExcite.Location = New System.Drawing.Point(250, 80)
        Me.lblSAMExcite.Name = "lblSAMExcite"
        Me.lblSAMExcite.Size = New System.Drawing.Size(800, 164)
        Me.lblSAMExcite.TabIndex = 35
        Me.lblSAMExcite.Text = "The tones and images that I just saw made me feel (Stimulated --> Calm):"
        Me.lblSAMExcite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(372, 477)
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
        Me.Label2.Location = New System.Drawing.Point(906, 518)
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
        Me.Label10.Location = New System.Drawing.Point(379, 518)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 23)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "|"
        '
        'SAMExcite
        '
        Me.SAMExcite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SAMExcite.Image = Global.SAM_Ratings.My.Resources.Resources.Excited_Hambone
        Me.SAMExcite.Location = New System.Drawing.Point(347, 260)
        Me.SAMExcite.Name = "SAMExcite"
        Me.SAMExcite.Size = New System.Drawing.Size(606, 170)
        Me.SAMExcite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAMExcite.TabIndex = 57
        Me.SAMExcite.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(644, 517)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 23)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "|"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(618, 537)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Neutral"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(776, 515)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 23)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "|"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(513, 515)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 23)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "|"
        '
        'frmSAMExcite
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1284, 729)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SAMExcite)
        Me.Controls.Add(Me.lblSAMExcite)
        Me.Controls.Add(Me.trbSAMExcite)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmSAMExcite"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SAMExcite"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.trbSAMExcite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAMExcite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents trbSAMExcite As System.Windows.Forms.TrackBar
    Friend WithEvents lblSAMExcite As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SAMExcite As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
