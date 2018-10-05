<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPacsQ5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPacsQ5))
        Me.Number = New System.Windows.Forms.TextBox()
        Me.pbxPointer = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblCrave = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Number
        '
        Me.Number.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Number.BackColor = System.Drawing.Color.LightGray
        Me.Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.Number.Location = New System.Drawing.Point(589, 600)
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(100, 47)
        Me.Number.TabIndex = 59
        Me.Number.Text = "0"
        Me.Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbxPointer
        '
        Me.pbxPointer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxPointer.Image = CType(resources.GetObject("pbxPointer.Image"), System.Drawing.Image)
        Me.pbxPointer.Location = New System.Drawing.Point(374, 364)
        Me.pbxPointer.Name = "pbxPointer"
        Me.pbxPointer.Size = New System.Drawing.Size(11, 21)
        Me.pbxPointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxPointer.TabIndex = 17
        Me.pbxPointer.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImage = Global.SAM_Ratings.My.Resources.Resources.Left
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(479, 600)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 47)
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackgroundImage = Global.SAM_Ratings.My.Resources.Resources.Right
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(719, 600)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(78, 47)
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'lblCrave
        '
        Me.lblCrave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCrave.Font = New System.Drawing.Font("Arial Black", 17.0!)
        Me.lblCrave.Location = New System.Drawing.Point(248, 266)
        Me.lblCrave.Name = "lblCrave"
        Me.lblCrave.Size = New System.Drawing.Size(804, 250)
        Me.lblCrave.TabIndex = 58
        Me.lblCrave.Text = resources.GetString("lblCrave.Text")
        Me.lblCrave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 22.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.Location = New System.Drawing.Point(222, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(855, 138)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Keeping in mind your responses to the previous questions, please rate your overal" &
    "l average alcohol craving for the past week."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPacsQ5
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1284, 729)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Number)
        Me.Controls.Add(Me.lblCrave)
        Me.Controls.Add(Me.pbxPointer)
        Me.KeyPreview = True
        Me.Name = "frmPacsQ5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PacsQ5"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxPointer As System.Windows.Forms.PictureBox
    Friend WithEvents Number As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblCrave As Label
    Friend WithEvents Label1 As Label
End Class
