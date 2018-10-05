<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrinks
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
        Me.lblDrinks = New System.Windows.Forms.Label()
        Me.lblCrave = New System.Windows.Forms.Label()
        Me.Number = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDrinks
        '
        Me.lblDrinks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDrinks.AutoSize = True
        Me.lblDrinks.Font = New System.Drawing.Font("Arial Black", 30.0!)
        Me.lblDrinks.Location = New System.Drawing.Point(523, 216)
        Me.lblDrinks.Name = "lblDrinks"
        Me.lblDrinks.Size = New System.Drawing.Size(254, 56)
        Me.lblDrinks.TabIndex = 0
        Me.lblDrinks.Text = "Right now,"
        Me.lblDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCrave
        '
        Me.lblCrave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCrave.Font = New System.Drawing.Font("Arial Black", 30.0!)
        Me.lblCrave.Location = New System.Drawing.Point(430, 277)
        Me.lblCrave.Name = "lblCrave"
        Me.lblCrave.Size = New System.Drawing.Size(441, 61)
        Me.lblCrave.TabIndex = 58
        Me.lblCrave.Text = "I feel as if I've had:"
        Me.lblCrave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Number
        '
        Me.Number.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Number.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!)
        Me.Number.Location = New System.Drawing.Point(618, 361)
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(74, 42)
        Me.Number.TabIndex = 59
        Me.Number.Text = "0"
        Me.Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 30.0!)
        Me.Label1.Location = New System.Drawing.Point(431, 421)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 64)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "of my usual drinks."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.HASDA_sQuizzer.My.Resources.Resources.Left1
        Me.PictureBox1.Location = New System.Drawing.Point(520, 361)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.HASDA_sQuizzer.My.Resources.Resources.right
        Me.PictureBox2.Location = New System.Drawing.Point(710, 361)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'frmDrinks
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1284, 729)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Number)
        Me.Controls.Add(Me.lblCrave)
        Me.Controls.Add(Me.lblDrinks)
        Me.KeyPreview = True
        Me.Name = "frmDrinks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Drinks"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDrinks As System.Windows.Forms.Label
    Friend WithEvents lblCrave As System.Windows.Forms.Label
    Friend WithEvents Number As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
