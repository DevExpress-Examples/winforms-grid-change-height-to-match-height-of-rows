Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace GridControlAutoSize
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			SkinManager.EnableFormSkins()
			Application.Run(New MainForm())
		End Sub
	End Class
End Namespace