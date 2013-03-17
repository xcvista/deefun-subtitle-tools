Imports myPlayer.LrcReader
Imports DST.Info
Imports System.IO

Public Class frmTranslate
	Protected origName As String
	Protected outName As String
	Protected isSaved As Boolean
	Protected current As Integer
	Protected indicefreeze As Boolean

	Private Sub 返回XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 返回XToolStripMenuItem.Click, ToolStripButton6.Click
		Me.Close()
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
		'If ListView1.SelectedIndices.Count = 0 Then Exit Sub
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
		DeefunActiviate.InvokeDeefunSite()
	End Sub

	Private Sub open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 打开原文OToolStripMenuItem.Click, ToolStripButton1.Click
		ofd.FileName = ""
		If ofd.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
		origName = ofd.FileName
		isSaved = False
		te.Source = LrcFile.LoadSRT(origName)
		te.GenerateNewDestinetion()
		updateui()
		sc.Enabled = True
		打开OToolStripMenuItem.Enabled = True
		保存SToolStripMenuItem.Enabled = True
		另存为AToolStripMenuItem.Enabled = True
		导出双语字幕XToolStripMenuItem.Enabled = True
		ToolStripButton2.Enabled = True
		ToolStripButton3.Enabled = True
		te.Changed = False
	End Sub

	Private Sub opendoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click, 打开OToolStripMenuItem.Click
		ofd.FileName = String.Format("{0}.d.srt", Path.GetFileNameWithoutExtension(origName))
		ofd.InitialDirectory = Path.GetDirectoryName(origName)
		If ofd.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
		outName = ofd.FileName
		isSaved = True
		te.Destinetion = LrcFile.LoadSRT(origName)
		te.GenerateNewDestinetion()
		te.Changed = False
		updateui()
		te.Changed = False
	End Sub

	Private Sub saveas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 另存为AToolStripMenuItem.Click
		sfd.FileName = String.Format("{0}.d.srt", Path.GetFileNameWithoutExtension(origName))
		sfd.InitialDirectory = Path.GetDirectoryName(origName)
		If sfd.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
		outName = sfd.FileName
		isSaved = True
		te.Changed = False
		te.Destinetion.SaveSRT(outName)
	End Sub

	Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 保存SToolStripMenuItem.Click, ToolStripButton3.Click
		If isSaved Then
			te.Destinetion.SaveSRT(outName)
			te.Changed = False
		Else
			saveas_Click(sender, e)
		End If
	End Sub

	Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
		Dim done As Boolean = False
		If te.Changed Then
			Do
				Select Case MessageBox.Show(Me, "文件未保存。保存？", "迪幻字幕工具", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
					Case Windows.Forms.DialogResult.Yes
						If isSaved Then
							te.Destinetion.SaveSRT(outName)
							te.Changed = False
							done = True
						Else
							sfd.FileName = String.Format("{0}.d.srt", Path.GetFileNameWithoutExtension(origName))
							sfd.InitialDirectory = Path.GetDirectoryName(origName)
							If sfd.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Continue Do
							outName = sfd.FileName
							isSaved = True
							te.Changed = False
							te.Destinetion.SaveSRT(outName)
							done = True
						End If
					Case Windows.Forms.DialogResult.Cancel
						e.Cancel = True
						done = True
					Case Windows.Forms.DialogResult.No
						done = True
				End Select
			Loop Until done
		End If
		MyBase.OnClosing(e)
	End Sub

	Private Sub 导出双语字幕XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 导出双语字幕XToolStripMenuItem.Click
		sfd.FileName = String.Format("{0}.chs.eng-Deefun.srt", Path.GetFileNameWithoutExtension(origName))
		sfd.InitialDirectory = Path.GetDirectoryName(origName)
		If sfd.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
		Dim sf As New LrcFile
		For i As Integer = 0 To Math.Min(te.Source.Count, te.Destinetion.Count) - 1
			Dim line As Line = te.Source(i)
			Dim s = te.Destinetion(i).Content
			s = String.Format("{0}{1}{2}", s.Trim, vbCrLf, line.Content.Trim)
			line.Content = s.Trim
			sf.Add(line)
		Next
		sf.Sort()
		sf.SaveSRT(sfd.FileName)
	End Sub
End Class