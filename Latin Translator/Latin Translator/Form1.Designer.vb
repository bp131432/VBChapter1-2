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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSinister = New System.Windows.Forms.Button()
        Me.btnDexter = New System.Windows.Forms.Button()
        Me.btnMedium = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Translations from Latin to English"
        '
        'btnSinister
        '
        Me.btnSinister.Location = New System.Drawing.Point(12, 128)
        Me.btnSinister.Name = "btnSinister"
        Me.btnSinister.Size = New System.Drawing.Size(75, 23)
        Me.btnSinister.TabIndex = 1
        Me.btnSinister.Text = "Sinister"
        Me.btnSinister.UseVisualStyleBackColor = True
        '
        'btnDexter
        '
        Me.btnDexter.Location = New System.Drawing.Point(126, 128)
        Me.btnDexter.Name = "btnDexter"
        Me.btnDexter.Size = New System.Drawing.Size(75, 23)
        Me.btnDexter.TabIndex = 2
        Me.btnDexter.Text = "Dexter"
        Me.btnDexter.UseVisualStyleBackColor = True
        '
        'btnMedium
        '
        Me.btnMedium.Location = New System.Drawing.Point(239, 128)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(75, 23)
        Me.btnMedium.TabIndex = 3
        Me.btnMedium.Text = "Medium"
        Me.btnMedium.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(126, 202)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMedium)
        Me.Controls.Add(Me.btnDexter)
        Me.Controls.Add(Me.btnSinister)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Latin Translator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSinister As System.Windows.Forms.Button
    Friend WithEvents btnDexter As System.Windows.Forms.Button
    Friend WithEvents btnMedium As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
