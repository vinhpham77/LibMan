using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoanReturnedDAL
    {
        public static List<LoanReturnedDTO> GetLoanReturnedList(string username = "")
        {
            List<LoanReturnedDTO> lrs = new List<LoanReturnedDTO>();
            
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = from l in context.Loans
                            join r in context.Returneds on l.ID equals r.LoanID into lReturned
                            from lr in lReturned.DefaultIfEmpty()
                            where l.Username.Equals(username)
                            select new { l.ID, l.Username, l.BookID, l.LoanDate, l.DueDate, lr.Date, lr.Fine };

                if (string.IsNullOrEmpty(username))
                {
                    query = from l in context.Loans
                            join r in context.Returneds on l.ID equals r.LoanID into lReturned
                            from lr in lReturned.DefaultIfEmpty()
                            select new { l.ID, l.Username, l.BookID, l.LoanDate, l.DueDate, lr.Date, lr.Fine };
                }

                
                foreach (var row in query)
                {
                    LoanReturnedDTO loanReturned = new LoanReturnedDTO()
                    {
                        LoanID = row.ID,
                        Username = row.Username,
                        BookID = row.BookID,
                        LoanDate = row.LoanDate,
                        DueDate = row.DueDate,
                        ReturnedDate = (DateTime?)row.Date,
                        Fine = row.Fine
                    };

                    lrs.Add(loanReturned);
                }

                return lrs;
            }
        }

        public static List<LoanReturnedDTO> GetNotReturnedList()
        {
            List<LoanReturnedDTO> lrs = new List<LoanReturnedDTO>();

            using (LibManDataContext context = new LibManDataContext())
            {
                var query = from l in context.Loans
                        join r in context.Returneds on l.ID equals r.LoanID into lReturned
                        from lr in lReturned.DefaultIfEmpty()
                        where lr.Date == null
                        select new { l.ID, l.Username, l.BookID, l.LoanDate, l.DueDate, lr.Date, lr.Fine };

                foreach (var row in query)
                {
                    LoanReturnedDTO loanReturned = new LoanReturnedDTO()
                    {
                        LoanID = row.ID,
                        Username = row.Username,
                        BookID = row.BookID,
                        LoanDate = row.LoanDate,
                        DueDate = row.DueDate,
                        ReturnedDate = (DateTime?)row.Date,
                        Fine = row.Fine
                    };

                    lrs.Add(loanReturned);
                }

                return lrs;
            }
        }
    }
}
