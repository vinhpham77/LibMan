using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ReturnedDAL
    {
        public static Returned GetReturned(int returnedIDOrLoanID, bool isLoanID = false)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                int field = returnedIDOrLoanID;
                var query = isLoanID ? context.Returneds.Where(r => r.LoanID == field) : context.Returneds.Where(r => r.ID == field);
                
                return query.FirstOrDefault();
            }
        }

        public static void CreateReturned(int loanID, DateTime date, double? fee)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                Returned returned = new Returned()
                {
                    LoanID = loanID,
                    Date = date,
                    Fine = fee
                };

                context.Returneds.InsertOnSubmit(returned);
                context.SubmitChanges();
            }
        }

        public static void DeleteReturned(int loanID)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                Returned returned = context.Returneds.Where(r => r.LoanID == loanID).FirstOrDefault();
                if (returned != null)
                {
                    context.Returneds.DeleteOnSubmit(returned);
                    context.SubmitChanges();
                }
            }
        }
    }
}
