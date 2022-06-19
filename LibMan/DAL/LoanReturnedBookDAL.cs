using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoanReturnedBookDAL
    {
        public static List<LoanReturnedBookDTO> GetLoanReturnedList(string keywords = "")
        {
            List<LoanReturnedBookDTO> lrs = new List<LoanReturnedBookDTO>();
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = string.IsNullOrEmpty(keywords)
                            ? from l in context.Loans
                              join b in context.Books on l.BookID equals b.ID 
                              join r in context.Returneds on l.ID equals r.LoanID into lReturned
                              from lr in lReturned.DefaultIfEmpty()
                              select new { l.ID, l.Username, l.BookID, b.Title, l.LoanDate, l.DueDate, lr.Date, lr.Fee }
                            : from l in context.Loans
                              join b in context.Books on l.BookID equals b.ID 
                              join r in context.Returneds on l.ID equals r.LoanID into lReturned
                              from lr in lReturned.DefaultIfEmpty()
                              where l.Username.Contains(keywords)
                              select new { l.ID, l.Username, l.BookID, b.Title, l.LoanDate, l.DueDate, lr.Date, lr.Fee };

                foreach (var row in query)
                {
                    LoanReturnedBookDTO loanReturned = new LoanReturnedBookDTO()
                    {
                        LoanID = row.ID,
                        Username = row.Username,
                        BookID = row.BookID,
                        BookTitle = row.Title,
                        LoanDate = row.LoanDate,
                        DueDate = row.DueDate,
                        ReturnedDate = row.Date,
                        Fee = row.Fee
                    };
                    lrs.Add(loanReturned);
                }

                return lrs;
            }
        }

        public static List<string> GetUsernamesNotReturned()
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = from l in context.Loans
                            join r in context.Returneds on l.ID equals r.LoanID into lReturned
                            from lr in lReturned.DefaultIfEmpty()
                            where lr.Date == null
                            select l.Username;

                return query.Distinct().ToList();
            }
        }

        public static List<int> GetLoanIDsNotReturned(string username = "")
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = from l in context.Loans
                            join r in context.Returneds on l.ID equals r.LoanID into lReturned
                            from lr in lReturned.DefaultIfEmpty()
                            where lr.Date == null && l.Username == username
                            select l.ID ;

                return query.ToList();
            }
        }
    }
}
