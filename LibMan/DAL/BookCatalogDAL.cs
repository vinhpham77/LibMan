using System.Collections.ObjectModel;
using System.Linq;
using DTO;

namespace DAL
{
    public class BookCatalogDAL
    {
        public static ObservableCollection<BookCatalogDTO> GetBookCatalogs(string keywords = "")
        {
            var bookCatalogs = new ObservableCollection<BookCatalogDTO>();
            using (var context = new LibManDataContext())
            {
                var query = string.IsNullOrEmpty(keywords)
                            ? from b in context.Books
                              join c in context.Catalogs on b.CatalogID equals c.ID into bc
                              from bookcat in bc.DefaultIfEmpty()
                              select new { b.ID, b.Title, bookcat.Name, b.Author, b.Publisher }
                            : from b in context.Books 
                              join c in context.Catalogs on b.CatalogID equals c.ID into bc
                              from bookcat in bc.DefaultIfEmpty()
                              where b.Title.Contains(keywords) || b.Author.Contains(keywords)
                              select new {b.ID, b.Title, bookcat.Name, b.Author, b.Publisher};
                
                BookCatalogDTO bookCatalog;
                foreach (var item in query)
                {
                    bookCatalog = new BookCatalogDTO()
                    {
                        BookID = item.ID,
                        BookTitle = item.Title,
                        CatalogName = item.Name,
                        Author = item.Author,
                        Publisher = item.Publisher
                    };
                    bookCatalogs.Add(bookCatalog);
                }
                return bookCatalogs;
            }
        }
    }
}
