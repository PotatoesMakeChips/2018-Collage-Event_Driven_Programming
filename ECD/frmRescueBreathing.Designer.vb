<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRescueBreathing
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
        Me.btnResBreAns = New System.Windows.Forms.Button()
        Me.cbResBreFalse = New System.Windows.Forms.CheckBox()
        Me.cbResBreTrue = New System.Windows.Forms.CheckBox()
        Me.lblResBreQuestion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnResBreAns
        '
        Me.btnResBreAns.Location = New System.Drawing.Point(107, 173)
        Me.btnResBreAns.Name = "btnResBreAns"
        Me.btnResBreAns.Size = New System.Drawing.Size(75, 35)
        Me.btnResBreAns.TabIndex = 15
        Me.btnResBreAns.Text = "Next Question"
        Me.btnResBreAns.UseVisualStyleBackColor = True
        '
        'cbResBreFalse
        '
        Me.cbResBreFalse.AutoSize = True
        Me.cbResBreFalse.Location = New System.Drawing.Point(182, 105)
        Me.cbResBreFalse.Name = "cbResBreFalse"
        Me.cbResBreFalse.Size = New System.Drawing.Size(51, 17)
        Me.cbResBreFalse.TabIndex = 14
        Me.cbResBreFalse.Text = "False"
        Me.cbResBreFalse.UseVisualStyleBackColor = True
        '
        'cbResBreTrue
        '
        Me.cbResBreTrue.AutoSize = True
        Me.cbResBreTrue.Location = New System.Drawing.Point(52, 105)
        Me.cbResBreTrue.Name = "cbResBreTrue"
        Me.cbResBreTrue.Size = New System.Drawing.Size(48, 17)
        Me.cbResBreTrue.TabIndex = 13
        Me.cbResBreTrue.Text = "True"
        Me.cbResBreTrue.UseVisualStyleBackColor = True
        '
        'lblResBreQuestion
        '
        Me.lblResBreQuestion.AutoSize = True
        Me.lblResBreQuestion.Location = New System.Drawing.Point(6, 65)
        Me.lblResBreQuestion.Name = "lblResBreQuestion"
        Me.lblResBreQuestion.Size = New System.Drawing.Size(271, 13)
        Me.lblResBreQuestion.TabIndex = 12
        Me.lblResBreQuestion.Text = "Rescue breaths are part of chest-compression-only CPR"
        '
        'frmRescueBreathing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnResBreAns)
        Me.Controls.Add(Me.cbResBreFalse)
        Me.Controls.Add(Me.cbResBreTrue)
        Me.Controls.Add(Me.lblResBreQuestion)
        Me.Name = "frmRescueBreathing"
        Me.Text = "Rescue Breathing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnResBreAns As Button
    Friend WithEvents cbResBreFalse As CheckBox
    Friend WithEvents cbResBreTrue As CheckBox
    Friend WithEvents lblResBreQuestion As Label
End Class
