using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BookCatalogBLL
    {
        public static List<BookCatalogDTO> GetBookCatalogList(string keywords = "")
        {
            return BookCatalogDAL.GetBookCatalogList(keywords.Trim());
        }
    }
}
