<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbdominalThrust
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
        Me.btnAbThrAns = New System.Windows.Forms.Button()
        Me.cbAbThrFalse = New System.Windows.Forms.CheckBox()
        Me.cbAbThrTrue = New System.Windows.Forms.CheckBox()
        Me.lblAbThrQuestion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAbThrAns
        '
        Me.btnAbThrAns.Location = New System.Drawing.Point(107, 173)
        Me.btnAbThrAns.Name = "btnAbThrAns"
        Me.btnAbThrAns.Size = New System.Drawing.Size(75, 35)
        Me.btnAbThrAns.TabIndex = 7
        Me.btnAbThrAns.Text = "Next Question"
        Me.btnAbThrAns.UseVisualStyleBackColor = True
        '
        'cbAbThrFalse
        '
        Me.cbAbThrFalse.AutoSize = True
        Me.cbAbThrFalse.Location = New System.Drawing.Point(182, 105)
        Me.cbAbThrFalse.Name = "cbAbThrFalse"
        Me.cbAbThrFalse.Size = New System.Drawing.Size(51, 17)
        Me.cbAbThrFalse.TabIndex = 6
        Me.cbAbThrFalse.Text = "False"
        Me.cbAbThrFalse.UseVisualStyleBackColor = True
        '
        'cbAbThrTrue
        '
        Me.cbAbThrTrue.AutoSize = True
        Me.cbAbThrTrue.Location = New System.Drawing.Point(52, 105)
        Me.cbAbThrTrue.Name = "cbAbThrTrue"
        Me.cbAbThrTrue.Size = New System.Drawing.Size(48, 17)
        Me.cbAbThrTrue.TabIndex = 5
        Me.cbAbThrTrue.Text = "True"
        Me.cbAbThrTrue.UseVisualStyleBackColor = True
        '
        'lblAbThrQuestion
        '
        Me.lblAbThrQuestion.AutoSize = True
        Me.lblAbThrQuestion.Location = New System.Drawing.Point(39, 59)
        Me.lblAbThrQuestion.Name = "lblAbThrQuestion"
        Me.lblAbThrQuestion.Size = New System.Drawing.Size(212, 13)
        Me.lblAbThrQuestion.TabIndex = 4
        Me.lblAbThrQuestion.Text = "If someone coughs they are going to choke"
        '
        'frmAbdominalThrust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnAbThrAns)
        Me.Controls.Add(Me.cbAbThrFalse)
        Me.Controls.Add(Me.cbAbThrTrue)
        Me.Controls.Add(Me.lblAbThrQuestion)
        Me.Name = "frmAbdominalThrust"
        Me.Text = "Abdominal Thrust"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbThrAns As Button
    Friend WithEvents cbAbThrFalse As CheckBox
    Friend WithEvents cbAbThrTrue As CheckBox
    Friend WithEvents lblAbThrQuestion As Label
End Class
