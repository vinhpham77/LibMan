using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class LoanBLL
    {
        public static List<LoanDTO> GetLoans(string username = "")
        {
            return LoanDAL.GetLoans(username);            
        }

        public static Loan GetLoan(int id)
        {
            return LoanDAL.GetLoan(id);
        }

        public static void DeleteLoan(int loanID)
        {
            LoanDAL.DeleteLoan(loanID);
        }

        public static void LoanBook(string username, int bookID, DateTime? loanDate, DateTime? dueDate)
        {
            Account acc = AccountDAL.GetAccount(username);
            Book book = BookBLL.GetBook(bookID);
            
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("Vui lòng không để trống tên đăng nhập!");
            }
            else if (acc is null)
            {
                throw new Exception($"Không tồn tại tên đăng nhập '{username}' trong hệ thống!");
            }
            else if (acc.Status is false)
            {
                throw new Exception("Tài khoản không có hiệu lực!");
            }
            else if (book is null)
            {
                throw new Exception($"Không tồn tại sách mã '{bookID}' trong hệ thống!");
            }
            else if (loanDate is null)
            {
                throw new Exception("Vui lòng nhập ngày mượn!");
            }
            else if (dueDate is null)
            {
                throw new Exception("Vui lòng nhập ngày trả!");
            }
            else
            {
                if (loanDate > dueDate)
                {
                    throw new Exception("Ngày mượn không thể sau ngày hẹn trả!");
                }
                else
                {
                    LoanDAL.CreateLoan(username, bookID, (DateTime)loanDate, (DateTime)dueDate);
                }
            }
        }
    }
}
