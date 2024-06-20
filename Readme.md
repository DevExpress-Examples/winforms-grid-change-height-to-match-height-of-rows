<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128626098/24.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1811)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - How to change the grid's height according to the total height of its rows

This example dynamically changes the height of the grid to match the total height of the visible rows.

The [GridControl.CalcBestSize](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl.CalcBestSize(System.Drawing.Size-System.Boolean)) method calculates the maximum allowable size of the Grid Control (to display as many data rows and columns as possible).

# Files to Review

* [Form1.cs](./CS/GridControlAutoSize/Form1.cs) (VB: [Form1.vb](./VB/GridControlAutoSize/Form1.vb))
