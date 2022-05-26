using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDAL
    {
        public static List<AccountDTO> GetAccountList()
        {
            List<AccountDTO> accounts = new List<AccountDTO>();

            using (LibManDataContext db = new LibManDataContext())
            {
                var query = from acc in db.Accounts select acc;

                foreach (var row in query)
                {
                    AccountDTO account = new AccountDTO
                    {
                        Username = row.Username,
                        Password = row.Password,
                        AccountTypeID = row.AccountTypeID,
                        Fullname = row.Fullname,
                        Birthday = row.Birthday,
                        Gender = row.Gender,
                        UserID = row.UserID,
                        Address = row.Address
                    };

                    accounts.Add(account);
                }
            }
            
            return accounts;
        }

        public static void CreateAccount(string username, string password, int accountTypeID, string fullname
                                            , DateTime birthday, bool gender, string userID, string address)
        {
            using(LibManDataContext context = new LibManDataContext())
            {
                Account account = new Account
                {
                    Username = username,
                    Password = password,
                    AccountTypeID = accountTypeID,
                    Fullname = fullname,
                    Birthday = birthday,
                    Gender = gender,
                    UserID = userID,
                    Address = address
                };

                context.Accounts.InsertOnSubmit(account);
                context.SubmitChanges();
            }
        }

        public static Account GetAccount(string usernameOrUserID, bool isUserIDField = false)
        {
            using(LibManDataContext context = new LibManDataContext())
            {
                string field = usernameOrUserID;
                var query = from acc in context.Accounts where acc.Username == field select acc;
                
                if (isUserIDField)
                {
                    query = from acc in context.Accounts where acc.UserID == field select acc;
                }

                return query.FirstOrDefault();
            }
        }
    }
}
