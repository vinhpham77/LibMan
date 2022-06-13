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
        public static List<AccountDTO> GetAccountList(string fullname = "", bool? status = null)
        {
            List<AccountDTO> accounts = new List<AccountDTO>();

            using (LibManDataContext context = new LibManDataContext())
            {
                var query = status is null ? context.Accounts.Where(acc => acc.Fullname.Contains(fullname)) 
                                           : context.Accounts.Where(acc => acc.Fullname.Contains(fullname) && acc.Status == status);

                foreach (var row in query)
                {
                    accounts.Add(new AccountDTO(row));
                }
            }
            
            return accounts;
        }

        public static void CreateAccount(string username, string password, int roleID, string fullname
                                            , DateTime birthday, bool? gender, string id, string address)
        {
            using(LibManDataContext context = new LibManDataContext())
            {
                Account account = new Account
                {
                    Username = username,
                    Password = password,
                    RoleID = roleID,
                    Fullname = fullname,
                    Birthday = birthday,
                    Gender = gender,
                    ID = id,
                    Address = address
                };

                context.Accounts.InsertOnSubmit(account);
                context.SubmitChanges();
            }
        }

        public static Account GetAccount(string usernameOrID, bool isID = false)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                string field = usernameOrID;
                var account = isID ? context.Accounts.Where(acc => acc.ID.Equals(field)).FirstOrDefault()
                                   : context.Accounts.Where(acc => acc.Username.Equals(field)).FirstOrDefault();

                return account;
            }
        }

        public static void DeleteAccount(Account acc)
        {
            using(LibManDataContext context = new LibManDataContext())
            {
                context.Accounts.DeleteOnSubmit(acc);
            }
        }

        public static bool UpdateAccount(string username, string fullname, string birthday, bool gender, string id, string address)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                Account account = GetAccount(username);

                if (account != null)
                {
                    account.Fullname = fullname;
                    account.Birthday = Convert.ToDateTime(birthday);
                    account.Gender = gender;
                    account.ID = id;
                    account.Address = address;

                    context.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool ChangeStatus(string usernameOrID, bool status, bool isID = false)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                Account account = GetAccount(usernameOrID, isID);

                if (account != null)
                {
                    account.Status = status;

                    context.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool ChangePassword(string username, string newPassword)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                Account account = GetAccount(username);

                if (account != null)
                {
                    account.Password = newPassword;
                    context.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
