using System;
using DTO;
using DAL;

namespace BLL
{
    public class BookBLL
    {
        public static void AddBook(string title, int? catalogID, string author, string publisher)
        {
            string[] fields = {title, catalogID.ToString(), author, publisher};
            ValidateBook(fields);
            BookDAL.AddBook(fields[0], catalogID, fields[2], fields[3]);
        }

        public static void UpdateBook(int id, string title, int? catalogID, string author, string publisher)
        {
            string[] fields = {title, catalogID.ToString(), author, publisher};
            ValidateBook(fields);
            BookDAL.UpdateBook(id, fields[0], catalogID, fields[2], fields[3]);
        }

        public static void ValidateBook(string[] fields)
        {
            for (int i = 0; i < fields.Length; i++)
            {
                if (string.IsNullOrEmpty(fields[i]))
                {
                    throw new Exception("Vui lòng cung cấp đầy đủ thông tin!");
                }
            }
        }

        public static Book GetBook(int id)
        {
            return BookDAL.GetBook(id);
        }

        public static void DeleteBook(int bookID)
        {
            BookDAL.DeleteBook(bookID);
        }
    }
}
