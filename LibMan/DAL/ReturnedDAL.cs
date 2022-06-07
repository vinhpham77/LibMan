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
        public static ReturnedDTO GetReturned(int returnedIDOrLoanID, bool isLoanID = false)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                int field = returnedIDOrLoanID;
                var query = isLoanID ? context.Returneds.Where(r => r.LoanID == field) : context.Returneds.Where(r => r.ID == field);
                Returned returned = query.FirstOrDefault();
                
                return new ReturnedDTO()
                {
                    ID = returned.ID,
                    LoanID = returned.LoanID,
                    Date = returned.Date,
                    Fine = returned.Fine
                };
            }
        }

        public static void CreateReturned(int loanID, DateTime date, double fine)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                Returned returned =new Returned()
                {
                    LoanID = loanID,
                    Date = date,
                    Fine = fine
                };

                context.Returneds.InsertOnSubmit(returned);
            }
        }
    }
}
