using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoanDAL
    {
        public static List<LoanDTO> GetLoans(string username = "")
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                List<LoanDTO> loans = new List<LoanDTO>();
                var query = string.IsNullOrEmpty(username) ? context.Loans : context.Loans.Where(l => l.Username == username);

                foreach (var row in query)
                {
                    LoanDTO loan = new LoanDTO()
                    {
                        ID = row.ID,
                        Username = row.Username,
                        BookID = row.BookID,
                        LoanDate = row.LoanDate,
                        DueDate = row.DueDate
                    };

                    loans.Add(loan);
                }

                return loans;
            }
        }

        public static LoanDTO GetLoan(int id)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                Loan loan = context.Loans.Where(l => l.ID == id).FirstOrDefault();
                
                return new LoanDTO()
                {
                    ID = loan.ID,
                    Username = loan.Username,
                    BookID = loan.BookID,
                    LoanDate = loan.LoanDate,
                    DueDate = loan.DueDate
                };
            }
        }

        public static void CreateLoan(string username, int bookID, DateTime loanDate, DateTime dueDate)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                Loan loan = new Loan()
                {
                    Username = username,
                    BookID = bookID,
                    LoanDate = loanDate,
                    DueDate = dueDate
                };

                context.Loans.InsertOnSubmit(loan);
            }
        }
    }
}
