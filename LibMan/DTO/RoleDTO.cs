using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public RoleDTO(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public RoleDTO(Role role)
        {
            ID = role.ID;
            Name = role.Name;
        }
    }

}
