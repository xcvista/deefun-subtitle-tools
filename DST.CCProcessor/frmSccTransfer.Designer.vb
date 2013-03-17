<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccTransfer
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccTransfer))
		Me.msMain = New System.Windows.Forms.MenuStrip()
		Me.文件FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.导入IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.删除DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
		Me.转换CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
		Me.返回BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.如何使用HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
		Me.迪幻网DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.关于AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsMain = New System.Windows.Forms.ToolStrip()
		Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lsFiles = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ofdFiles = New System.Windows.Forms.OpenFileDialog()
		Me.msMain.SuspendLayout()
		Me.tsMain.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'msMain
		'
		Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件FToolStripMenuItem, Me.帮助HToolStripMenuItem})
		Me.msMain.Location = New System.Drawing.Point(0, 0)
		Me.msMain.Name = "msMain"
		Me.msMain.Size = New System.Drawing.Size(1008, 25)
		Me.msMain.TabIndex = 0
		Me.msMain.Text = "MenuStrip1"
		'
		'文件FToolStripMenuItem
		'
		Me.文件FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.导入IToolStripMenuItem, Me.删除DToolStripMenuItem, Me.ToolStripMenuItem1, Me.转换CToolStripMenuItem, Me.ToolStripMenuItem2, Me.返回BToolStripMenuItem})
		Me.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem"
		Me.文件FToolStripMenuItem.Size = New System.Drawing.Size(58, 21)
		Me.文件FToolStripMenuItem.Text = "文件(&F)"
		'
		'导入IToolStripMenuItem
		'
		Me.导入IToolStripMenuItem.Image = Global.DST.CCProcessor.My.Resources.Resources.openHS
		Me.导入IToolStripMenuItem.Name = "导入IToolStripMenuItem"
		Me.导入IToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.导入IToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
		Me.导入IToolStripMenuItem.Text = "导入(&I)..."
		'
		'删除DToolStripMenuItem
		'
		Me.删除DToolStripMenuItem.Enabled = False
		Me.删除DToolStripMenuItem.Image = Global.DST.CCProcessor.My.Resources.Resources.DeleteHS
		Me.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem"
		Me.删除DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
		Me.删除DToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
		Me.删除DToolStripMenuItem.Text = "删除(&D)"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(165, 6)
		'
		'转换CToolStripMenuItem
		'
		Me.转换CToolStripMenuItem.Image = Global.DST.CCProcessor.My.Resources.Resources.FormRunHS
		Me.转换CToolStripMenuItem.Name = "转换CToolStripMenuItem"
		Me.转换CToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
		Me.转换CToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
		Me.转换CToolStripMenuItem.Text = "转换(&C)"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(165, 6)
		'
		'返回BToolStripMenuItem
		'
		Me.返回BToolStripMenuItem.Image = Global.DST.CCProcessor.My.Resources.Resources._305_Close_16x16_72
		Me.返回BToolStripMenuItem.Name = "返回BToolStripMenuItem"
		Me.返回BToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
		Me.返回BToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
		Me.返回BToolStripMenuItem.Text = "返回(&B)"
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
		Me.如何使用HToolStripMenuItem.Image = Global.DST.CCProcessor.My.Resources.Resources.Help
		Me.如何使用HToolStripMenuItem.Name = "如何使用HToolStripMenuItem"
		Me.如何使用HToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
		Me.如何使用HToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
		Me.如何使用HToolStripMenuItem.Text = "如何使用(&H)"
		'
		'ToolStripMenuItem3
		'
		Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
		Me.ToolStripMenuItem3.Size = New System.Drawing.Size(167, 6)
		'
		'迪幻网DToolStripMenuItem
		'
		Me.迪幻网DToolStripMenuItem.Image = Global.DST.CCProcessor.My.Resources.Resources.Web
		Me.迪幻网DToolStripMenuItem.Name = "迪幻网DToolStripMenuItem"
		Me.迪幻网DToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
		Me.迪幻网DToolStripMenuItem.Text = "迪幻网(&D)"
		'
		'关于AToolStripMenuItem
		'
		Me.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem"
		Me.关于AToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
		Me.关于AToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
		Me.关于AToolStripMenuItem.Text = "关于(&A)..."
		'
		'tsMain
		'
		Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton4})
		Me.tsMain.Location = New System.Drawing.Point(0, 25)
		Me.tsMain.Name = "tsMain"
		Me.tsMain.Size = New System.Drawing.Size(1008, 25)
		Me.tsMain.TabIndex = 1
		Me.tsMain.Text = "ToolStrip1"
		'
		'ToolStripButton1
		'
		Me.ToolStripButton1.Image = Global.DST.CCProcessor.My.Resources.Resources.openHS
		Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton1.Name = "ToolStripButton1"
		Me.ToolStripButton1.Size = New System.Drawing.Size(52, 22)
		Me.ToolStripButton1.Text = "打开"
		'
		'ToolStripButton2
		'
		Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton2.Enabled = False
		Me.ToolStripButton2.Image = Global.DST.CCProcessor.My.Resources.Resources.DeleteHS
		Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton2.Name = "ToolStripButton2"
		Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton2.Text = "删除"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'ToolStripButton3
		'
		Me.ToolStripButton3.Image = Global.DST.CCProcessor.My.Resources.Resources.FormRunHS
		Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton3.Name = "ToolStripButton3"
		Me.ToolStripButton3.Size = New System.Drawing.Size(76, 22)
		Me.ToolStripButton3.Text = "开始转换"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
		'
		'ToolStripButton5
		'
		Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton5.Image = Global.DST.CCProcessor.My.Resources.Resources.Help
		Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton5.Name = "ToolStripButton5"
		Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton5.Text = "如何使用"
		'
		'ToolStripButton4
		'
		Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton4.Image = Global.DST.CCProcessor.My.Resources.Resources._305_Close_16x16_72
		Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton4.Name = "ToolStripButton4"
		Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton4.Text = "返回"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 516)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(1008, 22)
		Me.StatusStrip1.TabIndex = 2
		Me.StatusStrip1.Text = "ssMain"
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(32, 17)
		Me.lblStatus.Text = "就绪"
		'
		'lsFiles
		'
		Me.lsFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
		Me.lsFiles.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lsFiles.FullRowSelect = True
		Me.lsFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lsFiles.Location = New System.Drawing.Point(0, 50)
		Me.lsFiles.Name = "lsFiles"
		Me.lsFiles.Size = New System.Drawing.Size(1008, 466)
		Me.lsFiles.TabIndex = 3
		Me.lsFiles.UseCompatibleStateImageBehavior = False
		Me.lsFiles.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "文件"
		Me.ColumnHeader1.Width = 400
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "状态"
		Me.ColumnHeader2.Width = 120
		'
		'ColumnHeader3
		'
		Me.ColumnHeader3.Text = "文件名"
		Me.ColumnHeader3.Width = 400
		'
		'ofdFiles
		'
		Me.ofdFiles.Filter = "所有文件 (*.*)|*.*"
		Me.ofdFiles.Multiselect = True
		'
		'frmSccTransfer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1008, 538)
		Me.Controls.Add(Me.lsFiles)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.tsMain)
		Me.Controls.Add(Me.msMain)
		Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.msMain
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "frmSccTransfer"
		Me.Text = "迪幻字幕助手 - SCC to SRT"
		Me.msMain.ResumeLayout(False)
		Me.msMain.PerformLayout()
		Me.tsMain.ResumeLayout(False)
		Me.tsMain.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents msMain As System.Windows.Forms.MenuStrip
    Friend WithEvents 文件FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 导入IToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 转换CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 返回BToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 如何使用HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 迪幻网DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lsFiles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ofdFiles As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
End Class
