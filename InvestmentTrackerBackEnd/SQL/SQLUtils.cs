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
        public static DataTable ExecuteRead(string storedProcNm, List<SqlParameter> sqlParameters)
        {
            using (SqlConnection sqlcon = new SqlConnection(Constants.DB_CONNECTION_STRING))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcNm, sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sqlParameters.ToArray());

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }

        public static int ExecuteWrite(string storedProcNm, List<SqlParameter> sqlParameters)
        {
            using (SqlConnection sqlcon = new SqlConnection(Constants.DB_CONNECTION_STRING))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcNm, sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sqlParameters.ToArray());

                    sqlcon.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    return rowsAffected;
                }
            }
        }
    }
}
