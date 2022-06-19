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
        public double? Fee { get; set; }
    }
}
