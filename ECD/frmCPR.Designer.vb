<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCPR
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
        Me.lblCprQuestion = New System.Windows.Forms.Label()
        Me.cbCprTrue = New System.Windows.Forms.CheckBox()
        Me.cbCprFalse = New System.Windows.Forms.CheckBox()
        Me.btnCprAns = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblCprQuestion
        '
        Me.lblCprQuestion.AutoSize = True
        Me.lblCprQuestion.Location = New System.Drawing.Point(17, 59)
        Me.lblCprQuestion.Name = "lblCprQuestion"
        Me.lblCprQuestion.Size = New System.Drawing.Size(255, 13)
        Me.lblCprQuestion.TabIndex = 0
        Me.lblCprQuestion.Text = "CPR compresions should be at the speed of 120bpm"
        '
        'cbCprTrue
        '
        Me.cbCprTrue.AutoSize = True
        Me.cbCprTrue.Location = New System.Drawing.Point(52, 105)
        Me.cbCprTrue.Name = "cbCprTrue"
        Me.cbCprTrue.Size = New System.Drawing.Size(48, 17)
        Me.cbCprTrue.TabIndex = 1
        Me.cbCprTrue.Text = "True"
        Me.cbCprTrue.UseVisualStyleBackColor = True
        '
        'cbCprFalse
        '
        Me.cbCprFalse.AutoSize = True
        Me.cbCprFalse.Location = New System.Drawing.Point(182, 105)
        Me.cbCprFalse.Name = "cbCprFalse"
        Me.cbCprFalse.Size = New System.Drawing.Size(51, 17)
        Me.cbCprFalse.TabIndex = 2
        Me.cbCprFalse.Text = "False"
        Me.cbCprFalse.UseVisualStyleBackColor = True
        '
        'btnCprAns
        '
        Me.btnCprAns.Location = New System.Drawing.Point(107, 173)
        Me.btnCprAns.Name = "btnCprAns"
        Me.btnCprAns.Size = New System.Drawing.Size(75, 35)
        Me.btnCprAns.TabIndex = 3
        Me.btnCprAns.Text = "Next Question"
        Me.btnCprAns.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 233)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Mute Music"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmCPR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnCprAns)
        Me.Controls.Add(Me.cbCprFalse)
        Me.Controls.Add(Me.cbCprTrue)
        Me.Controls.Add(Me.lblCprQuestion)
        Me.Name = "frmCPR"
        Me.Text = "CPR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCprQuestion As Label
    Friend WithEvents cbCprTrue As CheckBox
    Friend WithEvents cbCprFalse As CheckBox
    Friend WithEvents btnCprAns As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
