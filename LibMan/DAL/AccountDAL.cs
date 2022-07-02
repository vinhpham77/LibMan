using System;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class AccountDAL
    {
        public static List<AccountDTO> GetAccounts(string keyword = "")
        {
            var accounts = new List<AccountDTO>();
            using (var context = new LibManDataContext())
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

                    accounts.Add(account);
                }

                return accounts;
            }
        }

        public static List<string> GetUsernames()
        {
            using (var context = new LibManDataContext())
            {
                return context.Accounts.Select(acc => acc.Username).ToList();
            }
        }

        public static void CreateAccount(string username, string password, int roleID, 
                                            string fullname, DateTime birthday, bool? gender,
                                            string id, string address, bool status)
        {
            using (var context = new LibManDataContext())
            {
                var account = new Account
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

        public static Account GetAccount(string usernameOrID, bool isID = false)
        {
            using (var context = new LibManDataContext())
            {
                string field = usernameOrID;
                var query = isID ? context.Accounts.FirstOrDefault(a => a.ID.Equals(field))
                                 : context.Accounts.FirstOrDefault(a => a.Username.Equals(field));
                return query;
            }
        }

        public static void DeleteAccount(string username)
        {
            using(var context = new LibManDataContext())
            {
                var acc = context.Accounts.FirstOrDefault(a => a.Username.Equals(username));
                
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
            using (var context = new LibManDataContext())
            {
                var acc = context.Accounts.FirstOrDefault(a => a.Username.Equals(username));
                
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

        public static void ChangeStatus(string username)
        {
            using (var context = new LibManDataContext())
            {
                var acc = context.Accounts.FirstOrDefault(a => a.Username.Equals(username));
                if (acc is null)
                {
                    throw new Exception($"Không tồn tại tài khoản '{username}' trong hệ thống!");
                }
                else
                {
                    acc.Status = !acc.Status;
                    context.SubmitChanges();
                }
            }
        }

        public static void ChangePassword(string username, string newPassword)
        {
            using (var context = new LibManDataContext())
            {
                var acc = context.Accounts.FirstOrDefault(a => a.Username.Equals(username));

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
    }
}
