using DevExpress.DashboardCommon;
using System;
using System.Linq;

namespace Dashboard_MFDefaultValues
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            dashboardViewer1.ConfigureDataConnection += DashboardViewer1_ConfigureDataConnection;
            dashboardViewer1.MasterFilterDefaultValues += DashboardViewer1_MasterFilterDefaultValues;
            dashboardViewer1.RangeFilterDefaultValue += DashboardViewer1_RangeFilterDefaultValue;
        }

        private void DashboardViewer1_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e)
        {
            ExtractDataSourceConnectionParameters connParameters = e.ConnectionParameters as ExtractDataSourceConnectionParameters;
            connParameters.FileName = "Data\\SalesPerson.dat";
        }

        private void DashboardViewer1_MasterFilterDefaultValues(object sender, MasterFilterDefaultValuesEventArgs e) {
            if (e.ItemComponentName == "gridDashboardItem1") {
                e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["Sales Person"] == "Laura Callahan");
            }
            if (e.ItemComponentName == "treeViewDashboardItem1") {
                e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["Category"] == "Beverages" || 
                    (string)v["Product"] == "Aniseed Syrup");
            }
        }

        private void DashboardViewer1_RangeFilterDefaultValue(object sender, RangeFilterDefaultValueEventArgs e) {
            if (e.DashboardItemName == "rangeFilterDashboardItem1") {
                e.Range = new RangeFilterSelection(new DateTime(2015, 06, 01), new DateTime(2016, 04, 01));
            }
        }
    }
}
