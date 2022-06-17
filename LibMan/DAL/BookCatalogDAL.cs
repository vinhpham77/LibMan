using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class BookCatalogDAL
    {
        public static List<BookCatalogDTO> GetBookCatalogList(string bookTitle = "")
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = from b in context.Books 
                            join c in context.Catalogs on b.CatalogID equals c.ID into bc
                            from bookcat in bc.DefaultIfEmpty()
                            where b.Title.Contains(bookTitle) select new BookCatalogDTO(b, bookcat);
                return query.ToList();
            }
        }
    }
}
