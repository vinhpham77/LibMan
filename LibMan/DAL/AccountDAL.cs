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
        public static List<AccountDTO> GetAccountList(string keyword = "")
        {
            List<AccountDTO> list = new List<AccountDTO>();
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = string.IsNullOrEmpty(keyword)
                                ? context.Accounts
                                : context.Accounts.Where(acc => acc.Fullname.Contains(keyword) 
                                  || acc.Username.Contains(keyword) 
                                  || acc.ID.Contains(keyword));

                AccountDTO account;
                foreach (var row in query)
                {
                    account = new AccountDTO()
                    { 
                        Username = row.Username,
                        Password = row.Password,
                        RoleID = row.RoleID,
                        Fullname = row.Fullname,
                        Birthday = row.Birthday,
                        Gender = row.Gender,
                        ID = row.ID,
                        Address = row.Address,
                        Status = row.Status
                    };
                    list.Add(account);
                }
                return list;
            }
        }

        public static List<string> GetUsernameList()
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                return context.Accounts.Select(acc => acc.Username).ToList();
            }
        }

        public static void CreateAccount(string username, string password, int roleID, string fullname
                                            , DateTime birthday, bool? gender, string id, string address, bool status)
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
                    Address = address,
                    Status = status
                };

                context.Accounts.InsertOnSubmit(account);
                context.SubmitChanges();
            }
        }

        public static Account GetAccount(string username)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                return context.Accounts.Where(a => a.Username.Equals(username)).FirstOrDefault();                
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

        public static void UpdateAccount(string username, int roleID, string fullname,
                                            DateTime birthday, bool gender, string id, string address)
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
                    acc.RoleID = roleID;
                    acc.Fullname = fullname;
                    acc.Birthday = birthday;
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

        public static int GetRoleID(string username)
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
                    return acc.RoleID;
                }
            }
        }
    }
}
