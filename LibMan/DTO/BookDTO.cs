using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int? CatalogID { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
    }
}
