Namespace GridControlAutoSize

    Partial Class MainForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New GridControlAutoSize.nwindDataSet()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShippedDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipVia = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFreight = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipCity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipRegion = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ordersTableAdapter = New GridControlAutoSize.nwindDataSetTableAdapters.OrdersTableAdapter()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ordersBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.ordersBindingSource
            Me.gridControl1.EmbeddedNavigator.Name = ""
            Me.gridControl1.Location = New System.Drawing.Point(12, 12)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(400, 200)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' ordersBindingSource
            ' 
            Me.ordersBindingSource.DataMember = "Orders"
            Me.ordersBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID, Me.colCustomerID, Me.colEmployeeID, Me.colOrderDate, Me.colRequiredDate, Me.colShippedDate, Me.colShipVia, Me.colFreight, Me.colShipName, Me.colShipAddress, Me.colShipCity, Me.colShipRegion, Me.colShipPostalCode, Me.colShipCountry})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ColumnAutoWidth = False
            ' 
            ' colOrderID
            ' 
            Me.colOrderID.Caption = "Order ID"
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.Visible = True
            Me.colOrderID.VisibleIndex = 0
            ' 
            ' colCustomerID
            ' 
            Me.colCustomerID.Caption = "Customer ID"
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            ' 
            ' colEmployeeID
            ' 
            Me.colEmployeeID.Caption = "Employee ID"
            Me.colEmployeeID.FieldName = "EmployeeID"
            Me.colEmployeeID.Name = "colEmployeeID"
            ' 
            ' colOrderDate
            ' 
            Me.colOrderDate.Caption = "Order Date"
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            ' 
            ' colRequiredDate
            ' 
            Me.colRequiredDate.Caption = "Required Date"
            Me.colRequiredDate.FieldName = "RequiredDate"
            Me.colRequiredDate.Name = "colRequiredDate"
            ' 
            ' colShippedDate
            ' 
            Me.colShippedDate.Caption = "Shipped Date"
            Me.colShippedDate.FieldName = "ShippedDate"
            Me.colShippedDate.Name = "colShippedDate"
            ' 
            ' colShipVia
            ' 
            Me.colShipVia.Caption = "Ship Via"
            Me.colShipVia.FieldName = "ShipVia"
            Me.colShipVia.Name = "colShipVia"
            ' 
            ' colFreight
            ' 
            Me.colFreight.Caption = "Freight"
            Me.colFreight.FieldName = "Freight"
            Me.colFreight.Name = "colFreight"
            ' 
            ' colShipName
            ' 
            Me.colShipName.Caption = "Ship Name"
            Me.colShipName.FieldName = "ShipName"
            Me.colShipName.Name = "colShipName"
            ' 
            ' colShipAddress
            ' 
            Me.colShipAddress.Caption = "Ship Address"
            Me.colShipAddress.FieldName = "ShipAddress"
            Me.colShipAddress.Name = "colShipAddress"
            ' 
            ' colShipCity
            ' 
            Me.colShipCity.Caption = "Ship City"
            Me.colShipCity.FieldName = "ShipCity"
            Me.colShipCity.Name = "colShipCity"
            ' 
            ' colShipRegion
            ' 
            Me.colShipRegion.Caption = "Ship Region"
            Me.colShipRegion.FieldName = "ShipRegion"
            Me.colShipRegion.Name = "colShipRegion"
            ' 
            ' colShipPostalCode
            ' 
            Me.colShipPostalCode.Caption = "Ship Postal Code"
            Me.colShipPostalCode.FieldName = "ShipPostalCode"
            Me.colShipPostalCode.Name = "colShipPostalCode"
            ' 
            ' colShipCountry
            ' 
            Me.colShipCountry.Caption = "Ship Country"
            Me.colShipCountry.FieldName = "ShipCountry"
            Me.colShipCountry.Name = "colShipCountry"
            ' 
            ' ordersTableAdapter
            ' 
            Me.ordersTableAdapter.ClearBeforeFill = True
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1020, 556)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "MainForm"
            Me.Text = "DXSample: GridControl Autosize"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.MainForm_Load)
            AddHandler Me.Shown, New System.EventHandler(AddressOf Me.MainForm_Shown)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ordersBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private nwindDataSet As GridControlAutoSize.nwindDataSet

        Private ordersBindingSource As System.Windows.Forms.BindingSource

        Private ordersTableAdapter As GridControlAutoSize.nwindDataSetTableAdapters.OrdersTableAdapter

        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn

        Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn

        Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colShippedDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipVia As DevExpress.XtraGrid.Columns.GridColumn

        Private colFreight As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipName As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipAddress As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipCity As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipRegion As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipPostalCode As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipCountry As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
