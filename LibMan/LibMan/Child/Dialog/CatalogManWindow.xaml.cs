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
using System.Windows.Shapes;
using BLL;
using DTO;

namespace GUI.Child.Dialog
{
    /// <summary>
    /// Interaction logic for CatalogManWindow.xaml
    /// </summary>
    public partial class CatalogManWindow : Window
    {
        private readonly int _catalogID;
        public CatalogManWindow()
        {
            InitializeComponent();
            Title = "Thêm danh mục";
            _catalogID = 0;
        }

        public CatalogManWindow(CatalogDTO catalog)
        {
            InitializeComponent();
            Title = "Sửa danh mục";
            _catalogID = catalog.ID;
            txtCatalogName.Text = catalog.Name;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_catalogID == 0)
                {
                    string catalogName = txtCatalogName.Text.Trim();
                    CatalogBLL.CreateCatalog(catalogName);
                    if (Owner is BookManWindow bm)
                    {
                        bm.cbxCatalog_Load();
                        bm.cbxCatalog.Text = catalogName;
                    }
                }
                else
                {
                    CatalogBLL.UpdateCatalog(_catalogID, txtCatalogName.Text);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
