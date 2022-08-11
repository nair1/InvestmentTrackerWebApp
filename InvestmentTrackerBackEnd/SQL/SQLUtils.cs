using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace InvestmentTrackerBackEnd
{
    public class SQLUtils
    {
        public static int ExecuteStoredProc(string storedProcNm)
        {
            using (SqlConnection sqlcon = new SqlConnection(Constants.DB_CONNECTION_STRING))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcNm, sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);

                        DataColumnCollection tableColumns = dataTable.Columns;

                        //TODO: Dynamically assign columns to object properties
                    }
                }
            }

            return 0;
        }
    }
}
