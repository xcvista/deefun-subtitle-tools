Imports myPlayer.LrcReader
Imports System.Threading
Imports System.IO
Imports DST.Info
Imports System.Windows.Forms

Public Class frmSrtSplitter
    Protected srtFile As LrcFile
    Protected worker As Thread

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ofdSrtFile.FileName = ""
        If ofdSrtFile.ShowDialog(Me) = DialogResult.Cancel Then Exit Sub
        txtSrtFile.Text = ofdSrtFile.FileName
        srtFile = LrcFile.LoadSRT(txtSrtFile.Text)
        nudSplitNum.Maximum = srtFile.Count
        nudSplitNum.Value = 1
        lblStatus.Text = String.Format("文件已加载，共 {0} 行。", srtFile.Count)
        nudSplitNum.Enabled = True
        Button2.Enabled = True
    End Sub

    Private Sub nudSplitNum_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSplitNum.ValueChanged
        If Not IsNothing(srtFile) Then lblStatus.Text = String.Format("文件共 {0} 行，每份共 {1} 行。", srtFile.Count, CInt(Int(CDbl(srtFile.Count) / CDbl(nudSplitNum.Value))) + 1)
    End Sub

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        worker = New Thread(AddressOf Splitter)

    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        e.Cancel = worker.ThreadState = ThreadState.Running
        MyBase.OnClosing(e)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        worker = New Thread(AddressOf Splitter)
        Control.CheckForIllegalCrossThreadCalls = False
        worker.Start()
    End Sub

    Protected Sub Splitter()
		'禁用界面控件
		Button1.Enabled = False
        Button2.Enabled = False
        nudSplitNum.Enabled = False
		lblStatus.Text = "正在开始……"

		'准备
		Dim fileindex As Integer = 1 '生成文件名用
        Dim lpf As Integer = CInt(Int(CDbl(srtFile.Count) / CDbl(nudSplitNum.Value)))
        Dim fileName As String = Path.GetFileNameWithoutExtension(txtSrtFile.Text)
        Dim fileDir As String = Path.GetDirectoryName(txtSrtFile.Text)
        Dim outputDir As String = fileDir + Path.DirectorySeparatorChar + fileName
        Dim outFile As New LrcFile

        ProgressBar1.Maximum = srtFile.Count
        ProgressBar1.Value = 0

		'创建目录，安全原因
        If Not Directory.Exists(outputDir) Then Directory.CreateDirectory(outputDir)

		'逐行经过字幕内容
		For Each l As Line In srtFile
			lblStatus.Text = String.Format("正在生成第 {0} 份文件，已处理 {1}/{2} 行。", fileindex, ProgressBar1.Value + 1, srtFile.Count)
			outFile.Add(l)
			'够数了，保存一个分卷
			If outFile.Count >= lpf Then
				'Save this output
				outFile.SaveSRT(String.Format("{0}{1}{2}.part{3}.srt", outputDir, Path.DirectorySeparatorChar, fileName, fileindex))
				'分卷序号
				fileindex += 1
				'清空缓存
				outFile.Clear()
			End If
			ProgressBar1.Value += 1
		Next
		'outFile.Add(srtFile(srtFile.Count - 1))
		'还有剩余么？
        If outFile.Count <> 0 Then
            'Save this output
            Dim file As New LrcFile(outFile.ToArray)
            file.SaveSRT(String.Format("{0}{1}{2}.part{3}.srt", outputDir, Path.DirectorySeparatorChar, fileName, fileindex))
            fileindex += 1
            outFile.Clear()
		End If

		'结束
        lblStatus.Text = String.Format("处理完成，共生成 {0} 份文件。", fileindex - 1)
        Button1.Enabled = True
        Button2.Enabled = True
        nudSplitNum.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim frm As New frmAbout
        frm.ShowDialog(Me)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub
End Class