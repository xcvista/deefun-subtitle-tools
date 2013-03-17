Imports DST.SrtCvs
Imports myPlayer.LrcReader
Imports DST.Info
Imports System.IO
Imports System.Windows.Forms

Public Class frmcheck
	Protected stcxName As String
	Protected stcxFile As CvsFile
	Protected isSaved As Boolean
	Protected current As Integer
	Protected indicefreeze As Boolean

	Private Sub openfile(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 打开OToolStripMenuItem.Click, ToolStripButton2.Click
		ofdStcx.FileName = ""
		If ofdStcx.ShowDialog(Me) = DialogResult.Cancel Then Exit Sub
		Try
			stcxName = ofdStcx.FileName
			stcxFile = CvsFile.LoadSTCX(New FileStream(stcxName, FileMode.Open, FileAccess.Read))
			te.Source = stcxFile.OriginalFile
			For Each ver As CvsSubtitle In stcxFile
				cbVers.Items.Add(Format(ver.VersionDate, "yyyy.MM.dd HH:mm:ss"))
			Next
			cbVers.SelectedIndex = stcxFile.Count - 1
			isSaved = True
			sc.Enabled = True
			保存SToolStripMenuItem.Enabled = True
			另存为AToolStripMenuItem.Enabled = True
			导出XToolStripMenuItem.Enabled = True
			ToolStripButton1.Enabled = True
			cbVers.Enabled = True
			ToolStripButton3.Enabled = True
			te.Changed = False
			updateui()
		Catch ex As Exception
			lblStatus.Text = ex.Message
		End Try
	End Sub

	Private Sub saveas(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 另存为AToolStripMenuItem.Click
		sfd.FileName = ""
		If sfd.ShowDialog(Me) = DialogResult.Cancel Then Exit Sub
		stcxFile.Add(New CvsSubtitle(te.Destinetion))
		isSaved = True
		stcxName = sfd.FileName
		stcxFile.WriteSTCX(New FileStream(stcxName, FileMode.OpenOrCreate, FileAccess.Write))
		'duplicate
		Dim lrcfile As New LrcFile
		For Each l As Line In stcxFile(cbVers.SelectedIndex).LrcFile
			lrcfile.Add(l)
		Next
		te.Destinetion = lrcfile
		te.Changed = True
	End Sub

	Private Sub save(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 保存SToolStripMenuItem.Click, ToolStripButton3.Click
		If Not isSaved Then
			saveas(sender, e)
			Exit Sub
		End If
		stcxFile.Add(New CvsSubtitle(te.Destinetion))
		isSaved = True
		stcxName = sfd.FileName
		stcxFile.WriteSTCX(New FileStream(stcxName, FileMode.OpenOrCreate, FileAccess.Write))
		'duplicate
		Dim lrcfile As New LrcFile
		For Each l As Line In stcxFile(cbVers.SelectedIndex).LrcFile
			lrcfile.Add(l)
		Next
		te.Destinetion = lrcfile
		te.Changed = False
	End Sub

	Private Sub 返回XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 返回XToolStripMenuItem.Click, ToolStripButton6.Click
		Me.Close()
	End Sub

	Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
		If te.Changed = True Then
			Select Case MessageBox.Show(Me, "文件尚未保存，保存？", "迪幻字幕工具", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
				Case Windows.Forms.DialogResult.Yes
					save(Me, e)
				Case Windows.Forms.DialogResult.Cancel
					e.Cancel = True
			End Select
		End If
		MyBase.OnClosing(e)
	End Sub

	Protected Sub updateui()
		ListView1.Items.Clear()
		For i As Integer = 0 To Math.Min(te.Source.Count, te.Destinetion.Count) - 1
			ListView1.Items.Add(New ListViewItem(New String() {te.Source(i).Content, te.Destinetion(i).Content}))
		Next
		ListView1.SelectedIndices.Clear()
		current = 0
		te.Current = 0
	End Sub

	Protected Sub updateui(ByVal index As Integer)
		ListView1.Items(index) = (New ListViewItem(New String() {te.Source(index).Content, te.Destinetion(index).Content}))
	End Sub

	Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
		If ListView1.SelectedIndices.Count = 0 Then Exit Sub
		If indicefreeze Then Exit Sub
		indicefreeze = True
		te.Current = ListView1.SelectedIndices(0)
		current = te.Current
		indicefreeze = False
	End Sub

	Private Sub change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles te.CurrentChanged
		If ListView1.SelectedIndices.Count = 0 Then Exit Sub
		If indicefreeze Then Exit Sub
		indicefreeze = True
		ListView1.SelectedIndices.Clear()
		ListView1.SelectedIndices.Add(te.Current)
		updateui(current)
		current = te.Current
		indicefreeze = False
	End Sub

	Private Sub 关于AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于AToolStripMenuItem.Click
		Dim frm As New frmAbout
		frm.ShowDialog(Me)
	End Sub

	Private Sub 迪幻网DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 迪幻网DToolStripMenuItem.Click
		Shell(String.Format("""{0}{1}Internet Explorer{1}iexplore.exe"" ""http://www.deefun.com/""", My.Computer.FileSystem.SpecialDirectories.ProgramFiles, Path.DirectorySeparatorChar), AppWinStyle.MaximizedFocus, False, -1)
	End Sub

	Private Sub switchvers(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbVers.SelectedIndexChanged
		'duplicate
		Dim lrcfile As New LrcFile
		For Each l As Line In stcxFile(cbVers.SelectedIndex).LrcFile
			lrcfile.Add(l)
		Next
		te.Destinetion = lrcfile
	End Sub

	Private Sub 导出XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 导出XToolStripMenuItem.Click
		sfdSrt.FileName = ""
		If sfdSrt.ShowDialog(Me) = DialogResult.Cancel Then Exit Sub
		Dim out As New LrcFile
		For i As Integer = 0 To Math.Min(te.Source.Count, te.Destinetion.Count)
			Dim l As Line = te.Destinetion(i)
			l.Content = l.Content.Trim
			l.Content += vbCrLf
			l.Content += te.Source(i).Content.Trim
			out.Add(l)
		Next
		out.Sort()
		out.SaveSRT(sfdSrt.FileName)
	End Sub
End Class