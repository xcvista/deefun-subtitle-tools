Imports System.IO

Public Module DeefunActiviate
	Public Sub InvokeDeefunSite()
		Shell(String.Format("""{0}{1}Internet Explorer{1}iexplore.exe"" ""http://www.deefun.com/""", My.Computer.FileSystem.SpecialDirectories.ProgramFiles, Path.DirectorySeparatorChar), AppWinStyle.MaximizedFocus, False, -1)
	End Sub
End Module
