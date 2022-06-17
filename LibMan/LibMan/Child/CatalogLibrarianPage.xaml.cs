using GUI.Child.AddWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BLL;
using DTO;

namespace GUI.Child
{
    /// <summary>
    /// Interaction logic for CatalogLibrarianPage.xaml
    /// </summary>
    public partial class CatalogLibrarianPage : Page
    {
        public CatalogLibrarianPage()
        {
            InitializeComponent();
            dtgCatalog_Load();
        }

        private void dtgCatalog_Load(string catalogName = "")
        {
            dtgCatalog.ItemsSource = CatalogBLL.GetCatalogList(catalogName);
        }
            
        private void btnAddCatalog_Click(object sender, RoutedEventArgs e)
        {
            CatalogManWindow addCatalog = new CatalogManWindow();
            addCatalog.ShowDialog();
        }

        private void txtCatalogSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string catalogName = txtCatalogSearch.Text;
            dtgCatalog_Load(catalogName);
        }

        private void btnEditCatalog_Click(object sender, RoutedEventArgs e)
        {
            CatalogManWindow catalog = new CatalogManWindow(dtgCatalog.SelectedItem as CatalogDTO);
            catalog.ShowDialog();
        }

        private void btnDeleteCatalog_Click(object sender, RoutedEventArgs e)
        {
            string title = "Xoá danh mục";
            CatalogDTO catalog = dtgCatalog.SelectedItem as CatalogDTO;
            MessageBoxResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá danh mục mã '{catalog.ID}' không?",
                                            title, MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                   CatalogBLL.DeleteCatalog(catalog.ID);
                    btnRefresh_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            dtgCatalog_Load();
            txtCatalogSearch.Clear();
        }
    }
}
