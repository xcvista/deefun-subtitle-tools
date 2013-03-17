Imports myPlayer.LrcReader

Public Class TranslateEditor
	Private mSrcSub As LrcFile
	Private mDescSub As LrcFile
	Private loc As Integer
	Private mchg As Boolean

	Public Event CurrentChanged As EventHandler

	Public Property Changed As Boolean
		Get
			Return mchg
		End Get
		Set(ByVal value As Boolean)
			mchg = value
		End Set
	End Property

	Public Property Source As LrcFile
		Get
			Return mSrcSub
		End Get
		Set(ByVal value As LrcFile)
			mSrcSub = value
			RefreshUI()
		End Set
	End Property

	Public Property Destinetion As LrcFile
		Get
			Return mDescSub
		End Get
		Set(ByVal value As LrcFile)
			mDescSub = value
			RefreshUI()
		End Set
	End Property

	Public Property Current As Integer
		Get
			Return loc
		End Get
		Set(ByVal value As Integer)
			loc = value
			If mSrcSub.Count = 0 Or mDescSub.Count = 0 Then Exit Property
			If value < 0 Then Throw New ArgumentOutOfRangeException("Index lesser than 0")
			If value > Math.Min(mSrcSub.Count, mDescSub.Count) - 1 Then Throw New ArgumentOutOfRangeException("Index too big")
			RaiseEvent CurrentChanged(Me, New EventArgs)
			RefreshUI()
		End Set
	End Property

	Protected Sub RefreshUI()
		If mSrcSub.Count = 0 Or mDescSub.Count = 0 Then
			Button1.Enabled = False
			Button2.Enabled = False
			txtOriginal.Text = ""
			txtTranslation.Text = ""
			Exit Sub
		End If
		Dim chg As Boolean = mchg
		txtOriginal.Text = mSrcSub(loc).Content
		txtTranslation.Text = mDescSub(loc).Content
		Button1.Enabled = (loc > 0)
		Button2.Enabled = (loc < Math.Min(mSrcSub.Count, mDescSub.Count) - 1)
		mchg = chg
	End Sub

	Public Sub GenerateNewDestinetion()
		mDescSub = New LrcFile
		For Each l As Line In mSrcSub
			l.Content = ""
			mDescSub.Add(l)
		Next
	End Sub

	Public Sub New()

		' 此调用是设计器所必需的。
		InitializeComponent()

		' 在 InitializeComponent() 调用之后添加任何初始化。
		mSrcSub = New LrcFile
		mDescSub = New LrcFile

	End Sub

	Private Sub txtTranslation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTranslation.TextChanged
		If mSrcSub.Count = 0 Or mDescSub.Count = 0 Then Exit Sub
		Dim l As Line = mDescSub(loc)
		l.Content = txtTranslation.Text
		mDescSub(loc) = l
		mchg = True
	End Sub

	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		Current -= 1
	End Sub

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		Current += 1
	End Sub
End Class
