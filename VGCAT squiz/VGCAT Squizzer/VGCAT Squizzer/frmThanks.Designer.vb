<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThanks
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
        Me.lblThanks = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblThanks
        '
        Me.lblThanks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblThanks.AutoSize = True
        Me.lblThanks.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThanks.Location = New System.Drawing.Point(340, 211)
        Me.lblThanks.Name = "lblThanks"
        Me.lblThanks.Size = New System.Drawing.Size(258, 75)
        Me.lblThanks.TabIndex = 0
        Me.lblThanks.Text = "Thanks"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 30.0!)
        Me.Label1.Location = New System.Drawing.Point(80, 309)
        Me.Label1.MaximumSize = New System.Drawing.Size(800, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 90)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Remember to let the researchers know if you no longer want to work for either gam" & _
    "e."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmThanks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(929, 606)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblThanks)
        Me.Name = "frmThanks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Thanks"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblThanks As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
