using DTO;
using DAL;
using System.Collections.ObjectModel;

namespace BLL
{
    public class AccountRoleBLL
    {
        public static ObservableCollection<AccountRoleDTO> GetAccountRoles(string keyword = "")
        {
            return AccountRoleDAL.GetAccountRoles(keyword.Trim());
        }
    }
}
