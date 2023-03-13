<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MathContestForm
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
        Me.StudentInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.CurrentMathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.MathProblemTypeGroupbox = New System.Windows.Forms.GroupBox()
        Me.ControlsGroupbox = New System.Windows.Forms.GroupBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ControlsGroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentInformationGroupBox
        '
        Me.StudentInformationGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.StudentInformationGroupBox.Name = "StudentInformationGroupBox"
        Me.StudentInformationGroupBox.Size = New System.Drawing.Size(583, 120)
        Me.StudentInformationGroupBox.TabIndex = 0
        Me.StudentInformationGroupBox.TabStop = False
        Me.StudentInformationGroupBox.Text = "Student Information"
        '
        'CurrentMathProblemGroupBox
        '
        Me.CurrentMathProblemGroupBox.Location = New System.Drawing.Point(12, 138)
        Me.CurrentMathProblemGroupBox.Name = "CurrentMathProblemGroupBox"
        Me.CurrentMathProblemGroupBox.Size = New System.Drawing.Size(347, 326)
        Me.CurrentMathProblemGroupBox.TabIndex = 1
        Me.CurrentMathProblemGroupBox.TabStop = False
        Me.CurrentMathProblemGroupBox.Text = "Current Math Problem"
        '
        'MathProblemTypeGroupbox
        '
        Me.MathProblemTypeGroupbox.Location = New System.Drawing.Point(365, 138)
        Me.MathProblemTypeGroupbox.Name = "MathProblemTypeGroupbox"
        Me.MathProblemTypeGroupbox.Size = New System.Drawing.Size(230, 326)
        Me.MathProblemTypeGroupbox.TabIndex = 1
        Me.MathProblemTypeGroupbox.TabStop = False
        Me.MathProblemTypeGroupbox.Text = "Math Problem Type"
        '
        'ControlsGroupbox
        '
        Me.ControlsGroupbox.Controls.Add(Me.ExitButton)
        Me.ControlsGroupbox.Controls.Add(Me.SummaryButton)
        Me.ControlsGroupbox.Controls.Add(Me.ClearButton)
        Me.ControlsGroupbox.Controls.Add(Me.SubmitButton)
        Me.ControlsGroupbox.Location = New System.Drawing.Point(601, 12)
        Me.ControlsGroupbox.Name = "ControlsGroupbox"
        Me.ControlsGroupbox.Size = New System.Drawing.Size(230, 452)
        Me.ControlsGroupbox.TabIndex = 1
        Me.ControlsGroupbox.TabStop = False
        Me.ControlsGroupbox.Text = "Controls"
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(20, 26)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(192, 94)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(20, 126)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(192, 94)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(20, 226)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(192, 94)
        Me.SummaryButton.TabIndex = 2
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(20, 326)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(192, 94)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MathContestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 476)
        Me.Controls.Add(Me.CurrentMathProblemGroupBox)
        Me.Controls.Add(Me.MathProblemTypeGroupbox)
        Me.Controls.Add(Me.ControlsGroupbox)
        Me.Controls.Add(Me.StudentInformationGroupBox)
        Me.Name = "MathContestForm"
        Me.Text = "MathContestForm"
        Me.ControlsGroupbox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentInformationGroupBox As GroupBox
    Friend WithEvents CurrentMathProblemGroupBox As GroupBox
    Friend WithEvents MathProblemTypeGroupbox As GroupBox
    Friend WithEvents ControlsGroupbox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
End Class
