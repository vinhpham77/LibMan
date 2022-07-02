using System;
using DTO;
using DAL;
using System.Collections.ObjectModel;

namespace BLL
{
    public class CatalogBLL
    {
        public static ObservableCollection<CatalogDTO> GetCatalogs(string catalogName = "")
        {
            return CatalogDAL.GetCatalogs(catalogName);
        }

        public static void CreateCatalog(string catalogName)
        {
            if (string.IsNullOrEmpty(catalogName))
            {
                throw new Exception("Vui lòng điền tên danh mục!");
            }
            else if (CatalogDAL.GetCatalog(catalogName) is null)
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
