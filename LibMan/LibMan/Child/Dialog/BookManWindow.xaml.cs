using System;
using System.Windows;
using BLL;
using DTO;

namespace GUI.Child.Dialog
{
    public partial class BookManWindow : Window
    {
        private readonly int _bookID;

        public BookManWindow()
        {
            InitializeComponent();
            Title = "Thêm sách";
            _bookID = 0;
            cbxCatalog_Load();
            txtTitle.Focus();
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
            cbxCatalog.ItemsSource = CatalogBLL.GetCatalogs();
            cbxCatalog.DisplayMemberPath = "Name";
            cbxCatalog.SelectedValuePath = "ID";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string title = txtTitle.Text.Trim();
            var catalogID = cbxCatalog.SelectedValue as int?;
            string author = txtAuthor.Text.Trim();
            string publisher = txtPublisher.Text.Trim();

            try
            {
                if (_bookID == 0)
                {
                   BookBLL.AddBook(title, catalogID, author, publisher);
                }
                else
                {
                    BookBLL.UpdateBook(_bookID, title, catalogID, author, publisher);
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
