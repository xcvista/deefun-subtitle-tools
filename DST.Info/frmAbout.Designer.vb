<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.Label1.Location = New System.Drawing.Point(12, 137)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(191, 39)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "迪幻字幕工具"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.Label2.Location = New System.Drawing.Point(14, 176)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(215, 27)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Deefun Subtitle Tools"
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.Teal
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox1.ForeColor = System.Drawing.Color.White
		Me.TextBox1.Location = New System.Drawing.Point(12, 223)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = True
		Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TextBox1.Size = New System.Drawing.Size(405, 196)
		Me.TextBox1.TabIndex = 3
		Me.TextBox1.Text = resources.GetString("TextBox1.Text")
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.Button2)
		Me.Panel1.Controls.Add(Me.Button1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Panel1.Location = New System.Drawing.Point(0, 422)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(429, 38)
		Me.Panel1.TabIndex = 4
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(12, 3)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "迪幻网(&D)"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Button1.Location = New System.Drawing.Point(342, 3)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "确定"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 203)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(84, 17)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "版本 1.0 RTM"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.DST.Info.My.Resources.Resources.deefun
		Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(405, 122)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'frmAbout
		'
		Me.AcceptButton = Me.Button1
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Teal
		Me.CancelButton = Me.Button1
		Me.ClientSize = New System.Drawing.Size(429, 460)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.ForeColor = System.Drawing.Color.White
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmAbout"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "关于迪幻字幕工具"
		Me.Panel1.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
