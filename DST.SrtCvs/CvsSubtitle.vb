Imports myPlayer.LrcReader
Imports System.IO

Public Structure CvsSubtitle
    Implements IComparable(Of CvsSubtitle)

    Private mLrcFile As LrcFile
    Private mversionDate As Date

    Public Sub New(ByVal lrcFile As LrcFile)
        mLrcFile = lrcFile
        mversionDate = Now
	End Sub

    Public Property LrcFile As LrcFile
        Set(ByVal value As LrcFile)
            mLrcFile = value
        End Set
        Get
            Return mLrcFile
        End Get
    End Property

    Public Property VersionDate As Date
        Set(ByVal value As Date)
            mversionDate = value
        End Set
        Get
            Return mversionDate
        End Get
	End Property

	Friend Shared Function LoadFromStream(ByVal stream As Stream) As CvsSubtitle
		Dim cvss As New CvsSubtitle(Nothing)
		Dim br As New BinaryReader(stream)
		Dim spl As Integer
		Dim buf As Byte()
		cvss.mversionDate = New Date(br.ReadInt64)
		spl = br.ReadInt32
		buf = br.ReadBytes(spl)
		Dim ms As New MemoryStream(buf)
		cvss.mLrcFile = LrcFile.LoadSRT(ms)
		ms.Dispose()
		Return cvss
	End Function

	Friend Sub SaveCvss(ByVal stream As Stream)
		Dim bw As New BinaryWriter(stream)
		Dim ms As New MemoryStream()
		bw.Write(mversionDate.Ticks)
		mLrcFile.SaveSRT(MS)
		Dim buf As Byte() = ms.GetBuffer
		bw.Write(buf.Length)
		bw.Write(buf)
		ms.Dispose()
	End Sub

	Public Function CompareTo(ByVal other As CvsSubtitle) As Integer Implements System.IComparable(Of CvsSubtitle).CompareTo
		Return Me.mversionDate.CompareTo(other.mversionDate)
	End Function
End Structure