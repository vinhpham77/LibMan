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

        public static bool AddBook(string title, string catalog, string author, string publisher)
        {
            bool valid = ValidateBook(ref title, ref catalog, ref author, ref publisher);
            
            if (valid)
            {
                BookDAL.AddBook(title, catalog, author, publisher);
                return true;
            } else
            {
                return false;
            }
        }

        public static bool ValidateBook(ref string title, ref string catalog, ref string author, ref string publisher)
        {
            title = title.Trim();
            if (string.IsNullOrEmpty(title))
            {
                return false;
            }
            catalog = catalog.Trim();
            if (string.IsNullOrEmpty(catalog))
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

        public static Book GetBook(int id)
        {
            return BookDAL.GetBook(id);
        }

        public static bool UpdateBook(int id, string title, string catalog, string author, string publisher)
        {            
            bool valid = ValidateBook(ref title, ref catalog, ref author, ref publisher);
            if (valid)
            {
                BookDAL.UpdateBook(id, title, catalog, author, publisher);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
