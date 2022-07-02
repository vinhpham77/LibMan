using System.Collections.Generic;
using DTO;
using DAL;

namespace BLL
{
    public class RoleBLL
    {
        public static List<RoleDTO> GetRoles()
        {
            return RoleDAL.GetRoles();
        }
    }
}
