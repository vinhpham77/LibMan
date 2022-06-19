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
        public static void CreateReturned(int loanID, DateTime date, double fee)
        {
            ReturnedDAL.CreateReturned(loanID, date, fee);
        }

        public static double GetFee(DateTime loanDate, DateTime dueDate, DateTime returnedDate)
        {
            int numOfReturnedDays = (returnedDate - loanDate).Days;
            int numOfLateDays = (returnedDate - dueDate).Days;
            double fee;
            const float LATE_FEE = 5000; 
            const float DAY_M_FEE = 2000;
            const float DAY_OVERM_FEE = 4000;
            const byte DAYS_OF_WEEK = 7;
            const byte DAYS_OF_MONTH = 30;

            if (numOfReturnedDays <= DAYS_OF_WEEK)
            { 
                fee = 0;
            }
            else if (numOfReturnedDays <= DAYS_OF_MONTH)
            {
                fee = (numOfReturnedDays - DAYS_OF_WEEK) * DAY_M_FEE;
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
                throw new Exception("Vui lòng điền ngày trả sách!");
            }

            DateTime returned = Convert.ToDateTime(returnedDate);
            DateTime loan = Convert.ToDateTime(loanDate);
            if (returned < loan)
            {
                throw new Exception("Ngày trả không thể trước ngày mượn!");
            }
            DateTime due = Convert.ToDateTime(dueDate);
            Hashtable fields = new Hashtable
            {
                { "username", username },
                { "loanID", Convert.ToInt32(loanID) },
                { "loanDate", loan },
                { "dueDate", due },
                { "returnedDate", returned }
            };

            return fields;
        }
    }
}
