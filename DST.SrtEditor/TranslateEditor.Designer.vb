<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TranslateEditor
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
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
		Me.tlMain = New System.Windows.Forms.TableLayoutPanel()
		Me.txtOriginal = New System.Windows.Forms.TextBox()
		Me.txtTranslation = New System.Windows.Forms.TextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.tlMain.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'tlMain
		'
		Me.tlMain.ColumnCount = 1
		Me.tlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.tlMain.Controls.Add(Me.txtOriginal, 0, 0)
		Me.tlMain.Controls.Add(Me.txtTranslation, 0, 2)
		Me.tlMain.Controls.Add(Me.Panel1, 0, 1)
		Me.tlMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tlMain.Location = New System.Drawing.Point(0, 0)
		Me.tlMain.Margin = New System.Windows.Forms.Padding(0)
		Me.tlMain.Name = "tlMain"
		Me.tlMain.RowCount = 3
		Me.tlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.tlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
		Me.tlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.tlMain.Size = New System.Drawing.Size(395, 398)
		Me.tlMain.TabIndex = 0
		'
		'txtOriginal
		'
		Me.txtOriginal.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txtOriginal.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtOriginal.Location = New System.Drawing.Point(3, 4)
		Me.txtOriginal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtOriginal.Multiline = True
		Me.txtOriginal.Name = "txtOriginal"
		Me.txtOriginal.ReadOnly = True
		Me.txtOriginal.Size = New System.Drawing.Size(389, 175)
		Me.txtOriginal.TabIndex = 0
		'
		'txtTranslation
		'
		Me.txtTranslation.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txtTranslation.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTranslation.Location = New System.Drawing.Point(3, 218)
		Me.txtTranslation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtTranslation.Multiline = True
		Me.txtTranslation.Name = "txtTranslation"
		Me.txtTranslation.Size = New System.Drawing.Size(389, 176)
		Me.txtTranslation.TabIndex = 1
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.Button2)
		Me.Panel1.Controls.Add(Me.Button1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 183)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(395, 31)
		Me.Panel1.TabIndex = 2
		'
		'Button2
		'
		Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button2.Image = Global.DST.SrtEditor.My.Resources.Resources.forward
		Me.Button2.Location = New System.Drawing.Point(298, 3)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(94, 25)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "下一条(&N)"
		Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Image = Global.DST.SrtEditor.My.Resources.Resources.Back
		Me.Button1.Location = New System.Drawing.Point(3, 3)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(94, 25)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "上一条(&P)"
		Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TranslateEditor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.tlMain)
		Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "TranslateEditor"
		Me.Size = New System.Drawing.Size(395, 398)
		Me.tlMain.ResumeLayout(False)
		Me.tlMain.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents tlMain As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents txtOriginal As System.Windows.Forms.TextBox
	Friend WithEvents txtTranslation As System.Windows.Forms.TextBox
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents Button2 As System.Windows.Forms.Button
	Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
