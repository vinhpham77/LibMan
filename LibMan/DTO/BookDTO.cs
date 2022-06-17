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

        public BookDTO(int iD, string title, int catalogID, string author, string publisher)
        {
            ID = iD;
            Title = title;
            CatalogID = catalogID;
            Author = author;
            Publisher = publisher;
        }

        public BookDTO(Book book)
        {
            ID = book.ID;
            Title = book.Title;
            CatalogID = book.CatalogID;
            Author = book.Author;
            Publisher = book.Publisher;
        }
    }
}
