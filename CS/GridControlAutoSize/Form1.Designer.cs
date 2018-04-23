namespace GridControlAutoSize {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new GridControlAutoSize.nwindDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShippedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipVia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ordersTableAdapter = new GridControlAutoSize.nwindDataSetTableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.ordersBindingSource;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderID,
            this.colCustomerID,
            this.colEmployeeID,
            this.colOrderDate,
            this.colRequiredDate,
            this.colShippedDate,
            this.colShipVia,
            this.colFreight,
            this.colShipName,
            this.colShipAddress,
            this.colShipCity,
            this.colShipRegion,
            this.colShipPostalCode,
            this.colShipCountry});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colOrderID
            // 
            this.colOrderID.Caption = "Order ID";
            this.colOrderID.FieldName = "OrderID";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.Visible = true;
            this.colOrderID.VisibleIndex = 0;
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "Customer ID";
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "Employee ID";
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "Order Date";
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            // 
            // colRequiredDate
            // 
            this.colRequiredDate.Caption = "Required Date";
            this.colRequiredDate.FieldName = "RequiredDate";
            this.colRequiredDate.Name = "colRequiredDate";
            // 
            // colShippedDate
            // 
            this.colShippedDate.Caption = "Shipped Date";
            this.colShippedDate.FieldName = "ShippedDate";
            this.colShippedDate.Name = "colShippedDate";
            // 
            // colShipVia
            // 
            this.colShipVia.Caption = "Ship Via";
            this.colShipVia.FieldName = "ShipVia";
            this.colShipVia.Name = "colShipVia";
            // 
            // colFreight
            // 
            this.colFreight.Caption = "Freight";
            this.colFreight.FieldName = "Freight";
            this.colFreight.Name = "colFreight";
            // 
            // colShipName
            // 
            this.colShipName.Caption = "Ship Name";
            this.colShipName.FieldName = "ShipName";
            this.colShipName.Name = "colShipName";
            // 
            // colShipAddress
            // 
            this.colShipAddress.Caption = "Ship Address";
            this.colShipAddress.FieldName = "ShipAddress";
            this.colShipAddress.Name = "colShipAddress";
            // 
            // colShipCity
            // 
            this.colShipCity.Caption = "Ship City";
            this.colShipCity.FieldName = "ShipCity";
            this.colShipCity.Name = "colShipCity";
            // 
            // colShipRegion
            // 
            this.colShipRegion.Caption = "Ship Region";
            this.colShipRegion.FieldName = "ShipRegion";
            this.colShipRegion.Name = "colShipRegion";
            // 
            // colShipPostalCode
            // 
            this.colShipPostalCode.Caption = "Ship Postal Code";
            this.colShipPostalCode.FieldName = "ShipPostalCode";
            this.colShipPostalCode.Name = "colShipPostalCode";
            // 
            // colShipCountry
            // 
            this.colShipCountry.Caption = "Ship Country";
            this.colShipCountry.FieldName = "ShipCountry";
            this.colShipCountry.Name = "colShipCountry";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 556);
            this.Controls.Add(this.gridControl1);
            this.Name = "MainForm";
            this.Text = "DXSample: GridControl Autosize";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private GridControlAutoSize.nwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredDate;
        private DevExpress.XtraGrid.Columns.GridColumn colShippedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colShipVia;
        private DevExpress.XtraGrid.Columns.GridColumn colFreight;
        private DevExpress.XtraGrid.Columns.GridColumn colShipName;
        private DevExpress.XtraGrid.Columns.GridColumn colShipAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colShipCity;
        private DevExpress.XtraGrid.Columns.GridColumn colShipRegion;
        private DevExpress.XtraGrid.Columns.GridColumn colShipPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colShipCountry;

    }
}

