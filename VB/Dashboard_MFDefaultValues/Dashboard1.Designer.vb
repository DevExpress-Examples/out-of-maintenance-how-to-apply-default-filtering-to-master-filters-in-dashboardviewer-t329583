Namespace Dashboard_MFDefaultValues
    Partial Public Class Dashboard1
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
            Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim measure1 As New DevExpress.DashboardCommon.Measure()
            Dim gridMeasureColumn1 As New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo9 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo10 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo11 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo12 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
            Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
            Dim measure2 As New DevExpress.DashboardCommon.Measure()
            Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
            Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
            Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
            Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
            Dim measure3 As New DevExpress.DashboardCommon.Measure()
            Dim simpleSeries2 As New DevExpress.DashboardCommon.SimpleSeries()
            Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension6 As New DevExpress.DashboardCommon.Dimension()
            Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutGroup3 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem4 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.rangeFilterDashboardItem1 = New DevExpress.DashboardCommon.RangeFilterDashboardItem()
            Me.treeViewDashboardItem1 = New DevExpress.DashboardCommon.TreeViewDashboardItem()
            DirectCast(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.rangeFilterDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.treeViewDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' gridDashboardItem1
            ' 
            dimension1.DataMember = "Sales Person"
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridDimensionColumn1.AddDataItem("Dimension", dimension1)
            measure1.DataMember = "Extended Price"
            measure1.Name = "Extended Price"
            gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridMeasureColumn1.AddDataItem("Measure", measure1)
            Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1, gridMeasureColumn1})
            Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
            Me.gridDashboardItem1.DataItemRepository.Clear()
            Me.gridDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
            Me.gridDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
            Me.gridDashboardItem1.DataMember = "SalesPerson"
            Me.gridDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.gridDashboardItem1.GridOptions.ColumnWidthMode = DevExpress.DashboardCommon.GridColumnWidthMode.Manual
            Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.gridDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single
            Me.gridDashboardItem1.Name = "Grid 1"
            Me.gridDashboardItem1.ShowCaption = False
            ' 
            ' dashboardSqlDataSource1
            ' 
            Me.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1"
            Me.dashboardSqlDataSource1.ConnectionName = "nwind"
            Me.dashboardSqlDataSource1.Name = "SQL Data Source 1"
            tableQuery1.Name = "SalesPerson"
            tableInfo1.Name = "SalesPerson"
            columnInfo1.Name = "OrderID"
            columnInfo2.Name = "Country"
            columnInfo3.Name = "FirstName"
            columnInfo4.Name = "LastName"
            columnInfo5.Name = "ProductName"
            columnInfo6.Name = "CategoryName"
            columnInfo7.Name = "OrderDate"
            columnInfo8.Name = "UnitPrice"
            columnInfo9.Name = "Quantity"
            columnInfo10.Name = "Discount"
            columnInfo11.Name = "Extended Price"
            columnInfo12.Name = "Sales Person"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5, columnInfo6, columnInfo7, columnInfo8, columnInfo9, columnInfo10, columnInfo11, columnInfo12})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
            Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
            Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
            ' 
            ' chartDashboardItem1
            ' 
            dimension2.DataMember = "CategoryName"
            Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
            Me.chartDashboardItem1.AxisX.TitleVisible = False
            Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
            measure2.DataMember = "Extended Price"
            measure2.Name = "Extended Price"
            dimension3.DataMember = "OrderDate"
            Me.chartDashboardItem1.DataItemRepository.Clear()
            Me.chartDashboardItem1.DataItemRepository.Add(measure2, "DataItem1")
            Me.chartDashboardItem1.DataItemRepository.Add(dimension2, "DataItem2")
            Me.chartDashboardItem1.DataItemRepository.Add(dimension3, "DataItem3")
            Me.chartDashboardItem1.DataMember = "SalesPerson"
            Me.chartDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.chartDashboardItem1.Name = "Sales by Catgory"
            chartPane1.Name = "Pane 1"
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            chartPane1.PrimaryAxisY.ShowGridLines = True
            chartPane1.PrimaryAxisY.TitleVisible = True
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            chartPane1.SecondaryAxisY.ShowGridLines = False
            chartPane1.SecondaryAxisY.TitleVisible = True
            simpleSeries1.AddDataItem("Value", measure2)
            chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
            Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
            Me.chartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
            Me.chartDashboardItem1.ShowCaption = True
            ' 
            ' rangeFilterDashboardItem1
            ' 
            dimension4.DataMember = "OrderDate"
            dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.rangeFilterDashboardItem1.Argument = dimension4
            Me.rangeFilterDashboardItem1.ComponentName = "rangeFilterDashboardItem1"
            measure3.DataMember = "Extended Price"
            measure3.Name = "Extended Price"
            Me.rangeFilterDashboardItem1.DataItemRepository.Clear()
            Me.rangeFilterDashboardItem1.DataItemRepository.Add(dimension4, "DataItem0")
            Me.rangeFilterDashboardItem1.DataItemRepository.Add(measure3, "DataItem1")
            Me.rangeFilterDashboardItem1.DataMember = "SalesPerson"
            Me.rangeFilterDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.rangeFilterDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.rangeFilterDashboardItem1.Name = "Range Filter 1"
            simpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Area
            simpleSeries2.AddDataItem("Value", measure3)
            Me.rangeFilterDashboardItem1.Series.AddRange(New DevExpress.DashboardCommon.SimpleSeries() { simpleSeries2})
            Me.rangeFilterDashboardItem1.ShowCaption = False
            ' 
            ' treeViewDashboardItem1
            ' 
            Me.treeViewDashboardItem1.ComponentName = "treeViewDashboardItem1"
            dimension5.DataMember = "CategoryName"
            dimension5.Name = "Category"
            dimension6.DataMember = "ProductName"
            dimension6.Name = "Product"
            Me.treeViewDashboardItem1.DataItemRepository.Clear()
            Me.treeViewDashboardItem1.DataItemRepository.Add(dimension5, "DataItem0")
            Me.treeViewDashboardItem1.DataItemRepository.Add(dimension6, "DataItem1")
            Me.treeViewDashboardItem1.DataMember = "SalesPerson"
            Me.treeViewDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.treeViewDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension5, dimension6})
            Me.treeViewDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.treeViewDashboardItem1.Name = "Category"
            Me.treeViewDashboardItem1.ShowCaption = True
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.gridDashboardItem1, Me.treeViewDashboardItem1, Me.chartDashboardItem1, Me.rangeFilterDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.gridDashboardItem1
            dashboardLayoutItem1.Weight = 50R
            dashboardLayoutItem2.DashboardItem = Me.treeViewDashboardItem1
            dashboardLayoutItem2.Weight = 50R
            dashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
            dashboardLayoutGroup3.DashboardItem = Nothing
            dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            dashboardLayoutGroup3.Weight = 28.895184135977338R
            dashboardLayoutItem3.DashboardItem = Me.chartDashboardItem1
            dashboardLayoutItem3.Weight = 71.104815864022669R
            dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup3, dashboardLayoutItem3})
            dashboardLayoutGroup2.DashboardItem = Nothing
            dashboardLayoutGroup2.Weight = 79.935275080906152R
            dashboardLayoutItem4.DashboardItem = Me.rangeFilterDashboardItem1
            dashboardLayoutItem4.Weight = 20.064724919093852R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutItem4})
            dashboardLayoutGroup1.DashboardItem = Nothing
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.rangeFilterDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.treeViewDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
        Private dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Private rangeFilterDashboardItem1 As DevExpress.DashboardCommon.RangeFilterDashboardItem
        Private treeViewDashboardItem1 As DevExpress.DashboardCommon.TreeViewDashboardItem
    End Class
End Namespace
