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
        public static List<AccountRoleDTO> GetAccountRoleList(string keyword = "")
        {
            List<AccountRoleDTO> list = new List<AccountRoleDTO>();
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = string.IsNullOrEmpty(keyword) ?
                                from u in context.Accounts 
                                join r in context.Roles on u.RoleID equals r.ID 
                                select new {u, r.Name}
                                :
                                from u in context.Accounts
                                join r in context.Roles on u.RoleID equals r.ID
                                where u.Username.Contains(keyword) || u.ID.Contains(keyword) || u.Fullname.Contains(keyword)
                                select new {u, r.Name};

                AccountRoleDTO ar;
                foreach (var row in query)
                {
                    Account acc = row.u;
                    ar = new AccountRoleDTO()
                    {
                        Username = acc.Username,
                        Password = acc.Password,
                        RoleName = row.Name,
                        Fullname = acc.Fullname,
                        Birthday = acc.Birthday,
                        Gender = acc.Gender,
                        ID = acc.ID,
                        Address = acc.Address,
                        Status = acc.Status
                    };
                    list.Add(ar);
                }

                return list;
            }    
        }
    }
}
