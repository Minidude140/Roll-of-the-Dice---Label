<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollOfTheDiceLabelForm
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
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.PossibleRollsLabel = New System.Windows.Forms.Label()
        Me.RollTallyLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(139, 272)
        Me.RollButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(124, 67)
        Me.RollButton.TabIndex = 0
        Me.RollButton.Text = "&Roll"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(267, 272)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(124, 67)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(395, 272)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(124, 67)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DisplayLabel
        '
        Me.DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisplayLabel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.Location = New System.Drawing.Point(101, 51)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(503, 159)
        Me.DisplayLabel.TabIndex = 3
        Me.DisplayLabel.Text = "displaylabel"
        Me.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PossibleRollsLabel
        '
        Me.PossibleRollsLabel.AutoSize = True
        Me.PossibleRollsLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PossibleRollsLabel.Location = New System.Drawing.Point(6, 76)
        Me.PossibleRollsLabel.Name = "PossibleRollsLabel"
        Me.PossibleRollsLabel.Size = New System.Drawing.Size(82, 15)
        Me.PossibleRollsLabel.TabIndex = 4
        Me.PossibleRollsLabel.Text = "Possible Rolls"
        '
        'RollTallyLabel
        '
        Me.RollTallyLabel.AutoSize = True
        Me.RollTallyLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RollTallyLabel.Location = New System.Drawing.Point(26, 124)
        Me.RollTallyLabel.Name = "RollTallyLabel"
        Me.RollTallyLabel.Size = New System.Drawing.Size(62, 15)
        Me.RollTallyLabel.TabIndex = 5
        Me.RollTallyLabel.Text = "Roll Tally"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(205, 19)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(290, 21)
        Me.TitleLabel.TabIndex = 6
        Me.TitleLabel.Text = "Roll Two Six Sided Die 1,000 Times"
        '
        'RollOfTheDiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 366)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.RollTallyLabel)
        Me.Controls.Add(Me.PossibleRollsLabel)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RollButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RollOfTheDiceForm"
        Me.Text = "Roll of the Dice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RollButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents PossibleRollsLabel As Label
    Friend WithEvents RollTallyLabel As Label
    Friend WithEvents TitleLabel As Label
End Class
