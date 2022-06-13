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
        public string Catalog { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public BookDTO(int iD, string title, string catalog, string author, string publisher)
        {
            ID = iD;
            Title = title;
            Catalog = catalog;
            Author = author;
            Publisher = publisher;
        }

        public BookDTO(Book book)
        {
            ID = book.ID;
            Title = book.Title;
            Catalog = book.Catalog;
            Author = book.Author;
            Publisher = book.Publisher;
        }
    }
}
