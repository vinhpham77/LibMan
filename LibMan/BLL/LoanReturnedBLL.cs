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
            username = username.Trim();
            return LoanReturnedDAL.GetLoanReturnedList(username);
        }
        
        public static List<LoanReturnedDTO> GetNotReturnedList()
        {
            return LoanReturnedDAL.GetNotReturnedList();
        }
    }
}
