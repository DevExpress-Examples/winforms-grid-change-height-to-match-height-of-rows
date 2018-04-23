Imports Microsoft.VisualBasic
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
			Dim viewInfo As GridViewInfo = CType(gridView1.GetViewInfo(), GridViewInfo)
			Dim fi As FieldInfo = GetType(GridView).GetField("scrollInfo", BindingFlags.Instance Or BindingFlags.NonPublic)
			Dim scrollInfo As ScrollInfo = CType(fi.GetValue(gridView1), ScrollInfo)
			Dim width As Integer = viewInfo.ViewRects.IndicatorWidth
			For Each column As GridColumn In gridView1.VisibleColumns
				If viewInfo.GetColumnLeftCoord(column) < viewInfo.ViewRects.ColumnPanelWidth Then
					gridView1.LeftCoord = width
				End If
				width += viewInfo.ColumnsInfo(column).Bounds.Width
			Next column
			If scrollInfo.VScrollVisible Then
				width += scrollInfo.VScrollSize
			End If
			Dim height As Integer = viewInfo.CalcRealViewHeight(New Rectangle(0, 0, ClientSize.Width, ClientSize.Height))
			If scrollInfo.HScrollVisible Then
				height += scrollInfo.HScrollSize
			End If
			width = Math.Max(GridMinWidth, width)
			width = Math.Min(ClientSize.Width - gridControl1.Location.X, width)
			height = Math.Max(GridMinHeight, height)
			height = Math.Min(ClientSize.Height - gridControl1.Location.Y, height)
			gridControl1.Size = New Size(width, height)
			gridView1.LayoutChanged()
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