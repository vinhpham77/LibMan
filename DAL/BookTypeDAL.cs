using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class BookTypeDAL
    {
        public static List<BookTypeDTO> GetBookTypeList()
        {
            List<BookTypeDTO> bookTypes = new List<BookTypeDTO>();

            using (LibManDataContext context = new LibManDataContext())
            {
                var query = from bt in context.BookTypes select bt;
                
                foreach (var row in query)
                {
                    BookTypeDTO bookType = new BookTypeDTO
                    {
                        BookTypeID = row.BookTypeID,
                        BookTypeName = row.BookTypeName
                    };

                    bookTypes.Add(bookType);
                }
            }

            return bookTypes;
        }

        public static void AddBookType(string bookTypeName)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                BookType bookType = new BookType
                {
                    BookTypeName = bookTypeName
                };

                context.BookTypes.InsertOnSubmit(bookType);
                context.SubmitChanges();
            }
        }

        public static bool DeleteBookType(int bookTypeID)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = from bt in context.BookTypes where bt.BookTypeID == bookTypeID select bt;
                BookType bookType = query.FirstOrDefault();
                
                if (bookType is null)
                {
                    return false;
                }
                else
                {
                    context.BookTypes.DeleteOnSubmit(bookType);
                    context.SubmitChanges();
                    return true;
                }
            }
        }

        public static BookType GetBookType(int bookTypeID)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = from bt in context.BookTypes where bt.BookTypeID == bookTypeID select bt;
                return query.FirstOrDefault();
            }
        }

        public static BookType GetBookType(string bookTypeName)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = from bt in context.BookTypes where bt.BookTypeName == bookTypeName select bt;
                return query.FirstOrDefault();
            }
        }
    }
}
