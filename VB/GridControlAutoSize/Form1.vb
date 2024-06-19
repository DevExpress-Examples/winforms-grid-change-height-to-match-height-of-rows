Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports System.Reflection
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Scrolling
Imports DevExpress.XtraGrid.Views.Base

Namespace GridControlAutoSize
	Partial Public Class MainForm
		Inherits XtraForm

		Private Const GridMinWidth As Integer = 400
		Private Const GridMinHeight As Integer = 200

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
			Me.ordersTableAdapter.Fill(Me.nwindDataSet.Orders)
			gridView1.ActiveFilterString = "CustomerID = 'ALFKI'"
		End Sub

		Private Sub UpdateGridSize()
			Dim maxSize As New Size(ClientSize.Width, ClientSize.Height)
                        gridControl1.Size = gridControl1.CalcBestSize(maxSize, False)
                        gridControl1.MainView?.LayoutChanged()
                        gridControl1.Size = gridControl1.CalcBestSize(maxSize, True)
                        gridControl1.MainView?.LayoutChanged()
		End Sub

		Private Sub OnGridViewRowCountChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateGridSize()
		End Sub

		Private Sub OnGridViewColumnWidthChanged(ByVal sender As Object, ByVal e As ColumnEventArgs)
			UpdateGridSize()
		End Sub

		Private Sub OnGridViewDragObjectDrop(ByVal sender As Object, ByVal e As DragObjectDropEventArgs)
			UpdateGridSize()
		End Sub

		Private Sub MainForm_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
			AddHandler gridView1.RowCountChanged, AddressOf OnGridViewRowCountChanged
			AddHandler gridView1.ColumnWidthChanged, AddressOf OnGridViewColumnWidthChanged
			AddHandler gridView1.DragObjectDrop, AddressOf OnGridViewDragObjectDrop
			UpdateGridSize()
		End Sub
	End Class
End Namespace
