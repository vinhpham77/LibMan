using System;
using System.Collections.Generic;
using DTO;
using DAL;

namespace BLL
{
    public class AccountBLL
    {
        public static List<AccountDTO> GetAccountList(string keyword = "")
        {
            return AccountDAL.GetAccountList(keyword);
        }

        public static List<string> GetUsernameList()
        {
            return AccountDAL.GetUsernameList();
        }

        public static void CreateAccount(string username, string password, string rePassword, int? roleID, string fullname
                                            , DateTime? birthday, bool gender, string id, string address, bool status)
        {
            string[] formInputs = { username, roleID.ToString(), password, rePassword, fullname, birthday.ToString(), id, address };
            ValidateRegister(formInputs);
            AccountDAL.CreateAccount(formInputs[0], password, (int)roleID, formInputs[4], (DateTime)birthday, gender, formInputs[6], formInputs[7], status);
        }

        public static Account GetAccount(string username)
        {
            return AccountDAL.GetAccount(username);
        }

        public static void UpdateAccount(string username, int roleID, string fullname, 
                                        string birthday, bool gender, string id, string address)
        {
            string[] fields = {username, fullname, birthday, id, address};
            for (int i = 0; i < fields.Length; i++)
            {
                fields[i] = fields[i].Trim();
                if (string.IsNullOrEmpty(fields[i]))
                {
                    throw new Exception("Vui lòng cung cấp đầy đủ thông tin!");
                }
            }

            AccountDAL.UpdateAccount(fields[0], roleID, fields[1], Convert.ToDateTime(fields[2]), gender, fields[3], fields[4]);
        }

        public static void ChangePassword(string username, string newPassword)
        {
            AccountDAL.ChangePassword(username, newPassword);
        }

        public static void CheckLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Vui lòng không để trống!");
            }

            Account account = AccountDAL.GetAccount(username);
            if (account is null)
            {
                throw new Exception("Tài khoản không tồn tại trong hệ thống!");
            }
            else if (!account.Password.Equals(password))
            {
                throw new Exception ("Sai mật khẩu!");
            }
            else if (account.Status is false)
            {
                throw new Exception("Tài khoản không có hiệu lực, vui lòng đợi cấp quyền hoặc liên hệ người có thẩm quyền!");
            }
        }

        public static int GetRoleID(string username)
        {            
            return AccountDAL.GetRoleID(username.Trim());
        }

        public static void ValidateRegister(string[] formInputs)
        {
            for (int i = 0; i < formInputs.Length; i++)
            {
                formInputs[i] = formInputs[i].Trim();
                if (string.IsNullOrEmpty(formInputs[i]))
                {
                    throw new Exception("Vui lòng cung cấp đủ thông tin!");
                }
            }

            string username = formInputs[0];
            if (GetAccount(username) != null)
            {
                throw new Exception("Tài khoản đã tồn tại!");
            }

            string pass = formInputs[2];
            string repass = formInputs[3];

            if (!pass.Equals(repass))
            {
                throw new Exception("Mật khẩu nhập lại không khớp với mật khẩu trước đó!");
            }

            string id = formInputs[6];
            if (!int.TryParse(id, out _))
            {
                throw new Exception("CMND/CCCD chỉ chứa các chữ số!");
            }
            if (GetAccount(id) != null)
            {
                throw new Exception("CCCD/CMND đã tồn tại!");
            }
        }

        public static void ChangeStatus(string username, bool status)
        {
            AccountDAL.ChangeStatus(username, status);
        }

        public static void DeleteAccount(string username)
        {
            AccountDAL.DeleteAccount(username);
        }
    }
}
