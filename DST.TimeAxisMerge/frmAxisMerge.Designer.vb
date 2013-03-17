<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAxisMerge
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAxisMerge))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtAxis = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtContent = New System.Windows.Forms.TextBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtOut = New System.Windows.Forms.TextBox()
		Me.ofd = New System.Windows.Forms.OpenFileDialog()
		Me.sfd = New System.Windows.Forms.SaveFileDialog()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(68, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "时间轴文件"
		'
		'txtAxis
		'
		Me.txtAxis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtAxis.Location = New System.Drawing.Point(98, 12)
		Me.txtAxis.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtAxis.Name = "txtAxis"
		Me.txtAxis.ReadOnly = True
		Me.txtAxis.Size = New System.Drawing.Size(692, 23)
		Me.txtAxis.TabIndex = 1
		'
		'Button1
		'
		Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button1.Location = New System.Drawing.Point(796, 12)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "浏览(&B)..."
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 44)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(80, 17)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "字幕内容文件"
		'
		'txtContent
		'
		Me.txtContent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtContent.Location = New System.Drawing.Point(98, 41)
		Me.txtContent.Name = "txtContent"
		Me.txtContent.ReadOnly = True
		Me.txtContent.Size = New System.Drawing.Size(692, 23)
		Me.txtContent.TabIndex = 4
		'
		'Button2
		'
		Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button2.Enabled = False
		Me.Button2.Location = New System.Drawing.Point(796, 41)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 5
		Me.Button2.Text = "浏览(&R)..."
		Me.Button2.UseVisualStyleBackColor = True
		'
		'ListView1
		'
		Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
		Me.ListView1.Location = New System.Drawing.Point(12, 70)
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Size = New System.Drawing.Size(859, 394)
		Me.ListView1.TabIndex = 6
		Me.ListView1.UseCompatibleStateImageBehavior = False
		Me.ListView1.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "开始时间"
		Me.ColumnHeader1.Width = 120
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "结束时间"
		Me.ColumnHeader2.Width = 120
		'
		'ColumnHeader3
		'
		Me.ColumnHeader3.Text = "内容"
		Me.ColumnHeader3.Width = 400
		'
		'Button3
		'
		Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button3.Enabled = False
		Me.Button3.Location = New System.Drawing.Point(796, 470)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 23)
		Me.Button3.TabIndex = 7
		Me.Button3.Text = "浏览(&W)..."
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Button4.Location = New System.Drawing.Point(12, 499)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(75, 23)
		Me.Button4.TabIndex = 8
		Me.Button4.Text = "帮助(&H)"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button5
		'
		Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Button5.Location = New System.Drawing.Point(93, 499)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(75, 23)
		Me.Button5.TabIndex = 9
		Me.Button5.Text = "关于(&A)..."
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button6
		'
		Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button6.Enabled = False
		Me.Button6.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.Button6.Location = New System.Drawing.Point(796, 499)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(75, 23)
		Me.Button6.TabIndex = 10
		Me.Button6.Text = "开始(&S)"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 473)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(56, 17)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "输出文件"
		'
		'txtOut
		'
		Me.txtOut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtOut.Location = New System.Drawing.Point(98, 470)
		Me.txtOut.Name = "txtOut"
		Me.txtOut.ReadOnly = True
		Me.txtOut.Size = New System.Drawing.Size(692, 23)
		Me.txtOut.TabIndex = 12
		'
		'ofd
		'
		Me.ofd.Filter = "字幕文件 (*.srt)|*.srt|所有文件 (*.*)|*.*"
		Me.ofd.Title = "请选择字幕原文"
		'
		'sfd
		'
		Me.sfd.Filter = "字幕文件 (*.srt)|*.srt|所有文件 (*.*)|*.*"
		'
		'frmAxisMerge
		'
		Me.AcceptButton = Me.Button6
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(883, 534)
		Me.Controls.Add(Me.txtOut)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Button6)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.ListView1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.txtContent)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.txtAxis)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "frmAxisMerge"
		Me.Text = "迪幻字幕工具 - 时间轴融合"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents txtAxis As System.Windows.Forms.TextBox
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents txtContent As System.Windows.Forms.TextBox
	Friend WithEvents Button2 As System.Windows.Forms.Button
	Friend WithEvents ListView1 As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
	Friend WithEvents Button3 As System.Windows.Forms.Button
	Friend WithEvents Button4 As System.Windows.Forms.Button
	Friend WithEvents Button5 As System.Windows.Forms.Button
	Friend WithEvents Button6 As System.Windows.Forms.Button
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents txtOut As System.Windows.Forms.TextBox
	Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
	Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
End Class
