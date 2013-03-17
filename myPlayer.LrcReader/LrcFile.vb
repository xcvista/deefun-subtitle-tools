Imports System
Imports System.Collections.Generic
Imports System.IO

Public Class LrcFile
	Inherits List(Of Line)

	Private mArtist As String
	Private mTitle As String
	Private mAlbum As String
	Private mAuthor As String

	Public Property Artist As String
		Get
			Return mArtist
		End Get
		Set(ByVal value As String)
			mArtist = value
		End Set
	End Property

	Public Property Title As String
		Get
			Return mTitle
		End Get
		Set(ByVal value As String)
			mTitle = value
		End Set
	End Property

	Public Property Album As String
		Get
			Return mAlbum
		End Get
		Set(ByVal value As String)
			mAlbum = value
		End Set
	End Property

	Public Property Author As String
		Get
			Return mAuthor
		End Get
		Set(ByVal value As String)
			mAuthor = value
		End Set
	End Property

	Public Sub New()
		mArtist = ""
		mAlbum = ""
		mTitle = ""
		mAuthor = ""
		Me.Clear()
	End Sub

	Public Sub New(ByVal title As String, ByVal artist As String, ByVal album As String, ByVal author As String, ByVal ParamArray lines As Line())
		Me.AddRange(lines)
		mTitle = title
		mArtist = artist
		mAlbum = album
		mAuthor = author
	End Sub

	Public Sub New(ByVal title As String, ByVal artist As String, ByVal album As String, ByVal ParamArray lines As Line())
		Me.New(title, artist, album, "", lines)
	End Sub

	Public Sub New(ByVal title As String, ByVal artist As String, ByVal ParamArray lines As Line())
		Me.New(title, artist, "", lines)
	End Sub

	Public Sub New(ByVal title As String, ByVal ParamArray lines As Line())
		Me.New(title, "", lines)
	End Sub

	Public Sub New(ByVal ParamArray lines As Line())
		Me.New("", lines)
	End Sub
End Class
