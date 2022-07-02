using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class BookDAL
    {
        public static List<BookDTO> GetBooks(string title = "")
        {
            var list = new List<BookDTO>();
            using (var context = new LibManDataContext())
            {
                var query = context.Books.Where(b => b.Title.Contains(title));
                BookDTO book;

                foreach (var row in query)
                {
                    book = new BookDTO()
                    {
                        ID = row.ID,
                        Title = row.Title,
                        Author = row.Author,
                        CatalogID = row.CatalogID,
                        Publisher = row.Publisher
                    };
                }

                return list;
            }
        }

        public static void AddBook(string title, int? catalogID, string author, string publisher)
        {
            using(var context = new LibManDataContext())
            {
                Book book = new Book
                {
                    Title = title,
                    CatalogID = catalogID,
                    Author = author,
                    Publisher = publisher,
                };

                context.Books.InsertOnSubmit(book);
                context.SubmitChanges();
            }
        }

        public static void UpdateBook(int id, string title, int? catalogID, string author, string publisher)
        {
            using (var context = new LibManDataContext())
            {
                var book = context.Books.FirstOrDefault(b => b.ID == id);
                
                if (book is null)
                {
                    throw new Exception($"Không tồn tại sách mã '{id}' trong hệ thống!");
                }
                else
                {
                    book.Title = title;
                    book.CatalogID = catalogID;
                    book.Author = author;
                    book.Publisher = publisher;
                    
                    context.SubmitChanges();
                }
            }
        }

        public static Book GetBook(int id)
        {
            using (var context = new LibManDataContext())
            {
                return context.Books.FirstOrDefault(b => b.ID == id);
            }
        }

        public static void DeleteBook(int id)
        {
            using (var context = new LibManDataContext())
            {
                var book = context.Books.FirstOrDefault(b => b.ID == id);

                if (book is null)
                {
                    throw new Exception($"Không tồn tại sách mã '{id}' trong hệ thống!");
                }
                else
                {
                    context.Books.DeleteOnSubmit(book);
                    context.SubmitChanges();
                }
            }
        }
    }
}
