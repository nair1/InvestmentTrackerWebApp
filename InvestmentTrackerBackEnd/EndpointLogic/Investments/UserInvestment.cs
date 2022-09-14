using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace InvestmentTrackerBackEnd
{
    public class UserInvestment
    {
        public static List<UserInvestmentDTO> GetInvestments(string username)
        {
            DataTable resultDataTable;
            const string STORED_PROC_NM = "GetInvestments";
            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@username", username)
            };

            try
            {
                resultDataTable = SQLUtils.ExecuteRead(STORED_PROC_NM, sqlParameters);
            }
            catch (Exception ex)
            {
                throw;
            }

            List<UserInvestmentDTO> investments = new List<UserInvestmentDTO>();

            foreach (DataRow row in resultDataTable.Rows)
            {
                object[] items = row.ItemArray;

                UserInvestmentDTO investment = new UserInvestmentDTO();
                investment.USR_NM = items[0].ToString();
                investment.INVSTMNT_NM = items[1].ToString();
                investment.IS_POSITIVE = bool.Parse(items[2].ToString());
                investment.INVSTMNT_AMT = double.Parse(items[3].ToString());
                investment.INVSTMNT_NOTES = items[4].ToString();
                investment.UPDT_TS = items[5].ToString();

                investments.Add(investment);
            }

            return investments;

        }
    }

    public class UserInvestmentDTO
    {
        public string USR_NM { get; set; }
        public string INVSTMNT_NM { get; set; }
        public bool IS_POSITIVE { get; set; }
        public double INVSTMNT_AMT { get; set; }
        public string INVSTMNT_NOTES { get; set; }
        public string UPDT_TS { get; set; }
    }
}