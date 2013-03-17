<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
Me.components = New System.ComponentModel.Container()
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("前置处理", System.Windows.Forms.HorizontalAlignment.Left)
Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("字幕任务与翻译", System.Windows.Forms.HorizontalAlignment.Left)
Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("翻译后处理", System.Windows.Forms.HorizontalAlignment.Left)
Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("第一步：字符集转换", 0)
Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("第二步：剧本前置转换", 1)
Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("第三步：CC 字幕处理", 3)
Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("第四步：字幕切分（分任务）", 2)
Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("第五步：字幕翻译与校对", 4)
Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("第六步：翻译任务融合（交任务）", 5)
Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("第七步：时间轴融合", 6)
Me.ilMain = New System.Windows.Forms.ImageList(Me.components)
Me.ListView1 = New System.Windows.Forms.ListView()
Me.Button6 = New System.Windows.Forms.Button()
Me.Button5 = New System.Windows.Forms.Button()
Me.Button7 = New System.Windows.Forms.Button()
Me.PictureBox1 = New System.Windows.Forms.PictureBox()
CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'ilMain
'
Me.ilMain.ImageStream = CType(resources.GetObject("ilMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
Me.ilMain.TransparentColor = System.Drawing.Color.Transparent
Me.ilMain.Images.SetKeyName(0, "1403_Globe.png")
Me.ilMain.Images.SetKeyName(1, "112_RefreshArrow_Blue_48x48_72.png")
Me.ilMain.Images.SetKeyName(2, "1460_PaintPalette_48x48.png")
Me.ilMain.Images.SetKeyName(3, "005_Task_48x48_72.png")
Me.ilMain.Images.SetKeyName(4, "Book_Green_48x48.png")
Me.ilMain.Images.SetKeyName(5, "1446_envelope_stamp_clsd_48.png")
Me.ilMain.Images.SetKeyName(6, "1435_ClipBoard.png")
'
'ListView1
'
Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
ListViewGroup1.Header = "前置处理"
ListViewGroup1.Name = "ListViewGroup1"
ListViewGroup2.Header = "字幕任务与翻译"
ListViewGroup2.Name = "ListViewGroup2"
ListViewGroup3.Header = "翻译后处理"
ListViewGroup3.Name = "ListViewGroup3"
Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
ListViewItem1.Group = ListViewGroup1
ListViewItem2.Group = ListViewGroup1
ListViewItem3.Group = ListViewGroup1
ListViewItem4.Group = ListViewGroup2
ListViewItem5.Group = ListViewGroup2
ListViewItem6.Group = ListViewGroup3
ListViewItem7.Group = ListViewGroup3
Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7})
Me.ListView1.LargeImageList = Me.ilMain
Me.ListView1.Location = New System.Drawing.Point(140, 0)
Me.ListView1.Name = "ListView1"
Me.ListView1.Size = New System.Drawing.Size(302, 516)
Me.ListView1.SmallImageList = Me.ilMain
Me.ListView1.TabIndex = 9
Me.ListView1.UseCompatibleStateImageBehavior = False
Me.ListView1.View = System.Windows.Forms.View.Tile
'
'Button6
'
Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
Me.Button6.BackColor = System.Drawing.Color.Transparent
Me.Button6.Location = New System.Drawing.Point(12, 481)
Me.Button6.Name = "Button6"
Me.Button6.Size = New System.Drawing.Size(122, 23)
Me.Button6.TabIndex = 11
Me.Button6.Text = "退出(&X)"
Me.Button6.UseVisualStyleBackColor = False
'
'Button5
'
Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
Me.Button5.BackColor = System.Drawing.Color.Transparent
Me.Button5.Location = New System.Drawing.Point(12, 423)
Me.Button5.Name = "Button5"
Me.Button5.Size = New System.Drawing.Size(122, 23)
Me.Button5.TabIndex = 10
Me.Button5.Text = "关于(&A)..."
Me.Button5.UseVisualStyleBackColor = False
'
'Button7
'
Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
Me.Button7.BackColor = System.Drawing.Color.Transparent
Me.Button7.Location = New System.Drawing.Point(12, 452)
Me.Button7.Name = "Button7"
Me.Button7.Size = New System.Drawing.Size(122, 23)
Me.Button7.TabIndex = 12
Me.Button7.Text = "迪幻网(&D)"
Me.Button7.UseVisualStyleBackColor = False
'
'PictureBox1
'
Me.PictureBox1.Image = Global.DST.My.Resources.Resources.deefun_vertical
Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
Me.PictureBox1.Name = "PictureBox1"
Me.PictureBox1.Size = New System.Drawing.Size(122, 405)
Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
Me.PictureBox1.TabIndex = 13
Me.PictureBox1.TabStop = False
'
'frmMain
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.BackColor = System.Drawing.Color.Teal
Me.ClientSize = New System.Drawing.Size(442, 516)
Me.Controls.Add(Me.PictureBox1)
Me.Controls.Add(Me.Button6)
Me.Controls.Add(Me.Button7)
Me.Controls.Add(Me.Button5)
Me.Controls.Add(Me.ListView1)
Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
Me.MinimumSize = New System.Drawing.Size(450, 550)
Me.Name = "frmMain"
Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
Me.Text = "迪幻字幕助手"
CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
	Friend WithEvents ilMain As System.Windows.Forms.ImageList
	Friend WithEvents ListView1 As System.Windows.Forms.ListView
	Friend WithEvents Button7 As System.Windows.Forms.Button
	Friend WithEvents Button6 As System.Windows.Forms.Button
	Friend WithEvents Button5 As System.Windows.Forms.Button
 Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
