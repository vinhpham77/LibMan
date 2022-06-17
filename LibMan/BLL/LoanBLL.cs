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

        public static void LoanBook(string username, int bookID, string loanDate, string dueDate)
        {
            username = username.Trim();
            loanDate = loanDate.Trim();
            dueDate = dueDate.Trim();
            Account acc = AccountDAL.GetAccount(username);
            BookDTO book = BookBLL.GetBook(bookID);

            if (book is null)
            {
                throw new Exception("Không tồn tại sách này trong hệ thống!");
            }
            else if (string.IsNullOrEmpty(username))
            {
                throw new Exception("Vui lòng không để trống tên đăng nhập!");
            }
            else if (acc is null)
            {
                throw new Exception($"Không tồn tại tài khoản '{username}' trong hệ thống!");
            }
            else if (acc.Status == false)
            {
                throw new Exception("Tài khoản bị vô hiệu!");
            }
            else if (book is null)
            {
                throw new Exception($"Không tồn tại sách mã '{bookID}' trong hệ thống!");
            }
            else if (string.IsNullOrEmpty(loanDate))
            {
                throw new Exception("Vui lòng nhập ngày mượn!");
            }
            else if (string.IsNullOrEmpty(dueDate))
            {
                throw new Exception("Vui lòng nhập ngày trả!");
            }
            else
            {
                DateTime loan = Convert.ToDateTime(loanDate);
                DateTime due = Convert.ToDateTime(dueDate);
                
                if (loan.CompareTo(due) > 0)
                {
                    throw new Exception("Ngày mượn không thể sau ngày hẹn trả!");
                }
                else
                {
                    LoanDAL.CreateLoan(username, bookID, loan, due);
                }
            }
        }
    }
}
