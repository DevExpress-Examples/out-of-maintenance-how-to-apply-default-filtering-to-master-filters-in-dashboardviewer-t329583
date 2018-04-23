Imports System
Imports System.Linq
Imports DevExpress.DashboardCommon

Namespace Dashboard_MFDefaultValues
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub dashboardViewer1_SingleFilterDefaultValue(ByVal sender As Object, _
                                                              ByVal e As SingleFilterDefaultValueEventArgs) _
                                                          Handles dashboardViewer1.SingleFilterDefaultValue
            If e.DashboardItemName = "gridDashboardItem1" Then
                Dim lauraCallahan = e.GetAvailableSelections().First(Function(v) CStr(v("Sales Person")) = "Laura Callahan")
                e.SetFilterValue(lauraCallahan)
            End If
        End Sub

        Private Sub dashboardViewer1_FilterElementDefaultValues(ByVal sender As Object, _
                                                                ByVal e As FilterElementDefaultValuesEventArgs) _
                                                            Handles dashboardViewer1.FilterElementDefaultValues
            If e.ItemComponentName = "treeViewDashboardItem1" Then
                e.FilterValues.Clear()
                Dim beveragesProducts = e.AvailableFilterValues.Where(Function(v) CStr(v("Category")) = "Beverages")
                beveragesProducts.ToList().ForEach(Sub(i) e.FilterValues.Add(i))
                e.FilterValues.Add(e.AvailableFilterValues.First(Function(v) CStr(v("Product")) = "Aniseed Syrup"))
            End If
        End Sub

        Private Sub dashboardViewer1_RangeFilterDefaultValue(ByVal sender As Object, _
                                                             ByVal e As RangeFilterDefaultValueEventArgs) _
                                                         Handles dashboardViewer1.RangeFilterDefaultValue
            If e.DashboardItemName = "rangeFilterDashboardItem1" Then
                e.Range = New RangeFilterSelection(New Date(2015, 6, 1), New Date(2016, 4, 1))
            End If
        End Sub
    End Class
End Namespace
