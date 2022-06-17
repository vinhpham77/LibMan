using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CatalogDAL
    {
        public static List<CatalogDTO> GetCatalogList(string catalogName = "")
        {
            List<CatalogDTO> catalogs = new List<CatalogDTO>();
            using (LibManDataContext context = new LibManDataContext())
            {
                var query = context.Catalogs.Where(cat => cat.Name.Contains(catalogName));
                foreach (var row in query)
                {
                    catalogs.Add(new CatalogDTO(row));
                }
            }

            return catalogs;
        }

        public static void CreateCatalog(string catalogName)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                Catalog catalog = new Catalog
                {
                    Name = catalogName
                };

                context.Catalogs.InsertOnSubmit(catalog);
                context.SubmitChanges();
            }
        }

        public static Catalog GetCatalog(string catalogName)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                return context.Catalogs.Where(c => c.Name.Equals(catalogName)).FirstOrDefault();
            }
        }

        public static Catalog GetCatalog(int catalogID)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                return context.Catalogs.Where(c => c.ID == catalogID).FirstOrDefault();
            }
        }

        public static void DeleteCatalog(int catalogID)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                var catalog = context.Catalogs.Where(c => c.ID == catalogID).FirstOrDefault();
                if (catalog is null)
                {
                    throw new Exception($"Không tồn tại danh mục mã '{catalogID}' trong hệ thống!");
                }
                else
                {
                    context.Catalogs.DeleteOnSubmit(catalog);
                    context.SubmitChanges();
                }
            }
        }

        public static void UpdateCatalog(int catalogID, string catalogName)
        {
            using (LibManDataContext context = new LibManDataContext())
            {
                var catalog = context.Catalogs.Where(c => c.ID == catalogID).FirstOrDefault();
                if (catalog is null)
                {
                    throw new Exception($"Không tồn tại danh mục mã '{catalogID}' trong hệ thống!");
                }
                else
                {
                    catalog.Name = catalogName;
                    context.SubmitChanges();
                }
            }
        }
    }
}
