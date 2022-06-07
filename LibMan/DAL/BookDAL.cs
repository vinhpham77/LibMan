using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class BookDAL
    {
        public static List<BookDTO> GetBookList(string title = "")
        {
            List<BookDTO> books = new List<BookDTO>();

            using (LibManDataContext context = new LibManDataContext())
            {
                var query = context.Books.Where(b => b.Title.ToLower().Contains(title.ToLower()));
                foreach (var row in query)
                {
                    BookDTO book = new BookDTO()
                    {
                        ID = row.ID,
                        Title = row.Title,
                        Catalog = row.Catalog,
                        Author = row.Author,
                        Publisher = row.Publisher,
                    };

                    books.Add(book);
                }
            }

            return books;
        }

        public static void AddBook(string title, string catalog, string author, string publisher)
        {
            using(LibManDataContext context = new LibManDataContext())
            {
                Book book = new Book
                {
                    Title = title,
                    Catalog = catalog,
                    Author = author,
                    Publisher = publisher,
                };

                context.Books.InsertOnSubmit(book);
                context.SubmitChanges();
            }
        }

        public static bool UpdateBook(int id, string title, string catalog, string author, string publisher)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                var book = context.Books.Where(b => b.ID == id).FirstOrDefault();
                
                if (book is null)
                {
                    return false;
                }
                else
                {
                    book.Title = title;
                    book.Catalog = catalog;
                    book.Author = author;
                    book.Publisher = publisher;
                    
                    context.SubmitChanges();
                    return true;
                }
            }
        }

        public static Book GetBook(int id)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                return context.Books.Where(b => b.ID == id).FirstOrDefault();
            }
        }
    }
}
