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
            List<RoleDTO> list = new List<RoleDTO>();
            using (LibManDataContext context = new LibManDataContext())
            {
                RoleDTO role;
                foreach (var row in context.Roles)
                {
                    role = new RoleDTO()
                    {
                        ID = row.ID,
                        Name = row.Name
                    };
                    list.Add(role);
                }

                return list;
            }
        }
    }
}
