using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class BookDAL
    {
        public static List<BookDTO> GetBookList()
        {
            List<BookDTO> books = new List<BookDTO>();

            using (LibManDataContext context = new LibManDataContext())
            {
                var query = from b in context.Books select b;
                foreach (var row in query)
                {
                    BookDTO book = new BookDTO()
                    {
                        BookID = row.BookID,
                        BookName = row.BookName,
                        BookTypeID = row.BookTypeID,
                        Authors = row.Authors,
                        Publisher = row.Publisher,
                        Price = row.Price,
                        Quantity = row.Quantity
                    };

                    books.Add(book);
                }
            }

            return books;
        }

        public static void AddBook(string bookName, int bookTypeID, string authors, string publisher, double price, int quantity)
        {
            using(LibManDataContext context = new LibManDataContext())
            {
                Book book = new Book
                {
                    BookName = bookName,
                    BookTypeID = bookTypeID,
                    Authors = authors,
                    Publisher = publisher,
                    Price = price,
                    Quantity = quantity
                };

                context.Books.InsertOnSubmit(book);
                context.SubmitChanges();
            }
        }

        public static Book GetBook(int bookID)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = from b in context.Books where b.BookID == bookID select b;
                return query.FirstOrDefault();
            }
        }

        
    }
}
