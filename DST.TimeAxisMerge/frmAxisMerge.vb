Imports DST.Info
Imports System.Windows.Forms
Imports myPlayer.LrcReader
Imports System.IO

Public Class frmAxisMerge

	Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
		Dim frm As New frmAbout
		frm.ShowDialog(Me)
	End Sub

	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		ofd.FileName = ""
		If ofd.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
		txtAxis.Text = ofd.FileName
		updateui1()
		Button2.Enabled = True
	End Sub

	Protected Sub updateui()
		ListView1.Items.Clear()
		Dim source As LrcFile = LrcFile.LoadSRT(txtAxis.Text)
		Dim destinetion As LrcFile = LrcFile.LoadSRT(txtContent.Text)
		For i As Integer = 0 To Math.Min(source.Count, destinetion.Count) - 1
			ListView1.Items.Add(New ListViewItem(New String() {source(i).Start.ToString, source(i).Stop.ToString, destinetion(i).Content}))
		Next
		ListView1.SelectedIndices.Clear()
	End Sub

	Protected Sub updateui1()
		ListView1.Items.Clear()
		Dim source As LrcFile = LrcFile.LoadSRT(txtAxis.Text)
		For i As Integer = 0 To source.Count - 1
			ListView1.Items.Add(New ListViewItem(New String() {source(i).Start.ToString, source(i).Stop.ToString}))
		Next
		ListView1.SelectedIndices.Clear()
	End Sub

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		ofd.FileName = ""
		ofd.InitialDirectory = Path.GetDirectoryName(txtAxis.Text)
		If ofd.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
		txtContent.Text = ofd.FileName
		updateui()
		Button3.Enabled = True
	End Sub

	Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
		Dim origName As String = txtContent.Text
		sfd.FileName = String.Format("{0}.reaxis.srt", Path.GetFileNameWithoutExtension(origName))
		sfd.InitialDirectory = Path.GetDirectoryName(origName)
		If sfd.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
		txtOut.Text = sfd.FileName
		Button6.Enabled = True
	End Sub

	Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
		Dim source As LrcFile = LrcFile.LoadSRT(txtAxis.Text)
		Dim destinetion As LrcFile = LrcFile.LoadSRT(txtContent.Text)
		Dim out As New LrcFile
		For i As Integer = 0 To Math.Min(source.Count, destinetion.Count) - 1
			Dim l As Line = source(i)
			l.Content = destinetion(i).Content
			out.Add(l)
		Next
		out.Sort()
		out.SaveSRT(txtOut.Text)
	End Sub
End Class