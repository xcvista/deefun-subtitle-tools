Imports System
Imports System.Collections.Generic
Imports System.IO

Partial Public Class LrcFile
	Public Sub SaveLRC(ByVal fileName As String)
		SaveLRC(New FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
	End Sub

	Public Sub SaveLRC(ByVal stream As Stream)
		Dim sw As New StreamWriter(stream)

		If mTitle <> "" Then sw.WriteLine("[ti:{0}]", mTitle.Trim)
		If mArtist <> "" Then sw.WriteLine("[ar:{0}]", mArtist.Trim)
		If mAlbum <> "" Then sw.WriteLine("[al:{0}]", mAlbum.Trim)
		If mAuthor <> "" Then sw.WriteLine("[by:{0}]", mAuthor.Trim)
		sw.WriteLine()
		For Each l As Line In Me
			sw.WriteLine("[{0:00}:{1:00}.{2:00}]{3}", l.Start.Minutes, l.Start.Seconds, l.Start.Milliseconds \ 10, l.Content.Trim)
		Next
		sw.Close()
	End Sub

	Public Sub SaveSRT(ByVal fileName As String)
		SaveSRT(New FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
	End Sub

	Public Sub SaveSRT(ByVal stream As Stream)
		Dim sw As New StreamWriter(stream)
		Dim i As Integer = 1

		For Each l As Line In Me
			sw.WriteLine(i)
			sw.WriteLine("{0:00}:{1:00}:{2:00},{3:000} --> {4:00}:{5:00}:{6:00},{7:000}", l.Start.Hours, l.Start.Minutes, l.Start.Seconds, l.Start.Milliseconds, l.Stop.Hours, l.Stop.Minutes, l.Stop.Seconds, l.Stop.Milliseconds)
			sw.WriteLine(l.Content.Trim)
			sw.WriteLine()
			i += 1
		Next
		sw.Close()
	End Sub

	Public Shared Function LoadLRC(ByVal fileName As String) As LrcFile
		Return LoadLRC(New FileStream(fileName, FileMode.Open, FileAccess.Read))
	End Function

	Public Shared Function LoadLRC(ByVal stream As Stream) As LrcFile
		Dim lf As New LrcFile
		Dim sr As New StreamReader(stream)
		Dim currLine As Line
		Dim isBody As Boolean = False
		Dim str As String

		Do Until sr.EndOfStream
			str = sr.ReadLine.Trim
			If isBody Then
				'Check if it is a line beginning
				If str Like "[??:??.??]*" Then
					'New lines
					Dim times As New List(Of TimeSpan)
					Do While str Like "[??:??.??]*"
						Dim linets As New TimeSpan(0, 0, CInt(Mid(str, 2, 2)), CInt(Mid(str, 5, 2)), CInt(Mid(str, 8, 2)) * 10)
						times.Add(linets)
						str = str.Remove(0, 10)
					Loop
					For Each tt As TimeSpan In times
						currLine = New Line(tt, New TimeSpan(0, 0, 0, 0, 10), str.Trim)
						lf.Add(currLine)
					Next
				End If
			Else
				'Check if it is a tag
				If str Like "[??:*]" Then
					Select Case LCase(Mid(str, 2, 2))
						Case "al"
							'Album
							lf.mAlbum = Mid(str, 5, str.Length - 5).Trim
						Case "ar"
							'Artist
							lf.mArtist = Mid(str, 5, str.Length - 5).Trim
						Case "ti"
							'Title
							lf.mTitle = Mid(str, 5, str.Length - 5).Trim
						Case "by"
							'Author
							lf.mAuthor = Mid(str, 5, str.Length - 5).Trim
						Case Else
							'Abandon the tag
					End Select
				Else
					'It is body part
					isBody = True
					If str Like "[??:??.??]*" Then
						'New lines
						Dim times As New List(Of TimeSpan)
						Do While str Like "[??:??.??]*"
							Dim linets As New TimeSpan(0, 0, CInt(Mid(str, 2, 2)), CInt(Mid(str, 5, 2)), CInt(Mid(str, 8, 2)) * 10)
							times.Add(linets)
							str = str.Remove(0, 10)
						Loop
						For Each tt As TimeSpan In times
							currLine = New Line(tt, New TimeSpan(0, 0, 0, 0, 10), str.Trim)
							lf.Add(currLine)
						Next
					End If
				End If
			End If
		Loop
		sr.Close()

		'Reverse loop: ending tags
		lf.Sort()
		Dim etg As TimeSpan = lf(lf.Count - 1).Start
		For i As Integer = lf.Count - 2 To 0 Step -1
			Dim l As Line = lf(i)
			'etg -= New TimeSpan(0, 0, 0, 0, 10)
			l.Stop = etg
			etg = l.Start
			lf(i) = l
		Next
		Return lf
	End Function

	Public Shared Function LoadSRT(ByVal fileName As String) As LrcFile
		Return LoadSRT(New FileStream(fileName, FileMode.Open, FileAccess.Read))
	End Function

	Public Shared Function LoadSRT(ByVal stream As Stream) As LrcFile
		Dim lf As New LrcFile
		Dim sr As New StreamReader(stream)
		Dim currLine As Line
		Dim isBody As Boolean = False
		Dim phase As Integer = 0
		Dim str As String

		Do Until sr.EndOfStream
			str = Trim(sr.ReadLine)
			If Trim(CStr(CInt(Val(str)))) = str Then
				'New line
				If isBody And Not IsNothing(currLine) Then
					currLine.Content = currLine.Content.Trim
					lf.Add(currLine)
				End If
				isBody = True
				phase = 1
			End If
			Select Case phase
				Case 1
					'Time tag
					If str Like "??:??:??,??? --> ??:??:??,???" Then
						Dim tg1 As New TimeSpan(0, CInt(Mid(str, 1, 2)), CInt(Mid(str, 4, 2)), CInt(Mid(str, 7, 2)), CInt(Mid(str, 10, 3)))
						Dim tg2 As New TimeSpan(0, CInt(Mid(str, 18, 2)), CInt(Mid(str, 21, 2)), CInt(Mid(str, 24, 2)), CInt(Mid(str, 27, 3)))
						currLine = New Line(tg1, tg2)
						phase = 2
					End If
				Case 2
					'Content
					currLine.Content += str.Trim + vbCrLf
			End Select
		Loop
		If Not IsNothing(currLine) Then
			currLine.Content = currLine.Content.Trim
			lf.Add(currLine)
		End If
		sr.Close()
		lf.Sort()
		Return lf
	End Function

	Public Shared Function LoadSCC(ByVal fileName As String) As LrcFile
		Return LoadSCC(New FileStream(fileName, FileMode.Open, FileAccess.Read))
	End Function

	Public Shared Function LoadSCC(ByVal stream As Stream) As LrcFile
		Dim lf As New LrcFile
		Dim sr As New StreamReader(stream)
		Dim currLine As Line
		Dim str As String

		Do Until sr.EndOfStream
			str = sr.ReadLine.Trim
			'Check if it is a line beginning
			If Strings.Left(str, 8) Like "??:??:??" Then
				'New lines
				Dim linets As New TimeSpan(0, CInt(Mid(str, 1, 2)), CInt(Mid(str, 4, 2)), CInt(Mid(str, 7, 2)), 0)
				str = str.Remove(0, 9)
				currLine = New Line(linets, New TimeSpan(0, 0, 0, 0, 10), str.Trim)
				lf.Add(currLine)
			End If
		Loop
		sr.Close()

		'Reverse loop: ending tags
		lf.Sort()
		Dim etg As TimeSpan = lf(lf.Count - 1).Start
		For i As Integer = lf.Count - 2 To 0 Step -1
			Dim l As Line = lf(i)
			'etg -= New TimeSpan(0, 0, 0, 0, 10)
			l.Stop = etg
			etg = l.Start
			lf(i) = l
		Next
		Return lf
	End Function
End Class