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
            return DAL.AccountDAL.GetAccountList();
        }

        public static void CreateAccount(string username, string password, int accountTypeID, string fullname
                                            , DateTime birthday, bool gender, string userID, string address)
        {
            DAL.AccountDAL.CreateAccount(username, password, accountTypeID, fullname, birthday, gender, userID, address);
        }

        public static Account GetAccount(string usernameOrUserID, bool isUserID = false)
        {
            return DAL.AccountDAL.GetAccount(usernameOrUserID, isUserID);
        }
    }
}
