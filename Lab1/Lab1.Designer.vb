<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lab1
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
        Me.components = New System.ComponentModel.Container()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblDayCount = New System.Windows.Forms.Label()
        Me.txtUserEntry = New System.Windows.Forms.TextBox()
        Me.lblUnitsShipped = New System.Windows.Forms.Label()
        Me.lblAverageOutput = New System.Windows.Forms.Label()
        Me.btnEnterButton = New System.Windows.Forms.Button()
        Me.btnResetButton = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(12, 27)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(52, 21)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDayCount
        '
        Me.lblDayCount.Location = New System.Drawing.Point(194, 31)
        Me.lblDayCount.Name = "lblDayCount"
        Me.lblDayCount.Size = New System.Drawing.Size(51, 13)
        Me.lblDayCount.TabIndex = 2
        Me.lblDayCount.Text = "Day 1"
        Me.lblDayCount.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTips.SetToolTip(Me.lblDayCount, "What day is currently being added")
        '
        'txtUserEntry
        '
        Me.txtUserEntry.Location = New System.Drawing.Point(81, 27)
        Me.txtUserEntry.Name = "txtUserEntry"
        Me.txtUserEntry.Size = New System.Drawing.Size(101, 20)
        Me.txtUserEntry.TabIndex = 1
        Me.ToolTips.SetToolTip(Me.txtUserEntry, "User Entry: Please enter a number from 0-1000")
        '
        'lblUnitsShipped
        '
        Me.lblUnitsShipped.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUnitsShipped.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUnitsShipped.Location = New System.Drawing.Point(33, 53)
        Me.lblUnitsShipped.Name = "lblUnitsShipped"
        Me.lblUnitsShipped.Size = New System.Drawing.Size(207, 127)
        Me.lblUnitsShipped.TabIndex = 3
        Me.lblUnitsShipped.Text = "                   "
        Me.ToolTips.SetToolTip(Me.lblUnitsShipped, "List of all entered units")
        '
        'lblAverageOutput
        '
        Me.lblAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverageOutput.Location = New System.Drawing.Point(33, 183)
        Me.lblAverageOutput.Name = "lblAverageOutput"
        Me.lblAverageOutput.Size = New System.Drawing.Size(207, 26)
        Me.lblAverageOutput.TabIndex = 4
        Me.lblAverageOutput.Text = " "
        Me.lblAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblAverageOutput, "Error message/ Final averaged amount")
        '
        'btnEnterButton
        '
        Me.btnEnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnterButton.Location = New System.Drawing.Point(2, 212)
        Me.btnEnterButton.Name = "btnEnterButton"
        Me.btnEnterButton.Size = New System.Drawing.Size(90, 27)
        Me.btnEnterButton.TabIndex = 5
        Me.btnEnterButton.Text = "&Enter"
        Me.ToolTips.SetToolTip(Me.btnEnterButton, "Enter button that allows user to enter in next number")
        Me.btnEnterButton.UseVisualStyleBackColor = True
        '
        'btnResetButton
        '
        Me.btnResetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResetButton.Location = New System.Drawing.Point(95, 212)
        Me.btnResetButton.Name = "btnResetButton"
        Me.btnResetButton.Size = New System.Drawing.Size(90, 27)
        Me.btnResetButton.TabIndex = 6
        Me.btnResetButton.Text = "&Reset"
        Me.ToolTips.SetToolTip(Me.btnResetButton, "Reset button that allows user to reset entire application")
        Me.btnResetButton.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(188, 212)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 27)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.ToolTips.SetToolTip(Me.btnExit, "Exit button that allows user to exit on will")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Lab1
        '
        Me.AcceptButton = Me.btnEnterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CancelButton = Me.btnResetButton
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnResetButton)
        Me.Controls.Add(Me.btnEnterButton)
        Me.Controls.Add(Me.lblAverageOutput)
        Me.Controls.Add(Me.lblUnitsShipped)
        Me.Controls.Add(Me.txtUserEntry)
        Me.Controls.Add(Me.lblDayCount)
        Me.Controls.Add(Me.lblUnits)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lab1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ToolTips.SetToolTip(Me, "toolTips")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDayCount As Label
    Friend WithEvents txtUserEntry As TextBox
    Friend WithEvents lblUnitsShipped As Label
    Friend WithEvents lblAverageOutput As Label
    Friend WithEvents btnEnterButton As Button
    Friend WithEvents btnResetButton As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTips As ToolTip
End Class
