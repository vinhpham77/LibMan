using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReturnedDTO
    {
        public int ID { get; set; }
        public int LoanID { get; set; }
        public DateTime? Date { get; set; }
        public double? Fine { get; set; }

        public ReturnedDTO(int id, int loanID, DateTime date, double? fine)
        {
            ID = id;
            LoanID = loanID;
            Date = date;
            Fine = fine;
        }

        public ReturnedDTO(Returned rt)
        {
            ID = rt.ID;
            LoanID = rt.LoanID;
            Date = rt.Date;
            Fine = rt.Fine;
        }
    }
}
