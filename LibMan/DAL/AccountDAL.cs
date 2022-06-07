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
                var query = context.Accounts.Where(acc => acc.Fullname.Contains(fullname));
                
                if (status != null)
                {
                    query = context.Accounts.Where(acc => acc.Fullname.Contains(fullname) && acc.Status == status);
                }

                foreach (var row in query)
                {
                    AccountDTO account = new AccountDTO
                    {
                        Username = row.Username,
                        Password = row.Password,
                        RoleID = row.RoleID,
                        Fullname = row.Fullname,
                        Birthday = row.Birthday,
                        Gender = row.Gender,
                        ID = row.ID,
                        Address = row.Address
                    };

                    accounts.Add(account);
                }
            }
            
            return accounts;
        }

        public static void CreateAccount(string username, string password, int roleID, string fullname
                                            , string birthday, bool gender, string id, string address)
        {
            using(LibManDataContext context = new LibManDataContext())
            {
                Account account = new Account
                {
                    Username = username,
                    Password = password,
                    RoleID = roleID,
                    Fullname = fullname,
                    Birthday = Convert.ToDateTime(birthday),
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
            using(LibManDataContext context = new LibManDataContext())
            {
                string field = usernameOrID;
                
                if (isID)
                {
                    return context.Accounts.Where(acc => acc.ID.Equals(field)).FirstOrDefault();
                } 
                else
                {
                    return context.Accounts.Where(acc => acc.Username.Equals(field)).FirstOrDefault();
                }
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

        public static string CheckLogin(string username, string password)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                Account account = context.Accounts.Where(acc => acc.Username.Equals(username)).FirstOrDefault();
                string message = null;

                if (account == null)
                {
                    message = "Tài khoản không tồn tại trong hệ thống!";
                }
                else if (account.Password != password)
                {
                    message = "Sai mật khẩu";
                } 
                else if (account.Status == false)
                {
                    message = "Tài khoản không có sẵn, vui lòng chờ hoặc liên hệ người có thẩm quyền";
                }

                return message;
            }
        }
    }
}
