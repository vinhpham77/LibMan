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

        public static Account GetAccount(string username)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                return context.Accounts.Where(acc => acc.Username.Equals(username)).FirstOrDefault();
            }
        }

        public static void DeleteAccount(string username)
        {
            using(LibManDataContext context = new LibManDataContext())
            {
                var acc = context.Accounts.Where(a => a.Username.Equals(username)).FirstOrDefault();
                
                if (acc is null)
                {
                    throw new Exception($"Không tồn tại tài khoản '{username}' trong hệ thống!");
                }
                else
                {
                    context.Accounts.DeleteOnSubmit(acc);
                    context.SubmitChanges();
                }
            }
        }

        public static void UpdateAccount(string username, string fullname, string birthday, bool gender, string id, string address)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                var acc = context.Accounts.Where(a => a.Username.Equals(username)).FirstOrDefault();
                
                if (acc is null)
                {
                    throw new Exception($"Không tồn tại tài khoản '{username}' trong hệ thống!");
                }
                else
                {
                    acc.Fullname = fullname;
                    acc.Birthday = Convert.ToDateTime(birthday);
                    acc.Gender = gender;
                    acc.ID = id;
                    acc.Address = address;

                    context.SubmitChanges();
                }
            }
        }

        public static void ChangeStatus(string username, bool status)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                var acc = context.Accounts.Where(a => a.Username.Equals(username)).FirstOrDefault();
                
                if (acc is null)
                {
                    throw new Exception($"Không tồn tại tài khoản '{username}' trong hệ thống!");
                }
                else
                {
                    acc.Status = status;
                    context.SubmitChanges();
                }
            }
        }

        public static void ChangePassword(string username, string newPassword)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                var acc = context.Accounts.Where(a => a.Username.Equals(username)).FirstOrDefault();
                if (acc is null)
                {
                    throw new Exception($"Không tồn tại tài khoản '{username}' trong hệ thống!");
                }
                else
                {
                    acc.Password = newPassword;
                    context.SubmitChanges();
                }
            }
        }

        public static AccountDTO CheckLogin(string username)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = context.Accounts.Where(acc => acc.Username.Equals(username)).Select(acc => new {acc.Username, acc.Password, acc.RoleID, acc.Status }).FirstOrDefault();

                Account account = new Account
                {
                    Username = query.Username,
                    Password = query.Password,
                    RoleID = query.RoleID,
                    Status = query.Status
                };

                return new AccountDTO(account);
            }
        }
    }
}
