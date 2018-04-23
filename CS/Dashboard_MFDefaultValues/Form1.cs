using System;
using System.Linq;
using DevExpress.DashboardCommon;

namespace Dashboard_MFDefaultValues {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void dashboardViewer1_MasterFilterDefaultValues(object sender, MasterFilterDefaultValuesEventArgs e) {
            if (e.ItemComponentName == "gridDashboardItem1") {
                e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["Sales Person"] == "Laura Callahan");
            }
            if (e.ItemComponentName == "treeViewDashboardItem1") {
                e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["Category"] == "Beverages" || 
                    (string)v["Product"] == "Aniseed Syrup");
            }
        }

        private void dashboardViewer1_RangeFilterDefaultValue(object sender, RangeFilterDefaultValueEventArgs e) {
            if (e.DashboardItemName == "rangeFilterDashboardItem1") {
                e.Range = new RangeFilterSelection(new DateTime(2015, 06, 01), new DateTime(2016, 04, 01));
            }
        }
    }
}
