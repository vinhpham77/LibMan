using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Globalization;

namespace BLL
{
    public class LoanBLL
    {

        public static List<LoanDTO> GetLoanList(string username = "")
        {
            return LoanDAL.GetLoanList(username);            
        }

        public static Loan GetLoan(int id)
        {
            return LoanDAL.GetLoan(id);
        }

        public static string LoanBook(string username, int bookID, string loanDate, string dueDate)
        {
            username = username.Trim();
            loanDate = loanDate.Trim();
            dueDate = dueDate.Trim();
            Account acc = AccountBLL.GetAccount(username);
            Book book = BookBLL.GetBook(bookID);

            string message = null;
            if (book is null)
            {
                message = "Không tồn tại sách này trong hệ thống!";
            }
            else if (string.IsNullOrEmpty(username))
            {
                message = "Vui lòng không để trống tên đăng nhập!";
            }
            else if (acc is null)
            {
                message = "Không tồn tại tài khoản này trong hệ thống!";
            }
            else if (acc.Status == false)
            {
                message = "Tài khoản bị vô hiệu!";
            }
            else if (string.IsNullOrEmpty(loanDate))
            {
                return "Vui lòng nhập ngày mượn!";
            }
            else if (string.IsNullOrEmpty(dueDate))
            {
                return "Vui lòng nhập ngày trả!";
            }
            else
            {
                CultureInfo vn = new CultureInfo("vi-VN");
                DateTime loan = Convert.ToDateTime(loanDate, vn);
                DateTime due = Convert.ToDateTime(dueDate, vn);
                
                if (loan.CompareTo(due) > 0)
                {
                    return "Ngày mượn không thể sau ngày hẹn trả!";
                }
                else
                {
                    CreateLoan(username, bookID, loan, due);
                }
            }

            return message;
        }

        public static void CreateLoan(string username, int bookID, DateTime loanDate, DateTime dueDate)
        {
            LoanDAL.CreateLoan(username, bookID, loanDate, dueDate);
        }
    }
}
