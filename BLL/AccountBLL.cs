using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class AccountBLL
    {
        public static List<AccountDTO> GetAccountList()
        {
            return AccountDAL.GetAccountList();
        }

        public static void CreateAccount(string username, string password, int accountTypeID, string fullname
                                            , DateTime birthday, bool gender, string userID, string address)
        {
            AccountDAL.CreateAccount(username, password, accountTypeID, fullname, birthday, gender, userID, address);
        }

        public static Account GetAccount(string usernameOrUserID, bool isUserID = false)
        {
            return AccountDAL.GetAccount(usernameOrUserID, isUserID);
        }

        public static bool CheckAccount(string username, string password = null)
        {
            return AccountDAL.CheckAccount(username, password);
        }
    }
}
