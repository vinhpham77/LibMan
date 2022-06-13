using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoanDTO
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public int BookID { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }

        public LoanDTO(int id, string username, int bookID, DateTime loanDate, DateTime dueDate)
        {
            ID = id;
            Username = username;
            BookID = bookID;
            LoanDate = loanDate;
            DueDate = dueDate;
        }

        public LoanDTO(Loan loan)
        {
            ID = loan.ID;
            Username = loan.Username;
            BookID = loan.BookID;
            DueDate = loan.DueDate;
        }
    }
}
