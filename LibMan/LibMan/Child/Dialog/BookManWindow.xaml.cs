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
    /// Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class BookManWindow : Window
    {
        private readonly int _bookID;

        public BookManWindow()
        {
            InitializeComponent();
            Title = "Thêm sách";
            _bookID = 0;
            cbxCatalog_Load();
        }

        public BookManWindow(BookCatalogDTO bc)
        {
            InitializeComponent();
            Title = "Sửa sách";
            _bookID = bc.BookID;
            cbxCatalog_Load();
            cbxCatalog.Text = bc.CatalogName;
            LoadTextBoxes(bc);
        }

        public void LoadTextBoxes(BookCatalogDTO bc)
        {
            txtTitle.Text = bc.BookTitle;
            txtAuthor.Text = bc.Author;
            txtPublisher.Text = bc.Publisher;
        }

        public void cbxCatalog_Load()
        {
            cbxCatalog.ItemsSource = CatalogBLL.GetCatalogList();
            cbxCatalog.DisplayMemberPath = "Name";
            cbxCatalog.SelectedValuePath = "ID";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_bookID == 0)
                {
                   BookBLL.AddBook(txtTitle.Text, cbxCatalog.SelectedValue as int?, txtAuthor.Text, txtPublisher.Text);
                }
                else
                {
                    BookBLL.UpdateBook(_bookID, txtTitle.Text, cbxCatalog.SelectedValue as int?, txtAuthor.Text, txtPublisher.Text);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAddCatalog_Click(object sender, RoutedEventArgs e)
        {
            CatalogManWindow catalogMan = new CatalogManWindow();
            catalogMan.Owner = this;
            catalogMan.ShowDialog();
        }
    }
}
