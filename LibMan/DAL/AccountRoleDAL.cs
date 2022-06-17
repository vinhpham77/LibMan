using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class AccountRoleDAL
    {
        public static List<AccountRoleDTO> GetAccountRoleList(string username = "")
        {
            List<AccountRoleDTO> list = new List<AccountRoleDTO>();
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = from u in context.Accounts 
                            join r in context.Roles on u.RoleID equals r.ID 
                            where u.Username.Contains(username)
                            select new {u, r};
                AccountRoleDTO accountRole;
                foreach (var item in query)
                {
                    accountRole = new AccountRoleDTO(item.u, item.r);
                    list.Add(accountRole);
                }

                return list;
            }    
        }
    }
}
