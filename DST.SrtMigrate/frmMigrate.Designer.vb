<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMigrate
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMigrate))
		Me.tscMigrate = New System.Windows.Forms.ToolStripContainer()
		Me.ssMain = New System.Windows.Forms.StatusStrip()
		Me.pgbMain = New System.Windows.Forms.ToolStripProgressBar()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lsFiles = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.msMain = New System.Windows.Forms.MenuStrip()
		Me.字幕SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.设置保存目标SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.开始合并MToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
		Me.返回XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.分卷PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.导入分卷IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.移除分卷RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.如何使用HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
		Me.迪幻网DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.关于AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsMain = New System.Windows.Forms.ToolStrip()
		Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
		Me.tsOutput = New System.Windows.Forms.ToolStrip()
		Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
		Me.txtDestination = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
		Me.sfd = New System.Windows.Forms.SaveFileDialog()
		Me.ofd = New System.Windows.Forms.OpenFileDialog()
		Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.tscMigrate.BottomToolStripPanel.SuspendLayout()
		Me.tscMigrate.ContentPanel.SuspendLayout()
		Me.tscMigrate.TopToolStripPanel.SuspendLayout()
		Me.tscMigrate.SuspendLayout()
		Me.ssMain.SuspendLayout()
		Me.msMain.SuspendLayout()
		Me.tsMain.SuspendLayout()
		Me.tsOutput.SuspendLayout()
		Me.SuspendLayout()
		'
		'tscMigrate
		'
		'
		'tscMigrate.BottomToolStripPanel
		'
		Me.tscMigrate.BottomToolStripPanel.Controls.Add(Me.ssMain)
		'
		'tscMigrate.ContentPanel
		'
		Me.tscMigrate.ContentPanel.Controls.Add(Me.lsFiles)
		Me.tscMigrate.ContentPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.tscMigrate.ContentPanel.Size = New System.Drawing.Size(845, 430)
		Me.tscMigrate.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tscMigrate.Location = New System.Drawing.Point(0, 0)
		Me.tscMigrate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.tscMigrate.Name = "tscMigrate"
		Me.tscMigrate.Size = New System.Drawing.Size(845, 527)
		Me.tscMigrate.TabIndex = 0
		Me.tscMigrate.Text = "ToolStripContainer1"
		'
		'tscMigrate.TopToolStripPanel
		'
		Me.tscMigrate.TopToolStripPanel.Controls.Add(Me.msMain)
		Me.tscMigrate.TopToolStripPanel.Controls.Add(Me.tsMain)
		Me.tscMigrate.TopToolStripPanel.Controls.Add(Me.tsOutput)
		'
		'ssMain
		'
		Me.ssMain.Dock = System.Windows.Forms.DockStyle.None
		Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pgbMain, Me.lblStatus})
		Me.ssMain.Location = New System.Drawing.Point(0, 0)
		Me.ssMain.Name = "ssMain"
		Me.ssMain.Size = New System.Drawing.Size(845, 22)
		Me.ssMain.TabIndex = 0
		'
		'pgbMain
		'
		Me.pgbMain.Name = "pgbMain"
		Me.pgbMain.Size = New System.Drawing.Size(100, 16)
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(32, 17)
		Me.lblStatus.Text = "就绪"
		'
		'lsFiles
		'
		Me.lsFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
		Me.lsFiles.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lsFiles.Location = New System.Drawing.Point(0, 0)
		Me.lsFiles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.lsFiles.Name = "lsFiles"
		Me.lsFiles.Size = New System.Drawing.Size(845, 430)
		Me.lsFiles.TabIndex = 0
		Me.lsFiles.UseCompatibleStateImageBehavior = False
		Me.lsFiles.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "文件名"
		Me.ColumnHeader1.Width = 300
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "开始时间"
		Me.ColumnHeader2.Width = 120
		'
		'ColumnHeader3
		'
		Me.ColumnHeader3.Text = "结束时间"
		Me.ColumnHeader3.Width = 120
		'
		'ColumnHeader4
		'
		Me.ColumnHeader4.Text = "行数"
		'
		'msMain
		'
		Me.msMain.Dock = System.Windows.Forms.DockStyle.None
		Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.字幕SToolStripMenuItem, Me.分卷PToolStripMenuItem, Me.帮助HToolStripMenuItem})
		Me.msMain.Location = New System.Drawing.Point(0, 0)
		Me.msMain.Name = "msMain"
		Me.msMain.Size = New System.Drawing.Size(845, 25)
		Me.msMain.TabIndex = 0
		Me.msMain.Text = "MenuStrip1"
		'
		'字幕SToolStripMenuItem
		'
		Me.字幕SToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.设置保存目标SToolStripMenuItem, Me.开始合并MToolStripMenuItem, Me.ToolStripMenuItem1, Me.返回XToolStripMenuItem})
		Me.字幕SToolStripMenuItem.Name = "字幕SToolStripMenuItem"
		Me.字幕SToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
		Me.字幕SToolStripMenuItem.Text = "字幕(&S)"
		'
		'设置保存目标SToolStripMenuItem
		'
		Me.设置保存目标SToolStripMenuItem.Image = Global.DST.SrtMigrate.My.Resources.Resources.saveHS
		Me.设置保存目标SToolStripMenuItem.Name = "设置保存目标SToolStripMenuItem"
		Me.设置保存目标SToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.设置保存目标SToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
		Me.设置保存目标SToolStripMenuItem.Text = "设置保存目标(&S)..."
		'
		'开始合并MToolStripMenuItem
		'
		Me.开始合并MToolStripMenuItem.Enabled = False
		Me.开始合并MToolStripMenuItem.Image = Global.DST.SrtMigrate.My.Resources.Resources.PlayHS
		Me.开始合并MToolStripMenuItem.Name = "开始合并MToolStripMenuItem"
		Me.开始合并MToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
		Me.开始合并MToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
		Me.开始合并MToolStripMenuItem.Text = "开始合并(&M)"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(213, 6)
		'
		'返回XToolStripMenuItem
		'
		Me.返回XToolStripMenuItem.Image = Global.DST.SrtMigrate.My.Resources.Resources._305_Close_16x16_72
		Me.返回XToolStripMenuItem.Name = "返回XToolStripMenuItem"
		Me.返回XToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
		Me.返回XToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
		Me.返回XToolStripMenuItem.Text = "返回(&X)"
		'
		'分卷PToolStripMenuItem
		'
		Me.分卷PToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.导入分卷IToolStripMenuItem, Me.移除分卷RToolStripMenuItem})
		Me.分卷PToolStripMenuItem.Name = "分卷PToolStripMenuItem"
		Me.分卷PToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
		Me.分卷PToolStripMenuItem.Text = "分卷(&P)"
		'
		'导入分卷IToolStripMenuItem
		'
		Me.导入分卷IToolStripMenuItem.Image = Global.DST.SrtMigrate.My.Resources.Resources._077_AddFile_16x16_72
		Me.导入分卷IToolStripMenuItem.Name = "导入分卷IToolStripMenuItem"
		Me.导入分卷IToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.导入分卷IToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
		Me.导入分卷IToolStripMenuItem.Text = "导入分卷(&I)..."
		'
		'移除分卷RToolStripMenuItem
		'
		Me.移除分卷RToolStripMenuItem.Enabled = False
		Me.移除分卷RToolStripMenuItem.Image = Global.DST.SrtMigrate.My.Resources.Resources.DeleteHS
		Me.移除分卷RToolStripMenuItem.Name = "移除分卷RToolStripMenuItem"
		Me.移除分卷RToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
		Me.移除分卷RToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
		Me.移除分卷RToolStripMenuItem.Text = "移除分卷(&R)"
		'
		'帮助HToolStripMenuItem
		'
		Me.帮助HToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.帮助HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.如何使用HToolStripMenuItem, Me.ToolStripMenuItem3, Me.迪幻网DToolStripMenuItem, Me.关于AToolStripMenuItem})
		Me.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem"
		Me.帮助HToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
		Me.帮助HToolStripMenuItem.Text = "帮助(&H)"
		'
		'如何使用HToolStripMenuItem
		'
		Me.如何使用HToolStripMenuItem.Image = Global.DST.SrtMigrate.My.Resources.Resources.Help
		Me.如何使用HToolStripMenuItem.Name = "如何使用HToolStripMenuItem"
		Me.如何使用HToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
		Me.如何使用HToolStripMenuItem.Text = "如何使用(&H)"
		'
		'ToolStripMenuItem3
		'
		Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
		Me.ToolStripMenuItem3.Size = New System.Drawing.Size(138, 6)
		'
		'迪幻网DToolStripMenuItem
		'
		Me.迪幻网DToolStripMenuItem.Image = Global.DST.SrtMigrate.My.Resources.Resources.Web
		Me.迪幻网DToolStripMenuItem.Name = "迪幻网DToolStripMenuItem"
		Me.迪幻网DToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
		Me.迪幻网DToolStripMenuItem.Text = "迪幻网(&D)"
		'
		'关于AToolStripMenuItem
		'
		Me.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem"
		Me.关于AToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
		Me.关于AToolStripMenuItem.Text = "关于(&A)..."
		'
		'tsMain
		'
		Me.tsMain.Dock = System.Windows.Forms.DockStyle.None
		Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton4, Me.ToolStripSeparator2, Me.ToolStripButton6, Me.ToolStripButton5})
		Me.tsMain.Location = New System.Drawing.Point(3, 25)
		Me.tsMain.Name = "tsMain"
		Me.tsMain.Size = New System.Drawing.Size(245, 25)
		Me.tsMain.TabIndex = 1
		'
		'ToolStripButton2
		'
		Me.ToolStripButton2.Image = Global.DST.SrtMigrate.My.Resources.Resources._077_AddFile_16x16_72
		Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton2.Name = "ToolStripButton2"
		Me.ToolStripButton2.Size = New System.Drawing.Size(76, 22)
		Me.ToolStripButton2.Text = "导入分卷"
		'
		'ToolStripButton3
		'
		Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton3.Enabled = False
		Me.ToolStripButton3.Image = Global.DST.SrtMigrate.My.Resources.Resources.DeleteHS
		Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton3.Name = "ToolStripButton3"
		Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton3.Text = "移除分卷"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'ToolStripButton4
		'
		Me.ToolStripButton4.Enabled = False
		Me.ToolStripButton4.Image = Global.DST.SrtMigrate.My.Resources.Resources.PlayHS
		Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton4.Name = "ToolStripButton4"
		Me.ToolStripButton4.Size = New System.Drawing.Size(76, 22)
		Me.ToolStripButton4.Text = "开始合并"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
		'
		'ToolStripButton6
		'
		Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton6.Image = Global.DST.SrtMigrate.My.Resources.Resources.Help
		Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton6.Name = "ToolStripButton6"
		Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton6.Text = "帮助"
		'
		'ToolStripButton5
		'
		Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton5.Image = Global.DST.SrtMigrate.My.Resources.Resources._305_Close_16x16_72
		Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton5.Name = "ToolStripButton5"
		Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton5.Text = "返回"
		'
		'tsOutput
		'
		Me.tsOutput.Dock = System.Windows.Forms.DockStyle.None
		Me.tsOutput.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtDestination, Me.ToolStripButton1})
		Me.tsOutput.Location = New System.Drawing.Point(3, 50)
		Me.tsOutput.Name = "tsOutput"
		Me.tsOutput.Size = New System.Drawing.Size(273, 25)
		Me.tsOutput.TabIndex = 2
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(56, 22)
		Me.ToolStripLabel1.Text = "目标文件"
		'
		'txtDestination
		'
		Me.txtDestination.Name = "txtDestination"
		Me.txtDestination.ReadOnly = True
		Me.txtDestination.Size = New System.Drawing.Size(180, 25)
		'
		'ToolStripButton1
		'
		Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton1.Image = Global.DST.SrtMigrate.My.Resources.Resources.saveHS
		Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton1.Name = "ToolStripButton1"
		Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton1.Text = "设置保存目标"
		'
		'sfd
		'
		Me.sfd.Filter = "字幕文件 (*.srt)|*.srt|所有文件 (*.*)|*.*"
		'
		'ofd
		'
		Me.ofd.Filter = "字幕文件 (*.srt)|*.srt|所有文件 (*.*)|*.*"
		Me.ofd.Multiselect = True
		'
		'ColumnHeader5
		'
		Me.ColumnHeader5.Text = "状态"
		'
		'frmMigrate
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(845, 527)
		Me.Controls.Add(Me.tscMigrate)
		Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.msMain
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "frmMigrate"
		Me.Text = "迪幻字幕工具 - 字幕合并"
		Me.tscMigrate.BottomToolStripPanel.ResumeLayout(False)
		Me.tscMigrate.BottomToolStripPanel.PerformLayout()
		Me.tscMigrate.ContentPanel.ResumeLayout(False)
		Me.tscMigrate.TopToolStripPanel.ResumeLayout(False)
		Me.tscMigrate.TopToolStripPanel.PerformLayout()
		Me.tscMigrate.ResumeLayout(False)
		Me.tscMigrate.PerformLayout()
		Me.ssMain.ResumeLayout(False)
		Me.ssMain.PerformLayout()
		Me.msMain.ResumeLayout(False)
		Me.msMain.PerformLayout()
		Me.tsMain.ResumeLayout(False)
		Me.tsMain.PerformLayout()
		Me.tsOutput.ResumeLayout(False)
		Me.tsOutput.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents tscMigrate As System.Windows.Forms.ToolStripContainer
	Friend WithEvents ssMain As System.Windows.Forms.StatusStrip
	Friend WithEvents lsFiles As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
	Friend WithEvents msMain As System.Windows.Forms.MenuStrip
	Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
	Friend WithEvents tsOutput As System.Windows.Forms.ToolStrip
	Friend WithEvents 字幕SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 设置保存目标SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 开始合并MToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents 返回XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 分卷PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 导入分卷IToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 移除分卷RToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 帮助HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 如何使用HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents 迪幻网DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 关于AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents txtDestination As System.Windows.Forms.ToolStripTextBox
	Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
	Friend WithEvents pgbMain As System.Windows.Forms.ToolStripProgressBar
	Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
	Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
	Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
	Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class
