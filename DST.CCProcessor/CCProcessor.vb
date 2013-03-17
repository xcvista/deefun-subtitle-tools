Imports System.Text.RegularExpressions

Partial Public Class frmCcReform
    ''' <summary>
    ''' 除注释
    ''' </summary>
	''' <param name="line">字幕内容</param>
	''' <returns>处理后的字幕内容</returns>
    ''' <remarks>感谢 walterclozet 的正则表达式</remarks>
    Public Function KickComment(ByVal line As String) As String
        Dim reg As New Regex("\[.+\]", RegexOptions.IgnoreCase)
        Dim out As String = reg.Replace(line, "")
        Return out
    End Function

	''' <summary>
	''' 除空行
	''' </summary>
	''' <param name="line">字幕内容</param>
	''' <returns>处理后的字幕内容</returns>
	''' <remarks></remarks>
    Public Function RemoveSpaces(ByVal line As String) As String
        Dim lines As String() = line.Split(New Char() {vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries)
        Dim out As String = ""
        For Each l As String In lines
            out += l.Trim + " "
        Next
        Return out.Trim
    End Function
End Class
