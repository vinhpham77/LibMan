using System;
using System.Collections.ObjectModel;
using System.Linq;
using DTO;

namespace DAL
{
    public class CatalogDAL
    {
        public static ObservableCollection<CatalogDTO> GetCatalogs(string catalogName = "")
        {
            var catalogs = new ObservableCollection<CatalogDTO>();  
            using (var context = new LibManDataContext())
            {
                var query = string.IsNullOrEmpty(catalogName)
                            ? context.Catalogs
                            : context.Catalogs.Where(cat => cat.Name.Contains(catalogName));
                
                CatalogDTO catalog;
                foreach (var row in query)
                {
                    catalog = new CatalogDTO()
                    {
                        ID = row.ID,
                        Name = row.Name
                    };
                    catalogs.Add(catalog);
                }
                return catalogs;
            }
        }

        public static void CreateCatalog(string catalogName)
        {
            using (var context = new LibManDataContext())
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
            using (var context = new LibManDataContext())
            {
                return context.Catalogs.FirstOrDefault(c => c.Name.Equals(catalogName));
            }
        }

        public static Catalog GetCatalog(int catalogID)
        {
            using (var context = new LibManDataContext())
            {
                return context.Catalogs.FirstOrDefault(c => c.ID == catalogID);
            }
        }

        public static void DeleteCatalog(int catalogID)
        {
            using (var context = new LibManDataContext())
            {
                var catalog = context.Catalogs.FirstOrDefault(c => c.ID == catalogID);
                
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
            using (var context = new LibManDataContext())
            {
                var catalog = context.Catalogs.FirstOrDefault(c => c.ID == catalogID);

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
