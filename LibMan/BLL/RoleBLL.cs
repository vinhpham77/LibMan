using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class RoleBLL
    {
        public static List<RoleDTO> GetRoleList()
        {
            return RoleDAL.GetRoleList();
        }
    }
}
