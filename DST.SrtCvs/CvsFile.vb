Imports myPlayer.LrcReader
Imports System.IO

Public Class CvsFile
	Inherits List(Of CvsSubtitle)

	Protected moriginaFile As LrcFile

	Public Sub New(ByVal originalFile As LrcFile)
		MyBase.new()
		moriginaFile = originalFile
	End Sub

	Protected Sub New()
		MyBase.New()
	End Sub

	Public Property OriginalFile
		Get
			Return moriginaFile
		End Get
		Set(ByVal value)
			moriginaFile = value
		End Set
	End Property

	Public Shared Function LoadSTCX(ByVal stream As Stream) As CvsFile
		Dim stcx As New CvsFile
		Dim sr As New BinaryReader(stream)
		Dim buf() As Byte
		Dim bfl As Integer
		If sr.ReadInt64 <> &H30351A2759114CD8L Then
			sr.Close()
			Throw New ArgumentException("File not STCX")
		End If
		bfl = sr.ReadInt32
		buf = sr.ReadBytes(bfl)
		Dim ms As New MemoryStream(buf)
		stcx.moriginaFile = LrcFile.LoadSRT(ms)
		Dim vcount As Integer = sr.ReadInt32
		For i As Integer = 1 To vcount
			stcx.Add(CvsSubtitle.LoadFromStream(stream))
		Next
		sr.Close()
		stcx.Sort()
		ms.Dispose()
		Return stcx
	End Function

	Public Sub WriteSTCX(ByVal stream As Stream)
		Dim sw As New BinaryWriter(stream)
		sw.Write(&H30351A2759114CD8L)
		Dim ms As New MemoryStream()
		moriginaFile.SaveSRT(ms)
		Dim buf As Byte() = ms.GetBuffer
		ms.Dispose()
		sw.Write(buf.Length)
		sw.Write(buf)
		sw.Write(Me.Count)
		For Each ver As CvsSubtitle In Me
			ver.SaveCvss(stream)
		Next
		sw.Close()
	End Sub
End Class
