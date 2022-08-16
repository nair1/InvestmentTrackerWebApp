using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace InvestmentTrackerBackEnd
{
    public class UserSignup
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //public bool IsValidUsername()
        //{
        //    DataTable resultDataTable;
        //    const string STORED_PROC_NM = "GetNumberOfUsersWithSpecifiedUsername";
        //    List<SqlParameter> sqlParameters = new List<SqlParameter>
        //    {
        //        new SqlParameter("@username", this.Username)
        //    };

        //    try
        //    {
        //        resultDataTable = SQLUtils.ExecuteRead(STORED_PROC_NM, sqlParameters);
        //    } catch (Exception ex)
        //    {
        //        throw;
        //    }

        //    return (int)resultDataTable.Rows[0].ItemArray[0] == 0;
        //}

        public bool Signup()
        {
            int rowsAffected;
            const string STORED_PROC_NM = "SignupUser";
            List<SqlParameter> sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@first_name", this.FirstName),
                new SqlParameter("@last_name", this.LastName),
                new SqlParameter("@email", this.Email),
                new SqlParameter("@username", this.Username),
                new SqlParameter("@password", HashPassword(this.Password))
            };

            try
            {
                rowsAffected = SQLUtils.ExecuteWrite(STORED_PROC_NM, sqlParameters);
            } catch (Exception ex)
            {
                throw;
            }

            return rowsAffected == 1;
        }

        public static string HashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            return savedPasswordHash;
        }
    }

    public class UserSignupDTO
    {
        public string USR_NM { get; set; }
        public string PSS_WRD { get; set; }
        public string FRST_NM { get; set; }
        public string LST_NM { get; set; }
        public string EMAIL { get; set; }

    }
}
