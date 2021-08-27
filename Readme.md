<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128550062/15.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T323440)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [NorthwindDataProvider.cs](./CS/Models/NorthwindDataProvider.cs) (VB: [NorthwindDataProvider.vb](./VB/Models/NorthwindDataProvider.vb))
* [Product.cs](./CS/Models/Product.cs) (VB: [Product.vb](./VB/Models/Product.vb))
* [ChartPartial.cshtml](./CS/Views/Home/ChartPartial.cshtml)
* [GridViewPartial.cshtml](./CS/Views/Home/GridViewPartial.cshtml)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to filter Chart data based on the grid filter
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t323440/)**
<!-- run online end -->


<p>This example illustrates how to display only those data rows in the <a href="https://documentation.devexpress.com/#AspNet/CustomDocument9972">Chart</a> extension, which are displayed in the <a href="https://documentation.devexpress.com/#AspNet/CustomDocument8998">GridView</a> extension according to its current filter state (e.g., see <a href="http://demos.devexpress.com/MVCxGridViewDemos/Filtering/FilterRow">Filter Row - ASP.NET MVC Extensions - Grid View Demo</a>). Unlike the approach illustrated in the <a href="https://www.devexpress.com/Support/Center/p/T177863">T177863 - ASPxGridView - How to make WebChartControl display only data that is visible in grid</a> code example (for the WebForms platform), we use filtering at the database level to display data in a Chart. Note that the sorting order is not retained in this scenario, but the performance is much better for large data sources. The key idea here is to use the <strong>CriteriaToWhereClauseHelper</strong> class method to convert the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridView_FilterExpressiontopic">ASPxGridView.FilterExpression</a> property value to the database-specific filter query. Please review the <a href="https://www.devexpress.com/Support/Center/p/K18434">K18434 - How to convert the CriteriaOperator to the corresponding filter string in order to use it for building SQL queries or for filtering the DataView</a> and <a href="https://www.devexpress.com/Support/Center/p/A2921">A2921 - How to get a list of the data rows in a filtered grid</a> KB articles to learn more on this subject.</p>

<br/>


