using GUI.Child.Dialog;
using System;
using System.Windows;
using System.Windows.Controls;
using BLL;
using DTO;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace GUI.Child
{
    public partial class CatalogManPage : Page
    {
        private ObservableCollection<CatalogDTO> _data;

        public CatalogManPage()
        {
            InitializeComponent();
            dtgCatalog_Load();
        }

        private void dtgCatalog_Load(string keywords = "")
        {
            dtgCatalog.ItemsSource = _data = CatalogBLL.GetCatalogs(keywords);
        }

        private void txtCatalogSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key is Key.Enter)
            {
                string keywords = txtCatalogSearch.Text.Trim();
                dtgCatalog_Load(keywords);
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtCatalogSearch.Clear();
            dtgCatalog_Load();
        }

        private void btnAddCatalog_Click(object sender, RoutedEventArgs e)
        {
            var addCatalog = new CatalogManWindow();
            addCatalog.ShowDialog();
        }

        private void btnEditCatalog_Click(object sender, RoutedEventArgs e)
        {
            var item = dtgCatalog.SelectedItem as CatalogDTO;
            var catalog = new CatalogManWindow(item);
            catalog.ShowDialog();
        }

        private void btnDeleteCatalog_Click(object sender, RoutedEventArgs e)
        {
            string title = "Xoá danh mục";
            var catalog = dtgCatalog.SelectedItem as CatalogDTO;
            string message = string.Format($"Bạn có chắc chắn muốn xoá danh mục mã '{catalog.ID}' không?");
            var result = MessageBox.Show(message , title, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            
            if (result is MessageBoxResult.Yes)
            {
                try
                {
                   CatalogBLL.DeleteCatalog(catalog.ID);
                   _data.Remove(catalog);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
