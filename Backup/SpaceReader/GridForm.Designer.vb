<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridForm
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
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblEndTime = New System.Windows.Forms.Label
        Me.lblTotalSize = New System.Windows.Forms.Label
        Me.lblEndTimeVal = New System.Windows.Forms.Label
        Me.lblINFO = New System.Windows.Forms.Label
        Me.lblTotalSizeVal = New System.Windows.Forms.Label
        Me.lblFileCountVal = New System.Windows.Forms.Label
        Me.lblStartTime = New System.Windows.Forms.Label
        Me.lblStartTimeVal = New System.Windows.Forms.Label
        Me.lblFileCount = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnHelp = New System.Windows.Forms.Button
        Me.Process1 = New System.Diagnostics.Process
        Me.btnSave = New System.Windows.Forms.Button
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowUserToOrderColumns = True
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Grid.Location = New System.Drawing.Point(12, 64)
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeadersVisible = False
        Me.Grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.Size = New System.Drawing.Size(624, 482)
        Me.Grid.TabIndex = 18
        Me.Grid.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEndTime)
        Me.GroupBox1.Controls.Add(Me.lblTotalSize)
        Me.GroupBox1.Controls.Add(Me.lblEndTimeVal)
        Me.GroupBox1.Controls.Add(Me.lblINFO)
        Me.GroupBox1.Controls.Add(Me.lblTotalSizeVal)
        Me.GroupBox1.Controls.Add(Me.lblFileCountVal)
        Me.GroupBox1.Controls.Add(Me.lblStartTime)
        Me.GroupBox1.Controls.Add(Me.lblStartTimeVal)
        Me.GroupBox1.Controls.Add(Me.lblFileCount)
        Me.GroupBox1.Location = New System.Drawing.Point(12, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 53)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(368, 32)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(55, 13)
        Me.lblEndTime.TabIndex = 22
        Me.lblEndTime.Text = "End Time:"
        '
        'lblTotalSize
        '
        Me.lblTotalSize.AutoSize = True
        Me.lblTotalSize.Location = New System.Drawing.Point(15, 15)
        Me.lblTotalSize.Name = "lblTotalSize"
        Me.lblTotalSize.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalSize.TabIndex = 18
        Me.lblTotalSize.Text = "Total Size:"
        '
        'lblEndTimeVal
        '
        Me.lblEndTimeVal.AutoSize = True
        Me.lblEndTimeVal.Location = New System.Drawing.Point(432, 32)
        Me.lblEndTimeVal.Name = "lblEndTimeVal"
        Me.lblEndTimeVal.Size = New System.Drawing.Size(16, 13)
        Me.lblEndTimeVal.TabIndex = 23
        Me.lblEndTimeVal.Text = "..."
        '
        'lblINFO
        '
        Me.lblINFO.AutoSize = True
        Me.lblINFO.Location = New System.Drawing.Point(196, 15)
        Me.lblINFO.Name = "lblINFO"
        Me.lblINFO.Size = New System.Drawing.Size(94, 13)
        Me.lblINFO.TabIndex = 28
        Me.lblINFO.Text = "Selected File Size:"
        '
        'lblTotalSizeVal
        '
        Me.lblTotalSizeVal.AutoSize = True
        Me.lblTotalSizeVal.Location = New System.Drawing.Point(104, 15)
        Me.lblTotalSizeVal.Name = "lblTotalSizeVal"
        Me.lblTotalSizeVal.Size = New System.Drawing.Size(16, 13)
        Me.lblTotalSizeVal.TabIndex = 19
        Me.lblTotalSizeVal.Text = "..."
        '
        'lblFileCountVal
        '
        Me.lblFileCountVal.AutoSize = True
        Me.lblFileCountVal.Location = New System.Drawing.Point(104, 32)
        Me.lblFileCountVal.Name = "lblFileCountVal"
        Me.lblFileCountVal.Size = New System.Drawing.Size(16, 13)
        Me.lblFileCountVal.TabIndex = 25
        Me.lblFileCountVal.Text = "..."
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(368, 15)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(58, 13)
        Me.lblStartTime.TabIndex = 20
        Me.lblStartTime.Text = "Start Time:"
        '
        'lblStartTimeVal
        '
        Me.lblStartTimeVal.AutoSize = True
        Me.lblStartTimeVal.Location = New System.Drawing.Point(432, 15)
        Me.lblStartTimeVal.Name = "lblStartTimeVal"
        Me.lblStartTimeVal.Size = New System.Drawing.Size(16, 13)
        Me.lblStartTimeVal.TabIndex = 21
        Me.lblStartTimeVal.Text = "..."
        '
        'lblFileCount
        '
        Me.lblFileCount.AutoSize = True
        Me.lblFileCount.Location = New System.Drawing.Point(15, 32)
        Me.lblFileCount.Name = "lblFileCount"
        Me.lblFileCount.Size = New System.Drawing.Size(83, 13)
        Me.lblFileCount.TabIndex = 24
        Me.lblFileCount.Text = "Number of Files:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(534, 552)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(383, 552)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(24, 23)
        Me.btnHelp.TabIndex = 30
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(430, 552)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 23)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "&Save as .CSV"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GridForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(648, 583)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GridForm"
        Me.Text = "Space Reader Results"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEndTime As System.Windows.Forms.Label
    Friend WithEvents lblTotalSize As System.Windows.Forms.Label
    Friend WithEvents lblEndTimeVal As System.Windows.Forms.Label
    Friend WithEvents lblTotalSizeVal As System.Windows.Forms.Label
    Friend WithEvents lblFileCountVal As System.Windows.Forms.Label
    Friend WithEvents lblStartTime As System.Windows.Forms.Label
    Friend WithEvents lblStartTimeVal As System.Windows.Forms.Label
    Friend WithEvents lblFileCount As System.Windows.Forms.Label
    Friend WithEvents lblINFO As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
