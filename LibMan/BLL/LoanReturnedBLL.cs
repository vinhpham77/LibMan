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
        public static List<LoanReturnedDTO> GetLoanReturneds(string username)
        {
            return LoanReturnedDAL.GetLoanReturneds(username);
        }
    }

}
