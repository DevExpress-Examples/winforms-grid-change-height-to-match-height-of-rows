using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Scrolling;
using DevExpress.XtraGrid.Views.Base;

namespace GridControlAutoSize {
    public partial class MainForm : XtraForm {
        private const int GridMinWidth = 400;
        private const int GridMinHeight = 200;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);
            gridView1.ActiveFilterString = "CustomerID = 'ALFKI'";
        }

        private void UpdateGridSize() {
            GridViewInfo viewInfo = (GridViewInfo)gridView1.GetViewInfo();
            FieldInfo fi = typeof(GridView).GetField("scrollInfo", BindingFlags.Instance | BindingFlags.NonPublic);
            ScrollInfo scrollInfo = (ScrollInfo)fi.GetValue(gridView1);
            int width = viewInfo.ViewRects.IndicatorWidth;
            foreach (GridColumn column in gridView1.VisibleColumns) {
                if (viewInfo.GetColumnLeftCoord(column) < viewInfo.ViewRects.ColumnPanelWidth)
                    gridView1.LeftCoord = width;
                width += viewInfo.ColumnsInfo[column].Bounds.Width;
            }
            if (scrollInfo.VScrollVisible) width += scrollInfo.VScrollSize;
            int height = viewInfo.CalcRealViewHeight(new Rectangle(0, 0, ClientSize.Width, ClientSize.Height), true);
            if (scrollInfo.HScrollVisible) height += scrollInfo.HScrollSize;
            width = Math.Max(GridMinWidth, width);
            width = Math.Min(ClientSize.Width - gridControl1.Location.X, width);
            height = Math.Max(GridMinHeight, height);
            height = Math.Min(ClientSize.Height - gridControl1.Location.Y, height);
            gridControl1.Size = new Size(width, height);
            gridView1.LayoutChanged();
        }

        private void OnGridViewRowCountChanged(object sender, EventArgs e) {
            UpdateGridSize();
        }

        private void OnGridViewColumnWidthChanged(object sender, ColumnEventArgs e) {
            UpdateGridSize();
        }

        private void OnGridViewDragObjectDrop(object sender, DragObjectDropEventArgs e) {
            UpdateGridSize();
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            gridView1.RowCountChanged += new EventHandler(OnGridViewRowCountChanged);
            gridView1.ColumnWidthChanged += new ColumnEventHandler(OnGridViewColumnWidthChanged);
            gridView1.DragObjectDrop += new DragObjectDropEventHandler(OnGridViewDragObjectDrop);
            UpdateGridSize();
        }
    }
}