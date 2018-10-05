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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDrinks))
        Me.lblDrinks = New System.Windows.Forms.Label
        Me.btnDrinks = New System.Windows.Forms.Button
        Me.pbxPointer = New System.Windows.Forms.PictureBox
        Me.bwTimer = New System.ComponentModel.BackgroundWorker
        Me.lblCrave = New System.Windows.Forms.Label
        Me.Number = New System.Windows.Forms.TextBox
        Me.btnUp = New System.Windows.Forms.Button
        Me.btnDown = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDrinks
        '
        Me.lblDrinks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDrinks.AutoSize = True
        Me.lblDrinks.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinks.Location = New System.Drawing.Point(107, 77)
        Me.lblDrinks.Name = "lblDrinks"
        Me.lblDrinks.Size = New System.Drawing.Size(226, 50)
        Me.lblDrinks.TabIndex = 0
        Me.lblDrinks.Text = "Right now,"
        '
        'btnDrinks
        '
        Me.btnDrinks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrinks.Location = New System.Drawing.Point(157, 337)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(385, 51)
        Me.btnDrinks.TabIndex = 13
        Me.btnDrinks.Text = "Next Question"
        Me.btnDrinks.UseVisualStyleBackColor = True
        '
        'pbxPointer
        '
        Me.pbxPointer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxPointer.Image = CType(resources.GetObject("pbxPointer.Image"), System.Drawing.Image)
        Me.pbxPointer.Location = New System.Drawing.Point(82, 200)
        Me.pbxPointer.Name = "pbxPointer"
        Me.pbxPointer.Size = New System.Drawing.Size(11, 21)
        Me.pbxPointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxPointer.TabIndex = 17
        Me.pbxPointer.TabStop = False
        '
        'bwTimer
        '
        '
        'lblCrave
        '
        Me.lblCrave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCrave.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrave.Location = New System.Drawing.Point(12, 136)
        Me.lblCrave.Name = "lblCrave"
        Me.lblCrave.Size = New System.Drawing.Size(687, 100)
        Me.lblCrave.TabIndex = 58
        Me.lblCrave.Text = "I feel as if I've had          of my"
        Me.lblCrave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Number
        '
        Me.Number.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Number.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!)
        Me.Number.Location = New System.Drawing.Point(427, 170)
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(74, 40)
        Me.Number.TabIndex = 59
        Me.Number.Text = "0"
        Me.Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUp
        '
        Me.btnUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUp.BackColor = System.Drawing.Color.Transparent
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(432, 105)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(64, 48)
        Me.btnUp.TabIndex = 60
        Me.btnUp.Text = "More"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(432, 218)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(64, 48)
        Me.btnDown.TabIndex = 61
        Me.btnDown.Text = "Less"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 64)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "usual drinks."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDrinks
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.Number)
        Me.Controls.Add(Me.lblCrave)
        Me.Controls.Add(Me.pbxPointer)
        Me.Controls.Add(Me.btnDrinks)
        Me.Controls.Add(Me.lblDrinks)
        Me.KeyPreview = True
        Me.Name = "frmDrinks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Drinks"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbxPointer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDrinks As System.Windows.Forms.Label
    Friend WithEvents btnDrinks As System.Windows.Forms.Button
    Friend WithEvents pbxPointer As System.Windows.Forms.PictureBox
    Friend WithEvents bwTimer As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblCrave As System.Windows.Forms.Label
    Friend WithEvents Number As System.Windows.Forms.TextBox
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
