<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadForm
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
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.LblPrgrss = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(96, 77)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 42)
        Me.ProgressBar1.Maximum = 250
        Me.ProgressBar1.MaximumSize = New System.Drawing.Size(250, 20)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(250, 20)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 2
        '
        'LblPrgrss
        '
        Me.LblPrgrss.AutoSize = True
        Me.LblPrgrss.Location = New System.Drawing.Point(13, 13)
        Me.LblPrgrss.Name = "LblPrgrss"
        Me.LblPrgrss.Size = New System.Drawing.Size(52, 13)
        Me.LblPrgrss.TabIndex = 3
        Me.LblPrgrss.Text = "Scanning"
        '
        'LoadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(272, 115)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblPrgrss)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Name = "LoadForm"
        Me.Text = "Please Wait..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LblPrgrss As System.Windows.Forms.Label

End Class
