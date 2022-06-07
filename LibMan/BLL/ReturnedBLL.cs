using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ReturnedBLL
    {
        public static ReturnedDTO GetReturned(int returnIDOrLoanID, bool isLoanID = false)
        {
            return ReturnedDAL.GetReturned(returnIDOrLoanID, isLoanID); 
        }

        public static void CreateReturned(int loanID, DateTime date, double fine)
        {
            ReturnedDAL.CreateReturned(loanID, date, fine);
        }
    }
}
