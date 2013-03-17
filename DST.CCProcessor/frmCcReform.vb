Imports myPlayer.LrcReader
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms
Imports DST.Info

'---------------------------------------------
' 迪幻字幕工具 - CC处理
'---------------------------------------------

Public Class frmCcReform
    Protected isRunning As Boolean
    Protected Files As List(Of LrcFile)
    Protected Worker As Thread

    Private Sub 返回BToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 返回BToolStripMenuItem.Click, ToolStripButton4.Click
        Me.Close()
    End Sub

	Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
		'安全起见
		If IsNothing(Worker) Then
			MyBase.OnClosing(e)
			Exit Sub
		End If

		'防止意外关闭
		If Worker.ThreadState = ThreadState.Running Then
			e.Cancel = True
		End If
		MyBase.OnClosing(e)
	End Sub

    Private Sub 导入IToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 导入IToolStripMenuItem.Click, ToolStripButton1.Click
		'准备打开
		ofdFiles.FileName = ""

		'打开文件，简化写法
		If ofdFiles.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub

		'逐一添加
		For Each file As String In ofdFiles.FileNames
			Dim srtfile As LrcFile
			'Try
			srtfile = LrcFile.LoadSRT(file)
			lsFiles.Items.Add(New ListViewItem(New String() {Path.GetFileNameWithoutExtension(file), "挂起", file}))
			Files.Add(srtfile)
			'Catch ex As Exception
			'lblStatus.Text = ex.Message
			'Continue For
			'End Try
		Next
    End Sub

    Private Sub lsFiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsFiles.SelectedIndexChanged
		'不是什么时候都能删除——安全起见
		If lsFiles.SelectedIndices.Count <> 0 Then
			删除DToolStripMenuItem.Enabled = True
			ToolStripButton2.Enabled = True
		Else
			删除DToolStripMenuItem.Enabled = False
			ToolStripButton2.Enabled = False
		End If
    End Sub

    Private Sub 删除DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除DToolStripMenuItem.Click, ToolStripButton2.Click
		'删除文件项——必须逆向操作，安全起见
		For index As Integer = lsFiles.SelectedIndices.Count - 1 To 0 Step -1
			Files.RemoveAt(lsFiles.SelectedIndices(index))
			lsFiles.Items.RemoveAt(lsFiles.SelectedIndices(index))
		Next
    End Sub

    Private Sub 转换CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 转换CToolStripMenuItem.Click, ToolStripButton3.Click
		'多线程
		Control.CheckForIllegalCrossThreadCalls = False
        isRunning = True

        Worker = New Thread(AddressOf ConvertThread)
        Worker.Start()
    End Sub

    Protected Sub ConvertThread()
		'禁用窗体，准备工作
		msMain.Enabled = False
        tsMain.Enabled = False
        'pgbFile.Visible = True
		pgbFile.Value = 0

		'逐一处理 - 为了界面和谐，用for不用foreach
		For index As Integer = 0 To Files.Count - 1
			'防重复
			If lsFiles.Items(index).SubItems(1).Text = "完成" Then Continue For

			'面子工程
			lsFiles.Items(index).SubItems(1).Text = "正在转换"

			'读文件
			Dim srtFile As LrcFile = Files(index)
			Dim fileName As String = lsFiles.Items(index).SubItems(2).Text

			'处理文件
			pgbFile.Maximum = srtFile.Count
			For i As Integer = srtFile.Count - 1 To 0 Step -1 '存在删除问题
				pgbFile.Value = srtFile.Count - i
				lblStatus.Text = String.Format("文件：{0}/{1} - {2}，行：{3}/{4}", index + 1, Files.Count, lsFiles.Items(index).Text, srtFile.Count - i, srtFile.Count)
				With srtFile(i)
					Dim s As String
					s = KickComment(.Content)
					s = RemoveSpaces(s)
					If s = "" Then
						srtFile.RemoveAt(i)
					Else
						srtFile(i) = New Line(s, .Start, .Stop)
					End If
				End With
			Next
			srtFile.SaveSRT(Path.ChangeExtension(fileName, ".deefun.srt"))
			lsFiles.Items(index).SubItems(1).Text = "完成"
		Next

		'结束界面问题
        pgbFile.Value = 100
        pgbFile.Maximum = 100
        lblStatus.Text = "就绪"
        msMain.Enabled = True
        tsMain.Enabled = True
        isRunning = False
    End Sub

    Private Sub 迪幻网DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 迪幻网DToolStripMenuItem.Click
        Shell(String.Format("""{0}{1}Internet Explorer{1}iexplore.exe"" ""http://www.deefun.com/""", My.Computer.FileSystem.SpecialDirectories.ProgramFiles, Path.DirectorySeparatorChar), AppWinStyle.MaximizedFocus, False, -1)
    End Sub

    Private Sub SCC升级SRTUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCC升级SRTUToolStripMenuItem.Click
        Dim frm As New frmSccTransfer
        Me.Hide()
        frm.ShowDialog(Me)
        Me.Show()
    End Sub

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Files = New List(Of LrcFile)

    End Sub

    Private Sub 关于AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于AToolStripMenuItem.Click
        Dim frm As New frmAbout
        frm.ShowDialog(Me)
    End Sub

	Private Sub 如何使用HToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 如何使用HToolStripMenuItem.Click, ToolStripButton5.Click
		Shell(String.Format("""{0}{1}Internet Explorer{1}iexplore.exe"" ""http://www.deefun.com/viewthread.php?tid=10478""", My.Computer.FileSystem.SpecialDirectories.ProgramFiles, Path.DirectorySeparatorChar), AppWinStyle.MaximizedFocus, False, -1)
	End Sub
End Class