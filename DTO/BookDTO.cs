using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookDTO
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public int? BookTypeID { get; set; }
        public string Authors { get; set; }
        public string Publisher { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
