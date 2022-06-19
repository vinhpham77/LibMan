using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class LoanReturnedBookBLL
    {
        public static List<LoanReturnedBookDTO> GetLoanReturnedList(string keywords = "")
        {
            return LoanReturnedBookDAL.GetLoanReturnedList(keywords.Trim());
        }
        

        public static List<string> GetUsernamesNotReturned()
        {
            return LoanReturnedBookDAL.GetUsernamesNotReturned();
        }

        public static List<int> GetLoanIDsNotReturned(string username = "")
        {
            return LoanReturnedBookDAL.GetLoanIDsNotReturned(username.Trim());
            //return loanIDs.ConvertAll<string>(lID => lID.ToString());
        }
    }
}
