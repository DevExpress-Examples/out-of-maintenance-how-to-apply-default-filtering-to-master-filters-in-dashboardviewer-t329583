Imports DevExpress.DashboardCommon
Imports System
Imports System.Linq

Namespace Dashboard_MFDefaultValues
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            dashboardViewer1.UseNeutralFilterMode = True
            AddHandler dashboardViewer1.ConfigureDataConnection, AddressOf DashboardViewer1_ConfigureDataConnection
            AddHandler dashboardViewer1.MasterFilterDefaultValues, AddressOf DashboardViewer1_MasterFilterDefaultValues
            AddHandler dashboardViewer1.RangeFilterDefaultValue, AddressOf DashboardViewer1_RangeFilterDefaultValue

            dashboardViewer1.Dashboard = New Dashboard1()
        End Sub

        Private Sub DashboardViewer1_ConfigureDataConnection(ByVal sender As Object, ByVal e As DashboardConfigureDataConnectionEventArgs)
            Dim connParameters As ExtractDataSourceConnectionParameters = TryCast(e.ConnectionParameters, ExtractDataSourceConnectionParameters)
            connParameters.FileName = "Data\SalesPerson.dat"
        End Sub

        Private Sub DashboardViewer1_MasterFilterDefaultValues(ByVal sender As Object, ByVal e As MasterFilterDefaultValuesEventArgs)
            If e.ItemComponentName = "gridDashboardItem1" Then
                e.FilterValues = e.AvailableFilterValues.Where(Function(v) CStr(v("Sales Person")) = "Laura Callahan")
            End If
            If e.ItemComponentName = "treeViewDashboardItem1" Then
                e.FilterValues = e.AvailableFilterValues.Where(Function(v) CStr(v("Category")) = "Beverages" OrElse CStr(v("Product")) = "Aniseed Syrup")
            End If
        End Sub

        Private Sub DashboardViewer1_RangeFilterDefaultValue(ByVal sender As Object, ByVal e As RangeFilterDefaultValueEventArgs)
            If e.DashboardItemName = "rangeFilterDashboardItem1" Then
                e.Range = New RangeFilterSelection(New Date(2015, 06, 01), New Date(2016, 04, 01))
            End If
        End Sub
    End Class
End Namespace
