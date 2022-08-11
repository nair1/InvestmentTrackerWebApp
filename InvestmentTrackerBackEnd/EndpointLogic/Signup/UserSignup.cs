using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool IsValidUsername()
        {
            const string STORED_PROC_NM = "SelectAllUsers";
            int rowsAffected = SQLUtils.ExecuteStoredProc(STORED_PROC_NM);

            return rowsAffected == 0;
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
