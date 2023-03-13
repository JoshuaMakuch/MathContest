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
        Me.ControlsGroupbox.Location = New System.Drawing.Point(601, 12)
        Me.ControlsGroupbox.Name = "ControlsGroupbox"
        Me.ControlsGroupbox.Size = New System.Drawing.Size(230, 452)
        Me.ControlsGroupbox.TabIndex = 1
        Me.ControlsGroupbox.TabStop = False
        Me.ControlsGroupbox.Text = "Controls"
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentInformationGroupBox As GroupBox
    Friend WithEvents CurrentMathProblemGroupBox As GroupBox
    Friend WithEvents MathProblemTypeGroupbox As GroupBox
    Friend WithEvents ControlsGroupbox As GroupBox
End Class
