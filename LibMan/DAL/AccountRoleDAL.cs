using System.Collections.ObjectModel;
using System.Linq;
using DTO;

namespace DAL
{
    public class AccountRoleDAL
    {
        public static ObservableCollection<AccountRoleDTO> GetAccountRoles(string keyword = "")
        {
            var accRoles = new ObservableCollection<AccountRoleDTO>();
            using (var context = new LibManDataContext())
            {
                var query = string.IsNullOrEmpty(keyword) 
                                ? from u in context.Accounts 
                                  join r in context.Roles on u.RoleID equals r.ID 
                                  select new {u, r.Name}
                                : from u in context.Accounts
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
                    accRoles.Add(ar);
                }
                return accRoles;
            }    
        }
    }
}
