<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128626098/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1811)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

<!-- default file list end -->
# WinForms Data Grid - How to change the grid's height according to the total height of its rows

This example shows how to dynamically change the height of the grid to match the total height of the visible rows.

The `GridView.GetViewInfo` method is used to obtain the `GridViewInfo` object that contains information about grid UI elements (including the size). Note that this method is hidden from IntelliSense.

# Files to Review

* [Form1.cs](./CS/GridControlAutoSize/Form1.cs) (VB: [Form1.vb](./VB/GridControlAutoSize/Form1.vb))
