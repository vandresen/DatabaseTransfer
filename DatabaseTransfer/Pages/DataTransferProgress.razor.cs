using DatabaseTransfer.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTransfer.Pages
{
    public partial class DataTransferProgress
    {
        public string BarLabel = "0%";
        private string BarWidth = "0%";

        private void StartDatabaseTransfer()
        {
            string sourceCnStr = @"Data Source=DESKTOP-PAGHL5S;Initial Catalog=PDO_Test_Database;Integrated Security=SSPI";
            string destCnStr = @"Data Source=DESKTOP-PAGHL5S;Initial Catalog=PPDM_TEST8;Integrated Security=SSPI";
            DeleteProjectTables(destCnStr);
            BarLabel = "100% Complete";
            BarWidth = "100%";
        }

        private void DeleteProjectTables(string cnStr)
        {
            string table;
            Trace.TraceInformation("DeleteProjectTables: Start ");
            DbUtilities dbConn = new DbUtilities();
            dbConn.OpenConnection(cnStr);

            //Delete tables in destination
            //table = "WELL_LOG_CURVE_VALUE";
            //dbConn.DBDelete(table);
            //Clients.Caller.sendMessage("2%", "2%");
            //table = "WELL_LOG_CURVE";
            //dbConn.DBDelete(table);
            //Clients.Caller.sendMessage("3%", "3%");
            //table = "STRAT_WELL_SECTION";
            //dbConn.DBDelete(table);
            //Clients.Caller.sendMessage("4%", "4%");
            //table = "STRAT_UNIT";
            //dbConn.DBDelete(table);
            //table = "STRAT_NAME_SET";
            //dbConn.DBDelete(table);
            //Clients.Caller.sendMessage("5%", "5%");
            //table = "WELL";
            //dbConn.DBDelete(table);
            //table = "BUSINESS_ASSOCIATE";
            //dbConn.DBDelete(table);
            //table = "FIELD";
            //dbConn.DBDelete(table);
            //table = "R_WELL_DATUM_TYPE";
            //dbConn.DBDelete(table);
            //table = "R_WELL_STATUS";
            //dbConn.DBDelete(table);
            //Clients.Caller.sendMessage("9%", "9%");

            dbConn.CloseConnection();
            Trace.TraceInformation("DeleteProjectTables: End ");
        }
    }
}
