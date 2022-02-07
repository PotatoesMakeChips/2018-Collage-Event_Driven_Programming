<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecoveryPosition
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
        Me.btnRecPosAns = New System.Windows.Forms.Button()
        Me.cbRecPosFalse = New System.Windows.Forms.CheckBox()
        Me.cbRecPosTrue = New System.Windows.Forms.CheckBox()
        Me.lblRecPosQuestion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRecPosAns
        '
        Me.btnRecPosAns.Location = New System.Drawing.Point(107, 173)
        Me.btnRecPosAns.Name = "btnRecPosAns"
        Me.btnRecPosAns.Size = New System.Drawing.Size(75, 35)
        Me.btnRecPosAns.TabIndex = 11
        Me.btnRecPosAns.Text = "Next Question"
        Me.btnRecPosAns.UseVisualStyleBackColor = True
        '
        'cbRecPosFalse
        '
        Me.cbRecPosFalse.AutoSize = True
        Me.cbRecPosFalse.Location = New System.Drawing.Point(182, 105)
        Me.cbRecPosFalse.Name = "cbRecPosFalse"
        Me.cbRecPosFalse.Size = New System.Drawing.Size(51, 17)
        Me.cbRecPosFalse.TabIndex = 10
        Me.cbRecPosFalse.Text = "False"
        Me.cbRecPosFalse.UseVisualStyleBackColor = True
        '
        'cbRecPosTrue
        '
        Me.cbRecPosTrue.AutoSize = True
        Me.cbRecPosTrue.Location = New System.Drawing.Point(52, 105)
        Me.cbRecPosTrue.Name = "cbRecPosTrue"
        Me.cbRecPosTrue.Size = New System.Drawing.Size(48, 17)
        Me.cbRecPosTrue.TabIndex = 9
        Me.cbRecPosTrue.Text = "True"
        Me.cbRecPosTrue.UseVisualStyleBackColor = True
        '
        'lblRecPosQuestion
        '
        Me.lblRecPosQuestion.AutoSize = True
        Me.lblRecPosQuestion.Location = New System.Drawing.Point(32, 50)
        Me.lblRecPosQuestion.Name = "lblRecPosQuestion"
        Me.lblRecPosQuestion.Size = New System.Drawing.Size(223, 13)
        Me.lblRecPosQuestion.TabIndex = 8
        Me.lblRecPosQuestion.Text = "The recovery position helps prevent chokeing"
        '
        'frmRecoveryPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnRecPosAns)
        Me.Controls.Add(Me.cbRecPosFalse)
        Me.Controls.Add(Me.cbRecPosTrue)
        Me.Controls.Add(Me.lblRecPosQuestion)
        Me.Name = "frmRecoveryPosition"
        Me.Text = "Recovery Position"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRecPosAns As Button
    Friend WithEvents cbRecPosFalse As CheckBox
    Friend WithEvents cbRecPosTrue As CheckBox
    Friend WithEvents lblRecPosQuestion As Label
End Class
