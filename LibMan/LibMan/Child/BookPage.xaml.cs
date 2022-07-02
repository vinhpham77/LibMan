using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using BLL;

namespace GUI.Child
{
    public partial class BookPage : Page
    {
        public BookPage()
        {
            InitializeComponent();
            dtgBook_Load();
        }

        private void dtgBook_Load(string keywords = "")
        {
            dtgBook.ItemsSource = BookCatalogBLL.GetBookCatalogs(keywords);
        }

        private void txtBookSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key is Key.Enter)
            {
                string keywords = txtBookSearch.Text.Trim();
                dtgBook_Load(keywords);
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtBookSearch.Clear();
            dtgBook_Load();
        }
    }
}
