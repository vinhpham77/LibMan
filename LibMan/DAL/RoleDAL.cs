using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class RoleDAL
    {
        public static List<RoleDTO> GetRoleList()
        {
            List<RoleDTO> roles = new List<RoleDTO>();

            using (LibManDataContext context = new LibManDataContext())
            {
                var query = context.Roles;
                
                foreach(var row in query)
                {
                    roles.Add(new RoleDTO(row));
                }

                return roles;
            }
        }
    }
}
