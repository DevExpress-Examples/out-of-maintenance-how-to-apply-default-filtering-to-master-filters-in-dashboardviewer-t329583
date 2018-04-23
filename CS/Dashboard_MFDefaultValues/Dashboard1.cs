using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;

namespace Dashboard_MFDefaultValues {
    public partial class Dashboard1 : DevExpress.DashboardCommon.Dashboard {
        public Dashboard1() {
            InitializeComponent();
        }

        private void Dashboard1_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e) {
            if (e.DataSourceName == "SQL Data Source 1") {

                // Gets connection parameters used to establish a connection to the database.
                Access97ConnectionParameters parameters =
                    (Access97ConnectionParameters)e.ConnectionParameters;
                string databasePath = @"..\..\Data\nwind.mdb";

                // Specifies the path to a database file.                    
                parameters.FileName = databasePath;
            }
        }
    }
}
