<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/GridControlAutoSize/Form1.cs) (VB: [Form1.vb](./VB/GridControlAutoSize/Form1.vb))
* [Program.cs](./CS/GridControlAutoSize/Program.cs) (VB: [Program.vb](./VB/GridControlAutoSize/Program.vb))
<!-- default file list end -->
# How to change the Grid's height  according to the total height of its rows


<p>The size of each GridView's element is calculated by the GridViewInfo class. The instance of the GridViewInfo class, containing information about a specific GridView instance, can be obtained via the GridView.GetViewInfo method. This method is hidden for IntelliSence,  but is public and can be called from external code.</p>

<br/>


