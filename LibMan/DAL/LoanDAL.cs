﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoanDAL
    {
        public static List<LoanDTO> GetLoanList(string username = "")
        {
            List<LoanDTO> list = new List<LoanDTO>();
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = string.IsNullOrEmpty(username) 
                            ? context.Loans 
                            : context.Loans.Where(l => l.Username.Contains(username));

                LoanDTO loan;
                foreach (var row in query)
                {
                    loan = new LoanDTO()
                    {
                        ID = row.ID,
                        Username = row.Username,
                        BookID = row.BookID,
                        DueDate = row.DueDate,
                        LoanDate = row.LoanDate
                    };
                    list.Add(loan);
                }
                
                return list;
            }
        }

        public static Loan GetLoan(int id)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                return context.Loans.Where(l => l.ID == id).FirstOrDefault();
            }
        }

        public static void CreateLoan(string username, int bookID, DateTime loanDate, DateTime dueDate)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                Loan loan = new Loan()
                {
                    Username = username,
                    BookID = bookID,
                    LoanDate = loanDate,
                    DueDate = dueDate
                };

                context.Loans.InsertOnSubmit(loan);
                context.SubmitChanges();
            }
        }

        public static void DeleteLoan(int loanID)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                Loan loan = context.Loans.Where(l => l.ID == loanID).FirstOrDefault();

                if (loan is null)
                {
                    throw new Exception($"Không tồn tại dịch vụ mã '{loanID}' trong hệ thống!");
                }
                else
                {
                    context.Loans.DeleteOnSubmit(loan);
                    context.SubmitChanges();
                }
            }
        }
    }
}
