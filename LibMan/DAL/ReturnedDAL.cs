using System;
using DTO;

namespace DAL
{
    public class ReturnedDAL
    {
        public static void CreateReturned(int loanID, DateTime date, double fee)
        {
            using (var context = new LibManDataContext())
            {
                Returned returned = new Returned()
                {
                    LoanID = loanID,
                    Date = date,
                    Fee = fee
                };

                context.Returneds.InsertOnSubmit(returned);
                context.SubmitChanges();
            }
        }
    }
}
