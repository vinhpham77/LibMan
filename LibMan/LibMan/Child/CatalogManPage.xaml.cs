using GUI.Child.Dialog;
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
using System.Collections.ObjectModel;

namespace GUI.Child
{
    /// <summary>
    /// Interaction logic for CatalogLibrarianPage.xaml
    /// </summary>
    public partial class CatalogManPage : Page
    {
        public CatalogManPage()
        {
            InitializeComponent();
            dtgCatalog_Load();
        }

        private void dtgCatalog_Load(string catalogName = "")
        {
            dtgCatalog.ItemsSource = CatalogBLL.GetCatalogList(catalogName);
        }
            
        private void txtCatalogSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dtgCatalog_Load(txtCatalogSearch.Text);
        }

        private void btnAddCatalog_Click(object sender, RoutedEventArgs e)
        {
            CatalogManWindow addCatalog = new CatalogManWindow();
            addCatalog.ShowDialog();
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
                                            title, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result is MessageBoxResult.Yes)
            {
                try
                {
                   CatalogBLL.DeleteCatalog(catalog.ID);
                   dtgCatalog_Load(txtCatalogSearch.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtCatalogSearch.TextChanged -= txtCatalogSearch_TextChanged;
            txtCatalogSearch.Clear();
            dtgCatalog_Load();
            txtCatalogSearch.TextChanged += txtCatalogSearch_TextChanged;
        }
    }
}
