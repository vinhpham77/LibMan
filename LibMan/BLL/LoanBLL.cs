using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LoanBLL
    {

        public static List<LoanDTO> GetLoans(string username = "")
        {
            return LoanDAL.GetLoans(username);            
        }

        public static LoanDTO GetLoan(int id)
        {
            return LoanDAL.GetLoan(id);
        }

        public static void CreateLoan(string username, int bookID, DateTime loanDate, DateTime dueDate)
        {
            CreateLoan(username, bookID, loanDate, dueDate);
        }
    }
}
