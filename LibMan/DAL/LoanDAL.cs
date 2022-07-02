using System;
using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class LoanDAL
    {
        public static List<LoanDTO> GetLoans(string username = "")
        {
            var loans = new List<LoanDTO>();
            using (var context = new LibManDataContext())
            {
                var query = string.IsNullOrEmpty(username) 
                            ? context.Loans 
                            : context.Loans.Where(l => l.Username.Contains(username));

                LoanDTO loan;
                foreach (var row in query)
                {
                    loan = new LoanDTO()
                    {
                        ID = row.ID,
                        Username = row.Username,
                        BookID = row.BookID,
                        DueDate = row.DueDate,
                        LoanDate = row.LoanDate
                    };

                    loans.Add(loan);
                }
                
                return loans;
            }
        }

        public static Loan GetLoan(int id)
        {
            using (var context = new LibManDataContext())
            {
                return context.Loans.FirstOrDefault(l => l.ID == id);
            }
        }

        public static void CreateLoan(string username, int bookID, DateTime loanDate, DateTime dueDate)
        {
            using (var context = new LibManDataContext())
            {
                Loan loan = new Loan()
                {
                    Username = username,
                    BookID = bookID,
                    LoanDate = loanDate,
                    DueDate = dueDate
                };

                context.Loans.InsertOnSubmit(loan);
                context.SubmitChanges();
            }
        }

        public static void DeleteLoan(int loanID)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                Loan loan = context.Loans.FirstOrDefault(l => l.ID == loanID);

                if (loan is null)
                {
                    throw new Exception($"Không tồn tại dịch vụ mã '{loanID}' trong hệ thống!");
                }
                else
                {
                    context.Loans.DeleteOnSubmit(loan);
                    context.SubmitChanges();
                }
            }
        }
    }
}
