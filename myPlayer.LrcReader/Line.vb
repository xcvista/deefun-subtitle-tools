Imports System

Public Structure Line
	Implements IComparable(Of Line)

	Private mContent As String
	Private mStart As TimeSpan
	Private mStop As TimeSpan

	Public Sub New(ByVal content As String, ByVal start As TimeSpan, ByVal [stop] As TimeSpan)
		mContent = content
        If [stop] >= start Then
            mStop = [stop]
            mStart = start
        Else
            Throw New OverflowException("Data overflow")
        End If
	End Sub

	Public Sub New(ByVal start As TimeSpan, ByVal duration As TimeSpan, ByVal content As String)
		mContent = content
		mStart = start
		mStop = start + duration
	End Sub

	Public Sub New(ByVal start As TimeSpan, ByVal [stop] As TimeSpan)
        If [stop] >= start Then
            mStop = [stop]
            mStart = start
        Else
            Throw New OverflowException("Data overflow")
        End If
	End Sub

	Public Property Content As String
		Get
			Return mContent
		End Get
		Set(ByVal value As String)
			mContent = value
		End Set
	End Property

	Public Property Start As TimeSpan
		Get
			Return mStart
		End Get
		Set(ByVal value As TimeSpan)
            If value <= mStop Then
                mStart = value
            Else
                Throw New OverflowException("Data overflow")
            End If
		End Set
	End Property

	Public Property [Stop] As TimeSpan
		Get
			Return mStop
		End Get
		Set(ByVal value As TimeSpan)
            If value >= mStart Then
                mStop = value
            Else
                Throw New OverflowException("Data overflow")
            End If
		End Set
	End Property

	Public ReadOnly Property Duration As TimeSpan
		Get
			Return mStop - mStart
		End Get
	End Property

	Public Function CompareTo(ByVal other As Line) As Integer Implements System.IComparable(Of Line).CompareTo
		Return mStart.CompareTo(other.mStart)
	End Function
End Structure