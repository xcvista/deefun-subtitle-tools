Imports myPlayer.LrcReader
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms
Imports DST.Info

'--------------------------------------
' 迪幻字幕工具 - 剧本处理
' 代码结构类似 CC 处理，不再重复注释
'--------------------------------------

Public Class frmSccTransfer
    Protected isRunning As Boolean
    Protected Worker As Thread

    Private Sub 返回BToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 返回BToolStripMenuItem.Click, ToolStripButton4.Click
        Me.Close()
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        If IsNothing(Worker) Then
            MyBase.OnClosing(e)
            Exit Sub
        End If
        If Worker.ThreadState = ThreadState.Running Then
            e.Cancel = True
        End If
        MyBase.OnClosing(e)
    End Sub

    Private Sub 导入IToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 导入IToolStripMenuItem.Click, ToolStripButton1.Click
        ofdFiles.FileName = ""
        If ofdFiles.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
        For Each file As String In ofdFiles.FileNames
            'Try
            lsFiles.Items.Add(New ListViewItem(New String() {Path.GetFileNameWithoutExtension(file), "挂起", file}))
            'Catch ex As Exception
            'lblStatus.Text = ex.Message
            'Continue For
            'End Try
        Next
    End Sub

    Private Sub lsFiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsFiles.SelectedIndexChanged
        If lsFiles.SelectedIndices.Count <> 0 Then
            删除DToolStripMenuItem.Enabled = True
            ToolStripButton2.Enabled = True
        Else
            删除DToolStripMenuItem.Enabled = False
            ToolStripButton2.Enabled = False
        End If
    End Sub

    Private Sub 删除DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除DToolStripMenuItem.Click, ToolStripButton2.Click
        For index As Integer = lsFiles.SelectedIndices.Count - 1 To 0 Step -1
            lsFiles.Items.RemoveAt(lsFiles.SelectedIndices(index))
        Next
    End Sub

    Private Sub 转换CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 转换CToolStripMenuItem.Click, ToolStripButton3.Click
        Control.CheckForIllegalCrossThreadCalls = False
        isRunning = True

        Worker = New Thread(AddressOf ConvertThread)
        Worker.Start()
    End Sub

    Protected Sub ConvertThread()
        msMain.Enabled = False
        tsMain.Enabled = False
        For Each item As ListViewItem In lsFiles.Items
            If item.SubItems(1).Text = "完成" Then Continue For

            item.SubItems(1).Text = "正在升级"
            Dim fileName As String = item.SubItems(2).Text
            Dim outfileName As String = Path.ChangeExtension(fileName, ".srt")
			Dim srtFile As LrcFile = LrcFile.LoadSCC(fileName)
            srtFile.SaveSRT(outfileName)
            item.SubItems(1).Text = "完成"
        Next
        lblStatus.Text = "就绪"
        msMain.Enabled = True
        tsMain.Enabled = True
        isRunning = False
    End Sub

    Private Sub frmCcReform_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lsFiles.Items.Clear()
    End Sub

    Private Sub 迪幻网DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 迪幻网DToolStripMenuItem.Click
        Shell(String.Format("""{0}{1}Internet Explorer{1}iexplore.exe"" ""http://www.deefun.com/""", My.Computer.FileSystem.SpecialDirectories.ProgramFiles, Path.DirectorySeparatorChar), AppWinStyle.MaximizedFocus, False, -1)
    End Sub

    Private Sub 关于AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于AToolStripMenuItem.Click
        Dim frm As New frmAbout
        frm.ShowDialog(Me)
    End Sub

	Private Sub 如何使用HToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 如何使用HToolStripMenuItem.Click, ToolStripButton5.Click
		Shell(String.Format("""{0}{1}Internet Explorer{1}iexplore.exe"" ""http://www.deefun.com/viewthread.php?tid=10478""", My.Computer.FileSystem.SpecialDirectories.ProgramFiles, Path.DirectorySeparatorChar), AppWinStyle.MaximizedFocus, False, -1)
	End Sub
End Class