using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class CatalogBLL
    {
        public static List<CatalogDTO> GetCatalogList(string catalogName = "")
        {
            return CatalogDAL.GetCatalogList(catalogName.Trim());
        }

        public static void CreateCatalog(string catalogName)
        {
            catalogName = catalogName.Trim();
            if (string.IsNullOrEmpty(catalogName))
            {
                throw new Exception("Vui lòng điền tên danh mục!");
            }
            
            if (CatalogDAL.GetCatalog(catalogName) is null)
            {
                CatalogDAL.CreateCatalog(catalogName);
            }
            else
            {
                throw new Exception($"Đã tồn tại danh mục {catalogName} trong hệ thống!");
            }
        }

        public static void DeleteCatalog(int catalogID)
        {
            CatalogDAL.DeleteCatalog(catalogID);
        }

        public static void UpdateCatalog(int catalogID, string catalogName)
        {
            catalogName = catalogName.Trim();
            if (string.IsNullOrEmpty(catalogName))
            {
                throw new Exception("Vui lòng điền tên danh mục!");
            }
            else
            {
                CatalogDAL.UpdateCatalog(catalogID, catalogName);
            }
        }
    }
}
