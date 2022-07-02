using System;
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

        public static void Validate(string[] fields)
        {
            for (int i = 0; i < fields.Length; i++)
            {
                if (string.IsNullOrEmpty(fields[i]))
                {
                    throw new Exception("Vui lòng cung cấp đầy đủ thông tin!");
                }

                DateTime loan = Convert.ToDateTime(fields[2]);
                DateTime returned = Convert.ToDateTime(fields[4]);

                if (loan > returned)
                {
                    throw new Exception("Ngày trả không thể trước ngày mượn!");
                }
            }
        }
    }
}
