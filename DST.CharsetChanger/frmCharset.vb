Imports System.Text
Imports System.IO
Imports DST.Info

Public Class frmCharset
    Protected codePages As EncodingInfo()
    Protected data As Byte()

    Private Sub frmCharset_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        codePages = Encoding.GetEncodings
        For Each cp As EncodingInfo In codePages
            cbCodepage.Items.Add(cp.DisplayName)
        Next
        For i As Integer = 0 To codePages.Length - 1
            If codePages(i).CodePage = 936 Then
                cbCodepage.SelectedIndex = i
                Exit For
            End If
        Next
        'data = New Byte() {}
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCodepage.SelectedIndexChanged
        txtCosepage.Text = Trim(CStr(codePages(cbCodepage.SelectedIndex).CodePage))
        If IsNothing(data) Then Exit Sub
        Dim ms As New MemoryStream(data)
        Dim sr As New StreamReader(ms, codePages(cbCodepage.SelectedIndex).GetEncoding)
        txtPreview.Text = sr.ReadToEnd
        btnDesc.Enabled = True
		sr.Close()
		ms.Dispose()
    End Sub

    Private Sub btnSrc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSrc.Click
        ofd.FileName = ""
		If ofd.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
        lblStatus.Text = "正在加载文件"
        txtSrc.Text = ofd.FileName
        Dim fs As New FileStream(txtSrc.Text, FileMode.Open, FileAccess.Read)
        ReDim data(fs.Length)
        fs.Read(data, 0, fs.Length)
        fs.Close()
        cbCodepage.Enabled = True
        ComboBox1_SelectedIndexChanged(Me, Nothing)
        lblStatus.Text = "就绪"
    End Sub

    Private Sub btnDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesc.Click
        sfd.InitialDirectory = Path.GetDirectoryName(txtSrc.Text)
        sfd.FileName = Path.ChangeExtension(Path.GetFileName(txtSrc.Text), String.Format(".uni{0}", Path.GetExtension(txtSrc.Text)))
		If sfd.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
        txtDesc.Text = sfd.FileName
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sw As New StreamWriter(txtDesc.Text, False, Encoding.UTF8)
        sw.Write(txtPreview.Text)
        sw.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim frm As New frmAbout
        frm.ShowDialog(Me)
    End Sub

	Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
		Shell(String.Format("""{0}{1}Internet Explorer{1}iexplore.exe"" ""http://www.deefun.com/viewthread.php?tid=10477""", My.Computer.FileSystem.SpecialDirectories.ProgramFiles, Path.DirectorySeparatorChar), AppWinStyle.MaximizedFocus, False, -1)
	End Sub
End Class