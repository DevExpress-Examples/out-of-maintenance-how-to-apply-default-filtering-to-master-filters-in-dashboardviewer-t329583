using System;
using System.Linq;
using DevExpress.DashboardCommon;

namespace Dashboard_MFDefaultValues {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void dashboardViewer1_SingleFilterDefaultValue(object sender, SingleFilterDefaultValueEventArgs e) {
            if (e.DashboardItemName == "gridDashboardItem1") {
                var lauraCallahan = e.GetAvailableSelections().First(v => (string)v["Sales Person"] == "Laura Callahan");
                e.SetFilterValue(lauraCallahan); 
            }
        }

        private void dashboardViewer1_FilterElementDefaultValues(object sender, FilterElementDefaultValuesEventArgs e) {
            if (e.ItemComponentName == "treeViewDashboardItem1") {
                e.FilterValues.Clear();
                var beveragesProducts = e.AvailableFilterValues.Where(v => (string)v["Category"] == "Beverages");
                beveragesProducts.ToList().ForEach(i => e.FilterValues.Add(i));
                e.FilterValues.Add(e.AvailableFilterValues.First(v => (string)v["Product"] == "Aniseed Syrup"));
            }
        }

        private void dashboardViewer1_RangeFilterDefaultValue(object sender, RangeFilterDefaultValueEventArgs e) {
            if (e.DashboardItemName == "rangeFilterDashboardItem1") {
                e.Range = new RangeFilterSelection(new DateTime(2015, 06, 01), new DateTime(2016, 04, 01));
            }
        }
    }
}
