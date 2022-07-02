using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class RoleDAL
    {
        public static List<RoleDTO> GetRoles()
        {
            var roles = new List<RoleDTO>();

            using (var context = new LibManDataContext())
            {
                RoleDTO role;
                foreach (var row in context.Roles)
                {
                    role = new RoleDTO()
                    {
                        ID = row.ID,
                        Name = row.Name
                    };

                    roles.Add(role);
                }

                return roles;
            }
        }
    }
}
