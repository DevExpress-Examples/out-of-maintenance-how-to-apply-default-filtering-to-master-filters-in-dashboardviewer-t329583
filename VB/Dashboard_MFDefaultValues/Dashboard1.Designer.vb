Namespace Dashboard_MFDefaultValues

    Partial Class Dashboard1

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

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim gridDimensionColumn1 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim gridMeasureColumn1 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim chartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim simpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim simpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim dashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutGroup3 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            Me.treeViewDashboardItem1 = New DevExpress.DashboardCommon.TreeViewDashboardItem()
            Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.rangeFilterDashboardItem1 = New DevExpress.DashboardCommon.RangeFilterDashboardItem()
            Me.dashboardExtractDataSource1 = New DevExpress.DashboardCommon.DashboardExtractDataSource()
            CType((Me.gridDashboardItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((measure1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.treeViewDashboardItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chartDashboardItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((measure2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rangeFilterDashboardItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((measure3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dashboardExtractDataSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' gridDashboardItem1
            ' 
            dimension1.DataMember = "Sales Person"
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridDimensionColumn1.AddDataItem("Dimension", dimension1)
            measure1.DataMember = "Extended Price"
            gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridMeasureColumn1.AddDataItem("Measure", measure1)
            Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() {gridDimensionColumn1, gridMeasureColumn1})
            Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
            Me.gridDashboardItem1.DataItemRepository.Clear()
            Me.gridDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
            Me.gridDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
            Me.gridDashboardItem1.DataMember = ""
            Me.gridDashboardItem1.DataSource = Me.dashboardExtractDataSource1
            Me.gridDashboardItem1.GridOptions.ColumnWidthMode = DevExpress.DashboardCommon.GridColumnWidthMode.Manual
            Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.gridDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.[Single]
            Me.gridDashboardItem1.Name = "Grid 1"
            Me.gridDashboardItem1.ShowCaption = False
            ' 
            ' treeViewDashboardItem1
            ' 
            Me.treeViewDashboardItem1.ComponentName = "treeViewDashboardItem1"
            dimension2.DataMember = "CategoryName"
            dimension2.Name = "Category"
            dimension3.DataMember = "ProductName"
            dimension3.Name = "Product"
            Me.treeViewDashboardItem1.DataItemRepository.Clear()
            Me.treeViewDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0")
            Me.treeViewDashboardItem1.DataItemRepository.Add(dimension3, "DataItem1")
            Me.treeViewDashboardItem1.DataMember = ""
            Me.treeViewDashboardItem1.DataSource = Me.dashboardExtractDataSource1
            Me.treeViewDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {dimension2, dimension3})
            Me.treeViewDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.treeViewDashboardItem1.Name = "Category"
            Me.treeViewDashboardItem1.ShowCaption = True
            ' 
            ' chartDashboardItem1
            ' 
            dimension4.DataMember = "CategoryName"
            Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {dimension4})
            Me.chartDashboardItem1.AxisX.TitleVisible = False
            Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
            dimension5.DataMember = "OrderDate"
            measure2.DataMember = "Extended Price"
            Me.chartDashboardItem1.DataItemRepository.Clear()
            Me.chartDashboardItem1.DataItemRepository.Add(dimension5, "DataItem3")
            Me.chartDashboardItem1.DataItemRepository.Add(measure2, "DataItem0")
            Me.chartDashboardItem1.DataItemRepository.Add(dimension4, "DataItem1")
            Me.chartDashboardItem1.DataMember = ""
            Me.chartDashboardItem1.DataSource = Me.dashboardExtractDataSource1
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
            chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {simpleSeries1})
            Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {chartPane1})
            Me.chartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {dimension5})
            Me.chartDashboardItem1.ShowCaption = True
            ' 
            ' rangeFilterDashboardItem1
            ' 
            dimension6.DataMember = "OrderDate"
            dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.rangeFilterDashboardItem1.Argument = dimension6
            Me.rangeFilterDashboardItem1.ComponentName = "rangeFilterDashboardItem1"
            measure3.DataMember = "Extended Price"
            Me.rangeFilterDashboardItem1.DataItemRepository.Clear()
            Me.rangeFilterDashboardItem1.DataItemRepository.Add(dimension6, "DataItem0")
            Me.rangeFilterDashboardItem1.DataItemRepository.Add(measure3, "DataItem1")
            Me.rangeFilterDashboardItem1.DataMember = ""
            Me.rangeFilterDashboardItem1.DataSource = Me.dashboardExtractDataSource1
            Me.rangeFilterDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.rangeFilterDashboardItem1.Name = "Range Filter 1"
            simpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Area
            simpleSeries2.AddDataItem("Value", measure3)
            Me.rangeFilterDashboardItem1.Series.AddRange(New DevExpress.DashboardCommon.SimpleSeries() {simpleSeries2})
            Me.rangeFilterDashboardItem1.ShowCaption = False
            ' 
            ' dashboardExtractDataSource1
            ' 
            Me.dashboardExtractDataSource1.ComponentName = "dashboardExtractDataSource1"
            Me.dashboardExtractDataSource1.FileName = "C:\Data\SalesPerson.dat"
            Me.dashboardExtractDataSource1.Name = "Extract Data Source 1"
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.dashboardExtractDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.gridDashboardItem1, Me.treeViewDashboardItem1, Me.chartDashboardItem1, Me.rangeFilterDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.gridDashboardItem1
            dashboardLayoutItem1.Weight = 50R
            dashboardLayoutItem2.DashboardItem = Me.treeViewDashboardItem1
            dashboardLayoutItem2.Weight = 50R
            dashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {dashboardLayoutItem1, dashboardLayoutItem2})
            dashboardLayoutGroup3.DashboardItem = Nothing
            dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            dashboardLayoutGroup3.Weight = 28.895184135977338R
            dashboardLayoutItem3.DashboardItem = Me.chartDashboardItem1
            dashboardLayoutItem3.Weight = 71.104815864022669R
            dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {dashboardLayoutGroup3, dashboardLayoutItem3})
            dashboardLayoutGroup2.DashboardItem = Nothing
            dashboardLayoutGroup2.Weight = 79.935275080906152R
            dashboardLayoutItem4.DashboardItem = Me.rangeFilterDashboardItem1
            dashboardLayoutItem4.Weight = 20.064724919093852R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {dashboardLayoutGroup2, dashboardLayoutItem4})
            dashboardLayoutGroup1.DashboardItem = Nothing
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            AddHandler Me.ConfigureDataConnection, New DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventHandler(AddressOf Me.Dashboard1_ConfigureDataConnection)
            CType((dimension1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((measure1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridDashboardItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((dimension2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((dimension3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.treeViewDashboardItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((dimension4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((dimension5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((measure2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartDashboardItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((dimension6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((measure3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rangeFilterDashboardItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dashboardExtractDataSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem

        Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem

        Private rangeFilterDashboardItem1 As DevExpress.DashboardCommon.RangeFilterDashboardItem

        Private treeViewDashboardItem1 As DevExpress.DashboardCommon.TreeViewDashboardItem

        Private dashboardExtractDataSource1 As DevExpress.DashboardCommon.DashboardExtractDataSource
    End Class
End Namespace
