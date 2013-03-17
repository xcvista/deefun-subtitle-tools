Imports System.IO
Imports DST.Info
Imports DST.CharsetChanger
Imports DST.CCProcessor
Imports DST.Splitter
Imports DST.SrtMigrate
Imports DST.Translate
Imports DST.TimeAxisMerge

Public Class frmMain
	Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
		Me.Close()
	End Sub

	Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
		Dim frm As New frmAbout
		frm.ShowDialog(Me)
	End Sub

	Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
		Shell(String.Format("""{0}{1}Internet Explorer{1}iexplore.exe"" ""http://www.deefun.com/""", My.Computer.FileSystem.SpecialDirectories.ProgramFiles, Path.DirectorySeparatorChar), AppWinStyle.MaximizedFocus, False, -1)
	End Sub

	Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
		If ListView1.SelectedIndices.Count = 0 Then Exit Sub
		Dim frm As Form
		Select Case ListView1.SelectedIndices(0)
			Case 0
				frm = New frmCharset
			Case 1
				frm = New frmSccTransfer
			Case 2
				frm = New frmCcReform
			Case 3
				frm = New frmSrtSplitter
			Case 4
				frm = New frmTranslate
			Case 5
				frm = New frmMigrate
			Case 6
				frm = New frmAxisMerge
			Case Else
				frm = New frmAbout
		End Select
		Me.Hide()
		frm.ShowDialog(Me)
		Me.Show()
	End Sub
End Class
