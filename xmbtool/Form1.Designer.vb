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
        Me.WavetoolButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VisutoolButton = New System.Windows.Forms.Button()
        Me.ColdtoolButton = New System.Windows.Forms.Button()
        Me.BoottoolButton = New System.Windows.Forms.Button()
        Me.FonttoolButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WavetoolButton
        '
        Me.WavetoolButton.Location = New System.Drawing.Point(13, 13)
        Me.WavetoolButton.Name = "WavetoolButton"
        Me.WavetoolButton.Size = New System.Drawing.Size(414, 23)
        Me.WavetoolButton.TabIndex = 0
        Me.WavetoolButton.Text = "Wavetool"
        Me.WavetoolButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Created by cxnnie09. gvalue-04 on Github. All of the tools here require webman MO" &
    "D."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(357, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Wavetool is your suite for backing up your wave, and installing a new one."
        '
        'VisutoolButton
        '
        Me.VisutoolButton.Location = New System.Drawing.Point(13, 55)
        Me.VisutoolButton.Name = "VisutoolButton"
        Me.VisutoolButton.Size = New System.Drawing.Size(414, 23)
        Me.VisutoolButton.TabIndex = 3
        Me.VisutoolButton.Text = "???"
        Me.VisutoolButton.UseVisualStyleBackColor = True
        '
        'ColdtoolButton
        '
        Me.ColdtoolButton.Location = New System.Drawing.Point(13, 84)
        Me.ColdtoolButton.Name = "ColdtoolButton"
        Me.ColdtoolButton.Size = New System.Drawing.Size(414, 23)
        Me.ColdtoolButton.TabIndex = 4
        Me.ColdtoolButton.Text = "???"
        Me.ColdtoolButton.UseVisualStyleBackColor = True
        '
        'BoottoolButton
        '
        Me.BoottoolButton.Location = New System.Drawing.Point(13, 113)
        Me.BoottoolButton.Name = "BoottoolButton"
        Me.BoottoolButton.Size = New System.Drawing.Size(414, 23)
        Me.BoottoolButton.TabIndex = 5
        Me.BoottoolButton.Text = "???"
        Me.BoottoolButton.UseVisualStyleBackColor = True
        '
        'FonttoolButton
        '
        Me.FonttoolButton.Location = New System.Drawing.Point(13, 142)
        Me.FonttoolButton.Name = "FonttoolButton"
        Me.FonttoolButton.Size = New System.Drawing.Size(414, 23)
        Me.FonttoolButton.TabIndex = 6
        Me.FonttoolButton.Text = "???"
        Me.FonttoolButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 205)
        Me.Controls.Add(Me.FonttoolButton)
        Me.Controls.Add(Me.BoottoolButton)
        Me.Controls.Add(Me.ColdtoolButton)
        Me.Controls.Add(Me.VisutoolButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WavetoolButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "XMBTool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WavetoolButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents VisutoolButton As Button
    Friend WithEvents ColdtoolButton As Button
    Friend WithEvents BoottoolButton As Button
    Friend WithEvents FonttoolButton As Button
End Class
