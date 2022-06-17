using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class AccountRoleBLL
    {
        public static List<AccountRoleDTO> GetAccountRoleList(string username = "")
        {
            return AccountRoleDAL.GetAccountRoleList(username);
        }
    }
}
