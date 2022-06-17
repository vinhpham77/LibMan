using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookCatalogDTO
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public int? CatalogID { get; set; }
        public string CatalogName { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public BookCatalogDTO(Book book, Catalog catalog)
        {
            BookID = book.ID;
            BookTitle = book.Title;
            CatalogID = book.CatalogID;
            CatalogName = catalog.Name;
            Author = book.Author;
            Publisher = book.Publisher;
        }
    }
}
