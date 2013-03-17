<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcheck
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcheck))
		Me.msMain = New System.Windows.Forms.MenuStrip()
		Me.任务TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.另存为AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
		Me.帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
		Me.关于AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.字幕SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsMain = New System.Windows.Forms.ToolStrip()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
		Me.cbVers = New System.Windows.Forms.ToolStripComboBox()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ssMain = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.sc = New System.Windows.Forms.SplitContainer()
		Me.te = New DST.SrtEditor.TranslateEditor()
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ofdStcx = New System.Windows.Forms.OpenFileDialog()
		Me.sfd = New System.Windows.Forms.SaveFileDialog()
		Me.sfdSrt = New System.Windows.Forms.SaveFileDialog()
		Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
		Me.打开OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.返回XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.如何使用HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.迪幻网DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.导出XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
		Me.msMain.SuspendLayout()
		Me.tsMain.SuspendLayout()
		Me.ssMain.SuspendLayout()
		CType(Me.sc, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.sc.Panel1.SuspendLayout()
		Me.sc.Panel2.SuspendLayout()
		Me.sc.SuspendLayout()
		Me.SuspendLayout()
		'
		'msMain
		'
		Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.任务TToolStripMenuItem, Me.帮助HToolStripMenuItem, Me.字幕SToolStripMenuItem})
		Me.msMain.Location = New System.Drawing.Point(0, 0)
		Me.msMain.Name = "msMain"
		Me.msMain.Size = New System.Drawing.Size(860, 25)
		Me.msMain.TabIndex = 0
		Me.msMain.Text = "MenuStrip1"
		'
		'任务TToolStripMenuItem
		'
		Me.任务TToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开OToolStripMenuItem, Me.保存SToolStripMenuItem, Me.另存为AToolStripMenuItem, Me.ToolStripMenuItem3, Me.返回XToolStripMenuItem})
		Me.任务TToolStripMenuItem.Name = "任务TToolStripMenuItem"
		Me.任务TToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
		Me.任务TToolStripMenuItem.Text = "任务(&T)"
		'
		'另存为AToolStripMenuItem
		'
		Me.另存为AToolStripMenuItem.Enabled = False
		Me.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem"
		Me.另存为AToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
					Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.另存为AToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
		Me.另存为AToolStripMenuItem.Text = "另存为(&A)..."
		'
		'ToolStripMenuItem3
		'
		Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
		Me.ToolStripMenuItem3.Size = New System.Drawing.Size(212, 6)
		'
		'帮助HToolStripMenuItem
		'
		Me.帮助HToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.帮助HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.如何使用HToolStripMenuItem, Me.ToolStripMenuItem4, Me.迪幻网DToolStripMenuItem, Me.关于AToolStripMenuItem})
		Me.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem"
		Me.帮助HToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
		Me.帮助HToolStripMenuItem.Text = "帮助(&H)"
		'
		'ToolStripMenuItem4
		'
		Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
		Me.ToolStripMenuItem4.Size = New System.Drawing.Size(159, 6)
		'
		'关于AToolStripMenuItem
		'
		Me.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem"
		Me.关于AToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
		Me.关于AToolStripMenuItem.Text = "关于(&A)..."
		'
		'字幕SToolStripMenuItem
		'
		Me.字幕SToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.导出XToolStripMenuItem})
		Me.字幕SToolStripMenuItem.Name = "字幕SToolStripMenuItem"
		Me.字幕SToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
		Me.字幕SToolStripMenuItem.Text = "字幕(&S)"
		'
		'tsMain
		'
		Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.cbVers, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6})
		Me.tsMain.Location = New System.Drawing.Point(0, 25)
		Me.tsMain.Name = "tsMain"
		Me.tsMain.Size = New System.Drawing.Size(860, 25)
		Me.tsMain.TabIndex = 1
		Me.tsMain.Text = "ToolStrip1"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(32, 22)
		Me.ToolStripLabel1.Text = "版本"
		'
		'cbVers
		'
		Me.cbVers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVers.Enabled = False
		Me.cbVers.Name = "cbVers"
		Me.cbVers.Size = New System.Drawing.Size(160, 25)
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
		'
		'ssMain
		'
		Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.ssMain.Location = New System.Drawing.Point(0, 485)
		Me.ssMain.Name = "ssMain"
		Me.ssMain.Size = New System.Drawing.Size(860, 22)
		Me.ssMain.TabIndex = 2
		Me.ssMain.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.ActiveLinkColor = System.Drawing.Color.Red
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(32, 17)
		Me.lblStatus.Text = "就绪"
		'
		'sc
		'
		Me.sc.Dock = System.Windows.Forms.DockStyle.Fill
		Me.sc.Enabled = False
		Me.sc.Location = New System.Drawing.Point(0, 50)
		Me.sc.Name = "sc"
		'
		'sc.Panel1
		'
		Me.sc.Panel1.Controls.Add(Me.te)
		'
		'sc.Panel2
		'
		Me.sc.Panel2.Controls.Add(Me.ListView1)
		Me.sc.Size = New System.Drawing.Size(860, 435)
		Me.sc.SplitterDistance = 286
		Me.sc.TabIndex = 3
		'
		'te
		'
		Me.te.Changed = False
		Me.te.Current = 0
		Me.te.Dock = System.Windows.Forms.DockStyle.Fill
		Me.te.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.te.Location = New System.Drawing.Point(0, 0)
		Me.te.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.te.Name = "te"
		Me.te.Size = New System.Drawing.Size(286, 435)
		Me.te.TabIndex = 0
		'
		'ListView1
		'
		Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
		Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
		Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ListView1.FullRowSelect = True
		Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.ListView1.HideSelection = False
		Me.ListView1.Location = New System.Drawing.Point(0, 0)
		Me.ListView1.MultiSelect = False
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Size = New System.Drawing.Size(570, 435)
		Me.ListView1.TabIndex = 0
		Me.ListView1.UseCompatibleStateImageBehavior = False
		Me.ListView1.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "原文"
		Me.ColumnHeader1.Width = 300
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "译文"
		Me.ColumnHeader2.Width = 300
		'
		'ofdStcx
		'
		Me.ofdStcx.Filter = "翻译任务文件 (*.stcx)|*.stcx|所有文件 (*.*)|*.*"
		'
		'sfd
		'
		Me.sfd.Filter = "翻译任务文件 (*.stcx)|*.stcx|所有文件 (*.*)|*.*"
		'
		'sfdSrt
		'
		Me.sfdSrt.Filter = "字幕文件 (*.srt)|*.srt|所有文件 (*.*)|*.*"
		'
		'ToolStripButton2
		'
		Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton2.Image = Global.DST.SrtChecker.My.Resources.Resources.openHS
		Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton2.Name = "ToolStripButton2"
		Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton2.Text = "ToolStripButton2"
		'
		'ToolStripButton3
		'
		Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton3.Enabled = False
		Me.ToolStripButton3.Image = Global.DST.SrtChecker.My.Resources.Resources.saveHS
		Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton3.Name = "ToolStripButton3"
		Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton3.Text = "ToolStripButton3"
		'
		'ToolStripButton5
		'
		Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton5.Image = Global.DST.SrtChecker.My.Resources.Resources.Help
		Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton5.Name = "ToolStripButton5"
		Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton5.Text = "ToolStripButton5"
		'
		'ToolStripButton6
		'
		Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton6.Image = Global.DST.SrtChecker.My.Resources.Resources._305_Close_16x16_72
		Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton6.Name = "ToolStripButton6"
		Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton6.Text = "ToolStripButton6"
		'
		'打开OToolStripMenuItem
		'
		Me.打开OToolStripMenuItem.Image = Global.DST.SrtChecker.My.Resources.Resources.openHS
		Me.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem"
		Me.打开OToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.打开OToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
		Me.打开OToolStripMenuItem.Text = "打开(&O)..."
		'
		'保存SToolStripMenuItem
		'
		Me.保存SToolStripMenuItem.Enabled = False
		Me.保存SToolStripMenuItem.Image = Global.DST.SrtChecker.My.Resources.Resources.saveHS
		Me.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem"
		Me.保存SToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.保存SToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
		Me.保存SToolStripMenuItem.Text = "保存(&S)"
		'
		'返回XToolStripMenuItem
		'
		Me.返回XToolStripMenuItem.Image = Global.DST.SrtChecker.My.Resources.Resources._305_Close_16x16_72
		Me.返回XToolStripMenuItem.Name = "返回XToolStripMenuItem"
		Me.返回XToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
		Me.返回XToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
		Me.返回XToolStripMenuItem.Text = "返回(&X)"
		'
		'如何使用HToolStripMenuItem
		'
		Me.如何使用HToolStripMenuItem.Image = Global.DST.SrtChecker.My.Resources.Resources.Help
		Me.如何使用HToolStripMenuItem.Name = "如何使用HToolStripMenuItem"
		Me.如何使用HToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
		Me.如何使用HToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
		Me.如何使用HToolStripMenuItem.Text = "如何使用(&H)"
		'
		'迪幻网DToolStripMenuItem
		'
		Me.迪幻网DToolStripMenuItem.Image = Global.DST.SrtChecker.My.Resources.Resources.Web
		Me.迪幻网DToolStripMenuItem.Name = "迪幻网DToolStripMenuItem"
		Me.迪幻网DToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
		Me.迪幻网DToolStripMenuItem.Text = "迪幻网(&D)"
		'
		'导出XToolStripMenuItem
		'
		Me.导出XToolStripMenuItem.Enabled = False
		Me.导出XToolStripMenuItem.Image = Global.DST.SrtChecker.My.Resources.Resources.EnvelopeHS
		Me.导出XToolStripMenuItem.Name = "导出XToolStripMenuItem"
		Me.导出XToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
		Me.导出XToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.导出XToolStripMenuItem.Text = "导出(&X)..."
		'
		'ToolStripButton1
		'
		Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton1.Enabled = False
		Me.ToolStripButton1.Image = Global.DST.SrtChecker.My.Resources.Resources.EnvelopeHS
		Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton1.Name = "ToolStripButton1"
		Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton1.Text = "ToolStripButton1"
		'
		'frmcheck
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(860, 507)
		Me.Controls.Add(Me.sc)
		Me.Controls.Add(Me.ssMain)
		Me.Controls.Add(Me.tsMain)
		Me.Controls.Add(Me.msMain)
		Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.msMain
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "frmcheck"
		Me.Text = "迪幻字幕工具 - 字幕校对"
		Me.msMain.ResumeLayout(False)
		Me.msMain.PerformLayout()
		Me.tsMain.ResumeLayout(False)
		Me.tsMain.PerformLayout()
		Me.ssMain.ResumeLayout(False)
		Me.ssMain.PerformLayout()
		Me.sc.Panel1.ResumeLayout(False)
		Me.sc.Panel2.ResumeLayout(False)
		CType(Me.sc, System.ComponentModel.ISupportInitialize).EndInit()
		Me.sc.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents msMain As System.Windows.Forms.MenuStrip
	Friend WithEvents 任务TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 打开OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 保存SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 另存为AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents 返回XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 帮助HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 如何使用HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents 迪幻网DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 关于AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
	Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
	Friend WithEvents ssMain As System.Windows.Forms.StatusStrip
	Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents sc As System.Windows.Forms.SplitContainer
	Friend WithEvents te As DST.SrtEditor.TranslateEditor
	Friend WithEvents ListView1 As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ofdStcx As System.Windows.Forms.OpenFileDialog
	Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
	Friend WithEvents 字幕SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents 导出XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents cbVers As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents sfdSrt As System.Windows.Forms.SaveFileDialog
	Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
