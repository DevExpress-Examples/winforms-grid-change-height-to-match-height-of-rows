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
             Size maxSize = new Size(ClientSize.Width, ClientSize.Height);
             gridControl1.Size = gridControl1.CalcBestSize(maxSize, false);
             gridControl1.MainView?.LayoutChanged();
             gridControl1.Size = gridControl1.CalcBestSize(maxSize, true);
             gridControl1.MainView?.LayoutChanged();
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
