<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSetUp = New System.Windows.Forms.Button()
        Me.btnPunchLine = New System.Windows.Forms.Button()
        Me.lblJoke = New System.Windows.Forms.Label()
        Me.lblPunchLine = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSetUp
        '
        Me.btnSetUp.Location = New System.Drawing.Point(78, 120)
        Me.btnSetUp.Name = "btnSetUp"
        Me.btnSetUp.Size = New System.Drawing.Size(101, 60)
        Me.btnSetUp.TabIndex = 0
        Me.btnSetUp.Text = "Set Up"
        Me.btnSetUp.UseVisualStyleBackColor = True
        '
        'btnPunchLine
        '
        Me.btnPunchLine.Location = New System.Drawing.Point(304, 120)
        Me.btnPunchLine.Name = "btnPunchLine"
        Me.btnPunchLine.Size = New System.Drawing.Size(103, 60)
        Me.btnPunchLine.TabIndex = 1
        Me.btnPunchLine.Text = "Punch Line"
        Me.btnPunchLine.UseVisualStyleBackColor = True
        '
        'lblJoke
        '
        Me.lblJoke.AutoSize = True
        Me.lblJoke.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoke.Location = New System.Drawing.Point(12, 29)
        Me.lblJoke.Name = "lblJoke"
        Me.lblJoke.Size = New System.Drawing.Size(492, 19)
        Me.lblJoke.TabIndex = 2
        Me.lblJoke.Text = "How many programmers does it take to change a lightbulb?"
        Me.lblJoke.Visible = False
        '
        'lblPunchLine
        '
        Me.lblPunchLine.AutoSize = True
        Me.lblPunchLine.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPunchLine.Location = New System.Drawing.Point(108, 68)
        Me.lblPunchLine.Name = "lblPunchLine"
        Me.lblPunchLine.Size = New System.Drawing.Size(299, 19)
        Me.lblPunchLine.TabIndex = 3
        Me.lblPunchLine.Text = "None. Thats a hardware probelm. ;)"
        Me.lblPunchLine.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 212)
        Me.Controls.Add(Me.lblPunchLine)
        Me.Controls.Add(Me.lblJoke)
        Me.Controls.Add(Me.btnPunchLine)
        Me.Controls.Add(Me.btnSetUp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSetUp As System.Windows.Forms.Button
    Friend WithEvents btnPunchLine As System.Windows.Forms.Button
    Friend WithEvents lblJoke As System.Windows.Forms.Label
    Friend WithEvents lblPunchLine As System.Windows.Forms.Label

End Class
