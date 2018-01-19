<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.chkSubFolders = New System.Windows.Forms.CheckBox
        Me.chkUseTextPathLarge = New System.Windows.Forms.CheckBox
        Me.chkUseTextPathSmall = New System.Windows.Forms.CheckBox
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.BtnGo = New System.Windows.Forms.Button
        Me.txtBrowse = New System.Windows.Forms.TextBox
        Me.Menu = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Worker1 = New System.ComponentModel.BackgroundWorker
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbSkipSize = New System.Windows.Forms.ComboBox
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkSubFolders
        '
        Me.chkSubFolders.AutoSize = True
        Me.chkSubFolders.Location = New System.Drawing.Point(12, 86)
        Me.chkSubFolders.Name = "chkSubFolders"
        Me.chkSubFolders.Size = New System.Drawing.Size(119, 17)
        Me.chkSubFolders.TabIndex = 0
        Me.chkSubFolders.Text = "Search Sub Folders"
        Me.chkSubFolders.UseVisualStyleBackColor = True
        '
        'chkUseTextPathLarge
        '
        Me.chkUseTextPathLarge.AutoSize = True
        Me.chkUseTextPathLarge.Location = New System.Drawing.Point(98, 12)
        Me.chkUseTextPathLarge.Name = "chkUseTextPathLarge"
        Me.chkUseTextPathLarge.Size = New System.Drawing.Size(53, 17)
        Me.chkUseTextPathLarge.TabIndex = 1
        Me.chkUseTextPathLarge.Text = "Large"
        Me.chkUseTextPathLarge.UseVisualStyleBackColor = True
        Me.chkUseTextPathLarge.Visible = False
        '
        'chkUseTextPathSmall
        '
        Me.chkUseTextPathSmall.AutoSize = True
        Me.chkUseTextPathSmall.Location = New System.Drawing.Point(98, 26)
        Me.chkUseTextPathSmall.Name = "chkUseTextPathSmall"
        Me.chkUseTextPathSmall.Size = New System.Drawing.Size(51, 17)
        Me.chkUseTextPathSmall.TabIndex = 2
        Me.chkUseTextPathSmall.Text = "Small"
        Me.chkUseTextPathSmall.UseVisualStyleBackColor = True
        Me.chkUseTextPathSmall.Visible = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(269, 46)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'BtnGo
        '
        Me.BtnGo.Location = New System.Drawing.Point(269, 100)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(75, 23)
        Me.BtnGo.TabIndex = 4
        Me.BtnGo.Text = "Go"
        Me.BtnGo.UseVisualStyleBackColor = True
        '
        'txtBrowse
        '
        Me.txtBrowse.Location = New System.Drawing.Point(12, 48)
        Me.txtBrowse.Name = "txtBrowse"
        Me.txtBrowse.Size = New System.Drawing.Size(238, 20)
        Me.txtBrowse.TabIndex = 5
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.Transparent
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Menu.Size = New System.Drawing.Size(362, 24)
        Me.Menu.TabIndex = 6
        Me.Menu.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem1.Text = "&Menu"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'LoadTimer
        '
        Me.LoadTimer.Interval = 500
        '
        'Worker1
        '
        Me.Worker1.WorkerReportsProgress = True
        Me.Worker1.WorkerSupportsCancellation = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Skip Files Less than:"
        '
        'CmbSkipSize
        '
        Me.CmbSkipSize.FormattingEnabled = True
        Me.CmbSkipSize.Items.AddRange(New Object() {"Skip None", "1 KB", "10 KB", "50 KB", "100 KB", "1 MB", "7 MB", "15 MB", "30 MB", "62 MB", "125 MB", "250 MB", "500 MB", "1 GB", "2 GB"})
        Me.CmbSkipSize.Location = New System.Drawing.Point(144, 102)
        Me.CmbSkipSize.Name = "CmbSkipSize"
        Me.CmbSkipSize.Size = New System.Drawing.Size(106, 21)
        Me.CmbSkipSize.TabIndex = 9
        Me.CmbSkipSize.Text = "Skip None"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(362, 143)
        Me.Controls.Add(Me.CmbSkipSize)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBrowse)
        Me.Controls.Add(Me.BtnGo)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.chkUseTextPathSmall)
        Me.Controls.Add(Me.chkUseTextPathLarge)
        Me.Controls.Add(Me.chkSubFolders)
        Me.Controls.Add(Me.Menu)
        Me.MainMenuStrip = Me.Menu
        Me.Name = "Main"
        Me.Text = "Space Reader"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chkSubFolders As System.Windows.Forms.CheckBox
    Friend WithEvents chkUseTextPathLarge As System.Windows.Forms.CheckBox
    Friend WithEvents chkUseTextPathSmall As System.Windows.Forms.CheckBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents BtnGo As System.Windows.Forms.Button
    Friend WithEvents txtBrowse As System.Windows.Forms.TextBox
    Shadows WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadTimer As System.Windows.Forms.Timer
    Friend WithEvents Worker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbSkipSize As System.Windows.Forms.ComboBox

End Class
