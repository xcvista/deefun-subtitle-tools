<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharset
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCharset))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtSrc = New System.Windows.Forms.TextBox()
		Me.btnSrc = New System.Windows.Forms.Button()
		Me.txtCosepage = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtPreview = New System.Windows.Forms.TextBox()
		Me.btnDesc = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.cbCodepage = New System.Windows.Forms.ComboBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtDesc = New System.Windows.Forms.TextBox()
		Me.lblStatus = New System.Windows.Forms.Label()
		Me.ofd = New System.Windows.Forms.OpenFileDialog()
		Me.sfd = New System.Windows.Forms.SaveFileDialog()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(44, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "源文件"
		'
		'txtSrc
		'
		Me.txtSrc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtSrc.Location = New System.Drawing.Point(62, 12)
		Me.txtSrc.Name = "txtSrc"
		Me.txtSrc.ReadOnly = True
		Me.txtSrc.Size = New System.Drawing.Size(547, 23)
		Me.txtSrc.TabIndex = 1
		'
		'btnSrc
		'
		Me.btnSrc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSrc.Location = New System.Drawing.Point(615, 12)
		Me.btnSrc.Name = "btnSrc"
		Me.btnSrc.Size = New System.Drawing.Size(75, 23)
		Me.btnSrc.TabIndex = 2
		Me.btnSrc.Text = "浏览(&B)..."
		Me.btnSrc.UseVisualStyleBackColor = True
		'
		'txtCosepage
		'
		Me.txtCosepage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtCosepage.Location = New System.Drawing.Point(590, 41)
		Me.txtCosepage.Name = "txtCosepage"
		Me.txtCosepage.ReadOnly = True
		Me.txtCosepage.Size = New System.Drawing.Size(100, 23)
		Me.txtCosepage.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 47)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(44, 17)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "字符集"
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(540, 44)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(44, 17)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "代码页"
		'
		'txtPreview
		'
		Me.txtPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtPreview.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPreview.Location = New System.Drawing.Point(12, 93)
		Me.txtPreview.Multiline = True
		Me.txtPreview.Name = "txtPreview"
		Me.txtPreview.ReadOnly = True
		Me.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtPreview.Size = New System.Drawing.Size(678, 256)
		Me.txtPreview.TabIndex = 6
		'
		'btnDesc
		'
		Me.btnDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnDesc.Enabled = False
		Me.btnDesc.Location = New System.Drawing.Point(615, 355)
		Me.btnDesc.Name = "btnDesc"
		Me.btnDesc.Size = New System.Drawing.Size(75, 23)
		Me.btnDesc.TabIndex = 7
		Me.btnDesc.Text = "浏览(&R)..."
		Me.btnDesc.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Button3.Location = New System.Drawing.Point(12, 384)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 23)
		Me.Button3.TabIndex = 8
		Me.Button3.Text = "帮助(&H)"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Button4.Location = New System.Drawing.Point(93, 384)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(75, 23)
		Me.Button4.TabIndex = 9
		Me.Button4.Text = "关于(&A)..."
		Me.Button4.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSave.Enabled = False
		Me.btnSave.Location = New System.Drawing.Point(615, 384)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(75, 23)
		Me.btnSave.TabIndex = 10
		Me.btnSave.Text = "保存(&S)"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(12, 73)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(56, 17)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "内容预览"
		'
		'cbCodepage
		'
		Me.cbCodepage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbCodepage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCodepage.Enabled = False
		Me.cbCodepage.FormattingEnabled = True
		Me.cbCodepage.Location = New System.Drawing.Point(62, 41)
		Me.cbCodepage.Name = "cbCodepage"
		Me.cbCodepage.Size = New System.Drawing.Size(472, 25)
		Me.cbCodepage.TabIndex = 12
		'
		'Label5
		'
		Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(12, 358)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(114, 17)
		Me.Label5.TabIndex = 13
		Me.Label5.Text = "目标文件（UTF-8）"
		'
		'txtDesc
		'
		Me.txtDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtDesc.Location = New System.Drawing.Point(132, 355)
		Me.txtDesc.Name = "txtDesc"
		Me.txtDesc.ReadOnly = True
		Me.txtDesc.Size = New System.Drawing.Size(477, 23)
		Me.txtDesc.TabIndex = 14
		'
		'lblStatus
		'
		Me.lblStatus.AutoSize = True
		Me.lblStatus.Location = New System.Drawing.Point(174, 387)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(32, 17)
		Me.lblStatus.TabIndex = 15
		Me.lblStatus.Text = "就绪"
		'
		'ofd
		'
		Me.ofd.Filter = "所有文件 (*.*)|*.*"
		'
		'sfd
		'
		Me.sfd.Filter = "所有文件 (*.*)|*.*"
		'
		'frmCharset
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(702, 419)
		Me.Controls.Add(Me.lblStatus)
		Me.Controls.Add(Me.txtDesc)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.cbCodepage)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.btnDesc)
		Me.Controls.Add(Me.txtPreview)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtCosepage)
		Me.Controls.Add(Me.btnSrc)
		Me.Controls.Add(Me.txtSrc)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "frmCharset"
		Me.Text = "字符集转换"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSrc As System.Windows.Forms.TextBox
    Friend WithEvents btnSrc As System.Windows.Forms.Button
    Friend WithEvents txtCosepage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPreview As System.Windows.Forms.TextBox
    Friend WithEvents btnDesc As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbCodepage As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
End Class
