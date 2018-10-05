<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAversive
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
        Me.lblAversive = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.trbAversive = New System.Windows.Forms.TrackBar()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.trbAversive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAversive
        '
        Me.lblAversive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAversive.Font = New System.Drawing.Font("Arial Black", 28.0!)
        Me.lblAversive.Location = New System.Drawing.Point(332, 259)
        Me.lblAversive.Name = "lblAversive"
        Me.lblAversive.Size = New System.Drawing.Size(635, 114)
        Me.lblAversive.TabIndex = 54
        Me.lblAversive.Text = "The tones and images that I just saw are:"
        Me.lblAversive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(339, 528)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 45)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Negative"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(863, 527)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 45)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Positive"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(617, 538)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 19)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Neutral"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(643, 515)
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
        Me.Label2.Location = New System.Drawing.Point(380, 518)
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
        Me.Label10.Location = New System.Drawing.Point(907, 518)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 23)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "|"
        '
        'trbAversive
        '
        Me.trbAversive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.trbAversive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trbAversive.LargeChange = 1
        Me.trbAversive.Location = New System.Drawing.Point(373, 478)
        Me.trbAversive.Maximum = 100
        Me.trbAversive.Name = "trbAversive"
        Me.trbAversive.RightToLeftLayout = True
        Me.trbAversive.Size = New System.Drawing.Size(553, 45)
        Me.trbAversive.TabIndex = 58
        Me.trbAversive.Value = 50
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(372, 476)
        Me.Label11.MinimumSize = New System.Drawing.Size(555, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(555, 50)
        Me.Label11.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(776, 516)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 23)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "|"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(512, 516)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 23)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "|"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(733, 529)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 55)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Somewhat Positive"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(462, 531)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 48)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Somewhat Negative"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAversive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1284, 729)
        Me.Controls.Add(Me.trbAversive)
        Me.Controls.Add(Me.lblAversive)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Name = "frmAversive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aversive"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.trbAversive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAversive As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents trbAversive As System.Windows.Forms.TrackBar
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
