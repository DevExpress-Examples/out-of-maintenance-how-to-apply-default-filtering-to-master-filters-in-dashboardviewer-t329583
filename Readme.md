<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_MFDefaultValues/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_MFDefaultValues/Form1.vb))
<!-- default file list end -->
# How to initialize master filters in Dashboard Viewer


The following example shows how to initialize master filter in a dashboard loaded in the [DashboardViewer](https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWinDashboardViewertopic) control. 

To initialize master filters:

* Handle the [MasterFilterDefaultValues](https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_MasterFilterDefaultValuestopic) event to apply filtering to [Grid](https://documentation.devexpress.com/#Dashboard/CustomDocument15150) and [Tree View](https://documentation.devexpress.com/#Dashboard/CustomDocument17659).
* Handle the [RangeFilterDefaultValue](https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_RangeFilterDefaultValuetopic)</a> event to select the specified date range in the [Range Filter](https://documentation.devexpress.com/#Dashboard/CustomDocument15265).

![](https://github.com/DevExpress-Examples/how-to-apply-default-filtering-to-master-filters-in-dashboardviewer-t329583/blob/18.2.3%2B/images/screenshot.png)