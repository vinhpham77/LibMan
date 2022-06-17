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
        public static List<BookCatalogDTO> GetBookCatalogList(string bookTitle = "")
        {
            return BookCatalogDAL.GetBookCatalogList(bookTitle.Trim());
        }
    }
}
