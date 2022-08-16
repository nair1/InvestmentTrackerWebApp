using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace InvestmentTrackerBackEnd
{
    public class UserLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool Login()
        {
            return VerifyPassword(GetHashedLoginPassword());
        }

        public string GetHashedLoginPassword()
        {
            DataTable resultDataTable;
            const string STORED_PROC_NM = "GetHashedLoginPassword";
            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@username", this.Username)
            };

            try
            {
                resultDataTable = SQLUtils.ExecuteRead(STORED_PROC_NM, sqlParameters);
            }
            catch (Exception ex)
            {
                throw;
            }

            return resultDataTable.Rows[0].ItemArray[0].ToString();
        }

        public static bool IsUsernameTaken(string username)
        {
            DataTable resultDataTable;
            const string STORED_PROC_NM = "GetNumberOfUsersWithSpecifiedUsername";
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

            return (int)resultDataTable.Rows[0].ItemArray[0] == 1;
        }

        public bool VerifyPassword(string hashedPassword)
        {
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(this.Password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
