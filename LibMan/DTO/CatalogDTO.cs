using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CatalogDTO
    {
        public int ID { get; set; }        
        public string Name { get; set; }
        
        public CatalogDTO(Catalog catalog)
        {
            ID = catalog.ID;
            Name = catalog.Name;
        }
    }

}
