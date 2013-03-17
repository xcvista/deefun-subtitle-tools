Imports System.Windows.Forms
Imports System.Threading
Imports System.IO
Imports myPlayer.LrcReader
Imports DST.Info

Public Class frmMigrate
	Protected worker As Thread

	Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsFiles.SelectedIndexChanged
		If lsFiles.SelectedIndices.Count <> 0 Then
			移除分卷RToolStripMenuItem.Enabled = True
			ToolStripButton3.Enabled = True
		Else
			移除分卷RToolStripMenuItem.Enabled = False
			ToolStripButton3.Enabled = False
		End If
	End Sub

	Private Sub 设置保存目标SToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 设置保存目标SToolStripMenuItem.Click, ToolStripButton1.Click
		sfd.FileName = ""
		If sfd.ShowDialog(Me) = DialogResult.Cancel Then Exit Sub
		txtDestination.Text = sfd.FileName
		If lsFiles.Items.Count = 0 Or txtDestination.Text = "" Then
			开始合并MToolStripMenuItem.Enabled = False
			ToolStripButton4.Enabled = False
		Else
			开始合并MToolStripMenuItem.Enabled = True
			ToolStripButton4.Enabled = True
		End If
	End Sub

	Private Sub 导入分卷IToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 导入分卷IToolStripMenuItem.Click, ToolStripButton2.Click
		ofd.FileName = ""
		If ofd.ShowDialog(Me) = DialogResult.Cancel Then Exit Sub
		For Each file As String In ofd.FileNames
			Try
				Dim sf As LrcFile = LrcFile.LoadSRT(file)
				If sf.Count = 0 Then Continue For
				lsFiles.Items.Add(New ListViewItem(New String() {file, String.Format("{0}", sf(0).Start), String.Format("{0}", sf(sf.Count - 1).Stop), String.Format("{0}", sf.Count), "挂起"}))
			Catch ex As Exception
				lblStatus.Text = ex.Message
				Continue For
			End Try
		Next
		If lsFiles.Items.Count = 0 Or txtDestination.Text = "" Then
			开始合并MToolStripMenuItem.Enabled = False
			ToolStripButton4.Enabled = False
		Else
			开始合并MToolStripMenuItem.Enabled = True
			ToolStripButton4.Enabled = True
		End If
	End Sub

	Private Sub 移除分卷RToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 移除分卷RToolStripMenuItem.Click, ToolStripButton3.Click
		For index As Integer = lsFiles.SelectedIndices.Count - 1 To 0 Step -1
			lsFiles.Items.RemoveAt(lsFiles.SelectedIndices(index))
		Next
		If lsFiles.Items.Count = 0 Or txtDestination.Text = "" Then
			开始合并MToolStripMenuItem.Enabled = False
			ToolStripButton4.Enabled = False
		Else
			开始合并MToolStripMenuItem.Enabled = True
			ToolStripButton4.Enabled = True
		End If
	End Sub

	Private Sub 关于AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于AToolStripMenuItem.Click
		Dim frm As New frmAbout
		frm.ShowDialog(Me)
	End Sub

	Private Sub 返回XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 返回XToolStripMenuItem.Click, ToolStripButton5.Click
		Me.Close()
	End Sub

	Private Sub 开始合并MToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 开始合并MToolStripMenuItem.Click, ToolStripButton4.Click
		Control.CheckForIllegalCrossThreadCalls = False
		worker = New Thread(AddressOf Migrate)
		worker.Start()
	End Sub

	Protected Sub Migrate()
		msMain.Enabled = False
		tsMain.Enabled = False
		tsOutput.Enabled = False
		Dim totalLines As Integer = 0
		pgbMain.Value = 0
		lblStatus.Text = "正在准备"
		Dim out As New LrcFile
		For Each li As ListViewItem In lsFiles.Items
			If li.SubItems(3).Text = "完成" Then Continue For
			totalLines += CInt(Val(li.SubItems(3).Text))
		Next
		pgbMain.Maximum = totalLines
		For Each li As ListViewItem In lsFiles.Items
			If li.SubItems(3).Text = "完成" Then Continue For
			Dim f As LrcFile = LrcFile.LoadSRT(li.Text)
			out.AddRange(f)
			pgbMain.Value += f.Count
			lblStatus.Text = String.Format("已合并 {0}/{1} 行", pgbMain.Value, totalLines)
			li.SubItems(3).Text = "完成"
		Next
		lblStatus.Text = "正在排序"
		out.Sort()
		out.SaveSRT(txtDestination.Text)
		txtDestination.Text = ""
		msMain.Enabled = True
		tsMain.Enabled = True
		tsOutput.Enabled = True
		开始合并MToolStripMenuItem.Enabled = False
		ToolStripButton4.Enabled = False
	End Sub

	Private Sub frmMigrate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		worker = New Thread(AddressOf Migrate)
	End Sub

	Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
		If IsNothing(worker) Then
			MyBase.OnClosing(e)
			Exit Sub
		End If
		If worker.ThreadState = ThreadState.Running Then
			e.Cancel = True
		End If
		MyBase.OnClosing(e)
	End Sub
End Class