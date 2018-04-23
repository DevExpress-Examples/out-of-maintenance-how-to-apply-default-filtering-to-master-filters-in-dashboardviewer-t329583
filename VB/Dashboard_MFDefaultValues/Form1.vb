Imports System
Imports System.Linq
Imports DevExpress.DashboardCommon

Namespace Dashboard_MFDefaultValues
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub dashboardViewer1_MasterFilterDefaultValues(ByVal sender As Object,
                                                               ByVal e As MasterFilterDefaultValuesEventArgs) _
                                                           Handles dashboardViewer1.MasterFilterDefaultValues
            If e.ItemComponentName = "gridDashboardItem1" Then
                e.FilterValues = e.AvailableFilterValues.Where(Function(v) CStr(v("Sales Person")) = "Laura Callahan")
            End If
            If e.ItemComponentName = "treeViewDashboardItem1" Then
                e.FilterValues = e.AvailableFilterValues.Where(Function(v) CStr(v("Category")) = "Beverages" _
                                                                   OrElse CStr(v("Product")) = "Aniseed Syrup")
            End If
        End Sub

        Private Sub dashboardViewer1_RangeFilterDefaultValue(ByVal sender As Object,
                                                             ByVal e As RangeFilterDefaultValueEventArgs) _
                                                         Handles dashboardViewer1.RangeFilterDefaultValue
            If e.DashboardItemName = "rangeFilterDashboardItem1" Then
                e.Range = New RangeFilterSelection(New Date(2015, 6, 1), New Date(2016, 4, 1))
            End If
        End Sub
    End Class
End Namespace
