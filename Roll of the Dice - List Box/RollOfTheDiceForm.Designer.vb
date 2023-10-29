<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollOfTheDiceForm
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
        Me.DisplayRollsListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(130, 344)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(165, 83)
        Me.RollButton.TabIndex = 0
        Me.RollButton.Text = "&Roll"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(301, 344)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(165, 83)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(472, 344)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(165, 83)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DisplayRollsListBox
        '
        Me.DisplayRollsListBox.FormattingEnabled = True
        Me.DisplayRollsListBox.ItemHeight = 16
        Me.DisplayRollsListBox.Location = New System.Drawing.Point(45, 35)
        Me.DisplayRollsListBox.Name = "DisplayRollsListBox"
        Me.DisplayRollsListBox.Size = New System.Drawing.Size(722, 260)
        Me.DisplayRollsListBox.TabIndex = 3
        Me.DisplayRollsListBox.TabStop = False
        '
        'RollOfTheDiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DisplayRollsListBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RollButton)
        Me.Name = "RollOfTheDiceForm"
        Me.Text = "Roll of the Dice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RollButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DisplayRollsListBox As ListBox
End Class
