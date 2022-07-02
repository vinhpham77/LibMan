using System.Collections.Generic;
using DTO;
using DAL;
using System.Collections.ObjectModel;

namespace BLL
{
    public class LoanReturnedBookBLL
    {
        public static ObservableCollection<LoanReturnedBookDTO> GetLoanReturneds(string keywords = "")
        {
            return LoanReturnedBookDAL.GetLoanReturneds(keywords);
        }
        
        public static List<string> GetUsernamesNotReturned()
        {
            return LoanReturnedBookDAL.GetUsernamesNotReturned();
        }

        public static List<int> GetLoanIDsNotReturned(string username)
        {
            return LoanReturnedBookDAL.GetLoanIDsNotReturned(username);
        }
    }
}
