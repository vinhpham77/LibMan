using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class LoanReturnedBLL
    {
        public static List<LoanReturnedDTO> GetLoanReturnedList(string username = "")
        {
            return LoanReturnedDAL.GetLoanReturnedList(username.Trim());
        }
        
        public static List<LoanReturnedDTO> GetNotReturnedList()
        {
            return LoanReturnedDAL.GetNotReturnedList();
        }

        public static List<string> GetUsernamesNotReturned()
        {
            return LoanReturnedDAL.GetUsernamesNotReturned();
        }

        public static void DeleteLoanReturned(int loanID)
        {
            ReturnedDAL.DeleteReturned(loanID);
            LoanDAL.DeleteLoan(loanID);
        }

        public static List<int> GetLoanIDsNotReturned(string username = "")
        {
            return LoanReturnedDAL.GetLoanIDsNotReturned(username.Trim());
            //return loanIDs.ConvertAll<string>(lID => lID.ToString());
        }
    }
}
