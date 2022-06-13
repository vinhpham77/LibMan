using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ReturnedBLL
    {
        public static Returned GetReturned(int returnIDOrLoanID, bool isLoanID = false)
        {
            return ReturnedDAL.GetReturned(returnIDOrLoanID, isLoanID); 
        }

        public static void CreateReturned(int loanID, DateTime date, double? fee)
        {
            ReturnedDAL.CreateReturned(loanID, date, fee);
        }

        public static double GetFee(DateTime loanDate, DateTime dueDate, DateTime returnedDate)
        {
            int numOfLoanDueDays = (dueDate - loanDate).Days;
            int numOfLateDays = (returnedDate - dueDate).Days;
            double fee;
            const float LATE_FEE = 5000; 
            const float DAY_M_FEE = 2000;
            const float DAY_OVERM_FEE = 4000;
            const byte DAYS_OF_WEEK = 7;
            const byte DAYS_OF_MONTH = 30;

            if (numOfLoanDueDays <= DAYS_OF_WEEK)
            { 
                fee = 0;
            }
            else if (numOfLoanDueDays <= DAYS_OF_MONTH)
            {
                fee = (numOfLoanDueDays - DAYS_OF_WEEK) * DAY_M_FEE;
            }
            else
            {
                fee = (numOfLateDays - DAYS_OF_MONTH) * DAY_OVERM_FEE + (DAYS_OF_MONTH - DAYS_OF_WEEK) * DAY_M_FEE;
            }

            if (numOfLateDays > 0)
            {
                fee += numOfLateDays * LATE_FEE;
            }

            return fee;
        }

        public static Hashtable Validate(string username, string loanID, string loanDate, string dueDate, DateTime? returnedDate)
        {
            username = username.Trim();
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("Vui lòng chọn tài khoản trả sách!");
            }
            if (string.IsNullOrEmpty(loanID))
            {
                throw new Exception("Vui lòng chọn mã dịch vụ mượn sách!");
            }
            if (returnedDate is null)
            {
                throw new Exception("Vui lòng chọn ngày trả sách!");
            }

            CultureInfo vn = new CultureInfo("vi-VN");
            DateTime returned = Convert.ToDateTime(returnedDate, vn);
            DateTime loan = Convert.ToDateTime(loanDate, vn);
            if (returned < loan)
            {
                throw new Exception("Ngày trả không thể trước ngày mượn!");
            }
            DateTime due = Convert.ToDateTime(dueDate, vn);
            Hashtable fields = new Hashtable();
            fields.Add("username", username);
            fields.Add("loanID", Convert.ToInt32(loanID));
            fields.Add("loanDate", loan);
            fields.Add("dueDate", due);
            fields.Add("returnedDate", returned);

            return fields;
        }
    }
}
