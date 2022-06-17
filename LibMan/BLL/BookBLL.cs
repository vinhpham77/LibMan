using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BookBLL
    {
        public static List<BookDTO> GetBookList(string title = "")
        {   
            return BookDAL.GetBookList(title);
        }

        public static void AddBook(string title, int? catalogID, string author, string publisher)
        {
            bool valid = ValidateBook(ref title, ref catalogID, ref author, ref publisher);
            
            if (valid)
            {
                BookDAL.AddBook(title, catalogID, author, publisher);
            } else
            {
                throw new Exception("Vui lòng cung cấp đầy đủ thông tin!");
            }
        }

        public static bool ValidateBook(ref string title, ref int? catalog, ref string author, ref string publisher)
        {
            title = title.Trim();
            if (string.IsNullOrEmpty(title))
            {
                return false;
            }

            if (catalog is null)
            {
                return false;
            }
            author = author.Trim();
            if (string.IsNullOrEmpty(author))
            {
                return false;
            }
            publisher = publisher.Trim();
            if (string.IsNullOrEmpty(publisher))
            {
                return false;
            }

            return true;
        }

        public static BookDTO GetBook(int id)
        {
            return new BookDTO(BookDAL.GetBook(id));
        }

        public static void UpdateBook(int id, string title, int? catalog, string author, string publisher)
        {            
            bool valid = ValidateBook(ref title, ref catalog, ref author, ref publisher);
        
            if (valid)
            {
                BookDAL.UpdateBook(id, title, catalog, author, publisher);
            }
            else
            {
                throw new Exception("Vui lòng cung cấp đầy đủ thông tin!");
            }
        }

        public static void DeleteBook(int bookID)
        {
            BookDAL.DeleteBook(bookID);
        }
    }
}
