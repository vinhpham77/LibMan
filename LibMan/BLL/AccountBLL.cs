using System;
using System.Collections.Generic;
using DTO;
using DAL;

namespace BLL
{
    public class AccountBLL
    {
        public static List<AccountDTO> GetAccountList(string fullname = "", bool? status = null)
        {
            return AccountDAL.GetAccountList(fullname, status);
        }

/*        public static bool DeleteAccountApproval(string username)
        {
            Account acc = AccountDAL.GetAccount(username);

            if (acc is null)
            {
                return false;
            }
            else
            {
                AccountDAL.DeleteAccount(acc);
                return true;
            }
        }*/

        public static string CreateAccount(string username, string password, string rePassword, int roleID, string fullname
                                            , string birthday, bool? gender, string id, string address)
        {
            Account acc = GetAccount(username);
            
            if (acc != null)
            {
                return "Tài khoản đã được đăng ký trước đó";
            }

            username = username.Trim();
            fullname = fullname.Trim();
            id = id.Trim();
            address = address.Trim();
            string[] formInputs = { username, password, rePassword, fullname, birthday, id, address };
            string error = ValidateRegister(formInputs);
            if (error is null)
            {
                DateTime birth = Convert.ToDateTime(birthday);
                AccountDAL.CreateAccount(username, password, roleID, fullname, birth, gender, id, address);
            }

            return error;
        }

        //public static void ApproveAccount(Account acc)
        //{
        //    CreateAccount(acc.Username, acc.Password, acc.RoleID, acc.Fullname, acc.Birthday.ToString(),
        //                    (bool)acc.Gender, acc.ID, acc.Address);
        //}

        public static Account GetAccount(string usernameOrID, bool isID = false)
        {
            return AccountDAL.GetAccount(usernameOrID);
        }

        public static bool UpdateAccount(string username, string fullname, string birthday, bool gender, string id, string address)
        {
            Account acc = AccountDAL.GetAccount(username);
            if (acc is null)
            {
                return false;
            }
            else
            {
                AccountDAL.UpdateAccount(username, fullname, birthday, gender, id, address);
                return true;
            }
        }

        public static void ChangePassword(string username, string newPassword)
        {
            AccountDAL.ChangePassword(username, newPassword);
        }

        public static void CheckLogin(string username, string password)
        {
            username = username.Trim();
            password = password.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Vui lòng không để trống!");
            }

            AccountDTO account = AccountDAL.CheckLogin(username);
            if (account == null)
            {
                throw new Exception("Tài khoản không tồn tại trong hệ thống!");
            }
            else if (account.Password != password)
            {
                throw new Exception ("Sai mật khẩu!");
            }
            else if (account.Status == false)
            {
                throw new Exception("Tài khoản không có sẵn, vui lòng chờ hoặc liên hệ người có thẩm quyền!");
            }
        }

        public static int GetRoleID(string usernameOrID, bool isID = false)
        {
            string field = usernameOrID.Trim();
            return AccountDAL.GetAccount(field).RoleID;
        }

        public static string ValidateRegister(object[] formInputs)
        {
            foreach (var item in formInputs)
            {
                if (string.IsNullOrEmpty(item.ToString()))
                {
                    return "Vui lòng điền đầy đủ thông tin!";
                }
            }

            string username = formInputs[0].ToString();
            if (GetAccount(username) != null)
            {
                return "Tài khoản đã tồn tại!";
            }

            string pass = formInputs[1].ToString();
            string repass = formInputs[2].ToString();

            if (!pass.Equals(repass))
            {
                return "Mật khẩu nhập lại không khớp với mật khẩu trước đó!";
            }

            string id = formInputs[7].ToString();
            if (GetAccount(id, true) != null)
            {
                return "CCCD/CMND đã tồn tại!";
            }

            return null;
        }

        public static void ChangeStatus(string username, bool status)
        {
            AccountDAL.ChangeStatus(username, status);
        }
    }
}
