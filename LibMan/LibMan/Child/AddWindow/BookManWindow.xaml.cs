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

namespace GUI.Child.AddWindow
{
    /// <summary>
    /// Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class BookManWindow : Window
    {
        private readonly int _bookID;
        public BookManWindow(string title)
        {
            InitializeComponent();
            Title = title;
            txtTitle.Focus();
            cbxCatalog_Load();
        }

        public BookManWindow(string title, BookDTO book)
        {
            InitializeComponent();
            Title = title;
            txtTitle.Focus();
            _bookID = book.ID;
            cbxCatalog_Load();
            LoadTextElements(book);
        }

        public void LoadTextElements(BookDTO book)
        {
            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            cbxCatalog.Text = book.Catalog; 
            txtPublisher.Text = book.Publisher;
        }

        public void cbxCatalog_Load()
        {
            cbxCatalog.ItemsSource = BookBLL.GetBookList();
            cbxCatalog.DisplayMemberPath = "Catalog";
            //cbxCatalog.SelectedValuePath = "Catalog";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            bool successful;

            if (Title.Equals("Thêm sách"))
            {
                successful = BookBLL.AddBook(txtTitle.Text, cbxCatalog.Text, txtAuthor.Text, txtPublisher.Text);
            }
            else
            {
                successful = BookBLL.UpdateBook(_bookID, txtTitle.Text, cbxCatalog.Text, txtAuthor.Text, txtPublisher.Text);
            }

            if (successful)
            {
                MessageBox.Show("Thành công!", Title, MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Thất bại, vui lòng điền đầy đủ thông tin!", Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
