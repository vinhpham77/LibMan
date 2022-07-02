using DTO;
using DAL;
using System.Collections.ObjectModel;

namespace BLL
{
    public class BookCatalogBLL
    {
        public static ObservableCollection<BookCatalogDTO> GetBookCatalogs(string keywords = "")
        {
            return BookCatalogDAL.GetBookCatalogs(keywords);
        }
    }
}
