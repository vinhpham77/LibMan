using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoanReturnedBookDTO
    {
        public int LoanID { get; set; }
        public string Username { get; set; }
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public double? Fee { get; set; }
    }
}
